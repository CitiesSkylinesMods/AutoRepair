namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Defines vehicle effect packs.
    ///
    /// See also: <c>Catalog.AudioEffects</c>.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void VehicleEffectsCatalog() {

            string catalog = "VehicleEffects";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Item(1649747813, "No Reverb Mod") {
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
            AddMod(new Item(2008325200u, "Vehicle Effects Definition Pack DBAG") {
                Affect = Factor.Audio,
                Authors = "Oxylon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1548831935u, Status.Recommended }, // Advanced Vehicles Options (reduce accel and braking)
                    { 815103125u , Status.Required    }, // Extra Vehicle Effects
                    { 780720853u , Status.Required    }, // Vehicle Effects
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de",
                Tags = new[] {
                    "Audio", "Sounds", "Effects", "Vehicles",
                    "Germany", "Deutsche", "Europe",
                    "Trains", "Zug", "DB", "AG", "Bundesbahn", "Reichsbahn",
                },
            });

            AddMod(new Item(1541828679u, "CNSoundPack V0.2.2") {
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
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                Tags = new[] {
                    "Audio", "Sounds", "Effects", "Vehicles",
                    "China", "Chinese",
                    "Trains", "Fuxing", "EMU", "CR", "Aircraft",
                },
            });

        }
    }
}
