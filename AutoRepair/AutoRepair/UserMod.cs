namespace AutoRepair {
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

        }

        public void OnDisabled() {

        }

        public void OnPluginChange() {

        }

    }
}
