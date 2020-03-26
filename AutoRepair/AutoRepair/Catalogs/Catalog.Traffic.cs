namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Traffic (primarily pathfinder or vehicle AI) affecting mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void TrafficCatalog() {

            string catalog = "Traffic";

            string[] v11languages = new[] { "de", "en", "en-gb", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt", "ru", "tr", "uk", "zh", "zh-tw", };
            string[] v10languages = new[] { "de", "en", "es", "fr", "it", "ja", "ko", "nl", "pl", "pt", "ru" };

            AddMod(new Item(1829496988u, "Adjust Pathfinding") {
                Affect = Factor.Pathfinder
                       | Factor.Vehicles,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 949504539u , Status.Unknown      }, // SingleTrainTrackAI
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Strdate/AdjustPathfinding",
            });

            AddMod(new Item(1806963141u, "TM:PE v11.1.2 LABS") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.Pathfinder
                       | Factor.PlaceAndMove // anything that creates very small segments at junctions
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "Krzychu1245, kvakvs, LinuxFan, FireController#1847, kian.zarrin, aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Compatible   }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Recommended  }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Compatible   }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1637663252u, // TM:PE V11 STABLE (Krzychu1245)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Languages = v11languages,
                Locale = "en",
                Notes = new[] {
                    "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Troubleshooting",
                    "Setting 'Simulation Accuracy' to lower value will improve framerate.",
                    "Setting 'Simulation Accuracy' to higher value will improve vehicle behaviour at junctions.",
                    "If rail junction customiations not working, it is likely caused by SingleTrainTrackAI mod.",
                    "Sunset Harbor: Updated, but might be some issues with pedestrian pathfinding (investigating).",
                },
                SourceURL = "https://github.com/CitiesSkylinesMods/TMPE",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Item(1637663252u, "TM:PE V11 STABLE") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "Krzychu1245, kvakvs, LinuxFan, FireController#1847, kian.zarrin, aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Got one report that Extended Building Info mod might cause TM:PE to fail
                    // Not sure how that could be possible, but keeping here for future ref.
                    // { 1875298330u, Status.Incompatible }, // Extended Building Information
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Compatible   }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Recommended  }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Compatible   }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 583429740u, // TM:PE 10.20 (LinuxFan)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Languages = v11languages,
                Locale = "en",
                Notes = new[] {
                    "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Troubleshooting",
                    "Setting 'Simulation Accuracy' to lower value will improve framerate.",
                    "Setting 'Simulation Accuracy' to higher value will improve vehicle behaviour at junctions.",
                    "If rail junction customiations not working, it is likely caused by SingleTrainTrackAI mod.",
                    "Sunset Harbor: Updated, but might be some issues with pedestrian pathfinding (investigating).",
                },
                SourceURL = "https://github.com/CitiesSkylinesMods/TMPE",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Item(1596838226u, "Heavy Outside Traffic") {
                Affect = Factor.Immigrants
                       | Factor.OutsideConnection
                       | Factor.VehicleLimit
                       | Factor.Vehicles,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1721492498u, Status.Incompatible }, // Optimised Outside Connections
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(949504539u, "SingleTrainTrackAI") {
                Affect = Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.Vehicles,
                Authors = "CoarzFlovv",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1829496988u, Status.Unknown      }, // Adjust Pathfinding
                    // TMPE minor issues: https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE V11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new[] {
                    "Interferes with some rail junction features of TM:PE.",
                },
                SourceURL = "https://github.com/coarxflow/SingleTrainTrackAI",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1957033250u, "TrafficManager Fixed for industry DLC") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "591857426",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                CompatibleWith = GameVersion.Industries,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.Incompatible }, // SingleTrainTrackAI
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                ContinuationOf = 583429740u, // Traffic Manager: President Edition (LinuxFan)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Languages = v10languages,
                Locale = "en",
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Item(1604291910u, "498363759 Traffic Manager + Improved AI") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "leander123",
                BrokenBy = GameVersion.Concerts,
                Catalog = catalog,
                CloneOf = 498363759u, // Traffic Manager + Improved AI
                CompatibleWith = GameVersion.MassTransit,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.Incompatible }, // SingleTrainTrackAI
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus, // yes, really.
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                SkipVersionValidation = true,
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Item(1546870472u, "TrafficManager Fixed for industry DLC") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = string.Empty, // workshop page no longer exists
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                CompatibleWith = GameVersion.Industries,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.Incompatible }, // SingleTrainTrackAI
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                ContinuationOf = 583429740u, // Traffic Manager: President Edition (LinuxFan)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Languages = v10languages,
                Locale = "en",
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            // Had a modified Hearse AI
            AddMod(new Item(1348361731u, "Traffic Manager: President Edition ALPHA/DEBUG") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "tmhardie",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                CompatibleWith = GameVersion.ChirpX,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.Incompatible }, // SingleTrainTrackAI
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                ContinuationOf = 583429740u, // Traffic Manager: President Edition (LinuxFan)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Languages = v10languages,
                Locale = "en",
                ReleasedDuring = GameVersion.ChirpX,
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                SourceURL = "https://github.com/thardie/Cities-Skylines-Traffic-Manager-President-Edition",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Item(583429740u, "Traffic Manager: President Edition [STABLE]") {
                Affect = Factor.Despawn
                       | Factor.OutsideConnection
                       | Factor.PlaceAndMove // can be affected by other mods which affect that factor
                       | Factor.Pathfinder
                       | Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleInfo
                       | Factor.VehicleLimit
                       | Factor.Velocity,
                Authors = "LinuxFan",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2019097300u, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.MinorIssues  }, // Adjust Pathfinding
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257u, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.PdxLauncher,
                ContinuationOf = 568443446, // Traffic Manager Plus 1.2.0
                Flags = ItemFlags.Abandonware // replaced by v11 branch
                      | ItemFlags.BrokenByUpdate // Sunset Harbor
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // traffic spawning breaks in sunset harbor
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.MinorBugs // won't get fixed as development has moved to v11
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Languages = v10languages,
                Locale = "en",
                Notes = new[] {
                    "LinuxFan no longer plays the game so this v10.20 cannot be updated.",
                    "Please move to either TM:PE v11 STABLE or TM:PE v11 LABS for updated mod."
                },
                ReleasedDuring = GameVersion.AfterDark,
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                SourceURL = "https://github.com/VictorPhilipp/Cities-Skylines-Traffic-Manager-President-Edition",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });
        }
    }
}
