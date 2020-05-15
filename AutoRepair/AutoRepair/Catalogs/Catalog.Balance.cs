namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Balance affecting mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void BalanceMods() {

            string catalog = "Balance";

            AddMod(new Review(2039606384uL, "Easy Mode: Money Mod") {
                Affect = Factor.Revenue,
                Authors = "Anvilarse",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sets all construction, maintennace and relocation costs to zero." },
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Easy Mode mod is not much use." },
                    { 2039606384uL, "[Mod: Free Maintenance] Easy Mode includes free maintenance, so you can remove one of these mods." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            // confirmed by anvil that it sets maintenance to zero for everything (including transport)
            AddMod(new Review(2039205403uL, "Free Maintenance by Anvilarse") {
                Affect = Factor.Revenue,
                Authors = "Anvilarse",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sets all maintenance fees to zero." },
                    { 2039606384uL, "[Mod: Easy Mode: Money] Easy Money also sets maintenance fees to zero. Use one of the mods, not both." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Review(2027161563uL, "Lifecycle Rebalance Revisited") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2077426488uL, Status.MinorIssues  }, // Super Hearse AI [Beta]
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2025147082uL, Status.Recommended  }, // Realistic Population revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    //[ARIS] Early Death (incompat)
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218uL , Status.Incompatible }, //Slow Citizen Aging
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 654707599uL, // Citizen Lifecycle Rebalance v2.6
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 2077426488uL, "[Mod: Super Hearse AI] If 'Percentage of dead requiring transport' is set to 0 in 'Lifecycle Rebalance', you won't need 'Super Hearse AI'." },
                    { 803074771uL , "[Mod: No Deathcare] Both mods can disable death; use one and remove the other." },
                },
                Published = WorkshopDate("19 Mar, 2020"),
                SourceURL = "https://github.com/algernon-A/Lifecycle-Rebalance-Revisited",
                Updated = WorkshopDate("9 May, 2020"),
            });

            AddMod(new Review(2025147082uL, "Realistic Population revisited") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Immigrants
                       | Factor.LandValue
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563uL, Status.Recommended  }, // Lifecycle Rebalance Revisited
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Compatible   }, // Ploppable RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption (WG)
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 426163185uL, // Realistic Population and Consumption (WG)
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/algernon-A/Realistic-Population-Revisited",
            });

            AddMod(new Review(1830455071uL, "EasyMode") {
                Affect = Factor.Bulldoze
                       | Factor.Construction
                       | Factor.MaintenanceCost
                       | Factor.PlaceAndMove
                       | Factor.Money
                       | Factor.Revenue,
                Authors = "GoNutsDonuts",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Reduces cost of construction, maintenance, relocation, increases refund." },
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, EasyMode mod is not much use." },
                },
                Published = WorkshopDate("10 Aug, 2019"),
                Updated = WorkshopDate("10 Aug, 2019"),
            });

            AddMod(new Review(1806759255uL, "Customize It Extended") {
                Affect = Factor.BuildingInfo
                       | Factor.BuildingCapacity
                       | Factor.Employment
                       | Factor.Emptying
                       | Factor.Entertainment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Service
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1865667356uL, Status.Compatible   }, // Twitch Citizens
                    { 1806759255uL, Status.Incompatible }, // Customize It Extended
                    { 1562650024uL, Status.Compatible   }, // Rebalanced Industries
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options (new ver)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Incompatible }, // Customize It (original mod)
                    { 958161597uL , Status.Compatible   }, // Twitch Viewer Integrator
                    { 946550801uL , Status.Incompatible }, // Park Rebalance
                    { 714711792uL , Status.Compatible   }, // TwitchTV Viewers
                    { 530771650uL , Status.Compatible   }, // Prefab Hook
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (original)
                    { 414730498uL , Status.Unknown      }, // Twitch Chirper Chat
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1369729955uL, // Customize It (original mod)
                Flags = ItemFlags.SourceAvailable,
                Languages = new[] { "en", "de" },
                Locale = "en",
                SourceURL = "https://github.com/Celisuis/CustomizeItExtended",
            });

            AddMod(new Review(1765325082uL, "Customizable Education") {
                Affect = Factor.Education
                       | Factor.Immigrants,
                Authors = "monkey_sheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 1915645482uL, Status.Incompatible }, // Citizen Lifecycle Rebalance v2
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorIssues // sometimes loses settings
                      | ItemFlags.Abandonware,
            });

            // todo: prolly incompatible with similar mods
            AddMod(new Review(1744522363uL, "Money Back (Refund)") {
                Affect = Factor.Money
                       | Factor.PlaceAndMove
                       | Factor.Revenue,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode      , Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Abandonware,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Allows altering the relocation costs and bulldozer refund amounts while game is paused." },
                },
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMod(new Review(1674732053uL, "Employ Overeducated Workers V2 (1.11+)") {
                Affect = Factor.Employment,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944uL, Status.Compatible   }, // More Outside Interaction
                    { 1680840913uL, Status.Compatible   }, // More Effective Transfer Manager
                    { 1674732053uL, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958uL, Status.Compatible   }, // Real Gas Station
                    { 1614061108uL, Status.Compatible   }, // Real Construction
                    { 1192503086uL, Status.Compatible   }, // Real City V9.0.03.10
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                ContinuationOf = 1114249433uL, // Employ Overeducated Workers (1.10+)
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                SourceURL = "https://github.com/pcfantasy/EmployOvereducatedWorkers-v2",
            });

            AddMod(new Review(1598546349uL, "Mary's Mod") {
                Affect = Factor.Money,
                Authors = "tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Mary's Mod mod is not much use." },
                },
                Published = WorkshopDate("22 Dec, 2018"),
                Updated = WorkshopDate("22 Dec, 2018"),
            });

            AddMod(new Review(1562650024uL, "Rebalanced Industries") {
                Affect = Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Unlockers
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1806759255uL, Status.Compatible   }, // Customize It Extended
                    { 1553517176uL, Status.Incompatible }, // Specialized Industry Fix Redux
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Incompatible }, // Customize It!
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Quboid/CSL_RebalancedIndustries",
            });

            AddMod(new Review(1553517176uL, "Specialized Industry Fix Redux") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "Vectorial1024",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1562650024uL, Status.Incompatible }, // Rebalanced Industries
                    { 1312735149uL, Status.Incompatible }, // Klyte Commons
                    { 1192503086uL, Status.MinorIssues  }, // Real City V9.0.03.14
                    { 662386761uL , Status.Incompatible }, // Specialised Industry Fix [BUGFIX for Vanilla]
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 662386761uL, // Specialised Industry Fix [BUGFIX for Vanilla]
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1312735149uL, "[Mod: Klyte Commons] Incompatible: https://steamcommunity.com/workshop/filedetails/discussion/1553517176/2479690531125166855/" },
                },
                Published = WorkshopDate("1 Nov, 2018"),
                ReplaceWith = 1562650024uL, // Rebalanced Industries
                SourceURL = "https://github.com/Vectorial1024/SpecializedIndustryFixRedux",
                Updated = WorkshopDate("15 Nov, 2018"),
            });

            AddMod(new Review(1551563197uL, "EnhancedBuildingCapacity - Fixed") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = "Flexible Games",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // Ploppable RICO revisited
                    { 1806759255uL, Status.Incompatible }, // Customize It Extended
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1369729955uL, Status.Incompatible }, // Customize It
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 429238904uL , Status.Incompatible }, // Enhanced Building Capacity
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption (WG)
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 429238904uL, // Enhanced Building Capacity
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("29 Oct, 2018"),
                Updated = WorkshopDate("29 Oct, 2018"),
            });

            AddMod(new Review(1522785644uL, "Infinite Demand Mod") {
                Affect = Factor.DemandRCI
                       | Factor.Immigrants,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 819155459uL , Status.Incompatible }, // 超级需求
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("25 Sep, 2018"),
                Updated = WorkshopDate("11 Aug, 2019"),
            });

            AddMod(new Review(1412844620uL, "Realistic Walking Speed") {
                Affect = Factor.Velocity,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558uL, Status.Compatible   }, // Real Time Offline
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("15 Jun, 2018"),
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RealisticWalkingSpeed",
                Updated = WorkshopDate("23 Mar, 2020"),
            });

            AddMod(new Review(1403960464uL, "Maintenance Fees (Parklife Ready)") {
                Affect = Factor.Budget // side effect
                       | Factor.MaintenanceCost
                       | Factor.Revenue, // side effect
                Authors = "Xial",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 602336261uL , Status.Incompatible }, // Maintenance Fees (original)
                },
                CompatibleWith = GameVersion.Patch_1_10_1_f3,
                ContinuationOf = 602336261uL, // Maintenance Fees
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Industries: Users report issues since Industries game update." },
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Maintenance Fees mod is not much use." },
                },
                Published = WorkshopDate("6 Jun, 2018"),
                SourceURL = "https://github.com/Xial/Maintenancefee",
                Updated = WorkshopDate("7 Jun, 2018"),
            });

            // refund full construction cost when bulldozing
            AddMod(new Review(1227735337uL, "Full Refund Cost[Industries Compatible]") {
                Affect = Factor.Money,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode      , Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, Full Refund Cost mod is not much use." },
                },
                Published = WorkshopDate("10 Dec, 2017"),
                Updated = WorkshopDate("5 Mar, 2019"),
            });

            // An update to 406841580u - SimCity Fudged Population, but with better UI.
            // Dev still responsive as of Feb 2020, confirms mod still works.
            AddMod(new Review(1224627683uL, "Fudged Population Enhanced") {
                Affect = Factor.Toolbar,
                Authors = "khollenbeck",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // old mod:
                    { 406841580uL, Status.Incompatible }, // SimCity Fudged Population
                    // UI overhauls:
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 781767563uL, Status.Incompatible }, // Extended InfoPanel
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                    // skins:
                    { 593987954u , Status.Incompatible }, // Triple-Screen UI Skin
                    { 578482272u , Status.Incompatible }, // [FIXED][LEGACY] Emerald UI (16:9)
                    { 577230299u , Status.Incompatible }, // [LEGACY][FIXED][UI] Silicon Skin V1.0
                    { 511029270u , Status.Incompatible }, // Sapphire - Triple Screen Centered
                    { 450453336u , Status.Incompatible }, // Hello UI [Fixed 1.7]
                    { 428457597u , Status.Incompatible }, // ClearUI - Quartz Skin 16:9 / 16:10
                    { 428298776u , Status.Incompatible }, // [UI] Silicon Skin (21:9) V1.0
                    { 424995783u , Status.Incompatible }, // [UI] Silicon Skin V1.0
                    { 423910890u , Status.Incompatible }, // Blue UI - Quartz Skin
                    { 422251153u , Status.Incompatible }, // Emerald UI (16:9)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 406841580uL, // SimCity Fudged Population
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("8 Dec, 2017"),
                SourceURL = "https://github.com/krishollenbeck/cities_skylines_enhanced_fudged_population_mod",
                Updated = WorkshopDate("6 Jan, 2018"),
            });

            AddMod(new Review(838095079uL, "Cheaper Hydro Electric Power") {
                Affect = Factor.Budget
                       | Factor.MaintenanceCost
                       | Factor.Money
                       | Factor.Production,
                Authors = "mm",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.Patch_1_9_1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { Vanilla.UnlimitedMoney, "[Vanilla Mod: Unlimited Money] If you have unlimited money, this mod is not much use." },
                },
                Published = WorkshopDate("8 Jan, 2017"),
                Updated = WorkshopDate("8 Jan, 2017"),
            });

            // Super demand, housing, commerce, and industrial offices all maintain high demand.
            AddMod(new Review(819155459uL, "超级需求 (super RCI demand)") {
                Affect = Factor.DemandRCI
                       | Factor.Immigrants,
                Authors = "摇光",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 1522785644uL, Status.Incompatible }, // Infinite Demand Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("16 Dec, 2016"),
                ReplaceWith = 1522785644uL, // Infinite Demand Mod
                Updated = WorkshopDate("16 Dec, 2016"),
            });

            AddMod(new Review(813725855uL, "No Solar Power At Night") {
                Affect = Factor.Production,
                Authors = "informmanuel",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 813725855uL , Status.Incompatible }, // No Solar Power At Night
                    { 597020110uL , Status.Compatible   }, // Solar Capacitor Mod
                    { 569879360uL , Status.Compatible   }, // Thermal Solar Rebalance v1.3
                    { 524433047uL , Status.Incompatible }, // Night Time Solar Power (gives full solar at night)
                    { 489636701uL , Status.Compatible   }, // Power Balance
                    { 413301010uL , Status.Incompatible }, // Realistic Power Modification (RPM mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The base game reduces solar power to 70 % at night; this mod reduces it to 0 %." },
                },
                Published = WorkshopDate("7 Dec, 2016"),
                Updated = WorkshopDate("7 Dec, 2016"),
            });

            AddMod(new Review(569879360uL, "Thermal Solar Rebalance v1.3") {
                Affect = Factor.Production,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 813725855uL , Status.Compatible   }, // No Solar Power At Night
                    { 597020110uL , Status.Compatible   }, // Solar Capacitor Mod
                    { 569879360uL , Status.Incompatible }, // Thermal Solar Rebalance v1.3
                    { 524433047uL , Status.Incompatible }, // Night Time Solar Power (gives full solar at night)
                    { 489636701uL , Status.Incompatible }, // Power Balance
                    { 413301010uL , Status.Incompatible }, // Realistic Power Modification (RPM mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("20 Mar, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The power output can be customised via 'WG_RealisticSolar.xml' file in game folder." },
                },
                Published = WorkshopDate("6 Dec, 2015"),
                Removed = WorkshopDate("26 Mar, 2020"),
                SourceURL = "https://github.com/WhitefangGreytail/ImprovedSolar",
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("30 Dec, 2016"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // Real population, only one household at low density, high density population becomes larger
            AddMod(new Review(1587482024uL, "真实人口，低密度只有一户人，高密度人口容量变大 (realistic population)") {
                Affect = Factor.BuildingCapacity,
                Authors = "changxiuyingjian",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // Ploppable RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 2025147082uL, // Realistic Population revisited
            });

            AddMod(new Review(1487849798uL, "Higher Income Mod 1.2a") {
                Affect = Factor.Revenue,
                Authors = "I'm Not MentaL",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report issues with xml file
                ReplaceWith = 1498036881uL, // UltimateMod 2.4 ( Higher Income and More Options )
            });

            AddMod(new Review(1398502258uL, "Dam Upkeep Scaling") {
                Affect = Factor.MaintenanceCost,
                Authors = "Derangedteddy",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Industries DLC
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ParkLife,
            });

            // icky - not sure if this belongs in balance catagory, but lots of mods here conflict with it
            // (it's kind of manual balance adjustment for buildings and vehicles, although AVO could be considered same? meh)
            AddMod(new Review(1369729955uL, "Customize It!") {
                Affect = Factor.BuildingInfo
                       | Factor.BuildingCapacity
                       | Factor.Employment
                       | Factor.Emptying
                       | Factor.Entertainment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Service
                       | Factor.StorageCapacity,
                Authors = "TPB",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1865667356uL, Status.Compatible   }, // Twitch Citizens
                    { 1806759255uL, Status.Incompatible }, // Customize It Extended
                    { 1562650024uL, Status.Incompatible }, // Rebalanced Industries
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options (new ver)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Incompatible }, // Customize It (original mod)
                    { 958161597uL , Status.Compatible   }, // Twitch Viewer Integrator
                    { 946550801uL , Status.Incompatible }, // Park Rebalance
                    { 714711792uL , Status.Compatible   }, // TwitchTV Viewers
                    { 530771650uL , Status.Required     }, // Prefab Hook
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (original)
                    { 414730498uL , Status.Compatible   }, // Twitch Chirper Chat
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete // new version avail
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("25 Apr, 2018"),
                ReplaceWith = 1806759255uL, // Customize It Extended
                SourceURL = "https://github.com/TPBCS/CustomizeIt",
                Updated = WorkshopDate("22 May, 2018"),
            });

            // Residents become senile
            // Actually translated clone of 409070739u - Very Slow Citizen Aging (by Nohealforu)
            AddMod(new Review(1196714522uL, "居民衰老变十六分之一 (very slow citizen aging)") {
                Affect = Factor.Aging,
                Authors = "回忆时光℡",
                Catalog = catalog,
                CloneOf = 409070739uL, // Very Slow Citizen Aging
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218uL , Status.Incompatible }, // Slow Citizen Aging
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Game update during 2018 broke it
                      | ItemFlags.Obsolete // Replaced by WG's Citizen Lifecycle Rebalance
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
            });

            AddMod(new Review(1114249433uL, "Employ Overeducated Workers (1.10+)") {
                Affect = Factor.Employment,
                Authors = "Ellie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053uL, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958uL, Status.Incompatible }, // Real Gas Station
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                ContinuationOf = 569008960uL, // Employ Overeducated Workers
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                ReplaceWith = 1674732053uL, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            // Broken since May 2019
            AddMod(new Review(1108715012uL, "Adjustable Business Consumption") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = "Ellie",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: Infinite Goods by Googen
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 408706691uL , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.BrokenByUpdate // some time around May 2019
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Concerts,
                SourceURL = "https://github.com/AmaroqOkami/CS-AdjustableBusinessConsumption",
            });

            AddMod(new Review(946550801uL, "Park Rebalance") {
                Affect = Factor.Entertainment,
                Authors = "Azzurite, egi",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255uL, Status.Incompatible }, // Customize It Extended
                    { 1369729955uL, Status.Incompatible }, // Customize It
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // whatever came after the Industries update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.MinorIssues // mod doesn't disable properly
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                ReleasedDuring = GameVersion.ParkLife,
                ReplaceWith = 1806759255uL, // Customize It Extended
                SourceURL = "https://gitlab.com/azzurite/parkrebalance",
            });

            AddMod(new Review(938049744uL, "Proper Hardness Fixed") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.Disasters
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Unlockers // reduced cash reward
                       | Factor.Money
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity
                       | Factor.Wealth
                       | Factor.Zoning,
                Authors = "MarkedOne",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 1393820309uL, Status.Incompatible }, // Ticket Price Customizer
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.GreenCities,
                // note: if there is a knighthawkGP version, then it's continuation of that instead
                ContinuationOf = 408706691uL, // Proper Hardness
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking // Breaks police service (milestone 5 or above), spams log with errors, etc.
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.MassTransit,
                SourceURL = "https://github.com/m4rked0ne/Cities-Skyline-Proper-Hardness-master",
            });

            AddMod(new Review(931330091uL, "410344523 PopBalanceMod") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption,
                Authors = "onekil7804",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                CloneOf = 410344523uL, // PopBalanceMod
                Compatibility = new Dictionary<ulong, Status>() {
                    // INCOMPATIBLE:
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大 (similar to pop bal mod)
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 637901778uL , Status.Incompatible }, // Fire Spread [ Fixed for C:S 1.3.2+ ]
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 410234967uL , Status.Incompatible }, // Fire Spread
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // COMPATIBLE:
                    // Control Building Level up v0.4
                    // Terraform Tool 0.5
                    // Public Transport Capacity (Real)
                    // Traffic++ (Zonable Pedestrian Paths)
                    // Trafic Report Tool
                    // Extended Public Transport UI
                    // Tree Brush
                    // City Statistics Easy Access
                    // City Vitals Watch
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // AD
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // replaced by WG's pop & consumption mod, which itself has now been replaced
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("23 May, 2017"),
                ReplaceWith = 2025147082uL, // Realistic Population revisited
                Updated = WorkshopDate("23 May, 2017"),
            });

            AddMod(new Review(877402994uL, "Lifespan Changer Fix") {
                Affect = Factor.Aging
                       | Factor.Health,
                Authors = "Aben",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                CompatibleWith = GameVersion.GreenCities,
                ContinuationOf = 573925048uL, // Lifespan Changer
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("5 Mar, 2017"),
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
                Updated = WorkshopDate("5 Mar, 2017"),
            });

            AddMod(new Review(852103955uL, "InfiniteOilAndOre") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production,
                Authors = "jantoniolis",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                CloneOf = 409644467uL, // UnlimitedOilAndOre
                Compatibility = new Dictionary<ulong, Status>() {
                    // vanilla has this
                    { Vanilla.UnlimitedOilAndOre, Status.Incompatible },

                    // similar mods
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 715316103uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                },
                CompatibleWith = GameVersion.Patch_1_6_3_f1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.Laggy // runs code every frame
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This feature is now part of vanilla game, unsubscribe this mod." },
                },
                Published = WorkshopDate("28 Jan, 2017"),
                ReplaceWith = Vanilla.UnlimitedOilAndOre,
                Updated = WorkshopDate("28 Jan, 2017"),
            });

            AddMod(new Review(784378578uL, "Infinite Resources ( Materials for generic industries )") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "AnEjd",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053500739uL, Status.Incompatible }, // AdvancedOutsideConnection
                    // infinite resource mods:
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 725555912uL , Status.Incompatible }, // Infinite Goods
                    { 715316103uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                    { Vanilla.UnlimitedOilAndOre, Status.Incompatible },
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                ContinuationOf = 725555912uL, // Infinite Goods
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Probably broken as there have been lots of industry updates since it was released; if it works or not, please leave a comment!" },
                },
                Published = WorkshopDate("21 Oct, 2016"),
                ReplaceWith = 2053500739uL, // AdvancedOutsideConnection
                SourceURL = "http://anejd.com/infresmod.rar",
                Updated = WorkshopDate("21 Oct, 2016"),
            });

            AddMod(new Review(725555912uL, "Infinite Goods") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "Googen",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2016920607uL, Status.Unknown      }, // RICO revisited
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 586012417uL , Status.Compatible   }, // Ploppable RICO (original)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Published = WorkshopDate("16 Jul, 2016"),
                SourceURL = "https://github.com/goransh/InfiniteGoodsMod",
                Updated = WorkshopDate("27 Mar, 2020"),
            });

            AddMod(new Review(715316103uL, "InfiniteOilAndOre") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "fmguerreiro",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedOilAndOre , Status.Incompatible },
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 715316103uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // vanilla mod
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("15 May, 2020"),
                Published = WorkshopDate("2 Jul, 2016"),
                ReplaceWith = Vanilla.UnlimitedOilAndOre,
                Updated = WorkshopDate("2 Jul, 2016"),
            });

            AddMod(new Review(654707599uL, "Citizen Lifecycle Rebalance v2.6") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                ArchiveURL = "https://web.archive.org/web/20190806010838/https://steamcommunity.com/sharedfiles/filedetails/?id=654707599",
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1765325082uL, Status.Incompatible }, // Customizable Education
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    //Randomize Age Cim Move In (incompat)
                    //Lifespan Changer (incompat)
                    //Slow Citizen Aging (incompat)
                    //Very Slow Citizen Aging (incompat)
                    //[ARIS] Early Death (incompat)
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                ContinuationOf = 643642403uL, // Lifespan multiplier v1.1
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("1 Mar, 2020"),
                Published = WorkshopDate("28 Mar, 2016"),
                Removed = WorkshopDate("19 Mar, 2020"),
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
                SourceURL = "https://github.com/WhitefangGreytail/WG_CitizenEdit",
                Updated = WorkshopDate("31 Oct, 2018"),
            });

            AddMod(new Review(643642403uL, "Lifespan multiplier v1.1") {
                Affect = Factor.Aging
                       | Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // early death mods (incompat)
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218uL , Status.Incompatible }, // Slow Citizen Aging
                },
                ContinuationOf = 409071509uL, // Slow Citizen Aging Configurable
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Removed around March 2020
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("1 Mar, 2020"),
                Published = WorkshopDate("12 Mar, 2016"),
                Removed = WorkshopDate("19 Mar, 2020"),
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
                SourceURL = "https://github.com/WhitefangGreytail/WG_Lifespan",
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("12 Mar, 2016"), // almost certainly wrong, but can't find archive of the page to check
            });

            AddMod(new Review(573925048uL, "Lifespan Changer") {
                Affect = Factor.Aging
                       | Factor.Health,
                Authors = "Akira Ishizaki",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                CompatibleWith = GameVersion.Patch_1_5_2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // https://steamcommunity.com/workshop/filedetails/discussion/573925048/152390648075690448/
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("12 Dec, 2015"),
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
                SourceURL = "https://github.com/akira-ishizaki/Skylines-LifespanChanger",
                Updated = WorkshopDate("21 Dec, 2015"),
            });

            AddMod(new Review(569008960uL, "Employ Overeducated Workers") {
                Affect = Factor.Employment,
                Authors = "Akira Ishizaki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053uL, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958uL, Status.Incompatible }, // Real Gas Station
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have Industries DLC, the 'Industry 4.0' city/district policy might be better alternative." },
                },
                ReplaceWith = 1674732053uL, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            AddMod(new Review(541673195uL, "Resident Travel Rebalance v1.1") {
                Affect = Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                ArchiveURL = "https://web.archive.org/web/20160222120305/http://steamcommunity.com/sharedfiles/filedetails/?id=541673195",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 426163185uL , Status.Recommended  }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Compatible   }, // Building Simulation Overhaul
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("1 Mar, 2020"),
                Published = WorkshopDate("25 Oct, 2015"),
                Removed = WorkshopDate("19 Mar, 2020"),
                Updated = WorkshopDate("30 Oct, 2015"),
            });

            // Incompatible with any mod which changes:
            // * residential household capacity,
            // * worker count,
            // * power, water, sewage, garbage,
            // * income, pollution or production.
            AddMod(new Review(426163185uL, "Realistic Population and Consumption Mod v8.4.0") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Immigrants
                       | Factor.LandValue
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference,
                ArchiveURL = "https://web.archive.org/web/20190806010923/https://steamcommunity.com/sharedfiles/filedetails/?id=426163185",
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Compatible   }, // RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Compatible   }, // Ploppable Rico High Density Fix
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 586012417uL , Status.Compatible   }, // Ploppable RICO
                    { 541673195uL , Status.Compatible   }, // Resident Travel Rebalance v1.1
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // INCOMPATIBLE:
                    // Enhanced Building Capacity
                },
                ContinuationOf = 410344523uL, // PopBalanceMod
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Made hidden around March 2020
                      | ItemFlags.Obsolete // new version available
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("1 Mar, 2020"),
                Published = WorkshopDate("16 Apr, 2015"),
                Removed = WorkshopDate("19 Mar, 2020"),
                ReplaceWith = 2025147082uL, // Realistic Population revisited
                SourceURL = "https://github.com/WhitefangGreytail/WG_RealisticCitySkylines",
                Updated = WorkshopDate("25 Oct, 2018"),
            });

            AddMod(new Review(411190402uL, "Building Simulation Overhaul") {
                Affect = Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Immigrants
                       | Factor.LandValue,
                ArchiveURL = "https://web.archive.org/web/20160620100139/http://steamcommunity.com/sharedfiles/filedetails/?id=411190402",
                Authors = "Nohealforu",
                BrokenBy = GameVersion.Patch_1_2_2_f2, // changes to game limits
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 541673195uL , Status.Compatible   }, // Resident Travel Rebalance v1.1
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // incompat: fill the houses
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jun, 2016"),
                Published = WorkshopDate("21 Mar, 2015"), // based on adjacent workshop ids; web archive shows "10 Apr, 2015"!
                Removed = WorkshopDate("20 Jun, 2018"), // rough guesstimate
                ReplaceWith = 2025147082uL, // Realistic Population revisited
                Updated = WorkshopDate("24 Sep, 2015"), // might be later versions
            });

            AddMod(new Review(410344523uL, "PopBalanceMod") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption,
                Authors = "Kundun",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // INCOMPATIBLE:
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大 (similar to pop bal mod)
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 637901778uL , Status.Incompatible }, // Fire Spread [ Fixed for C:S 1.3.2+ ]
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 410234967uL , Status.Incompatible }, // Fire Spread
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // COMPATIBLE:
                    // Control Building Level up v0.4
                    // Terraform Tool 0.5
                    // Public Transport Capacity (Real)
                    // Traffic++ (Zonable Pedestrian Paths)
                    // Trafic Report Tool
                    // Extended Public Transport UI
                    // Tree Brush
                    // City Statistics Easy Access
                    // City Vitals Watch
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // difficult to say when, but definitely broken
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // replaced by WG's pop & consumption mod, which itself has now been replaced
                      | ItemFlags.SourceBundled,
                Published = WorkshopDate("19 Mar, 2015"),
                ReplaceWith = 2025147082uL, // Realistic Population revisited
                Updated = WorkshopDate("26 Mar, 2015"),
            });

            AddMod(new Review(409644467uL, "InfiniteOilAndOre") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production,
                ArchiveURL = "https://web.archive.org/web/20181222222153/https://steamcommunity.com/sharedfiles/filedetails/?id=409644467",
                Authors = "Nohealforu",
                BrokenBy = GameVersion.MassTransit, // incorportated in to vanilla game
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // vanilla has this
                    { Vanilla.UnlimitedOilAndOre, Status.Incompatible },

                    // similar mods
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 715316103uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre

                    // other
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                },
                CompatibleWith = GameVersion.Patch_1_6_3_f1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy // runs code every frame
                      | ItemFlags.NoWorkshop // removed some time after 22 Dec, 2018
                      | ItemFlags.Obsolete // vanilla mod since Mass Transit
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("22 Dec, 2018"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This feature is now part of vanilla game; unsubscribe this mod." },
                },
                Published = WorkshopDate("17 Mar, 2015"), // based on 409644466uL :)
                Removed = WorkshopDate("10 Aug, 2019"), // rough guesstimate based on web archive
                ReplaceWith = Vanilla.UnlimitedOilAndOre,
                Updated = WorkshopDate("6 Apr, 2015"), // based on webarchive
            });

            AddMod(new Review(409071509uL, "Slow Citizen Aging Configurable") {
                Affect = Factor.Aging,
                Authors = "Nohealforu",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218uL , Status.Incompatible }, // Slow Citizen Aging
                },
                CompatibleWith = GameVersion.AfterDark,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // 1.3.2 Snowfall update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 2027161563uL, // Lifecycle Rebalance Revisited
            });

            // note possibly a KnighthawkGP continuation (AD & snowfall compat) of this prior to later Proper Hardness Fixed version
            // see https://github.com/Knighth/Cities-Skyline-Proper-Hardness
            AddMod(new Review(408706691uL, "Proper Hardness") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.Disasters
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Unlockers // reduced cash reward
                       | Factor.Money
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity
                       | Factor.Wealth
                       | Factor.Zoning,
                Authors = "emf",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues  },
                    { Vanilla.HardMode      , Status.Incompatible },

                    // incompat with t++ & likely other traffic mods
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1587482024uL, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 1393820309uL, Status.Incompatible }, // Ticket Price Customizer
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 931330091uL , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410344523uL , Status.Incompatible }, // PopBalanceMod
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // new mod avail
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 938049744uL, // Proper Hardness Fixed
                SourceURL = "https://github.com/lxteo/Cities-Skyline-Proper-Hardness",
            });

        }
    }
}