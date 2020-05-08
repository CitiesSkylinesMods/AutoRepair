namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods bundled with base game.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void VanillaMods() {

            string catalog = "Vanilla";

            AddMod(new Review(Vanilla.HardMode, "Hard Mode (bundled with Cities: Skylines)") {
                Affect = Factor.Construction
                       | Factor.BuildingLevel
                       | Factor.DemandRCI
                       | Factor.MaintenanceCost,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1522785644uL, Status.Incompatible }, // Infinite Demand Mod
                    { 1403960464uL, Status.Incompatible }, // Maintenance Fees (Parklife Ready)
                    { 1398502258uL, Status.Incompatible }, // Dam Upkeep Scaling
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 819155459uL , Status.Incompatible }, // 超级需求
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                LastSeen = DateTime.Now,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "When Hard Mode is enabled, mods that make the game easier will conflict with it." },
                },
                Published = WorkshopDate("19 May, 2015"), // existed as of May 2015, could be earlier?
                Updated = GameVersion.Updated,
            });

            AddMod(new Review(Vanilla.UnlimitedMoney, "Unlimited Money (bundled with Cities: Skylines)") {
                Affect = Factor.Budget
                       | Factor.Construction
                       | Factor.MaintenanceCost
                       | Factor.Money,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039606384uL, Status.MinorIssues  }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.MinorIssues  }, // Free Maintenance by Anvilarse
                    { 2036484892uL, Status.MinorIssues  }, // AutoMoney
                    { 2030216556uL, Status.MinorIssues  }, // GrantMeMoney: get cash / money unconditionally
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { 1830455071uL, Status.MinorIssues  }, // EasyMode
                    { 1744522363uL, Status.MinorIssues  }, // Money Back (Refund)
                    { 1673480325uL, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319uL, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1598546349uL, Status.MinorIssues  }, // Mary's Mod
                    { 1403960464uL, Status.MinorIssues  }, // Maintenance Fees (Parklife Ready)
                    { 1330289236uL, Status.MinorIssues  }, // CS-Utils
                    { 1367444256uL, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1237383751uL, Status.MinorIssues  }, // Extended Game Options
                    { 1232451940uL, Status.MinorIssues  }, // 调整金钱
                    { 1227735337uL, Status.MinorIssues  }, // Full Refund Cost[Industries Compatible]
                    { 855704599uL , Status.MinorIssues  }, // Set your own Start Money amount
                    { 838095079uL , Status.MinorIssues  }, // Cheaper Hydro Electric Power
                    { 938049744uL , Status.MinorIssues  }, // Proper Hardness Fixed
                    { 409171141uL , Status.MinorIssues  }, // Cash on Demand
                    { 408706691uL , Status.MinorIssues  }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                LastSeen = DateTime.Now,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "When Unlimited Money is enabled, mods which reduce costs or increase revenues are not required." },
                },
                Published = WorkshopDate("19 May, 2015"), // existed as of May 2015, could be earlier?
                Updated = GameVersion.Updated,
            });

            AddMod(new Review(Vanilla.UnlimitedOilAndOre, "Unlimited Oil and Ore (bundled with Cities: Skylines)") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                LastSeen = DateTime.Now,
                Published = WorkshopDate("18 May, 2017"), // Mass Transit
                Updated = GameVersion.Updated,
            });

            AddMod(new Review(Vanilla.UnlimitedSoil, "Unlimited Soil (bundled with Cities: Skylines)") {
                Affect = Factor.Environment,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                LastSeen = DateTime.Now,
                Published = WorkshopDate("18 May, 2017"), // Mass Transit
                Updated = GameVersion.Updated,
            });

            AddMod(new Review(Vanilla.UnlockAll, "Unlock All (bundled with Cities: Skylines)") {
                Affect = Factor.Environment,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1614062928uL, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814uL, Status.Incompatible }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                LastSeen = DateTime.Now,
                Published = WorkshopDate("19 May, 2015"), // existed as of May 2015, could be earlier?
                Updated = GameVersion.Updated,
            });
        }
    }
}