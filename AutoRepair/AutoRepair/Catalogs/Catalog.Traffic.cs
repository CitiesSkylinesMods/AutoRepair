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
                    // Current versions of TM:PE
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
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
                    // ARIS Hearse AI (breaks AI)
                    { 813835241u , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 583556014u , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 433249875u , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    // ARIS Garbage AI (breaks AI)
                    { 813835391u , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 583552152u , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 439582006u , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    // ARIS Remove Stuck (use TM:PE "Reset Stuck Vehicles and Cims" instead)
                    { 813834836u , Status.Incompatible }, // Remove Stuck Vehicles [1.6]
                    { 587530437u , Status.Incompatible }, // Remove Stuck Vehicles [Fixed for v1.4+]
                    { 428094792u , Status.Incompatible }, // [ARIS] Remove Stuck Vehicles
                    // ARIS Overwatch (breaks game)
                    { 813833476u , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 583538182u , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 421028969u , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    // Old anarchy mods (make a huge mess of networks and terrain!)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 912329352u,  Status.Incompatible }, // Building Anarchy (just sick of seeing this break games!)
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9 (just sick of seeing this break games!)
                    // Obsolete road mods (fix with "Road Removal Tool" and "Safenets" mods)
                    { 929114228u , Status.Incompatible }, // New Roads for Network Extensions
                    { 478820060u , Status.Incompatible }, // Network Extensions Project (v1)
                    { 414702884u,  Status.Incompatible }, // Zoneable Pedestrian Paths
                    // Incompatible with TM:PE (patch conflicts or does not fire events)
                    { 1803209875u, Status.Incompatible }, // Trees Respiration
                    { 649522495u , Status.Incompatible }, // District Service Limit
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 512341354u , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 413847191u , Status.Incompatible }, // SOM - Services Optimisation Module
                    // Reported to cause lane usage issues in TM:PE
                    { 810858473u , Status.Incompatible }, // Traffic Report Mod: Updated
                    { 408092246u , Status.Incompatible }, // Traffic Report Tool 2.0
                    // Other breaking mods
                    { 1767246646u, Status.Incompatible }, // AutoLineBudget (PropVehCount errors, using .Net Framework 2, published as camera script?!!)
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 436253779u,  Status.Incompatible }, // Road Protractor
                    { 417926819u,  Status.Incompatible }, // Road Assistant
                    // Mods made obsolete by TM:PE (and conflict with TM:PE patches/state)
                    { 1628112268u, Status.Incompatible }, // RightTurnNoStop
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 600733054u , Status.Incompatible }, // No On-Street Parking
                    { 529979180u , Status.Incompatible }, // CSL Service Reserve
                    { 411833858u , Status.Incompatible }, // Toggle Traffic Lights
                    { 407335588u , Status.Incompatible }, // No Despawn Mod
                    // Transport line mods
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.MinorIssues  }, // New American Traffic Lights
                    // prop removers
                    { 1962752152u, Status.Compatible   }, // Busstop Prop Remover
                    { 1627469414u, Status.Compatible   }, // No Parking
                    { 1320575938u, Status.Compatible   }, // Hide Traffic Lights
                    { 956707300u , Status.Compatible   }, // Remove Street Arrows
                    // Other mods
                    { 2019097300u, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Compatible   }, // CSUR ToolBox
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Recommended  }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Compatible   }, // Adjust Pathfinding
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1633580257u, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    //{ 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 726005715u , Status.MinorIssues  }, // Roads United: Core+
                    { 633547552u , Status.MinorIssues  }, // Roads United Core 2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (old version)

                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1637663252u, // TM:PE V11 STABLE (Krzychu1245)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
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
                    { 1586027591u, "[Mod: Tiny Segments] Very short road segments entering junctions may cause traffic to ignore customisations." },
                    { 949504539u , "[SingleTrainTrackAI] Breaks rail junction customisations (traffic lights, priority signs, etc)." },
                    { 726005715u , "[Mod: Roads United: Core+] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 633547552u , "[Mod: Roads United Core 2.0] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
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
                    // { 1875298330u, Status.Incompatible }, // Extended Building Information
                    // Not sure how that could be possible, but keeping here for future ref.

                    // Current versions of TM:PE
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
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
                    // ARIS Hearse AI (breaks AI)
                    { 813835241u , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 583556014u , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4+]
                    { 433249875u , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    // ARIS Garbage AI (breaks AI)
                    { 813835391u , Status.Incompatible }, // Enhanced Garbage Truck AI [1.6]
                    { 583552152u , Status.Incompatible }, // Enhanced Garbage Truck AI [Fixed for v1.4+]
                    { 439582006u , Status.Incompatible }, // [ARIS] Enhanced Garbage Truck AI
                    // ARIS Remove Stuck (use TM:PE "Reset Stuck Vehicles and Cims" instead)
                    { 813834836u , Status.Incompatible }, // Remove Stuck Vehicles [1.6]
                    { 587530437u , Status.Incompatible }, // Remove Stuck Vehicles [Fixed for v1.4+]
                    { 428094792u , Status.Incompatible }, // [ARIS] Remove Stuck Vehicles
                    // ARIS Overwatch (breaks game)
                    { 813833476u , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 583538182u , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 421028969u , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    // Old anarchy mods (make a huge mess of networks and terrain!)
                    { 954034590u , Status.Incompatible }, // Road Anarchy V2
                    { 912329352u,  Status.Incompatible }, // Building Anarchy (just sick of seeing this break games!)
                    { 658653260u,  Status.Incompatible }, // Network Nodes Editor [Experimental]
                    { 553184329u,  Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                    { 411095553u,  Status.Incompatible }, // Terraform Tool v0.9 (just sick of seeing this break games!)
                    // Obsolete road mods (fix with "Road Removal Tool" and "Safenets" mods)
                    { 929114228u , Status.Incompatible }, // New Roads for Network Extensions
                    { 478820060u , Status.Incompatible }, // Network Extensions Project (v1)
                    { 414702884u,  Status.Incompatible }, // Zoneable Pedestrian Paths
                    // Incompatible with TM:PE (patch conflicts or does not fire events)
                    { 1803209875u, Status.Incompatible }, // Trees Respiration
                    { 649522495u , Status.Incompatible }, // District Service Limit
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 512341354u , Status.Incompatible }, // Central Services Dispatcher (WtM)
                    { 413847191u , Status.Incompatible }, // SOM - Services Optimisation Module
                    // Reported to cause lane usage issues in TM:PE
                    { 810858473u , Status.Incompatible }, // Traffic Report Mod: Updated
                    { 408092246u , Status.Incompatible }, // Traffic Report Tool 2.0
                    // Other breaking mods
                    { 1767246646u, Status.Incompatible }, // AutoLineBudget (PropVehCount errors, using .Net Framework 2, published as camera script?!!)
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 436253779u,  Status.Incompatible }, // Road Protractor
                    { 417926819u,  Status.Incompatible }, // Road Assistant
                    // Mods made obsolete by TM:PE (and conflict with TM:PE patches/state)
                    { 1628112268u, Status.Incompatible }, // RightTurnNoStop
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 600733054u , Status.Incompatible }, // No On-Street Parking
                    { 529979180u , Status.Incompatible }, // CSL Service Reserve
                    { 411833858u , Status.Incompatible }, // Toggle Traffic Lights
                    { 407335588u , Status.Incompatible }, // No Despawn Mod
                    // Transport line mods
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.MinorIssues  }, // New American Traffic Lights
                    // prop removers
                    { 1962752152u, Status.Compatible   }, // Busstop Prop Remover
                    { 1627469414u, Status.Compatible   }, // No Parking
                    { 1320575938u, Status.Compatible   }, // Hide Traffic Lights
                    { 956707300u , Status.Compatible   }, // Remove Street Arrows
                    // Other mods
                    { 2019097300u, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1959342332u, Status.Compatible   }, // CSUR ToolBox
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1939169189u, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Recommended  }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1829496988u, Status.Compatible   }, // Adjust Pathfinding
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1633580257u, Status.Compatible   }, // Vehicle Wealthizer 2
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    //{ 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 726005715u , Status.MinorIssues  }, // Roads United: Core+
                    { 633547552u , Status.MinorIssues  }, // Roads United Core 2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (old version)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 583429740u, // TM:PE 10.20 (LinuxFan)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Languages = v11languages,
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Troubleshooting" },
                    { NOTE, "Setting 'Simulation Accuracy' to lower value will improve framerate." },
                    { NOTE, "Setting 'Simulation Accuracy' to higher value will improve vehicle behaviour at junctions." },
                    { NOTE, "Sunset Harbor: Updated, but might be some issues with pedestrian pathfinding (investigating)." },
                    { 1586027591u, "[Mod: Tiny Segments] Very short road segments entering junctions may cause traffic to ignore customisations." },
                    { 949504539u , "[SingleTrainTrackAI] Breaks rail junction customisations (traffic lights, priority signs, etc)." },
                    { 726005715u , "[Mod: Roads United: Core+] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 633547552u , "[Mod: Roads United Core 2.0] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
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
                Notes = new Dictionary<ulong, string>() {
                    { 1806963141u, "[Mod: TM:PE] SingleTrainTrackAI breaks TM:PE rail junction customisations (traffic lights, priority signs, etc)." },
                    { 1637663252u, "[Mod: TM:PE] SingleTrainTrackAI breaks TM:PE rail junction customisations (traffic lights, priority signs, etc)." },
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
                    // Traffic lights
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
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
                SuppressOlderReplacementWarning = true,
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
                    // Traffic lights
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
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
                SuppressVersionWarnings = true,
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
                    // Traffic lights
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
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
                    // Traffic lights
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
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
                    { 1962752152u, Status.Compatible   }, // Busstop Prop Remover
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
                    { 1627469414u, Status.Compatible   }, // No Parking
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 956707300u , Status.Compatible   }, // Remove Street Arrows
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 927293560u , Status.Incompatible }, // Geli-Districts v3.0
                    { 844180955u , Status.Incompatible }, // City Drive
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                    // Traffic lights
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.MinorIssues  }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.MinorIssues  }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.MinorIssues  }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.MinorIssues  }, // New American Traffic Lights
                    { 1320575938u, Status.Compatible   }, // Hide Traffic Lights
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "THIS VERSION OF TM:PE IS NO LONGER MAINTAINED, PRESS 'F' TO PAY RESPECTS." },
                    { NOTE, "LinuxFan no longer plays the game so this mod will NOT be updated; use TM:PE v11 STABLE instead." },
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
