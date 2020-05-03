namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that alter the content manager or options screen.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void ContentManagerMods() {

            string catalog = "ContentManager";

            // weird mod collection manager
            AddMod(new Review(1842879635uL, "SwitchMAD_light") {
                Affect = Factor.UI,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1838385855uL, // SwitchMAD
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // weird mod collection manager
            AddMod(new Review(1838385855uL, "SwitchMAD") {
                Affect = Factor.UI,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: check if source still obfu
            AddMod(new Review(1773106708uL, "More Advanced OptionsPanel") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Options", "UI", "Settings", },
            });

            // todo: check if source still obfu
            AddMod(new Review(1762394554uL, "Wider Options Panel") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Options", "UI", "Settings", },
            });

            // todo: check compat with other mod panel mods
            AddMod(new Review(973512634uL, "Sort Mod Settings") {
                Affect = Factor.UI,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-SortModSettings",
                Tags = new[] { "Options", "UI", "Settings", },
            });

            AddMod(new Review(903285221uL, "Auto-Enable Mods") {
                Affect = Factor.Other,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you install a broken mod, this mod will still try and auto-enable it. So beware!" },
                },
                Published = WorkshopDate("11 Apr, 2017"),
                Updated = WorkshopDate("18 Nov, 2018"),
            });

            AddMod(new Review(814498849uL, "Improved Content Manager") {
                Affect = Factor.UI,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 632951976uL , Status.Compatible   }, // Improved Mod Upload Panel
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("8 Dec, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedContentManager",
                Updated = WorkshopDate("24 May, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // decommissioned on Nov 30, 2016 https://github.com/bloodypenguin/Skylines-ImprovedAssetsPanel/commit/cbeda90fdb38774af3e7b0fc48ab8ebf95166860
            AddMod(new Review(449020940uL, "Improved Assets Panel Fixed for v1.1") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20160623145240/http://steamcommunity.com/sharedfiles/filedetails/?id=449020940",
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 632951976uL , Status.Compatible   }, // Improved Mod Upload Panel
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Compatible   }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.EuropeBiome,
                ContinuationOf = 417430545uL, // Improved Assets Panel
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("30 Nov, 2016"),
                Published = WorkshopDate("25 May, 2015"),
                Removed = WorkshopDate("8 Dec, 2016"),
                ReplaceWith = 814498849uL, // Improved Content Manager
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedAssetsPanel",
                Updated = WorkshopDate("30 Nov, 2016"),
            });

            // decommissoned on Nov 30, 2016 https://github.com/bloodypenguin/Skylines-ImprovedModsPanel/commit/8d4ad458a04976e013bbc5eb0f9f284d0a889b18
            AddMod(new Review(448687553uL, "Improved Mods Panel Fixed for v1.1") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20160623154016/http://steamcommunity.com/sharedfiles/filedetails/?id=448687553",
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 632951976uL , Status.Compatible   }, // Improved Mod Upload Panel
                    { 449020940uL , Status.Compatible   }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.EuropeBiome,
                ContinuationOf = 416033610uL, // Improved Mods Panel
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("30 Nov, 2016"),
                Published = WorkshopDate("24 May, 2015"),
                Removed = WorkshopDate("8 Dec, 2016"),
                ReplaceWith = 814498849uL, // Improved Content Manager
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedModsPanel",
                Updated = WorkshopDate("30 Nov, 2016"), // based on last commit
            });

            AddMod(new Review(417430545uL, "Improved Assets Panel") {
                Affect = Factor.UI,
                Authors = "nlight",
                BrokenBy = GameVersion.EuropeBiome,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Incompatible }, // Improved Assets Panel
                    { 416033610uL , Status.Compatible   }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.Patch_1_0_7c,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("1 Apr, 2015"),
                ReplaceWith = 814498849uL, // Improved Content Manager
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-ImprovedAssetsPanel",
                Updated = WorkshopDate("7 Apr, 2015"),
            });

            AddMod(new Review(416033610uL, "Improved Mods Panel") {
                Affect = Factor.UI,
                Authors = "nlight",
                BrokenBy = GameVersion.EuropeBiome,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635uL, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855uL, Status.Incompatible }, // SwitchMAD
                    { 1773106708uL, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554uL, Status.Incompatible }, // Wider Options Panel
                    { 973512634uL , Status.Incompatible }, // Sort Mod Settings
                    { 903285221uL , Status.Incompatible }, // Auto-Enable Mods
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 449020940uL , Status.Incompatible }, // Improved Assets Panel Fixed for v1.1
                    { 448687553uL , Status.Incompatible }, // Improved Mods Panel Fixed for v1.1
                    { 417430545uL , Status.Compatible   }, // Improved Assets Panel
                    { 416033610uL , Status.Incompatible }, // Improved Mods Panel
                },
                CompatibleWith = GameVersion.Patch_1_0_7c,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("29 Mar, 2015"),
                ReplaceWith = 814498849uL, // Improved Content Manager
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-ImprovedModsPanel",
                Updated = WorkshopDate("7 Apr, 2015"),
            });
        }
    }
}