namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Automatic emptying of cemeteries, snow dumps and garbage dumps.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void EmptyingCatalog() {

            string catalog = "Emptying";

            AddMod(new Item(1661072176u, "Empty It!") {
                Affect = Factor.Emptying,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176u, Status.Incompatible }, // Empty It!
                    { 1456061226u, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930u, Status.Incompatible }, // Automatic Empty
                    { 896806060u , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890u , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631u , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceURL = "https://github.com/keallu/CSL-EmptyIt",
            });

            AddMod(new Item(1456061226u, "Better Cemetery AI") {
                Affect = Factor.Emptying,
                Authors = "Sean",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176u, Status.Incompatible }, // Empty It!
                    { 1456061226u, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930u, Status.Incompatible }, // Automatic Empty
                    { 896806060u , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890u , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631u , Status.Incompatible }, // Automatic Emptying
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // Some users say it doesn't work
                SourceURL = "https://github.com/seanke/BetterCemeteryAI",
            });

            AddMod(new Item(1182722930u, "Automatic Empty") {
                Affect = Factor.Emptying,
                Authors = "Sottam",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176u, Status.Incompatible }, // Empty It!
                    { 1456061226u, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930u, Status.Incompatible }, // Automatic Empty
                    { 896806060u , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890u , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631u , Status.Incompatible }, // Automatic Emptying
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // some users state it's not working since parklife DLC
                SourceURL = "https://github.com/sottam/AutoEmpty",
            });
        }
    }
}