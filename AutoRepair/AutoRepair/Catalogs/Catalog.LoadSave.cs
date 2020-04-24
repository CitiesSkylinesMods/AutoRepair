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

            AddMod(new Review(833779378uL, "Loading Screen Mod [Test]") {
                Affect = Factor.LoadSaveExit,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1386697922uL, Status.MinorIssues  }, // Garbage Bin Controller
                    { 1383456057uL, Status.Incompatible }, // Shicho
                    { 833779378uL , Status.Incompatible }, // Loading Screen Mod [Test]
                    { 667342976uL , Status.Incompatible }, // Loading Screen Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 667342976uL, // Loading Screen Mod
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable
                      | ItemFlags.SourceOudated,
                Languages = new[] { "en", "zh-cn" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is the test verison of the mod, where new features are beta tested." },
                    { NOTE, "If you need maximum reliability, use the other verison of the mod instead." },
                    { NOTE, "How to find & fix broken/bloated assets: https://steamcommunity.com/sharedfiles/filedetails/?id=1846793796" },
                    { NOTE, "Asset creators, see: https://steamcommunity.com/workshop/filedetails/discussion/667342976/1636416951459546732" },
                },
                Published = WorkshopDate("3 Jan, 2017"),
                ReplaceWith = 667342976uL, // Loading Screen Mod
                SourceURL = "https://github.com/thale5/LSM",
                SuppressOlderReplacementWarning = true,
                Updated = WorkshopDate("26 Mar, 2020"),
            });

            AddMod(new Review(667342976uL, "Loading Screen Mod") {
                Affect = Factor.LoadSaveExit,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1386697922uL, Status.MinorIssues  }, // Garbage Bin Controller
                    { 1383456057uL, Status.Incompatible }, // Shicho
                    { 833779378uL , Status.Incompatible }, // Loading Screen Mod [Test]
                    { 667342976uL , Status.Incompatible }, // Loading Screen Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.Recommended
                      | ItemFlags.SourceAvailable
                      | ItemFlags.SourceOudated,
                Languages = new[] { "en", "zh-cn" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To fix broken savegames: https://steamcommunity.com/workshop/filedetails/discussion/667342976/1626286205707786286/" },
                    { NOTE, "Find & fix broken/bloated assets: https://steamcommunity.com/sharedfiles/filedetails/?id=1846793796" },
                    { NOTE, "Asset creators, see: https://steamcommunity.com/workshop/filedetails/discussion/667342976/1636416951459546732" },
                    { NOTE, "More guides here: https://steamcommunity.com/sharedfiles/filedetails/discussions/667342976" },
                },
                Published = WorkshopDate("17 Apr, 2016"),
                SourceURL = "https://github.com/thale5/LSM",
                Updated = WorkshopDate("26 Mar, 2020"),
            });

            AddMod(new Review(411821214u, "Pause on no focus/Alt-Tab") {
                Affect = Factor.LoadSaveExit,
                Authors = "MrLawbreaker",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("22 Mar, 2015"),
                SourceURL = "https://github.com/MrLawbreaker/SkylinesMod_PauseOnNoFocus/",
                Updated = WorkshopDate("22 Mar, 2015"),
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
                    { NOTE, "Sunset Harbor: The base game now has pause on load feature; unsubscribe this mod." },
                },
                Published = WorkshopDate("16 Mar, 2015"),
                SourceURL = "https://github.com/MrLawbreaker/SkylinesMod_PauseOnLoad",
                Updated = WorkshopDate("16 Mar, 2015"),
            });
        }
    }
}
