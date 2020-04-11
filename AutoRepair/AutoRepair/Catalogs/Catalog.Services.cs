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

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            AddMod(new Review(1922400472u, "Enhanced District Services") {
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
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1721492498u, Status.Recommended  }, // Optimised Outside Connections
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 785237088u , Status.Incompatible }, // Service Radius Adjuster
                    { 649522495u , Status.Incompatible }, // District Service Limit
                    { 554232266u , Status.Incompatible }, // Mod: Nursing Homes for Senior Citizens
                    { 512341354u , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 439582006u , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    { 433249875u , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/chronofanz/EnhancedDistrictServices",
            });

            AddMod(new Review(1680840913u, "More Effective Transfer Manager") {
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
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 934994075u , Status.Unknown      }, // Service Vehicle Selector 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
            });

            AddMod(new Review(1632320836u, "Service Vehicles Manager 2.0.1") {
                Affect = Factor.Service,
                Authors = "Klyte45",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Klyte45 is aware of issue but is currently fixing other mods. Check workshop page for progress updates." },
                },
                Published = WorkshopDate("22 Jan, 2019"),
                SourceURL = "https://github.com/klyte45/ServiceVehiclesManager",
                Updated = WorkshopDate("9 Jun, 2019"),
            });

            AddMod(new Review(1181352643u, "District Service Limit 3.0") {
                Affect = Factor.Service
                       | Factor.Vehicles,
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                },
                ContinuationOf = 649522495u, // District Service Limit
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some users report it breaks deathcare, garbage and other services." },
                    { NOTE, "Campus DLC: Deactivate 'Education in current district' for compatibility." },
                    { 1420955187u, "[Mod: Real Time] For compatibility, disable citizen limiting options in District Service Limit." },
                },
                // ReplaceWith = 927293560u, // Geli Districts (also seems broken)
                SourceURL = "https://github.com/TheDogKSP/cs-districts",
            });

            AddMod(new Review(934994075u, "Service Vehicle Selector 2") {
                Affect = Factor.Service
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1764208250u, Status.Unknown      }, // More Vehicles
                    { 1680840913u, Status.Unknown      }, // More Effective Transfer Manager
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (alters vehicle AIs)
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 871859856u , Status.Incompatible }, // RiverCargoHarborMod
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT) - original ver
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 519691655u, // Service Vehicle Selector
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("28 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-ServiceVehicleSelector",
                Updated = WorkshopDate("2 Apr, 2020"),
            });

            // prolly cont. of dsl3
            AddMod(new Review(927293560u, "Geli-Districts v3.0") {
                Affect = Factor.Service,
                Authors = "Geliboy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0 (cambrium)
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 813835391u , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 813835241u , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 785237088u , Status.Compatible   }, // Service Radius Adjuster
                    { 649522495u , Status.Incompatible }, // District Service Limit (Witcher) // gsteigert on github?
                    { 583556014u , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 583552152u , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 554232266u , Status.Incompatible }, // Mod: Nursing Homes for Senior Citizens
                    { 512341354u , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 439582006u , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    { 433249875u , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 413847191u , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                    // Compatible with:
                    { 1420955187u, Status.Compatible   }, // Real Time (dymanoid)
                    { 1749971558u, Status.Compatible   }, // Real Time Offline
                    { 2016920607u, Status.Compatible   }, // Ploppable RICO revisited
                    { 816260433u , Status.Compatible   }, // Metro Overhaul Mod
                    { 605590542u , Status.Compatible   }, // Rush Hour 2
                    // TMPE v11:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 649522495u, // District Service Limit (Witcher)
                Flags = ItemFlags.Laggy // some users report lag, but could be mod conflict?
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 554232266u, "[Mod: Nursing Homes for Senior Citizens] Breaks ambulances and hospitals when used with Geli-Districts." },
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

            // old version
            AddMod(new Review(519691655u, "Service Vehicle Selector") {
                Affect = Factor.Other,
                Authors = "DontCryJustDie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // removed jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 934994075u, // Service Vehicle Selector 2
            });

        }
    }
}