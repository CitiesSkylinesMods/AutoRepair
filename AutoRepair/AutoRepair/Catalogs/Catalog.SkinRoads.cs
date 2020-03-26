namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that alter the way roads look.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void SkinRoadsCatalog() {

            string catalog = "Skin.Roads";

            // Requires TM:PE
            AddMod(new Item(2019097300u, "Hide TM:PE Unconnected Tracks") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings, // not really, but close enough
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
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
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/kianzarrin/HideUnconnectedTracks",
                Tags = new[] { "TMPE", "TM:PE", "Tram", "Train", "Network", "Skins", "Junctions", "Tracks" },
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
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1934023593u, // Hide TMPE crosswalks V2.5 [BETA]
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
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
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850u , Status.Incompatible }, // Network Skins (original)
                    { 417585852u , Status.Incompatible }, // Road Color Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/boformer/NetworkSkins",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1962752152u, "Busstop Prop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "PC28K",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160u, Status.Incompatible }, // Hide It (has same feature)
                    { 919020932u , Status.Incompatible }, // Stop Remover
                    { 545878277u , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs // requires game restart after changing its settings
                      | ItemFlags.SourceUnavailable,
                Notes = new[] {
                    "Requires game restart after changing settings.",
                    "[Mod: Hide It!] The hide it mod contains a stop remover feature that can be toggled in-game.",
                },
                ReleasedDuring = GameVersion.Campus,
                ReplaceWith = 1591417160u, // Hide It
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
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
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
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
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
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060u , Status.Incompatible }, // Network Extensions Project
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                ContinuationOf = 651610627u, // [DISCONTINUED] Road Color Changer Continued
                Flags = ItemFlags.Obsolete // network skins and other prop/decal remover mods
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
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
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
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
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