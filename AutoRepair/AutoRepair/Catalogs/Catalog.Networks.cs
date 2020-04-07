namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that add or alter networks.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        private void NetworksCatalog() {

            string catalog = "Networks";

            AddMod(new Item(1959342332u, "CSUR ToolBox") {
                Affect = Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.RoadMarkings,
                Authors = "amamlya, pcfantasy, VictoriaCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044086131u, Status.Incompatible }, // Network Extensions 2 - Sunset Harbour Build / Fix
                    { 1959183067u, Status.Required     }, // CSUR Loader
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 427258853u , Status.Incompatible }, // Crossings
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 2044086131u, "[Mod: Network Extensions 2] Breaks NExt2 road zoning position and Zone Adjuster (Shift+Click)" },
                    { 812125426u , "[Mod: Network Extensions 2] Breaks NExt2 road zoning position and Zone Adjuster (Shift+Click)" },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/citiesskylines-csur/CSURToolBox",
            });

            // Todo - list more assets?
            AddMod(new Item(1959183067u, "CSUR Loader") {
                Affect = Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.Props
                       | Factor.RoadMarkings
                       | Factor.TrafficLights,
                Authors = "amamlya, pcfantasy, VictoriaCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959342332u, Status.Required     }, // CSUR ToolBox
                    { 1959210164u, Status.Required     }, // CSUR Basic Pack [R1]
                    { 1758376843u, Status.MinorIssues  }, // Network Skins 2 (overrides road color; likely desirable in that respect)
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803u, Status.Unknown      }, // Parallel Road Tool
                    { 1400711138u, Status.Unknown      }, // [BETA] Parallel Road Tool
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850u , Status.Incompatible }, // Network Skins (original)
                    { 417585852u , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/citiesskylines-csur/CSURLoader",
            });

            // seems to be based on cimtographer
            AddMod(new Item(1957515502u, "OpenStreetMap Import - generate roads from OSM with street names and road-type selection") {
                Affect = Factor.Naming
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove,
                Authors = "dopefish",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957515502u, Status.Incompatible }, // OpenStreetMap Import - generate roads from OSM with street names and road-type selection
                    { 1485051886u, Status.Incompatible }, // Cimtographer - rebuild for 1.10.1-f3
                    { 771161159u , Status.Incompatible }, // OSM Import
                    { 416064574u , Status.Incompatible }, // Cimtographer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                // ContinuationOf = ??
                Flags = ItemFlags.EditorMod
                      | ItemFlags.MinorBugs // doesn't check node/segment/lane limits properly
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // causes game crashes for some users
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/grilly86/Open-Street-Cities",
            });

            // todo: probably incompatible with MOM, etc
            AddMod(new Item(1953042839u, "Unified Railway System") {
                Affect = Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.TransportLines
                       | Factor.Vehicles,
                Authors = "fanyongda2012",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: probably incompatible with TMPE, MOM, etc
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Unknown      }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.Incompatible }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 816260433u , Status.Incompatible }, // Metro Overhaul Mod
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SaveChanging
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // will cause major problems
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: move to editor cat
            AddMod(new Item(1845697704u, "Network Dump Tools") {
                Affect = Factor.Textures,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "In game Graphics Settings, set 'Texture Quality' to 'High' before dumping for best quality." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/Cgameworld/NetworkDumpTools",
            });


        }
    }
}
