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
        private void AudioEffectMods() {

            string catalog = "AudioEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Review(818641631u, "Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1719979486u, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    // incompat: [ARIS] Remove Cows
                    // incompat: [ARIS] Remove Pigs
                    // incompat: [ARIS] Remove Seagulls
                    { 555026832u , Status.Incompatible }, // UK Sound Pack
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 455958878u, // Ambient Sounds Tuner
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMusic(new Review(2053925580u, "Philippines Sound MOD 2K20 (PSM)") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1952822305u, Status.Recommended  }, // Pulis Mobil Philippines
                    { 1719979486u, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 1719979486u, // Philippines Realistic Sound Mod: Return!
                Flags = ItemFlags.SourceBundled,
                Locale = "tl-ph",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("9 Apr, 2020"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Philippines", "Pulis", "Mobil", "Pilipinas", "Filipinas", "Manila",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            AddMod(new Review(1999271351u, "0xyl0nSoundPackUSA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 76 MB
                      | ItemFlags.SourceBundled,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("16 Feb, 2020"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
                Updated = WorkshopDate("19 Feb, 2020"),
            });

            AddMod(new Review(1982045897u, "(for backup)TwotoolusFLY's Siren mod") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "TwotoolusFLY LSh.st",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1979269356u, "Swedish Emergency Vehicle Sirens - Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "JCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "sv-se",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1977435537u, "OxylonEuroSoundpackSWE") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 64 MB
                      | ItemFlags.SourceBundled,
                Locale = "sv-se",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1974722022u, "Grand Theft Auto Mission Passed On Upgrade") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Building", "Upgrade", "GTA",
                },
            });

            AddMod(new Review(1969438995u, "OxylonEuroSoundpackITA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 72 MB
                      | ItemFlags.SourceBundled,
                Locale = "it",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Italy", "Italian", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969435641u, "OxylonEuroSoundpackFRA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 73 MB
                      | ItemFlags.SourceBundled,
                Locale = "fr",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "France", "French", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969432061u, "OxylonEuroSoundpackNED") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 70 MB
                      | ItemFlags.SourceBundled,
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Holland", "Dutch", "Nederlands", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969428208u, "OxylonEuroSoundpackAUT") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 67 MB
                      | ItemFlags.SourceBundled,
                Locale = "de-at",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austria", "German", "Österreich", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969411916u, "OxylonEuroSoundpackGER") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 62 MB
                      | ItemFlags.SourceBundled,
                Locale = "de",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1961235713u, "Grand Theft Auto Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "GTA",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1764439209u, "DB Announcer") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Retch | Mushr00mhat",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "de",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European", "Düsseldorf", "Hbf",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1729946947u, "Austrian Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "X00LA",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "de-at",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austria", "German", "Österreich", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1660065880u, "Pre-War Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Destructulus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "en-us",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "1930", "1940", "1950",
                },
            });

            AddMod(new Review(1636310959u, "NS Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "nl", "en", "fr", },
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("26 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Dutch", "Nedelands", "Netherlands", "European",
                    "Buildings", "Trains", "Stations", "NS", "Spoorwegen", "announcement",
                },
                Updated = WorkshopDate("26 Jan, 2019"),
            });

            AddMod(new Review(1629745074u, "ÖBB Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "de-at", "en" },
                Locale = "de-at",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austrian", "Vienna", "Österreich", "German", "Deutsch", "Wien", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "ÖBB", "OBB", "OEBB",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Review(1628985258u, "CFF Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "fr-ch", "en" },
                Locale = "fr-ch",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "French", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Review(1624184698u, "SBB Sound Pack for Ambient Sounds Tune") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "de-ch", "en", "fr-ch", "it-ch", },
                Locale = "de-ch",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("13 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "German", "deutsch", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("18 Jan, 2019"),
            });

            AddMod(new Review(1480332470u, "Polish Sirens Pack [V2.2]") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Miętaa",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "pl",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Poland", "Polish", "Polskie", "Polsce", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1436056719u, "Kaguki's Realistic Akihabara Sounds") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1431909554u, Status.Recommended }, // Kaguki JPN Realistic Sounds v6 (TESTING)
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125u , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125u, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Metro",
                    "Akihabara", "Otaku", "Anime", "Manga",
                },
            });

            AddMod(new Review(1398060749u, "Evo's Korean Sound Overhaul [v0.1d]") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Evo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "ko",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Metro",
                    "Korean",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1327734238u, "Deutsche Martinshörner für Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Viss Valdyr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1316748022u, "Martinshorn/ vormals V10 Siren") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Kwengie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "de",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European", "Martinshorn",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(939566479u, "Bee's North America Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "imabusybee",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "en-us",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance", "Rumbler", "Howler",
                },
            });

            AddMod(new Review(925211833u, "K's Old Siren Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Lieutenant A.Kouassi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "en-us",
                Published = WorkshopDate("13 May, 2017"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "USA", "America", "United", "States", "1950s", "1960s", "1970s", "1980s",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance", "Rumbler", "Howler",
                },
                Updated = WorkshopDate("26 Jun, 2017"),
            });

            AddMod(new Review(917009851u, "Swedish 1970 Siren Mod") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Indiana Jones: The Original Adve",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "sv-se",
                Published = WorkshopDate("1 May, 2017"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance", "Volvo", "Amazon",
                },
                Updated = WorkshopDate("1 May, 2017"),
            });

            AddMod(new Review(899063611u, "UK Sound Pack -- Updated 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "alborzka",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 899063611u , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631u , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 555026832u , Status.Incompatible }, // UK Sound Pack
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 555026832u, // UK Sound Pack
                Flags = ItemFlags.SourceBundled,
                Locale = "en-gb",
                Published = WorkshopDate("5 Apr, 2017"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "British", "English", "UK", "Britain", "European",
                    "Buildings", "Trains", "Stations", "Announcement",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
                Updated = WorkshopDate("5 Apr, 2017"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1719979486u, "Philippines Realistic Sound Mod: Return!") {
                Affect = Factor.Audio,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580u, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "tl-ph",
                Published = WorkshopDate("22 Apr, 2019"),
                ReplaceWith = 2053925580u, // Philippines Sound MOD 2K20 (PSM)
                SuppressArchiveWarning = true,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Philippines", "Pulis", "Mobil", "Pilipinas", "Filipinas", "Manila",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
                Updated = WorkshopDate("22 Apr, 2019"),
            });

            AddMod(new Review(555026832u, "UK Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Neal_911",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 899063611u , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 555026832u , Status.Incompatible }, // UK Sound Pack
                    { 455958878u , Status.Required     }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Patch_1_5_2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceBundled,
                Locale = "en-gb",
                Published = WorkshopDate("14 Nov, 2015"),
                ReplaceWith = 899063611u, // UK Sound Pack -- Updated 2.0
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "British", "English", "UK", "Britain", "European",
                    "Buildings", "Trains", "Stations", "Announcement",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
                Updated = WorkshopDate("15 Nov, 2015"),
            });

            // original mod (obsolete)
            AddMod(new Review(455958878u, "Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                ArchiveURL = "https://web.archive.org/web/20150703090042/http://steamcommunity.com/sharedfiles/filedetails/?id=455958878",
                Authors = "Archomeda",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580u, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 1999271351u, Status.Incompatible }, // 0xyl0nSoundPackUSA
                    { 1982045897u, Status.Incompatible }, // (for backup)TwotoolusFLY's Siren mod
                    { 1979269356u, Status.Incompatible }, // Swedish Emergency Vehicle Sirens - Sound Pack
                    { 1977435537u, Status.Incompatible }, // OxylonEuroSoundpackSWE
                    { 1974722022u, Status.Incompatible }, // Grand Theft Auto Mission Passed On Upgrade
                    { 1969438995u, Status.Incompatible }, // OxylonEuroSoundpackITA
                    { 1969435641u, Status.Incompatible }, // OxylonEuroSoundpackFRA
                    { 1969432061u, Status.Incompatible }, // OxylonEuroSoundpackNED
                    { 1969428208u, Status.Incompatible }, // OxylonEuroSoundpackAUT
                    { 1969411916u, Status.Incompatible }, // OxylonEuroSoundpackGER
                    { 1961235713u, Status.Incompatible }, // Grand Theft Auto Sirens
                    { 1764439209u, Status.Incompatible }, // DB Announcer
                    { 1729946947u, Status.Incompatible }, // Austrian Sirens
                    { 1719979486u, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1660065880u, Status.Incompatible }, // Pre-War Sirens
                    { 1636310959u, Status.Incompatible }, // NS Sound Pack for Ambient Sounds Tuner
                    { 1629745074u, Status.Incompatible }, // ÖBB Sound Pack for Ambient Sounds Tuner
                    { 1628985258u, Status.Incompatible }, // CFF Sound Pack for Ambient Sounds Tuner
                    { 1624184698u, Status.Incompatible }, // SBB Sound Pack for Ambient Sounds Tune
                    { 1541828679u, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 1480332470u, Status.Incompatible }, // Polish Sirens Pack [V2.2]
                    { 1436056719u, Status.Incompatible }, // Kaguki's Realistic Akihabara Sounds
                    { 1398060749u, Status.Incompatible }, // Evo's Korean Sound Overhaul [v0.1d]
                    { 1327734238u, Status.Incompatible }, // Deutsche Martinshörner für Ambient Sounds Tuner 2.0
                    { 1316748022u, Status.Incompatible }, // Martinshorn/ vormals V10 Siren
                    { 939566479u , Status.Incompatible }, // Bee's North America Sound Pack
                    { 925211833u , Status.Incompatible }, // K's Old Siren Pack
                    { 917009851u , Status.Incompatible }, // Swedish 1970 Siren Mod
                    { 899063611u , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 555026832u , Status.Compatible   }, // UK Sound Pack
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Creating sound packs (outdated): https://github.com/Archomeda/csl-ambient-sounds-tuner/wiki/Creating%20Sound%20Packs" },
                },
                Published = WorkshopDate("5 Jun, 2015"),
                ReplaceWith = 818641631u, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/Archomeda/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
                Updated = WorkshopDate("1 Jul, 2015"), // prolly more  updates, but that's as far as wayback machine goes
            });

            // obsolete
            AddMod(new Review(435167188u, "V10Siren") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "V10lator",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580u, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 1999271351u, Status.Incompatible }, // 0xyl0nSoundPackUSA
                    { 1982045897u, Status.Incompatible }, // (for backup)TwotoolusFLY's Siren mod
                    { 1979269356u, Status.Incompatible }, // Swedish Emergency Vehicle Sirens - Sound Pack
                    { 1977435537u, Status.Incompatible }, // OxylonEuroSoundpackSWE
                    { 1974722022u, Status.Incompatible }, // Grand Theft Auto Mission Passed On Upgrade
                    { 1969438995u, Status.Incompatible }, // OxylonEuroSoundpackITA
                    { 1969435641u, Status.Incompatible }, // OxylonEuroSoundpackFRA
                    { 1969432061u, Status.Incompatible }, // OxylonEuroSoundpackNED
                    { 1969428208u, Status.Incompatible }, // OxylonEuroSoundpackAUT
                    { 1969411916u, Status.Incompatible }, // OxylonEuroSoundpackGER
                    { 1961235713u, Status.Incompatible }, // Grand Theft Auto Sirens
                    { 1764439209u, Status.Incompatible }, // DB Announcer
                    { 1729946947u, Status.Incompatible }, // Austrian Sirens
                    { 1719979486u, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1660065880u, Status.Incompatible }, // Pre-War Sirens
                    { 1636310959u, Status.Incompatible }, // NS Sound Pack for Ambient Sounds Tuner
                    { 1629745074u, Status.Incompatible }, // ÖBB Sound Pack for Ambient Sounds Tuner
                    { 1628985258u, Status.Incompatible }, // CFF Sound Pack for Ambient Sounds Tuner
                    { 1624184698u, Status.Incompatible }, // SBB Sound Pack for Ambient Sounds Tune
                    { 1541828679u, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 1480332470u, Status.Incompatible }, // Polish Sirens Pack [V2.2]
                    { 1436056719u, Status.Incompatible }, // Kaguki's Realistic Akihabara Sounds
                    { 1398060749u, Status.Incompatible }, // Evo's Korean Sound Overhaul [v0.1d]
                    { 1327734238u, Status.Incompatible }, // Deutsche Martinshörner für Ambient Sounds Tuner 2.0
                    { 1316748022u, Status.Incompatible }, // Martinshorn/ vormals V10 Siren
                    { 939566479u , Status.Incompatible }, // Bee's North America Sound Pack
                    { 925211833u , Status.Incompatible }, // K's Old Siren Pack
                    { 917009851u , Status.Incompatible }, // Swedish 1970 Siren Mod
                    { 899063611u , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 555026832u , Status.Incompatible }, // UK Sound Pack
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    { 455958878u , Status.Compatible   }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // use Ambinet Sounds Tuner 2.0
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("1 May, 2015"),
                ReplaceWith = 818641631u, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/V10lator/V10Siren",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" },
                Updated = WorkshopDate("21 Jun, 2018"),
            });
        }
    }
}
