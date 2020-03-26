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
        private void UnsortedCatalog() {

            string catalog = "Unsorted";

            AddMod(new Item(2033714682u, "Tree and Vehicle Props") {
                Affect = Factor.LoadSave
                       | Factor.Props
                       | Factor.Trees
                       | Factor.Vehicles,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 791221322u , Status.Recommended  }, // Prop Precision
                    { 593588108u , Status.Recommended  }, // Prop & Tree Anarchy
                    { 1094334744u, Status.Compatible   }, // Procedural Objects
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });

            // looks like translated clone of Favorite Cims mod
            AddMod(new Item(1985556066u, "4546") {
                Affect = Factor.Other,
                Authors = "暮",
                Catalog = catalog,
                CloneOf = 426460372u, // Favorite Cims
                Compatibility = new Dictionary<ulong, Status>() {
                    { 426460372u, Status.Incompatible }, // Favorite Cims
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                ReplaceWith = 426460372u, // Favorite Cims
            });

            AddMod(new Item(2016920607u, "RICO revisited") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Compatible   }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/algernon-A/Ploppable-RICO-Revisited",
            });

            AddMod(new Item(2009708489u, "Road Arrows Replacer [Spain]") {
                Affect = Factor.RoadMarkings,
                Authors = "Nouvilas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issue: hide it
                    // incompat - anything that chances road arrows or markings etc
                    { 2008960441u, Status.Required     }, // Spanish Arrow Decals Pack
                    { 956707300u , Status.Incompatible }, // Remove Street Arrows
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });



            AddMod(new Item(1927186256u, "Problem Info") {
                Affect = Factor.Other,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // no known issues
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // likely incompat with Customize It Extended
            AddMod(new Item(1865667356u, "Twitch Citizens") {
                Affect = Factor.Naming,
                Authors = "μohnytoxic™",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806759255u, Status.Unknown      }, // Customize It Extended
                    { 1369729955u, Status.Unknown      }, // Customize It!
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // Apparently creates some sort of biogas harvesting building that's
            // dependent on the number of plants in close proximity.
            AddMod(new Item(1920431318u, "Biogas-pw") {
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
                      | ItemFlags.SaveChanging
                      | ItemFlags.SourceUnavailable,
            });

            // replaces bus shelters, likely incompat with similar mods
            AddMod(new Item(1900151000u, "替换为不锈钢公交候车亭") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "ZEIR",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // anything that alters bus stops
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/OwiHH-NC/4cefbd1fbc7ff7135c59",
            });

            AddMod(new Item(1899943042u, "No Scaffolding Animation") {
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
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceUnavailable,
            });

            // mesures performance based on time it takes for a game day, and fps
            AddMod(new Item(1899449152, "Game Day Timer") {
                Affect = Factor.Other,
                Authors = "rcav8tr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/rcav8tr/GameDayTimer",
            });

            AddMod(new Item(1859100867u, "Klyte's Framework 1.1") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/KlyteFramework",
            });

            // Bundle of Chinese localised mods - will break your game
            AddMod(new Item(1812384654u, "(no name specified)") {
                Affect = Factor.Other,
                Authors = "打的好不如排的好",
                BrokenBy = GameVersion.DefaultRelease,
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                SkipVersionValidation = true,
            });

            AddMod(new Item(1801953480u, "Natural Disasters Overhaul") {
                Affect = Factor.Environment,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.MinorIssues  }, // Real Time (causes excessive thunderstorms)
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline (ditto)
                    // todo: check compat with other disaster mods
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                RequiredDLC = DLCs.NaturalDisasters,
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Enhanced-Disasters",
            });

            AddMod(new Item(1800844556u, "Zone Mixer 0 (Beta)") {
                Affect = Factor.Zoning,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/ZoneMixer",
            });

            AddMod(new Item(1799667916u, "UX Mod - OSD & Keybinds") {
                Affect = Factor.Other,
                Authors = "kvakvs",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/kvakvs/Skylines-UX",
            });

            AddMod(new Item(1782814610u, "Building Variations") {
                Affect = Factor.Textures,
                Authors = "Elektrix",
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
            });

            // sounds like bit of a nightmare
            AddMod(new Item(1769420886u, "Panel Hook (beta) for modders") {
                Affect = Factor.BuildingInfo
                       | Factor.VehicleInfo,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // tmpe?
                    // snooper?
                    // klyte mods?
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/vpoteryaev-cs-mods/PanelHook",
            });

            AddMod(new Item(1768810491u, "Measure It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-MeasureIt",
            });

            AddMod(new Item(1204126182u, "Ploppable Rico High Density Fix") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "(unknown)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 586012417u, // Ploppable RICO (original)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 2016920607u, // RICO revisited
            });

            AddMod(new Item(1749971558u, "Real Time Offline") {
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
            });

            AddMod(new Item(1706703944u, "More Outside Interaction") {
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

            AddMod(new Item(1614061108u, "Real Construction") {
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

            AddMod(new Item(1383456057u, "Shicho") {
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
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
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
                    { 1388613752u, Status.Incompatible }, // Tree Movement Control
                    { 1369729955u, Status.Incompatible }, // Customize It!
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
                Notes = new[] {
                    "Shicho seems to break mods that use Harmony framework.",
                },
                SourceURL = "https://github.com/SETNAHQ/Shicho",
            });

            AddMod(new Item(1420955187u, "Real Time") {
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
                    { 2016920607u, Status.MinorIssues  }, // RICO revisited
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
                    { 1801953480u, Status.MinorIssues  }, // Natural Disasters Overhaul (endless thunderstorms)
                    { 1412844620u, Status.Compatible   }, // Realistic Walking Speed
                    { 927293560u , Status.Compatible   }, // Geli-Districts v3.0
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Locale = "en",
                Languages = new[] { "de", "en", "es", "fr", "it", "ja", "ko", "pl", "pt", "ru", "zh" },
                Notes = new[] {
                    "The 'Better citizen aging' option has a big influence on how education works.",
                    "[Mod: Climate Control] It breaks the citizen schedules in Real Time.",
                    "[Mod: District Service Limit] Disable its citizen-limiting options to make compatible with Real Time.",
                    "[Mod: Natural Disasters Overhaul] Real Time changes time flow, causuing excessive thunder storms.",
                    "[Mod: Plop the Growables] If plopped buildings disappear, set 'Construction speed' to 100% in Real Time.",
                    "[Mod: TimeWarp Fix] Game will pause when you change time, time will revert when game unpaused.",
                    "[Mod: Ultimate Eye Candy] Game will pause when you change time, time will revert when game unpaused.",
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/dymanoid/RealTime",
            });

            AddMod(new Item(1386697922u, "Garbage Bin Controller") {
                Affect = Factor.Props
                       | Factor.Emptying,
                Authors = "Arnold J. Rimmer, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1390252175u, Status.Recommended }, // Japanese Plastic Bucket
                    { 1389908178u, Status.Recommended }, // Wheelie Bin - Color Variation
                    { 1386088603u, Status.Recommended }, // Metal bin - 01
                    // LSM skipping vanilla garbage bin = game breaking
                    { 667342976u , Status.MinorIssues }, // Loading Screen Mod
                    { 833779378u , Status.MinorIssues }, // Loading Screen Mod [Test]
                    { 1894425170u, Status.MinorIssues }, // Loading Screen Mod 汉化版
                    { 1860379049u, Status.MinorIssues }, // 加载优化 Loading Screen
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                Notes = new[] {
                    "[Mod: Loading Screen Mod] To prevent crashes, remove 'Garbage Bin' from your skip.txt file.",
                },
                ReleasedDuring = GameVersion.ParkLife,
            });

            AddMod(new Item(1274199764u, "Network Tiling") {
                Affect = Factor.Rendering,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                Notes = new[] {
                    "[Docs] For asset creators: https://gist.github.com/ronyx69/db4e7c41fe80020e31d9bd2e1e1196f8",
                },
                SourceURL = "https://gist.github.com/ronyx69/4f06181c8082188418cd0c224f630a09",
            });

            // Several reported issues with this mod (based on user comment):
            // * laggy (multiple users are reporting this - lots of code running on recurring events!)
            // * milestone unlock not working
            // * achievement enabler not working
            AddMod(new Item(1237383751u, "Extended Game Options") {
                Authors = "Zenya",
                Affect = Factor.Milestones, // will be more
                Catalog = catalog,
                Flags = ItemFlags.Laggy
                      | ItemFlags.MinorBugs // pause on load now in base game
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 823348129u , Status.Incompatible }, // Disasters Enabler
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                    // todo: will be more
                },
                Notes = new[] {
                    "Users report lag and reduced framerate when using this mod.",
                    "Users report the milestone unlocks no longer work as expected.",
                    "Users report achievement enabler is not working properly.",
                    "The base game has a 'Pause On Load' feature since Sunset Harbor update.",
                },
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Extended-Game-Options",
            });
        }
    }
}