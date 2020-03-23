namespace AutoRepair {
    using AutoRepair.Catalogs;
    using ICities;

    public class UserMod : IUserMod {

        /// <summary>
        /// Gets the name of the mod which is shown in Options screens and also Content Manager > Mods.
        /// </summary>
        public string Name => "Auto Repair";

        /// <summary>
        /// Gets the description of the mod which is shown in Content Manager > Mods.
        /// </summary>
        public string Description => "Helps track down mod incompatibilities.";

        public void OnEnabled() {

        }

        public void OnSettingsUI(UIHelperBase helper) {
            Log.Info($"\n\nNum items in catalog = {Catalog.Instance.Items.Count}");
        }

        public void OnDisabled() {

        }

        public void OnPluginChange() {

        }

    }
}
