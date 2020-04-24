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
                    { 1383456057uL, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      //| ItemFlags.BrokenByUpdate
                      | ItemFlags.Laggy
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
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

            AddMod(new Review(895061550uL, "Theme Decals") {
                Affect = Factor.MapThemes
                       | Factor.Props,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Unknown      }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1383456057uL, Status.Incompatible }, // Shicho
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 793346248uL , Status.Recommended  }, // Decal Hover Area
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 767233815uL , Status.Required     }, // Decal Prop Fix
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
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

            AddMod(new Review(911295408uL, "Prop Scaling 0.3 [Experimental ALPHA]") {
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

            AddMod(new Review(903347963uL, "Transparent Selectors") {
                Affect = Factor.PlaceAndMove
                       | Factor.UI,
                Authors = "Ronyx69, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.Incompatible }, // Toggle It!
                    { 1540147921uL, Status.Compatible   }, // Grid be Gone
                    { 1536223783uL, Status.Compatible   }, // Hide Selectors
                    { 1383456057uL, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
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
                Published = WorkshopDate("14 Jul, 2019"), // guess based on git repo creation date
                ReplaceWith = 2055972178uL, // Custom Zone Mixer
                SourceURL = "https://github.com/klyte45/ZoneMixer",
                SuppressArchiveWarning = true,
                Updated = WorkshopDate("16 Jul, 2019"), // guess based on github commits
                UserModInspected = true,
            });

            AddMod(new Review(2053655383uL, "Pretty Pixel's Trump Tweets") {
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

            AddMod(new Review(2044145894uL, "Dropouts Sunset Fix") {
                Authors = "Bobinator The Destroyer!",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 506982407uL, Status.Incompatible }, // Dropouts
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 506982407uL, // Dropouts
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is a temporary bug fix mod for Dropouts mod." },
                },
                Published = WorkshopDate("1 Apr, 2020"),
                ReleasedDuring = GameVersion.SunsetHarbor,
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMod(new Review(2040656402uL, "Harmony") {
                Affect = Factor.Other,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
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
                ReleasedDuring = GameVersion.ParadoxLauncher,
                ReplaceWith = 426460372uL, // Favorite Cims
            });

            // likely incompat with Customize It Extended
            AddMod(new Review(1865667356uL, "Twitch Citizens") {
                Affect = Factor.Naming,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255uL, Status.Unknown      }, // Customize It Extended
                    { 1369729955uL, Status.Unknown      }, // Customize It!
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 935350530uL , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
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
            });

            // replaces bus shelters, likely incompat with similar mods
            AddMod(new Review(1900151000uL, "替换为不锈钢公交候车亭") {
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

            AddMod(new Review(1899943042uL, "No Scaffolding Animation") {
                Affect = Factor.Construction,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
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
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/rcav8tr/GameDayTimer",
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
                      | ItemFlags.SourceUnavailable,
                SuppressVersionWarnings = true,
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
                    { 814698320uL , Status.MinorIssues  }, // TimeWarp Fix (game will pause when used, time resets when unpaused)
                    { 672248733uL , Status.MinorIssues  }, // Ultimate Eyecandy v1.5.2 (game will pause when used, time resets when unpaused)
                    { 1899449152uL, Status.Incompatible }, // Game Day Timer (it can't recognise offline realtime)
                    // other
                    { 1801953480uL, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1412844620uL, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                },
                ContinuationOf = 1420955187uL, // Real Time (original by dymanoid)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1420955187uL, // Real Time (original by dymanoid)
                SuppressOlderReplacementWarning = true,
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
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
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
                SourceURL = "https://github.com/pcfantasy/RealConstruction",
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
                Authors = "saki7, Ryuichi Kaminogi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2045014295uL, Status.Incompatible }, // Move It! 移动它 中文版
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 2035564927uL, Status.Compatible   }, // 25parts_su
                    { 2027161563uL, Status.Incompatible }, // Lifecycle Rebalance Revisited
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 1978555062uL, Status.Compatible   }, // AllSpacesUnlockable
                    { 1892174866uL, Status.Incompatible }, // MoveIt2.6汉化版
                    { 1891302645uL, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1878659195uL, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1866239503uL, Status.Incompatible }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421uL, Status.Incompatible }, // 766190099_Move_It_
                    { 1856282754uL, Status.Incompatible }, // MoveIt 汉化版
                    { 1830615215uL, Status.Compatible   }, // All 25 Areas purchaseable
                    { 1778652879uL, Status.Compatible   }, // MaxArea
                    { 1758376843uL, Status.Incompatible }, // Network Skins 2 Beta
                    { 1723162741uL, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1721492498uL, Status.Incompatible }, // Cargo Hold Fix
                    { 1643902284uL, Status.Incompatible }, // Watch It!
                    //{ 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1622545887uL, Status.Incompatible }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1619685021uL, Status.Incompatible }, // Move It 2.4.1
                    { 1612287735uL, Status.Compatible   }, // Purchase It!
                    { 1597852915uL, Status.Incompatible }, // More Advanced Toolbar
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1577882296uL, Status.Incompatible }, // Resize It!
                    { 1575247594uL, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1560122066uL, Status.Incompatible }, // 81MOD
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options 1.8.5
                    { 1457742795uL, Status.Compatible   }, // 403798635 All Spaces Unlockable
                    { 1449194984uL, Status.Compatible   }, // 25格汉化版
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1388613752uL, Status.Incompatible }, // Tree Movement Control
                    { 1369729955uL, Status.Incompatible }, // Customize It!
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 1361478243uL, Status.Incompatible }, // 81 Tiles
                    { 1314938052uL, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1312735149uL, Status.Incompatible }, // Klyte Commons 1.1.6
                    { 1270675750uL, Status.Compatible   }, // BigCity (25 tiles mod)
                    { 1268806334uL, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1265292380uL, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1225712804uL, Status.Compatible   }, // 406218372
                    { 1223738434uL, Status.Incompatible }, // 422554572
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 1138679561uL, Status.Compatible   }, // AllSpacesUnlock
                    { 1120637951uL, Status.Incompatible }, // [OUTDATED] Move It! Extra Filters
                    { 1094334744uL, Status.Incompatible }, // Procedural Objects 1.5.5
                    { 940299505uL , Status.Incompatible }, // AnimUV Params
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2 [r4.3.1]
                    { 928103306uL , Status.Incompatible }, // Ship Converter
                    { 924884948uL , Status.Incompatible }, // Plop The Growables
                    { 922939393uL , Status.Incompatible }, // Transparency LOD Fix + Cloud Assets Enabler
                    { 912329352uL , Status.Incompatible }, // Building Anarchy
                    { 903347963uL , Status.Incompatible }, // Transparent Selectors
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 878991312uL , Status.Incompatible }, // Prop it Up! 1.4.4
                    { 877748783uL , Status.Incompatible }, // Topographic Lines Toggle
                    { 877402994uL , Status.Incompatible }, // Lifespan Changer Fix
                    { 839931599uL , Status.Compatible   }, // UnlockAreaCountLimit
                    { 837734529uL , Status.Incompatible }, // Find It! 1.5.4
                    { 833779378uL , Status.Incompatible }, // Loading Screen Mod [Test]
                    { 820157360uL , Status.Incompatible }, // Spawn Points Fix
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner
                    { 816260433uL , Status.Incompatible }, // Metro Overhaul
                    { 815103125uL , Status.Incompatible }, // Extra Vehicle Effects
                    { 814498849uL , Status.Incompatible }, // Improved Content Manager
                    { 812125426uL , Status.Incompatible }, // Network Extensions 2
                    { 812107110uL , Status.Incompatible }, // Less Steam
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy 1.3.5
                    { 795514116uL , Status.Incompatible }, // Train Converter
                    { 793176674uL , Status.Incompatible }, // Sharp Textures
                    { 791221322uL , Status.Incompatible }, // Prop Precision 1.0.1
                    { 787611845uL , Status.Incompatible }, // Prop Snapping
                    { 780720853uL , Status.Incompatible }, // Vehicle Effects 1.8.1a
                    { 766190099uL , Status.Incompatible }, // Move It
                    { 724382534uL , Status.Incompatible }, // One-Way Train Tracks
                    { 714056356uL , Status.Incompatible }, // Transport Line Rendering Fix
                    { 707759735uL , Status.Incompatible }, // Ship Path Anarchy
                    { 694512541uL , Status.Incompatible }, // Prop Line Tool
                    { 694123443uL , Status.Incompatible }, // American Traffic Lights
                    { 689937287uL , Status.Incompatible }, // Surface Painter
                    { 667342976uL , Status.Incompatible }, // Loading Screen Mod
                    { 654707599uL , Status.Incompatible }, // WG Citizen Lifecycle Rebalance v2.6
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool 1.3.7
                    { 650436109uL , Status.Incompatible }, // Quay Anarchy
                    { 625608461uL , Status.Incompatible }, // Adaptive Prop Visibility Distance
                    { 616078328uL , Status.Incompatible }, // All Tile Start -- not a tile mod, incompat with 81 tiles
                    { 593588108uL , Status.Incompatible }, // Prop & Tree Anarchy
                    { 591137516uL , Status.Incompatible }, // Redcomet's Municipal Sound Pack
                    { 583429740uL , Status.Incompatible }, // TM:PE 10.20
                    { 576327847uL , Status.Incompatible }, // 81 Tiles (Fixed for C:S 1.2+)
                    { 573925048uL , Status.Incompatible }, // Lifespan Changer
                    { 552309905uL , Status.Incompatible }, // No Abandonment
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 538019888uL , Status.Incompatible }, // Spawn/Unspawn Positions Swapper
                    { 530771650uL , Status.Incompatible }, // Prefab Hook
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 515489008uL , Status.Incompatible }, // Extra Train Station Tracks
                    { 512314255uL , Status.Incompatible }, // More Network Stuff
                    { 510677558uL , Status.Incompatible }, // The Metropolitan Sound Pack
                    { 502750307uL , Status.Incompatible }, // Extra Landscaping Tools
                    { 498386331uL , Status.Incompatible }, // CrossTheLine
                    { 497033453uL , Status.Incompatible }, // UnlimitedOutsideConnections
                    { 465318661uL , Status.Incompatible }, // ToggleableWhiteness
                    { 463845891uL , Status.Incompatible }, // No Pillars
                    { 455403039uL , Status.Incompatible }, // Unlimited Trees Mod
                    { 445589127uL , Status.Incompatible }, // Precision Engineering
                    { 426163185uL , Status.Incompatible }, // WG Realistic Population v8.4.0
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 422554572uL , Status.Incompatible }, // 81 Tiles (original by emf)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413498678uL , Status.Compatible   }, // All Spaces Unlockable - With Right Price
                    { 411821214uL , Status.Incompatible }, // Pause on no focus/Alt-Tab
                    { 408905948uL , Status.Incompatible }, // Pause on load
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    { 406218372uL , Status.Compatible   }, // All Spaces Unlockable
                    { 405810376uL , Status.Compatible   }, // All 25 Areas purchasable (by tomdotio)
                    { 403798635uL , Status.Compatible   }, // All Spaces Unlockable
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Shicho seems to break mods that use Harmony framework." },
                },
                SourceURL = "https://github.com/SETNAHQ/Shicho",
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