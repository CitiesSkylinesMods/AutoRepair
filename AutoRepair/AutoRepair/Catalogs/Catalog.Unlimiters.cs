namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods which extend game limits.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void UnlimiterMods() {

            string catalog = "Unlimiters";

            // Compatibilities for 25 tile mods
            Dictionary<ulong, Status> tile25compatibility = new Dictionary<ulong, Status>() {
                { 2035564927u, Status.Incompatible }, // 25parts_su
                { 1978555062u, Status.Incompatible }, // AllSpacesUnlockable
                { 1891302645u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                { 1878659195u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                { 1830615215u, Status.Incompatible }, // All 25 Areas purchaseable
                { 1778652879u, Status.Incompatible }, // MaxArea
                { 1764208250u, Status.Compatible   }, // More Vehicles -- not a tile mod, incompat with 81 tiles
                { 1723162741u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                { 1612287735u, Status.Incompatible }, // Purchase It!
                { 1575247594u, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                { 1560122066u, Status.Incompatible }, // 81MOD
                { 1457742795u, Status.Incompatible }, // 403798635 All Spaces Unlockable
                { 1449194984u, Status.Incompatible }, // 25格汉化版
                { 1383456057u, Status.Compatible   }, // Shicho
                { 1361478243u, Status.Incompatible }, // 81 Tiles
                { 1314938052u, Status.Incompatible }, // UnlockAreaCountLimit
                { 1270675750u, Status.Incompatible }, // BigCity (25 tiles mod)
                { 1268806334u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                { 1265292380u, Status.Incompatible }, // UnlockAreaCountLimit
                { 1237383751u, Status.Incompatible }, // Extended Game Options
                { 1225712804u, Status.Incompatible }, // 406218372
                { 1223738434u, Status.Incompatible }, // 422554572
                { 1138679561u, Status.Incompatible }, // AllSpacesUnlock
                { 616078328u , Status.Incompatible }, // All Tile Start -- not a tile mod, incompat with 81 tiles
                { 576327847u , Status.Incompatible }, // 81 Tiles (current ver by BP)
                { 422554572u , Status.Incompatible }, // 81 Tiles (original by emf)
                { 413498678u , Status.Incompatible }, // All Spaces Unlockable - With Right Price
                { 406218372u , Status.Incompatible }, // All Spaces Unlockable
                { 405810376u , Status.Incompatible }, // All 25 Areas purchasable (by tomdotio)
                { 403798635u , Status.Incompatible }, // All Spaces Unlockable
            };

            // Compatibilities for 81 tiles mods
            Dictionary<ulong, Status> tile81compatibility = new Dictionary<ulong, Status>(tile25compatibility) {
                // note: More Vehicles is compatible with BPs 81 Tiles mod but not any older versions
                //       MV is specifically marked compatible with BPs 81 Tiles mod descriptor,
                //       but left incompatible here for all the other 81 Tiles clones.
                [1764208250u] = Status.Incompatible, // More Vehicles
                // technical conflict with all 81 Tile mods:
                [1383456057u] = Status.Incompatible, // Shicho
                [616078328u ] = Status.Incompatible, // All Tile Start
                // customisations sometimes reset outside central 25 tile area:
                [1869561285u] = Status.MinorIssues , // Prop Painter 2.6.0
                [543722850u ] = Status.MinorIssues , // Network Skins (Park Life compatible)
                [463845891u ] = Status.MinorIssues , // No Pillars
            };

            AddMod(new Review(1764208250u, "More Vehicles") {
                Affect = Factor.VehicleLimit // mods which don't properly check vehicle limits will break
                       | Factor.TileLimit // incompat with 81 tiles
                       | Factor.Toolbar, // date/event display can be broken by toolbar & quartz/sapphire mods
                Authors = "dymanoid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2035564927u, Status.Compatible   }, // 25parts_su
                    { 1978555062u, Status.Compatible   }, // AllSpacesUnlockable
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Unknown      }, // Unified Railway System
                    { 1891302645u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1878659195u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1830615215u, Status.Compatible   }, // All 25 Areas purchaseable
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1778652879u, Status.Compatible   }, // MaxArea
                    { 1723162741u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1612287735u, Status.Compatible   }, // Purchase It!
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1575247594u, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066u, Status.Incompatible }, // 81MOD
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options (new one; v1.9.0 should fix)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1457742795u, Status.Compatible   }, // 403798635 All Spaces Unlockable
                    { 1449194984u, Status.Compatible   }, // 25格汉化版
                    { 1361478243u, Status.Incompatible }, // 81 Tiles (prolly a localised version)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1314938052u, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1270675750u, Status.Compatible   }, // BigCity (25 tiles mod)
                    { 1268806334u, Status.Compatible   }, // UnlockAreaCountLimitAndFree
                    { 1265292380u, Status.Compatible   }, // UnlockAreaCountLimit
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1225712804u, Status.Compatible   }, // 406218372
                    { 1223738434u, Status.Incompatible }, // 422554572
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 1138679561u, Status.Compatible   }, // AllSpacesUnlock
                    { 934994075u , Status.Unknown      }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 816260433u , Status.Compatible   }, // Metro Overhaul Mod
                    { 781767563u , Status.MinorIssues  }, // Extended InfoPanel
                    { 616078328u , Status.Incompatible }, // All Tile Start
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 576327847u , Status.Compatible   }, // 81 Tiles (BP version)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 422554572u , Status.Incompatible }, // 81 Tiles (original version)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413498678u , Status.Compatible   }, // All Spaces Unlockable - With Right Price
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                    { 406218372u , Status.Compatible   }, // All Spaces Unlockable
                    { 403798635u , Status.Compatible   }, // All Spaces Unlockable
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.SaveAltering,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/dymanoid/MoreVehicles",
                Tags = new[] { "Vehicles", "Parked", "Parking", "Limits", "Unlimiter" },
            });

            // 25 tiles - with extra features
            AddMod(new Review(1612287735u, "Purchase It!") {
                Affect = Factor.TileLimit,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility) {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // harmony patch management could be better
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/keallu/CSL-PurchaseIt",
            });

            // 25 tiles - author still active
            // Using this as main replacement for legions of abandonned 25 tile mods
            // primarily because it has good instructions for users and author provides
            // good responses to comments.
            AddMod(new Review(1270675750u, "BigCity (25 tiles mod)") {
                Affect = Factor.TileLimit,
                Authors = "frostblue",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.GreenCities,
            });

            // 81 tiles
            AddMod(new Review(576327847u, "81 Tiles (Fixed for 1.2+)") {
                Affect = Factor.Construction
                       | Factor.PlaceAndMove
                       | Factor.Rendering
                       | Factor.TileLimit,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility) {
                    [1764208250u] = Status.Compatible, // More Vehicles
                    [576327847u ] = Status.MinorIssues, // Surface Painter
                },
                ContinuationOf = 422554572u, // 81 Tiles (original version by emf)
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Laggy // each purchased tile adds additional rendering and simulation workload
                      | ItemFlags.MinorIssues // some glitches with various services built outside central 25 tile area
                      | ItemFlags.SaveAltering // can be removed, but stuff outside central 25 tiles will glitch
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "IMPORTANT: If your save game became corrupt due to Sunset Harbor update, use the recovery mode in 81 Tiles mod options." },
                    { NOTE, "After loading a save, terrain may look distorted but should quickly return to normal." },
                    { NOTE, "Dams cause tsunamis if placed outside central 25 tile area." },
                    { NOTE, "Disasters and evacuation don't work properly outside central 25 tile area." },
                    { 1764208250u, "[Mod: More Vehicles] Some reports that 81 Tiles mod still isn't compatible with More Vehicles." },
                    { 576327847u , "[Mod: Surface Painter] Customisations sometimes reset if used outside of central 25 tile area." },
                    { 543722850u , "[Mod: Network Skins] Customisations sometimes reset outside of central 25 tile area." },
                    { 463845891u , "[Mod: No Pillars] Customisations sometimes reset outside of central 25 tile area." },
                },
                ReleasedDuring = GameVersion.AfterDark,
                SourceURL = "https://github.com/bloodypenguin/cities-skylines-unlimiter-1",
            });

            // 25 tiles - author still active
            AddMod(new Review(413498678u, "All Spaces Unlockable - With Right Price") {
                Affect = Factor.TileLimit,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
            });

            // 25 tiles - author still active
            AddMod(new Review(403798635u, "All Spaces Unlockable") {
                Affect = Factor.TileLimit,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorIssues, // doesn't increase purchase price after first 9 tiles
                ReleasedDuring = GameVersion.InitialRelease,
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // 25 tiles
            AddMod(new Review(2035564927u, "25parts_su") {
                Affect = Factor.TileLimit,
                Authors = "915962083",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1978555062u, "AllSpacesUnlockable") {
                Affect = Factor.TileLimit,
                Authors = "(unknown)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop // sometime during March 2020
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressArchiveWarning = true,
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1891302645u, "UnlockAreaCountLimitAndFree") {
                Affect = Factor.TileLimit,
                Authors = "enroban",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1878659195u, "UnlockAreaCountLimitAndFree") {
                Affect = Factor.TileLimit,
                Authors = "KiDDOT",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1830615215u, "All 25 Areas purchaseable") {
                Affect = Factor.TileLimit,
                Authors = "gendows",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1778652879u, "MaxArea") {
                Affect = Factor.TileLimit,
                Authors = "MMP",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1723162741u, "UnlockAreaCountLimitAndFree") {
                Affect = Factor.TileLimit,
                Authors = "奥利弗·奎恩",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 81 tiles
            AddMod(new Review(1575247594u, "576327847 81 Tiles (Fixed for 1") {
                Affect = Factor.TileLimit,
                Authors = "1061303312",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // all old 81 tiles mods are game breaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 576327847u, // 81 Tile (BP version)
                SuppressOlderReplacementWarning = true,
            });

            // 81 tiles
            AddMod(new Review(1560122066u, "81MOD") {
                Affect = Factor.TileLimit,
                Authors = "116060166",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // all old 81 tiles mods are game breaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 576327847u, // 81 Tile (BP version)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1457742795u, "403798635 All Spaces Unlockable") {
                Affect = Factor.TileLimit,
                Authors = "exedoronexe",
                Catalog = catalog,
                CloneOf = 403798635u, // All Spaces Unlockable (by Klyte45)
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 403798635u, // All Spaces Unlockable (by Klyte45)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1449194984u, "25格汉化版") {
                Affect = Factor.TileLimit,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 405810376u, // All 25 Areas purchasable (by tomdotio)
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 405810376u, // All 25 Areas purchasable (by tomdotio)
                SuppressOlderReplacementWarning = true,
            });

            // 81 tiles
            AddMod(new Review(1361478243u, "81 Tiles") {
                Affect = Factor.TileLimit,
                Authors = "限量版好男人",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // all old 81 tiles mods are game breaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                ReplaceWith = 576327847u, // 81 Tile (BP version)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1314938052u, "UnlockAreaCountLimit") {
                Affect = Factor.TileLimit,
                Authors = "angelleng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressOlderReplacementWarning = true,
            });

            // 25 tiles
            AddMod(new Review(1268806334u, "UnlockAreaCountLimitAndFree") {
                Affect = Factor.TileLimit,
                Authors = "YFGG",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
            });

            // 25 tiles
            AddMod(new Review(1265292380u, "UnlockAreaCountLimit") {
                Affect = Factor.TileLimit,
                Authors = "binbck-y",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
            });

            // 25 tiles
            AddMod(new Review(1225712804u, "406218372") {
                Affect = Factor.TileLimit,
                Authors = "丿CK独狼灬",
                BrokenBy = GameVersion.EuropeBiome, // when the IUserMod changed
                Catalog = catalog,
                CloneOf = 406218372u, // 25 Spaces
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // using really old version of IUserMod
                      | ItemFlags.Localised
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReleasedDuring = GameVersion.GreenCities, // lolol
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressArchiveWarning = true,
                SuppressVersionWarnings = true,
            });

            // 81 tiles
            AddMod(new Review(1223738434u, "422554572") {
                Affect = Factor.TileLimit,
                Authors = "Pride",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                CompatibleWith = new Version(1, 1, 1), // patch after euro theme added
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy // adds extra cpu and gpu strain
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReleasedDuring = GameVersion.GreenCities, // lol!!
                ReplaceWith = 576327847, // 81 Tiles (Fixed for 1.2+)
                SuppressOlderReplacementWarning = true,
                SuppressVersionWarnings = true,
            });

            // 25 tiles
            AddMod(new Review(1138679561u, "AllSpacesUnlock") {
                Authors = "The700",
                Affect = Factor.TileLimit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // Multiple user comments stating it doesn't work (maybe they forgot to enabled?)
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
            });

            // Unlocks all tiles (up to current tile limit) at start of new game
            // eg. if no other tile mods, will unlock 9 tiles. If a 25 tile mod
            // is active, it will unlock 25 tiles. Incompatible with more advanced mods
            // such as 81 Tiles and Purchase It.
            AddMod(new Review(616078328u, "All Tile Start") {
                Affect = Factor.Other,
                Authors = "johnrom",
                BrokenBy = GameVersion.Campus, // breaks milestones, issues with vehicle spawning, etc.
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking // lots of uers reporting game breaking bugs or other major issues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod is known to break vehicle spawning and causes problems with milestones." },
                    { NOTE, "[Mod: 81 Tiles] It is game-breaking when used with any version of 81 Tiles." },
                },
                ReleasedDuring = GameVersion.AfterDark,
            });

            // the original 81 tiles mod by emf
            AddMod(new Review(422554572u, "81 Tiles Updated") {
                Affect = Factor.TileLimit,
                Authors = "emf",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile81compatibility),
                CompatibleWith = new Version(1, 1, 1), // patch after euro theme added
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy // adds extra cpu and gpu strain
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = new Version(1, 0, 7), // patch before euro theme added
                ReplaceWith = 576327847, // 81 Tiles (Fixed for 1.2+)
                SourceURL = "https://github.com/lxteo/cities-skylines-unlimiter-1",
            });

            // 25 tiles
            AddMod(new Review(406218372u, "All Spaces Unlockable") { // in-game name: 25 Spaces
                Affect = Factor.TileLimit,
                Authors = "(unknown)",
                BrokenBy = GameVersion.EuropeBiome, // when the IUserMod changed
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(tile25compatibility),
                CompatibleWith = new Version(1, 0, 7),
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // using really old version of IUserMod
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 1270675750u, // BigCity (25 tiles mod)
                SuppressArchiveWarning = true,
            });
        }
    }
}