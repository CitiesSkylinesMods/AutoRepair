using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {
    public partial class AnarchyTool {
        private void AddObsoleteToList() {
            AddClone(1895443005u, "Fine Road Anarchy 2 汉化版", 1844440354u, "zh-cn");
            AddClone(1895440521u, "Fine Road Tool 2 汉化版", 1844442251u, "zh-cn");
            AddClone(1892174866u, "MoveIt2.6汉化版", 1619685021u, "zh-cn");
            AddClone(1866239503u, "MOVE IT Sakuya16个人汉化版", 1619685021u, "zh-cn");
            AddGameBreakingClone(1857894421u, "766190099_Move_It_", 1619685021u);
            AddGameBreakingClone(1856282754u, "MoveIt 汉化版", 1619685021u, "zh-cn");
            AddClone(1436255148u, "Fine Road Anarchy 汉化版1.3.5", 802066100u, "zh-cn"); // game breaking

            Add(new Item(1622545887u, "Move It! 2.3.0 (Updated for Industries patch)") {
                Flags = ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.MoveIt,
                IncompatibleMods = new List<ulong>() {
                    { 1619685021u }, // Move It (current stable release)
                    { 1866239503u }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u }, // 766190099_Move_It_
                    { 1120637951u }, // [OUTDATED] Move It! Extra Filters
                    { 1856282754u }, // MoveIt 汉化版
                    { 1892174866u }, // MoveIt2.6汉化版
                },
                ReplaceWith = 1619685021u, // Move It (current stable release)
            });

            Add(new Item(1597198847u, "[Legacy] Segment Slope Smoother") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                ReplaceWith = 1645781000u, // Elektrix's Road Tools 2.91
            });

            Add(new Item(1362508329u, "TC01 - FineRoadAnarchy! (2018)") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
                Authors = "Fatih ÇELİK",
                Locale = "tr",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

        }
    }
}
