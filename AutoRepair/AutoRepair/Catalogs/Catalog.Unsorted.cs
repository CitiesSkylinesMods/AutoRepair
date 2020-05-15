namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using UnityEngine;

    /// <summary>
    /// This is just a temporary place to store items prior to moving them in to
    /// more logical catalogs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void UnsortedMods() {

            string catalog = "Unsorted";

            AddMod(new Review(1751039059u, "Taxes Helper Mod") {
                Affect = Factor.Budget
                       | Factor.Money,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Compatible   }, // Game Speed mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("25 May, 2019"),
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Tax-Helper",
                Updated = WorkshopDate("25 May, 2019"),
            });

            AddMod(new Review(411253368uL, "Steam notification mover") {
                Affect = Factor.UI,
                Authors = "(unknown)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                },
                CompatibleWith = GameVersion.Patch_1_0_6b,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 Nov, 2016"), // was linked to from 794268416uL
                Published = WorkshopDate("21 Mar, 2015"), // based on adjacent item
                Removed = WorkshopDate("9 Jul, 2018"), // based on wayback showing green redirect
                ReplaceWith = 794268416uL, // Steamy - More Steam controls
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("21 Mar, 2015"), // unable to determine if there were any updates
            });

            AddMod(new Review(814102166uL, "Image Overlay") {
                Affect = Factor.UI,
                Authors = "Lanceris",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1864205702uL, Status.Incompatible }, // 地图图片叠加 Image Overlay
                    { 814102166uL , Status.Incompatible }, // Image Overlay
                    { 662933818uL , Status.Incompatible }, // OverLayer v2
                    { 421400880uL , Status.Incompatible }, // BetterImageOverlay
                    { 413748580uL , Status.Incompatible }, // ImageOverlay
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 421400880uL, // BetterImageOverlay
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Template PNG image with all tiles marked: https://i.imgur.com/12u8Jm7.png" },
                    { NOTE, "Some users report the keyboard shortcuts no longer work; but it does work for other users." },
                    { NOTE, "Image must be valid PNG file for the mod to work; try different colour depth and make dimensions 'power of 2' (see wikipedia) for best results." },
                    { NOTE, "It needs to load image from disk; if you get 'Unauthorized Access' violantion, try running game as Administrator user." },
                },
                Published = WorkshopDate("7 Dec, 2016"),
                SourceURL = "https://github.com/lanceris/EvenBetterImageOverlay",
                Updated = WorkshopDate("19 Jul, 2018"),
            });

            AddMod(new Review(421400880uL, "BetterImageOverlay") {
                Affect = Factor.UI,
                Authors = "Omegote",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1864205702uL, Status.Incompatible }, // 地图图片叠加 Image Overlay
                    { 814102166uL , Status.Incompatible }, // Image Overlay
                    { 662933818uL , Status.Incompatible }, // OverLayer v2
                    { 421400880uL , Status.Incompatible }, // BetterImageOverlay
                    { 413748580uL , Status.Incompatible }, // ImageOverlay
                },
                CompatibleWith = GameVersion.Stadiums,
                ContinuationOf = 413748580uL, // ImageOverlay
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("7 Apr, 2015"),
                ReplaceWith = 814102166uL, // Image Overlay
                Updated = WorkshopDate("7 Apr, 2015"),
            });

            AddMod(new Review(413748580uL, "ImageOverlay") {
                Affect = Factor.UI,
                Authors = "Play Nicely",
                BrokenBy = GameVersion.NaturalDisasters, // possibly earlier (1.7.?)
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1864205702uL, Status.Incompatible }, // 地图图片叠加 Image Overlay
                    { 814102166uL , Status.Incompatible }, // Image Overlay
                    { 662933818uL , Status.Incompatible }, // OverLayer v2
                    { 421400880uL , Status.Incompatible }, // BetterImageOverlay
                    { 413748580uL , Status.Incompatible }, // ImageOverlay
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("26 Mar, 2015"),
                ReplaceWith = 814102166uL, // Image Overlay
                Updated = WorkshopDate("26 Mar, 2015"),
            });

            AddMod(new Review(662933818uL, "OverLayer v2") {
                Affect = Factor.UI,
                Authors = "princekolt",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1864205702uL, Status.Incompatible }, // 地图图片叠加 Image Overlay
                    { 814102166uL , Status.Incompatible }, // Image Overlay
                    { 662933818uL , Status.Incompatible }, // OverLayer v2
                    { 421400880uL , Status.Incompatible }, // BetterImageOverlay
                    { 413748580uL , Status.Incompatible }, // ImageOverlay
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Template PNG image with all tiles marked: https://i.imgur.com/12u8Jm7.png" },
                    { NOTE, "Some users report the keyboard shortcuts no longer work; but it does work for other users." },
                    { NOTE, "Image must be valid PNG file for the mod to work; try different colour depth and make dimensions 'power of 2' (see wikipedia) for best results." },
                    { NOTE, "It needs to load image from disk; if you get 'Unauthorized Access' violantion, try running game as Administrator user." },
                },
                Published = WorkshopDate("10 Apr, 2016"),
                SourceURL = "https://github.com/brunophilipe/OverLayer",
                Updated = WorkshopDate("28 May, 2016"),
            });

            AddMod(new Review(1864205702uL, "地图图片叠加 Image Overlay") {
                Affect = Factor.UI,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 814102166uL, // Image Overlay
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1864205702uL, Status.Incompatible }, // 地图图片叠加 Image Overlay
                    { 814102166uL , Status.Incompatible }, // Image Overlay
                    { 662933818uL , Status.Incompatible }, // OverLayer v2
                    { 421400880uL , Status.Incompatible }, // BetterImageOverlay
                    { 413748580uL , Status.Incompatible }, // ImageOverlay
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("15 Sep, 2019"),
                Updated = WorkshopDate("15 Sep, 2019"),
            });


            AddMod(new Review(1623509958uL, "Real Gas Station") {
                Affect = Factor.Vehicles,
                Authors = "pcfantasy, Ciar Aon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040656402uL, Status.Required     }, // Harmony 2.0.0.9 (Mod Dependency)
                    { 1908304789uL, Status.Required     }, // Gas Station(w/o NE2) - required asset
                    { 1785774902uL, Status.Compatible   }, // Transfer Info (beta)
                    { 1739993783uL, Status.Incompatible }, // Cargo Info (Fix)
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1435741602uL, Status.Incompatible }, // Snooper
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1072157697uL, Status.Incompatible }, // Cargo Info
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("13 Jan, 2019"),
                SourceURL = "https://github.com/pcfantasy/RealGasStation",
                Updated = WorkshopDate("8 May, 2020"),
            });

            // https://github.com/pcfantasy/RealCity/blob/master/Resources/incompatible_mods.txt
            // https://steamcommunity.com/workshop/filedetails/discussion/1192503086/1488866180603720344/
            AddMod(new Review(1192503086uL, "Real City V9.0.03.14") {
                Affect = Factor.Employment
                       | Factor.Money,
                Authors = "pcfantasy, Singlewolf",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2040656402uL, Status.Required     }, // Harmony 2.0.0.9 (Mod Dependency)
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1893036262uL, Status.MinorIssues  }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1739993783uL, Status.Incompatible }, // Cargo Info (Fix)
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1562650024uL, Status.Incompatible }, // Rebalanced Industries
                    { 1553517176uL, Status.MinorIssues  }, // Specialized Industry Fix Redux
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1435741602uL, Status.Incompatible }, // Snooper
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1072157697uL, Status.Incompatible }, // Cargo Info
                    { 702070768uL , Status.MinorIssues  }, // Export Electricity
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 519781146uL , Status.Incompatible }, // Difficulty Tuning
                    { 409240984uL , Status.Incompatible }, // Difficulty Options
                    // todo: minor incompat - list money mods here
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Laggy // causes lag on big cities
                      | ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "ru", "zh", "zh-cn" }, // https://github.com/pcfantasy/RealCity/blob/master/Resources
                LastSeen = WorkshopDate("10 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("5 Nov, 2017"),
                SourceURL = "https://github.com/pcfantasy/RealCity/",
                Updated = WorkshopDate("5 May, 2020"),
            });

            AddMod(new Review(1312735149u, "[OUTDATED] Klyte Commons") {
                Affect = Factor.Other,
                Authors = "Klyte45",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1553517176uL, Status.Incompatible }, // Specialized Industry Fix Redux
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete // no longer required for any of Klyte mods
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod is no longer required, you can unsubscribe it." },
                    { NOTE, "This mod causes game to exit to desktop when trying to exit to Main Menu." },
                },
                Published = WorkshopDate("25 Feb, 2018"),
                SourceURL = "https://github.com/klyte45/KlyteCommons",
                Updated = WorkshopDate("9 Jun, 2019"),
            });



            AddMod(new Review(845665815uL, "CSL Map View") {
                Affect = Factor.Other,
                Authors = "Gansaku",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "de", "en", "fr", "ja", "ko", "ru", "zh-cn", "zh-tw" },
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Command line parameters: https://github.com/gansaku/CSLMapView/wiki/Command-line-parameters" },
                    { NOTE, "Translation resources: https://github.com/gansaku/CSLMapView/" },
                },
                Published = WorkshopDate("19 Jan, 2017"),
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            // OS compatibility for 845665815uL
            switch (Application.platform) {
                case RuntimePlatform.OSXPlayer:
                    Reviews[845665815uL].Notes.Add(NOTE, "This mod requires a Windows .exe file to work, it is not compatible with Mac OS/X.");
                    break;
                case RuntimePlatform.LinuxPlayer:
                    Reviews[845665815uL].Notes.Add(NOTE, "To run on Linux, see: https://steamcommunity.com/workshop/filedetails/discussion/845665815/1776010325130246251/");
                    break;
            }

            AddMod(new Review(856602624uL, "Sandiego") {
                Affect = Factor.Other,
                Authors = "Tailgunner",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // prolly incompat with all toolbar mods
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Double-clicking a building in build menus will center map camera on fist instance of that building." },
                    { NOTE, "This mod is probably incompatible with any mod that changes the toolbars (unconfirmed)." },
                },
                Published = WorkshopDate("4 Feb, 2017"),
                Updated = WorkshopDate("6 Feb, 2017"),
            });

            AddMod(new Review(878991312uL, "Prop It Up! v1.4.4") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props
                       | Factor.Trees
                       | Factor.UI,
                Authors = "Judazzz, BloodyPenguin",
                //BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      //| ItemFlags.BrokenByUpdate
                      | ItemFlags.Laggy
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Runs a lot of code in OnUpdate() = can cause lag in-game." },
                    { NOTE, "User guide: https://steamcommunity.com/workshop/filedetails/discussion/878991312/133259227529823319/" },
                    { NOTE, "Sunset Harbor: Sometimes causes errors when a save is loaded, but mod still seems to work after that." },
                    { NOTE, "Sunset Harbor: Some users say tree replacement features are broken." },
                    { NOTE, "Sunset Harbor: Some users say it crashes when replacing props." },
                },
                Published = WorkshopDate("7 Mar, 2017"),
                SourceURL = "https://github.com/Judazzz/CitiesSkylines-PropItUp",
                Updated = WorkshopDate("3 Mar, 2018"),
            });

            AddMod(new Review(911295408uL, "Prop Scaling 0.3 [Experimental ALPHA]") {
                Affect = Factor.Props,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod takes effect whilst placing props on the map:" },
                    { NOTE, "Press Ctrl + Up/Down to incease/decrease min scale." },
                    { NOTE, "Press Alt + Up/Down to incease/decrease max scale." },
                    { NOTE, "Press Ctrl + Alt + Up/Down to incease/decrease both min and max scale." },
                    { NOTE, "With shortcuts above, pressing Right arrow will increase/decrease faster." },
                    { NOTE, "Press Home to reset to default." },
                },
                Published = WorkshopDate("23 Apr, 2017"),
                Updated = WorkshopDate("5 May, 2017"),
            });

            AddMod(new Review(903347963uL, "Transparent Selectors") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Ronyx69, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.Incompatible }, // Toggle It!
                    { 1540147921uL, Status.Compatible   }, // Grid be Gone
                    { 1536223783uL, Status.Compatible   }, // Hide Selectors
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("11 Apr, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/e556609f78efd918aa5895261d38d78e",
                Updated = WorkshopDate("12 Apr, 2017"),
            });



            AddMod(new Review(2055972178uL, "Custom Zone Mixer") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2055972178uL, Status.Incompatible }, // Custom Zone Mixer
                    { 1800844556uL, Status.Incompatible }, // Zone Mixer 0 (Beta)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1800844556uL, // Zone Mixer 0 (Beta)
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Tutorial video explains how to use it, and also how to safely remove it without breaking save game: https://www.youtube.com/watch?v=_MAeV4mkAV8" },
                },
                Published = WorkshopDate("10 Apr, 2020"),
                SourceURL = "https://github.com/klyte45/ZoneMixer",
                Updated = WorkshopDate("11 Apr, 2020"),
                UserModInspected = true,
            });

            AddMod(new Review(1800844556uL, "Zone Mixer 0 (Beta)") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2055972178uL, Status.Incompatible }, // Custom Zone Mixer
                    { 1800844556uL, Status.Incompatible }, // Zone Mixer 0 (Beta)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // removed ~10 Apr 2020
                      | ItemFlags.Obsolete // replacement version available
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("26 Mar, 2020"),
                Published = WorkshopDate("12 Jul, 2019"), // based on adjacent workshop item
                Removed = WorkshopDate("10 Apr, 2020"),
                ReplaceWith = 2055972178uL, // Custom Zone Mixer
                SourceURL = "https://github.com/klyte45/ZoneMixer",
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("16 Jul, 2019"), // guess based on github commits
                UserModInspected = true,
            });

            AddMod(new Review(2044145894uL, "Dropouts Sunset Fix") {
                Affect = Factor.Education,
                Authors = "Bobinator The Destroyer!",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044145894uL, Status.Incompatible }, // Dropouts Sunset Fix
                    { 506982407uL , Status.Incompatible }, // Dropouts
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 506982407uL, // Dropouts
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Enacting the 'Education Boost' city/district policy will reduce number of dropouts." },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                SourceURL = "https://github.com/AbitFishy/CitiesSkylinesDropoutsModSunsetHarborFix",
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMod(new Review(506982407uL, "Dropouts") {
                Affect = Factor.Education,
                Authors = "FrF",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2044145894uL, Status.Incompatible }, // Dropouts Sunset Fix
                    { 506982407uL , Status.Incompatible }, // Dropouts
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Causes '.Citizen.m_age' errors which break game." },
                },
                Published = WorkshopDate("26 Aug, 2015"),
                ReplaceWith = 2044145894uL, // Dropouts Sunset Fix
                SourceURL = "https://github.com/markbt/CitiesSkylinesDropoutsMod",
                Updated = WorkshopDate("26 Aug, 2015"),
            });

            AddMod(new Review(2040656402uL, "Harmony") {
                Affect = Factor.Other,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is a dependency for multiple mods, do not remove." },
                },
                Published = WorkshopDate("30 Mar, 2020"),
                SourceURL = "https://github.com/boformer/CitiesHarmony",
                Updated = WorkshopDate("10 Apr, 2020"),
            });


            // looks like translated clone of Favorite Cims mod
            AddMod(new Review(1985556066uL, "4546 (Fav Cims)") {
                Affect = Factor.Other,
                Authors = "暮",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 426460372uL, // Favorite Cims
                Compatibility = new Dictionary<ulong, Status>() {
                    { 426460372uL, Status.Incompatible }, // Favorite Cims
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("1 Feb, 2020"),
                ReplaceWith = 426460372uL, // Favorite Cims
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("1 Feb, 2020"),
            });

            // Apparently creates some sort of biogas harvesting building that's
            // dependent on the number of plants in close proximity.
            AddMod(new Review(1920431318uL, "Biogas-pw") {
                Affect = Factor.Other,
                Authors = "dolaritar",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                // It changes building AI both in editor and game, but doesn't reset it for autosave, save or level unloading.
                // This will result in broken save games and will likely break assets published from asset editor.
                // Avoid until code is improved!
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.GameBreaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("24 Nov, 2019"),
                Updated = WorkshopDate("24 Nov, 2019"),
            });



            // mesures performance based on time it takes for a game day, and fps
            AddMod(new Review(1899449152uL, "Game Day Timer") {
                Affect = Factor.Other,
                Authors = "rcav8tr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("26 Oct, 2019"),
                SourceURL = "https://github.com/rcav8tr/GameDayTimer",
                Updated = WorkshopDate("15 Jan, 2020"),
            });

            AddMod(new Review(1859100867uL, "Klyte's Framework 1.1") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/KlyteFramework",
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("10 Sep, 2019"),
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            // Bundle of Chinese localised mods - will break your game
            AddMod(new Review(1812384654uL, "(no name specified)") {
                Affect = Factor.Other,
                Authors = "打的好不如排的好",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning // 165 MB
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe. It's a zip of old mods translated to Chinese, they are all broken by subsequent game updates." },
                },
                LastSeen = WorkshopDate("12 May, 2020"),
                Published = WorkshopDate("22 Jul, 2019"),
                Updated = WorkshopDate("22 Jul, 2019"),
            });

            AddMod(new Review(1614061108uL, "Real Construction") {
                Affect = Factor.Construction
                       | Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleLimit,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
                    { 2040656402uL, Status.Required     }, // Harmony 2.0.0.9 (Mod Dependency)
                    { 1908304237uL, Status.Required     }, // City Resource Building
                    { 1899943042uL, Status.Incompatible }, // No Scaffolding Animation
                    { 1785774902uL, Status.Compatible   }, // Transfer Info (beta)
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1739993783uL, Status.Incompatible }, // Cargo Info (Fix)
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1435741602uL, Status.Incompatible }, // Snooper
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 1072157697uL, Status.Incompatible }, // Cargo Info
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 408706691uL , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://steamcommunity.com/sharedfiles/filedetails/?id=1756860335" },
                },
                Published = WorkshopDate("4 Jan, 2019"),
                SourceURL = "https://github.com/pcfantasy/RealConstruction",
                Updated = WorkshopDate("20 Apr, 2020"),
            });

            AddMod(new Review(1383456057uL, "Shicho") {
                Affect = Factor.BuildingInfo
                       | Factor.Camera
                       | Factor.Health
                       | Factor.HideRemove
                       | Factor.Rendering
                       | Factor.Toolbar
                       | Factor.Trees
                       | Factor.VehicleInfo,
                ArchiveURL = "https://web.archive.org/web/20190102224333/https://steamcommunity.com/sharedfiles/filedetails/?id=1383456057",
                Authors = "saki7, Ryuichi Kaminogi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // removed between mar 26 and apr 26, 2020
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("26 Mar, 2020"),
                Published = WorkshopDate("11 May, 2018"),
                Removed = WorkshopDate("26 Apr, 2020"),
                SourceURL = "https://github.com/SETNAHQ/Shicho",
                Updated = WorkshopDate("27 Sep, 2018"),
            });


            AddMod(new Review(1386697922uL, "Garbage Bin Controller") {
                Affect = Factor.Props
                       | Factor.Emptying,
                Authors = "Arnold J. Rimmer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1390252175uL, Status.Recommended  }, // Japanese Plastic Bucket
                    { 1389908178uL, Status.Recommended  }, // Wheelie Bin - Color Variation
                    { 1386088603uL, Status.Recommended  }, // Metal bin - 01
                    // LSM skipping vanilla garbage bin = game breaking
                    { 2045011960uL, Status.MinorIssues  }, // Loading Screen 中文版
                    { 1894425170uL, Status.MinorIssues  }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.Incompatible }, // 加载优化 Loading Screen
                    { 833779378uL , Status.MinorIssues  }, // Loading Screen Mod [Test]
                    { 667342976uL , Status.MinorIssues  }, // Loading Screen Mod
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 833779378uL, "[Mod: Loading Screen Mod] If you get crashes, remove 'Garbage Bin' from your skip.txt file." },
                    { 667342976uL, "[Mod: Loading Screen Mod] If you get crashes, remove 'Garbage Bin' from your skip.txt file." },
                },
                ReleasedDuring = GameVersion.ParkLife,
            });

            // Known issues (based on author comment):
            // * Cannot see values that you set the offsets for
            // * Unable to save/load option settings
            // * Does not update visual budget panel, but does update budget in the background
            // Was previously named "Water and Electricity Controller".
            AddMod(new Review(1239683428uL, "Budget Controller") {
                Affect = Factor.Budget,
                Authors = "wboler05",
                Catalog = catalog,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                SourceURL = "https://github.com/wboler05/CS-BudgetController",
            });
        }
    }
}