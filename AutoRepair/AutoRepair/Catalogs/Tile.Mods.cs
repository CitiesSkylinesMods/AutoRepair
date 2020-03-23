/*
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
            Item item;

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
                SourceURL = "https://github.com/keallu/CSL-PurchaseIt",
            });

            item = AddMod(1575247594u, "576327847 81 Tiles (Fixed for 1", 576327847u, true);
            item.Affect |= Factor.VehicleLimit;
            item.Flags |= ItemFlags.SaveChanging | ItemFlags.Localised;
            item.Locale = "zh-cn";

            item = AddMod(1560122066u, "81MOD", 576327847u, true);
            item.Flags |= ItemFlags.SaveChanging;
            item.Affect |= Factor.VehicleLimit;

            AddMod(1457742795u, "403798635 All Spaces Unlockable", 403798635u, true);

            item = AddMod(1449194984u, "25格汉化版", 405810376u);
            item.Flags |= ItemFlags.Localised;
            item.Locale = "zh-cn";

            Add(new Item(1361478243u, "81 Tiles") {
                Authors = "限量版好男人",
                Affect = Factor.TileLimit,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SaveChanging
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                IncompatibleMods = new List<ulong>() {
                    { 1764208250u }, // More Vehicles
                },
                Locale = "zh-cn",
                ReplaceWith = 576327847u, // 81 Tile (BP version)
            });

            AddMod(1314938052u, "UnlockAreaCountLimit");
            AddMod(1270675750u, "BigCity (25 tiles mod)");
            AddMod(1268806334u, "UnlockAreaCountLimitAndFree");
            AddMod(1265292380u, "UnlockAreaCountLimit");

            // all spaces unlockable (25 tiles)
            AddMod(1225712804u, "406218372"); // zh-cn translation

            AddMod(1223738434u, "422554572", 576327847u, true); // zh-cn translation of original (broken) 81 tiles mod

            AddMod(406218372, "All Spaces Unlockable"); // no longer in workshop

            // Multiple user comments stating it doesn't work
            Add(new Item(1138679561u, "AllSpacesUnlock") {
                Authors = "The700",
                Affect = Factor.TileLimit,
                Flags = ItemFlags.SourceUnavailable,
            });

        }
    }
}
*/