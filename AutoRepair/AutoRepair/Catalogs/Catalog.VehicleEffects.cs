namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines vehicle effect packs.
    ///
    /// See also: <c>Catalog.AudioEffects</c> - some of those packs additionally contain vehicle effects.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void VehicleEffectMods() {

            string catalog = "VehicleEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Review(1649747813uL, "No Reverb Mod") {
                Affect = Factor.Audio,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125uL , Status.Incompatible }, // Extra Vehicle Effects (has same feature)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/Acc3ssViolation/67c8b829db76e0a81c02ee18995abb2c",
                Tags = new[] { "Audio", "Reverb", "Sounds", "Effects", "Vehicles" },
            });

            AddMod(new Review(815103125uL, "Extra Vehicle Effects (Plugin for Vehicle Effects Mod)") {
                Affect = Factor.Audio
                       | Factor.Rendering
                       | Factor.Vehicles,
                Authors = "Thaok",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1999271351uL, Status.MinorIssues  }, // 0xyl0nSoundPackUSA
                    { 1977435537uL, Status.MinorIssues  }, // OxylonEuroSoundpackSWE
                    { 1969438995uL, Status.MinorIssues  }, // OxylonEuroSoundpackITA
                    { 1969435641uL, Status.MinorIssues  }, // OxylonEuroSoundpackFRA
                    { 1969432061uL, Status.MinorIssues  }, // OxylonEuroSoundpackNED
                    { 1969428208uL, Status.MinorIssues  }, // OxylonEuroSoundpackAUT
                    { 1969411916uL, Status.MinorIssues  }, // OxylonEuroSoundpackGER
                    { 1764439209uL, Status.MinorIssues  }, // DB Announcer
                    { 1649747813uL, Status.Incompatible }, // No Reverb Mod
                    { 1636310959uL, Status.MinorIssues  }, // NS Sound Pack for Ambient Sounds Tuner
                    { 1629745074uL, Status.MinorIssues  }, // ÖBB Sound Pack for Ambient Sounds Tuner
                    { 1628985258uL, Status.MinorIssues  }, // CFF Sound Pack for Ambient Sounds Tuner
                    { 1624184698uL, Status.MinorIssues  }, // SBB Sound Pack for Ambient Sounds Tune
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1436056719uL, Status.MinorIssues  }, // Kaguki's Realistic Akihabara Sounds
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 887588790uL , Status.MinorIssues  }, // Japanese Sound MOD
                    { 818641631uL , Status.MinorIssues  }, // Ambinet Sounds Tuner 2.0
                    { 815103125uL , Status.Incompatible }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects 1.9.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Asset creators) Custom effects: https://steamcommunity.com/workshop/filedetails/discussion/815103125/152391285467044728/" },
                    { 818641631uL , "[Mod: Ambinet Sounds Tuner] If 'Disable rail service sounds' is selected in 'Extra Vehicle Effects' mod, you won't hear the sounds at station." },
                },
                Published = WorkshopDate("9 Dec, 2016"),
                SourceURL = "https://github.com/Thaok/ExtraVehicleEffects",
                Updated = WorkshopDate("26 Oct, 2017"),
            });

            AddMod(new Review(780720853uL, "Vehicle Effects 1.9.0") {
                Affect = Factor.Audio
                       | Factor.Rendering
                       | Factor.Vehicles,
                Authors = "Acc3ss Violation, Thaok",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1548831935uL, Status.Recommended  }, // Advanced Vehicles Options (reduce accel and braking)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 815103125uL , Status.Recommended  }, // Extra Vehicle Effects
                    { 780720853uL , Status.Incompatible }, // Vehicle Effects 1.9.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Asset creators) Custom sound effects: https://steamcommunity.com/workshop/filedetails/discussion/780720853/1620600279667837781/" },
                    { NOTE, "(Asset creators) Custom particle effects: https://steamcommunity.com/workshop/filedetails/discussion/780720853/1697167355211924591/" },
                },
                Published = WorkshopDate("14 Oct, 2016"),
                SourceURL = "https://github.com/Acc3ssViolation/VehicleEffects/",
                Updated = WorkshopDate("25 Apr, 2020"),
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            // https://drive.google.com/file/d/1ATs9XRlt9oCVOazyqFn5h0S517b7BN1L/view
            AddMod(new Review(2008325200uL, "Vehicle Effects Definition Pack DBAG") {
                Affect = Factor.Audio,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1548831935uL, Status.Recommended }, // Advanced Vehicles Options (reduce accel and braking)
                    { 815103125uL , Status.Required    }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required    }, // Vehicle Effects
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "de",
                Tags = new[] {
                    "Audio", "Sounds", "Effects", "Vehicles",
                    "Germany", "Deutsche", "Europe",
                    "Trains", "Zug", "DB", "AG", "Bundesbahn", "Reichsbahn",
                },
            });

            AddMod(new Review(1541828679uL, "CNSoundPack V0.2.2") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "言绥",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1548831935uL, Status.Recommended  }, // Advanced Vehicles Options (reduce accel and braking)
                    { 815103125uL , Status.Required     }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects
                    { 818641631uL , Status.Recommended  }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188uL , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "zh-cn",
                Tags = new[] {
                    "Audio", "Sounds", "Effects", "Vehicles",
                    "China", "Chinese",
                    "Trains", "Fuxing", "EMU", "CR", "Aircraft",
                },
            });

            AddMod(new Review(843220538uL, "Vehicle Effects Definition Pack (IC3, Y2)") {
                Affect = Factor.Audio,
                Authors = "Von Roth",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125uL , Status.Recommended  }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects
                    // supported vehicles:
                    { 629739002uL , Status.Recommended  }, // DSB IC3 Gray/Blue - 3 cars
                    { 629740314uL , Status.Recommended  }, // DSB IC3 Gray/Blue - 6 cars
                    { 607442454uL , Status.Recommended  }, // IC3 - DSB 3 cars Red/White
                    { 607467264uL , Status.Recommended  }, // IC3 - DSB 6 cars Red/White
                    { 607456665uL , Status.Recommended  }, // Y2 - Kustpilen 3 cars (old livery)
                    { 607471160uL , Status.Recommended  }, // Y2 - Kustpilen 6 cars (old livery)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "da", "no", "sv-se" },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("15 Jan, 2017"),
                Updated = WorkshopDate("15 Jan, 2017"),
            });

            AddMod(new Review(833784103uL, "Vehicle Effect Definitions for BR Class 43 (aka Intercity 125 / HST)") {
                Affect = Factor.Audio,
                Authors = "Thaok",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125uL , Status.Recommended  }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects
                    // supported vehicles:
                    { 472472119uL , Status.Recommended  }, // British Rail Class 43 Trainset (Intercity 125 Livery)
                    { 473701384uL , Status.Recommended  }, // British Rail Class 43 Trainset (Swallow Livery)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "en-gb",
                Published = WorkshopDate("3 Jan, 2017"),
                Updated = WorkshopDate("3 Jan, 2017"),
            });

            AddMod(new Review(820681113uL, "Vehicle Effects Definition Pack (NS 2200)") {
                Affect = Factor.Audio,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125uL , Status.Recommended  }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects
                    // supported vehicles:
                    { 558294131uL , Status.Recommended  }, // NS 2200 Tanker Train
                    { 553702245uL , Status.Recommended  }, // NS 2200 Passenger Train
                    { 551161964uL , Status.Recommended  }, // NS 2200 Mixed Cargo
                    { 549655765uL , Status.Recommended  }, // NS 2200 Coal Train
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "nl",
                Published = WorkshopDate("18 Dec, 2016"),
                Updated = WorkshopDate("18 Dec, 2016"),
            });

            AddMod(new Review(816529586uL, "Vehicle Effects Definition Pack (NS 6400)") {
                Affect = Factor.Audio,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125uL , Status.Recommended  }, // Extra Vehicle Effects
                    { 780720853uL , Status.Required     }, // Vehicle Effects
                    // supported vehicles:
                    { 1847502920uL, Status.Recommended  }, // Class 6400 (Railion) with SGGRSS (Pack3)
                    { 1847502295uL, Status.Recommended  }, // Class 6400 (Railpro) with SGGRSS (Pack2)
                    { 1722070204uL, Status.Recommended  }, // Class 6400 (DB) with ZACENS (11 Trailers)
                    { 1720372673uL, Status.Recommended  }, // Class 6400 Creator Pack
                    { 581361285uL , Status.Recommended  }, // LTE 6400 Gas Tanker Train
                    { 520396381uL , Status.Recommended  }, // LTE 6400 Coal Hopper Train
                    { 520297024uL , Status.Recommended  }, // DB 6400 Coal Hopper Train (Long)
                    { 516172560uL , Status.Recommended  }, // DB 6400 Forestry Train
                    { 501990901uL , Status.Recommended  }, // Railion 6400 Ballast Train
                    { 500984466uL , Status.Recommended  }, // NS 6400 Coal Train
                    { 499772720uL , Status.Recommended  }, // NS 6400 Garbage Train
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "nl",
                Published = WorkshopDate("11 Dec, 2016"),
                Updated = WorkshopDate("19 Jan, 2018"),
            });
        }
    }
}
