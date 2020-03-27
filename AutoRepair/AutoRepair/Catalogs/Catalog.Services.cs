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
        private void ServicesCatalog() {

            string catalog = "Services";

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            AddMod(new Item(1922400472u, "Enhanced District Services") {
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
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/chronofanz/EnhancedDistrictServices",
            });

            AddMod(new Item(1680840913u, "More Effective Transfer Manager") {
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
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
            });

            AddMod(new Item(1632320836u, "Service Vehicles Manager 2.0.1") {
                Affect = Factor.Service,
                Authors = "Klyte45",
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
                SourceURL = "https://github.com/klyte45/ServiceVehiclesManager",
            });

            // todo: move to vehicle cat?
            AddMod(new Item(1192250578u, "Emergency Lights Manager") {
                Affect = Factor.Rendering
                       | Factor.Service,
                Authors = "Cryptkeeper",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 863909323u, Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u, Status.Incompatible }, // Emergency Light Changer
                },
                ContinuationOf = 863909323u, // Emergency Lights Changer Plus
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1181352643u, "District Service Limit 3.0") {
                Affect = Factor.Service,
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1706703944u, Status.Incompatible }, // More Outside Interaction
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 649522495u , Status.Incompatible }, // District Service Limit
                },
                ContinuationOf = 649522495u, // District Service Limit
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                Notes = new[] {
                    "Lots of users report this mod no longer works for them.",
                    "[Mod: Real Time] Disable citizen-limiting options in DSL mod to be compatible.",
                },
                // ReplaceWith = 927293560u, // Geli Districts (also seems broken)
                SourceURL = "https://github.com/TheDogKSP/cs-districts",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // old version
            AddMod(new Item(519691655u, "Service Vehicle Selector") {
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