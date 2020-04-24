namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Camera mods and first person cameras.
    ///
    /// Note: Not same as Catalog.CameraScripts!.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void CameraMods() {

            string catalog = "Camera";

            // Camera control via SpaceMouse
            AddMod(new Review(2021361606u, "SpaceMouse for CSL") {
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
                Published = WorkshopDate("13 Mar, 2020"),
                SourceURL = "https://github.com/graealex/CSL-SpaceMouse",
                Updated = WorkshopDate("13 Mar, 2020"),
            });

            // Stereoscopic camera (split screen)
            AddMod(new Review(1828737770u, "StereoscopicView") {
                Affect = Factor.Camera,
                Authors = "eelcobaas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    //{ 1828737770u, Status.Incompatible }, // StereoscopicView
                    //{ 1492317158u, Status.Incompatible }, // 第一人称视角
                    //{ 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    //{ 651056665u , Status.Incompatible }, // Enhanced Zoom Continued (no longer in workshop)
                    //{ 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    //{ 411016892u , Status.Incompatible }, // Enhanced Zoom (no longer in workshop)
                    //{ 406255342u , Status.Incompatible }, // First-person camera
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues // mouse pointer and underground view borked
                      | ItemFlags.SourceBundled,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press left Ctr + T to toggle the stereoscopic camera view." },
                },
                Published = WorkshopDate("8 Aug, 2019"),
                Updated = WorkshopDate("25 Aug, 2019"),
                UserModInspected = true,
            });

            AddMod(new Review(1756089251u, "Zoom It!") {
                Affect = Factor.Camera,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible   }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible   }, // Zoom It!
                    { 1721824249u, Status.Compatible   }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible   }, // NoOffScreenScroll
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("30 May, 2019"),
                SourceURL = "https://github.com/keallu/CSL-ZoomIt",
                Updated = WorkshopDate("3 Jul, 2019"),
            });

            // Camera control by joystick
            AddMod(new Review(1721824249u, "Joystick Camera Control") {
                Affect = Factor.Camera,
                Authors = "Rena",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2021361606u, Status.Compatible }, // SpaceMouse for CSL
                    { 1756089251u, Status.Compatible }, // Zoom It!
                    { 1721824249u, Status.Compatible }, // Joystick Camera Control
                    { 1721823173u, Status.Compatible }, // NoOffScreenScroll
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("24 Apr, 2019"),
                SourceURL = "https://github.com/RenaKunisaki/CSL-JoystickCameraControl",
                Updated = WorkshopDate("24 Mar, 2020"),
            });

            AddMod(new Review(1721823173u, "NoOffScreenScroll") {
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
                Published = WorkshopDate("24 Apr, 2019"),
                SourceURL = "https://github.com/RenaKunisaki/CSL-NoOffScreenScroll",
                Updated = WorkshopDate("24 Apr, 2019"),
            });

            // todo: move to driving category
            AddMod(new Review(1518296436u, "Driving Mod") {
                Affect = Factor.Camera
                       | Factor.Vehicles,
                Authors = "WULF1045",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: test with TMPE
                },
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("21 Sep, 2018"),
                Updated = WorkshopDate("21 Sep, 2018"),
            });

            AddMod(new Review(1406625743u, "EnhancedZoomContinued") {
                Affect = Factor.Camera,
                Authors = "UguuDoki",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 898480258u , Status.Unknown      }, // Camera Positions Utility
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                    { 409359952u , Status.Incompatible }, // Isometric Camera
                    { 406297458u , Status.Incompatible }, // Camera Additions (Rightclick scroll & save camera positions)
                },
                ContinuationOf = 651056665u, // Enhanced Zoom Continued
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://steamcommunity.com/workshop/filedetails/discussion/1406625743/1728711392724061143/" },
                },
                Published = WorkshopDate("9 Jun, 2018"),
                SourceURL = "https://drive.google.com/file/d/1n9Bga69WamgKPk8rsWDjdJOSEJBTLNId",
                Updated = WorkshopDate("9 Jun, 2018"),
            });

            AddMod(new Review(898480258u, "Camera Positions Utility") {
                Affect = Factor.Camera,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Unknown      }, // EnhancedZoomContinued
                    { 651056665u , Status.Compatible   }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom (orig)
                    { 406297458u , Status.Incompatible }, // Camera Additions (Rightclick scroll & save camera positions)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Save camera position: Ctrl + Shift + 1-9 or Ctrl + Shift + F1-12" },
                    { NOTE, "Return to position: Ctrl + 1-9 or Ctrl + F1-12" },
                    { NOTE, "Return to position when game was saved: Ctrl + Home" },
                    { NOTE, "Face down and north: Alt + R" },
                    { NOTE, "Rotate X-axis: Ctrl + Shift + X and Ctrl + X" },
                    { NOTE, "Rotate Y-axis: Ctrl + Shift + Y and Ctrl + Y" },
                    { NOTE, "Hold Alt while rotating to go in steps of 45° (default 15°)" },
                    { NOTE, "Change FOV: Ctrl + Shift + Up/Down; Reset FOV: Ctrl + Shift + Left" },
                    { NOTE, "Hold Alt while changing FOV to go in steps of 1 (defult 5)" },
                    { NOTE, "Asset editor: Center camera with Ctrl + Shift + C" },
                    { NOTE, "Asset editor: Isometric projection with Ctrl + Shift + I" },
                    { NOTE, "Sunset Harbor: Auto-saved position may act weirdly as vanilla game now has same feature." },
                    { 1406625743u, "[Mod: Enhanced Zoom Continued] Compatbility is unknown with this version of EZC; let me know if it works." },
                    { 651056665u , "[Mod: Enhanced Zoom Continued] Compatible, but FOV options in Camera Positions Utility will be disabled." },
                },
                Published = WorkshopDate("4 Apr, 2017"),
                Updated = WorkshopDate("4 Apr, 2018"),
            });

            AddMod(new Review(844180955u, "City Drive") {
                Affect = Factor.Camera
                       | Factor.Vehicles,
                Authors = "yole.karif",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1492317158uL, Status.Incompatible }, // 第一人称视角
                    { 1406625743uL, Status.Incompatible }, // EnhancedZoomContinued
                    { 1317859996uL, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 651056665uL , Status.Incompatible }, // Enhanced Zoom Continued
                    { 650805785uL , Status.Incompatible }, // First Person Camera: Updated
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 411016892uL , Status.Incompatible }, // Enhanced Zoom
                    { 406255342uL , Status.Incompatible }, // First-person camera
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://steamcommunity.com/workshop/filedetails/discussion/844180955/1479857071252874461/" },
                    { NOTE, "A few 'HD' car assets: https://steamcommunity.com/sharedfiles/filedetails/?id=1182824413" },
                },
                Published = WorkshopDate("17 Jan, 2017"),
                Updated = WorkshopDate("26 Oct, 2017"),
            });

            AddMod(new Review(650805785u, "First Person Camera: Updated") {
                Affect = Factor.Camera,
                Authors = "tony56a",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 406255342u, // First-person camera
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("23 Mar, 2016"),
                SourceURL = "https://github.com/tony56a/Skylines-FPSCamera/tree/1.4.0-fix",
                Updated = WorkshopDate("16 Apr, 2020"),
            });

            AddMod(new Review(602077938u, "TotalyFree Camera") {
                Affect = Factor.Camera,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812713438u , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 411016892u , Status.Compatible   }, // Enhanced Zoom (orig)
                    { 406629464u , Status.Incompatible }, // Dynamic Resolution
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                },
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("16 Jan, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TotalyFreeCamera",
                Updated = WorkshopDate("27 May, 2017"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1492317158u, "第一人称视角") {
                Affect = Factor.Camera,
                Authors = "Ling Youqiang",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                CloneOf = 406255342u, // First-person camera
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 844180955u , Status.Incompatible }, // City Drive
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
                Published = WorkshopDate("25 Aug, 2018"),
                ReplaceWith = 650805785u, // First Person Camera: Updated
                ReleasedDuring = GameVersion.ParkLife,
                Locale = "zh-cn",
                SuppressVersionWarnings = true, // it was long broken when added to workshop lol
                Updated = WorkshopDate("25 Aug, 2018"),
            });

            // literally an exact copy of 650805785u
            AddMod(new Review(1317859996u, "650805785 First Person Camera_ Updated") {
                Affect = Factor.Camera,
                Authors = "KoLoNyAlı MeNdİL",
                Catalog = catalog,
                CloneOf = 650805785u, // First Person Camera: Updated
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406255342u , Status.Incompatible }, // First-person camera
                },
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // reported by users
                      | ItemFlags.Obsolete // use 650805785u which is maintained
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("2 Mar, 2018"),
                ReplaceWith = 650805785u, // First Person Camera: Updated
                Updated = WorkshopDate("2 Mar, 2018"),
            });

            AddMod(new Review(651056665u, "Enhanced Zoom Continued") {
                Affect = Factor.Camera,
                ArchiveURL = "https://web.archive.org/web/20170406042531/http://steamcommunity.com/sharedfiles/filedetails/?id=651056665",
                Authors = "cylon33",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 898480258u , Status.Compatible   }, // Camera Positions Utility
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                    { 409359952u , Status.Incompatible }, // Isometric Camera
                    { 406297458u , Status.Incompatible }, // Camera Additions (Rightclick scroll & save camera positions)
                },
                ContinuationOf = 411016892u, // Enhanced Zoom
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // broke by game update years ago
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable
                      | ItemFlags.SourceOudated, // git repo removed
                Published = WorkshopDate("23 Mar, 2016"),
                ReplaceWith = 1406625743u, // EnhancedZoomContinued
                SourceURL = "https://github.com/vukivan/EnhancedZoomContinued",
                Updated = WorkshopDate("12 Dec, 2016"),
            });

            AddMod(new Review(411016892u, "Enhanced Zoom") {
                Affect = Factor.Camera,
                ArchiveURL = "https://web.archive.org/web/20150325043452/https://steamcommunity.com/sharedfiles/filedetails/?id=411016892",
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 898480258u , Status.Incompatible }, // Camera Positions Utility
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 602077938u , Status.Compatible   }, // TotalyFree Camera
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                    { 409359952u , Status.Incompatible }, // Isometric Camera
                    { 406297458u , Status.Incompatible }, // Camera Additions (Rightclick scroll & save camera positions)
                },
                ContinuationOf = 410610814u, // Farther Zoom (full zoom in)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // broke by game update years ago
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("24 Mar, 2015"),
                ReplaceWith = 1406625743u, // EnhancedZoomContinued
                Updated = WorkshopDate("26 Sep, 2015"),
            });

            // found via wayback machine looking at h_e's profile
            AddMod(new Review(410610814u, "Farther Zoom (full zoom in)") {
                Affect = Factor.Camera,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1756089251u, Status.Incompatible }, // Zoom It!
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 602077938u , Status.Incompatible }, // TotalyFree Camera
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                },
                ContinuationOf = 410227672u, // Farther Zoom
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // broke by game update years ago
                      | ItemFlags.NoWorkshop // existed 21 Dec 2018
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("19 Mar, 2015"), // from comments on 410227672u
                ReplaceWith = 1756089251u, // Zoom It!
                SuppressArchiveWarning = true,
                Updated = WorkshopDate("19 Mar, 2015"), // guesstimate
            });

            AddMod(new Review(410227672u, "Farther Zoom") {
                Affect = Factor.Camera,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1756089251u, Status.Incompatible }, // Zoom It!
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 602077938u , Status.Incompatible }, // TotalyFree Camera
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410610814u , Status.Incompatible }, // Farther Zoom (full zoom in)
                    { 410227672u , Status.Incompatible }, // Farther Zoom
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("19 Mar, 2015"),
                ReplaceWith = 1756089251u, // Zoom It!
                Updated = WorkshopDate("19 Mar, 2015"),
            });

            // discovered via: https://steamcommunity.com/workshop/filedetails/discussion/410329674/611701360830851903/
            AddMod(new Review(409359952u, "Isometric Camera") {
                Affect = Factor.Rendering,
                ArchiveURL = "https://web.archive.org/web/20150415004447/http://steamcommunity.com/sharedfiles/filedetails/?id=409359952",
                Authors = "Ulysius",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870740367u, Status.Incompatible }, // Dynamic Resolution 动态分辨率 Sakuya16个人汉化版
                    { 1794015399u, Status.Incompatible }, // Render It!
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 1138510774u, Status.Incompatible }, // PostProcessFX - Multi-platform
                    { 934825735u , Status.Incompatible }, // Ambient Occlusion (TBP)
                    { 933513277u , Status.Incompatible }, // Sun Shafts (current)
                    { 812713438u , Status.Incompatible }, // Dynamic Resolution (Fixed for 1.9!)
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                    { 410805639u , Status.Compatible   }, // Sun Shafts (old)
                    { 410329674u , Status.Incompatible }, // Ambient Occlusion (orig)
                    { 410196151u , Status.Compatible   }, // Bordered Skylines (Fixed for Mass Transit!)
                    { 409359952u , Status.Incompatible }, // Isometric Camera (orig)
                    { 408648436u , Status.Compatible   }, // More Options
                    { 406629464u , Status.Compatible   }, // Dynamic Resolution (old)

                    // todo: incompatible with first person cameras
                },
                Flags = ItemFlags.Abandonware
                      //| ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press F8 to open the options panel." },
                },
                Published = WorkshopDate("17 Mar, 2015"), // guessed from 409359950 (NSFW!!)
                Updated = WorkshopDate("23 Mar, 2015"), // WBM shows 11 updates, but steam did not show updated date back then
            });

            AddMod(new Review(406940119u, "Camera Buttons") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150329012553/http://steamcommunity.com/profiles/76561198179273381/myworkshopfiles/?appid=255710",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-CameraButtons",
                Updated = WorkshopDate("8 Apr, 2015"), // guessing based on other mods by same author
            });

            AddMod(new Review(406297458u, "Camera Additions (Rightclick scroll & save camera positions)") {
                Affect = Factor.Camera,
                Authors = "WalrusPug",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1406625743u, Status.Incompatible }, // EnhancedZoomContinued
                    { 898480258u , Status.Incompatible }, // Camera Positions Utility
                    { 651056665u , Status.Incompatible }, // Enhanced Zoom Continued
                    { 411016892u , Status.Incompatible }, // Enhanced Zoom
                },
                CompatibleWith = GameVersion.Patch_1_10_1_f3,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Hold right mouse button and drag to scroll the map." },
                    { NOTE, "Map scrolling: Ctrl + Shift + O to toggle on/off, Ctrl + Shift + I to invert direction." },
                    { NOTE, "Hold Ctrl, Shift or Alt to temporarily disable map scrolling feature." },
                    { NOTE, "Camera positions: Ctrl + Shift + 0-9 to save, Ctrl + 0-9 to return." },
                    { NOTE, "Scrolling sensitivity controlled by game options 'Edge Scrolling Sensitivity' slider." },
                },
                Published = WorkshopDate("11 Mar, 2015"),
                ReplaceWith = 898480258u, // Camera Positions Utility
                Updated = WorkshopDate("18 Mar, 2015"),
            });

            AddMod(new Review(406326408u, "HideUI") {
                Affect = Factor.Camera,
                Authors = "nlight",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 406255342u , Status.Compatible  }, // First-person camera
                },
                CompatibleWith = GameVersion.MassTransit,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // vanilla
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press F11 to toggle UI." },
                    { NOTE, "Vanilla game now has free camera mode, press Tab in-game to activate it." },
                },
                Published = WorkshopDate("11 Mar, 2015"),
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-HideUI/",
                Updated = WorkshopDate("8 Apr, 2015"),
            });

            AddMod(new Review(406255342u, "First-person camera") {
                Affect = Factor.Camera,
                Authors = "nlight",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1492317158u, Status.Incompatible }, // 第一人称视角
                    { 1317859996u, Status.Incompatible }, // 650805785 First Person Camera_ Updated
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 650805785u , Status.Incompatible }, // First Person Camera: Updated
                    { 406326408u , Status.Compatible   }, // HideUI
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
                Published = WorkshopDate("11 Mar, 2015"),
                ReplaceWith = 650805785u, // First Person Camera: Updated
                ReleasedDuring = GameVersion.EuropeBiome,
                SourceURL = "https://github.com/AlexanderDzhoganov/Skylines-FPSCamera/",
                Updated = WorkshopDate("7 Apr, 2015"),
            });
        }
    }
}
