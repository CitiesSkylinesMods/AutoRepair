namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Currently active CSM mods.
    /// </summary>
    public partial class Multiplayer {
        private void AddModsToList() {
            AddMod(new Item(1558675585u, "Cities: Skylines Multiplayer (CSM) [Beta]") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs,
                SourceCode = "https://github.com/DominicMaas/Tango",
            });
        }
    }
}
