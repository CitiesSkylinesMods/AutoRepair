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
        private void TrafficMods() {

            string catalog = "Traffic";

            string[] v11languages = new[] { "de", "en", "en-gb", "es", "fr", "hu", "it", "ja", "ko", "nl", "pl", "pt", "ru", "tr", "uk", "zh", "zh-tw", };
            string[] v10languages = new[] { "de", "en", "es", "fr", "it", "ja", "ko", "nl", "pl", "pt", "ru" };

            AddMod(new Review(1829496988uL, "Adjust Pathfinding") {
                Affect = Factor.Pathfinder
                       | Factor.Vehicles,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // current TM:PE
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
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
                    // other
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 949504539uL , Status.Unknown      }, // SingleTrainTrackAI
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Strdate/AdjustPathfinding",
            });

            AddMod(new Review(1806963141uL, "TM:PE v11.1.2 LABS") {
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
                    // Current versions of TM:PE
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager (11.0-alpha6 clone)
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
                    // ARIS Hearse AI (breaks AI)
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    // ARIS Garbage AI (breaks AI)
                    { 813835391uL , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 583552152uL , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 439582006uL , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    // ARIS Remove Stuck (use TM:PE "Reset Stuck Vehicles and Cims" instead)
                    { 813834836uL , Status.Incompatible }, // Remove Stuck Vehicles [1.6]
                    { 587530437uL , Status.Incompatible }, // Remove Stuck Vehicles [Fixed for v1.4+]
                    { 428094792uL , Status.Incompatible }, // [ARIS] Remove Stuck Vehicles
                    // ARIS Overwatch (breaks game)
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    // Old anarchy mods (make a huge mess of networks and terrain!)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 912329352uL , Status.Incompatible }, // Building Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                    // Obsolete road mods (fix with "Road Removal Tool" and "Safenets" mods)
                    { 929114228uL , Status.Incompatible }, // New Roads for Network Extensions
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project (v1)
                    { 414702884uL , Status.Incompatible }, // Zoneable Pedestrian Paths
                    // Incompatible with TM:PE (patch conflicts or does not fire events)
                    { 649522495uL , Status.Incompatible }, // District Service Limit
                    { 844180955uL , Status.Incompatible }, // City Drive
                    { 512341354uL , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 413847191uL , Status.Incompatible }, // SOM - Services Optimisation Module
                    // Reported to cause lane usage issues in TM:PE
                    { 810858473uL , Status.Compatible   }, // Traffic Report Mod: Updated
                    { 408092246uL , Status.Incompatible }, // Traffic Report Tool 2.0
                    // Other breaking mods
                    { 1767246646uL, Status.Incompatible }, // AutoLineBudget (PropVehCount errors, using .Net Framework 2, published as camera script?!!)
                    { 1072157697uL, Status.Incompatible }, // Cargo Info
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                    { 417926819uL , Status.Incompatible }, // Road Assistant
                    // Mods made obsolete by TM:PE (and conflict with TM:PE patches/state)
                    { 1628112268uL, Status.Incompatible }, // RightTurnNoStop
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 600733054uL , Status.Incompatible }, // No On-Street Parking
                    { 529979180uL , Status.Incompatible }, // CSL Service Reserve
                    { 411833858uL , Status.Incompatible }, // Toggle Traffic Lights
                    { 407335588uL , Status.Incompatible }, // No Despawn Mod
                    // Transport line mods
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.MinorIssues  }, // New American Traffic Lights
                    // prop removers
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1627469414uL, Status.Compatible   }, // No Parking
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                    { 956707300uL , Status.Compatible   }, // Remove Street Arrows
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                    // Other mods
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2019097300uL, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Compatible   }, // CSUR ToolBox
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Recommended  }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Compatible   }, // Adjust Pathfinding
                    { 1803209875uL, Status.Compatible   }, // Trees Respiration
                    { 1764208250uL, Status.Compatible   }, // More Vehicles
                    { 1633580257uL, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1586774819uL, Status.Compatible   }, // Other Rail Track Speed Increaser
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1192503086uL, Status.Compatible   }, // Real City V9.0.03.14
                    { 949504539uL , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                    { 726005715uL , Status.MinorIssues  }, // Roads United: Core+
                    { 633547552uL , Status.MinorIssues  }, // Roads United Core 2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector (old version)
                    { 457516262uL , Status.Compatible   }, // Rail Track Speed Increaser 2.2.1
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1637663252uL, // TM:PE V11 STABLE (Krzychu1245)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorIssues // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Languages = v11languages,
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Troubleshooting" },
                    { NOTE, "Vehicles despawning after altering roads? Use Broken Nodes Detector: https://steamcommunity.com/sharedfiles/filedetails/?id=1777173984" },
                    { NOTE, "Setting 'Simulation Accuracy' to lower value will reduce lag (but impair junction customisations)." },
                    { NOTE, "Sunset Harbor: Updated, but might be some issues with pedestrian pathfinding (investigating)." },
                    { NOTE, "[Mod: CSM - Cities Skylines Multiplayer] Some users report it's incompatible with TM:PE" },
                    { 1586027591uL, "[Mod: Tiny Segments] Very short road segments entering junctions may cause traffic to ignore customisations." },
                    { 949504539uL , "[SingleTrainTrackAI] Breaks rail junction customisations (traffic lights, priority signs, etc): https://github.com/CitiesSkylinesMods/TMPE/issues/787" },
                    { 726005715uL , "[Mod: Roads United: Core+] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 633547552uL , "[Mod: Roads United Core 2.0] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                SourceURL = "https://github.com/CitiesSkylinesMods/TMPE",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Review(1637663252uL, "TM:PE V11 STABLE") {
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
                    // { 1875298330uL, Status.Incompatible }, // Extended Building Information
                    // Not sure how that could be possible, but keeping here for future ref.

                    // Current versions of TM:PE
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager (11.0-alpha6 clone)
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
                    // ARIS Hearse AI (breaks AI)
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    // ARIS Garbage AI (breaks AI)
                    { 813835391uL , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 583552152uL , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 439582006uL , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    // ARIS Remove Stuck (use TM:PE "Reset Stuck Vehicles and Cims" instead)
                    { 813834836uL , Status.Incompatible }, // Remove Stuck Vehicles [1.6]
                    { 587530437uL , Status.Incompatible }, // Remove Stuck Vehicles [Fixed for v1.4+]
                    { 428094792uL , Status.Incompatible }, // [ARIS] Remove Stuck Vehicles
                    // ARIS Overwatch (breaks game)
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    // Old anarchy mods (make a huge mess of networks and terrain!)
                    { 954034590uL , Status.Incompatible }, // Road Anarchy V2
                    { 912329352uL , Status.Incompatible }, // Building Anarchy
                    { 658653260uL , Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                    { 411095553uL , Status.Incompatible }, // Terraform Tool v0.9
                    // Obsolete road mods (fix with "Road Removal Tool" and "Safenets" mods)
                    { 929114228uL , Status.Incompatible }, // New Roads for Network Extensions
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project (v1)
                    { 414702884uL , Status.Incompatible }, // Zoneable Pedestrian Paths
                    // Incompatible with TM:PE (patch conflicts or does not fire events)
                    { 649522495uL , Status.Incompatible }, // District Service Limit
                    { 844180955uL , Status.Incompatible }, // City Drive
                    { 512341354uL , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 413847191uL , Status.Incompatible }, // SOM - Services Optimisation Module
                    // Reported to cause lane usage issues in TM:PE
                    { 810858473uL , Status.Compatible   }, // Traffic Report Mod: Updated
                    { 408092246uL , Status.Incompatible }, // Traffic Report Tool 2.0
                    // Other breaking mods
                    { 1767246646uL, Status.Incompatible }, // AutoLineBudget (PropVehCount errors, using .Net Framework 2, published as camera script?!!)
                    { 1072157697uL, Status.Incompatible }, // Cargo Info
                    { 436253779uL , Status.Incompatible }, // Road Protractor
                    { 417926819uL , Status.Incompatible }, // Road Assistant
                    // Mods made obsolete by TM:PE (and conflict with TM:PE patches/state)
                    { 1628112268uL, Status.Incompatible }, // RightTurnNoStop
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 600733054uL , Status.Incompatible }, // No On-Street Parking
                    { 529979180uL , Status.Incompatible }, // CSL Service Reserve
                    { 411833858uL , Status.Incompatible }, // Toggle Traffic Lights
                    { 407335588uL , Status.Incompatible }, // No Despawn Mod
                    // Transport line mods
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.MinorIssues  }, // New American Traffic Lights
                    // prop removers
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1627469414uL, Status.Compatible   }, // No Parking
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                    { 956707300uL , Status.Compatible   }, // Remove Street Arrows
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                    // Other mods
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2019097300uL, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Compatible   }, // CSUR ToolBox
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Recommended  }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Compatible   }, // Adjust Pathfinding
                    { 1803209875uL, Status.Compatible   }, // Trees Respiration
                    { 1764208250uL, Status.Compatible   }, // More Vehicles
                    { 1633580257uL, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1586774819uL, Status.Compatible   }, // Other Rail Track Speed Increaser
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1192503086uL, Status.Compatible   }, // Real City V9.0.03.14
                    { 949504539uL , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 927293560uL , Status.Compatible   }, // Geli-Districts v3.0
                    { 726005715uL , Status.MinorIssues  }, // Roads United: Core+
                    { 633547552uL , Status.MinorIssues  }, // Roads United Core 2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector (old version)
                    { 457516262uL , Status.Compatible   }, // Rail Track Speed Increaser 2.2.1
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 583429740uL, // TM:PE 10.20 (LinuxFan)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorIssues // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Languages = v11languages,
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Troubleshooting" },
                    { NOTE, "Setting 'Simulation Accuracy' to lower value will improve framerate." },
                    { NOTE, "Setting 'Simulation Accuracy' to higher value will improve vehicle behaviour at junctions." },
                    { NOTE, "Sunset Harbor: Updated, but might be some issues with pedestrian pathfinding (investigating)." },
                    { 1586027591uL, "[Mod: Tiny Segments] Very short road segments entering junctions may cause traffic to ignore customisations." },
                    { 949504539uL , "[SingleTrainTrackAI] Breaks rail junction customisations (traffic lights, priority signs, etc)." },
                    { 726005715uL , "[Mod: Roads United: Core+] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 633547552uL , "[Mod: Roads United Core 2.0] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                SourceURL = "https://github.com/CitiesSkylinesMods/TMPE",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Review(1586774819uL, "Other Rail Track Speed Increaser") {
                Affect = Factor.TransportPreference
                       | Factor.Velocity,
                Authors = "DAV",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1586774819uL, Status.Incompatible }, // Other Rail Track Speed Increaser
                    { 457516262uL , Status.Incompatible }, // Rail Track Speed Increaser 2.2.1
                    // Current versions of TM:PE
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    // tracks:
                    { 1577943878uL, Status.Compatible   }, // Rail-Over-Road Train Tracks
                    { 1569088356uL, Status.Compatible   }, // Railway
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("9 Dec, 2018"),
                SourceURL = "https://pastebin.com/sDbefj5J",
                Updated = WorkshopDate("19 Jan, 2019"),
            });

            AddMod(new Review(949504539uL, "SingleTrainTrackAI") {
                Affect = Factor.TrafficLights
                       | Factor.TransportLines
                       | Factor.Vehicles,
                Authors = "CoarzFlovv",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1829496988uL, Status.Unknown      }, // Adjust Pathfinding
                    // TMPE minor issues: https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE V11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1806963141uL, "[Mod: TM:PE] SingleTrainTrackAI breaks TM:PE rail junction customisations (traffic lights, priority signs, etc)." },
                    { 1637663252uL, "[Mod: TM:PE] SingleTrainTrackAI breaks TM:PE rail junction customisations (traffic lights, priority signs, etc)." },
                },
                SourceURL = "https://github.com/coarxflow/SingleTrainTrackAI",
            });

            AddMod(new Review(810858473uL, "Traffic Report Mod: Updated") {
                Affect = Factor.Pathfinder
                       | Factor.UI,
                Authors = "tony56a",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    { 810858473uL , Status.Incompatible }, // Traffic Report Mod: Updated
                    { 408092246uL , Status.Incompatible }, // Traffic Report Tool 2.0
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 408092246uL, // Traffic Report Tool 2.0
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some users report that it causes game to start in traffic info view." },
                    { NOTE, "Vanilla game now has traffic routes tool built-in: https://skylines.paradoxwikis.com/Info_views#Traffic_Routes" },
                    { NOTE, "If you only want to see where vehicles are going to from their current position, you won't need this mod." },
                },
                Published = WorkshopDate("2 Dec, 2016"),
                SourceURL = "https://github.com/tony56a/TrafficReport",
                Updated = WorkshopDate("2 Apr, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // clone of 11.0-alpha6 - already game breaking lol
            AddMod(new Review(2064509439uL, "TrafficManager") {
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
                Authors = "doido",
                BrokenBy = GameVersion.ParadoxLauncher,
                Catalog = catalog,
                CloneOf = 1806963141uL, // TM:PE v11.1.2 LABS
                CompatibleWith = GameVersion.Campus,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                },
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Old alpha release of TM:PE; not compatible with current game version." },
                },
                Published = WorkshopDate("17 Apr, 2020"),
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("17 Apr, 2020"),
            });

            AddMod(new Review(1957033250uL, "TrafficManager Fixed for industry DLC") {
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
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                },
                ContinuationOf = 583429740uL, // Traffic Manager: President Edition (LinuxFan)
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
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                Suppress = Warning.OlderReplacement,
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });

            AddMod(new Review(1604291910uL, "498363759 Traffic Manager + Improved AI") {
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
                CloneOf = 498363759uL, // Traffic Manager + Improved AI
                CompatibleWith = GameVersion.MassTransit,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("27 Dec, 2018"),
                ReleasedDuring = GameVersion.Campus, // yes, really.
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                Suppress = Warning.InvalidVersionSequence,
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
                Updated = WorkshopDate("27 Dec, 2018"),
            });

            AddMod(new Review(1546870472uL, "TrafficManager Fixed for industry DLC") {
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
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                },
                ContinuationOf = 583429740uL, // Traffic Manager: President Edition (LinuxFan)
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
                LastSeen = WorkshopDate("21 May, 2019"),
                Locale = "en",
                Published = WorkshopDate("24 Oct, 2018"),
                Removed = WorkshopDate("22 Mar, 2020"),
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                Suppress = Warning.MissingArchiveURL,
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
                Updated = WorkshopDate("24 Oct, 2018"),
            });

            // Had a modified Hearse AI
            AddMod(new Review(1348361731uL, "Traffic Manager: President Edition ALPHA/DEBUG") {
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
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 949504539uL , Status.Incompatible }, // SingleTrainTrackAI
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                },
                ContinuationOf = 583429740uL, // Traffic Manager: President Edition (LinuxFan)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Languages = v10languages,
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("31 Mar, 2018"),
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                SourceURL = "https://github.com/thardie/Cities-Skylines-Traffic-Manager-President-Edition",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
                Updated = WorkshopDate("1 Apr, 2018"),
            });

            AddMod(new Review(583429740uL, "Traffic Manager: President Edition [STABLE]") {
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
                ArchiveURL = "https://web.archive.org/web/20200317042008/http://steamcommunity.com/sharedfiles/filedetails/?id=583429740",
                Authors = "LinuxFan",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2019097300uL, Status.Incompatible }, // Hide TM:PE Unconnected Tracks
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1959342332uL, Status.Incompatible }, // CSUR ToolBox
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1939169189uL, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593uL, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988uL, Status.Incompatible }, // Adjust Pathfinding
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1633580257uL, Status.Incompatible }, // Vehicle Wealthizer 2
                    { 1627469414uL, Status.Compatible   }, // No Parking
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591uL, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 956707300uL , Status.Compatible   }, // Remove Street Arrows
                    { 949504539uL , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 927293560uL , Status.Incompatible }, // Geli-Districts v3.0
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                    { 844180955uL , Status.Incompatible }, // City Drive
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090uL, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.MinorIssues  }, // New American Traffic Lights
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 568443446, // Traffic Manager Plus 1.2.0
                Flags = ItemFlags.Abandonware // replaced by v11 branch
                      | ItemFlags.BrokenByUpdate // Sunset Harbor
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // traffic spawning breaks in sunset harbor
                      | ItemFlags.Laggy
                      | ItemFlags.Localised
                      | ItemFlags.MinorIssues // won't get fixed as development has moved to v11
                      | ItemFlags.NoWorkshop // some time around 6th March 2020
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Languages = v10languages,
                LastSeen = WorkshopDate("1 Apr, 2020"), // still there but hidden
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "THIS VERSION OF TM:PE IS NO LONGER MAINTAINED, PRESS 'F' TO PAY RESPECTS." },
                    { NOTE, "LinuxFan no longer plays the game so this version will NOT be updated; use TM:PE v11 STABLE instead." },
                },
                Published = WorkshopDate("25 Dec, 2015"),
                Removed = WorkshopDate("1 Apr, 2020"),
                ReplaceWith = 1637663252uL, // TM:PE V11 STABLE
                SourceURL = "https://github.com/VictorPhilipp/Cities-Skylines-Traffic-Manager-President-Edition",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
                Updated = WorkshopDate("21 May, 2019"),
            });

            AddMod(new Review(457516262uL, "Rail Track Speed Increaser 2.2.1") {
                Affect = Factor.TransportPreference
                       | Factor.Velocity,
                Authors = "DontCryJustDie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1586774819uL, Status.Incompatible }, // Other Rail Track Speed Increaser
                    { 457516262uL , Status.Incompatible }, // Rail Track Speed Increaser 2.2.1
                    // Current versions of TM:PE
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    // tracks:
                    { 1577943878uL, Status.Incompatible }, // Rail-Over-Road Train Tracks
                    { 1569088356uL, Status.Incompatible }, // Railway
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("8 Jun, 2015"),
                ReplaceWith = 1586774819uL, // Other Rail Track Speed Increaser
                SourceURL = "https://pastebin.com/QvxKyyN1",
                Updated = WorkshopDate("20 Mar, 2016"),
            });

            AddMod(new Review(408092246uL, "Traffic Report Tool 2.0") {
                Affect = Factor.Pathfinder
                       | Factor.UI,
                Authors = "LisaLionheart",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 810858473uL , Status.Incompatible }, // Traffic Report Mod: Updated
                    { 408092246uL , Status.Incompatible }, // Traffic Report Tool 2.0
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("26 Jun, 2017"), // web archive
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Vanilla game now has traffic routes tool built-in: https://skylines.paradoxwikis.com/Info_views#Traffic_Routes" },
                    { NOTE, "If you only want to see where vehicles are going to from their current position, you won't need this mod." },
                },
                Published = WorkshopDate("15 Mar, 2015"), // based on adjacent items
                Removed = WorkshopDate("28 Jul, 2017"), // web archive
                ReplaceWith = 810858473uL, // Traffic Report Mod: Updated
                SourceURL = "https://github.com/lisa-lionheart/TrafficReport/",
                Updated = WorkshopDate("31 Mar, 2016"), // web archive
            });
        }
    }
}