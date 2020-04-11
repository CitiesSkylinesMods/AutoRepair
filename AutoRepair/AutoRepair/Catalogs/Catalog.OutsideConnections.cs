namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that affect outside connecitons.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void OutsideConnectionMods() {

            string catalog = "OutsideConnections";

            AddMod(new Review(2053500739u, "AdvancedOutsideConnection") {
                Affect = Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "anti-freak",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053500739u, Status.Incompatible }, // AdvancedOutsideConnection
                    { 1721492498u, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226u, Status.Incompatible }, // Heavy Outside Traffic
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1721492498u, "[Mod: Optimised Outside Connections] If you disable dummy traffic, it will conflict with AdvancedOutsideConnection settings." },
                },
                Published = WorkshopDate("8 Apr, 2020"),
                SourceURL = "https://github.com/DNKpp/CitiesSkylines_AdvancedOutsideConnection",
                Updated = WorkshopDate("8 Apr, 2020"),
            });

            AddMod(new Review(1596838226u, "Heavy Outside Traffic") {
                Affect = Factor.Immigrants
                       | Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053500739u, Status.Incompatible }, // AdvancedOutsideConnection
                    { 1721492498u, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226u, Status.Incompatible }, // Heavy Outside Traffic
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1721492498u, "[Mod: Optimised Outside Connections] If you disable dummy traffic, it will conflict with AdvancedOutsideConnection settings." },
                },
                Published = WorkshopDate("21 Dec, 2018"),
                Updated = WorkshopDate("23 Feb, 2020"),
            });

        }
    }
}