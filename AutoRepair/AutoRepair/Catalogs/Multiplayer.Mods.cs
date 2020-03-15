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
                SourceCodeURL = "https://github.com/DominicMaas/Tango",
            });

            AddMod(new Item(2021598295u, "1558438291 [Beta] CSM - Cities_ Skylines Multiplayer") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
                Locale = "zh-cn",
            });
        }
    }
}
