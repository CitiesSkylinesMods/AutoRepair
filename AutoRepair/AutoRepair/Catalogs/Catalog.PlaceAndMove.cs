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
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void PlaceAndMoveMods() {

            string catalog = "PlaceAndMove";

            AddMod(new Review(2085018096uL, "Node Spacer") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1844442251uL, Status.Required     }, // Fine Road Tool 2.0.4
                    { 1844440354uL, Status.Recommended  }, // Fine Road Anarchy 2.0.2
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("4 May, 2020"),
                Updated = WorkshopDate("4 May, 2020"),
            });

            AddMod(new Review(2083188521uL, "Precision Engineering 2.0") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Tuna",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2083188521uL, Status.Incompatible }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Incompatible }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 876444259uL , Status.Incompatible }, // PrecisionEngineering测量工具
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 2082427515uL, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Hold 'Ctrl' while placing roads/rails to enable angle snapping (5 degree increments)." },
                    { NOTE, "Hold 'Alt' while placing roads/rails to enable snapping to guidelines." },
                    { NOTE, "Hold 'Shift' while placing roads/rails to show additional information." },
                },
                Published = WorkshopDate("3 May, 2020"),
                SourceURL = "https://github.com/tunaflish/PrecisionEngineering",
                Updated = WorkshopDate("3 May, 2020"),
            });

            AddMod(new Review(2071210858uL, "[BETA] Quay Upgrade Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("23 Apr, 2020"),
                SourceURL = "https://github.com/ST-Apps/CS-QuayUpgradeTool",
                Updated = WorkshopDate("23 Apr, 2020"),
            });

            AddMod(new Review(2060132379uL, "Feature: Path Snapping") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 912329352uL , Status.Unknown      }, // Building Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("13 Apr, 2020"),
                Updated = WorkshopDate("13 Apr, 2020"),
            });

            AddMod(new Review(2030755273uL, "Automatic Pedestrian Bridge Builder [PRE ALPHA]") {
                Affect = Factor.Tools
                       | Factor.Toolbar,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/kianzarrin/PedestrianBridge/",
            });

            // for creating intersections
            // No detours used!! Compat with basically everything.
            AddMod(new Review(1925527132uL, "Advanced Road Tools") {
                Affect = Factor.PlaceAndMove,
                Authors = "amamlya, VictoriaCity, pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Languages = new[] { "de", "en", "es", "fr", "ko", "ru", "zh-cn", "zh" },
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en",
                SourceURL = "https://github.com/pcfantasy/AdvancedRoadTools",
            });

            AddMod(new Review(1902022083uL, "TerrainRiverTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
            });

            // map editor mod, also works in-game
            AddMod(new Review(1894371878uL, "TotalTerrainTool") {
                Affect = Factor.PlaceAndMove, // todo: add terrain factor
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.EditorMod // can also be used in-game
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
            });

            AddMod(new Review(1890830956uL, "Undo It!") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.MinorIssues  }, // Move It! 移动它 中文版
                    { 1677913611uL, Status.MinorIssues  }, // Smart Intersection Builder (compatible, but can't undo)
                    { 1625704117uL, Status.MinorIssues  }, // Roundabout Builder (compatible, but can't undo)
                    { 1619685021uL, Status.MinorIssues  }, // Move It (compatible, but can't undo)
                    { 694512541uL , Status.MinorIssues  }, // Prop Line Tool (compatible, but can't undo)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Notes = new Dictionary<ulong, string>() {
                    { 1677913611uL, "[Mod: Smart Intersection Builder] Can't undo intersections made with Smart Intersection Builder (use it's own undo tool instead)." },
                    { 1625704117uL, "[Mod: Roundabout Builder] Can't undo roundabouts made with Roundabout Builder (use it's own undo tool instead)." },
                    { 1619685021uL, "[Mod: Move It] Can't undo changes made by Move It (use it's own undo tool instead)." },
                    { 694512541uL , "[Mod: Prop Line Tool] Can't undo props placed with Prop Line Tool." },
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/Strdate/UndoMod",
            });

            AddMod(new Review(1844442251uL, "Fine Road Tool 2.0.3") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 651322972uL, // Fine Road Tool
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/klyte45/CS-FineRoadTool",
            });

            AddMod(new Review(1844440354uL, "Fine Road Anarchy 2") {
                Affect = Factor.PlaceAndMove,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Compatible   }, // Dynamic Text Props
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 802066100uL, // Fine Road Anarchy
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/klyte45/CS-FineRoadAnarchy",
            });

            AddMod(new Review(1783307723uL, "Zone It!") {
                Affect = Factor.PlaceAndMove
                       | Factor.Zoning,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {

                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Error when exiting game; doesn't seem to cause any problems though: https://github.com/keallu/CSL-ZoneIt/issues/1" },
                },
                SourceURL = "https://github.com/keallu/CSL-ZoneIt",
            });

            // todo: check if source still obfu
            AddMod(new Review(1761648213uL, "More Advanced District Snapping") {
                Affect = Factor.PlaceAndMove,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 510802741uL, Status.Incompatible }, // [DEPRECATED] Toggle District Snapping
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
            });

            AddMod(new Review(1691909129uL, "Rotate Brush") {
                Affect = Factor.PlaceAndMove,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 502750307uL, Status.Recommended }, // Extra Landscaping Tools
                    { 689937287uL, Status.Recommended }, // Surface Painter
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Note] Avoid using it near map edges (small bug spams log file)." },
                },
            });

            AddMod(new Review(1677913611uL, "Smart Intersection Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1890830956uL, Status.MinorIssues  }, // Undo It!
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1890830956uL, "[Mod: Undo It!] Doesn't undo roundabouts. Use the undo feature of Smart Intersections instead." },
                },
                SourceURL = "https://github.com/Strdate/SmartIntersections",
            });

            AddMod(new Review(1645781000uL, "Elektrix's Road Tools 2.91") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool (invert flag)
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool (invert flag)
                    { 1597198847uL, Status.Incompatible }, // [Legacy] Segment Slope Smoother
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1597198847uL, // [Legacy] Segment Slope Smoother
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
            });

            AddMod(new Review(1625704117uL, "Roundabout Builder") {
                Affect = Factor.PlaceAndMove,
                Authors = "Strad",
                Catalog = catalog,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1890830956uL, Status.MinorIssues  }, // Undo It!
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1890830956uL, "[Mod: Undo It!] Doesn't undo roundabouts. Use undo feature of Roundabout Builder instead." },
                },
                SourceURL = "https://github.com/Strdate/AutomaticRoundaboutBuilder",
            });

            AddMod(new Review(1619685021uL, "Move It 2.7.0") {
                Affect = Factor.PlaceAndMove,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1890830956uL, Status.MinorIssues  }, // Undo It!
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 924884948uL , Status.Compatible   }, // Plop the Growables
                    { 787611845uL , Status.Recommended  }, // Prop Snapping
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 503147777uL , Status.Compatible   }, // Moledozer
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 766190099uL, // Move It (original)
                Flags = ItemFlags.Recommended // rare accolade
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=1999726060" },
                },
                SourceURL = "https://github.com/Quboid/CS-MoveIt",
            });

            AddMod(new Review(1612012531uL, "Net Picker 2.0") {
                Affect = Factor.PlaceAndMove
                       | Factor.Toolbar, // toolbar altering mods can adversely affect it
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Compatible   }, // Move It! 移动它 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251uL, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Compatible   }, // Fine Road Anarchy 2
                    { 1619685021uL, Status.Compatible   }, // Move It 2.7.0
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1436255148uL, Status.Compatible   }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1362508329uL, Status.Compatible   }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
            });

            // Might cause issues with TM:PE - short segments entering junctions causes AI issues
            AddMod(new Review(1586027591uL, "Tiny Segments") {
                Affect = Factor.PlaceAndMove, // todo; networks factor
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.MinorIssues  }, // TrafficManager
                    { 1957033250uL, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141uL, Status.MinorIssues  }, // TMPE v11 LABS (issues at junctions)
                    { 1637663252uL, Status.MinorIssues  }, // TMPE v11 STABLE (issues at junctions)
                    { 1604291910uL, Status.MinorIssues  }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.MinorIssues  }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.MinorIssues  }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1806963141uL, "[Mod: TM:PE v11 LABS] Small segements at junctions can make vehicles misbehave." },
                    { 1637663252uL, "[Mod: TM:PE v11 STABLE] Small segements at junctions can make vehicles misbehave." },
                },
                Published = WorkshopDate("8 Dec, 2018"),
                Updated = WorkshopDate("14 Sep, 2019"),
            });

            AddMod(new Review(1440928803uL, "Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2083188521uL, Status.Compatible   }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Compatible   }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2065380745uL, Status.Compatible   }, // MetroReplacer
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2053661585uL, Status.Compatible   }, // Emergency Lights Manager V2
                    { 2045011960uL, Status.Compatible   }, // Loading Screen 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy (clone)
                    { 2040656402uL, Status.Compatible   }, // Harmony 2.0.0.9
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2034713132uL, Status.Compatible   }, // Auto Repair
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1959183067uL, Status.Unknown      }, // CSUR Loader
                    { 1938493221uL, Status.Compatible   }, // Mini FPS Booster 1.0
                    { 1922400472uL, Status.Compatible   }, // Enhanced District Services 1.0.18
                    { 1894425170uL, Status.Compatible   }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.Incompatible }, // 加载优化 Loading Screen
                    { 1844442251uL, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141uL, Status.Compatible   }, // TM:PE 11 LABS
                    { 1806759255uL, Status.Compatible   }, // Customize It! Extended
                    { 1764637396uL, Status.Compatible   }, // Toggle It!
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1756089251uL, Status.Compatible   }, // Zoom It!
                    { 1721492498uL, Status.Compatible   }, // Optimised Outside Connections
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1664509314uL, Status.Compatible   }, // Custom Animation Loader (CAL)
                    { 1661072176uL, Status.Compatible   }, // Empty It!
                    { 1658679290uL, Status.Compatible   }, // Forest Brush
                    { 1656549865uL, Status.Compatible   }, // Rebuild It!
                    { 1645781000uL, Status.Compatible   }, // Elektrix's Road Tools
                    { 1643902284uL, Status.Compatible   }, // Watch It!
                    { 1637663252uL, Status.Compatible   }, // TM:PE 11 STABLE
                    { 1627986403uL, Status.Compatible   }, // Bulldoze It!
                    { 1619685021uL, Status.Compatible   }, // Move It 2.7.1
                    { 1612287735uL, Status.Compatible   }, // Purchase It!
                    { 1591417160uL, Status.Compatible   }, // Hide It!
                    { 1577882296uL, Status.Compatible   }, // Resize It!
                    { 1567569285uL, Status.Compatible   }, // Achieve It!
                    { 1562650024uL, Status.Compatible   }, // Rebalanced Industries
                    { 1556715327uL, Status.Compatible   }, // Show It!
                    { 1552053911uL, Status.Compatible   }, // Trailer Variation Loader
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options (v1.9 or above)
                    { 1530376523uL, Status.Compatible   }, // Railway Replacer
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1415090282uL, Status.Compatible   }, // AutoLineColor Redux
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1393452031uL, Status.Compatible   }, // Parkify r1.0.3
                    { 1388613752uL, Status.Compatible   }, // Tree Movement Control
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 973512634uL , Status.Compatible   }, // Sort Mod Settings
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2 [r5.0.3]
                    { 922939393uL , Status.Compatible   }, // Transparency LOD Fix + Cloud Assets Enabler
                    { 837734529uL , Status.Compatible   }, // Find It! 1.5.4
                    { 833779378uL , Status.Compatible   }, // Loading Screen Mod [Test]
                    { 818641631uL , Status.Compatible   }, // Ambient Sounds Tuner
                    { 815103125uL , Status.Compatible   }, // Extra Vehicle Effects
                    { 814498849uL , Status.Compatible   }, // Improved Content Manager
                    { 811352708uL , Status.Compatible   }, // Ragnarok
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 787611845uL , Status.Compatible   }, // Prop Snapping
                    { 780720853uL , Status.Compatible   }, // Vehicle Effects 1.8.1b
                    { 767233815uL , Status.Compatible   }, // Decal Prop Fix
                    { 707497031uL , Status.Compatible   }, // Tram Station Track
                    { 694123443uL , Status.Compatible   }, // American Traffic Lights
                    { 690066392uL , Status.Compatible   }, // American Roadsigns 2.2.0
                    { 667342976uL , Status.Compatible   }, // Loading Screen Mod
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 645390478uL , Status.Compatible   }, // Map Editor Tunnels Enabler
                    { 627096876uL , Status.Compatible   }, // Improved Wind Simulation
                    { 618536610uL , Status.Compatible   }, // AST: KRA Sound Pack
                    { 608517757uL , Status.Compatible   }, // Sub-Buildings Tabs
                    { 593588108uL , Status.Compatible   }, // Prop & Tree Anarchy
                    { 591137516uL , Status.Compatible   }, // Redcomet's Municipal Sound Pack
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 543722850uL , Status.Unknown      }, // Network Skins (Park Life compatible)
                    { 530871278uL , Status.Compatible   }, // Daylight Classic
                    { 530771650uL , Status.Compatible   }, // Prefab Hook
                    { 515489008uL , Status.Compatible   }, // Extra Train Station Tracks
                    { 512314255uL , Status.Compatible   }, // More Network Stuff
                    { 502750307uL , Status.Compatible   }, // Extra Landscaping Tools
                    { 465127441uL , Status.Compatible   }, // Airport Roads 1.3.7
                    { 455403039uL , Status.Compatible   }, // Unlimited Trees Mod
                    { 445589127uL , Status.Compatible   }, // Precision Engineering
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (AVO)
                    { 427258853uL , Status.Compatible   }, // Pedestrian Crossings
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 409776678uL , Status.Compatible   }, // Demand Master
                    { 409171141uL , Status.Compatible   }, // Cash on Demand
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1400711138uL, // [BETA] Parallel Road Tool
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 1844442251uL, "[Mod: Fine Road Tool] Should now be compatible since PRT update on 26 Apr, 2020."},
                },
                Published = WorkshopDate("14 Jul, 2018"),
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
                Updated = WorkshopDate("26 Apr, 2020"),
            });

            AddMod(new Review(1400711138uL, "[BETA] Parallel Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2083188521uL, Status.Compatible   }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Compatible   }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2065380745uL, Status.Compatible   }, // MetroReplacer
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2053661585uL, Status.Compatible   }, // Emergency Lights Manager V2
                    { 2045011960uL, Status.Compatible   }, // Loading Screen 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy (clone)
                    { 2040656402uL, Status.Compatible   }, // Harmony 2.0.0.9
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2034713132uL, Status.Compatible   }, // Auto Repair
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1959183067uL, Status.Unknown      }, // CSUR Loader
                    { 1938493221uL, Status.Compatible   }, // Mini FPS Booster 1.0
                    { 1922400472uL, Status.Compatible   }, // Enhanced District Services 1.0.18
                    { 1894425170uL, Status.Compatible   }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.Incompatible }, // 加载优化 Loading Screen
                    { 1844442251uL, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141uL, Status.Compatible   }, // TM:PE 11 LABS
                    { 1806759255uL, Status.Compatible   }, // Customize It! Extended
                    { 1764637396uL, Status.Compatible   }, // Toggle It!
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1756089251uL, Status.Compatible   }, // Zoom It!
                    { 1721492498uL, Status.Compatible   }, // Optimised Outside Connections
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1664509314uL, Status.Compatible   }, // Custom Animation Loader (CAL)
                    { 1661072176uL, Status.Compatible   }, // Empty It!
                    { 1658679290uL, Status.Compatible   }, // Forest Brush
                    { 1656549865uL, Status.Compatible   }, // Rebuild It!
                    { 1645781000uL, Status.Compatible   }, // Elektrix's Road Tools
                    { 1643902284uL, Status.Compatible   }, // Watch It!
                    { 1637663252uL, Status.Compatible   }, // TM:PE 11 STABLE
                    { 1627986403uL, Status.Compatible   }, // Bulldoze It!
                    { 1619685021uL, Status.Compatible   }, // Move It 2.7.1
                    { 1612287735uL, Status.Compatible   }, // Purchase It!
                    { 1591417160uL, Status.Compatible   }, // Hide It!
                    { 1577882296uL, Status.Compatible   }, // Resize It!
                    { 1567569285uL, Status.Compatible   }, // Achieve It!
                    { 1562650024uL, Status.Compatible   }, // Rebalanced Industries
                    { 1556715327uL, Status.Compatible   }, // Show It!
                    { 1552053911uL, Status.Compatible   }, // Trailer Variation Loader
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options (v1.9 or above)
                    { 1530376523uL, Status.Compatible   }, // Railway Replacer
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1415090282uL, Status.Compatible   }, // AutoLineColor Redux
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1393452031uL, Status.Compatible   }, // Parkify r1.0.3
                    { 1388613752uL, Status.Compatible   }, // Tree Movement Control
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 973512634uL , Status.Compatible   }, // Sort Mod Settings
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2 [r5.0.3]
                    { 922939393uL , Status.Compatible   }, // Transparency LOD Fix + Cloud Assets Enabler
                    { 837734529uL , Status.Compatible   }, // Find It! 1.5.4
                    { 833779378uL , Status.Compatible   }, // Loading Screen Mod [Test]
                    { 818641631uL , Status.Compatible   }, // Ambient Sounds Tuner
                    { 815103125uL , Status.Compatible   }, // Extra Vehicle Effects
                    { 814498849uL , Status.Compatible   }, // Improved Content Manager
                    { 811352708uL , Status.Compatible   }, // Ragnarok
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 787611845uL , Status.Compatible   }, // Prop Snapping
                    { 780720853uL , Status.Compatible   }, // Vehicle Effects 1.8.1b
                    { 767233815uL , Status.Compatible   }, // Decal Prop Fix
                    { 707497031uL , Status.Compatible   }, // Tram Station Track
                    { 694123443uL , Status.Compatible   }, // American Traffic Lights
                    { 690066392uL , Status.Compatible   }, // American Roadsigns 2.2.0
                    { 667342976uL , Status.Compatible   }, // Loading Screen Mod
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 645390478uL , Status.Compatible   }, // Map Editor Tunnels Enabler
                    { 627096876uL , Status.Compatible   }, // Improved Wind Simulation
                    { 618536610uL , Status.Compatible   }, // AST: KRA Sound Pack
                    { 608517757uL , Status.Compatible   }, // Sub-Buildings Tabs
                    { 593588108uL , Status.Compatible   }, // Prop & Tree Anarchy
                    { 591137516uL , Status.Compatible   }, // Redcomet's Municipal Sound Pack
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 543722850uL , Status.Unknown      }, // Network Skins (Park Life compatible)
                    { 530871278uL , Status.Compatible   }, // Daylight Classic
                    { 530771650uL , Status.Compatible   }, // Prefab Hook
                    { 515489008uL , Status.Compatible   }, // Extra Train Station Tracks
                    { 512314255uL , Status.Compatible   }, // More Network Stuff
                    { 502750307uL , Status.Compatible   }, // Extra Landscaping Tools
                    { 465127441uL , Status.Compatible   }, // Airport Roads 1.3.7
                    { 455403039uL , Status.Compatible   }, // Unlimited Trees Mod
                    { 445589127uL , Status.Compatible   }, // Precision Engineering
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (AVO)
                    { 427258853uL , Status.Compatible   }, // Pedestrian Crossings
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 409776678uL , Status.Compatible   }, // Demand Master
                    { 409171141uL , Status.Compatible   }, // Cash on Demand
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 1844442251uL, "[Mod: Fine Road Tool] Should now be compatible since PRT update on 26 Apr, 2020."},
                },
                Published = WorkshopDate("2 Jun, 2018"),
                ReplaceWith = 1440928803uL, // Parallel Road Tool
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
                Updated = WorkshopDate("26 Apr, 2020"),
            });

            AddMod(new Review(1393797695uL, "Touch This! Tool 3") {
                Affect = Factor.Pathfinder // may chance how pathfinder relates to buildings
                       | Factor.PlaceAndMove
                       | Factor.TransportLines, // can break transport lines
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2045014295uL, Status.Compatible   }, // Move It! 移动它 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Compatible   }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Compatible   }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Compatible   }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Compatible   }, // Fine Road Anarchy 2
                    { 1619685021uL, Status.Compatible   }, // Move It 2.7.0
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                SourceURL = "https://github.com/klyte45/TouchThisTool",
                // todo: incompat with older touch tool no longer in workshop
            });

            AddMod(new Review(912329352uL, "Building Anarchy") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI, // construction tooltips
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2060132379uL, Status.Unknown      }, // Path Snapping
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 821539759uL , Status.Incompatible }, // Disable Zone Check
                    { 766190099uL , Status.Incompatible }, // Move It
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have problem with building placement, try deleting 'BuildingAnarchy.xml' from\n  'C:\\Users\\YOURUSER\\AppData\\Local\\Colossal Order\\Cities_Skylines'" },
                    { NOTE, "Incorrect use of this mod can seriously mess up your city; buildings further than 2 zoning squares from road cannot be reached! Use with caution!" },
                    { NOTE, "Usage notes: https://steamcommunity.com/workshop/filedetails/discussion/912329352/1326718197216147348/" },
                    { NOTE, "A somewhat safer alternative is 'Path Snapping' mod: https://steamcommunity.com/sharedfiles/filedetails/?id=2060132379" },
                },
                Published = WorkshopDate("24 Apr, 2017"),
                SourceURL = "https://github.com/TPBCS/BuildingAnarchy",
                Updated = WorkshopDate("13 Nov, 2018"),
            });

            AddMod(new Review(821539759uL, "Disable Zone Check") {
                Affect = Factor.PlaceAndMove
                       | Factor.Zoning,
                Authors = "AJ3D",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 912329352uL , Status.Incompatible }, // Building Anarchy
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod sometimes causes multiple buildings to spawn on top of each other." },
                    { 924884948uL, "[Mod: Plop the Growables] Disable Zone Check causes buildings that were placed with Plop the Growables to despawn." },
                },
                Published = WorkshopDate("19 Dec, 2016"),
                ReplaceWith = 924884948uL, // Plop the Growables
                SourceURL = "https://github.com/AJ3D/DisaableZoneCheck/tree/master/DisaableZoneCheck",
                Updated = WorkshopDate("19 Dec, 2016"),
            });

            AddMod(new Review(818899749uL, "WaterPipeUpgrader v2 PARKLIFE READY") {
                Affect = Factor.PlaceAndMove,
                Authors = "headkillah",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818899749uL , Status.Incompatible }, // WaterPipeUpgrader v2 PARKLIFE READY
                    { 636081274uL , Status.Incompatible }, // Water Pipe Upgrader
                },
                CompatibleWith = GameVersion.Campus,
                ContinuationOf = 636081274uL, // Water Pipe Upgrader
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("15 Dec, 2016"),
                RequiredDLC = DLCs.Snowfall,
                SourceURL = "https://github.com/Headkillah/CS-WaterPipeUpgraderv2",
                Updated = WorkshopDate("16 Jun, 2018"),
            });

            AddMod(new Review(793346248uL, "Decal Hover Area") {
                Affect = Factor.UI,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 767233815uL , Status.Required    }, // Decal Prop Fix
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("4 Nov, 2016"),
                Updated = WorkshopDate("15 Aug, 2017"),
            });

            AddMod(new Review(791221322uL, "Prop Precision") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                Authors = "Boogieman Sam",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 787611845uL , Status.Compatible   }, // Prop Snapping
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("1 Nov, 2016"),
                SourceURL = "https://github.com/SamsamTS/CS-PropPrecision",
                Updated = WorkshopDate("1 Nov, 2016"),
            });

            AddMod(new Review(787611845uL, "Prop Snapping") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 791221322uL , Status.Compatible   }, // Prop Precision
                    { 593588108uL , Status.Required     }, // Prop & Tree Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("26 Oct, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-PropSnapping",
                Updated = WorkshopDate("24 May, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2082427515uL, "[DEPRECATED ] PrecisionEngineering - Length snapping fix test") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Tuna",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2083188521uL, Status.Incompatible }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Incompatible }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 876444259uL , Status.Incompatible }, // PrecisionEngineering测量工具
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 445589127uL, // Precision Engineering
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // was temp test, now replaced by v2.0
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Hold Ctrl while placing roads/rails to enable angle snapping (5 degree increments)." },
                    { NOTE, "Hold Alt while placing roads/rails to enable snapping to guidelines." },
                    { NOTE, "Hold Shift while placing roads/rails to show additional information." },
                },
                Published = WorkshopDate("2 May, 2020"),
                ReplaceWith = 2083188521uL, // Precision Engineering 2.0
                SourceURL = "https://github.com/tunaflish/PrecisionEngineering",
                Updated = WorkshopDate("2 May, 2020"),
            });

            AddMod(new Review(2059655996uL, "[Beta] PRT-2") {
                Affect = Factor.PlaceAndMove,
                Authors = "S__T, Tim, resonansER",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2083188521uL, Status.Compatible   }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Compatible   }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2065380745uL, Status.Compatible   }, // MetroReplacer
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2053661585uL, Status.Compatible   }, // Emergency Lights Manager V2
                    { 2045011960uL, Status.Compatible   }, // Loading Screen 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy (clone)
                    { 2040656402uL, Status.Compatible   }, // Harmony 2.0.0.9
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2034713132uL, Status.Compatible   }, // Auto Repair
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1959183067uL, Status.Unknown      }, // CSUR Loader
                    { 1938493221uL, Status.Compatible   }, // Mini FPS Booster 1.0
                    { 1922400472uL, Status.Compatible   }, // Enhanced District Services 1.0.18
                    { 1894425170uL, Status.Compatible   }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.Incompatible }, // 加载优化 Loading Screen
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Required     }, // Fine Road Anarchy 2
                    { 1806963141uL, Status.Compatible   }, // TM:PE 11 LABS
                    { 1806759255uL, Status.Compatible   }, // Customize It! Extended
                    { 1764637396uL, Status.Compatible   }, // Toggle It!
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1756089251uL, Status.Compatible   }, // Zoom It!
                    { 1721492498uL, Status.Compatible   }, // Optimised Outside Connections
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1664509314uL, Status.Compatible   }, // Custom Animation Loader (CAL)
                    { 1661072176uL, Status.Compatible   }, // Empty It!
                    { 1658679290uL, Status.Compatible   }, // Forest Brush
                    { 1656549865uL, Status.Compatible   }, // Rebuild It!
                    { 1645781000uL, Status.Compatible   }, // Elektrix's Road Tools
                    { 1643902284uL, Status.Compatible   }, // Watch It!
                    { 1637663252uL, Status.Compatible   }, // TM:PE 11 STABLE
                    { 1627986403uL, Status.Compatible   }, // Bulldoze It!
                    { 1619685021uL, Status.Compatible   }, // Move It 2.7.1
                    { 1612287735uL, Status.Compatible   }, // Purchase It!
                    { 1591417160uL, Status.Compatible   }, // Hide It!
                    { 1577882296uL, Status.Compatible   }, // Resize It!
                    { 1567569285uL, Status.Compatible   }, // Achieve It!
                    { 1562650024uL, Status.Compatible   }, // Rebalanced Industries
                    { 1556715327uL, Status.Compatible   }, // Show It!
                    { 1552053911uL, Status.Compatible   }, // Trailer Variation Loader
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options (v1.9 or above)
                    { 1530376523uL, Status.Compatible   }, // Railway Replacer
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1415090282uL, Status.Compatible   }, // AutoLineColor Redux
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1393452031uL, Status.Compatible   }, // Parkify r1.0.3
                    { 1388613752uL, Status.Compatible   }, // Tree Movement Control
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 973512634uL , Status.Compatible   }, // Sort Mod Settings
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2 [r5.0.3]
                    { 922939393uL , Status.Compatible   }, // Transparency LOD Fix + Cloud Assets Enabler
                    { 837734529uL , Status.Compatible   }, // Find It! 1.5.4
                    { 833779378uL , Status.Compatible   }, // Loading Screen Mod [Test]
                    { 818641631uL , Status.Compatible   }, // Ambient Sounds Tuner
                    { 815103125uL , Status.Compatible   }, // Extra Vehicle Effects
                    { 814498849uL , Status.Compatible   }, // Improved Content Manager
                    { 811352708uL , Status.Compatible   }, // Ragnarok
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 787611845uL , Status.Compatible   }, // Prop Snapping
                    { 780720853uL , Status.Compatible   }, // Vehicle Effects 1.8.1b
                    { 767233815uL , Status.Compatible   }, // Decal Prop Fix
                    { 766190099uL , Status.Incompatible }, // Move It (old)
                    { 707497031uL , Status.Compatible   }, // Tram Station Track
                    { 694123443uL , Status.Compatible   }, // American Traffic Lights
                    { 690066392uL , Status.Compatible   }, // American Roadsigns 2.2.0
                    { 667342976uL , Status.Compatible   }, // Loading Screen Mod
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 645390478uL , Status.Compatible   }, // Map Editor Tunnels Enabler
                    { 627096876uL , Status.Compatible   }, // Improved Wind Simulation
                    { 618536610uL , Status.Compatible   }, // AST: KRA Sound Pack
                    { 608517757uL , Status.Compatible   }, // Sub-Buildings Tabs
                    { 593588108uL , Status.Compatible   }, // Prop & Tree Anarchy
                    { 591137516uL , Status.Compatible   }, // Redcomet's Municipal Sound Pack
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 543722850uL , Status.Unknown      }, // Network Skins (Park Life compatible)
                    { 530871278uL , Status.Compatible   }, // Daylight Classic
                    { 530771650uL , Status.Compatible   }, // Prefab Hook
                    { 515489008uL , Status.Compatible   }, // Extra Train Station Tracks
                    { 512314255uL , Status.Compatible   }, // More Network Stuff
                    { 502750307uL , Status.Compatible   }, // Extra Landscaping Tools
                    { 465127441uL , Status.Compatible   }, // Airport Roads 1.3.7
                    { 455403039uL , Status.Compatible   }, // Unlimited Trees Mod
                    { 445589127uL , Status.Compatible   }, // Precision Engineering
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (AVO)
                    { 427258853uL , Status.Compatible   }, // Pedestrian Crossings
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 409776678uL , Status.Compatible   }, // Demand Master
                    { 409171141uL , Status.Compatible   }, // Cash on Demand
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1440928803uL, // Parallel Road Tool
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // original version now updated
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "zh-cn", "nl", "en", "fr", "de", "it", "ja", "pt", "ru", "es", },
                LastSeen = WorkshopDate("24 Apr, 2020"),
                Locale = "en",
                Published = WorkshopDate("13 Apr, 2020"),
                Removed = WorkshopDate("26 Apr, 2020"),
                ReplaceWith = 1440928803uL, // Parallel Road Tool
                SourceURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            AddMod(new Review(2045014295uL, "Move It! 移动它 中文版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Yuuki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1890830956uL, Status.MinorIssues  }, // Undo It!
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1393797695uL, Status.Compatible   }, // Touch This! Tool 3
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 787611845uL , Status.Recommended  }, // Prop Snapping
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1619685021uL, // Move It (current stable release)
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                Published = WorkshopDate("2 Apr, 2020"),
                Updated = WorkshopDate("2 Apr, 2020"),
            });

            AddMod(new Review(2043038271uL, "Fine Road Anarchy") {
                Affect = Factor.PlaceAndMove,
                Authors = "jorgesatoor",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611uL, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117uL, Status.Incompatible }, // Roundabout Builder
                    { 1612012531uL, Status.Incompatible }, // Net Picker 2.0
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Incompatible }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // on or before 13/Apr/2020
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("1 Apr, 2020"),
                ReplaceWith = 1844440354uL, // Fine Road Anarchy 2
                Suppress = Warning.InvalidVersionSequence | Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMod(new Review(1895443005uL, "Fine Road Anarchy 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1844440354uL, // Fine Road Anarchy 2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Compatible   }, // Dynamic Text Props
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695uL, Status.Compatible   }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354uL, // Fine Road Anarchy 2
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1895440521uL, "Fine Road Tool 2 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1844442251uL, // Fine Road Tool 2.0.3
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Compatible   }, // Dynamic Text Props
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1393797695uL, Status.Compatible   }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844442251uL, // Fine Road Tool 2.0.3
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1892174866uL, "MoveIt2.6汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Catnip.",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1619685021uL, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021uL, // Move It 2.7.1
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1866239503uL, "MOVE IT Sakuya16个人汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "Izayoi _Sakuya16",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 1619685021uL, // Move It
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021uL, // Move It 2.7.1
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1857894421uL, "766190099_Move_It_") {
                Affect = Factor.PlaceAndMove,
                Authors = "r.heikens",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                CloneOf = 766190099uL, // Move It (original version)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Incompatible }, // Move It (original)
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
                ReplaceWith = 1619685021uL, // Move It (current stable release)
                Suppress = Warning.InvalidVersionSequence | Warning.OlderReplacement,
            });

            AddMod(new Review(1856282754uL, "MoveIt 汉化版") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 1619685021uL, // Move It (current stable release)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                },
                Flags = ItemFlags.Abandonware // stuck on v2.5.0
                      | ItemFlags.ForceMigration
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1619685021uL, // Move It (current stable release)
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1622545887uL, "Move It! 2.3.0 (Updated for Industries patch)") {
                Affect = Factor.PlaceAndMove,
                Authors = "RudRecciah",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                },
                ContinuationOf = 766190099uL, // Move It
                Flags = ItemFlags.Abandonware // Was temporary bug fix
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1619685021uL, // Move It (current stable release)
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1597198847uL, "[Legacy] Segment Slope Smoother") {
                Affect = Factor.PlaceAndMove,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1645781000uL, Status.Incompatible }, // Elektrix's Road Tools 2.91
                },
                Flags = ItemFlags.Abandonware // Elektrix states no further development
                      | ItemFlags.Obsolete // Replaced by Road Tools
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                ReplaceWith = 1645781000uL, // Elektrix's Road Tools 2.91
            });

            AddMod(new Review(1436255148uL, "Fine Road Anarchy 汉化版1.3.5") {
                Affect = Factor.PlaceAndMove,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 802066100uL, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611uL, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117uL, Status.Incompatible }, // Roundabout Builder
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Incompatible }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues // Breaks tooling of other mods
                      | ItemFlags.Obsolete // Fixed mods available
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1844440354uL, // Fine Road Anarchy 2
            });

            AddMod(new Review(1362508329uL, "TC01 - FineRoadAnarchy! (2018)") {
                Affect = Factor.PlaceAndMove,
                Authors = "Fatih ÇELİK",
                Catalog = catalog,
                CloneOf = 802066100uL, // Fine Road Anarchy
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611uL, Status.Incompatible }, // Smart Intersection Builder
                    { 1625704117uL, Status.Incompatible }, // Roundabout Builder
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Incompatible }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Incompatible }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Ancient version of the mod
                      | ItemFlags.Obsolete // Fixed mods available
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "tr",
                ReplaceWith = 1844440354uL, // Fine Road Anarchy 2
            });

            AddMod(new Review(1120637951uL, "[OUTDATED] Move It! Extra Filters") {
                Affect = Factor.PlaceAndMove,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 766190099uL , Status.Required     }, // Move It (original)
                },
                ReplaceWith = 1619685021uL, // Move It (curent stable release)
                SourceURL = "https://gist.github.com/simon56modder/46b2d593e0364fb5386c80c3c97ae396",
            });

            AddMod(new Review(876444259uL, "PrecisionEngineering测量工具") {
                Affect = Factor.PlaceAndMove,
                Authors = "可乐楠",
                Catalog = catalog,
                CloneOf = 445589127uL, // Precision Engineering
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2083188521uL, Status.Incompatible }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Incompatible }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 876444259uL , Status.Incompatible }, // PrecisionEngineering测量工具
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                },
                CompatibleWith = GameVersion.Patch_1_6_3_f1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                Published = WorkshopDate("4 Mar, 2017"),
                ReplaceWith = 445589127uL, // Precision Engineering
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("4 Mar, 2017"),
            });

            AddMod(new Review(802066100uL, "Fine Road Anarchy") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611uL, Status.Compatible   }, // Smart Intersection Builder
                    { 1625704117uL, Status.Compatible   }, // Roundabout Builder
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Incompatible }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Compatible   }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                // todo: might actually have been cont. of sharper junction angles mod
                ContinuationOf = 418556522uL, // Road Anarchy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE,  "Sunset Harbor: Colission toggle isn't working properly; also breaks metro line placement.\n" },
                },
                Published = WorkshopDate("18 Nov, 2016"),
                ReplaceWith = 1844440354uL, // Fine Road Anarchy 2
                SourceURL = "https://github.com/SamsamTS/CS-FineRoadAnarchy",
                Updated = WorkshopDate("24 May, 2018"),
            });

            // original version
            AddMod(new Review(766190099uL, "Move It") {
                Affect = Factor.PlaceAndMove,
                ArchiveURL = "https://web.archive.org/web/20190109162233/https://steamcommunity.com/sharedfiles/filedetails/?id=766190099",
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.7.0
                    { 1120637951uL, Status.Compatible   }, // [OUTDATED] Move It! Extra Filters
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 912329352uL , Status.Incompatible }, // Building Anarchy (just sick of seeing this break games!)
                    { 791221322uL , Status.Required     }, // Prop Precision
                    { 787611845uL , Status.Required     }, // Prop Snapping
                    { 766190099uL , Status.Incompatible }, // Move It (original)
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.Patch_1_10_1_f3,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Industries
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // Removed some time around Feb 2019
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("9 Jan, 2019"), // web archive
                Published = WorkshopDate("18 Sep, 2016"),
                Removed = WorkshopDate("1 Feb, 2019"), // web archive
                ReplaceWith = 1619685021uL, // Move It (curent stable release)
                SourceURL = "https://github.com/SamsamTS/CS-MoveIt",
                Updated = WorkshopDate("26 Aug, 2018"),
            });

            // original mod
            AddMod(new Review(651322972uL, "Fine Road Tool") {
                Affect = Factor.PlaceAndMove,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Incompatible }, // [Beta] PRT-2
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Incompatible }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Incompatible }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Incompatible }, // Fine Road Tool 2.0.3
                    { 1844440354uL, Status.Incompatible }, // Fine Road Anarchy 2
                    { 1831805509uL, Status.Incompatible }, // Dynamic Text Props
                    { 1677913611uL, Status.Compatible   }, // Smart Intersection Builder
                    { 1625704117uL, Status.Compatible   }, // Roundabout Builder
                    { 1612012531uL, Status.Compatible   }, // Net Picker 2.0
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393797695uL, Status.Incompatible }, // Touch This Tool
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 802066100uL , Status.Compatible   }, // Fine Road Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 418556522uL, // Road Anarchy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Snowfall,
                ReplaceWith = 1844442251uL, // Fine Road Tool 2
                SourceURL = "https://github.com/SamsamTS/CS-FineRoadTool",
            });

            AddMod(new Review(636081274uL, "Water Pipe Upgrader") {
                Affect = Factor.PlaceAndMove,
                ArchiveURL = "https://web.archive.org/web/20160306220347/http://steamcommunity.com/sharedfiles/filedetails/?id=636081274",
                Authors = "DontCryJustDie",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818899749uL , Status.Incompatible }, // WaterPipeUpgrader v2 PARKLIFE READY
                    { 636081274uL , Status.Incompatible }, // Water Pipe Upgrader
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 Mar, 2016"),
                Published = WorkshopDate("1 Mar, 2016"),
                Removed = WorkshopDate("17 Dec, 2018"),
                ReplaceWith = 818899749uL, // WaterPipeUpgrader v2 PARKLIFE READY
                RequiredDLC = DLCs.Snowfall,
                Updated = WorkshopDate("1 Mar, 2016"),
            });

            AddMod(new Review(445589127uL, "Precision Engineering") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Simie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2083188521uL, Status.Incompatible }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Incompatible }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 876444259uL , Status.Incompatible }, // PrecisionEngineering测量工具
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Hold Ctrl while placing roads/rails to enable angle snapping (5 degree increments)." },
                    { NOTE, "Hold Alt while placing roads/rails to enable snapping to guidelines." },
                    { NOTE, "Hold Shift while placing roads/rails to show additional information." },
                },
                Published = WorkshopDate("19 May, 2015"),
                ReplaceWith = 2083188521uL, // Precision Engineering 2.0
                SourceURL = "https://github.com/Simie/PrecisionEngineering",
                Updated = WorkshopDate("29 Mar, 2016"),
            });

            AddMod(new Review(436253779uL, "Road Protractor") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Oelderoth",
                BrokenBy = GameVersion.Snowfall, // users starting reporting lag and crashes after Snowfall release
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2083188521uL, Status.Incompatible }, // Precision Engineering 2.0
                    { 2082427515uL, Status.Incompatible }, // [DEPRECATED ] PrecisionEngineering - Length snapping fix test
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 876444259uL , Status.Incompatible }, // PrecisionEngineering测量工具
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("2 May, 2015"),
                ReplaceWith = 2083188521uL, // Precision Engineering 2.0
                Updated = WorkshopDate("20 May, 2015"),
            });
        }
    }
}