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
                    { 2053500739uL, Status.Incompatible }, // AdvancedOutsideConnection
                    { 1721492498uL, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226uL, Status.Incompatible }, // Heavy Outside Traffic
                    { 784378578uL , Status.Incompatible }, // Infinite Resources ( Materials for generic industries )
                    { 734025380uL , Status.Incompatible }, // Configure Outside Connections' Limits
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1721492498u, "[Mod: Optimised Outside Connections] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                },
                Published = WorkshopDate("8 Apr, 2020"),
                SourceURL = "https://github.com/DNKpp/CitiesSkylines_AdvancedOutsideConnection",
                Updated = WorkshopDate("8 Apr, 2020"),
            });

            AddMod(new Review(1721492498u, "Optimised Outside Connections") {
                Affect = Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2053500739uL, Status.MinorIssues  }, // AdvancedOutsideConnection
                    { 1721492498uL, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226uL, Status.MinorIssues  }, // Heavy Outside Traffic
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 734025380uL , Status.MinorIssues  }, // Configure Outside Connections' Limits
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 2053500739uL, "[Mod: AdvancedOutsideConnection] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                    { 1596838226uL, "[Mod: Heavy Outside Traffic] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                    { 734025380uL , "[Mod: Configure Outside Connections' Limits] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                },
                Published = WorkshopDate("23 Apr, 2019"),
                SourceURL = "https://github.com/Quboid/Cargo_Hold_Fix",
                Updated = WorkshopDate("30 Sep, 2019"),
            });

            AddMod(new Review(1706703944uL, "More Outside Interaction") {
                Affect = Factor.OutsideConnection
                       | Factor.Employment
                       | Factor.Service,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1911736890uL, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("8 Apr, 2019"),
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
                Updated = WorkshopDate("3 May, 2020"),
            });

            AddMod(new Review(1596838226u, "Heavy Outside Traffic") {
                Affect = Factor.Immigrants
                       | Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053500739uL, Status.Incompatible }, // AdvancedOutsideConnection
                    { 1721492498uL, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226uL, Status.Incompatible }, // Heavy Outside Traffic
                    { 734025380uL , Status.Incompatible }, // Configure Outside Connections' Limits
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1721492498u, "[Mod: Optimised Outside Connections] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                },
                Published = WorkshopDate("21 Dec, 2018"),
                SourceURL = "https://github.com/pcfantasy/HeavyOutsideTraffic",
                Updated = WorkshopDate("23 Feb, 2020"),
            });

            // control cargo and resident limits
            AddMod(new Review(734025380uL, "Configure Outside Connections' Limits") {
                Affect = Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "Overhatted",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053500739uL, Status.Incompatible }, // AdvancedOutsideConnection
                    { 1721492498uL, Status.MinorIssues  }, // Optimised Outside Connections
                    { 1596838226uL, Status.Incompatible }, // Heavy Outside Traffic
                    { 734025380uL , Status.Incompatible }, // Configure Outside Connections' Limits
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1721492498u, "[Mod: Optimised Outside Connections] To ensure compatibility, do not disable 'dummy traffic' in 'Optimised Outside Connections' mod." },
                },
                Published = WorkshopDate("30 Jul, 2016"),
                SourceURL = "https://cld.pt/dl/download/5e053a73-db7a-417b-87c0-d000fc718efe/ConfigureOutsideConnectionsLimits.zip",
                Updated = WorkshopDate("25 Aug, 2018"),
            });

        }
    }
}