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

            AddMod(new Review(1869777403uL, "TimeWarp Fix 时间光照控制 Sakuya16个人汉化") {
                Affect = Factor.Timeflow,
                Alternatives = new[] {
                    1870670690uL, // Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版
                    814698320uL , // Time Warp Fix
                    672248733uL , // Ultimate Eyecandy
                },
                Authors = "Izayoi _Sakuya16",
                Catalog = catalog,
                CloneOf = 814698320uL, // Time Warp Fix
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870670690uL, Status.Incompatible }, // Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版
                    { 1869777403uL, Status.Incompatible }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 814698320uL , Status.Incompatible }, // TimeWarp Fix
                    { 672248733uL , Status.Incompatible }, // Ultimate Eye Candy (does same thing)
                    { 629713122uL , Status.MinorIssues  }, // Climate Control 1.2.7.0
                    { 524021335uL , Status.Incompatible }, // Time Warp (original)
                    { 456408505uL , Status.Incompatible }, // European Buildings Unlocker (+vice versa) [ DEPRECATED ]
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.MinorIssues
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "zh-cn", "en", "de", "it", "nl" },
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To use this mod, the day/night cycle must be enabled in game settings." },
                    { NOTE, "May cause slight flickering effect on some graphics cards (never noticed it personally, but some users had problems)." },
                    { NOTE, "May conflict with time slider in asset editor (please let auberine18 know if this is the case via the Mod Compatibility Checker workshop page)." },
                    { 1591417160uL, "[Mod: Hide It!] Do not hide the 'Zoom button' otherwise it might cause TimeWarp Fix mod to crash." },
                    { 1420955187uL, "[Mod: Real Time] The mods are compatible: Real Time will pause game when you Time Warp; when game is unpaused, time will revert to normal." },
                    { 672248733uL , "[Mod: Ultimate Eye Candy] Both mods do similar thing; use one, unsubscribe the other." },
                    { 629713122uL , "[Mod: Climate Control] If 'Alter day length' option is enabled, it causes issues with city lighting and day/night cycle." },
                },
                Published = WorkshopDate("22 Sep, 2019"),
                Updated = WorkshopDate("22 Sep, 2019"),
            });

            AddMod(new Review(814698320uL, "TimeWarp Fix") {
                Affect = Factor.Timeflow,
                Alternatives = new[] {
                    1869777403uL, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    672248733uL , // Ultimate Eyecandy
                },
                Authors = "boldhedgehog",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870670690uL, Status.Incompatible }, // Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版
                    { 1869777403uL, Status.Incompatible }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 814698320uL , Status.Incompatible }, // TimeWarp Fix
                    { 672248733uL , Status.Incompatible }, // Ultimate Eye Candy (does same thing)
                    { 629713122uL , Status.MinorIssues  }, // Climate Control 1.2.7.0
                    { 524021335uL , Status.Incompatible }, // Time Warp (original)
                    { 456408505uL , Status.Incompatible }, // European Buildings Unlocker (+vice versa) [ DEPRECATED ]
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 524021335uL, // Time Warp (original)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking
                      | ItemFlags.MinorIssues
                      | ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "de", "it", "nl" },
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Video of the mod from original author: https://www.youtube.com/watch?v=iYbJyRpNniw" },
                    { NOTE, "To use this mod, the day/night cycle must be enabled in game settings." },
                    { NOTE, "May cause slight flickering effect on some graphics cards (never noticed it personally, but some users had problems)." },
                    { NOTE, "May conflict with time slider in asset editor (please let auberine18 know if this is the case via the Mod Compatibility Checker workshop page)." },
                    { 1591417160uL, "[Mod: Hide It!] Do not hide the 'Zoom button' otherwise it might cause TimeWarp Fix mod to crash." },
                    { 1420955187uL, "[Mod: Real Time] The mods are compatible: Real Time will pause game when you Time Warp; when game is unpaused, time will revert to normal." },
                    { 672248733uL , "[Mod: Ultimate Eye Candy] Both mods do similar thing; use one, unsubscribe the other." },
                    { 629713122uL , "[Mod: Climate Control] If 'Alter day length' option is enabled, it causes issues with city lighting and day/night cycle." },
                },
                Published = WorkshopDate("8 Dec, 2016"),
                SourceURL = "https://github.com/boldhedgehog/TimeWarp",
                Updated = WorkshopDate("30 May, 2017"),
            });

            // original
            // https://web.archive.org/web/20170602224846/http://steamcommunity.com/id/LisaLionheart/myworkshopfiles/?appid=255710
            AddMod(new Review(524021335uL, "Time Warp") {
                Affect = Factor.Timeflow,
                Alternatives = new[] {
                    672248733uL, // Ultimate Eyecandy
                },
                ArchiveURL = "https://web.archive.org/web/20161229200834/http://steamcommunity.com:80/sharedfiles/filedetails/?id=524021335",
                Authors = "LisaLionheart",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1870670690uL, Status.Incompatible }, // Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版
                    { 1869777403uL, Status.Incompatible }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 814698320uL , Status.Incompatible }, // TimeWarp Fix
                    { 672248733uL , Status.Incompatible }, // Ultimate Eye Candy (does same thing)
                    { 629713122uL , Status.Incompatible }, // Climate Control 1.2.7.0
                    { 524021335uL , Status.Incompatible }, // Time Warp (original)
                    { 456408505uL , Status.Incompatible }, // European Buildings Unlocker (+vice versa) [ DEPRECATED ]
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "de", "it", "nl" },
                LastSeen = WorkshopDate("29 Dec, 2016"), // based on comments shown in web archive
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Video of the mod from original author: https://www.youtube.com/watch?v=iYbJyRpNniw" },
                },
                Published = WorkshopDate("24 Sep, 2015"), // based on adjacent item and web archive
                Removed = WorkshopDate("21 Aug, 2017"), // based on web archive
                ReplaceWith = 814698320uL, // TimeWarp Fix
                SourceURL = "https://github.com/lisa-lionheart/TimeWarp",
                Updated = WorkshopDate("30 Oct, 2015"), // based on web archive
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

            AddMod(new Review(932490392uL, "Track My Time") {
                Affect = Factor.Other,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("25 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TrackMyTime",
                Updated = WorkshopDate("25 May, 2017"),
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
            AddMod(new Review(1985556066uL, "4546") {
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

            AddMod(new Review(1899943042uL, "No Scaffolding Animation") {
                Affect = Factor.Construction,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    // rico?
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 924884948uL, // Plop the Growables
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("27 Oct, 2019"),
                Updated = WorkshopDate("27 Oct, 2019"),
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
                BrokenBy = GameVersion.DefaultRelease,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning // 165 MB
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe. It's a zip of old mods translated to Chinese, most of them don't work." },
                },
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("10 Sep, 2019"),
                Suppress = Warning.InvalidVersionSequence,
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            AddMod(new Review(1749971558uL, "Real Time Offline") {
                Affect = Factor.Aging
                       | Factor.Boredom
                       | Factor.Construction
                       | Factor.Consumption
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Entertainment
                       | Factor.Environment
                       | Factor.Production
                       | Factor.Rendering
                       | Factor.TileLimit
                       | Factor.Timeflow
                       | Factor.Timerate
                       | Factor.TransportPreference,
                Authors = "Gness Erquint",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                // NOTE:
                // The offline version has differenet compatibility vectors than the original online version
                // primarily because it's offline and thus can't reliably idenfity other mods (nor they it).
                Compatibility = new Dictionary<ulong, Status>() {
                    // technical conflicts (cause severe loss of funcitonality or crashes):
                    { 1911736890uL, Status.MinorIssues  }, // 1181352643 District Service Limit 3 (see note for DSL 3.0 below)
                    { 1893036262uL, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1729576238uL, Status.Incompatible }, // Date Changer
                    { 1420955187uL, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 1181352643uL, Status.MinorIssues  }, // District Service Limit 3.0 (citizen limiting features directly conflict with RT)
                    { 702070768uL , Status.Incompatible }, // Export Electricity
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                    { 629713122uL , Status.Incompatible }, // Climate Control
                    { 605590542uL , Status.Incompatible }, // Rush Hour II
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    // age change (lifespan balance issues):
                    { 2027161563uL, Status.MinorIssues  }, // Lifecycle Rebalance Revisited
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.MinorIssues  }, // Lifespan Changer Fix
                    { 654707599uL , Status.MinorIssues  }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.MinorIssues  }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.MinorIssues  }, // Lifespan Changer
                    { 571655171uL , Status.MinorIssues  }, // Randomize Age Cims Move in
                    { 541673195uL , Status.MinorIssues  }, // Resident Travel Rebalance v1.1:
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509uL , Status.MinorIssues  }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.MinorIssues  }, // Very Slow Citizen Aging
                    { 409070218uL , Status.MinorIssues  }, // Slow Citizen Aging
                    // construction change (construction time/period/animation issues):
                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1899943042uL, Status.Incompatible }, // No Scaffolding Animation
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 924884948uL , Status.MinorIssues  }, // Plop the Growables
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 523818382uL , Status.MinorIssues  }, // Force Level Up
                    { 466158459uL , Status.MinorIssues  }, // Building Themes
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // time change (daily schedule issues):
                    { 1869777403uL, Status.Incompatible }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1899449152uL, Status.Incompatible }, // Game Day Timer (it can't recognise offline realtime)
                    { 814698320uL , Status.MinorIssues  }, // TimeWarp Fix (game will pause when used, time resets when unpaused)
                    { 672248733uL , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2 (game will pause when used, time resets when unpaused)
                    // other
                    { 1801953480uL, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1412844620uL, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1420955187uL, // Real Time (original by dymanoid)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("24 May, 2019"),
                ReplaceWith = 1420955187uL, // Real Time (original by dymanoid)
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("7 Nov, 2019"),
            });

            AddMod(new Review(1706703944uL, "More Outside Interaction") {
                Affect = Factor.Employment
                       | Factor.Service,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1911736890uL, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("8 Apr, 2019"),
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
                Updated = WorkshopDate("3 May, 2020"),
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

            AddMod(new Review(1420955187uL, "Real Time") {
                Affect = Factor.Aging
                       | Factor.Boredom
                       | Factor.Construction
                       | Factor.Consumption
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Entertainment
                       | Factor.Environment
                       | Factor.Production
                       | Factor.Rendering
                       | Factor.TileLimit
                       | Factor.Timeflow
                       | Factor.Timerate
                       | Factor.TransportPreference,
                Authors = "dymanoid",
                Catalog = catalog,
                // NOTE:
                // Online version has different compatibility vectors to the offline clone version.
                Compatibility = new Dictionary<ulong, Status>() {
                    // technical conflicts (cause severe loss of funcitonality or crashes):
                    { 1911736890uL, Status.MinorIssues  }, // 1181352643 District Service Limit 3 (see note for DSL 3.0 below)
                    { 1893036262uL, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1432430887uL, Status.Incompatible }, // Rush Hour II (Development)
                    { 1420955187uL, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 1181352643uL, Status.MinorIssues  }, // District Service Limit 3.0 (citizen limiting features, if enabled, directly conflict with RT)
                    { 702070768uL , Status.Incompatible }, // Export Electricity
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                    { 605590542uL , Status.Incompatible }, // Rush Hour II
                    // conceptual conflict: boredom
                    { 1776052533uL, Status.Compatible   }, // Stops & Stations
                    { 1766839841uL, Status.MinorIssues  }, // Anxiety Reducer (still testing)
                    // possibly optimised outside connections which increases time until bored
                    // conceptual conflict: time
                    { 1869777403uL, Status.Incompatible }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1899449152uL, Status.Compatible   }, // Game Day Timer (switches to different mode for Real Time)
                    { 1729576238uL, Status.Incompatible }, // Date Changer
                    { 814698320uL , Status.MinorIssues  }, // TimeWarp Fix
                    { 672248733uL , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2
                    { 629713122uL , Status.Incompatible }, // Climate Control
                    { 781767563uL , Status.MinorIssues  }, // Extended InfoPanel - has options to set time, also replaces time progress bar
                    // conceptual coflict: aging
                    { 2027161563uL, Status.Compatible   }, // Lifecycle Rebalance Revisited
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 877402994uL , Status.MinorIssues  }, // Lifespan Changer Fix
                    { 654707599uL , Status.Compatible   }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.MinorIssues  }, // Lifespan multiplier v1.1
                    { 573925048uL , Status.MinorIssues  }, // Lifespan Changer
                    { 571655171uL , Status.MinorIssues  }, // Randomize Age Cims Move in
                    { 541673195uL , Status.MinorIssues  }, // Resident Travel Rebalance v1.1:
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509uL , Status.MinorIssues  }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.MinorIssues  }, // Very Slow Citizen Aging
                    { 409070218uL , Status.MinorIssues  }, // Slow Citizen Aging
                    // conceptual conflict: construction
                    { 2016920607uL, Status.Compatible   }, // RICO revisited
                    { 1899943042uL, Status.MinorIssues  }, // No Scaffolding Animation
                    { 1614061108uL, Status.Compatible   }, // Real Construction
                    { 1204126182uL, Status.MinorIssues  }, // Ploppable Rico High Density Fix
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 924884948uL , Status.MinorIssues  }, // Plop the Growables
                    { 586012417uL , Status.MinorIssues  }, // Ploppable RICO (original)
                    { 523818382uL , Status.MinorIssues  }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                    // toolbar (time bar):
                    { 888017364uL , Status.MinorIssues  }, // Quartz (Sapphire) - Fixed 1.11
                    { 576970398uL , Status.MinorIssues  }, // Quartz (former Sapphire) - UI skin framework
                    { 421770876uL , Status.MinorIssues  }, // Sapphire - UI skin framework
                    // other
                    { 2048266761uL, Status.MinorIssues  }, // Building Usage
                    { 1801953480uL, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1412844620uL, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Locale = "en",
                Languages = new[] { "de", "en", "es", "fr", "it", "ja", "ko", "pl", "pt", "ru", "zh" },
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The 'Better citizen aging' option has a big influence on how education works." },
                    { 2048266761uL, "[Mod: Building Usage] Building Usage mod does not account for worker variations due to Real Time shifts." },
                    { 1911736890uL, "[Mod: District Service Limit] Disable its citizen-limiting options to make compatible with Real Time." },
                    { 1801953480uL, "[Mod: Natural Disasters Overhaul] Real Time changes time flow, causuing excessive thunder storms." },
                    { 1204126182uL, "[Mod: Ploppable RICO] Old versions of the mod sometimes report zero construction time which crashes Real Time." },
                    { 924884948uL , "[Mod: Plop the Growables] If plopped buildings disappear, set 'Construction speed' to 100% in Real Time." },
                    { 814698320uL , "[Mod: TimeWarp Fix] Game will pause when you change time, time will revert when game unpaused." },
                    { 672248733uL , "[Mod: Ultimate Eye Candy] Game will pause when you change time, time will revert when game unpaused." },
                    { 649522495uL , "[Mod: District Service Limit] Disable its citizen-limiting options to make compatible with Real Time." },
                    { 629713122uL , "[Mod: Climate Control] It breaks the citizen schedules in Real Time." },
                    { 586012417uL , "[Mod: Ploppable RICO] Old versions of the mod sometimes report zero construction time which crashes Real Time." },
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/dymanoid/RealTime",
            });

            AddMod(new Review(1386697922uL, "Garbage Bin Controller") {
                Affect = Factor.Props
                       | Factor.Emptying,
                Authors = "Arnold J. Rimmer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1390252175uL, Status.Recommended }, // Japanese Plastic Bucket
                    { 1389908178uL, Status.Recommended }, // Wheelie Bin - Color Variation
                    { 1386088603uL, Status.Recommended }, // Metal bin - 01
                    // LSM skipping vanilla garbage bin = game breaking
                    { 2045011960uL, Status.MinorIssues }, // Loading Screen 中文版
                    { 1894425170uL, Status.MinorIssues }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.MinorIssues }, // 加载优化 Loading Screen
                    { 833779378uL , Status.MinorIssues }, // Loading Screen Mod [Test]
                    { 667342976uL , Status.MinorIssues }, // Loading Screen Mod
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