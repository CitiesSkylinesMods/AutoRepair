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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Compatible assets: https://steamcommunity.com/workshop/filedetails/?id=2065610088" },
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=1843406895" },
                },
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
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Apr, 2020"),
                SourceURL = "https://github.com/Cgameworld/CGWRailwayCustomizations",
                Updated = WorkshopDate("3 Apr, 2020"),
            });

            AddMod(new Review(2044086131uL, "Network Extensions 2 - Sunset Harbour Build / Fix") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "DJSADERS",
                BrokenBy = GameVersion.Patch_1_13_0_f8,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other road skin mods:
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
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
                    // level crossing lights mods struggle with NExt2 roads:
                    { 1519049273uL, Status.MinorIssues  }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.MinorIssues  }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 812125426uL, // Network Extensions 2
                Flags = ItemFlags.NoWorkshop // removed 6th April 2020 due to original mod being fixed
                      | ItemFlags.Obsolete
                      | ItemFlags.SaveAltering
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "OBSOLETE: The original mod has been fixed, so you can unsubscribe this temporary bug fix version." },
                    // { NOTE, "More info: https://github.com/andreharv/NetworkExtensions/issues/18" },
                    { 1959342332uL, "[Mod: CSUR ToolBox] Breaks road zoning position and Zone Adjuster (Shift+Click)" },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                ReplaceWith = 812125426uL, // Network Extensions 2
                SourceURL = "https://github.com/andreharv/NetworkExtensions",
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
                Updated = WorkshopDate("1 Apr, 2020"),
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
                    // hide it - if used to hide street arrows, road arrows replacer won't work
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    // incompat - anything that chances road arrows or markings etc
                    { 2008960441uL, Status.Required     }, // Spanish Arrow Decals Pack
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Can use lots of RAM if you have lots of different roads that have crossings removed." },
                    { NOTE, "[Railway Replacer] and [Catenary Replacer] mods are suspected to be incompatible." },
                },
                Published = WorkshopDate("11 Dec, 2019"),
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
                Updated = WorkshopDate("11 Apr, 2020"),
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
                Notes = new Dictionary<ulong, string>() {
                    { 1959183067uL, "[Mod: CSUR Loader] Network Skins replaces the CSUR road colors." },
                    { 877950833uL, "[Mod: Vanilla Trees Remover] Disable it's road tree removal for best compatibility with Network Skins." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/boformer/NetworkSkins2",
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
                    { 816260433uL , Status.Incompatible }, // Metro Overhaul Mod
                    { 774449380uL , Status.Incompatible }, // Catenary Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Shift + Alt + P to show the railway props settings window." },
                    { NOTE, "User guide and related assets: https://steamcommunity.com/sharedfiles/filedetails/?id=1569088356" },
                    { 816260433uL, "[Mod: Metro Overhaul Mod] Incompatible with Railway Replacer as they both udpate Railway Tracks." },
                },
                Published = WorkshopDate("4 Oct, 2018"),
                Updated = WorkshopDate("29 Dec, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1128766708uL, "Remove Road Textures - Blank Roads") {
                Authors = "Madgemade",
                Affect = Factor.RoadMarkings,
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
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
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 1758376843uL, // Network Skins 2
            });

            // Road Options (Road Colors Changer ++)
            AddMod(new Review(1189186167uL, "道路颜色调整") {
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
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Users report wires no longer removed when catenaries are removed." },
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
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("13 Apr, 2015"),
                ReplaceWith = 1758376843uL, // Network Skins 2
                Updated = WorkshopDate("18 Feb, 2016"), // may be subsequent updates, but that's as much as I could find via web archive
            });
        }
    }
}