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

            AddMod(new Review(818641631uL, "Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1719979486uL, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (Plugin for Vehicle Effects Mod)
                    { 768213484uL , Status.Incompatible }, // Subtle Bulldozing, Dragging and More!
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    // incompat: [ARIS] Remove Cows
                    // incompat: [ARIS] Remove Pigs
                    // incompat: [ARIS] Remove Seagulls
                    { 555026832uL , Status.Incompatible }, // UK Sound Pack
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 455958878uL, // Ambient Sounds Tuner
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Documentation: https://github.com/Archomeda/csl-ambient-sounds-tuner/wiki" },
                },
                Published = WorkshopDate("15 Dec, 2016"),
                SourceURL = "https://github.com/bloodypenguin/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
                Updated = WorkshopDate("11 Mar, 2018"),
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMusicMod(new Review(2053925580uL, "Philippines Sound MOD 2K20 (PSM)") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1952822305uL, Status.Recommended  }, // Pulis Mobil Philippines
                    { 1719979486uL, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 1719979486uL, // Philippines Realistic Sound Mod: Return!
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "tl-ph",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
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

            AddMod(new Review(1999271351uL, "0xyl0nSoundPackUSA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 76 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
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

            AddMod(new Review(1982045897uL, "(for backup)TwotoolusFLY's Siren mod") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "TwotoolusFLY LSh.st",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1979269356uL, "Swedish Emergency Vehicle Sirens - Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "JCity",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "sv-se",
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1977435537uL, "OxylonEuroSoundpackSWE") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 64 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "sv-se",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Sweden", "Swedish", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1974722022uL, "Grand Theft Auto Mission Passed On Upgrade") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Building", "Upgrade", "GTA",
                },
            });

            AddMod(new Review(1969438995uL, "OxylonEuroSoundpackITA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 72 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "it",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Italy", "Italian", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969435641uL, "OxylonEuroSoundpackFRA") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 73 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "fr",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "France", "French", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969432061uL, "OxylonEuroSoundpackNED") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 70 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Holland", "Dutch", "Nederlands", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969428208uL, "OxylonEuroSoundpackAUT") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 67 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de-at",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austria", "German", "Österreich", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1969411916uL, "OxylonEuroSoundpackGER") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 62 MB
                      | ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1961235713uL, "Grand Theft Auto Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Marty Stonks",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "GTA",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
            });

            AddMod(new Review(1764439209uL, "DB Announcer") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Retch | Mushr00mhat",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Germany", "Deutschland", "European", "Düsseldorf", "Hbf",
                    "Buildings", "Trains", "Stations",
                },
            });

            AddMod(new Review(1729946947uL, "Austrian Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "X00LA",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(1660065880uL, "Pre-War Sirens") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Destructulus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(1636310959uL, "NS Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "nl", "en", "fr", },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("26 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Dutch", "Nedelands", "Netherlands", "European",
                    "Buildings", "Trains", "Stations", "NS", "Spoorwegen", "announcement",
                },
                Updated = WorkshopDate("26 Jan, 2019"),
            });

            AddMod(new Review(1629745074uL, "ÖBB Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "de-at", "en" },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de-at",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Austrian", "Vienna", "Österreich", "German", "Deutsch", "Wien", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "ÖBB", "OBB", "OEBB",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Review(1628985258uL, "CFF Sound Pack for Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "fr-ch", "en" },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "fr-ch",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("19 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "French", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Review(1624184698uL, "SBB Sound Pack for Ambient Sounds Tune") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "ralphzug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Languages = new[] { "de-ch", "en", "fr-ch", "it-ch", },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de-ch",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("13 Jan, 2019"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Swiss", "Switzerland", "Schweiz", "Suisse", "German", "deutsch", "European",
                    "Buildings", "Trains", "Stations", "Announcement", "SBB", "CFF", "FFS",
                },
                Updated = WorkshopDate("18 Jan, 2019"),
            });

            AddMod(new Review(1480332470uL, "Polish Sirens Pack [V2.2]") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Miętaa",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(1436056719uL, "Kaguki's Realistic Akihabara Sounds") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1431909554uL, Status.Recommended }, // Kaguki JPN Realistic Sounds v6 (TESTING)
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled,
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Tags = new[] {
                    "Sounds", "Audio", "Ambient", "Metro",
                    "Akihabara", "Otaku", "Anime", "Manga",
                },
            });

            AddMod(new Review(1398060749uL, "Evo's Korean Sound Overhaul [v0.1d]") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Evo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(1327734238uL, "Deutsche Martinshörner für Ambient Sounds Tuner 2.0") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Viss Valdyr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(1316748022uL, "Martinshorn/ vormals V10 Siren") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Kwengie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL, Status.Required }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(939566479uL, "Bee's North America Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "imabusybee",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(925211833uL, "K's Old Siren Pack") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Lieutenant A.Kouassi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(917009851uL, "Swedish 1970 Siren Mod") {
                Affect = Factor.Audio
                       | Factor.Vehicles,
                Authors = "Indiana Jones: The Original Adve",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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

            AddMod(new Review(899063611uL, "UK Sound Pack -- Updated 2.0") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "alborzka",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 899063611uL , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 555026832uL , Status.Incompatible }, // UK Sound Pack
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 555026832uL, // UK Sound Pack
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

            // Author states:
            // If you save while applying this sound mod, and delete the mod, when the game loads
            // an error will occur and you will not be able to play.
            AddMod(new Review(887588790uL, "Japanese Sound MOD") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "alborzka",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Required     }, // Ambient Sounds Tuner 2.0
                    { 815103125uL , Status.MinorIssues  }, // Extra Vehicle Effects (disable rail service sounds)
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SaveAltering // according to author
                      | ItemFlags.SourceBundled,
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { 815103125uL, "[Mod: Extra Vehicle Effects] If 'Disable rail service sounds' is selected, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("20 Mar, 2017"),
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Japanese",
                    "Buildings", "Trains", "Stations", "Announcement",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
                Updated = WorkshopDate("20 Mar, 2017"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1719979486uL, "Philippines Realistic Sound Mod: Return!") {
                Affect = Factor.Audio,
                Authors = "Corn Starchia",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580uL, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("30 Mar, 2020"),
                Locale = "tl-ph",
                Published = WorkshopDate("22 Apr, 2019"),
                Removed = WorkshopDate("15 Apr, 2020"),
                ReplaceWith = 2053925580uL, // Philippines Sound MOD 2K20 (PSM)
                Suppress = Warning.MissingArchiveURL,
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "Philippines", "Pulis", "Mobil", "Pilipinas", "Filipinas", "Manila",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                    "Buildings", "Trains", "Stations",
                },
                Updated = WorkshopDate("22 Apr, 2019"),
            });

            AddMod(new Review(555026832uL, "UK Sound Pack") {
                Affect = Factor.Audio
                       | Factor.Environment
                       | Factor.Vehicles,
                Authors = "Neal_911",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 899063611uL , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 555026832uL , Status.Incompatible }, // UK Sound Pack
                    { 455958878uL , Status.Required     }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
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
                ReplaceWith = 899063611uL, // UK Sound Pack -- Updated 2.0
                Tags = new[] {
                    "Sounds", "Audio", "Ambient",
                    "British", "English", "UK", "Britain", "European",
                    "Buildings", "Trains", "Stations", "Announcement",
                    "Vehicles", "Sirens", "Police", "Fire", "Ambulance",
                },
                Updated = WorkshopDate("15 Nov, 2015"),
            });

            // original mod (obsolete)
            AddMod(new Review(455958878uL, "Ambient Sounds Tuner") {
                Affect = Factor.Audio
                       | Factor.Environment,
                ArchiveURL = "https://web.archive.org/web/20150703090042/http://steamcommunity.com/sharedfiles/filedetails/?id=455958878",
                Authors = "Archomeda",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580uL, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 1999271351uL, Status.Incompatible }, // 0xyl0nSoundPackUSA
                    { 1982045897uL, Status.Incompatible }, // (for backup)TwotoolusFLY's Siren mod
                    { 1979269356uL, Status.Incompatible }, // Swedish Emergency Vehicle Sirens - Sound Pack
                    { 1977435537uL, Status.Incompatible }, // OxylonEuroSoundpackSWE
                    { 1974722022uL, Status.Incompatible }, // Grand Theft Auto Mission Passed On Upgrade
                    { 1969438995uL, Status.Incompatible }, // OxylonEuroSoundpackITA
                    { 1969435641uL, Status.Incompatible }, // OxylonEuroSoundpackFRA
                    { 1969432061uL, Status.Incompatible }, // OxylonEuroSoundpackNED
                    { 1969428208uL, Status.Incompatible }, // OxylonEuroSoundpackAUT
                    { 1969411916uL, Status.Incompatible }, // OxylonEuroSoundpackGER
                    { 1961235713uL, Status.Incompatible }, // Grand Theft Auto Sirens
                    { 1764439209uL, Status.Incompatible }, // DB Announcer
                    { 1729946947uL, Status.Incompatible }, // Austrian Sirens
                    { 1719979486uL, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1660065880uL, Status.Incompatible }, // Pre-War Sirens
                    { 1636310959uL, Status.Incompatible }, // NS Sound Pack for Ambient Sounds Tuner
                    { 1629745074uL, Status.Incompatible }, // ÖBB Sound Pack for Ambient Sounds Tuner
                    { 1628985258uL, Status.Incompatible }, // CFF Sound Pack for Ambient Sounds Tuner
                    { 1624184698uL, Status.Incompatible }, // SBB Sound Pack for Ambient Sounds Tune
                    { 1541828679uL, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 1480332470uL, Status.Incompatible }, // Polish Sirens Pack [V2.2]
                    { 1436056719uL, Status.Incompatible }, // Kaguki's Realistic Akihabara Sounds
                    { 1398060749uL, Status.Incompatible }, // Evo's Korean Sound Overhaul [v0.1d]
                    { 1327734238uL, Status.Incompatible }, // Deutsche Martinshörner für Ambient Sounds Tuner 2.0
                    { 1316748022uL, Status.Incompatible }, // Martinshorn/ vormals V10 Siren
                    { 939566479uL , Status.Incompatible }, // Bee's North America Sound Pack
                    { 925211833uL , Status.Incompatible }, // K's Old Siren Pack
                    { 917009851uL , Status.Incompatible }, // Swedish 1970 Siren Mod
                    { 899063611uL , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 887588790uL , Status.Incompatible }, // Japanese Sound MOD
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 768213484uL , Status.Incompatible }, // Subtle Bulldozing, Dragging and More!
                    { 555026832uL , Status.Compatible   }, // UK Sound Pack
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    // incompat: [ARIS] Remove Cows
                    // incompat: [ARIS] Remove Pigs
                    // incompat: [ARIS] Remove Seagulls
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Compatible   }, // V10Siren
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // approx Dec 2016
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // approx Jan 2017
                      | ItemFlags.Obsolete // replacement mod available
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("30 Sep, 2015"), // based on last github commit
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Creating sound packs (outdated): https://github.com/Archomeda/csl-ambient-sounds-tuner/wiki/Creating%20Sound%20Packs" },
                },
                Published = WorkshopDate("5 Jun, 2015"),
                Removed = WorkshopDate("4 Sep, 2018"), // web archive
                ReplaceWith = 818641631uL, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/Archomeda/csl-ambient-sounds-tuner",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" }, // add more
                Updated = WorkshopDate("30 Sep, 2015"), // based on last github commit
            });

            // obsolete
            AddMod(new Review(435167188uL, "V10Siren") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "V10lator",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053925580uL, Status.Incompatible }, // Philippines Sound MOD 2K20 (PSM)
                    { 1999271351uL, Status.Incompatible }, // 0xyl0nSoundPackUSA
                    { 1982045897uL, Status.Incompatible }, // (for backup)TwotoolusFLY's Siren mod
                    { 1979269356uL, Status.Incompatible }, // Swedish Emergency Vehicle Sirens - Sound Pack
                    { 1977435537uL, Status.Incompatible }, // OxylonEuroSoundpackSWE
                    { 1974722022uL, Status.Incompatible }, // Grand Theft Auto Mission Passed On Upgrade
                    { 1969438995uL, Status.Incompatible }, // OxylonEuroSoundpackITA
                    { 1969435641uL, Status.Incompatible }, // OxylonEuroSoundpackFRA
                    { 1969432061uL, Status.Incompatible }, // OxylonEuroSoundpackNED
                    { 1969428208uL, Status.Incompatible }, // OxylonEuroSoundpackAUT
                    { 1969411916uL, Status.Incompatible }, // OxylonEuroSoundpackGER
                    { 1961235713uL, Status.Incompatible }, // Grand Theft Auto Sirens
                    { 1764439209uL, Status.Incompatible }, // DB Announcer
                    { 1729946947uL, Status.Incompatible }, // Austrian Sirens
                    { 1719979486uL, Status.Incompatible }, // Philippines Realistic Sound Mod: Return!
                    { 1660065880uL, Status.Incompatible }, // Pre-War Sirens
                    { 1636310959uL, Status.Incompatible }, // NS Sound Pack for Ambient Sounds Tuner
                    { 1629745074uL, Status.Incompatible }, // ÖBB Sound Pack for Ambient Sounds Tuner
                    { 1628985258uL, Status.Incompatible }, // CFF Sound Pack for Ambient Sounds Tuner
                    { 1624184698uL, Status.Incompatible }, // SBB Sound Pack for Ambient Sounds Tune
                    { 1541828679uL, Status.Incompatible }, // CNSoundPack V0.2.2
                    { 1480332470uL, Status.Incompatible }, // Polish Sirens Pack [V2.2]
                    { 1436056719uL, Status.Incompatible }, // Kaguki's Realistic Akihabara Sounds
                    { 1398060749uL, Status.Incompatible }, // Evo's Korean Sound Overhaul [v0.1d]
                    { 1327734238uL, Status.Incompatible }, // Deutsche Martinshörner für Ambient Sounds Tuner 2.0
                    { 1316748022uL, Status.Incompatible }, // Martinshorn/ vormals V10 Siren
                    { 939566479uL , Status.Incompatible }, // Bee's North America Sound Pack
                    { 925211833uL , Status.Incompatible }, // K's Old Siren Pack
                    { 917009851uL , Status.Incompatible }, // Swedish 1970 Siren Mod
                    { 899063611uL , Status.Incompatible }, // UK Sound Pack -- Updated 2.0
                    { 887588790uL , Status.Incompatible }, // Japanese Sound MOD
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 555026832uL , Status.Incompatible }, // UK Sound Pack
                    // incompat: SilenceObnoxiousSirens (no longer in workshop)
                    { 455958878uL , Status.Compatible   }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // use Ambinet Sounds Tuner 2.0
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("1 May, 2015"),
                ReplaceWith = 818641631uL, // Ambient Sounds Tuner 2.0
                SourceURL = "https://github.com/V10lator/V10Siren",
                Tags = new[] { "Audio", "Sound", "Sirens", "Police", "Fire", "Ambulance" },
                Updated = WorkshopDate("21 Jun, 2018"),
            });
        }
    }
}
