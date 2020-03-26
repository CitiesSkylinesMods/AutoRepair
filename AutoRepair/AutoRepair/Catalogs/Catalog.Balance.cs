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
        private void BalanceCatalog() {

            string catalog = "Balance";

            AddMod(new Item(2027161563u, "Lifecycle Rebalance Revisited") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2025147082u, Status.Recommended  }, // Realistic Population revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1383456057u, Status.Incompatible }, // Shicho
                    //Randomize Age Cim Move In (incompat)
                    //Lifespan Changer (incompat)
                    //Slow Citizen Aging (incompat)
                    //Very Slow Citizen Aging (incompat)
                    //[ARIS] Early Death (incompat)
                    { 654707599u, Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u, Status.Incompatible }, // Lifespan multiplier v1.1
                    { 541673195u, Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509u, Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                ContinuationOf = 654707599u, // Citizen Lifecycle Rebalance v2.6
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(2025147082u, "Realistic Population revisited") {
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
                    { 2027161563u, Status.Recommended  }, // Lifecycle Rebalance Revisited
                    { 2016920607u, Status.Compatible   }, // Ploppable RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption (WG)
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 426163185u, // Realistic Population and Consumption (WG)
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1806759255u, "Customize It Extended") {
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
                    { 1865667356u, Status.Unknown      }, // Twitch Citizens
                    { 1562650024u, Status.Compatible   }, // Rebalanced Industries
                    { 1369729955u, Status.Incompatible }, // Customize It (original mod)
                    { 946550801u , Status.Incompatible }, // Park Rebalance
                },
                ContinuationOf = 1369729955u, // Customize It (original mod)
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Celisuis/CustomizeItExtended",
            });

            AddMod(new Item(1765325082u, "Customizable Education") {
                Affect = Factor.Education
                       | Factor.Immigrants,
                Authors = "monkey_sheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 1915645482u, Status.Incompatible }, // Citizen Lifecycle Rebalance v2
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorBugs // somtimes loses settings
                      | ItemFlags.Abandonware,
            });

            AddMod(new Item(1674732053u, "Employ Overeducated Workers V2 (1.11+)") {
                Affect = Factor.Employment,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Compatible   }, // More Outside Interaction
                    { 1680840913u, Status.Compatible   }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Compatible   }, // Real Gas Station
                    { 1614061108u, Status.Compatible   }, // Real Construction
                    { 1192503086u, Status.Compatible   }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                ContinuationOf = 1114249433u, // Employ Overeducated Workers (1.10+)
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                SourceURL = "https://github.com/pcfantasy/EmployOvereducatedWorkers-v2",
            });

            AddMod(new Item(1562650024u, "Rebalanced Industries") {
                Affect = Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Milestones
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Compatible   }, // Customize It Extended
                    { 1553517176u, Status.Incompatible }, // Specialized Industry Fix Redux
                    { 1369729955u, Status.Incompatible }, // Customize It!
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Quboid/CSL_RebalancedIndustries",
            });

            // todo: prolly incompat with WG mods
            AddMod(new Item(1551563197u, "EnhancedBuildingCapacity - Fixed") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = " Flexible Games",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 938049744u, Status.Incompatible }, // Proper Hardness Fixed
                    { 410344523u, Status.Incompatible }, // PopBalanceMod
                    { 408706691u, Status.Incompatible }, // Proper Hardness
                    { 411190402u, Status.Incompatible }, // Building Simulation Overhaul (no longer in workshop)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1522785644u, "Infinite Demand Mod") {
                Affect = Factor.DemandRCI
                       | Factor.Immigrants,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1412844620u, "Realistic Walking Speed") {
                Affect = Factor.Velocity,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Compatible   }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RealisticWalkingSpeed",
            });

            AddMod(new Item(1403960464u, "Maintenance Fees (Parklife Ready)") {
                Affect = Factor.Budget // side effect
                       | Factor.MaintenanceCost
                       | Factor.Revenue, // side effect
                Authors = "Xial",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 602336261u, Status.Incompatible }, // Maintenance Fees

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                ContinuationOf = 602336261u, // Maintenance Fees
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Xial/Maintenancefee",
            });

            AddMod(new Item(1393820309u, "Ticket Price Customizer") {
                Affect = Factor.Revenue,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompat with similar mods? eg. by klyte
            });

            // An update to 406841580u - SimCity Fudged Population, but with better UI.
            // Dev still responsive as of Feb 2020, confirms mod still works.
            AddMod(new Item(1224627683u, "Fudged Population Enhanced") {
                Affect = Factor.Toolbar,
                Authors = "khollenbeck",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 888017364u, Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 781767563u, Status.Incompatible }, // Extended InfoPanel
                    { 576970398u, Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 406841580u, Status.Incompatible }, // SimCity Fudged Population
                    { 421770876u, Status.Incompatible }, // Sapphire - UI skin framework
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/krishollenbeck/cities_skylines_enhanced_fudged_population_mod",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // Real population, only one household at low density, high density population becomes larger
            AddMod(new Item(1587482024u, "真实人口，低密度只有一户人，高密度人口容量变大") {
                Affect = Factor.BuildingCapacity,
                Authors = "changxiuyingjian",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // Ploppable RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 2025147082u, // Realistic Population revisited
            });

            AddMod(new Item(1553517176u, "Specialized Industry Fix Redux") {
                Affect = Factor.Consumption
                       | Factor.Production,
                Authors = "Vectorial1024",
                BrokenBy = GameVersion.Industries, // lol
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1562650024u, Status.Incompatible }, // Rebalanced Industries
                    { 662386761u , Status.Incompatible }, // Specialised Industry Fix [BUGFIX for Vanilla]
                },
                CompatibleWith = GameVersion.Industries,
                ContinuationOf = 662386761u, // Specialised Industry Fix [BUGFIX for Vanilla]
                Flags = ItemFlags.Obsolete
                      | ItemFlags.BrokenByUpdate // broken since Industries DLC (lol)
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1562650024u, // Rebalanced Industries
                SkipVersionValidation = true,
                SourceURL = "https://github.com/Vectorial1024/SpecializedIndustryFixRedux",
            });;

            // potentially replace with UltimateMod 2.4?
            AddMod(new Item(1487849798u, "Higher Income Mod 1.2a") {
                Affect = Factor.Revenue,
                Authors = "I'm Not MentaL",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.4 ( Higher Income and More Options )
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report issues with xml file
                ReplaceWith = 1498036881u, // UltimateMod 2.4 ( Higher Income and More Options )
            });

            AddMod(new Item(1398502258u, "Dam Upkeep Scaling") {
                Affect = Factor.MaintenanceCost,
                Authors = "Derangedteddy",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
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
            AddMod(new Item(1369729955u, "Customize It!") {
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
                    { 1865667356u, Status.Unknown      }, // Twitch Citizens
                    { 1806759255u, Status.Incompatible }, // Customize It Extended
                    { 1562650024u, Status.Incompatible }, // Rebalanced Industries
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 946550801u , Status.Incompatible }, // Park Rebalance
                },
                Flags = ItemFlags.Obsolete // new version avail
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1806759255u, // Customize It Extended
                SourceURL = "https://github.com/TPBCS/CustomizeIt",
            });

            // Residents become senile
            // Actually translated clone of 409070739u - Very Slow Citizen Aging (by Nohealforu)
            AddMod(new Item(1196714522u, "居民衰老变十六分之一") {
                Affect = Factor.Aging,
                Authors = "回忆时光℡",
                Catalog = catalog,
                CloneOf = 409070739u, // Very Slow Citizen Aging
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Game update during 2018 broke it
                      | ItemFlags.Obsolete // Replaced by WG's Citizen Lifecycle Rebalance
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 654707599u, // Citizen Lifecycle Rebalance
            });

            AddMod(new Item(1114249433u, "Employ Overeducated Workers (1.10+)") {
                Affect = Factor.Employment,
                Authors = "Ellie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Incompatible }, // Real Gas Station
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1192503086u, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                ContinuationOf = 569008960u, // Employ Overeducated Workers
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                ReplaceWith = 1674732053u, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            // Broken since May 2019
            AddMod(new Item(1108715012u, "Adjustable Business Consumption") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity,
                Authors = "Ellie",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: Infinite Goods by Googen
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.BrokenByUpdate // some time around May 2019
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Concerts,
                SourceURL = "https://github.com/AmaroqOkami/CS-AdjustableBusinessConsumption",
            });

            AddMod(new Item(946550801u, "Park Rebalance") {
                Affect = Factor.Entertainment,
                Authors = "Azzurite, egi",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Incompatible }, // Customize It Extended
                    { 1369729955u, Status.Incompatible }, // Customize It
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // whatever came after the Industries update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.MinorBugs // mod doesn't disable properly
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                ReleasedDuring = GameVersion.ParkLife,
                ReplaceWith = 1806759255u, // Customize It Extended
                SourceURL = "https://gitlab.com/azzurite/parkrebalance",
            });

            AddMod(new Item(938049744u, "Proper Hardness Fixed") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.FireSpread
                       | Factor.Flooding
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Milestones // reduced cash reward
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
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.GreenCities,
                // note: if there is a knighthawkGP version, then it's continuation of that instead
                ContinuationOf = 408706691u, // Proper Hardness
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking // Breaks police service (milestone 5 or above), spams log with errors, etc.
                      | ItemFlags.SaveChanging
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.MassTransit,
                SourceURL = "https://github.com/m4rked0ne/Cities-Skyline-Proper-Hardness-master",
            });

            AddMod(new Item(654707599u, "Citizen Lifecycle Rebalance v2.6") {
                Affect = Factor.Aging
                       | Factor.Education
                       | Factor.Health
                       | Factor.Immigrants
                       | Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1765325082u, Status.Incompatible }, // Customizable Education
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    //Randomize Age Cim Move In (incompat)
                    //Lifespan Changer (incompat)
                    //Slow Citizen Aging (incompat)
                    //Very Slow Citizen Aging (incompat)
                    //[ARIS] Early Death (incompat)
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                ContinuationOf = 643642403u, // Lifespan multiplier v1.1
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/WhitefangGreytail/WG_CitizenEdit",
            });

            AddMod(new Item(643642403u, "Lifespan multiplier v1.1") {
                Affect = Factor.Aging
                       | Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // early death mods (incompat)
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                ContinuationOf = 409071509u, // Slow Citizen Aging Configurable
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 654707599u, // Citizen Lifecycle Rebalance v2.6
                SourceURL = "https://github.com/WhitefangGreytail/WG_Lifespan",
            });

            AddMod(new Item(569008960u, "Employ Overeducated Workers") {
                Affect = Factor.Employment,
                Authors = "Akira Ishizaki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1674732053u, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1623509958u, Status.Incompatible }, // Real Gas Station
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1192503086u, Status.Incompatible }, // Real City V9.0.03.10
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                },
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                ReplaceWith = 1674732053u, // Employ Overeducated Workers V2 (1.11+)
                SourceURL = "https://github.com/AmaroqOkami/Skylines-EmployOvereducatedWorkers",
            });

            AddMod(new Item(541673195u, "Resident Travel Rebalance v1.1") {
                Affect = Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 426163185u , Status.Recommended  }, // Realistic Population and Consumption Mod v8.4.0
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // Made "friends only" around March 2020
                      | ItemFlags.SourceUnavailable,
            });

            // Incompatible with any mod which changes:
            // * residential household capacity,
            // * worker count,
            // * power, water, sewage, garbage,
            // * income, pollution or production.
            AddMod(new Item(426163185u, "Realistic Population and Consumption Mod v8.4.0") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption
                       | Factor.Employment
                       | Factor.Immigrants
                       | Factor.LandValue
                       | Factor.Pollution
                       | Factor.Production
                       | Factor.Revenue
                       | Factor.TransportPreference,
                Authors = "Whitefang Greytail",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Compatible   }, // RICO revisited
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1204126182u, Status.Compatible   }, // Ploppable Rico High Density Fix
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 541673195u , Status.Compatible   }, // Resident Travel Rebalance v1.1
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // INCOMPATIBLE:
                    // Building Simulation Overhaul
                    // Enhanced Building Capacity
                },
                ContinuationOf = 410344523u, // PopBalanceMod
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // Made hidden around March 2020
                      | ItemFlags.Obsolete // new version available
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 2025147082u, // Realistic Population revisited
                SourceURL = "https://github.com/WhitefangGreytail/WG_RealisticCitySkylines",
            });

            AddMod(new Item(410344523u, "PopBalanceMod") {
                Affect = Factor.BuildingCapacity
                       | Factor.Consumption,
                Authors = "Kundun",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // INCOMPATIBLE:
                    // Building Simulation Overhaul
                    // Fire Spread (?!!)
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness

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
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 2025147082u, // Realistic Population revisited
            });

            AddMod(new Item(409071509u, "Slow Citizen Aging Configurable") {
                Affect = Factor.Aging,
                Authors = "Nohealforu",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time (by dymanoid)
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 573925048u , Status.Incompatible }, // Lifespan Changer
                    { 571655171u , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195u , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218u , Status.Incompatible }, // Slow Citizen Aging
                },
                CompatibleWith = GameVersion.AfterDark,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // 1.3.2 Snowfall update
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 643642403u, // Lifespan multiplier v1.1
            });

            // note possibly a KnighthawkGP continuation (AD & snowfall compat) of this prior to later Proper Hardness Fixed version
            // see https://github.com/Knighth/Cities-Skyline-Proper-Hardness
            AddMod(new Item(408706691u, "Proper Hardness") {
                Affect = Factor.Boredom
                       | Factor.BuildingInfo
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.DemandRCI
                       | Factor.Despawn
                       | Factor.Employment
                       | Factor.FireSpread
                       | Factor.Flooding
                       | Factor.Happiness
                       | Factor.Immigrants
                       | Factor.MaintenanceCost
                       | Factor.Milestones // reduced cash reward
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
                    // incompat with all extended building info
                    // incompat with t++ & likely other traffic mods
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1551563197u, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 426163185u , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // new mod avail
                      | ItemFlags.SaveChanging
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 938049744u, // Proper Hardness Fixed
                SourceURL = "https://github.com/lxteo/Cities-Skyline-Proper-Hardness",
            });
        }
    }
}
