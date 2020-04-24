namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
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
                    { 2039606384u, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403u, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071u, Status.Incompatible }, // EasyMode
                    { 1744522363u, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1598546349u, Status.Incompatible }, // Mary's Mod
                    { 1522785644u, Status.Incompatible }, // Infinite Demand Mod
                    { 1403960464u, Status.Incompatible }, // Maintenance Fees (Parklife Ready)
                    { 1398502258u, Status.Incompatible }, // Dam Upkeep Scaling
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 1227735337u, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "When Hard Mode is enabled, mods that make the game easier will conflict with it." },
                },
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Review(Vanilla.UnlimitedMoney, "Unlimited Money (bundled with Cities: Skylines)") {
                Affect = Factor.Budget
                       | Factor.Construction
                       | Factor.MaintenanceCost
                       | Factor.Money,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039606384u, Status.MinorIssues  }, // Easy Mode: Money Mod
                    { 2039205403u, Status.MinorIssues  }, // Free Maintenance by Anvilarse
                    { 2036484892u, Status.MinorIssues  }, // AutoMoney
                    { 2030216556u, Status.MinorIssues  }, // GrantMeMoney: get cash / money unconditionally
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1830455071u, Status.MinorIssues  }, // EasyMode
                    { 1744522363u, Status.MinorIssues  }, // Money Back (Refund)
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1598546349u, Status.MinorIssues  }, // Mary's Mod
                    { 1403960464u, Status.MinorIssues  }, // Maintenance Fees (Parklife Ready)
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils
                    { 1367444256u, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1237383751u, Status.MinorIssues  }, // Extended Game Options
                    { 1232451940u, Status.MinorIssues  }, // 调整金钱
                    { 1227735337u, Status.MinorIssues  }, // Full Refund Cost[Industries Compatible]
                    { 855704599uL , Status.MinorIssues  }, // Set your own Start Money amount
                    { 838095079uL , Status.MinorIssues  }, // Cheaper Hydro Electric Power
                    { 938049744u , Status.MinorIssues  }, // Proper Hardness Fixed
                    { 409171141u , Status.MinorIssues  }, // Cash on Demand
                    { 408706691u , Status.MinorIssues  }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "When Unlimited Money is enabled, mods which reduce costs or increase revenues are not required or may be incompatible." },
                },
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Review(Vanilla.UnlimitedOilAndOre, "Unlimited Oil and Ore (bundled with Cities: Skylines)") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                ReleasedDuring = GameVersion.Active,
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
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Review(Vanilla.UnlockAll, "Unlock All (bundled with Cities: Skylines)") {
                Affect = Factor.Environment,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1614062928u, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814u, Status.Incompatible }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                ReleasedDuring = GameVersion.Active,
            });
        }
    }
}