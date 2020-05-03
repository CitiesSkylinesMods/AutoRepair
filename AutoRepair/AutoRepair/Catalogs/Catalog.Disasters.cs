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
        private void DisasterMods() {

            string catalog = "Disasters";

            AddMod(new Review(1801953480uL, "Natural Disasters Overhaul") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187uL, Status.MinorIssues  }, // Real Time (causes excessive thunderstorms)
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline (ditto)
                    // other disaster mods:
                    { 1499486217uL, Status.Unknown      }, // Ragnarok EXTREME EDITION
                    { 811352708uL , Status.Unknown      }, // Ragnarok - More disaster controls
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1420955187uL, "[Mod: Real Time] Slower time rate results in excessive number of thunderstorms." },
                },
                Published = WorkshopDate("13 Jul, 2019"),
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Enhanced-Disasters",
                Updated = WorkshopDate("22 Aug, 2019"),
            });

            AddMod(new Review(1499486217uL, "Ragnarok EXTREME EDITION") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "SpikeViper",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1801953480uL, Status.Unknown      }, // Natural Disasters Overhaul
                    { 1499486217uL, Status.Incompatible }, // Ragnarok EXTREME EDITION
                    { 811352708uL , Status.Incompatible }, // Ragnarok - More disaster controls
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 811352708uL, // Ragnarok - More disaster controls
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // many users saying it doesn't work or is broken
                Published = WorkshopDate("1 Sep, 2018"),
                ReplaceWith = 811352708uL, // Ragnarok - More disaster controls
                RequiredDLC = DLCs.NaturalDisasters,
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("2 Sep, 2018"),
            });

            AddMod(new Review(912484109uL, "Flood Damage Control [BETA]") {
                Affect = Factor.Disasters,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // no problem mod? toggle it?
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("24 Apr, 2017"),
                Updated = WorkshopDate("2 May, 2017"),
            });

            AddMod(new Review(811352708uL, "Ragnarok - More disaster controls") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Asser", // formerly sexyfishhorse
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1801953480uL, Status.Unknown      }, // Natural Disasters Overhaul
                    { 1499486217uL, Status.Incompatible }, // Ragnarok EXTREME EDITION
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 811352708uL , Status.Incompatible }, // Ragnarok - More disaster controls
                    // based on mod called 'LessRandomDisasters' (can't find it in workshop) https://github.com/yenyang/lessRandomDisasters
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Dec, 2016"),
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/SexyFishHorse/CitiesSkylines-Ragnarok",
                Updated = WorkshopDate("1 Nov, 2018"),
            });

            AddMod(new Review(823348129uL, "Disasters Enabler") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1237383751uL, Status.MinorIssues  }, // Extended Game Options
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("22 Dec, 2016"),
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Disasters-Enabler-Mod",
                Updated = WorkshopDate("25 Dec, 2016"),
            });
        }
    }
}