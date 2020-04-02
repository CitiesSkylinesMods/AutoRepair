namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Audio effects, vehicle sounds, environment sounds, volume, etc.
    ///
    /// See also: <c>Catalog.VehicleEffects.cs</c>.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void AudioEffectsCatalog() {

            string catalog = "AudioEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Item(818641631u, "Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    // incompat: [ARIS] Remove Cows
                    // incompat: [ARIS] Remove Pigs
                    // incompat: [ARIS] Remove Seagulls
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                ContinuationOf = 455958878u, // Ambient Sounds Tuner
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // original mod (obsolete)
            // https://github.com/Archomeda/csl-ambient-sounds-tuner/wiki/Creating%20Sound%20Packs
            AddMod(new Item(455958878u, "Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Archomeda",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1541828679u, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    // incompat: [ARIS] Remove Cows
                    // incompat: [ARIS] Remove Pigs
                    // incompat: [ARIS] Remove Seagulls
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Compatible   }, // V10Siren
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // approx Dec 2016
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // approx Jan 2017
                      | ItemFlags.Obsolete // replacement mod available
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 818641631u, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/Archomeda/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
            });

            // obsolete
            AddMod(new Item(435167188u, "V10Siren") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "V10lator",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1541828679u, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    { 455958878u , Status.Compatible   }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // use Ambinet Sounds Tuner 2.0
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 818641631u, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/V10lator/V10Siren",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" },
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Item(1999271351u, "0xyl0nSoundPackUSA") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required    }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 76 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1982045897u, "(for backup)TwotoolusFLY's Siren mod") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "TwotoolusFLY LSh.st",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1979269356u, "Swedish Emergency Vehicle Sirens - Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "JCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "sv-se",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1977435537u, "OxylonEuroSoundpackSWE") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 64 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "sv-se",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1974722022u, "Grand Theft Auto Mission Passed On Upgrade") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Building", "Upgrade", "GTA",
                },
            });

            AddMod(new Item(1969438995u, "OxylonEuroSoundpackITA") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 72 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "it",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Italy", "Italian", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1969435641u, "OxylonEuroSoundpackFRA") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 73 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "fr",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "France", "French", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1969432061u, "OxylonEuroSoundpackNED") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 70 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "nl",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Holland", "Dutch", "Nederlands", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1969428208u, "OxylonEuroSoundpackAUT") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 67 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "de-at",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austria", "German", "Österreich", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1969411916u, "OxylonEuroSoundpackGER") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 62 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1961235713u, "Grand Theft Auto Sirens") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "GTA",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1764439209u, "DB Announcer") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Retch | Mushr00mhat",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European", "Düsseldorf", "Hbf",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Item(1729946947u, "Austrian Sirens") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "X00LA",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de-at",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austria", "German", "Österreich", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1660065880u, "Pre-War Sirens") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Destructulus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "1930", "1940", "1950",
                },
            });

            AddMod(new Item(1636310959u, "NS Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "nl", "en", "fr", },
                Locale = "nl",
                Published = WorkshopDate("26 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Dutch", "Nedelands", "Netherlands", "European",
                    "Buildings", "Trains", "Stations", "NS", "Spoorwegen", "announcement",
                },
                Updated = WorkshopDate("26 Jan, 2019"),
            });

            AddMod(new Item(1629745074u, "ÖBB Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "de-at", "en" },
                Locale = "de-at",
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austrian", "Vienna", "Österreich", "German", "Deutsch", "Wien", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "ÖBB", "OBB", "OEBB",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Item(1628985258u, "CFF Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "fr-ch", "en" },
                Locale = "fr-ch",
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "French", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Item(1624184698u, "SBB Sound Pack for Ambient Sounds Tune") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 815103125u, Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "de-ch", "en", "fr-ch", "it-ch", },
                Locale = "de-ch",
                Published = WorkshopDate("13 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "German", "deutsch", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("18 Jan, 2019"),
            });

            AddMod(new Item(1480332470u, "Polish Sirens Pack [V2.2]") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Miętaa",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "pl",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Poland", "Polish", "Polskie", "Polsce", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1436056719u, "Kaguki's Realistic Akihabara Sounds") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1431909554u, Status.Recommended }, // Kaguki JPN Realistic Sounds v6 (TESTING)
                    { 818641631u , Status.Required    }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues }, // Extra Vehicle Effects (disable rail service sounds)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "ja",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Metro",
                    "Akihabara", "Otaku", "Anime", "Manga",
                },
            });

            AddMod(new Item(1398060749u, "Evo's Korean Sound Overhaul [v0.1d]") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Evo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "ko",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Metro",
                    "Korean",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1327734238u, "Deutsche Martinshörner für Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Viss Valdyr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(1316748022u, "Martinshorn/ vormals V10 Siren") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Kwengie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European", "Martinshorn",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Item(939566479u, "Bee's North America Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "imabusybee",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance", "Rumbler", "Howler",
                },
            });
        }
    }
}
