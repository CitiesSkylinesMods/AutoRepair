namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that alter time, or rate of time flow, construciton time, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void TimeMods() {

            string catalog = "Time";

            AddMod(new Review(2090425593uL, "Game Speed mod") {
                Affect = Factor.Construction
                       | Factor.Aging
                       | Factor.Money
                       | Factor.Timerate,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.HardMode, Status.Incompatible }, // Vanilla
                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Vanilla

                    { 2045011960uL, Status.Compatible   }, // Loading Screen 中文版
                    { 2039606384uL, Status.Incompatible }, // Easy Mode: Money Mod
                    { 2039205403uL, Status.Incompatible }, // Free Maintenance by Anvilarse
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2016920607uL, Status.Unknown      }, // RICO revisited
                    { 1899943042uL, Status.Incompatible }, // No Scaffolding Animation
                    { 1894425170uL, Status.Compatible   }, // Loading Screen Mod 汉化版
                    { 1860379049uL, Status.Incompatible }, // 加载优化 Loading Screen
                    { 1830455071uL, Status.Incompatible }, // EasyMode
                    { 1801953480uL, Status.Compatible   }, // Natural Disasters Overhaul
                    { 1751039059uL, Status.Compatible   }, // Taxes Helper Mod
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1744522363uL, Status.Incompatible }, // Money Back (Refund)
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1598546349uL, Status.Incompatible }, // Mary's Mod
                    { 1541897355uL, Status.Compatible   }, // Total Autobudget
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 1403960464uL, Status.Incompatible }, // Maintenance Fees (Parklife Ready)
                    { 1398502258uL, Status.Incompatible }, // Dam Upkeep Scaling
                    { 1237383751uL, Status.Compatible   }, // Extended Game Options
                    { 1227735337uL, Status.Incompatible }, // Full Refund Cost[Industries Compatible]
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 1196714522uL, Status.Incompatible }, // 居民衰老变十六分之一
                    { 1108715012uL, Status.Incompatible }, // Adjustable Business Consumption
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 838095079uL , Status.Incompatible }, // Cheaper Hydro Electric Power
                    { 833779378uL , Status.Compatible   }, // Loading Screen Mod (TEST)
                    { 667342976uL , Status.Compatible   }, // Loading Screen Mod
                    { 654707599uL , Status.Incompatible }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403uL , Status.Incompatible }, // Lifespan multiplier v1.1
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO (original)
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 571655171uL , Status.Incompatible }, // Randomize Age Cims Move in
                    { 541673195uL , Status.Incompatible }, // Resident Travel Rebalance v1.1:
                    { 519781146uL , Status.Incompatible }, // Difficulty Tuning
                    { 421188880uL , Status.Incompatible }, // [ARIS] Early Death
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409071509uL , Status.Incompatible }, // Slow Citizen Aging Configurable
                    { 409070739uL , Status.Incompatible }, // Very Slow Citizen Aging
                    { 409070218uL , Status.Incompatible }, // Slow Citizen Aging
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("9 May, 2020"),
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Game-Speed",
                Updated = WorkshopDate("9 May, 2020"),
            });

            AddMod(new Review(1899943042uL, "No Scaffolding Animation") {
                Affect = Factor.Construction,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
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
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
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

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

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
                    { 2090425593uL, Status.Incompatible }, // Game Speed mod
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
        }
    }
}