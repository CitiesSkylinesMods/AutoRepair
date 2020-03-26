namespace AutoRepair {
    using AutoRepair.Catalogs;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    using ColossalFramework;
    using ColossalFramework.Plugins;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using static ColossalFramework.Plugins.PluginManager;

    /// <summary>
    ///  This is what acutally runs the scan and currently just dumps results to log file.
    /// </summary>
    public class Scanner {

        internal const string LOCAL_MOD_STR = "(local)";
        internal const string BUNDLED_MOD_STR = "(bundled)";

        /// <summary>
        /// Performs the compatibility scan.
        /// </summary>
        public static void PerformScan() {

            StringBuilder log = new StringBuilder(1024 * 20);

            log.Append("\nTo contact us, visit workshop page: https://steamcommunity.com/sharedfiles/filedetails/?id=2034713132 \n"); // todo

            PluginManager manager = Singleton<PluginManager>.instance;

            // list of all subscribed, local and bundled mods (incl. camera scripts)
            List<PluginInfo> plugins = new List<PluginInfo>(manager.modCount);

            plugins.AddRange(manager.GetPluginsInfo()); // normal mods
            plugins.AddRange(manager.GetCameraPluginInfos()); // camera scripts

            // workshop id
            ulong modId;

            // id and name
            string strId;
            string strName;

            // basic properties
            bool isLocal;
            bool isVanilla;
            bool isEnabled;

            // flags from descriptor
            ItemFlags flags;

            // compatibility dict from descriptor
            Dictionary<ulong, Status> compatibility;

            // list of subscribed mod workshop ids
            Dictionary<ulong, string> subscriptions = new Dictionary<ulong, string>();

            log.Append("\nStarting compatibility scan...\n");

            // populate list of subscribed mod workshop ids
            foreach (PluginInfo record in plugins) {
                try {
                    if (!IsLocal(record) && !(record?.isBuiltin ?? false)) {
                        modId = record.publishedFileID.AsUInt64;
                        strName = GetPluginName(record);
                        if (!subscriptions.ContainsKey(modId)) {
                            subscriptions.Add(modId, strName);
                        }
                    }
                } catch {
                    // ignore
                }
            }

            foreach (PluginInfo plugin in plugins) {
                try {

                    isLocal = IsLocal(plugin);
                    isVanilla = plugin?.isBuiltin ?? false;
                    isEnabled = plugin?.isEnabled ?? false;

                    // todo: translate vanilla mods to their fake ids (see Catalog.Vanilla.cs)
                    modId = plugin?.publishedFileID.AsUInt64 ?? 0u;

                    strId = isVanilla
                        ? BUNDLED_MOD_STR
                        : isLocal
                            ? LOCAL_MOD_STR
                            : modId.ToString();

                    strName = GetPluginName(plugin);

                    log.Append("\n");
                    log.Append('-', 75);
                    log.AppendFormat("\n[ID: {0}] \"{1}\":\n", strId, strName);

                    // todo: find a decent way to identify local mods
                    if (isLocal || isVanilla) {
                        log.Append(" - Bundled or local mods are not currently scanned, sorry.\n");
                        continue;
                    }

                    if (!isEnabled) {
                        log.Append("\n - It is disabled; if not using it, it should be unsubscribed.\n");
                    }

                    if (!Catalog.Instance.Has(modId)) {
                        log.Append("\n - AutoRepair database does not currently contain any data for this mod, sorry.\n");

                        // best wait until we have mode descriptors otherwise it will result in flood of spam!
                        //log.Append("\n - It would be helpful if you could copy and paste the mod id/name above\n");
                        //log.Append("   to the Compatibility Checker workshop page linked at top of log file.\n");

                        log.AppendFormat("\n - Workshop page for this mod: {0}\n", GetWorkshopURL(modId));

                        continue;
                    }

                    if (Catalog.Instance.TryGetValue(modId, out var descriptor)) {
                        flags = descriptor.Flags;

                        compatibility = descriptor.Compatibility == null
                            ? new Dictionary<ulong, Status>()
                            : descriptor.Compatibility;

                        log.AppendFormat(
                            "\n - [AutoRepair Descriptor] Catalog: '{0}'. Vectors: {1}. Author(s): {2}\n",
                            descriptor.Catalog,
                            compatibility.Count,
                            descriptor.Authors);

                        if (HasFlag(flags, ItemFlags.NoWorkshop)) {
                            log.Append("\n - It has no workshop page; it is probably obsolete or game breaking.\n");
                        } else {
                            log.AppendFormat("\n - Workshop page for this mod: {0}\n", GetWorkshopURL(modId));
                        }

                        if (HasFlag(flags, ItemFlags.GameBreaking)) {
                            log.Append("\n - It's reported as game breaking. Unsubscribe it.\n");
                        } else if(descriptor.BrokenBy <= GameVersion.Active) {
                            log.Append(" - Not compatible with current game version. Disable it until an update is ready.\n");
                        } else if (descriptor.CompatibleWith >= GameVersion.Active) {
                            log.AppendFormat("\n - It is confirmed compatible with Cities: Skylines v{0}.\n", GameVersion.Active.ToString(3));
                        } else {
                            log.Append("\n - It should be compatible with current game version; if not, let us know!\n");
                        }

                        if (HasFlag(flags, ItemFlags.EditorBreaking)) {
                            log.Append("\n - It's reported to cause problems with the asset/map/theme editors.\n");
                        }

                        if (HasFlag(flags, ItemFlags.Abandonware)) {
                            log.Append("\n - It appears the author no longer maintains this mod; if wrong, let us know!\n");
                        }

                        if (HasFlag(flags, ItemFlags.Streamable)) {
                            log.Append("\n - The music in this mod is safe for streaming (according to mod author).\n");
                        } else if (compatibility.TryGetValue(422934383u, out var music)) {
                            if (music == Status.Required) {
                                log.Append("\n - The music is copyrighted and must not be played while streaming.\n");
                            }
                        }

                        if (HasFlag(flags, ItemFlags.Laggy)) {
                            log.Append("\n - It can cause some lag or framerate drop in-game.\n");
                        }

                        if (HasFlag(flags, ItemFlags.SlowLoad)) {
                            log.Append("\n - It is likely to significantly increase load times.\n");
                        }

                        if (HasFlag(flags, ItemFlags.LargeFileWarning)) {
                            log.Append("\n - It has a somewhat large file size compared to other mods of this type.\n");
                        }

                        if (HasFlag(flags, ItemFlags.MinorBugs)) {
                            log.Append("\n - Minor bugs reported for this mod; please read the mods' workshop page/comments for details.\n");
                        }

                        if (HasFlag(flags, ItemFlags.SaveChanging)) {
                            log.Append("\n - This mod alters the save game; without the mod, the savegame might be unusable.\n");
                        }

                        if (HasFlag(flags, ItemFlags.Unreliable)) {
                            log.Append("\n - Some users report major problems with this mod; see mods' workshop page/comments for details.\n");
                        }

                        if (HasFlag(flags, ItemFlags.SourceAvailable)) {
                            if (!string.IsNullOrEmpty(descriptor.SourceURL)) {
                                log.AppendFormat("\n - Source available: {0}\n", descriptor.SourceURL);
                            }
                        } else if (HasFlag(flags, ItemFlags.SourceUnavailable)) {
                            // todo: check for `Source` folder in mod folder
                            log.Append("\n - No source code/files found (yet); it might be difficult to update in future.\n");
                        }

                        if (HasFlag(flags, ItemFlags.SourceObfuscated)) {
                            log.Append("\n - ALERT: The mod source code is obfuscated to prevent inspection!\n");
                        }

                        foreach (KeyValuePair<ulong, Status> entry in compatibility) {
                            if (entry.Key == descriptor.WorkshopId) {
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
                                    if (!subscriptions.ContainsKey(entry.Key)) {
                                        log.AppendFormat("\n - It won't work unless you subscribe to: {0}\n", GetWorkshopURL(entry.Key));
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }

                        if (descriptor.Notes != null) {
                            foreach (string note in descriptor.Notes) {
                                log.AppendFormat("\n - {0}\n", note);
                            }
                        }

                        if (descriptor.ReplaceWith != 0u) {
                            log.AppendFormat("\n - Newer version/replacement: {0}\n", GetWorkshopURL(descriptor.ReplaceWith));
                        }
                    }
                } catch (Exception e) {
                    Log.Error(e.ToString());
                }
            }

            log.Append("\nSCAN COMPLETE.\n");

            Log.Info(log.ToString());
        }

        // check if flag set
        public static bool HasFlag(ItemFlags item, ItemFlags flag) {
            return (item & flag) != 0;
        }

        // given workshop id, return workshop url
        public static string GetWorkshopURL(ulong id) {
            return $"https://steamcommunity.com/sharedfiles/filedetails/?id={id}";
        }

        // get the mod name safely
        public static string GetPluginName(PluginInfo plugin) {
            return ModInspector.GetModName(plugin);
        }

        // return true if mod stored in local folder (Addons\Mods)
        public static bool IsLocal(PluginInfo plugin) {
            ulong id = plugin?.publishedFileID.AsUInt64 ?? 0u;

            // If workshop id is ulong.MaxValue, it's a locally installed mod
            return id == ulong.MaxValue;
        }

    }
}
