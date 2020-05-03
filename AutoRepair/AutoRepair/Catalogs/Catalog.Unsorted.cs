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

            AddMod(new Review(819797131uL, "Reddit For Chirpy: Updated") {
                Affect = Factor.UI,
                Authors = "tony56a",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 408705348uL, // Reddit For Chirpy
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users report this mod is unreliable since Campus game update." },
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("17 Dec, 2016"),
                Updated = WorkshopDate("5 Jul, 2018"),
            });

            AddMod(new Review(408705348uL, "Reddit For Chirpy") {
                Affect = Factor.UI,
                Authors = "mabako",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 819797131uL, // Reddit For Chirpy: Updated
                SourceURL = "https://github.com/mabako/reddit-for-city-skylines",
                Updated = WorkshopDate("3 Apr, 2015"),
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
                Suppress = Warning.MissingArchiveURL,
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
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
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
                Suppress = Warning.OlderReplacement,
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
                Suppress = Warning.InvalidVersionSequence,
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
                Suppress = Warning.OlderReplacement,
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