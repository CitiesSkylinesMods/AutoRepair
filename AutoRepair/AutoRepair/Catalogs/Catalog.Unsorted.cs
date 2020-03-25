namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// This is just a temporary place to store items prior to moving them in to
    /// more logical catalogs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void UnsortedCatalog() {

            string catalog = "Unsorted";

            AddMod(new Item(2033714682u, "Tree and Vehicle Props") {
                Affect = Factor.Loading
                       | Factor.Props
                       | Factor.Trees
                       | Factor.Vehicles,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 791221322u , Status.Recommended  }, // Prop Precision
                    { 593588108u , Status.Recommended  }, // Prop & Tree Anarchy
                    { 1094334744u, Status.Compatible   }, // Procedural Objects
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });

            AddMod(new Item(2030755273u, "Automatic Pedestrian Bridge Builder [PRE ALPHA]") {
                Affect = Factor.Tools
                       | Factor.Toolbar,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/kianzarrin/PedestrianBridge/",
            });

            AddMod(new Item(2030216556u, "GrantMeMoney: get cash / money unconditionally") {
                Affect = Factor.Money,
                Authors = "the weatherman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/NJAldwin/GrantMeMoney",
            });

            // looks like translated clone of Favorite Cims mod
            AddMod(new Item(1985556066u, "4546") {
                Affect = Factor.Other,
                Authors = "暮",
                Catalog = catalog,
                CloneOf = 426460372u, // Favorite Cims
                Compatibility = new Dictionary<ulong, Status>() {
                    { 426460372u, Status.Incompatible }, // Favorite Cims
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                ReplaceWith = 426460372u, // Favorite Cims
            });

            AddMod(new Item(2016920607u, "RICO revisited") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Compatible   }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/algernon-A/Ploppable-RICO-Revisited",
            });

            AddMod(new Item(2009708489u, "Road Arrows Replacer [Spain]") {
                Affect = Factor.RoadMarkings,
                Authors = "Nouvilas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issue: hide it
                    // incompat - anything that chances road arrows or markings etc
                    { 2008960441u, Status.Required     }, // Spanish Arrow Decals Pack
                    { 956707300u , Status.Incompatible }, // Remove Street Arrows
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });

            AddMod(new Item(2009172305u, "EPTUI TLM Integration (Beta)") {
                Affect = Factor.TransportLines,
                Authors = "Arturj07",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });

            AddMod(new Item(1962752152u, "Busstop Prop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "PC28K",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160u, Status.Incompatible },
                    { 919020932u , Status.Incompatible }, // Stop Remover
                    { 545878277u , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.MinorBugs // requires game restart to toggle th
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1938493221u, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // no known issues!
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1927186256u, "Problem Info") {
                Affect = Factor.Other,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // no known issues
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            AddMod(new Item(1922400472u, "Enhanced District Services") {
                Affect = Factor.Consumption
                       | Factor.Customize
                       | Factor.Emptying
                       | Factor.Immigrants
                       | Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.Production
                       | Factor.ServiceLimit
                       | Factor.StorageCapacity
                       | Factor.Vehicles,
                Authors = "chronofanz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1721492498u, Status.Recommended  }, // Optimised Outside Connections
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 785237088u , Status.Incompatible }, // Service Radius Adjuster
                    { 649522495u , Status.Incompatible }, // District Service Limit
                    { 554232266u , Status.Incompatible }, // Mod: Nursing Homes for Senior Citizens
                    { 512341354u , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 439582006u , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    { 433249875u , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/chronofanz/EnhancedDistrictServices",
            });

            // likely incompat with Customize It Extended
            AddMod(new Item(1865667356u, "Twitch Citizens") {
                Affect = Factor.Naming,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Unknown      }, // Customize It Extended
                    { 1369729955u, Status.Unknown      }, // Customize It!
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // Apparently creates some sort of biogas harvesting building that's
            // dependent on the number of plants in close proximity.
            AddMod(new Item(1920431318u, "Biogas-pw") {
                Affect = Factor.Other,
                Authors = "dolaritar",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                // It changes building AI both in editor and game, but doesn't reset it for autosave, save or level unloading.
                // This will result in broken save games and will likely break assets published from asset editor.
                // Avoid until code is improved!
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.GameBreaking
                      | ItemFlags.SaveChanging
                      | ItemFlags.SourceUnavailable,
            });

            // replaces bus shelters, likely incompat with similar mods
            AddMod(new Item(1900151000u, "替换为不锈钢公交候车亭") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "ZEIR",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // anything that alters bus stops
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/OwiHH-NC/4cefbd1fbc7ff7135c59",
            });

            AddMod(new Item(1899943042u, "No Scaffolding Animation") {
                Affect = Factor.Construction,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // real time?
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    // real construciton?
                    // plop growables?
                    // rico?
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
            });

            // mesures performance based on time it takes for a game day, and fps
            AddMod(new Item(1899449152, "Game Day Timer") {
                Affect = Factor.Other,
                Authors = "rcav8tr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/rcav8tr/GameDayTimer",
            });

            AddMod(new Item(1859100867u, "Klyte's Framework 1.1") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/KlyteFramework",
            });

            // Bundle of Chinese localised mods - will break your game
            AddMod(new Item(1812384654u, "(no name specified)") {
                Affect = Factor.Other,
                Authors = "打的好不如排的好",
                BrokenBy = GameVersion.DefaultRelease,
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                SkipVersionValidation = true,
            });

            AddMod(new Item(1801953480u, "Natural Disasters Overhaul") {
                Affect = Factor.Environment,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.MinorIssues  }, // Real Time (causes excessive thunderstorms)
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline (ditto)
                    // todo: check compat with other disaster mods
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Enhanced-Disasters",
            });

            AddMod(new Item(1800844556u, "Zone Mixer 0 (Beta)") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/ZoneMixer",
            });

            AddMod(new Item(1799667916u, "UX Mod - OSD & Keybinds") {
                Affect = Factor.Other,
                Authors = "kvakvs",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/kvakvs/Skylines-UX",
            });

            AddMod(new Item(1782814610u, "Building Variations") {
                Affect = Factor.Textures,
                Authors = "Elektrix",
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
            });

            // sounds like bit of a nightmare
            AddMod(new Item(1769420886u, "Panel Hook (beta) for modders") {
                Affect = Factor.BuildingInfo
                       | Factor.VehicleInfo,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // tmpe?
                    // snooper?
                    // klyte mods?
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/vpoteryaev-cs-mods/PanelHook",
            });

            AddMod(new Item(1768810491u, "Measure It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-MeasureIt",
            });

            AddMod(new Item(1766839841u, "Anxiety Reducer") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // tmpe? ipt2?
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1764637396u, "Toggle It!") {
                Affect = Factor.HideRemove,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Toggle it covers functionality of these mods:
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                    { 1540147921u, Status.Incompatible }, // Grid be Gone
                    { 1536223783u, Status.MinorIssues  }, // Hide Selectors
                    { 917543381u , Status.MinorIssues  }, // No Problem Notifications
                    { 903347963u , Status.Incompatible }, // Transparent Selectors
                    { 877748783u , Status.Incompatible }, // Topographic Lines Toggle
                    { 592076973u , Status.MinorIssues  }, // Zoning toolset (toggle + upgrade tool)
                    { 561293123u , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                    { 553319260u , Status.MinorIssues  }, // Hide Border Line and Asset Editor Grid
                    { 507225392u , Status.MinorIssues  }, // Topographic Info View
                    { 465318661u , Status.Incompatible }, // Toggleable Whiteness
                    { 451193058u , Status.Incompatible }, // The Original Hide Policy Icons
                    { 443904654u , Status.Incompatible }, // Zoning and Districts Co-viewer
                    { 439360165u , Status.Incompatible }, // mabako's Hide District Policy Icons Mod
                    { 437716646u , Status.MinorIssues  }, // Cities Atlas
                    { 433557907u , Status.Incompatible }, // District UI Tweaks: Hide Names
                    { 421443866u , Status.Incompatible }, // Zone Colours
                    { 410842044u , Status.Incompatible }, // Persistent Resource View
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better, map borders keep reappearing
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/keallu/CSL-ToggleIt",
            });

            AddMod(new Item(1204126182u, "Ploppable Rico High Density Fix") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "(unknown)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 586012417u, // Ploppable RICO (original)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 2016920607u, // RICO revisited
            });

            AddMod(new Item(1749971558u, "Real Time Offline") {
                Affect = Factor.Aging
                       | Factor.Boredom
                       | Factor.Construction
                       | Factor.Consumption
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Entertainment
                       | Factor.Environment
                       | Factor.Production
                       | Factor.Rendering
                       | Factor.TileLimit
                       | Factor.Timeflow
                       | Factor.Timerate
                       | Factor.TransportPreference,
                Authors = "Gness Erquint",
                Catalog = catalog,
                // NOTE:
                // The offline version has differenet compatibility vectors than the original online version
                // primarily because it's offline and thus can't reliably idenfity other mods (nor they it).
                Compatibility = new Dictionary<ulong, Status>() {
                    // technical conflicts (cause severe loss of funcitonality or crashes):
                    { 1911736890u, Status.MinorIssues  }, // 1181352643 District Service Limit 3 (see note for DSL 3.0 below)
                    { 1893036262u, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1729576238u, Status.Incompatible }, // Date Changer
                    { 1420955187u, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 1181352643u, Status.MinorIssues  }, // District Service Limit 3.0 (citizen limiting features directly conflict with RT)
                    { 702070768u , Status.Incompatible }, // Export Electricity
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 629713122u , Status.Incompatible }, // Climate Control
                    { 605590542u , Status.Incompatible }, // Rush Hour II
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    // age change (lifespan balance issues):
                    { 2027161563u, Status.MinorIssues  }, // Lifecycle Rebalance Revisited
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.MinorIssues  }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.MinorIssues  }, // Lifespan multiplier v1.1
                    { 573925048u , Status.MinorIssues  }, // Lifespan Changer
                    { 571655171u , Status.MinorIssues  }, // Randomize Age Cims Move in
                    { 541673195u , Status.MinorIssues  }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.MinorIssues  }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.MinorIssues  }, // Very Slow Citizen Aging
                    { 409070218u , Status.MinorIssues  }, // Slow Citizen Aging
                    // construction change (construction time/period/animation issues):
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1899943042u, Status.Incompatible }, // No Scaffolding Animation
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 924884948u , Status.MinorIssues  }, // Plop the Growables
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 523818382u , Status.MinorIssues  }, // Force Level Up
                    { 466158459u , Status.MinorIssues  }, // Building Themes
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // time change (daily schedule issues):
                    { 814698320u , Status.MinorIssues  }, // TimeWarp Fix (game will pause when used, time resets when unpaused)
                    { 672248733u , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2 (game will pause when used, time resets when unpaused)
                    { 1899449152u, Status.Incompatible }, // Game Day Timer (it can't recognise offline realtime)
                    // other
                    { 1801953480u, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1412844620u, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560u , Status.Compatible   }, // Geli-Districts v3.0
                },
                ContinuationOf = 1420955187u, // Real Time (original by dymanoid)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1420955187u, // Real Time (original by dymanoid)
            });

            AddMod(new Item(1706703944u, "More Outside Interaction") {
                Affect = Factor.Employment
                       | Factor.ServiceLimit,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
            });

            AddMod(new Item(1680840913u, "More Effective Transfer Manager") {
                Affect = Factor.Consumption
                       | Factor.Emptying
                       | Factor.Health
                       | Factor.Pathfinder
                       | Factor.Production
                       | Factor.ServiceLimit
                       | Factor.Vehicles,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
            });

            AddMod(new Item(1632320836u, "Service Vehicles Manager 2.0.1") {
                Affect = Factor.ServiceLimit,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/ServiceVehiclesManager",
            });

            AddMod(new Item(1614061108u, "Real Construction") {
                Affect = Factor.Construction
                       | Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleLimit,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902u, Status.Compatible   }, // Transfer Info (beta)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1435741602u, Status.Incompatible }, // Snooper
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/RealConstruction",
            });

            AddMod(new Item(1312767991u, "Transport Lines Manager 13.1") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.PdxLauncher,
                ContinuationOf = 929654063u, // Transport Lines Manager Reborn 8.0.3
                Languages = new[] { "en", "pt", "ko", "de", "nl", "pl", "zh-cn", "fr", "es" },
                Locale = "en",
                ReleasedDuring = GameVersion.GreenCities,
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

            // old version
            AddMod(new Item(424106600u, "Improved Public Transport (IPT)") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "DontCryJustDie",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // was compat with ancient versions of TMPE, but they all changed after mass transit
                    // was also compat with t++ v2 (now obsolete)
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 531401164u , Status.Incompatible }, // Vehicle Unbuncher
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.NoWorkshop // removed jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "de", "es", "zh-cn", "pl", "it", "pt", "zh", "ru", "fr", "ko", },
                Locale = "en",
                ReleasedDuring = new Version(1, 0, 7), // before European buildings were added
                ReplaceWith = 928128676u, // Improved Public Transport 2
            });

            // old version
            AddMod(new Item(519691655u, "Service Vehicle Selector") {
                Affect = Factor.Other,
                Authors = "DontCryJustDie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // removed jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 934994075u, // Service Vehicle Selector 2
            });

            // old version
            AddMod(new Item(929654063u, "Transport Lines Manager Reborn 8.0.3") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                BrokenBy = GameVersion.ParkLife, // was already replaced by new mod by then
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with overwatch/aris mods
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.GreenCities,
                ContinuationOf = 408875519u, // Transport Lines Manager
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // park life
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable, // same repo as new version
                Languages = new[] { "en", "de", "zh-cn", "pl", "pt", "ko", },
                Locale = "en",
                ReleasedDuring = GameVersion.MassTransit,
                ReplaceWith = 1312767991u, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

            // old version
            AddMod(new Item(408875519u, "Transport Lines Manager") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.NaturalDisasters, // there was update on ND release day, assuming minor bug fixes
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // mass transit
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable, // same repo as new version
                ReleasedDuring = new Version(1, 0, 7), // before European buildings were added
                ReplaceWith = 1312767991u, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

        }
    }
}