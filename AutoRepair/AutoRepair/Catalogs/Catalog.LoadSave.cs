namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that affect loading process.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        ///
        /// TODO:
        /// * Add authors.
        /// </summary>
        private void LoadSaveMods() {
            string catalog = "LoadSave";

            AddMod(new Review(1818482110u, "Change Loading Image 2") {
                Affect = Factor.LoadSaveExit,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 431125814u, Status.Incompatible }, // ChangeLoadingImage (original version)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/ChangeLoadingImage",
            });

            // todo: check if source still obfu
            AddMod(new Review(1675213439u, "No Intro") {
                Affect = Factor.LoadSaveExit,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1665106193u, Status.Incompatible }, // Skip Intro
                    // tmpe?
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1665106193u, "Skip Intro") {
                Affect = Factor.LoadSaveExit,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1675213439u, Status.Incompatible }, // No Intro
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-SkipIntro",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1733593614u, "Immediate Continue") {
                Affect = Factor.LoadSaveExit,
                Authors = "Dendraspis",
                BrokenBy = GameVersion.ParadoxLauncher,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // 1.12.3
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete, // vanilla has this since launcher update
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Paradox Launcher app now allows you to 'Resume' your last save." },
                    { NOTE, "Alternatively, you can use '--continuelastsave' launch option to get same result." },
                },
            });

            // Completely redundant mod as vanilla has auto-save
            AddMod(new Review(1225712349u, "406123642") {
                Affect = Factor.LoadSaveExit,
                Authors = "丿CK独狼灬",
                Catalog = catalog,
                CloneOf = 406123642u, // AutoSave - Configurable
                Compatibility = new Dictionary<ulong, Status>() {
                    { 406123642u, Status.Incompatible }, // AutoSave - Configurable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Auto-save feature is now part of base game. Unsubscribe this mod." },
                },
            });

            AddMod(new Review(408905948u, "Pause on load") {
                Affect = Factor.LoadSaveExit,
                Authors = "MrLawbreaker",
                BrokenBy = GameVersion.SunsetHarbor, // has native pause on load feature
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: The base game now has pause on load feature, you can unsubscribe this mod." },
                },
                ReleasedDuring = GameVersion.InitialRelease,
                SourceURL = "https://github.com/MrLawbreaker/SkylinesMod_PauseOnLoad",
            });
        }
    }
}
