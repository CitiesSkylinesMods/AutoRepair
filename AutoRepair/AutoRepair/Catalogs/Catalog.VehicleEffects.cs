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

            AddMod(new Review(1649747813, "No Reverb Mod") {
                Affect = Factor.Audio,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 815103125u, Status.Incompatible }, // Extra Vehicle Effects (has same feature)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/Acc3ssViolation/67c8b829db76e0a81c02ee18995abb2c",
                Tags = new[] { "Audio", "Reverb", "Sounds", "Effects", "Vehicles" },
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            // https://drive.google.com/file/d/1ATs9XRlt9oCVOazyqFn5h0S517b7BN1L/view
            AddMod(new Review(2008325200u, "Vehicle Effects Definition Pack DBAG") {
                Affect = Factor.Audio,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1548831935u, Status.Recommended }, // Advanced Vehicles Options (reduce accel and braking)
                    { 815103125u , Status.Required    }, // Extra Vehicle Effects
                    { 780720853u , Status.Required    }, // Vehicle Effects
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Audio", "Sounds", "Effects", "Vehicles",
                    "Germany", "Deutsche", "Europe",
                    "Trains", "Zug", "DB", "AG", "Bundesbahn", "Reichsbahn",
                },
            });

            AddMod(new Review(1541828679u, "CNSoundPack V0.2.2") {
                Affect = Factor.Audio
                       | Factor.Environment,
                Authors = "言绥",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1548831935u, Status.Recommended  }, // Advanced Vehicles Options (reduce accel and braking)
                    { 815103125u , Status.Required     }, // Extra Vehicle Effects
                    { 780720853u , Status.Required     }, // Vehicle Effects
                    { 818641631u , Status.Recommended  }, // Ambient Sounds Tuner 2.0
                    { 455958878u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 435167188u , Status.Incompatible }, // V10Siren
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
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
                Locale = "en-gb",
                Published = WorkshopDate("3 Jan, 2017"),
                Updated = WorkshopDate("3 Jan, 2017"),
            });
        }
    }
}
