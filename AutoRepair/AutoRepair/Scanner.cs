namespace AutoRepair {
    using AutoRepair.Catalogs;
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using AutoRepair.Lists;
    using AutoRepair.Util;
    using ColossalFramework;
    using ColossalFramework.PlatformServices;
    using ColossalFramework.Plugins;
    using ICities;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;
    using UnityEngine;
    using static ColossalFramework.Plugins.PluginManager;

    /// <summary>
    ///  This is what acutally runs the scan and currently just dumps results to log file.
    /// </summary>
    public class Scanner {

        internal const string LOCAL_MOD_STR = "(local)";
        internal const string BUNDLED_MOD_STR = "(bundled)";

        /// <summary>
        /// Gets a value indicating whether the Steam Workshop is available.
        /// </summary>
        private static bool SteamWorkshopAvailable => PlatformService.platformType == PlatformType.Steam && !PluginManager.noWorkshop;

        /// <summary>
        /// Performs the compatibility scan.
        /// </summary>
        public static void PerformScan() {

            if (!SteamWorkshopAvailable) {
                Log.Info("Steam Workshop is not online; unable to perform compatibility scan.");
                return;
            }

            try {
                Stopwatch timer = Stopwatch.StartNew();

                Log.Reset();
                Log.Info($"\nLoaded {Catalog.Instance.Count} AutoRepair Descriptors.");

                DoScan();

                timer.Stop();
                Log.Info($"\nAutoRepair scanned {subscriptions.Count} items in {timer.ElapsedMilliseconds}ms");

                subscriptions.Clear();
            }
            catch (Exception e) {
                Log.Info("Failure...");
                Log.Error(e.ToString());
            }
            finally {
                Catalog.Close();
            }
        }

        /// <summary>
        /// Maps subscribed mods to their names.
        /// </summary>
        private static Dictionary<ulong, string> subscriptions;

        /// <summary>
        /// Scans the subscribed mods for issues.
        /// </summary>
        private static void DoScan() {

            StringBuilder log = new StringBuilder(1024 * 100);

            log.Append("\nGeneral Announcements:\n");

            if (Announcements.Notes.Count > 0) {
                foreach (KeyValuePair<ulong, string> entry in Announcements.Notes) {
                    log.AppendFormat("\n* {0} - {1}\n",
                    entry.Value,
                    GetWorkshopURL(entry.Key));
                }
            }

            log.Append("\n* Save game not loading? Subscribe Loading Screen Mod,\nenable it's sharing/optimisation and safe mode options, then load your save.\n https://steamcommunity.com/sharedfiles/filedetails/?id=667342976\n");

            if (Options.Instance.LogIntroText) {
                log.Append("\nThings to know about mods:\n");
                log.Append("\n* Disabled mods are often still loaded; always unsubscribe mods you're not using!");
                log.Append("\n* Mods that do the same thing are generally incompatible.");
                log.Append("\n* For modded games, always exit to desktop before loading another city.");
                log.Append("\n* After disabling/unsubscribing mods, always exit to desktop to flush them from RAM\n");
            }

            log.Append("\n* If you find any problems in the report below, _please_ let us know what the specific problem is.\n");

            PluginManager manager = Singleton<PluginManager>.instance;

            // list of all subscribed, local and bundled mods (incl. camera scripts)
            List<PluginInfo> plugins = new List<PluginInfo>(manager.modCount);

            plugins.AddRange(manager.GetPluginsInfo()); // normal mods
            plugins.AddRange(manager.GetCameraPluginInfos()); // camera scripts

            // workshop id
            ulong modId;

            // id and name
            string strName;

            // list of subscribed mod workshop ids -> names
            if (subscriptions == null) {
                subscriptions = new Dictionary<ulong, string>();
            } else {
                subscriptions.Clear();
            }

            log.Append("\nSscanning...\n");

            // populate list of subscribed mod workshop ids
            foreach (PluginInfo plugin in plugins) {
                try {
                    if (!IsLocal(plugin) && !(plugin?.isBuiltin ?? false)) {
                        modId = plugin.publishedFileID.AsUInt64;
                        strName = GetPluginName(plugin);
                        if (!subscriptions.ContainsKey(modId)) {
                            subscriptions.Add(modId, strName);
                        }
                    }
                } catch (Exception e) {
                    UnityEngine.Debug.LogError(e);
                }
            }

            /*
            foreach (var modEntry in PluginManager.instance.GetPluginsInfo().Select(pi => new EntryData(pi))
            {
                var updated = modEntry.updated;
            }
            */

            foreach (PluginInfo plugin in plugins) {
                try {
                    ScanMod(plugin, ref log);
                } catch (Exception e) {
                    UnityEngine.Debug.LogError(e);
                }
            }

            log.Append("\nSCAN COMPLETE.\n");

            log.Append("\nOudated information? Please let us know! https://steamcommunity.com/sharedfiles/filedetails/?id=2034713132 \n"); // todo

            log.Append("\nDid it help? Please rate/comment the compatibility checker mod in the workshop to help others find it.");

            Log.Info(log.ToString());
        }

        private static void ScanMod(PluginInfo plugin, ref StringBuilder log) {
            bool isLocal = IsLocal(plugin);
            bool isVanilla = plugin?.isBuiltin ?? false;
            bool isEnabled = plugin?.isEnabled ?? false;

            // todo: translate vanilla mods to their fake ids (see Catalog.Vanilla.cs)
            ulong modId = plugin?.publishedFileID.AsUInt64 ?? 0u;

            string strId = isVanilla
                ? BUNDLED_MOD_STR
                : isLocal
                    ? LOCAL_MOD_STR
                    : modId.ToString();

            string strName = GetPluginName(plugin);

            log.Append("\n");
            log.Append('-', 75);
            log.AppendFormat("\n[ID: {0}] \"{1}\":\n", strId, strName);

            // todo: find a decent way to identify local mods
            if (isLocal || isVanilla) {
                log.Append(" - Bundled/local mods not scanned.\n");
                return;
            }

            if (!isEnabled) {
                log.Append("\n - It is disabled; if not using it, it should be unsubscribed.\n");
            }

            if (!Catalog.Instance.Has(modId)) {
                log.Append("\n - Should be compatible with current game version (if not, let us know).\n");

                // best wait until we have mode descriptors otherwise it will result in flood of spam!
                //log.Append("\n - It would be helpful if you could copy and paste the mod id/name above\n");
                //log.Append("   to the Compatibility Checker workshop page linked at top of log file.\n");
                if (Options.Instance.LogWorkshopURLs) {
                    log.AppendFormat("\n - Workshop page: {0}\n", GetWorkshopURL(modId));
                }

                return;
            }

            if (Catalog.Instance.TryGetValue(modId, out var item)) {

                if (item.Compatibility == null) {
                    item.Compatibility = new Dictionary<ulong, Status>();
                }

                if (Options.Instance.LogDescriptorHeaders) {
                    log.AppendFormat(
                        "\n - [AutoRepair Descriptor] Catalog: '{0}'. Vectors: {1}. Author(s): {2}\n",
                        item.Catalog,
                        item.Compatibility.Count,
                        item.Authors);
                }

                Version gameVersion = GameVersion.Active;

                if (item.HasFlag(ItemFlags.GameBreaking)) {

                    log.Append("\n - Broken mod. Unsubscribe it.\n");

                } else if (item.BrokenBy != null && gameVersion >= item.BrokenBy) {

                    log.Append("\n - Not compatible with current game version. Disable it until an update is ready.\n");

                } else if (item.CompatibleWith != null && GameVersion.LatestMilestone <= item.CompatibleWith) {

                    log.AppendFormat(
                        "\n - Compatible with Cities: Skylines v{0}-f{1} :)\n",
                        gameVersion.ToString(3),
                        gameVersion.Revision);

                } else {

                    log.Append("\n - Should be compatible with current game version (if not, let us know).\n");
                }

                if (Options.Instance.LogWorkshopURLs) {
                    if (item.HasFlag(ItemFlags.NoWorkshop)) {
                        log.Append("\n - Removed from Steam Workshop; it is probably obsolete or game breaking.\n");
                    } else {
                        log.AppendFormat("\n - Workshop page for this mod: {0}\n", GetWorkshopURL(modId));
                    }
                }

                if (item.HasFlag(ItemFlags.EditorBreaking)) {
                    log.Append("\n - Causes problems in content editors; before using editors, disable it and exit to desktop to flush it from RAM.\n");
                }

                if (item.HasFlag(ItemFlags.Abandonware)) {
                    log.Append("\n - The author hasn't been active for a long time, updates unlikely.\n");
                }

                if (item.HasFlag(ItemFlags.Streamable)) {
                    log.Append("\n - This music is safe for streaming (according to author / music source).\n");
                } else if (item.Compatibility.TryGetValue(422934383u, out var music)) {
                    if (music == Status.Required) {
                        log.Append("\n - Not safe for streaming (copyrighted music).\n");
                    }
                }

                if (item.HasFlag(ItemFlags.Laggy)) {
                    log.Append("\n - May cause some lag or framerate drop in-game.\n");
                }

                if (item.HasFlag(ItemFlags.SlowLoad)) {
                    log.Append("\n - Likely to significantly increase load times.\n");
                }

                if (item.HasFlag(ItemFlags.LargeFileWarning)) {
                    log.Append("\n - Large file size compared to other items of same type.\n");
                }

                if (item.HasFlag(ItemFlags.MinorBugs)) {
                    log.Append("\n - Minor issues - check workshop page/comments for details.\n");
                }

                if (item.HasFlag(ItemFlags.SaveChanging)) {
                    log.Append("\n - Alters the save game; without it, the savegame might break.\n");
                }

                if (item.HasFlag(ItemFlags.Unreliable)) {
                    log.Append("\n - Some users report problems; check workshop page/comments for details.\n");
                }

                if (Options.Instance.LogLanguages) {
                    if (item.Languages != null) {
                        log.AppendFormat(
                            "\n - Contains locales: {0}\n",
                            string.Join(", ", Locale.FromStringArray(item.Languages).ToArray()));
                    }
                    log.AppendFormat("\n - Primary locale: {0}\n", Locale.ToString(item.Locale));
                }

                if (Options.Instance.LogSourceURLs) {
                    if (item.HasFlag(ItemFlags.SourceAvailable)) {
                        if (!string.IsNullOrEmpty(item.SourceURL)) {
                            log.AppendFormat("\n - Source available: {0}\n", item.SourceURL);
                        }
                    } else if (item.HasFlag(ItemFlags.SourceBundled)) {
                        log.Append("\n - Source is bundled in its 'Source' folder.\n");

                        if (Application.platform == RuntimePlatform.OSXPlayer) {
                            log.Append("\n - Mac users: If this item doesn't contain a pre-compiled '.dll' file, it might not work on OS/X.\n");
                        }
                    } else if (item.HasFlag(ItemFlags.SourceUnavailable)) {
                        // todo: check for `Source` folder in mod folder
                        log.Append("\n - No source code/files found (yet); future updates will be difficult.\n");
                    }
                }

                if (item.HasFlag(ItemFlags.SourceObfuscated)) {
                    log.Append("\n - WARNING: Source code is obfuscated, preventing inspection!\n");
                }

                if (item.Compatibility.Count > 0) {
                    ScanCompatibility(item, ref log);
                }

                if (item.Notes != null) {
                    foreach (KeyValuePair<ulong, string> note in item.Notes) {
                        if (IsAlwaysNote(note.Key) || subscriptions.ContainsKey(note.Key)) {
                            log.AppendFormat("\n - {0}\n", note.Value);
                        }
                    }
                }

                if (item.ReplaceWith != 0u) {
                    log.AppendFormat("\n - Newer version/replacement: {0}\n", GetWorkshopURL(item.ReplaceWith));
                }
            }
        }

        /// <summary>
        /// Given a compatibility list, it checks against subscribed items and logs any issues.
        /// </summary>
        /// 
        /// <param name="descriptor">The item descriptor to inspect.</param>
        /// <param name="log">The log file where results are sent.</param>
        private static void ScanCompatibility(Item descriptor, ref StringBuilder log) {

            uint reqSubscribed = 0;

            foreach (KeyValuePair<ulong, Status> entry in descriptor.Compatibility) {
                if (entry.Key == 0u || entry.Key == descriptor.WorkshopId) {
                    continue;
                }

                switch (entry.Value) {
                    case Status.Incompatible:
                        if (subscriptions.TryGetValue(entry.Key, out var strIncompat)) {
                            log.AppendFormat("\n - Incompatible: [ID: {0}] \"{1}\"\n", entry.Key, strIncompat);
                        }
                        break;
                    case Status.MinorIssues:
                        if (subscriptions.TryGetValue(entry.Key, out var strMinor)) {
                            log.AppendFormat("\n - Minor isuses: [ID: {0}] \"{1}\"\n", entry.Key, strMinor);
                        }
                        break;
                    case Status.Required:

                        if (descriptor.RequiredModsSelection == Selection.OnlyOne && reqSubscribed > 0) {
                            continue;
                        }

                        // todo: check required item is enabled
                        if (!IsSunbscribed(entry.Key)) {
                            log.AppendFormat("\n - It won't work without: {0}\n", GetWorkshopURL(entry.Key));
                        } else {
                            ++reqSubscribed;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        // returns true if subbed
        private static bool IsSunbscribed(ulong id) {
            return subscriptions.ContainsKey(id);
        }

        // check if Notes id is an "always show" note.
        private static bool IsAlwaysNote(ulong id) {
            return id >= 100000000u && id <= 200000000u;
        }

        // given workshop id, return workshop url
        public static string GetWorkshopURL(ulong id) {
            return $"https://steamcommunity.com/sharedfiles/filedetails/?id={id}";
        }

        // get the mod name safely
        public static string GetPluginName(PluginInfo plugin) {
            try {
                if (plugin == null) {
                    return "(PluginInfo is null)";
                }

                if (plugin.userModInstance == null) {
                    return string.IsNullOrEmpty(plugin.name)
                        ? "(userModInstance and name are null)"
                        : $"({plugin.name})";
                }

                return ((IUserMod)plugin.userModInstance).Name;
            }
            catch {
                return $"(error retreiving Name)";
            }
        }

        // return true if mod stored in local folder (Addons\Mods)
        public static bool IsLocal(PluginInfo plugin) {
            ulong id = plugin?.publishedFileID.AsUInt64 ?? 0u;

            // If workshop id is ulong.MaxValue, it's a locally installed mod
            return id == ulong.MaxValue;
        }

    }
}
