namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods which enable achievements for modded games.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void AchievementsCatalog() {
            string catalog = "Achievements";

            AddMod(new Item(1567569285u, "Achieve It!") {
                Affect = Factor.Achievements,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-AchieveIt",
            });

            AddMod(new Item(1444491969u, "Achievements with Mods") {
                Affect = Factor.Achievements,
                Authors = "TianBao",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                },
                ContinuationOf = 407055819u, // Mod Achievement Enabler
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1567569285u, // Achieve It!
            });

            AddMod(new Item(407055819u, "Mod Achievement Enabler") {
                Affect = Factor.Achievements,
                Authors = "extra bad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 407055819u, Status.Incompatible }, // Mod Achievement Enabler
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1444491969u, // Achievements with Mods
                SourceURL = "https://gist.github.com/anonymous/c524671571c3879381b2",
            });
        }
    }
}
