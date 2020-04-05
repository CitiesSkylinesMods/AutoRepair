namespace AutoRepair {
    using AutoRepair.Catalogs;
    using AutoRepair.Util;
    using ICities;
    using JetBrains.Annotations;
    using System;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// The main mod class.
    /// </summary>
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

        /// <summary>
        /// Called by the game when the mod is enabled.
        /// </summary>
        [UsedImplicitly]
        public void OnEnabled() {

        }

        /// <summary>
        /// Called by the game when it wants the settings UI to be created.
        /// </summary>
        /// <param name="helper">UI helper from the game.</param>
        [UsedImplicitly]
        public void OnSettingsUI(UIHelperBase helper) {
            string scene = SceneManager.GetActiveScene().name;

            SettingsUI.Render(helper, scene);

            if (scene != "Game") {
                Scanner.PerformScan();
            }
        }

        /// <summary>
        /// Called by the game when the mod is disabled.
        /// </summary>
        [UsedImplicitly]
        public void OnDisabled() {
            Catalog.Close();
        }

        public void OnPluginChange() {
            throw new NotImplementedException("UserMod.OnPluginsChange()");
        }

    }
}
