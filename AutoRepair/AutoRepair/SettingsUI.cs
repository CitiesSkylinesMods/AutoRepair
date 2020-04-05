namespace AutoRepair {
#if DEBUG
    using AutoRepair.Catalogs;
#endif
    using AutoRepair.Lists;
    using AutoRepair.Util;
    using ColossalFramework.UI;
    using ICities;
    using System.Collections.Generic;
    using UnityEngine;

    /// <summary>
    /// Renders the settings UI.
    /// </summary>
    public class SettingsUI {

        /// <summary>
        /// Define components for settings UI.
        ///
        /// Full settings are rendered at main menu; only partial settings are rendered in-game.
        /// </summary>
        /// 
        /// <param name="helper">UI helper from the game.</param>
        /// <param name="scene">The currently active scene from <c>SceneManager.GetActiveScene()</c>.</param>
        public static void Render(UIHelperBase helper, string scene) {
            UIHelperBase group;
            bool selected = false;
            string path, caption;
            
            group = helper.AddGroup("Announcements");

            if (Announcements.Notes.Count > 0) {
                foreach (KeyValuePair<ulong, string> entry in Announcements.Notes) {
                    selected = Announce(group, entry.Key, entry.Value) || selected;
                }
            }

            if (!selected) {
                Announce(group, 0u, "There are currently no announcements.");
            }

            group = helper.AddGroup("Log File Options");

            if (Application.platform == RuntimePlatform.OSXPlayer) {
                caption = "Search for 'AutoRepair Descriptors' in this file:";
                path = "~/Library/Logs/Unity/Player.log"; // only way I could get logging working on Macs (see also: Log.cs)
            } else {
                if (Application.platform == RuntimePlatform.WindowsPlayer) {
                    caption = "Copy this path in to Windows File Explorer to view log file:";
                } else {
                    caption = "Copy this path for log file location:";
                }
                path = Log.LogFile;
            }

            UITextField field = (UITextField)group.AddTextfield(caption, path, _ => { });
            field.selectOnFocus = true;
            field.width = 650f;

            if (Application.platform == RuntimePlatform.WindowsPlayer) {
                group.AddButton("Open File Explorer", () => System.Diagnostics.Process.Start("explorer.exe", "/select," + path));
            }

            if (scene == "Game") {
                return;
            }

            selected = Options.Instance.LogIntroText;
            group.AddCheckbox("Add notes on mod management at top of log file", selected, sel => {
                Options.Instance.LogIntroText = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogLanguages;
            group.AddCheckbox("Include details of languages/translations (where applicable)", selected, sel => {
                Options.Instance.LogLanguages = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogWorkshopURLs;
            group.AddCheckbox("Include URLs to Steam Workshop pages (if known)", selected, sel => {
                Options.Instance.LogWorkshopURLs = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogSourceURLs;
            group.AddCheckbox("Include URLs to source files (if known)", selected, sel => {
                Options.Instance.LogSourceURLs = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogDescriptorHeaders;
            group.AddCheckbox("Include descriptor headers (not recommended)", selected, sel => {
                Options.Instance.LogDescriptorHeaders = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

#if DEBUG
            group.AddButton("Dump CSV", () => {
                Catalog.Instance.DumpToCSV();
            });
#endif

        }

        private static bool Announce(UIHelperBase group, ulong workshopId, string msg) {
            if (workshopId == 0u || IsSubscribed(workshopId)) {
                UICheckBox box = (UICheckBox)group.AddCheckbox(msg, true, (bool _) => { });
                box.readOnly = true;
                box.opacity = 1f;
                return true;
            } else {
                return false;
            }
        }

        private static bool IsSubscribed(ulong workshopId) {
            return true; // todo
        }
    }
}
