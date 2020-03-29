namespace AutoRepair {
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

            group = helper.AddGroup("Log File Options");

            string value = Application.platform == RuntimePlatform.OSXPlayer
                ? "~/Library/Logs/Unity/Player.log" // only way I could get logging working on Macs
                : Log.LogFile;

            UITextField field = (UITextField)group.AddTextfield("Log file (copy and paste in to Explorer/Finder):", value, _ => { });
            field.selectOnFocus = true;
            field.width = 650f;

            selected = Options.Instance.LogIntroText;
            group.AddCheckbox("Log intro text at top of log file (recommended for first time users)", selected, sel => {
                Options.Instance.LogIntroText = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogDescriptorHeaders;
            group.AddCheckbox("Log the AutoRepair Descriptor header (if available) for each item", selected, sel => {
                Options.Instance.LogDescriptorHeaders = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogWorkshopURLs;
            group.AddCheckbox("Log the Steam Workshop URL for each item", selected, sel => {
                Options.Instance.LogWorkshopURLs = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

            selected = Options.Instance.LogSourceURLs;
            group.AddCheckbox("Log the Source URL (if available) for each item", selected, sel => {
                Options.Instance.LogSourceURLs = sel;
                Options.Instance.Save();
                Scanner.PerformScan();
            });

        }
    }
}
