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
            AddMod(new Review(1842879635u, "SwitchMAD_light") {
                Affect = Factor.Other,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                    { 1773106708u, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554u, Status.Incompatible }, // Wider Options Panel
                    { 973512634u , Status.Incompatible }, // Sort Mod Settings
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // weird mod collection manager
            AddMod(new Review(1838385855u, "SwitchMAD") {
                Affect = Factor.Other,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                    { 1773106708u, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554u, Status.Incompatible }, // Wider Options Panel
                    { 973512634u , Status.Incompatible }, // Sort Mod Settings
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: check if source still obfu
            AddMod(new Review(1773106708u, "More Advanced OptionsPanel") {
                Affect = Factor.Other,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                    { 1773106708u, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554u, Status.Incompatible }, // Wider Options Panel
                    { 973512634u , Status.Incompatible }, // Sort Mod Settings
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Options", "UI", "Settings", },
            });

            // todo: check if source still obfu
            AddMod(new Review(1762394554u, "Wider Options Panel") {
                Affect = Factor.Other,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                    { 1773106708u, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554u, Status.Incompatible }, // Wider Options Panel
                    { 973512634u , Status.Incompatible }, // Sort Mod Settings
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Tags = new[] { "Options", "UI", "Settings", },
            });

            // todo: check compat with other mod panel mods
            AddMod(new Review(973512634u, "Sort Mod Settings") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                    { 1773106708u, Status.Incompatible }, // More Advanced OptionsPanel
                    { 1762394554u, Status.Incompatible }, // Wider Options Panel
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 973512634u , Status.Incompatible }, // Sort Mod Settings
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-SortModSettings",
                Tags = new[] { "Options", "UI", "Settings", },
            });
        }
    }
}