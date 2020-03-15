using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {
    public partial class AnarchyTool {
        private void AddModstoList() {
            Add(new Item(1844442251u, "Fine Road Tool 2.0.3") {
                Flags = ItemFlags.Verified,
                ConflictsWith = ConflictGroups.FineRoadAnarchy | ConflictGroups.FineRoadTool,
                CompatibleWith = new List<ulong> {
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 1831805509u }, // Dynamic Text Props
                    { 1393797695u }, // Touch This Tool
                },
            });

            Add(new Item(1844440354u, "Fine Road Anarchy 2") {
                Flags = ItemFlags.Verified,
                ConflictsWith = ConflictGroups.FineRoadAnarchy | ConflictGroups.FineRoadTool,
                CompatibleWith = new List<ulong> {
                    { 1844442251u }, // Fine Road Tool 2
                    { 1831805509u }, // Dynamic Text Props
                    { 1393797695u }, // Touch This Tool
                },
            });

            Add(new Item(1783307723u, "Zone It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                ConflictsWith = ConflictGroups.Zoning,
            });

            Add(new Item(1645781000u, "Elektrix's Road Tools 2.91") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1612012531u, "Net Picker 2.0") {
                Flags = ItemFlags.SourceUnavailable,
            });

            // Might cause issues with TM:PE - short segments entering junctions causes AI issues
            Add(new Item(1586027591u, "Tiny Segments") {
                Flags = ItemFlags.SourceUnavailable,
                RequiredMods = {
                    { 1844440354u }, // Fine Road Anarchy 2
                },
            });

            Add(new Item(1619685021u, "Move It") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Quboid/CS-MoveIt",
                ConflictsWith = ConflictGroups.MoveIt,
                IncompatibleMods = new List<ulong>() {
                    { 1622545887u }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1866239503u }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u }, // 766190099_Move_It_
                    { 1120637951u }, // [OUTDATED] Move It! Extra Filters
                    { 1856282754u }, // MoveIt 汉化版
                    { 1892174866u }, // MoveIt2.6汉化版
                },
                SuggestedMods = new List<ulong>() {
                    { 787611845u }, // Prop Snapping
                },
            });

        }
    }
}
