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
    using System.Globalization;
    using System.Text;
    using UnityEngine;
    using static ColossalFramework.Plugins.PluginManager;

    /// <summary>
    ///  This is what acutally runs the scan and currently just dumps results to log file.
    /// </summary>
    public class Scanner {

        /// <summary>
        /// Subscription descriptors keyed by Steam Workshop ID.
        /// </summary>
        private static Dictionary<ulong, Subscription> subscriptions;

        /// <summary>
        /// Gets a value indicating whether the Steam Workshop is available.
        /// </summary>
        private static bool SteamWorkshopAvailable => PlatformService.platformType == PlatformType.Steam && !PluginManager.noWorkshop;

        /// <summary>
        /// Perform a compatibility scan.
        /// </summary>
        public static void PerformScan() {
            try {
                if (!SteamWorkshopAvailable) {
                    Log.Info("Steam Workshop is not online; unable to perform compatibility scan.");
                    return;
                }

                StringBuilder log = new StringBuilder(1024 * 100);
                Stopwatch timer = Stopwatch.StartNew();

                Log.Reset();

                if (Options.Instance.LogIntroText) {
                    AddAnnouncementText(ref log);
                    AddIntroText(ref log);
                }

                log.AppendFormat("\nLoaded {0} Review Descriptors.\n", Catalog.Open().Count);

                subscriptions = CollateSubscriptions(ref log);

                if (subscriptions.Count > 0) {
                    DoScan(ref log);
                }

                AddFooterText(ref log);

                timer.Stop();
                log.AppendFormat("\nScanned {0} item(s) in {1}ms\n", subscriptions.Count, timer.ElapsedMilliseconds);

                Log.Info(log.ToString());
            }
            catch (Exception e) {
                Log.Error(e.ToString());
            }
            finally {
                subscriptions?.Clear();
                Catalog.Close();
            }
        }

        /// <summary>
        /// Add any announcement text to the log file.
        /// </summary>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        internal static void AddAnnouncementText(ref StringBuilder log) {
            if (Announcements.Notes.Count > 0) {
                log.Append("\nGeneral Announcements:\n");

                foreach (var entry in Announcements.Notes) {
                    if (IsAlwaysNote(entry.Key)) {
                        log.AppendFormat("\n* {0}\n", entry.Value);
                    } else {
                        log.AppendFormat("\n* {0} - {1}\n", entry.Value, GetWorkshopURL(entry.Key));
                    }
                }
            }
        }

        /// <summary>
        /// Add intro text to the log file (if enabled in mod options).
        /// </summary>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        internal static void AddIntroText(ref StringBuilder log) {
            log.Append("\nThings to know about mods:\n");
            log.Append("\n* Disabled mods are often still loaded; always unsubscribe mods you're not using!\n");
            log.Append("\n* Mods that do the same thing are generally incompatible.\n");
            log.Append("\n* For modded games, always exit to desktop before loading another city.\n");
            log.Append("\n* After disabling/unsubscribing mods, always exit to desktop to flush them from RAM\n");
            log.Append("\n* Save game not loading? Subscribe Loading Screen Mod,\n  enable it's sharing/optimisation and safe mode options, then load your save:\n  https://steamcommunity.com/sharedfiles/filedetails/?id=667342976 \n");
        }

        /// <summary>
        /// Add footer text to log file.
        /// </summary>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        internal static void AddFooterText(ref StringBuilder log) {
            log.Append("\nOudated information? Please let us know! https://steamcommunity.com/sharedfiles/filedetails/?id=2034713132 \n"); // todo

            log.Append("\nDid it help? Please rate/comment the Mod Compatibility Checker in the workshop to help others find it (:");
        }

        /// <summary>
        /// Create a disctionary of <see cref="Subscription"/> descriptors.
        /// </summary>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        /// 
        /// <returns>Returns a dictionary of subscriptions, keyed by Steam Workshop ID.</returns>
        internal static Dictionary<ulong, Subscription> CollateSubscriptions(ref StringBuilder log) {

            List<PluginInfo> plugins = new List<PluginInfo>(); // (manager.modCount);

            PluginManager manager = Singleton<PluginManager>.instance;

            plugins.AddRange(manager.GetPluginsInfo()); // normal mods
            plugins.AddRange(manager.GetCameraPluginInfos()); // camera scripts

            log.Append("\nScanning...\n");

            Dictionary<ulong, Subscription> list = new Dictionary<ulong, Subscription>();

            foreach (var plugin in plugins) {
                try {
                    Subscription subscription = new Subscription(plugin);

                    if (subscription.IsValid && !subscription.IsOffline) {
                        list.Add(subscription.WorkshopId, subscription);
                    } else {
                        LogHeader(subscription, ref log);
                        log.Append("\n - Local/bundled mods not scanned.\n");
                    }
                }
                catch (Exception e) {
                    Log.Error(e.ToString());
                }
            }

            return list;
        }

        /// <summary>
        /// Investigate each subscription.
        /// </summary>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        internal static void DoScan(ref StringBuilder log) {

            foreach (var subscription in subscriptions) {
                try {
                    Investigate(subscription.Value, ref log);
                } catch (Exception e) {
                    Log.Error(e.ToString());
                }
            }
        }

        /// <summary>
        /// Investigate a specific subscription.
        /// </summary>
        /// 
        /// <param name="subscription">The <see cref="Subscription"/> descriptor to inspect.</param>
        /// 
        /// <param name="log">The log file where results are sent.</param>
        private static void Investigate(Subscription subscription, ref StringBuilder log) {

            Review review = subscription.Review;
            Version gameVersion = GameVersion.Active;

            LogHeader(subscription, ref log);

            if (!subscription.IsEnabled) {
                log.Append("\n - It is disabled; if not using it, it should be unsubscribed.\n");
            }

            if (!subscription.IsReviewed) {
                log.Append("\n - This mod has not been reviewed yet.\n");

                if (Options.Instance.LogWorkshopURLs) {
                    log.AppendFormat("\n - Workshop page: {0}\n", subscription.WorkshopURL);
                }

                return;
            }

            if (Options.Instance.LogDescriptorHeaders) {
                log.AppendFormat(
                    "\n - [AutoRepair Descriptor] Catalog: '{0}'. Vectors: {1}. Author(s): {2}\n   ",
                    review.Catalog,
                    review.Compatibility.Count,
                    review.Authors);

                if (review.Published != null) {
                    log.AppendFormat("Published: {0:d MMM yyyy}. ", review.Published);
                }

                if (review.Updated != null) {
                    log.AppendFormat("Updated: {0:d MMM yyyy}. ", review.Updated);
                }

                if (review.LastSeen != null) {
                    log.AppendFormat("Checked: {0:d MMM yyyy}. ", review.LastSeen);
                }

                if (review.Removed != null) {
                    log.AppendFormat("Removed: {0:d MMM yyyy}. ", review.Removed);
                }

                log.AppendFormat("Downloaded: {0:d MMM yyyy}.\n", subscription.Downloaded);
            }

            if (review.BrokenBy != null && gameVersion >= review.BrokenBy) {

                log.AppendFormat(
                    "\n - Broken by the Cities: Skylines {0} update.\n",
                    GameVersion.GetVersionString(review.BrokenBy));

            } else if (review.HasFlag(ItemFlags.GameBreaking)) {

                    log.Append("\n - Broken. Unsubscribe it.\n");

            } else if (review.CompatibleWith != null && GameVersion.LatestMilestone <= review.CompatibleWith) {

                log.AppendFormat(
                    "\n - Compatible with Cities: Skylines {0} :)\n",
                    GameVersion.GetVersionString(gameVersion));

            } else {

                log.AppendFormat(
                    "\n - Probably compatible with Cities: Skylines {0} ?\n",
                    GameVersion.GetVersionString(gameVersion));
            }

            if (Options.Instance.LogWorkshopURLs) {
                if (!string.IsNullOrEmpty(review.ArchiveURL)) {
                    log.AppendFormat("\n - Archive of removed workshop page: {0}\n", review.ArchiveURL);
                } else if (review.HasFlag(ItemFlags.NoWorkshop)) {
                    log.Append("\n - Removed from Steam Workshop; it is probably obsolete or game breaking.\n");
                } else {
                    log.AppendFormat("\n - Workshop page: {0}\n", subscription.WorkshopURL);
                }
            }

            if (review.HasFlag(ItemFlags.EditorBreaking)) {
                log.Append("\n - Breaks content editors; before using editors, disable it and exit to desktop to flush it from RAM.\n");
            }

            if (review.HasFlag(ItemFlags.Abandonware)) {
                log.Append("\n - Mod seems (or is) abandonned; future updates are unlikely.\n");
            }

            if (review.HasFlag(ItemFlags.Streamable)) {
                log.Append("\n - Safe for streaming (according to author / music source).\n");
            } else if (review.Compatibility.TryGetValue(422934383u, out var status)) {
                if (status == Status.Required) {
                    log.Append("\n - Not safe for streaming (copyrighted music).\n");
                }
            }

            if (review.HasFlag(ItemFlags.Laggy)) {
                log.Append("\n - Can cause performance issues (lag or framerate drop in-game).\n");
            }

            if (review.HasFlag(ItemFlags.SlowLoad)) {
                log.Append("\n - Can increase time taken to load save games.\n");
            }

            if (review.HasFlag(ItemFlags.LargeFileWarning)) {
                log.Append("\n - Large file size compared to other items of same type.\n");
            }

            if (review.HasFlag(ItemFlags.MinorIssues)) {
                log.Append("\n - Minor issues - check workshop page/comments for details.\n");
            }

            if (review.HasFlag(ItemFlags.SaveAltering)) {
                log.Append("\n - Alters the save game; without it, the savegame might break.\n");
            }

            if (review.HasFlag(ItemFlags.Unreliable)) {
                log.Append("\n - Some users experienced problems; check workshop page/comments for details.\n");
            }

            if (Options.Instance.LogLanguages) {
                if (review.Languages != null) {
                    log.AppendFormat(
                        "\n - Locales: {0}\n",
                        string.Join(", ", Locale.FromStringArray(review.Languages).ToArray()));
                }
                log.AppendFormat("\n - Primary locale: {0}\n", Locale.ToString(review.Locale));
            }

            if (Options.Instance.LogSourceURLs) {
                if (review.HasFlag(ItemFlags.SourceAvailable)) {
                    if (!string.IsNullOrEmpty(review.SourceURL)) {
                        log.AppendFormat("\n - Source available: {0}\n", review.SourceURL);
                    }

                    if (review.HasFlag(ItemFlags.SourceOudated)) {
                        log.Append("\n - The available source code hasn't been kept up-to-date with recent mod updates.\n");
                    }
                } else if (review.HasFlag(ItemFlags.SourceBundled)) {
                    log.Append("\n - Source is bundled in its 'Source' folder.\n");

                    if (Application.platform == RuntimePlatform.OSXPlayer) {
                        log.Append("\n - Mac users: If this item doesn't contain pre-compiled files, it might not work on OS/X.\n");
                    }
                } else if (review.HasFlag(ItemFlags.SourceUnavailable)) {
                    // todo: check for `Source` folder in mod folder
                    log.Append("\n - No source code/files found (yet); future updates will be difficult.\n");
                }
            }

            if (review.HasFlag(ItemFlags.SourceObfuscated)) {
                log.Append("\n - WARNING: Source code is obfuscated, preventing inspection!\n");
            }

            if (review.Compatibility != null && review.Compatibility.Count > 0) {
                ScanCompatibility(review, ref log);
            }

            if (review.Notes != null) {
                foreach (var note in review.Notes) {
                    if (IsAlwaysNote(note.Key) || IsSubscribed(note.Key)) {
                        log.AppendFormat("\n - {0}\n", note.Value);
                    }
                }
            }

            if (review.ReplaceWith != 0u) {
                SuggestReplacement(review, ref log);
            }
        }

        /// <summary>
        /// Given a review with non-zero <see cref="Review.ReplaceWith"/>, logs details of the replacement.
        /// </summary>
        /// 
        /// <param name="review">The item descriptor to inspect.</param>
        /// <param name="log">The log file where results are sent.</param>
        private static void SuggestReplacement(Review review, ref StringBuilder log) {

            // TODO: List alternatives too, if defined

            if (!Catalog.Instance.TryGetReview(review.ReplaceWith, out var replacement)) {

                if (review.HasFlag(ItemFlags.ForceMigration)) {
                    log.AppendFormat(
                        "\n - Replace with: {0}\n",
                        GetWorkshopURL(review.ReplaceWith));

                } else {
                    log.AppendFormat(
                        "\n - Suitable alternative: {0}\n",
                        GetWorkshopURL(review.ReplaceWith));
                }

                return;
            }

            // we can be more descriptive when we have descriptor for replacement...

            if (replacement.HasFlag(ItemFlags.Vanilla)) {
                log.AppendFormat(
                    "\n - Replace with: {0}\n",
                    replacement.ToString(true));

            } else if (review.HasFlag(ItemFlags.ForceMigration)) {
                log.AppendFormat(
                    "\n - Replace with: {0}\n   {1}\n",
                    replacement.ToString(true),
                    GetWorkshopURL(replacement.WorkshopId));

            } else {
                log.AppendFormat(
                    "\n - Suitable alternative: {0}\n   {1}\n",
                    replacement.ToString(true),
                    GetWorkshopURL(replacement.WorkshopId));
            }
        }

        /// <summary>
        /// Given a compatibility list, it checks against subscribed items and logs any issues.
        /// </summary>
        /// 
        /// <param name="review">The item descriptor to inspect.</param>
        /// <param name="log">The log file where results are sent.</param>
        private static void ScanCompatibility(Review review, ref StringBuilder log) {

            uint reqSubscribed = 0;

            foreach (var vector in review.Compatibility) {
                if (vector.Key == 0u || vector.Key == review.WorkshopId) {
                    continue;
                }

                Subscription target = default;

                if (subscriptions.TryGetValue(vector.Key, out var value)) {
                    target = value;
                }

                switch (vector.Value) {
                    case Status.Incompatible:
                        if (IsSubscribed(vector.Key)) {
                            log.AppendFormat("\n - Incompatible: {0}\n", target.ToString());
                        }
                        break;
                    case Status.MinorIssues:
                        if (IsSubscribed(vector.Key)) {
                            log.AppendFormat("\n - Minor isuses: {0}\n", target.ToString());
                        }
                        break;
                    case Status.Required:

                        if (review.RequiredModsSelection == Selection.OnlyOne && reqSubscribed > 0) {
                            continue;
                        }

                        // todo: check required item is enabled
                        if (!IsSubscribed(vector.Key)) {
                            log.AppendFormat("\n - It won't work without: {0}\n", GetWorkshopURL(vector.Key));
                        } else {
                            ++reqSubscribed;

                            if (!target.IsEnabled) {
                                log.AppendFormat("\n - It won't work until you enable: {0}\n", target.ToString());
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private static void LogHeader(Subscription subscription, ref StringBuilder log) {
            log.Append("\n");
            log.Append('-', 75);
            log.AppendFormat("\n[ID: {0}] \"{1}\":\n", subscription.WorkshopId, subscription.Name);
        }

        // returns true if subbed
        private static bool IsSubscribed(ulong workshopId) {
            return subscriptions.ContainsKey(workshopId);
        }

        // check if Notes id is an "always show" note.
        private static bool IsAlwaysNote(ulong id) {
            return id >= 100000000u && id <= 200000000u;
        }

        // given workshop id, return workshop url
        private static string GetWorkshopURL(ulong workshopId) {
            return $"https://steamcommunity.com/sharedfiles/filedetails/?id={workshopId}";
        }

    }
}
