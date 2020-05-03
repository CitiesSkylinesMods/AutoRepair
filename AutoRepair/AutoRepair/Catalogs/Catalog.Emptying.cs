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
        private void EmptyingMods() {

            string catalog = "Emptying";

            AddMod(new Review(1661072176uL, "Empty It!") {
                Affect = Factor.Emptying,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("19 Feb, 2019"),
                SourceURL = "https://github.com/keallu/CSL-EmptyIt",
                Updated = WorkshopDate("20 Mar, 2019"),
            });

            AddMod(new Review(1456061226uL, "Better Cemetery AI") {
                Affect = Factor.Emptying,
                Authors = "Sean",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // Some users say it doesn't work
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Possibly incompatible with TM:PE and/or Real Time mods (further testing required)." },
                },
                Published = WorkshopDate("28 Jul, 2018"),
                ReplaceWith = 1661072176uL, // Empty It
                SourceURL = "https://github.com/seanke/BetterCemeteryAI",
                Updated = WorkshopDate("30 Jul, 2018"),
            });

            AddMod(new Review(1182722930uL, "Automatic Empty") {
                Affect = Factor.Emptying,
                Authors = "Sottam",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // some users state it's not working since parklife DLC
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Doesn't empty snow dumps." },
                },
                Published = WorkshopDate("28 Oct, 2017"),
                ReplaceWith = 1661072176uL, // Empty It
                SourceURL = "https://github.com/sottam/AutoEmpty",
                Updated = WorkshopDate("28 Oct, 2017"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // possibly a translation
            AddMod(new Review(896806060uL, "407873631 Automatic Emptying") {
                Affect = Factor.Emptying,
                Authors = "Ozhunter",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                CloneOf = 407873631uL, // Automatic Emptying
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("2 Apr, 2017"),
                ReplaceWith = 1661072176uL, // Empty It
                Suppress = Warning.InvalidVersionSequence,
                Updated = WorkshopDate("2 Apr, 2017"),
            });

            AddMod(new Review(686588890uL, "Automatic Emptying: Extended") {
                Affect = Factor.Emptying,
                Authors = "mexahuk",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.ParkLife,
                ContinuationOf = 407873631uL, // Automatic Emptying
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "pt", "ru" },
                Locale = "en",
                Published = WorkshopDate("18 May, 2016"),
                ReplaceWith = 1661072176uL, // Empty It
                SourceURL = "https://github.com/YuryScherbakov/AutoEmptyingExtended",
                Updated = WorkshopDate("19 May, 2018"),
            });

            AddMod(new Review(407873631uL, "Automatic Emptying") {
                Affect = Factor.Emptying,
                Authors = "Sadler",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1661072176uL, Status.Incompatible }, // Empty It!
                    { 1456061226uL, Status.Incompatible }, // Better Cemetery AI
                    { 1182722930uL, Status.Incompatible }, // Automatic Empty
                    { 896806060uL , Status.Incompatible }, // 407873631 Automatic Emptying
                    { 686588890uL , Status.Incompatible }, // Automatic Emptying: Extended
                    { 407873631uL , Status.Incompatible }, // Automatic Emptying
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unreliable, sometimes doesn't work, other times causes lots of lag, doesn't empty snow dumps." },
                },
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 1661072176uL, // Empty It
                Updated = WorkshopDate("15 Mar, 2015"),
            });
        }
    }
}