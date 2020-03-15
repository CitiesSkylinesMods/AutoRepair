using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    class Achievements {

        private void AddModsToList() {
            Add(new Item(1567569285u, "Achieve It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-AchieveIt",
                IncompatibleMods = new List<ulong>() {
                    // todo: achievements mods
                },
            });

            Add(new Item(1444491969u, "Achievements with Mods") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 407055819u }, // Mod Achievement Enabler
                },
            });

        }
    }
}
