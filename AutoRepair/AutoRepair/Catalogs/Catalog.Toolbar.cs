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
                Affect = Factor.Toolbar
                       | Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1577882296u, Status.Incompatible }, // Resize It!
                    { 1383456057u, Status.Incompatible }, // Shicho - Fundamental support mod for hardcore builders
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 837734529uL , Status.MinorIssues  }, // Find It!
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Mod: Find It!] Advanced Toolbar cannot be applied to the non-standard Find It panel." },
                },
                Published = WorkshopDate("22 Dec, 2018"),
                Updated = WorkshopDate("18 Jun, 2019"),
            });

            AddMod(new Review(1577882296u, "Resize It!") {
                Affect = Factor.Toolbar
                       | Factor.UI,
                Authors = "Keallu",
                Catalog = catalog,
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

            AddMod(new Review(837734529uL, "Find It!") {
                Affect = Factor.PlaceAndMove
                       | Factor.Toolbar
                       | Factor.UI,
                Authors = "Boogieman Sam",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1597852915uL, Status.MinorIssues  }, // More Advanced Toolbar
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057uL, Status.Incompatible }, // Shicho
                    { 888017364uL , Status.Compatible   }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.Compatible   }, // Quartz (former Sapphire) - UI skin framework
                    { 540758804uL , Status.Incompatible }, // Search Box Mod
                    { 421770876uL , Status.Compatible   }, // Sapphire - UI skin framework
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod generates asset thumbnails at end of loading screen; if you are very low on RAM, it may cause game to crash." },
                    { NOTE, "[DLC: Green Cities] The filters don't include eco buildings, but you can search for 'eco' to find them." },
                    { NOTE, "[DLC: Industries] The filters don't include some industry buidings, but you can still search for them by name." },
                    { NOTE, "[DLC: Campus] The filters don't include some campus buidings, but you can still search for them by name." },
                    { NOTE, "[DLC: Sunset Harbor] The filters don't include some fishing buidings, but you can still search for them by name." },
                    { 1597852915uL, "[Mod: More Advanced Toolbar] Find It has custom toolbar, so More Advanced Toolbar features will not be applied to it." },
                },
                Published = WorkshopDate("8 Jan, 2017"),
                SourceURL = "https://github.com/SamsamTS/CS-FindIt",
                Updated = WorkshopDate("10 Jun, 2018"),
            });
        }
    }
}