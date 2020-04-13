namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods which affect public transport, transport lines, waiting times, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void PublicTransportMods() {

            string catalog = "PublicTransport";

            // looks like update to Extended Public Transport UI, that's compatibile or merged with TLM
            AddMod(new Review(2009172305u, "EPTUI TLM Integration (Beta)") {
                Affect = Factor.TransportLines,
                Authors = "Arturj07",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778u, Status.Incompatible }, // ScaleUI
                    { 2009172305u, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150u , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 411164732u , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401u , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string> {
                    { NOTE, "This appears to be update to Extended Public Transport UI. Author is not responsive." },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
            });

            // todo: check if this causes stuck cims
            AddMod(new Review(1776052533u, "Stops & Stations") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "dymanoid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT) -- old ver
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/dymanoid/StopsAndStations",
            });

            AddMod(new Review(1766839841u, "Anxiety Reducer") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1420955187u, Status.MinorIssues  }, // Real Time (still investigating)
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT) -- old ver
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1394468624u, "Advanced Stop Selection (ex MTSE)") {
                Affect = Factor.TransportLines,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 532863263u, Status.Incompatible }, // [deprecated] Multi-Track Station Enabler 1.2.0
                    { 442957897u, Status.Incompatible }, // [Obsolete] Multi-Track Station Enabler
                    { 409184143u, Status.Incompatible }, // Traffic++
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedStopSelection",
            });

            AddMod(new Review(1393820309u, "Ticket Price Customizer") {
                Affect = Factor.Revenue
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Values in options screen are divided by 100 in-game, so if you want price 2.80 set option value to 280." },
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/bloodypenguin/Skylines-TicketPriceCustomizer",
            });

            AddMod(new Review(1312767991u, "Transport Lines Manager 13.1") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                Catalog = catalog,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1776052533u, Status.Compatible   }, // Stops & Stations
                    { 1766839841u, Status.Compatible   }, // Anxiety Reducer
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309u, Status.Incompatible }, // Ticket Price Customizer
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337u, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 929654063u, // Transport Lines Manager Reborn 8.0.3
                Languages = new[] { "en", "pt", "ko", "de", "nl", "pl", "zh-cn", "fr", "es" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 928128676u, "[Mod: Improved Public Transport] Massive lag when IPT and TLM are used together. Unsubscribe one of them." },
                },
                ReleasedDuring = GameVersion.GreenCities,
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

            // Based on user comments some major bugs with this:
            // * Causes problems with route creation
            // * Often adds too many vehicles (even after waiting for it to settle after few day/night cycles)
            AddMod(new Review(1218121337u, "Automatic Vehicle Numbers Adjuster") {
                Affect = Factor.TransportLines,
                Authors = "Overhatted",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: likely IPT and maybe others
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users report this mod causes problems with route creation." },
                    { NOTE, "Users report this mod adds excessive numbers of vehicles to lines\n   (even after waiting few game dayes for it to settle)." },
                },
                SourceURL = "https://cld.pt/dl/download/0d0cc60b-6568-4618-90f5-ed687b9d8eed/AutomaticVehicleNumbersAdjuster.zip",
            });

            AddMod(new Review(928128676, "Improved Public Transport 2") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1776052533u, Status.Compatible   }, // Stops & Stations
                    { 1766839841u, Status.Compatible   }, // Anxiety Reducer
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1632320836u, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337u, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2 (BP's version)
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 531401164u , Status.Incompatible }, // Vehicle Unbuncher
                    { 472128528u , Status.Incompatible }, // Larger Footprints (Snowfall)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT) - original ver
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 424106600u, // Improved Public Transport (IPT)
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1312767991u, "[Mod: Transport Lines Manager] Massive lag when IPT and TLM are used together. Unsubscribe one of them." },
                    { 472128528u , "[Mod: Larger Footprints] Causes 'Depot not found' errors." },
                },
                Published = WorkshopDate("18 May, 2017"),
                SourceURL = "https://github.com/bloodypenguin/ImprovedPublicTransport",
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // old version
            AddMod(new Review(929654063u, "Transport Lines Manager Reborn 8.0.3") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                BrokenBy = GameVersion.ParkLife, // was already replaced by new mod by then
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with overwatch/aris mods
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309u, Status.Incompatible }, // Ticket Price Customizer
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337u, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.GreenCities,
                ContinuationOf = 408875519u, // Transport Lines Manager
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // park life
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Localised
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable, // same repo as new version
                Languages = new[] { "en", "de", "zh-cn", "pl", "pt", "ko", },
                Locale = "en",
                ReleasedDuring = GameVersion.MassTransit,
                ReplaceWith = 1312767991u, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

            AddMod(new Review(714056356u, "Transport Line Rendering Fix") {
                Affect = Factor.TransportLines
                       | Factor.Rendering,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The vanilla game now includes this fix; you can unsubscribe this mod." },
                },
                Published = WorkshopDate("30 Jun, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TransportLineRenderingFix",
                Updated = WorkshopDate("14 Mar, 2018"),
            });


            // old version
            AddMod(new Review(424106600u, "Improved Public Transport (IPT)") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "DontCryJustDie",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // was compat with ancient versions of TMPE, but they all changed after mass transit
                    // was also compat with t++ v2 (now obsolete)
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337u, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2 (BP's version)
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 531401164u , Status.Incompatible }, // Vehicle Unbuncher
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Localised
                      | ItemFlags.NoWorkshop // removed jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "de", "es", "zh-cn", "pl", "it", "pt", "zh", "ru", "fr", "ko", },
                Locale = "en",
                ReleasedDuring = new Version(1, 0, 7), // before European buildings were added
                ReplaceWith = 928128676u, // Improved Public Transport 2
            });

            // old version
            AddMod(new Review(408875519u, "Transport Lines Manager") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                Authors = "Klyte45",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533u, Status.Incompatible }, // Stops & Stations
                    { 1766839841u, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309u, Status.Incompatible }, // Ticket Price Customizer
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337u, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655u , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.NaturalDisasters, // there was update on ND release day, assuming minor bug fixes
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // mass transit
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable, // same repo as new version
                ReleasedDuring = new Version(1, 0, 7), // before European buildings were added
                ReplaceWith = 1312767991u, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });
        }
    }
}