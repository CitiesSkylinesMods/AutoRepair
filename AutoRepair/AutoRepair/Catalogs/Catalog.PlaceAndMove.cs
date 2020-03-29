namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Tools that help with placement and relocation of roads, buildings, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void PlaceAndMoveCatalog() {

            string catalog = "PlaceAndMove";

            AddMod(new Item(2030755273u, "Automatic Pedestrian Bridge Builder [PRE ALPHA]") {
                Affect = Factor.Tools
                       | Factor.Toolbar,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/kianzarrin/PedestrianBridge/",
            });

            // for creating intersections
            // No detours used!! Compat with basically everything.
            AddMod(new Item(1925527132u, "Advanced Road Tools") {
                Affect = Factor.PlaceAndMove,
                Authors = "amamlya, VictoriaCity, pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Languages = new[] { "de", "en", "es", "fr", "ko", "ru", "zh-cn", "zh" },
                Locale = "en",
                SourceURL = "https://github.com/pcfantasy/AdvancedRoadTools",
            });

            AddMod(new Item(1902022083u, "TerrainRiverTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
            });

            // map editor mod, also works in-game
            AddMod(new Item(1894371878u, "TotalTerrainTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1890830956u, "Undo It!") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1677913611u, Status.MinorIssues }, // Smart Intersection Builder (compatible, but can't undo)
                    { 1625704117u, Status.MinorIssues }, // Roundabout Builder (compatible, but can't undo)
                    { 1619685021u, Status.MinorIssues }, // Move It (compatible, but can't undo)
                    { 694512541u , Status.MinorIssues }, // Prop Line Tool (compatible, but can't undo)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Strdate/UndoMod",
            });

            AddMod(new Item(1844442251u, "Fine Road Tool 2.0.3") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844440354u, Status.Recommended  }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                ContinuationOf = 651322972u, // Fine Road Tool
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/CS-FineRoadTool",
            });

            AddMod(new Item(1844440354u, "Fine Road Anarchy 2") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                ContinuationOf = 802066100u, // Fine Road Anarchy
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE,  "Sunset Harbor: It's making road collisions (connections) unreliable." },
                },
                SourceURL = "https://github.com/klyte45/CS-FineRoadAnarchy",
            });

            AddMod(new Item(1783307723u, "Zone It!") {
                Affect = Factor.PlaceAndMove
                       | Factor.Zoning,
                Authors = "Keallu",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better, doesn't update zoning grid
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-ZoneIt",
            });

            // todo: check if source still obfu
            AddMod(new Item(1761648213u, "More Advanced District Snapping") {
                Affect = Factor.PlaceAndMove,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 510802741u, Status.Incompatible }, // [DEPRECATED] Toggle District Snapping
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1691909129u, "Rotate Brush") {
                Affect = Factor.PlaceAndMove,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 502750307u, Status.Recommended }, // Extra Landscaping Tools
                    { 689937287u, Status.Recommended }, // Surface Painter
                },
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Note] Avoid using it near map edges (small bug spams log file)." },
                },
            });

            AddMod(new Item(1677913611u, "Smart Intersection Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1890830956u, Status.MinorIssues }, // Undo It!
                    { 1844442251u, Status.Recommended }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Required    }, // Fine Road Anarchy 2
                    { 802066100u , Status.Compatible  }, // Fine Road Anarchy
                    { 651322972u , Status.Compatible  }, // Fine Road Tool
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Strdate/SmartIntersections",
            });

            AddMod(new Item(1645781000u, "Elektrix's Road Tools 2.91") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool (invert flag)
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool (invert flag)
                    { 1597198847u, Status.Incompatible }, // [Legacy] Segment Slope Smoother
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1597198847u, // [Legacy] Segment Slope Smoother
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1625704117u, "Roundabout Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1890830956u, Status.MinorIssues }, // Undo It!
                    { 1844442251u, Status.Recommended }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Required    }, // Fine Road Anarchy 2
                    { 802066100u , Status.Compatible  }, // Fine Road Anarchy
                    { 651322972u , Status.Compatible  }, // Fine Road Tool
                },
                SourceURL = "https://github.com/Strdate/AutomaticRoundaboutBuilder",
            });

            AddMod(new Item(1619685021u, "Move It 2.7.0") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1890830956u, Status.MinorIssues  }, // Undo It!
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1393797695u, Status.Compatible   }, // Touch This! Tool 3
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 766190099u, // Move It (original)
                Flags = ItemFlags.Recommended // rare accolade
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Quboid/CS-MoveIt",
            });

            AddMod(new Item(1612012531u, "Net Picker 2.0") {
                Affect = Factor.PlaceAndMove
                       | Factor.Toolbar, // toolbar altering mods can adversely affect it
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251u, Status.Compatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Compatible }, // Fine Road Anarchy 2
                    { 1619685021u, Status.Compatible }, // Move It 2.7.0
                    { 1612012531u, Status.Compatible }, // Net Picker 2.0
                    { 1393797695u, Status.Compatible }, // Touch This! Tool 3
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
            });

            // Might cause issues with TM:PE - short segments entering junctions causes AI issues
            AddMod(new Item(1586027591u, "Tiny Segments") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141u, Status.MinorIssues  }, // TMPE v11 LABS (issues at junctions)
                    { 1637663252u, Status.MinorIssues  }, // TMPE v11 STABLE (issues at junctions)
                    { 1957033250u, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.MinorIssues  }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.MinorIssues  }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1440928803u, "Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Unknown      }, // CSUR Loader
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1645781000u, Status.Incompatible }, // Elektrix's Road Tools 2.91
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool (invert flag)
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool (invert flag)
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 543722850u , Status.Unknown      }, // Network Skins (Park Life compatible)
                },
                ContinuationOf = 1400711138u, // [BETA] Parallel Road Tool
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                Locale = "en",
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
            });

            AddMod(new Item(1400711138u, "[BETA] Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Unknown      }, // CSUR Loader
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1645781000u, Status.Incompatible }, // Elektrix's Road Tools 2.91
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool (invert flag)
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool (invert flag)
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 543722850u , Status.Unknown      }, // Network Skins (Park Life compatible)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                Locale = "en",
                ReplaceWith = 1440928803u, // Parallel Road Tool
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
            });

            AddMod(new Item(1393797695u, "Touch This! Tool 3") {
                Affect = Factor.Pathfinder // may chance how pathfinder relates to buildings
                       | Factor.PlaceAndMove
                       | Factor.TransportLines, // can break transport lines
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1895443005u, Status.Compatible   }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Compatible   }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Compatible   }, // Fine Road Anarchy 2
                    { 1619685021u, Status.Compatible   }, // Move It 2.7.0
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/TouchThisTool",
                // todo: incompat with older touch tool no longer in workshop
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1895443005u, "Fine Road Anarchy 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1844440354u, // Fine Road Anarchy 2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            AddMod(new Item(1895440521u, "Fine Road Tool 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1844442251u, // Fine Road Tool 2.0.3
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844442251u, // Fine Road Tool 2.0.3
            });

            AddMod(new Item(1892174866u, "MoveIt2.6汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021u, // Move It 2.7.1
            });

            AddMod(new Item(1866239503u, "MOVE IT Sakuya16个人汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Izayoi _Sakuya16",
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021u, // Move It 2.7.1
            });

            AddMod(new Item(1857894421u, "766190099_Move_It_") {
                Affect = Factor.PlaceAndMove,
                Authors = "r.heikens",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                CloneOf = 766190099u, // Move It (original version)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Industries
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Ancient version (2.2.x or earlier)
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReleasedDuring = GameVersion.Campus, // lol!!
                ReplaceWith = 1619685021u, // Move It (current stable release)
                SkipVersionValidation = true,
            });

            AddMod(new Item(1856282754u, "MoveIt 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It (current stable release)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware // stuck on v2.5.0
                      | ItemFlags.ForceMigration
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021u, // Move It (current stable release)
            });

            AddMod(new Item(1622545887u, "Move It! 2.3.0 (Updated for Industries patch)") {
                Affect = Factor.PlaceAndMove,
                Authors = "RudRecciah",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                ContinuationOf = 766190099u, // Move It
                Flags = ItemFlags.Abandonware // Was temporary bug fix
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1619685021u, // Move It (current stable release)
            });

            AddMod(new Item(1597198847u, "[Legacy] Segment Slope Smoother") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1645781000u, Status.Incompatible }, // Elektrix's Road Tools 2.91
                },
                Flags = ItemFlags.Abandonware // Elektrix states no further development
                      | ItemFlags.Obsolete // Replaced by Road Tools
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                ReplaceWith = 1645781000u, // Elektrix's Road Tools 2.91
            });

            AddMod(new Item(1436255148u, "Fine Road Anarchy 汉化版1.3.5") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 802066100u, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorBugs // Breaks tooling of other mods
                      | ItemFlags.Obsolete // Fixed mods available
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            AddMod(new Item(1362508329u, "TC01 - FineRoadAnarchy! (2018)") {
                Affect = Factor.PlaceAndMove,
                Authors = "Fatih ÇELİK",
                Catalog = catalog,
                CloneOf = 802066100u, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Ancient version of the mod
                      | ItemFlags.Obsolete // Fixed mods available
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "tr",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            AddMod(new Item(1120637951u, "[OUTDATED] Move It! Extra Filters") {
                Affect = Factor.PlaceAndMove,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Required     }, // Move It (original)
                },
                ReplaceWith = 1619685021u, // Move It 2.7.0
                SourceURL = "https://gist.github.com/simon56modder/46b2d593e0364fb5386c80c3c97ae396",
            });

            // original version
            AddMod(new Item(766190099u, "Move It") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Compatible   }, // [OUTDATED] Move It! Extra Filters
                    { 766190099u , Status.Incompatible }, // Move It (original)
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Industries
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // Removed some time around Feb 2019
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1619685021u, // Move It (curent stable release)
                SourceURL = "https://github.com/SamsamTS/CS-MoveIt",
            });

        }
    }
}
