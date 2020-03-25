namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods which affect public transport, transport lines, waiting times, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void PublicTransportCatalog() {

            string catalog = "PublicTransport";

            // todo: check if this causes stuck cims
            AddMod(new Item(1776052533u, "Stops & Stations") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "dymanoid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 928128676u , Status.MinorIssues  }, // Improved Public Transport 2 (can confuse boredom indicator)
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/dymanoid/StopsAndStations",
            });
        }
    }
}