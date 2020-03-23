namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that replace road textures or colors.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        private void NetworksCatalog() {

            string catalog = "Networks";

            AddMod(new Item(1758376843u, "Network Skins 2 (Beta)") {
                Affect = Factor.Props // catenary, lights
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "boformer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: incompat with roads color changer
                    { 1826488681u, Status.Recommended  }, // Modern Lighting Pack: Liberated!
                    { 1440928803u, Status.Incompatible }, // Parallel Road Tool
                    { 1400711138u, Status.Incompatible }, // [BETA] Parallel Road Tool
                    { 543722850u , Status.Incompatible }, // Network Skins (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/boformer/NetworkSkins",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // translated clone of (assuming) 932192868u
            AddMod(new Item(1449429720u, "Road Color 道路颜色修改中文汉化版") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 932192868u, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
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
                ReplaceWith = 1758376843u, // Network Skins 2 (Beta)
            });

            // Road Options (Road Colors Changer ++)
            AddMod(new Item(1189186167u, "道路颜色调整") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "hlwb7788",
                Catalog = catalog,
                CloneOf = 932192868u, // Road Options (Road Colors Changer ++)
                Compatibility = new Dictionary<ulong, Status>() {
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
                ReplaceWith = 1758376843u, // Network Skins 2 (Beta)
            });

            // Additional dev work on 651610627u
            // Currently most reliable version but superseded by NS2
            AddMod(new Item(932192868u, "Road Options (Road Colors Changer ++)") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
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
                ReplaceWith = 1758376843u, // Network Skins 2 (Beta)
            });

            // Additional dev work on the original mod
            AddMod(new Item(651610627u, "[DISCONTINUED] Road Color Changer Continued") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "vukica",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
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
                ReplaceWith = 932192868u, // Road Options (Road Colors Changer ++)
            });

            // original mod
            AddMod(new Item(417585852u, "Road Color Changer") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
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
                      | ItemFlags.GameBreaking // older than 651610627u which is also game breaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 932192868u, // Road Options (Road Colors Changer ++)
            });

        }
    }
}
