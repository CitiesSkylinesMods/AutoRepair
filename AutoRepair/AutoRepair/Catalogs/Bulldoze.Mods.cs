using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    public partial class Bulldoze {
        private void AddModsToList() {
            Add(new Item(1656549865u, "Rebuild It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-RebuildIt",
                ConflictsWith = ConflictGroups.Bulldoze,
                CompatibleWith = new List<ulong>() {
                    { 1627986403u }, // Bulldoze It!
                },
            });

            Add(new Item(1628521230u, "Bulldoze Everything *Campus Compatible*") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/yakka34/AutomaticBulldoze",
                ConflictsWith = ConflictGroups.Bulldoze,
            });

            Add(new Item(1627986403u, "Bulldoze It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-BulldozeIt",
                ConflictsWith = ConflictGroups.Bulldoze,
                CompatibleWith = new List<ulong>() {
                    { 1656549865u }, // Rebuild It!
                },
            });

            Add(new Item(1507233911u, "Automatic Bulldoze *Campus Compatible*") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/yakka34/AutomaticBulldoze",
            });

            Add(new Item(1393966192u, "Automatic Bulldoze Simple Edition v1.1.3") {
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompat with other bulldozers
            });

        }
    }
}
