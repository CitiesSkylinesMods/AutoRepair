namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that alter the toolbar area at bottom of screen (build menus, tools bar, info bar).
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void ToolbarMods() {

            string catalog = "Toolbar";

            AddMod(new Review(1597852915u, "More Advanced Toolbar") {
                Affect = Factor.Toolbar,
                Catalog = catalog,
                Authors = "Dendraspis",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296u, Status.Incompatible }, // Resize It!
                    { 1383456057u, Status.Incompatible }, // Shicho - Fundamental support mod for hardcore builders
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 586012417u , Status.Incompatible }, // Ploppable RICO
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 563229150u , Status.Incompatible }, // Advanced Toolbar
                    { 540758804u , Status.Incompatible }, // Search Box Mod
                    { 451906822u , Status.Incompatible }, // Enhanced Build Panel (WIP)
                    { 451700838u , Status.Incompatible }, // Extended Toolbar
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                },
                Flags = ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1577882296u, "Resize It!") {
                Affect = Factor.Toolbar,
                Catalog = catalog,
                Authors = "Keallu",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2016920607u, Status.Compatible   }, // RICO revisited
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296u, Status.Incompatible }, // Resize It!
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho - Fundamental support mod for hardcore builders
                    { 1204126182u, Status.Compatible   }, // Ploppable Rico High Density Fix
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 586012417u , Status.Compatible   }, // Ploppable RICO
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 563229150u , Status.Incompatible }, // Advanced Toolbar
                    { 540758804u , Status.Incompatible }, // Search Box Mod
                    { 451906822u , Status.Incompatible }, // Enhanced Build Panel (WIP)
                    { 451700838u , Status.Incompatible }, // Extended Toolbar
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // harmony patch management could be better
                SourceURL = "https://github.com/keallu/CSL-ResizeIt",
            });
        }
    }
}