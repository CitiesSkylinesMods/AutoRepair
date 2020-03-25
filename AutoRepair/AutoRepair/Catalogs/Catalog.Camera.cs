namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Camera mods.
    ///
    /// Note: Not same as Catalog.CameraScripts!.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void CameraCatalog() {

            string catalog = "Camera";

            // Camera control via SpaceMouse
            AddMod(new Item(2021361606u, "SpaceMouse for CSL") {
                Affect = Factor.Camera,
                Authors = "alex",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible }, // Zoom It!
                    { 1721824249u, Status.Compatible }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible }, // NoOffScreenScroll
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/graealex/CSL-SpaceMouse",
            });

            // Stereoscopic camera (split screen)
            AddMod(new Item(1828737770u, "StereoscopicView") {
                Affect = Factor.Camera,
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1828737770u, Status.Incompatible }, // StereoscopicView
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued (no longer in workshop)
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom (no longer in workshop)
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                Flags = ItemFlags.MinorBugs // mouse pointer and underground view borked
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1756089251u, "Zoom It!") {
                Affect = Factor.Camera,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible }, // Zoom It!
                    { 1721824249u, Status.Compatible }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible }, // NoOffScreenScroll
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-ZoomIt",
            });

            // Camera control by joystick
            AddMod(new Item(1721824249u, "Joystick Camera Control") {
                Affect = Factor.Camera,
                Authors = "Rena",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible }, // Zoom It!
                    { 1721824249u, Status.Compatible }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible }, // NoOffScreenScroll
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/RenaKunisaki/CSL-JoystickCameraControl",
            });

            AddMod(new Item(1721823173u, "NoOffScreenScroll") {
                Affect = Factor.Camera,
                Authors = "Rena",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible }, // Zoom It!
                    { 1721824249u, Status.Compatible }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible }, // NoOffScreenScroll
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/RenaKunisaki/CSL-NoOffScreenScroll",
            });

            AddMod(new Item(1406625743u, "EnhancedZoomContinued") {
                Affect = Factor.Camera,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                },
                ContinuationOf = 651056665u, // Enhanced Zoom Continued
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://drive.google.com/file/d/1n9Bga69WamgKPk8rsWDjdJOSEJBTLNId",
            });

            AddMod(new Item(650805785u, "First Person Camera: Updated") {
                Affect = Factor.Camera,
                Authors = "tony56a",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                ContinuationOf = 406255342u, // First-person camera
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/tony56a/Skylines-FPSCamera/tree/1.4.0-fix",
            });

            AddMod(new Item(1518296436u, "Driving Mod") {
                Affect = Factor.Camera
                       | Factor.Vehicles,
                Authors = "WULF1045",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: test with TMPE
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1492317158u, "第一人称视角") {
                Affect = Factor.Camera,
                Authors = "Ling Youqiang",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                CloneOf = 406255342u, // First-person camera
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                CompatibleWith = GameVersion.AfterDark,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // unable to exit first person cam (Esc not working)
                ReplaceWith = 650805785u, // First Person Camera: Updated
                ReleasedDuring = GameVersion.ParkLife,
                Locale = "zh-cn",
                SkipVersionValidation = true, // it was long broken when added to workshop lol
            });

            // literally an exact copy of 650805785u
            AddMod(new Item(1317859996u, "650805785 First Person Camera_ Updated") {
                Affect = Factor.Camera,
                Authors = "KoLoNyAlı MeNdİL",
                Catalog = catalog,
                CloneOf = 650805785u, // First Person Camera: Updated
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.Obsolete // use 650805785u which is maintained
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 650805785u, // First Person Camera: Updated
            });

            AddMod(new Item(651056665u, "Enhanced Zoom Continued") {
                Affect = Factor.Camera,
                Authors = "cylon33",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                },
                ContinuationOf = 411016892u, // Enhanced Zoom
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // broke by game update years ago
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1406625743u, // EnhancedZoomContinued
                SourceURL = "https://github.com/vukivan/EnhancedZoomContinued",
            });

            AddMod(new Item(411016892u, "Enhanced Zoom") {
                Affect = Factor.Camera,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // broke by game update years ago
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1406625743u, // EnhancedZoomContinued
            });

            AddMod(new Item(406255342u, "First-person camera") {
                Affect = Factor.Camera,
                Authors = "nlight",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                CompatibleWith = GameVersion.AfterDark,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration // Snowfall
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // Many users not able to exit from fp cam view (Esc not working)
                ReplaceWith = 650805785u, // First Person Camera: Updated
                ReleasedDuring = GameVersion.EuropeBiome,
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-FPSCamera/",
            });
        }
    }
}
