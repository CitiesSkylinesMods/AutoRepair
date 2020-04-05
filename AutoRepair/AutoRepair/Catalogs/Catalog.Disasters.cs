namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Disasters - fire, earthquake, tsumami, storms, flooding, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void DisastersCatalog() {

            string catalog = "Disasters";

            AddMod(new Item(1801953480u, "Natural Disasters Overhaul") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.MinorIssues  }, // Real Time (causes excessive thunderstorms)
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline (ditto)
                    // other disaster mods:
                    { 1499486217u, Status.Unknown      }, // Ragnarok EXTREME EDITION
                    { 811352708u , Status.Unknown      }, // Ragnarok - More disaster controls
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1420955187u, "[Mod: Real Time] Slower time rate results in excessive number of thunderstorms." },
                },
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Enhanced-Disasters",
            });

            AddMod(new Item(1499486217u, "Ragnarok EXTREME EDITION") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "SpikeViper",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1801953480u, Status.Unknown      }, // Natural Disasters Overhaul
                    { 1499486217u, Status.Incompatible }, // Ragnarok EXTREME EDITION
                    { 811352708u , Status.Incompatible }, // Ragnarok - More disaster controls
                },
                CompatibleWith = GameVersion.PdxLauncher,
                ContinuationOf = 811352708u, // Ragnarok - More disaster controls
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // many users saying it doesn't work or is broken
                Published = WorkshopDate("1 Sep, 2018"),
                ReplaceWith = 811352708u, // Ragnarok - More disaster controls
                SuppressOlderReplacementWarning = true,
                Updated = WorkshopDate("2 Sep, 2018"),
            });

            AddMod(new Item(811352708u, "Ragnarok - More disaster controls") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Asser", // formerly sexyfishhorse
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1801953480u, Status.Unknown      }, // Natural Disasters Overhaul
                    { 1499486217u, Status.Incompatible }, // Ragnarok EXTREME EDITION
                    { 811352708u , Status.Incompatible }, // Ragnarok - More disaster controls
                    // based on mod called 'LessRandomDisasters' (can't find it in workshop) https://github.com/yenyang/lessRandomDisasters
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Dec, 2016"),
                SourceURL = "https://github.com/SexyFishHorse/CitiesSkylines-Ragnarok",
                Updated = WorkshopDate("1 Nov, 2018"),
            });
        }
    }
}