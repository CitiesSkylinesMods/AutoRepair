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

        [UsedImplicitly]
        public void OnSettingsUI(UIHelperBase helper) {
            if (SceneManager.GetActiveScene().name == "Game") {
                return;
            }

            try {
                Log.Info($"\nNum items in catalog = {Catalog.Instance.Items.Count}");
                Scanner.PerformScan();
            } catch (Exception e) {
                Log.Info("Something went horribly wrong...");
                Log.Error(e.ToString());
            }
        }

        [UsedImplicitly]
        public void OnDisabled() {

        }

        public void OnPluginChange() {

        }

    }
}
