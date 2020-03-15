namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that replace road textures or colors.
    ///
    /// Any texutre packs should go in the <c>Skins.Packs.cs</c> file.
    /// </summary>
    public partial class Skins {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void AddRoadsToList() {

            string catalog = "Skins.Roads";

            AddMod(new Item(1758376843u, "Network Skins 2 (Beta)") {
                Authors = "boformer, TPB",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.NetworkSkins
                              | ConflictGroups.RoadColorChanger,
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 543722850u }, // Network Skins (original)
                    { 1440928803u }, // Parallel Road Tool
                    { 1400711138u }, // [BETA] Parallel Road Tool
                },
                SourceCodeURL = "https://github.com/boformer/NetworkSkins",
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
                Authors = "TIMIYANG",
                Catalog = catalog,
                CompatibleWith = new List<ulong>() {
                    { 812125426u }, // Network Extensions 2
                },
                ConflictsWith = ConflictGroups.NetworkExtensions
                              | ConflictGroups.NetworkSkins
                              | ConflictGroups.RoadColorChanger
                              | ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone
                      //| ItemFlags.GameBreaking ??
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
                IncompatibleMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1449429720u }, // Road Color 道路颜色修改中文汉化版
                    { 932192868u }, // Road Options (Road Colors Changer ++)
                    { 651610627u }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060u }, // Network Extensions Project
                    { 417585852u }, // Road Color Changer (original mod)
                },
                Locale = "zh-cn",
                ReplaceWith = 1758376843u, // Network Skins 2 (Beta)
            });

            // Additional dev work on 651610627u
            // Currently most reliable version but superceded by NS2
            AddMod(new Item(932192868u, "Road Options (Road Colors Changer ++)") {
                Authors = "TPB",
                Catalog = catalog,
                CompatibleWith = new List<ulong>() {
                    { 812125426u }, // Network Extensions 2
                },
                ConflictsWith = ConflictGroups.NetworkExtensions
                              | ConflictGroups.NetworkSkins
                              | ConflictGroups.RoadColorChanger
                              | ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning,
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1449429720u }, // Road Color 道路颜色修改中文汉化版
                    { 932192868u }, // Road Options (Road Colors Changer ++)
                    { 651610627u }, // [DISCONTINUED] Road Color Changer Continued
                    { 478820060u }, // Network Extensions Project
                    { 417585852u }, // Road Color Changer (original mod)
                },
                ReplaceWith = 1758376843u, // Network Skins 2 (Beta)
            });

            // Additional dev work on the original mod
            AddMod(new Item(651610627u, "[DISCONTINUED] Road Color Changer Continued") {
                Authors = "vukica",
                Catalog = catalog,
                CompatibleWith = new List<ulong>() {
                    { 478820060u }, // Network Extensions Project
                },
                ConflictsWith = ConflictGroups.NetworkExtensions
                              | ConflictGroups.NetworkSkins
                              | ConflictGroups.RoadColorChanger
                              | ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // yellow bar in workshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1449429720u }, // Road Color 道路颜色修改中文汉化版
                    { 932192868u }, // Road Options (Road Colors Changer ++)
                    { 812125426u }, // Network Extensions 2
                    { 651610627u }, // [DISCONTINUED] Road Color Changer Continued
                    { 417585852u }, // Road Color Changer (original mod)
                },
                ReplaceWith = 932192868u, // Road Options (Road Colors Changer ++)
            });

            // original mod
            AddMod(new Item(417585852u, "Road Color Changer") {
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                CompatibleWith = new List<ulong>() {
                    { 478820060u }, // Network Extensions Project
                },
                ConflictsWith = ConflictGroups.NetworkExtensions
                              | ConflictGroups.NetworkSkins
                              | ConflictGroups.RoadColorChanger
                              | ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // older than 651610627u
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1449429720u }, // Road Color 道路颜色修改中文汉化版
                    { 932192868u }, // Road Options (Road Colors Changer ++)
                    { 812125426u }, // Network Extensions 2
                    { 651610627u }, // [DISCONTINUED] Road Color Changer Continued
                    { 417585852u }, // Road Color Changer (original mod)
                },
                ReplaceWith = 932192868u, // Road Options (Road Colors Changer ++)
            });

        }
    }
}
