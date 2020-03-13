namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;

    /// <summary>
    /// Mod(s) which unlock map tiles.
    /// </summary>
    public partial class Tile {

        /// <summary>
        /// Add tile mods to list.
        /// </summary>
        private void AddModsToList() {
            AddMod(1978555062u, "AllSpacesUnlockable");
            AddMod(1891302645u, "UnlockAreaCountLimitAndFree");
            AddMod(1878659195u, "UnlockAreaCountLimitAndFree");
            AddMod(1830615215u, "All 25 Areas purchaseable");
            AddMod(1778652879u, "MaxArea");
            AddMod(1723162741u, "UnlockAreaCountLimitAndFree");

            AddMod(new Item(1612287735u, "Purchase It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Recommended
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-PurchaseIt",
            });

            AddMod(1560122066u, "81MOD", 576327847u, true);
        }
    }
}
