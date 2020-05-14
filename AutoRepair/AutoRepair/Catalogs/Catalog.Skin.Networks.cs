namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that skin road textures/meshes.
    ///
    /// Mods that just remove basic props/decals should go in Catalog.Hide.cs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinNetworkMods() {

            string catalog = "Skin.Networks";

            AddMod(new Review(2092856384uL, "Japanese Road Arrows") {
                Affect = Factor.RoadMarkings,
                Authors = "Ryuichi Kaminogi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160uL, Status.Compatible   }, // Hide It!
                    // incompat - anything that chances road arrows or markings etc
                    { 2092856384uL, Status.Incompatible }, // Japanese Road Arrows
                    { 2009708489uL, Status.Incompatible }, // Road Arrows Replacer [Spain]
                    { 956707300uL , Status.Incompatible }, // Remove Street Arrows
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("14 May, 2020"),
                Published = WorkshopDate("11 May, 2020"),
                SourceURL = "https://github.com/kaminogi/csl-japaneseroadarrows",
                Updated = WorkshopDate("11 May, 2020"),
            });

            AddMod(new Review(2085403475uL, "Node controller [pre release testing]") {
                Affect = Factor.Other,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1939169189uL, Status.Required     }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1806963141uL, Status.Required     }, // TM:PE v11.4.0 LABS (Traffic Manager: President Edition)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/kianzarrin/RoadTransitionManager/wiki" },
                },
                Published = WorkshopDate("5 May, 2020"),
                SourceURL = "https://github.com/kianzarrin/RoadTransitionManager",
                Updated = WorkshopDate("5 May, 2020"),
            });

            AddMod(new Review(2065380745uL, "MetroReplacer") {
                Affect = Factor.Props,
                Authors = "egi, REV0, Ronyx69, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 816260433uL , Status.Incompatible }, // Metro Overhaul Mod
                    { 774449380uL , Status.Incompatible }, // Catenary Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Compatible assets: https://steamcommunity.com/workshop/filedetails/?id=2065610088" },
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=1843406895" },
                    { 816260433uL, "[Mod: Metro Overhaul Mod] Both mods replace station tracks making them technically incompatible." },
                },
                Published = WorkshopDate("18 Apr, 2020"),
                Updated = WorkshopDate("19 Apr, 2020"),
            });

            AddMod(new Review(2045625827uL, "Cgameworld’s Railway/BVU Track Customizations") {
                Affect = Factor.Rendering // meh
                       | Factor.Textures,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1779369015uL, Status.Required     }, // Railway Shinkansen Gravel Wireless
                    { 1847646595uL, Status.Recommended  }, // Bienvenüe - Munich U-Bahn Tracks
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("3 Apr, 2020"),
                SourceURL = "https://github.com/Cgameworld/CGWRailwayCustomizations",
                Updated = WorkshopDate("3 Apr, 2020"),
            });

            // Requires TM:PE
            AddMod(new Review(2019097300uL, "Hide TM:PE Unconnected Tracks") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings, // not really, but close enough
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141uL, Status.Required     }, // TM:PE LABS
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1680642819uL, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252uL, Status.Compatible   }, // TM:PE STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481uL, Status.Compatible   }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Compatible   }, // Remove Road Textures - Blank Roads
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("10 Mar, 2020"),
                SourceURL = "https://github.com/kianzarrin/HideUnconnectedTracks",
                Tags = new[] { "TMPE", "TM:PE", "Tram", "Train", "Network", "Skins", "Junctions", "Tracks" },
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            AddMod(new Review(2009708489uL, "Road Arrows Replacer [Spain]") {
                Affect = Factor.RoadMarkings,
                Authors = "Nouvilas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2008960441uL, Status.Required     }, // Spanish Arrow Decals Pack
                    // hide it - if used to hide street arrows, road arrows replacer won't work
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    // incompat - anything that chances road arrows or markings etc
                    { 2092856384uL, Status.Incompatible }, // Japanese Road Arrows
                    { 956707300uL , Status.Incompatible }, // Remove Street Arrows
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It!] If you remove road arrows with Hide It, the Road Arrows Replacer can't replace them." },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Review(1939169189uL, "Hide Crosswalks V3.0 [EXPERIMENTAL]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141uL, Status.Recommended  }, // TM:PE LABS
                    { 1758376843uL, Status.Recommended  }, // Network Skins 2
                    { 1680642819uL, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252uL, Status.Compatible   }, // TM:PE STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1934023593uL, // Hide TMPE crosswalks V2.5 [BETA]
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Can use lots of RAM if you have lots of different roads that have crossings removed." },
                    { NOTE, "[Railway Replacer] and [Catenary Replacer] mods are suspected to be incompatible." },
                },
                Published = WorkshopDate("17 Dec, 2019"),
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Review(1934023593uL, "Hide TMPE crosswalks V2.5 [BETA]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141uL, Status.Compatible   }, // TM:PE LABS
                    { 1758376843uL, Status.Recommended  }, // Network Skins 2
                    { 1680642819uL, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252uL, Status.Recommended  }, // TM:PE STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Can use lots of RAM if you have lots of different roads that have crossings removed." },
                    { NOTE, "[Railway Replacer] and [Catenary Replacer] mods are suspected to be incompatible." },
                },
                Published = WorkshopDate("11 Dec, 2019"),
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            // replaces bus shelters, likely incompat with similar mods
            AddMod(new Review(1900151000uL, "替换为不锈钢公交候车亭 (shelter replacer)") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "ZEIR",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // anything that alters bus stops
                    { 1962752152uL, Status.Incompatible }, // Busstop Prop Remover
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("27 Oct, 2019"),
                SourceURL = "https://gist.github.com/OwiHH-NC/4cefbd1fbc7ff7135c59",
                Updated = WorkshopDate("27 Oct, 2019"),
            });

            AddMod(new Review(1758376843uL, "Network Skins 2") {
                Affect = Factor.Props // catenary, lights
                       | Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2065380745uL, Status.Compatible   }, // MetroReplacer
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1959183067uL, Status.MinorIssues  }, // CSUR Loader
                    { 1826488681uL, Status.Recommended  }, // Modern Lighting Pack: Liberated!
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1530376523uL, Status.Compatible   }, // Railway Replacer
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 877950833uL , Status.MinorIssues  }, // Vanilla Trees Remover
                    { 774449380uL , Status.Incompatible }, // Catenary Replacer
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850uL , Status.Incompatible }, // Network Skins (original)
                    { 417585852uL , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1959183067uL, "[Mod: CSUR Loader] Network Skins replaces the CSUR road colors." },
                    { 877950833uL, "[Mod: Vanilla Trees Remover] Disable it's road tree removal for best compatibility with Network Skins." },
                },
                Published = WorkshopDate("1 Jun, 2019"),
                SourceURL = "https://github.com/boformer/NetworkSkins2",
                Updated = WorkshopDate("25 Apr, 2020"),
            });

            AddMod(new Review(1530376523uL, "Railway Replacer") {
                Affect = Factor.Props, // need a networks factor too
                Authors = "Ronyx69, Simon Ryr, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1758376843uL, Status.Compatible   }, // Network Skins 2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 816260433uL , Status.MinorIssues  }, // Metro Overhaul Mod
                    { 774449380uL , Status.Incompatible }, // Catenary Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Shift + Alt + P to show the railway props settings window." },
                    { NOTE, "User guide and related assets: https://steamcommunity.com/sharedfiles/filedetails/?id=1569088356" },
                    { 816260433uL, "[Mod: Metro Overhaul Mod] The Railway Replacer UI might sometimes appear on MOM stations." },
                },
                Published = WorkshopDate("4 Oct, 2018"),
                Updated = WorkshopDate("29 Dec, 2019"),
            });

            AddMod(new Review(812125426uL, "Network Extensions 2") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Lazarus*Man, GCVos, BadPeanut, #Positivity!",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // road skin mods:
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1939169189uL, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1737575423uL, Status.Compatible   }, // [ Backward Compatibility ]  New Roads For Network Extension 2
                    { 1449429720uL, Status.Compatible   }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Compatible   }, // 道路颜色调整
                    { 1147015481uL, Status.Compatible   }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Compatible   }, // Remove Road Textures - Blank Roads
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 932192868uL , Status.Compatible   }, // Road Options (Road Colors Changer ++)
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer
                    { 413687519uL , Status.Incompatible }, // Some Roads
                    // street lights:
                    { 547126602uL , Status.Incompatible }, // Street Light Replacer
                    // traffic lights:
                    { 1812157090uL, Status.MinorIssues  }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.MinorIssues  }, // New American Traffic Lights
                    { 1259628682uL, Status.MinorIssues  }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095uL, Status.MinorIssues  }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552uL, Status.MinorIssues  }, // Horizontal Traffic Lights
                    { 890420060uL , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987uL , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    { 810355214uL , Status.Compatible   }, // Japanese Traffic Lights (RHT)　日本風信号機MOD (右側通行用)
                    { 809633246uL , Status.Compatible   }, // Japanese Traffic Lights (LHT)　日本風信号機MOD (左側通行用)
                    // level crossing lights:
                    { 1519049273uL, Status.MinorIssues  }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.MinorIssues  }, // Japanese Railway Crossings 日本風踏切MOD
                    // other props:
                    { 1900151000uL, Status.Incompatible }, // 替换为不锈钢公交候车亭
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 478820060uL, // Network Extensions Project
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                    { 1959342332uL, "[Mod: CSUR ToolBox] Breaks road zoning position and Zone Adjuster (Shift+Click)" },
                },
                Published = WorkshopDate("4 Dec, 2016"),
                SourceURL = "https://github.com/andreharv/NetworkExtensions",
                Updated = WorkshopDate("6 Apr, 2020"),
            });

            AddMod(new Review(427258853uL, "Crossings") {
                Affect = Factor.Pathfinder
                       | Factor.RoadMarkings,
                Authors = "Spectra",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141uL, Status.Unknown      }, // TM:PE LABS
                    { 1758376843uL, Status.Unknown      }, // Network Skins 2
                    { 1680642819uL, Status.Unknown      }, // Ultimate Level of Detail (ULOD)
                    { 1637663252uL, Status.Unknown      }, // TM:PE STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426uL , Status.MinorIssues  }, // Network Extensions 2 // sometimes glitches crossings due to conflicting code
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("14 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 812125426uL, "[Mod: Network Extensions] Sometimes causes double crossings to appear." },
                },
                Published = WorkshopDate("18 Apr, 2015"),
                ReplaceWith = 1934023593uL, // Hide TMPE crosswalks V2.5 [BETA]
                SourceURL = "https://github.com/bernardd/Crossings",
                Updated = WorkshopDate("8 Mar, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2044086131uL, "Network Extensions 2 - Sunset Harbour Build / Fix") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "DJSADERS",
                BrokenBy = GameVersion.Patch_1_13_0_f8,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other road skin mods:
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1737575423uL, Status.Compatible   }, // [ Backward Compatibility ]  New Roads For Network Extension 2
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 413687519uL , Status.Incompatible }, // Some Roads
                    // street light mods:
                    { 547126602uL , Status.Incompatible }, // Street Light Replacer
                    // traffic light mods struggle with NExt2 roads:
                    { 1812157090uL, Status.MinorIssues  }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.MinorIssues  }, // New American Traffic Lights
                    { 1259628682uL, Status.MinorIssues  }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095uL, Status.MinorIssues  }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552uL, Status.MinorIssues  }, // Horizontal Traffic Lights
                    { 890420060uL , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987uL , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    { 810355214uL , Status.Compatible   }, // Japanese Traffic Lights (RHT)　日本風信号機MOD (右側通行用)
                    { 809633246uL , Status.Compatible   }, // Japanese Traffic Lights (LHT)　日本風信号機MOD (左側通行用)
                    // level crossing lights mods struggle with NExt2 roads:
                    { 1519049273uL, Status.MinorIssues  }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.MinorIssues  }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 812125426uL, // Network Extensions 2
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // removed 6th April 2020 due to original mod being fixed
                      | ItemFlags.Obsolete
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 Apr, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "OBSOLETE: The original mod has been fixed, so you can unsubscribe this temporary bug fix version and use the replacement." },
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                Removed = WorkshopDate("6 Apr, 2020"),
                ReplaceWith = 812125426uL, // Network Extensions 2
                SourceURL = "https://github.com/andreharv/NetworkExtensions",
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            // technically a repair mod, but it actually includes replacement networks hence put in this catalog
            AddMod(new Review(1737575423uL, "[ Backward Compatibility ]  New Roads For Network Extension 2") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "(gibberish name)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044086131uL, Status.Compatible   }, // Network Extensions 2 - Sunset Harbour Build / Fix
                    { 1243740191uL, Status.Recommended  }, // Road Removal Tool
                    { 950807008uL , Status.Compatible   }, // Network Extensions 2 Fix
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 59 MB
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Read the mod's Steam Workshop page description for important usage instructions." },
                },
                Published = WorkshopDate("10 May, 2019"),
                RequiredDLC = DLCs.AfterDark,
                Updated = WorkshopDate("10 May, 2019"),
            });

            AddMod(new Review(1128766708uL, "Remove Road Textures - Blank Roads") {
                Authors = "Madgemade",
                Affect = Factor.RoadMarkings,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Sep, 2017"),
                Updated = WorkshopDate("6 Sep, 2017"),
            });

            // translated clone of (assuming) 932192868u
            AddMod(new Review(1449429720uL, "Road Color 道路颜色修改中文汉化版") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TIMIYANG",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 932192868uL, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("24 Jul, 2018"),
                ReplaceWith = 1758376843uL, // Network Skins 2
                Updated = WorkshopDate("24 Jul, 2018"),
            });

            // Road Options (Road Colors Changer ++)
            AddMod(new Review(1189186167uL, "道路颜色调整 (road color changer)") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "hlwb7788",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 932192868uL, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 1758376843uL, // Network Skins 2
            });

            // obsoleted by kian's mods
            AddMod(new Review(1147015481uL, "No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets") {
                Affect = Factor.RoadMarkings,
                Authors = "Madgemade",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300uL, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    //{ 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceObfuscated // alert!!
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1934023593uL, // Hide TMPE crosswalks V2.5 [BETA]
            });

            AddMod(new Review(950807008uL, "Network Extensions 2 Fix") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "(unknown)",
                BrokenBy = GameVersion.Concerts,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other road skin mods:
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1737575423uL, Status.Compatible   }, // [ Backward Compatibility ] New Roads For Network Extension 2
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 413687519uL , Status.Incompatible }, // Some Roads
                },
                CompatibleWith = GameVersion.Patch_1_7_2_f1,
                ContinuationOf = 812125426uL, // Network Extensions 2
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // removed 6th April 2020 due to original mod being fixed
                      | ItemFlags.Obsolete
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("30 Jun, 2017"), // when NExt2 was fixed
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "OBSOLETE: The original mod has been fixed, so you can unsubscribe this temporary bug fix version and use the replacement." },
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                },
                Published = WorkshopDate("19 Jun, 2017"), // based on adjacent item
                Removed = WorkshopDate("30 Jun, 2017"), // guessing; when NExt2 was fixed
                ReplaceWith = 812125426uL, // Network Extensions 2
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("19 Jun, 2017"), // guessing
            });

            // Additional dev work on 651610627u
            // Currently most reliable version but superseded by NS2
            AddMod(new Review(932192868uL, "Road Options (Road Colors Changer ++)") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1565201461uL, Status.MinorIssues  }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Compatible   }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 651610627uL, // [DISCONTINUED] Road Color Changer Continued
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1758376843uL, // Network Skins 2
            });

            AddMod(new Review(929114228uL, "New Roads For Network Extension 2") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "blaremc",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1737575423uL, Status.Incompatible }, // [ Backward Compatibility ]  New Roads For Network Extension 2
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 413687519uL , Status.Incompatible }, // Some Roads
                },
                CompatibleWith = GameVersion.Patch_1_10_1_f3,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning // 58 MB
                      | ItemFlags.Obsolete // roads are moved in to NExt2
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                },
                Published = WorkshopDate("20 May, 2017"),
                ReplaceWith = 1737575423uL, // [ Backward Compatibility ]  New Roads For Network Extension 2
                RequiredDLC = DLCs.AfterDark,
                Updated = WorkshopDate("6 Jul, 2017"),
            });

            AddMod(new Review(774449380uL, "Catenary Replacer") {
                Affect = Factor.Props
                      | Factor.HideRemove,
                Authors = "Tim The Terrible, boformer, BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2065380745uL, Status.Incompatible }, // MetroReplacer
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1530376523uL, Status.Incompatible }, // Railway Replacer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Users report wires no longer removed when catenaries are removed, particularly over 1-way tracks." },
                },
                Published = WorkshopDate("3 Oct, 2016"),
                ReplaceWith = 1758376843uL, // Network Skins 2
                SourceURL = "https://github.com/TimTheTerribleCS/Catenary-Replacer",
                Updated = WorkshopDate("4 Dec, 2017"),
            });

            // Additional dev work on the original mod
            AddMod(new Review(651610627uL, "[DISCONTINUED] Road Color Changer Continued") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "vukica", // formerly cylon33
                BrokenBy = GameVersion.MassTransit, // based on user comments (and also when TPB started working on his continuation)
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Compatible   }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                ContinuationOf = 417585852uL, // Road Color Changer
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // yellow bar in workshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("24 Mar, 2016"),
                ReplaceWith = 1758376843uL, // Network Skins 2
                SourceURL = "https://github.com/vukivan/RoadColorChanger",
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddMod(new Review(543722850uL, "Network Skins (Park Life compatible)") {
                Affect = Factor.Props // catenary, lights
                       | Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer, BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Unknown      }, // [Beta] PRT-2
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1826488681uL, Status.Incompatible }, // Modern Lighting Pack: Liberated!
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1575247594uL, Status.MinorIssues  }, // 576327847 81 Tiles (Fixed for 1
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1560122066uL, Status.MinorIssues  }, // 81MOD
                    { 1312735149uL, Status.Incompatible }, // Klyte Commons
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803uL, Status.Unknown      }, // Parallel Road Tool
                    { 1400711138uL, Status.Unknown      }, // [BETA] Parallel Road Tool
                    { 1361478243uL, Status.MinorIssues  }, // 81 Tiles
                    { 1223738434uL, Status.MinorIssues  }, // 422554572
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 877950833uL , Status.MinorIssues  }, // Vanilla Trees Remover
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 616078328uL , Status.MinorIssues  }, // All Tile Start
                    { 576327847uL , Status.MinorIssues  }, // 81 Tiles (Fixed for 1.2+)
                    { 543722850uL , Status.Incompatible }, // Network Skins (original)
                    { 422554572uL , Status.MinorIssues  }, // 81 Tiles Updated
                    { 417585852uL , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 877950833uL, "[Mod: Vanilla Trees Remover] Disable it's road tree removal for best compatibility with Network Skins." },
                    { 576327847uL, "[Mod: 81 Tiles] Network Skins settings may occasionally reset outside central 25 tile area." },
                },
                ReleasedDuring = GameVersion.AfterDark,
                ReplaceWith = 1758376843uL, // Network Skins 2
                SourceURL = "https://github.com/boformer/NetworkSkins",
            });

            AddMod(new Review(478820060uL, "Network Extensions Project") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Katalyst6, GCVos, Lazarus*Man, #Positivity!, samchar00",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other road skin mods:
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1737575423uL, Status.Incompatible }, // [ Backward Compatibility ]  New Roads For Network Extension 2
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Compatible   }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Compatible   }, // Road Color Changer
                    { 413687519uL , Status.Compatible   }, // Some Roads
                    // other (compat):
                    //-Road Color Changer Continued
                    //-Traffic++ V2
                    //-NoPillars
                    //-Traffic Report Tool
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning // 84 MB
                      | ItemFlags.Obsolete // replacement avail
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                },
                Published = WorkshopDate("10 Jul, 2015"),
                ReplaceWith = 812125426uL, // Network Extensions 2
                SourceURL = "https://github.com/Katalyst6/CSL.TransitAddonMod",
                Updated = WorkshopDate("30 Nov, 2016"),
            });

            // could remove optional lane arrows (left/right)
            // change pavement texture
            AddMod(new Review(418637762uL, "American Roads") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20160806030718/https://steamcommunity.com/sharedfiles/filedetails/?id=418637762",
                Authors = "hyperdrive_engage, che_bacca",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other mods that can hide road props:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1117087491uL, Status.Incompatible }, // Remove Road Props
                    { 690066392uL , Status.Incompatible }, // American RoadSigns v2.2.0
                    { 418637762uL , Status.Incompatible }, // American Roads
                    // traffic light - level crossings:
                    { 1519049273uL, Status.MinorIssues  }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.MinorIssues  }, // Japanese Railway Crossings 日本風踏切MOD
                    // other
                    { 417585852uL , Status.Compatible   }, // Road Color Changer (original)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // use American RoadSigns v2.2.0
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It!] Both mods can remove road markings/props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("15 Apr, 2015"),
                ReplaceWith = 690066392uL, // American RoadSigns v2.2.0
                Updated = WorkshopDate("18 Feb, 2016"),
            });

            // original mod
            AddMod(new Review(417585852uL, "Road Color Changer") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20161130171223/http://steamcommunity.com/sharedfiles/filedetails/?id=417585852",
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067uL, Status.Incompatible }, // CSUR Loader
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2
                    { 1565201461uL, Status.Incompatible }, // Roads United: US Reworked 2018
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1147015481uL, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Compatible   }, // Network Extensions Project
                    { 418637762uL , Status.Compatible   }, // American Roads
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // new ver available
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("13 Apr, 2015"),
                ReplaceWith = 1758376843uL, // Network Skins 2
                Updated = WorkshopDate("18 Feb, 2016"), // may be subsequent updates, but that's as much as I could find via web archive
            });

            AddMod(new Review(413687519uL, "Some Road") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20160620100330/http://steamcommunity.com/sharedfiles/filedetails/?id=413687519",
                Authors = "some danny",
                BrokenBy = GameVersion.NaturalDisasters, // guessing
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044086131uL, Status.Incompatible }, // Network Extensions 2 Sunset Harbor temp fix
                    { 950807008uL , Status.Incompatible }, // Network Extensions 2 Fix
                    { 929114228uL , Status.Incompatible }, // New Roads For Network Extension 2
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 478820060uL , Status.Compatible   }, // Network Extensions Project
                    { 413687519uL , Status.Incompatible }, // Some Roads
                },
                CompatibleWith = GameVersion.Patch_1_4_1_f2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("20 Jun, 2016"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have broken saves after removing this mod, see: https://github.com/CitiesSkylinesMods/TMPE/wiki/How-to-remove-workshop-networks" },
                },
                Published = WorkshopDate("25 Mar, 2015"),
                Removed = WorkshopDate("01 Jul, 2018"),
                SourceURL = "https://gist.github.com/thatfool/0545ff2641ef46c2cf52",
                Updated = WorkshopDate("25 Mar, 2015"),
            });

            // - Build elevated railroad, roads, and pedestrian paths without pillars
            // - Build elevated roads that use the railroad pillars instead of the clunky concrete ones
            // - Disable collision detection while building roads
            // - Build railroad tracks in the asset editor
            AddMod(new Review(409073164uL, "NoPillars") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                ArchiveURL = "https://web.archive.org/web/20170104001601/http://steamcommunity.com/sharedfiles/filedetails/?id=409073164",
                Authors = "some danny",
                BrokenBy = GameVersion.EuropeBiome,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 463845891uL , Status.Incompatible }, // No Pillars (BP ver)
                    { 409073164uL , Status.Incompatible }, // NoPillars
                },
                CompatibleWith = GameVersion.Patch_1_0_7c,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // new mod avail
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 Jan, 2017"),
                Published = WorkshopDate("16 Mar, 2015"),
                Removed = WorkshopDate("14 Mar, 2017"),
                ReplaceWith = 463845891uL, // No Pillars (BP ver)
                SourceURL = "https://gist.github.com/thatfool/8b8f90baaa5f62ed6b9d",
                Updated = WorkshopDate("18 Mar, 2015"),
            });
        }
    }
}