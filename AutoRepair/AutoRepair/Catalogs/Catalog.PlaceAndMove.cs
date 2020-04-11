namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Tools that help with placement and relocation of roads, buildings, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void PlaceAndMoveMods() {

            string catalog = "PlaceAndMove";

            AddMod(new Review(2030755273u, "Automatic Pedestrian Bridge Builder [PRE ALPHA]") {
                Affect = Factor.Tools
                       | Factor.Toolbar,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/kianzarrin/PedestrianBridge/",
            });

            // for creating intersections
            // No detours used!! Compat with basically everything.
            AddMod(new Review(1925527132u, "Advanced Road Tools") {
                Affect = Factor.PlaceAndMove,
                Authors = "amamlya, VictoriaCity, pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Languages = new[] { "de", "en", "es", "fr", "ko", "ru", "zh-cn", "zh" },
                Locale = "en",
                SourceURL = "https://github.com/pcfantasy/AdvancedRoadTools",
            });

            AddMod(new Review(1902022083u, "TerrainRiverTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
            });

            // map editor mod, also works in-game
            AddMod(new Review(1894371878u, "TotalTerrainTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1890830956u, "Undo It!") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.MinorIssues  }, // Move It! 移动它 中文版
                    { 1677913611u, Status.MinorIssues  }, // Smart Intersection Builder (compatible, but can't undo)
                    { 1625704117u, Status.MinorIssues  }, // Roundabout Builder (compatible, but can't undo)
                    { 1619685021u, Status.MinorIssues  }, // Move It (compatible, but can't undo)
                    { 694512541u , Status.MinorIssues  }, // Prop Line Tool (compatible, but can't undo)
                },
                Notes = new Dictionary<ulong, string>() {
                    { 1677913611u, "[Mod: Smart Intersection Builder] Can't undo intersections made with Smart Intersection Builder (use it's own undo tool instead)." },
                    { 1625704117u, "[Mod: Roundabout Builder] Can't undo roundabouts made with Roundabout Builder (use it's own undo tool instead)." },
                    { 1619685021u, "[Mod: Move It] Can't undo changes made by Move It (use it's own undo tool instead)." },
                    { 694512541u , "[Mod: Prop Line Tool] Can't undo props placed with Prop Line Tool." },
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Strdate/UndoMod",
            });

            AddMod(new Review(1844442251u, "Fine Road Tool 2.0.3") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844440354u, Status.Recommended  }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 651322972u, // Fine Road Tool
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/CS-FineRoadTool",
            });

            AddMod(new Review(1844440354u, "Fine Road Anarchy 2") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Recommended  }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 802066100u, // Fine Road Anarchy
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/CS-FineRoadAnarchy",
            });

            AddMod(new Review(1783307723u, "Zone It!") {
                Affect = Factor.PlaceAndMove
                       | Factor.Zoning,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {

                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Error when exiting game; doesn't seem to cause any problems though: https://github.com/keallu/CSL-ZoneIt/issues/1" },
                },
                SourceURL = "https://github.com/keallu/CSL-ZoneIt",
            });

            // todo: check if source still obfu
            AddMod(new Review(1761648213u, "More Advanced District Snapping") {
                Affect = Factor.PlaceAndMove,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 510802741u, Status.Incompatible }, // [DEPRECATED] Toggle District Snapping
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1691909129u, "Rotate Brush") {
                Affect = Factor.PlaceAndMove,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 502750307u, Status.Recommended }, // Extra Landscaping Tools
                    { 689937287u, Status.Recommended }, // Surface Painter
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Note] Avoid using it near map edges (small bug spams log file)." },
                },
            });

            AddMod(new Review(1677913611u, "Smart Intersection Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1890830956u, Status.MinorIssues  }, // Undo It!
                    { 1844442251u, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1890830956u, "[Mod: Undo It!] Doesn't undo roundabouts. Use the undo feature of Smart Intersections instead." },
                },
                SourceURL = "https://github.com/Strdate/SmartIntersections",
            });

            AddMod(new Review(1645781000u, "Elektrix's Road Tools 2.91") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool (invert flag)
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool (invert flag)
                    { 1597198847u, Status.Incompatible }, // [Legacy] Segment Slope Smoother
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 658653260u , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1597198847u, // [Legacy] Segment Slope Smoother
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1625704117u, "Roundabout Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1890830956u, Status.MinorIssues  }, // Undo It!
                    { 1844442251u, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                Notes = new Dictionary<ulong, string>() {
                    { 1890830956u, "[Mod: Undo It!] Doesn't undo roundabouts. Use undo feature of Roundabout Builder instead." },
                },
                SourceURL = "https://github.com/Strdate/AutomaticRoundaboutBuilder",
            });

            AddMod(new Review(1619685021u, "Move It 2.7.0") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 924884948u , Status.Compatible   }, // Plop the Growables
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 766190099u , Status.Incompatible }, // Move It (original)
                    { 658653260u , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u , Status.Incompatible }, // Sharp Junction Angles
                    { 503147777u , Status.Compatible   }, // Moledozer
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 766190099u, // Move It (original)
                Flags = ItemFlags.Recommended // rare accolade
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Quboid/CS-MoveIt",
            });

            AddMod(new Review(1612012531u, "Net Picker 2.0") {
                Affect = Factor.PlaceAndMove
                       | Factor.Toolbar, // toolbar altering mods can adversely affect it
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Compatible   }, // Move It! 移动它 中文版
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251u, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Compatible   }, // Fine Road Anarchy 2
                    { 1619685021u, Status.Compatible   }, // Move It 2.7.0
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Compatible   }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This! Tool 3
                    { 1362508329u, Status.Compatible   }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260u , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 553184329u , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
            });

            // Might cause issues with TM:PE - short segments entering junctions causes AI issues
            AddMod(new Review(1586027591u, "Tiny Segments") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141u, Status.MinorIssues  }, // TMPE v11 LABS (issues at junctions)
                    { 1637663252u, Status.MinorIssues  }, // TMPE v11 STABLE (issues at junctions)
                    { 1604291910u, Status.MinorIssues  }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.MinorIssues  }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1440928803u, "Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1959183067u, Status.Unknown      }, // CSUR Loader
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1645781000u, Status.Compatible   }, // Elektrix's Road Tools 2.91
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 543722850u , Status.Unknown      }, // Network Skins (Park Life compatible)
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                ContinuationOf = 1400711138u, // [BETA] Parallel Road Tool
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                Locale = "en",
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
            });

            AddMod(new Review(1400711138u, "[BETA] Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1959183067u, Status.Unknown      }, // CSUR Loader
                    { 1844440354u, Status.Required     }, // Fine Road Anarchy 2
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1645781000u, Status.Compatible   }, // Elektrix's Road Tools 2.91
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 543722850u , Status.Unknown      }, // Network Skins (Park Life compatible)
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                Locale = "en",
                ReplaceWith = 1440928803u, // Parallel Road Tool
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
            });

            AddMod(new Review(1393797695u, "Touch This! Tool 3") {
                Affect = Factor.Pathfinder // may chance how pathfinder relates to buildings
                       | Factor.PlaceAndMove
                       | Factor.TransportLines, // can break transport lines
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Compatible   }, // Move It! 移动它 中文版
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Compatible   }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Compatible   }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Compatible   }, // Fine Road Anarchy 2
                    { 1619685021u, Status.Compatible   }, // Move It 2.7.0
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
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

            AddMod(new Review(2045014295u, "Move It! 移动它 中文版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Yuuki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 766190099u , Status.Incompatible }, // Move It (original)
                    { 658653260u , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1619685021u, // Move It (current stable release)
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                Published = WorkshopDate("2 Apr, 2020"),
                Updated = WorkshopDate("2 Apr, 2020"),
            });

            AddMod(new Review(2043038271u, "Fine Road Anarchy") {
                Affect = Factor.PlaceAndMove,
                Authors = "jorgesatoor",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611u, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117u, Status.Incompatible }, // Roundabout Builder
                    { 1612012531u, Status.Incompatible }, // Net Picker 2.0
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("1 Apr, 2020"),
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
                ReleasedDuring = GameVersion.SunsetHarbor,
                SuppressOlderReplacementWarning = true,
                SuppressVersionWarnings = true,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMod(new Review(1895443005u, "Fine Road Anarchy 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1844440354u, // Fine Road Anarchy 2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            AddMod(new Review(1895440521u, "Fine Road Tool 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1844442251u, // Fine Road Tool 2.0.3
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Compatible   }, // Dynamic Text Props
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695u, Status.Compatible   }, // Touch This Tool
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844442251u, // Fine Road Tool 2.0.3
            });

            AddMod(new Review(1892174866u, "MoveIt2.6汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021u, // Move It 2.7.1
            });

            AddMod(new Review(1866239503u, "MOVE IT Sakuya16个人汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Izayoi _Sakuya16",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021u, // Move It 2.7.1
            });

            AddMod(new Review(1857894421u, "766190099_Move_It_") {
                Affect = Factor.PlaceAndMove,
                Authors = "r.heikens",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                CloneOf = 766190099u, // Move It (original version)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                SuppressVersionWarnings = true,
            });

            AddMod(new Review(1856282754u, "MoveIt 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 1619685021u, // Move It (current stable release)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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

            AddMod(new Review(1622545887u, "Move It! 2.3.0 (Updated for Industries patch)") {
                Affect = Factor.PlaceAndMove,
                Authors = "RudRecciah",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1619685021u, // Move It (current stable release)
                SuppressOlderReplacementWarning = true,
            });

            AddMod(new Review(1597198847u, "[Legacy] Segment Slope Smoother") {
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

            AddMod(new Review(1436255148u, "Fine Road Anarchy 汉化版1.3.5") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 802066100u, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611u, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117u, Status.Incompatible }, // Roundabout Builder
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues // Breaks tooling of other mods
                      | ItemFlags.Obsolete // Fixed mods available
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            AddMod(new Review(1362508329u, "TC01 - FineRoadAnarchy! (2018)") {
                Affect = Factor.PlaceAndMove,
                Authors = "Fatih ÇELİK",
                Catalog = catalog,
                CloneOf = 802066100u, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611u, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117u, Status.Incompatible }, // Roundabout Builder
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
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

            AddMod(new Review(1120637951u, "[OUTDATED] Move It! Extra Filters") {
                Affect = Factor.PlaceAndMove,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
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
                ReplaceWith = 1619685021u, // Move It (curent stable release)
                SourceURL = "https://gist.github.com/simon56modder/46b2d593e0364fb5386c80c3c97ae396",
            });

            AddMod(new Review(802066100u, "Fine Road Anarchy") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611u, Status.Compatible   }, // Smart Intersection Builder
                    { 1625704117u, Status.Compatible   }, // Roundabout Builder
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Compatible   }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                // todo: might actually have been cont. of sharper junction angles mod
                ContinuationOf = 418556522u, // Road Anarchy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE,  "Sunset Harbor: Colission toggle isn't working properly; also breaks metro line placement.\n" },
                },
                ReleasedDuring = GameVersion.Stadiums,
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
                SourceURL = "https://github.com/SamsamTS/CS-FineRoadAnarchy",
            });

            // original version
            AddMod(new Review(766190099u, "Move It") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.7.0
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1120637951u, Status.Compatible   }, // [OUTDATED] Move It! Extra Filters
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 924884948u , Status.Incompatible }, // Plop the Growables
                    { 912329352u,  Status.Incompatible }, // Building Anarchy (just sick of seeing this break games!)
                    { 766190099u , Status.Incompatible }, // Move It (original)
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
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

            // original mod
            AddMod(new Review(651322972u, "Fine Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354u, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509u, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611u, Status.Compatible   }, // Smart Intersection Builder
                    { 1625704117u, Status.Compatible   }, // Roundabout Builder
                    { 1612012531u, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695u, Status.Incompatible }, // Touch This Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 802066100u , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 418556522u, // Road Anarchy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Snowfall,
                ReplaceWith = 1844442251u, // Fine Road Tool 2
                SourceURL = "https://github.com/SamsamTS/CS-FineRoadTool",
            });
        }
    }
}
