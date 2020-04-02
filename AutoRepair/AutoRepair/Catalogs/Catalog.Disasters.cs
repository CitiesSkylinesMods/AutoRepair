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
                    // todo: check compat with other disaster mods
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1420955187u, "[Mod: Real Time] Slower time rate results in excessive number of thunderstorms." },
                },
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Enhanced-Disasters",
            });
        }
    }
}