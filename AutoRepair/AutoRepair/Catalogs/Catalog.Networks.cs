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
        private void NetworkMods() {

            string catalog = "Networks";

            AddMod(new Review(1959342332uL, "CSUR ToolBox") {
                Affect = Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.RoadMarkings,
                Authors = "amamlya, pcfantasy, VictoriaCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 - Sunset Harbour Build / Fix
                    { 1959183067uL, Status.Required     }, // CSUR Loader
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 427258853uL , Status.Incompatible }, // Crossings
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 812125426uL , "[Mod: Network Extensions 2] Breaks NExt2 road zoning position and Zone Adjuster (Shift+Click)" },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/citiesskylines-csur/CSURToolBox",
            });

            // Todo - list more assets?
            AddMod(new Review(1959183067uL, "CSUR Loader") {
                Affect = Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.Props
                       | Factor.RoadMarkings
                       | Factor.TrafficLights,
                Authors = "amamlya, pcfantasy, VictoriaCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Unknown      }, // [Beta] PRT-2
                    { 1959342332uL, Status.Required     }, // CSUR ToolBox
                    { 1959210164uL, Status.Required     }, // CSUR Basic Pack [R1]
                    { 1758376843uL, Status.MinorIssues  }, // Network Skins 2 (overrides road color; likely desirable in that respect)
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803uL, Status.Unknown      }, // Parallel Road Tool
                    { 1400711138uL, Status.Unknown      }, // [BETA] Parallel Road Tool
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850uL , Status.Incompatible }, // Network Skins (original)
                    { 417585852uL , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/citiesskylines-csur/CSURLoader",
            });

            // seems to be based on cimtographer
            AddMod(new Review(1957515502uL, "OpenStreetMap Import - generate roads from OSM with street names and road-type selection") {
                Affect = Factor.Naming
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove,
                Authors = "dopefish",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957515502uL, Status.Incompatible }, // OpenStreetMap Import - generate roads from OSM with street names and road-type selection
                    { 1485051886uL, Status.Incompatible }, // Cimtographer - rebuild for 1.10.1-f3
                    { 771161159uL , Status.Incompatible }, // OSM Import
                    { 416064574uL , Status.Incompatible }, // Cimtographer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                // ContinuationOf = ??
                Flags = ItemFlags.EditorMod
                      | ItemFlags.MinorIssues // doesn't check node/segment/lane limits properly
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // causes game crashes for some users
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/grilly86/Open-Street-Cities",
            });

            // todo: probably incompatible with MOM, etc
            AddMod(new Review(1953042839uL, "Unified Railway System") {
                Affect = Factor.Pathfinder
                       | Factor.PlaceAndMove
                       | Factor.TransportLines
                       | Factor.Vehicles,
                Authors = "fanyongda2012",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: probably incompatible with TMPE, MOM, etc
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250uL, Status.Unknown      }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 816260433uL , Status.Incompatible }, // Metro Overhaul Mod
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // will cause major problems
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Review(883332136uL, "Any Road Outside Connections") {
                Affect = Factor.OutsideConnection, // todo; add network factor
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 530771650uL , Status.Required     }, // Prefab Hook
                    { 497033453uL , Status.Required     }, // Unlimited Outside Connections (Beta)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If the road has zoning, you will need to disable its zoning where it reaches edge of map (use a zoning mod to do that)." },
                },
                Published = WorkshopDate("14 Mar, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-AnyRoadOutsideConnections",
                Updated = WorkshopDate("18 May, 2017"),
            });

            AddMod(new Review(816260433uL, "Metro Overhaul Mod") {
                Affect = Factor.TransportLines
                       | Factor.TransportPreference, // todo; add network factor
                Authors = "Lazarus*Man, BloodyPenguin, bsquiklehausen, Tim The Terrible, BadPeanut",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2065380745uL, Status.Incompatible }, // MetroReplacer
                    { 2039036102uL, Status.Incompatible }, // Metro Station Converter
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1764208250uL, Status.Compatible   }, // More Vehicles
                    { 1530376523uL, Status.Incompatible }, // Railway Replacer
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                    { 820157360uL , Status.Compatible   }, // Spawn Points Fix
                    { 816325876uL , Status.Required     }, // Metropolitan Depot
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=1802098189" },
                    { NOTE, "Collection of required items: https://steamcommunity.com/sharedfiles/filedetails/?id=1798577756" },
                    { NOTE, "Users report 'Array Index' bug: https://github.com/bloodypenguin/Skylines-MetroOverhaulMod/issues/29" },
                },
                Published = WorkshopDate("11 Dec, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-MetroOverhaulMod",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

        }
    }
}