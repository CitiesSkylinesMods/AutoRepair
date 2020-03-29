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
        private void VanillaCatalog() {

            string catalog = "Vanilla";

            AddMod(new Item(Vanilla.HardMode, "Hard Mode (bundled with Cities: Skylines)") {
                Affect = Factor.Construction
                       | Factor.BuildingLevel
                       | Factor.DemandRCI
                       | Factor.MaintenanceCost,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1522785644u, Status.Incompatible }, // Infinite Demand Mod
                    { 1403960464u, Status.Incompatible }, // Maintenance Fees (Parklife Ready)
                    { 1398502258u, Status.Incompatible }, // Dam Upkeep Scaling
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Item(Vanilla.UnlimitedMoney, "Unlimited Money (bundled with Cities: Skylines)") {
                Affect = Factor.Budget
                       | Factor.Construction
                       | Factor.MaintenanceCost
                       | Factor.Money,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2036484892u, Status.MinorIssues  }, // AutoMoney
                    { 2030216556u, Status.MinorIssues  }, // GrantMeMoney: get cash / money unconditionally
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils
                    { 1367444256u, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.MinorIssues  }, // 调整金钱
                    { 409171141u , Status.MinorIssues  }, // Cash on Demand
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Item(Vanilla.UnlimitedOilAndOre, "Unlimited Oil and Ore (bundled with Cities: Skylines)") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "ColossalOrder",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Vanilla,
                ReleasedDuring = GameVersion.Active,
            });

            AddMod(new Item(Vanilla.UnlimitedSoil, "Unlimited Soil (bundled with Cities: Skylines)") {
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

            AddMod(new Item(Vanilla.UnlockAll, "Unlock All (bundled with Cities: Skylines)") {
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
        }
    }
}