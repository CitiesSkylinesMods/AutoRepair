namespace AutoRepair {
    using AutoRepair.Catalogs;
    using AutoRepair.Util;
    using ColossalFramework.UI;
    using ICities;
    using System.IO;
    using UnityEngine;

    /// <summary>
    /// Renders the settings UI.
    /// </summary>
    public class SettingsUI {

        /// <summary>
        /// Define components for settings UI.
        /// </summary>
        /// 
        /// <param name="helper">UI helper from the game.</param>
        public static void Render(UIHelperBase helper) {
            UIHelperBase group;
            bool selected;
            string path, caption;

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

            selected = Options.Instance.LogIntroText;
            group.AddCheckbox("Add notes on mod management at top of log file", selected, sel => {
                Options.Instance.LogIntroText = sel;
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
    }
}
