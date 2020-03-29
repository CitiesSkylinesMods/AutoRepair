namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Assets (not mods).
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void AssetsCatalog() {

            string catalog = "Assets";

            AddAsset(new Item(421624072u, "Small Airport Hangar") {
                Authors = "GolonkaSwe",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2037862156u, Status.Compatible   }, // IsIntercity Fix
                },
                CompatibleWith = GameVersion.SunsetHarbor,
            });

            AddAsset(new Item(1361591068u, "Invisible 1x1 Spawn Point Variety Pack") {
                Authors = "ninjanoobslayer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
            });

            AddAsset(new Item(661138741, "Runway Blast Pad") {
                Authors = "Ayki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
            });
        }
    }
}