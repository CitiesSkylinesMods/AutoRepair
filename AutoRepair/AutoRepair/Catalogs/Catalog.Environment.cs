namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Environmental/disaster effects - fire, earthquake, tsumami, storms, flooding, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void EnvironmentMods() {

            string catalog = "Environment";

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
                LastSeen = WorkshopDate("8 May, 2020"),
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
                LastSeen = WorkshopDate("04 May, 2020"),
                Published = WorkshopDate("1 Sep, 2018"),
                ReplaceWith = 811352708uL, // Ragnarok - More disaster controls
                RequiredDLC = DLCs.NaturalDisasters,
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("2 Sep, 2018"),
            });

            // not really disaster, but similar to other stuff in this cat
            AddMod(new Review(1348627392u, "Tides") {
                Affect = Factor.Environment,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // possibly incompat with rainfall / other water mods?
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1115699323uL, "Immersive Water 0.9.0.0 (beta release)") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Runaurufu",
                BrokenBy = GameVersion.Campus, // may have been sooner
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 698395457uL , Status.Incompatible }, // Rainfall
                    { 629713122uL , Status.MinorIssues  }, // Climate Control 1.2.7.0
                },
                CompatibleWith = GameVersion.ParkLife, // based on user comments
                ContinuationOf = 629713122u, // water stuff split out from Climate Control 1.2.7.0
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 629713122u , "[Mod: Climate Control] You must enable 'Climate Control' option in 'Immersive Water' mod options to ensure compatibility." },
                },
                Published = WorkshopDate("20 Aug, 2017"),
                ReplaceWith = 698395457uL, // Rainfall
                SourceURL = "https://bitbucket.org/Runaurufu/cities-skylines-immersive-water/src/master/",
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("25 Sep, 2017"),
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
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("24 Apr, 2017"),
                Updated = WorkshopDate("2 May, 2017"),
            });

            AddMod(new Review(811352708uL, "Ragnarok - More disaster controls") {
                Affect = Factor.Disasters
                       | Factor.Environment,
                Authors = "Asser, [SSU]yenyang", // formerly sexyfishhorse
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
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Create disasters using the disasters tab in 'Landscaping' menu." },
                    { NOTE, "Based on an un-released earlier mod called 'LessRandomDisasters': https://github.com/yenyang/lessRandomDisasters" },
                },
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
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("22 Dec, 2016"),
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Disasters-Enabler-Mod",
                Updated = WorkshopDate("25 Dec, 2016"),
            });

            AddMod(new Review(698395457uL, "Rainfall") {
                Affect = Factor.Environment,
                Authors = "[SSU]yenyang",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1115699323uL, Status.Incompatible }, // Immersive Water 0.9.0.0 (beta release)
                    { 767233815uL , Status.Required     }, // Decal Prop Fix
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Requires drain/culvert assets to work: https://steamcommunity.com/workshop/filedetails/?id=698408622" },
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=776719005" },
                    { NOTE, "The user guide contains a section explaining how to safely remove this mod from a city." },
                },
                Published = WorkshopDate("6 Jun, 2016"),
                SourceURL = "https://github.com/yenyang/rainfall",
                Updated = WorkshopDate("10 Feb, 2020"),
            });

            AddMod(new Review(629713122uL, "Climate Control 1.2.7.0") {
                Affect = Factor.Environment,
                Authors = "Runaurufu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1869777403uL, Status.MinorIssues  }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 1115699323uL, Status.MinorIssues  }, // Immersive Water 0.9.0.0 (beta release)
                    { 814698320uL , Status.MinorIssues  }, // TimeWarp Fix
                    { 672248733uL , Status.MinorIssues  }, // Ultimate Eyecandy
                    { 605590542uL , Status.MinorIssues  }, // Rush Hour II
                    { 524021335uL , Status.Incompatible }, // Time Warp
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1115699323uL, "[Mod: Immersive Water] You must enable 'Climate Control' option in 'Immersive Water' mod options to ensure compatibility." },
                    { 814698320uL , "[Mod: Time Warp] If 'Alter day length' option is enabled, it causes issues with city lighting and day/night cycle." },
                    { 672248733uL , "[Mod: Ultimate Eyecandy] If both mods enabled, it causes issues with city lighting and day/night cycle." },
                    { 605590542uL , "[Mod: Rush Hour] To enable compatibility, select 'Rush Hour' in the settings of 'Climate Control'." },
                },
                Published = WorkshopDate("21 Feb, 2016"),
                SourceURL = "https://bitbucket.org/Runaurufu/cities-skylines-climate-control/src/master/",
                Updated = WorkshopDate("23 Jul, 2017"),
            });
        }
    }
}