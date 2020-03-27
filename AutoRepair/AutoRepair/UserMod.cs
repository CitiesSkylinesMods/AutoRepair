namespace AutoRepair {
    using AutoRepair.Catalogs;
    using AutoRepair.Util;
    using ICities;
    using JetBrains.Annotations;
    using System;
    using UnityEngine.SceneManagement;

    public class UserMod : IUserMod {

        /// <summary>
        /// Gets the name of the mod which is shown in Options screens and also Content Manager > Mods.
        /// </summary>
        [UsedImplicitly]
        public string Name => "Auto Repair";

        /// <summary>
        /// Gets the description of the mod which is shown in Content Manager > Mods.
        /// </summary>
        [UsedImplicitly]
        public string Description => "Mod compatibility checker.";
        
        [UsedImplicitly]
        public void OnEnabled() {

        }

        /// <summary>
        /// Called by the game when it wants the settings UI to be created.
        /// </summary>
        /// <param name="helper">UI helper from the game.</param>
        [UsedImplicitly]
        public void OnSettingsUI(UIHelperBase helper) {
            if (SceneManager.GetActiveScene().name == "Game") {
                return;
            }

            SettingsUI.Render(helper);
            Scanner.PerformScan();
        }

        [UsedImplicitly]
        public void OnDisabled() {

        }

        public void OnPluginChange() {

        }

    }
}
