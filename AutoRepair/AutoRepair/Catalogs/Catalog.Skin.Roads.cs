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
        private void SkinRoadsCatalog() {

            string catalog = "Skin.Roads";

            AddMod(new Item(2045625827u, "Cgameworld’s Railway/BVU Track Customizations") {
                Affect = Factor.Rendering // meh
                       | Factor.Textures,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1779369015u, Status.Required     }, // Railway Shinkansen Gravel Wireless
                    { 1847646595u, Status.Recommended  }, // Bienvenüe - Munich U-Bahn Tracks
                },
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Apr, 2020"),
                SourceURL = "https://github.com/Cgameworld/CGWRailwayCustomizations",
                Updated = WorkshopDate("3 Apr, 2020"),
            });

            AddMod(new Item(2044086131u, "Network Extensions 2 - Sunset Harbour Build / Fix") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "DJSADERS",
                BrokenBy = GameVersion.Patch_1_13_0_f8,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other road skin mods:
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    // street light mods:
                    { 547126602u , Status.Incompatible }, // Street Light Replacer
                    // traffic light mods struggle with NExt2 roads:
                    { 1812157090u, Status.MinorIssues  }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.MinorIssues  }, // New American Traffic Lights
                    { 1259628682u, Status.MinorIssues  }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.MinorIssues  }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.MinorIssues  }, // Horizontal Traffic Lights
                    // level crossing lights mods struggle with NExt2 roads:
                    { 1519049273u, Status.MinorIssues  }, // American Railroad Signal Replacer
                    { 1249000709u, Status.MinorIssues  }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 812125426u, // Network Extensions 2
                Flags = ItemFlags.NoWorkshop // removed 6th April 2020 due to original mod being fixed
                      | ItemFlags.Obsolete
                      | ItemFlags.SaveChanging
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "OBSOLETE: The original mod has been fixed, so you can unsubscribe this temporary bug fix version." },
                    // { NOTE, "More info: https://github.com/andreharv/NetworkExtensions/issues/18" },
                    { 1959342332u, "[Mod: CSUR ToolBox] Breaks road zoning position and Zone Adjuster (Shift+Click)" },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                ReleasedDuring = GameVersion.SunsetHarbor,
                ReplaceWith = 812125426u, // Network Extensions 2
                SourceURL = "https://github.com/andreharv/NetworkExtensions",
                SuppressOlderReplacementWarning = true,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            // Requires TM:PE
            AddMod(new Item(2019097300u, "Hide TM:PE Unconnected Tracks") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings, // not really, but close enough
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141u, Status.Required     }, // TM:PE LABS
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252u, Status.Compatible   }, // TM:PE STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481u, Status.Compatible   }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Compatible   }, // Remove Road Textures - Blank Roads
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/kianzarrin/HideUnconnectedTracks",
                Tags = new[] { "TMPE", "TM:PE", "Tram", "Train", "Network", "Skins", "Junctions", "Tracks" },
            });

            AddMod(new Item(2009708489u, "Road Arrows Replacer [Spain]") {
                Affect = Factor.RoadMarkings,
                Authors = "Nouvilas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // hide it - if used to hide street arrows, road arrows replacer won't work
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    // incompat - anything that chances road arrows or markings etc
                    { 2008960441u, Status.Required     }, // Spanish Arrow Decals Pack
                    { 956707300u , Status.Incompatible }, // Remove Street Arrows
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160u, "[Mod: Hide It!] If you remove road arrows with Hide It, the Road Arrows Replacer can't replace them." },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1939169189u, "Hide Crosswalks V3.0 [EXPERIMENTAL]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141u, Status.Recommended  }, // TM:PE LABS
                    { 1758376843u, Status.Recommended  }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252u, Status.Compatible   }, // TM:PE STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1934023593u, // Hide TMPE crosswalks V2.5 [BETA]
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1934023593u, "Hide TMPE crosswalks V2.5 [BETA]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141u, Status.Compatible   }, // TM:PE LABS
                    { 1758376843u, Status.Recommended  }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1637663252u, Status.Recommended  }, // TM:PE STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
            });

            AddMod(new Item(1758376843u, "Network Skins 2") {
                Affect = Factor.Props // catenary, lights
                       | Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: incompat with roads color changer
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1959183067u, Status.MinorIssues  }, // CSUR Loader
                    { 1826488681u, Status.Recommended  }, // Modern Lighting Pack: Liberated!
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850u , Status.Incompatible }, // Network Skins (original)
                    { 417585852u , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1959183067u, "[Mod: CSUR Loader] Network Skins replaces the CSUR road colors." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/boformer/NetworkSkins2",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1128766708u, "Remove Road Textures - Blank Roads") {
                Authors = "Madgemade",
                Affect = Factor.RoadMarkings,
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
            });

            // translated clone of (assuming) 932192868u
            AddMod(new Item(1449429720u, "Road Color 道路颜色修改中文汉化版") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TIMIYANG",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 932192868u, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 1758376843u, // Network Skins 2
            });

            // Road Options (Road Colors Changer ++)
            AddMod(new Item(1189186167u, "道路颜色调整") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "hlwb7788",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 932192868u, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 1758376843u, // Network Skins 2
            });

            // obsoleted by kian's mods
            AddMod(new Item(1147015481u, "No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets") {
                Affect = Factor.RoadMarkings,
                Authors = "Madgemade",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    //{ 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceObfuscated // alert!!
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1934023593u, // Hide TMPE crosswalks V2.5 [BETA]
            });

            // Additional dev work on 651610627u
            // Currently most reliable version but superseded by NS2
            AddMod(new Item(932192868u, "Road Options (Road Colors Changer ++)") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TPB",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                ContinuationOf = 651610627u, // [DISCONTINUED] Road Color Changer Continued
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1758376843u, // Network Skins 2
            });

            // Additional dev work on the original mod
            AddMod(new Item(651610627u, "[DISCONTINUED] Road Color Changer Continued") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "vukica",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Compatible   }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                ContinuationOf = 417585852u, // Road Color Changer
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // yellow bar in workshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1758376843u, // Network Skins 2
            });

            AddMod(new Item(543722850u, "Network Skins (Park Life compatible)") {
                Affect = Factor.Props // catenary, lights
                       | Factor.Rendering
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer, BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1826488681u, Status.Incompatible }, // Modern Lighting Pack: Liberated!
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1575247594u, Status.MinorIssues  }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066u, Status.MinorIssues  }, // 81MOD
                    { 1312735149u, Status.Incompatible }, // Klyte Commons
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803u, Status.Unknown      }, // Parallel Road Tool
                    { 1400711138u, Status.Unknown      }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1361478243u, Status.MinorIssues  }, // 81 Tiles
                    { 1223738434u, Status.MinorIssues  }, // 422554572
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 616078328u , Status.MinorIssues  }, // All Tile Start
                    { 576327847u , Status.MinorIssues  }, // 81 Tiles (Fixed for 1.2+)
                    { 543722850u , Status.Incompatible }, // Network Skins (original)
                    { 422554572u , Status.MinorIssues  }, // 81 Tiles Updated
                    { 417585852u , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.MinorBugs
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 576327847u, "[Mod: 81 Tiles] Network Skins settings may occasionally reset outside central 25 tile area." },
                },
                ReleasedDuring = GameVersion.AfterDark,
                ReplaceWith = 1758376843u, // Network Skins 2
                SourceURL = "https://github.com/boformer/NetworkSkins",
            });

            // original mod
            AddMod(new Item(417585852u, "Road Color Changer") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Incompatible }, // CSUR Loader
                    { 1758376843u, Status.Incompatible }, // Network Skins 2
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060u , Status.Compatible   }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1758376843u, // Network Skins 2
            });
        }
    }
}