namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Services (health, waste, emergency, etc).
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void ServiceMods() {

            string catalog = "Services";

            AddMod(new Review(2077426488uL, "Super Hearse AI [Beta]") {
                Affect = Factor.Pathfinder
                       | Factor.Service,
                Authors = "Fox",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 2027161563uL, Status.MinorIssues  }, // Lifecycle Rebalance Revisited
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 803074771uL , Status.Incompatible }, // No Deathcare
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                    // incompat: Service Vehicle Selector
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("7 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 2027161563uL, "[Mod: Lifecycle Rebalance] If 'Percentage of dead requiring transport' is set to 0 in 'Lifecycle Rebalance', you won't need 'Super Hearse AI'." },
                },
                Published = WorkshopDate("28 Apr, 2020"),
                Updated = WorkshopDate("29 Apr, 2020"),
            });

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            AddMod(new Review(1922400472uL, "Enhanced District Services") {
                Affect = Factor.Consumption
                       | Factor.Customize
                       | Factor.Emptying
                       | Factor.Immigrants
                       | Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.Production
                       | Factor.Service
                       | Factor.StorageCapacity
                       | Factor.Vehicles,
                Authors = "chronofanz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1911736890uL, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1721492498uL, Status.Recommended  }, // Optimised Outside Connections
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 785237088uL , Status.Incompatible }, // Service Radius Adjuster
                    { 649522495uL , Status.Incompatible }, // District Service Limit
                    { 554232266uL , Status.Incompatible }, // Mod: Nursing Homes for Senior Citizens
                    { 512341354uL , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 439582006uL , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI

                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 576327847uL, "[Mod: 81 Tiles] May cause problems with Enhanced District Services mod: https://steamcommunity.com/workshop/filedetails/discussion/576327847/2266942917235315332/" },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/chronofanz/EnhancedDistrictServices",
            });

            AddMod(new Review(1680840913uL, "More Effective Transfer Manager") {
                Affect = Factor.Consumption
                       | Factor.Emptying
                       | Factor.Health
                       | Factor.Pathfinder
                       | Factor.Production
                       | Factor.Service
                       | Factor.Vehicles,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 2076619989uL, Status.Unknown      }, // 934994075 Service Vehicle Selector 2
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1911736890uL, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053uL, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 934994075uL , Status.Unknown      }, // Service Vehicle Selector 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers (original)
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                SourceURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
            });

            AddMod(new Review(1632320836uL, "Service Vehicles Manager 2.0.1") {
                Affect = Factor.Service,
                Authors = "Klyte45",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1911736890uL, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495uL , Status.Incompatible }, // District Service Limit (original)
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Klyte45 is aware of issue but is currently fixing other mods. Check workshop page for progress updates." },
                },
                Published = WorkshopDate("22 Jan, 2019"),
                SourceURL = "https://github.com/klyte45/ServiceVehiclesManager",
                Updated = WorkshopDate("9 Jun, 2019"),
            });

            AddMod(new Review(1181352643uL, "District Service Limit 3.0") {
                Affect = Factor.Service
                       | Factor.Vehicles,
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 649522495uL , Status.Incompatible }, // District Service Limit
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                ContinuationOf = 649522495uL, // District Service Limit
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some users report it breaks deathcare, garbage and other services." },
                    { NOTE, "Campus DLC: Deactivate 'Education in current district' for compatibility." },
                    { 1420955187uL, "[Mod: Real Time] For compatibility, disable citizen limiting options in District Service Limit." },
                },
                // ReplaceWith = 927293560uL, // Geli Districts (also seems broken)
                SourceURL = "https://github.com/TheDogKSP/cs-districts",
            });

            AddMod(new Review(934994075uL, "Service Vehicle Selector 2") {
                Affect = Factor.Service
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1764208250uL, Status.Unknown      }, // More Vehicles
                    { 1680840913uL, Status.Unknown      }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (alters vehicle AIs)
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 871859856uL , Status.Incompatible }, // RiverCargoHarborMod
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT) - original ver
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 519691655uL, // Service Vehicle Selector
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("28 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-ServiceVehicleSelector",
                Updated = WorkshopDate("2 Apr, 2020"),
            });

            // prolly cont. of dsl3
            AddMod(new Review(927293560uL, "Geli-Districts v3.0") {
                Affect = Factor.Service,
                Authors = "Geliboy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1706703944uL, Status.Incompatible }, // More Outside Interaction
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0 (cambrium)
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835391uL , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 785237088uL , Status.Compatible   }, // Service Radius Adjuster
                    { 649522495uL , Status.Incompatible }, // District Service Limit (Witcher) // gsteigert on github?
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 583552152uL , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 554232266uL , Status.Incompatible }, // Mod: Nursing Homes for Senior Citizens
                    { 512341354uL , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 439582006uL , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                    // Compatible with:
                    { 1420955187uL, Status.Compatible   }, // Real Time (dymanoid)
                    { 1749971558uL, Status.Compatible   }, // Real Time Offline
                    { 2016920607uL, Status.Compatible   }, // Ploppable RICO revisited
                    { 816260433uL , Status.Compatible   }, // Metro Overhaul Mod
                    { 605590542uL , Status.Compatible   }, // Rush Hour 2
                    // TMPE v11:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 649522495uL, // District Service Limit (Witcher)
                Flags = ItemFlags.Laggy // some users report lag, but could be mod conflict?
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 554232266uL, "[Mod: Nursing Homes for Senior Citizens] Breaks ambulances and hospitals when used with Geli-Districts." },
                },
                Published = WorkshopDate("17 May, 2017"),
                Updated = WorkshopDate("29 Jan, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2076619989uL, "934994075 Service Vehicle Selector 2") {
                Affect = Factor.Service
                       | Factor.Vehicles,
                Authors = "Bea",
                Catalog = catalog,
                CloneOf = 934994075uL, // Service Vehicle Selector 2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250uL, Status.Unknown      }, // More Vehicles
                    { 1680840913uL, Status.Unknown      }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (alters vehicle AIs)
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 871859856uL , Status.Incompatible }, // RiverCargoHarborMod
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 442167376uL , Status.Compatible   }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT) - original ver
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("28 Apr, 2020"),
                ReplaceWith = 934994075uL, // Service Vehicle Selector 2
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("28 Apr, 2020"),
            });

            // 439582006; [ARIS] Enhanced Garbage Truck AI
            // 583552152; Enhanced Garbage Truck AI[Fixed for v1.4 +]
            // 813835391; Enhanced Garbage Truck AI[1.6]

            // last seen:
            // 3 Mar, 2017 - based on user comment date mentioned in google search results
            // 6 Nov, 2017 - based on link to workshop here: http://www.citiesmods.com/enhanced-hearse-ai-1-6/
            AddMod(new Review(813835241uL, "Enhanced Hearse AI [1.6]") {
                Affect = Factor.Service,
                Alternatives = new[] {
                    1922400472uL, // Enhanced District Services
                    1680840913uL, // More Effective Transfer Manager
                    1181352643uL, // District Service Limit 3.0
                    927293560uL , // Geli-Districts v3.0
                },
                Authors = "Chryssie", // based on page at citiesmods.com above
                BrokenBy = GameVersion.Industries, // was listed broken on industries broken mods google sheet; may have broken earlier
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Required     }, // Skylines Overwatch [1.6]
                    { 803074771uL , Status.Incompatible }, // No Deathcare
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.Concerts, // it was still being linked to (LastSeen)
                ContinuationOf = 583556014uL, // Enhanced Hearse AI [Fixed for v1.4 +]
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 Nov, 2017"), // based on page at citiesmods.com above
                Published = WorkshopDate("7 Dec, 2016"), // based on adjacent workshop item
                Removed = WorkshopDate("21 May, 2019"), // removed from broken mods google sheet (was there for Industries)
                ReplaceWith = 2077426488uL, // Super Hearse AI [Beta]
                SourceURL = "https://github.com/Chryssie/CS-EnhancedHearseAI",
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("7 Dec, 2016"), // based on last commit to git repo
            });

            // released for csl 1.2
            AddMod(new Review(583556014uL, "Enhanced Hearse AI [Fixed for v1.4 +]") {
                Affect = Factor.Service,
                Alternatives = new[] {
                    1922400472uL, // Enhanced District Services
                    1680840913uL, // More Effective Transfer Manager
                    1181352643uL, // District Service Limit 3.0
                    927293560uL , // Geli-Districts v3.0
                },
                Authors = "Akira Ishizaki",
                BrokenBy = GameVersion.MatchDay, // based on user comments
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 803074771uL , Status.Incompatible }, // No Deathcare
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Required     }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.Patch_1_4_0_f3,
                ContinuationOf = 433249875uL, // [ARIS] Enhanced Hearse AI
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("7 May, 2020"),
                Published = WorkshopDate("25 Dec, 2015"),
                ReplaceWith = 2077426488uL, // Super Hearse AI [Beta]
                SourceURL = "https://github.com/akira-ishizaki/CS-EnhancedHearseAI/tree/develop",
                Updated = WorkshopDate("27 Mar, 2016"),
            });

            AddMod(new Review(529979180uL, "CSL Service Reserve") {
                Affect = Factor.Service,
                Authors = "knighthawkGP",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("7 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Covers services up to and including Mass Transit. Services added in subsequent game updates are treated as normal vehicles." },
                    { NOTE, "Settings guide: https://steamcommunity.com/workshop/filedetails/discussion/529979180/483366528917557909/" },
                },
                Published = WorkshopDate("4 Oct, 2015"),
                SourceURL = "https://github.com/Knighth/CSLServiceReserve",
                Updated = WorkshopDate("18 May, 2017"),
            });

            // old version
            AddMod(new Review(519691655uL, "Service Vehicle Selector") {
                Affect = Factor.Other,
                ArchiveURL = "https://web.archive.org/web/20170330013917/http://steamcommunity.com/sharedfiles/filedetails/?id=519691655",
                Authors = "DontCryJustDie",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("30 Mar, 2017"), // web archive
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod fell in to disrepair when Natural Disasters was released, due to helicopters spawning from road-vehicle buildings." },
                },
                Published = WorkshopDate("17 Sep, 2015"),
                Removed = WorkshopDate("7 Jul, 2018"), // web archive
                ReplaceWith = 934994075uL, // Service Vehicle Selector 2
                Updated = WorkshopDate("9 Jun, 2016"),
            });

            // this was continuation of SOM: https://www.reddit.com/r/CitiesSkylines/comments/3420af/enhanced_hearse_ai_som_services_optimization/
            AddMod(new Review(433249875uL, "[ARIS] Enhanced Hearse AI") {
                Affect = Factor.Service,
                Alternatives = new[] {
                    1922400472uL, // Enhanced District Services
                    1680840913uL, // More Effective Transfer Manager
                    1181352643uL, // District Service Limit 3.0
                    927293560uL , // Geli-Districts v3.0
                },
                Authors = "Soda",
                BrokenBy = GameVersion.AfterDark, // based on 583556014uL initial release being fixed for 1.2+
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 803074771uL , Status.Incompatible }, // No Deathcare
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Required     }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.Patch_1_1_1,
                ContinuationOf = 413847191uL, // SOM - Services Optimisation Module
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("7 May, 2020"),
                Published = WorkshopDate("27 Apr, 2015"),
                ReplaceWith = 2077426488uL, // Super Hearse AI [Beta]
                SourceURL = "https://github.com/arislancrescent/CS-EnhancedHearseAI",
                Updated = WorkshopDate("9 May, 2015"),
            });

            // 413847191; SOM - Services Optimisation Module
            AddMod(new Review(413847191uL, "[Deprecated] SOM - Services Optimization Module") {
                Affect = Factor.Service,
                Alternatives = new[] {
                    1922400472uL, // Enhanced District Services
                    1680840913uL, // More Effective Transfer Manager
                    1181352643uL, // District Service Limit 3.0
                    927293560uL , // Geli-Districts v3.0
                },
                Authors = "Soda",
                BrokenBy = GameVersion.EuropeBiome, // guessing; the hearse/garbage ai mods replaced SOM at that point
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1922400472uL, Status.Incompatible }, // Enhanced District Services
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1680840913uL, Status.Incompatible }, // More Effective Transfer Manager
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1181352643uL, Status.Incompatible }, // District Service Limit 3.0
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 803074771uL , Status.Incompatible }, // No Deathcare
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.Patch_1_0_7c,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable, // checked git repo (same as advanced hearse ai) but could not find this project
                LastSeen = WorkshopDate("7 May, 2020"),
                Published = WorkshopDate("25 Mar, 2015"),
                ReplaceWith = 1680840913uL, // More Effective Transfer Manager
                Updated = WorkshopDate("30 Mar, 2015"),
            });

        }
    }
}