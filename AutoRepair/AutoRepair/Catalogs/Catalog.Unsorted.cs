namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// This is just a temporary place to store items prior to moving them in to
    /// more logical catalogs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void UnsortedMods() {

            string catalog = "Unsorted";

            AddMod(new Review(895061550u, "Theme Decals") {
                Affect = Factor.MapThemes
                       | Factor.Props,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Unknown      }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 793346248u , Status.Recommended  }, // Decal Hover Area
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 767233815u , Status.Required     }, // Decal Prop Fix
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you see 'If you see this then the mod didn't work' the mod is either disabled or failed to initialise." },
                    { NOTE, "Changes to prop or distance, theme textures or graphics detail will likely require game restart for the decals to update." },
                    { NOTE, "Asset creators, script for creating decals: https://gist.github.com/ronyx69/69130ffd46ab3573f0968aedd11c88eb" },
                    { NOTE, "Asset creators, logo for asset icon: https://drive.google.com/open?id=0B6Ccf1N5h5f7ZE9laHg3cVY0aHM" },
                },
                Published = WorkshopDate("31 Mar, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/a3fff79130e59fd5b7210ed5228ab812",
                Updated = WorkshopDate("21 Aug, 2017"),
            });

            AddMod(new Review(911295408u, "Prop Scaling 0.3 [Experimental ALPHA]") {
                Affect = Factor.Props,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
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

            AddMod(new Review(903347963u, "Transparent Selectors") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Ronyx69, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396u, Status.Incompatible }, // Toggle It!
                    { 1540147921u, Status.Compatible   }, // Grid be Gone
                    { 1536223783u, Status.Compatible   }, // Hide Selectors
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("11 Apr, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/e556609f78efd918aa5895261d38d78e",
                Updated = WorkshopDate("12 Apr, 2017"),
            });

            AddMod(new Review(932490392u, "Track My Time") {
                Affect = Factor.Other,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("25 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TrackMyTime",
                Updated = WorkshopDate("25 May, 2017"),
            });

            AddMod(new Review(2055972178u, "Custom Zone Mixer") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2055972178u, Status.Incompatible }, // Custom Zone Mixer
                    { 1800844556u, Status.Incompatible }, // Zone Mixer 0 (Beta)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1800844556u, // Zone Mixer 0 (Beta)
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Tutorial video explains how to use it, and also how to safely remove it without breaking save game: https://www.youtube.com/watch?v=_MAeV4mkAV8" },
                },
                Published = WorkshopDate("10 Apr, 2020"),
                SourceURL = "https://github.com/klyte45/ZoneMixer",
                Updated = WorkshopDate("11 Apr, 2020"),
                UserModInspected = true,
            });

            AddMod(new Review(1800844556u, "Zone Mixer 0 (Beta)") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2055972178u, Status.Incompatible }, // Custom Zone Mixer
                    { 1800844556u, Status.Incompatible }, // Zone Mixer 0 (Beta)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // removed ~10 Apr 2020
                      | ItemFlags.Obsolete // replacement version available
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Jul, 2019"), // guess based on git repo creation date
                ReplaceWith = 2055972178u, // Custom Zone Mixer
                SourceURL = "https://github.com/klyte45/ZoneMixer",
                SuppressArchiveWarning = true,
                Updated = WorkshopDate("16 Jul, 2019"), // guess based on github commits
                UserModInspected = true,
            });

            AddMod(new Review(2053655383u, "Pretty Pixel's Trump Tweets") {
                Affect = Factor.UI,
                Authors = "Gerald",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with any chirper removers
                },
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("9 Apr, 2020"),
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            AddMod(new Review(2044145894u, "Dropouts Sunset Fix") {
                Authors = "Bobinator The Destroyer!",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 506982407u, Status.Incompatible }, // Dropouts
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 506982407u, // Dropouts
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is a temporary bug fix mod for Dropouts mod." },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                ReleasedDuring = GameVersion.SunsetHarbor,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMod(new Review(2040656402u, "Harmony") {
                Affect = Factor.Other,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is a dependency for multiple mods, do not remove." },
                },
                Published = WorkshopDate("30 Mar, 2020"),
                SourceURL = "https://github.com/boformer/CitiesHarmony",
                Updated = WorkshopDate("31 Mar, 2020"),
            });


            // looks like translated clone of Favorite Cims mod
            AddMod(new Review(1985556066u, "4546") {
                Affect = Factor.Other,
                Authors = "暮",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                CloneOf = 426460372u, // Favorite Cims
                Compatibility = new Dictionary<ulong, Status>() {
                    { 426460372u, Status.Incompatible }, // Favorite Cims
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                ReplaceWith = 426460372u, // Favorite Cims
            });

            // likely incompat with Customize It Extended
            AddMod(new Review(1865667356u, "Twitch Citizens") {
                Affect = Factor.Naming,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Unknown      }, // Customize It Extended
                    { 1369729955u, Status.Unknown      }, // Customize It!
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // Apparently creates some sort of biogas harvesting building that's
            // dependent on the number of plants in close proximity.
            AddMod(new Review(1920431318u, "Biogas-pw") {
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
            });

            // replaces bus shelters, likely incompat with similar mods
            AddMod(new Review(1900151000u, "替换为不锈钢公交候车亭") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "ZEIR",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // anything that alters bus stops
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/OwiHH-NC/4cefbd1fbc7ff7135c59",
            });

            AddMod(new Review(1899943042u, "No Scaffolding Animation") {
                Affect = Factor.Construction,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    // real construciton?
                    // plop growables?
                    // rico?
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
            });

            // mesures performance based on time it takes for a game day, and fps
            AddMod(new Review(1899449152, "Game Day Timer") {
                Affect = Factor.Other,
                Authors = "rcav8tr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/rcav8tr/GameDayTimer",
            });

            AddMod(new Review(1859100867u, "Klyte's Framework 1.1") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/KlyteFramework",
            });

            // Bundle of Chinese localised mods - will break your game
            AddMod(new Review(1812384654u, "(no name specified)") {
                Affect = Factor.Other,
                Authors = "打的好不如排的好",
                BrokenBy = GameVersion.DefaultRelease,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {},
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                SuppressVersionWarnings = true,
            });

            AddMod(new Review(1749971558u, "Real Time Offline") {
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
                Catalog = catalog,
                // NOTE:
                // The offline version has differenet compatibility vectors than the original online version
                // primarily because it's offline and thus can't reliably idenfity other mods (nor they it).
                Compatibility = new Dictionary<ulong, Status>() {
                    // technical conflicts (cause severe loss of funcitonality or crashes):
                    { 1911736890u, Status.MinorIssues  }, // 1181352643 District Service Limit 3 (see note for DSL 3.0 below)
                    { 1893036262u, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1729576238u, Status.Incompatible }, // Date Changer
                    { 1420955187u, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 1181352643u, Status.MinorIssues  }, // District Service Limit 3.0 (citizen limiting features directly conflict with RT)
                    { 702070768u , Status.Incompatible }, // Export Electricity
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 629713122u , Status.Incompatible }, // Climate Control
                    { 605590542u , Status.Incompatible }, // Rush Hour II
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    // age change (lifespan balance issues):
                    { 2027161563u, Status.MinorIssues  }, // Lifecycle Rebalance Revisited
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.MinorIssues  }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.MinorIssues  }, // Lifespan multiplier v1.1
                    { 573925048u , Status.MinorIssues  }, // Lifespan Changer
                    { 571655171u , Status.MinorIssues  }, // Randomize Age Cims Move in
                    { 541673195u , Status.MinorIssues  }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.MinorIssues  }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.MinorIssues  }, // Very Slow Citizen Aging
                    { 409070218u , Status.MinorIssues  }, // Slow Citizen Aging
                    // construction change (construction time/period/animation issues):
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1899943042u, Status.Incompatible }, // No Scaffolding Animation
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 924884948u , Status.MinorIssues  }, // Plop the Growables
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 523818382u , Status.MinorIssues  }, // Force Level Up
                    { 466158459u , Status.MinorIssues  }, // Building Themes
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // time change (daily schedule issues):
                    { 814698320u , Status.MinorIssues  }, // TimeWarp Fix (game will pause when used, time resets when unpaused)
                    { 672248733u , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2 (game will pause when used, time resets when unpaused)
                    { 1899449152u, Status.Incompatible }, // Game Day Timer (it can't recognise offline realtime)
                    // other
                    { 1801953480u, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1412844620u, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560u , Status.Compatible   }, // Geli-Districts v3.0
                },
                ContinuationOf = 1420955187u, // Real Time (original by dymanoid)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1420955187u, // Real Time (original by dymanoid)
                SuppressOlderReplacementWarning = true,
            });

            AddMod(new Review(1706703944u, "More Outside Interaction") {
                Affect = Factor.Employment
                       | Factor.Service,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
            });

            AddMod(new Review(1614061108u, "Real Construction") {
                Affect = Factor.Construction
                       | Factor.Consumption
                       | Factor.DemandRCI
                       | Factor.Production
                       | Factor.StorageCapacity
                       | Factor.VehicleLimit,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902u, Status.Compatible   }, // Transfer Info (beta)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1435741602u, Status.Incompatible }, // Snooper
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1108715012u, Status.Incompatible }, // Adjustable Business Consumption
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                    { 408706691u , Status.Incompatible }, // Proper Hardness

                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/RealConstruction",
            });

            AddMod(new Review(1383456057u, "Shicho") {
                Affect = Factor.BuildingInfo
                       | Factor.Camera
                       | Factor.Health
                       | Factor.HideRemove
                       | Factor.Rendering
                       | Factor.Toolbar
                       | Factor.Trees
                       | Factor.VehicleInfo,
                Authors = "saki7, Ryuichi Kaminogi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295u, Status.Incompatible }, // Move It! 移动它 中文版
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 2035564927u, Status.Compatible   }, // 25parts_su
                    { 2027161563u, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 1978555062u, Status.Compatible   }, // AllSpacesUnlockable
                    { 1892174866u, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1891302645u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1878659195u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1866239503u, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754u, Status.Incompatible }, // MoveIt 汉化版
                    { 1830615215u, Status.Compatible   }, // All 25 Areas purchaseable
                    { 1778652879u, Status.Compatible   }, // MaxArea
                    { 1758376843u, Status.Incompatible }, // Network Skins 2 Beta
                    { 1723162741u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1721492498u, Status.Incompatible }, // Cargo Hold Fix
                    { 1643902284u, Status.Incompatible }, // Watch It!
                    //{ 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1622545887u, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021u, Status.Incompatible }, // Move It 2.4.1
                    { 1612287735u, Status.Compatible   }, // Purchase It!
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1591417160u, Status.Incompatible }, // Hide It!
                    { 1577882296u, Status.Incompatible }, // Resize It!
                    { 1575247594u, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1560122066u, Status.Incompatible }, // 81MOD
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options 1.8.5
                    { 1457742795u, Status.Compatible   }, // 403798635 All Spaces Unlockable
                    { 1449194984u, Status.Compatible   }, // 25格汉化版
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1388613752u, Status.Incompatible }, // Tree Movement Control
                    { 1369729955u, Status.Incompatible }, // Customize It!
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 1361478243u, Status.Incompatible }, // 81 Tiles
                    { 1314938052u, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1312735149u, Status.Incompatible }, // Klyte Commons 1.1.6
                    { 1270675750u, Status.Compatible   }, // BigCity (25 tiles mod)
                    { 1268806334u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1265292380u, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1225712804u, Status.Compatible   }, // 406218372
                    { 1223738434u, Status.Incompatible }, // 422554572
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 1138679561u, Status.Compatible   }, // AllSpacesUnlock
                    { 1120637951u, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 1094334744u, Status.Incompatible }, // Procedural Objects 1.5.5
                    { 940299505u , Status.Incompatible }, // AnimUV Params
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2 [r4.3.1]
                    { 928103306u , Status.Incompatible }, // Ship Converter
                    { 924884948u , Status.Incompatible }, // Plop The Growables
                    { 922939393u , Status.Incompatible }, // Transparency LOD Fix + Cloud Assets Enabler
                    { 912329352u , Status.Incompatible }, // Building Anarchy
                    { 903347963u , Status.Incompatible }, // Transparent Selectors
                    { 895061550u , Status.Incompatible }, // Theme Decals
                    { 878991312u , Status.Incompatible }, // Prop it Up! 1.4.4
                    { 877748783u , Status.Incompatible }, // Topographic Lines Toggle
                    { 837734529u , Status.Incompatible }, // Find It! 1.5.4
                    { 820157360u , Status.Incompatible }, // Spawn Points Fix
                    { 818641631u , Status.Incompatible }, // Ambient Sounds Tuner
                    { 816260433u , Status.Incompatible }, // Metro Overhaul
                    { 815103125u , Status.Incompatible }, // Extra Vehicle Effects
                    { 814498849u , Status.Incompatible }, // Improved Content Manager
                    { 812125426u , Status.Incompatible }, // Network Extensions 2
                    { 812107110u , Status.Incompatible }, // Less Steam
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy 1.3.5
                    { 795514116u , Status.Incompatible }, // Train Converter
                    { 793176674u , Status.Incompatible }, // Sharp Textures
                    { 791221322u , Status.Incompatible }, // Prop Precision 1.0.1
                    { 787611845u , Status.Incompatible }, // Prop Snapping
                    { 780720853u , Status.Incompatible }, // Vehicle Effects 1.8.1a
                    { 766190099u , Status.Incompatible }, // Move It
                    { 724382534u , Status.Incompatible }, // One-Way Train Tracks
                    { 714056356u , Status.Incompatible }, // Transport Line Rendering Fix
                    { 707759735u , Status.Incompatible }, // Ship Path Anarchy
                    { 694512541u , Status.Incompatible }, // Prop Line Tool
                    { 694123443u , Status.Incompatible }, // American Traffic Lights
                    { 689937287u , Status.Incompatible }, // Surface Painter
                    { 667342976u , Status.Incompatible }, // Loading Screen Mod
                    { 654707599u , Status.Incompatible }, // WG Citizen Lifecycle Rebalance v2.6
                    { 651322972u , Status.Incompatible }, // Fine Road Tool 1.3.7
                    { 650436109u , Status.Incompatible }, // Quay Anarchy
                    { 625608461u , Status.Incompatible }, // Adaptive Prop Visibility Distance
                    { 616078328u , Status.Incompatible }, // All Tile Start -- not a tile mod, incompat with 81 tiles
                    { 593588108u , Status.Incompatible }, // Prop & Tree Anarchy
                    { 591137516u , Status.Incompatible }, // Redcomet's Municipal Sound Pack
                    { 583429740u , Status.Incompatible }, // TM:PE 10.20
                    { 576327847u , Status.Incompatible }, // 81 Tiles (Fixed for C:S 1.2+)
                    { 552309905u , Status.Incompatible }, // No Abandonment
                    { 543722850u , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 538019888u , Status.Incompatible }, // Spawn/Unspawn Positions Swapper
                    { 530771650u , Status.Incompatible }, // Prefab Hook
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 515489008u , Status.Incompatible }, // Extra Train Station Tracks
                    { 512314255u , Status.Incompatible }, // More Network Stuff
                    { 510677558u , Status.Incompatible }, // The Metropolitan Sound Pack
                    { 502750307u , Status.Incompatible }, // Extra Landscaping Tools
                    { 498386331u , Status.Incompatible }, // CrossTheLine
                    { 497033453u , Status.Incompatible }, // UnlimitedOutsideConnections
                    { 465318661u , Status.Incompatible }, // ToggleableWhiteness
                    { 463845891u , Status.Incompatible }, // No Pillars
                    { 455403039u , Status.Incompatible }, // Unlimited Trees Mod
                    { 445589127u , Status.Incompatible }, // Precision Engineering
                    { 426163185u , Status.Incompatible }, // WG Realistic Population v8.4.0
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 422554572u , Status.Incompatible }, // 81 Tiles (original by emf)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413498678u , Status.Compatible   }, // All Spaces Unlockable - With Right Price
                    { 408905948u , Status.Incompatible }, // Pause on load
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                    { 406218372u , Status.Compatible   }, // All Spaces Unlockable
                    { 405810376u , Status.Compatible   }, // All 25 Areas purchasable (by tomdotio)
                    { 403798635u , Status.Compatible   }, // All Spaces Unlockable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Shicho seems to break mods that use Harmony framework." },
                },
                SourceURL = "https://github.com/SETNAHQ/Shicho",
            });

            AddMod(new Review(1420955187u, "Real Time") {
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
                    { 1911736890u, Status.MinorIssues  }, // 1181352643 District Service Limit 3 (see note for DSL 3.0 below)
                    { 1893036262u, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1432430887u, Status.Incompatible }, // Rush Hour II (Development)
                    { 1420955187u, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 1181352643u, Status.MinorIssues  }, // District Service Limit 3.0 (citizen limiting features, if enabled, directly conflict with RT)
                    { 702070768u , Status.Incompatible }, // Export Electricity
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 605590542u , Status.Incompatible }, // Rush Hour II
                    // conceptual conflict: boredom
                    { 1776052533u, Status.Compatible   }, // Stops & Stations
                    { 1766839841u, Status.MinorIssues  }, // Anxiety Reducer (still testing)
                    // conceptual conflict: time
                    { 1899449152u, Status.Compatible   }, // Game Day Timer (switches to different mode for Real Time)
                    { 1729576238u, Status.Incompatible }, // Date Changer
                    { 814698320u , Status.MinorIssues  }, // TimeWarp Fix
                    { 672248733u , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2
                    { 629713122u , Status.Incompatible }, // Climate Control
                    // conceptual coflict: aging
                    { 2027161563u, Status.Compatible   }, // Lifecycle Rebalance Revisited
                    { 1196714522u, Status.Incompatible }, // 居民衰老变十六分之一
                    { 654707599u , Status.Compatible   }, // Citizen Lifecycle Rebalance v2.6
                    { 643642403u , Status.MinorIssues  }, // Lifespan multiplier v1.1
                    { 573925048u , Status.MinorIssues  }, // Lifespan Changer
                    { 571655171u , Status.MinorIssues  }, // Randomize Age Cims Move in
                    { 541673195u , Status.MinorIssues  }, // Resident Travel Rebalance v1.1:
                    { 421188880u , Status.Incompatible }, // [ARIS] Early Death
                    { 409071509u , Status.MinorIssues  }, // Slow Citizen Aging Configurable
                    { 409070739u , Status.MinorIssues  }, // Very Slow Citizen Aging
                    { 409070218u , Status.MinorIssues  }, // Slow Citizen Aging
                    // conceptual conflict: construction
                    { 2016920607u, Status.Compatible   }, // RICO revisited
                    { 1899943042u, Status.MinorIssues  }, // No Scaffolding Animation
                    { 1614061108u, Status.Compatible   }, // Real Construction
                    { 1204126182u, Status.MinorIssues  }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 924884948u , Status.MinorIssues  }, // Plop the Growables
                    { 586012417u , Status.MinorIssues  }, // Ploppable RICO (original)
                    { 523818382u , Status.MinorIssues  }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                    // other
                    { 2048266761u, Status.MinorIssues  }, // Building Usage
                    { 1801953480u, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1412844620u, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560u , Status.Compatible   }, // Geli-Districts v3.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Locale = "en",
                Languages = new[] { "de", "en", "es", "fr", "it", "ja", "ko", "pl", "pt", "ru", "zh" },
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The 'Better citizen aging' option has a big influence on how education works." },
                    { 2048266761u, "[Mod: Building Usage] Building Usage mod does not account for worker variations due to Real Time shifts." },
                    { 1911736890u, "[Mod: District Service Limit] Disable its citizen-limiting options to make compatible with Real Time." },
                    { 1801953480u, "[Mod: Natural Disasters Overhaul] Real Time changes time flow, causuing excessive thunder storms." },
                    { 1204126182u, "[Mod: Ploppable RICO] Old versions of the mod sometimes report zero construction time which crashes Real Time." },
                    { 924884948u , "[Mod: Plop the Growables] If plopped buildings disappear, set 'Construction speed' to 100% in Real Time." },
                    { 814698320u , "[Mod: TimeWarp Fix] Game will pause when you change time, time will revert when game unpaused." },
                    { 672248733u , "[Mod: Ultimate Eye Candy] Game will pause when you change time, time will revert when game unpaused." },
                    { 649522495u , "[Mod: District Service Limit] Disable its citizen-limiting options to make compatible with Real Time." },
                    { 629713122u , "[Mod: Climate Control] It breaks the citizen schedules in Real Time." },
                    { 586012417u , "[Mod: Ploppable RICO] Old versions of the mod sometimes report zero construction time which crashes Real Time." },
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/dymanoid/RealTime",
            });

            AddMod(new Review(1386697922u, "Garbage Bin Controller") {
                Affect = Factor.Props
                       | Factor.Emptying,
                Authors = "Arnold J. Rimmer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1390252175u, Status.Recommended }, // Japanese Plastic Bucket
                    { 1389908178u, Status.Recommended }, // Wheelie Bin - Color Variation
                    { 1386088603u, Status.Recommended }, // Metal bin - 01
                    // LSM skipping vanilla garbage bin = game breaking
                    { 1894425170u, Status.MinorIssues }, // Loading Screen Mod 汉化版
                    { 1860379049u, Status.MinorIssues }, // 加载优化 Loading Screen
                    { 833779378u , Status.MinorIssues }, // Loading Screen Mod [Test]
                    { 667342976u , Status.MinorIssues }, // Loading Screen Mod
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 833779378u, "[Mod: Loading Screen Mod] If you get crashes, remove 'Garbage Bin' from your skip.txt file." },
                    { 667342976u, "[Mod: Loading Screen Mod] If you get crashes, remove 'Garbage Bin' from your skip.txt file." },
                },
                ReleasedDuring = GameVersion.ParkLife,
            });

            // runs a load of code in OnUpdate = lag.
            AddMod(new Review(878991312u, "Prop it Up! 1.4.4") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props
                       | Factor.Trees,
                Authors = "Judazzz, BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.Laggy
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Runs a lot of code in OnUpdate() = can cause lag in-game." },
                    { NOTE, "User guide: https://steamcommunity.com/workshop/filedetails/discussion/878991312/133259227529823319/" },
                    { NOTE, "Sunset Harbor: Tree replacement features seem broken." },
                    { NOTE, "Sunset Harbor: Some users report it crashes when replacing props." },
                },
                SourceURL = "https://github.com/Judazzz/CitiesSkylines-PropItUp",
            });

            // Known issues (based on author comment):
            // * Cannot see values that you set the offsets for
            // * Unable to save/load option settings
            // * Does not update visual budget panel, but does update budget in the background
            // Was previously named "Water and Electricity Controller".
            AddMod(new Review(1239683428u, "Budget Controller") {
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