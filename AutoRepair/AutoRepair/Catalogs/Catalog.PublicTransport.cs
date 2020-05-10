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
            AddMod(new Review(2009172305uL, "EPTUI TLM Integration (Beta)") {
                Affect = Factor.TransportLines,
                Authors = "Arturj07",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150uL , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 411164732uL , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523uL , Status.Incompatible }, // TextScaleMod
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
            AddMod(new Review(1776052533uL, "Stops & Stations") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "dymanoid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1420955187uL, Status.Compatible   }, // Real Time
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT) -- old ver
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/dymanoid/StopsAndStations",
            });

            AddMod(new Review(1766839841uL, "Anxiety Reducer") {
                Affect = Factor.Boredom
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1420955187uL, Status.MinorIssues  }, // Real Time (still investigating)
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT) -- old ver
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1394468624uL, "Advanced Stop Selection (ex MTSE)") {
                Affect = Factor.TransportLines,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 532863263uL, Status.Incompatible }, // [deprecated] Multi-Track Station Enabler 1.2.0
                    { 442957897uL, Status.Incompatible }, // [Obsolete] Multi-Track Station Enabler
                    { 409184143uL, Status.Incompatible }, // Traffic++
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedStopSelection",
            });

            AddMod(new Review(1393820309uL, "Ticket Price Customizer") {
                Affect = Factor.Revenue
                       | Factor.TransportLines
                       | Factor.TransportPreference,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3 -- old ver
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager -- old ver
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Values in options screen are divided by 100 in-game, so if you want price 2.80 set option value to 280." },
                },
                ReleasedDuring = GameVersion.ParkLife,
                SourceURL = "https://github.com/bloodypenguin/Skylines-TicketPriceCustomizer",
            });

            AddMod(new Review(1312767991uL, "Transport Lines Manager 13.1") {
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
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1776052533uL, Status.Compatible   }, // Stops & Stations
                    { 1766839841uL, Status.Compatible   }, // Anxiety Reducer
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282uL, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309uL, Status.Incompatible }, // Ticket Price Customizer
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337uL, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition [STABLE]
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376uL , Status.MinorIssues  }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323uL , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 929654063uL, // Transport Lines Manager Reborn 8.0.3
                Languages = new[] { "en", "pt", "ko", "de", "nl", "pl", "zh-cn", "fr", "es" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 928128676uL, "[Mod: Improved Public Transport] Massive lag when IPT and TLM are used together. Unsubscribe one of them." },
                },
                Published = WorkshopDate("25 Feb, 2018"),
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            // Based on user comments some major bugs with this:
            // * Causes problems with route creation
            // * Often adds too many vehicles (even after waiting for it to settle after few day/night cycles)
            AddMod(new Review(1218121337uL, "Automatic Vehicle Numbers Adjuster") {
                Affect = Factor.TransportLines,
                Authors = "Overhatted",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: likely IPT and maybe others
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
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
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Compatible   }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1776052533uL, Status.Compatible   }, // Stops & Stations
                    { 1766839841uL, Status.Compatible   }, // Anxiety Reducer
                    { 1764208250uL, Status.Compatible   }, // More Vehicles
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1632320836uL, Status.Incompatible }, // Service Vehicles Manager 2.0.1
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337uL, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2 (BP's version)
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 531401164uL , Status.Incompatible }, // Vehicle Unbuncher
                    { 472128528uL , Status.Incompatible }, // Larger Footprints (Snowfall)
                    { 442167376uL , Status.MinorIssues  }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT) - original ver
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 424106600uL, // Improved Public Transport (IPT)
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1312767991uL, "[Mod: Transport Lines Manager] Massive lag when IPT and TLM are used together. Unsubscribe one of them." },
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
            AddMod(new Review(929654063uL, "Transport Lines Manager Reborn 8.0.3") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                ArchiveURL = "https://web.archive.org/web/20180128030931/http://steamcommunity.com/sharedfiles/filedetails/?id=929654063",
                Authors = "Klyte45",
                BrokenBy = GameVersion.ParkLife, // was already replaced by new mod by then
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with overwatch/aris mods
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282uL, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309uL, Status.Incompatible }, // Ticket Price Customizer
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337uL, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323uL , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.GreenCities,
                ContinuationOf = 408875519uL, // Transport Lines Manager
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Required a UI dependency mod, which I can not find in workshop. Source is: https://github.com/klyte45/UIHelper" },
                },
                Published = WorkshopDate("20 May, 2017"),
                ReplaceWith = 1312767991uL, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
                Updated = WorkshopDate("20 Jan, 2018"),
            });

            AddMod(new Review(802489150uL, "Extended Public Transport UI (+DLCs!)") {
                Affect = Factor.UI
                       | Factor.TransportLines,
                Authors = "gmyx",
                BrokenBy = GameVersion.GreenCities,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150uL , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 411164732uL , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                },
                CompatibleWith = GameVersion.Concerts,
                ContinuationOf = 411164732uL, // Extended Public Transport UI(Obsolete)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      //| ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The vanilla game now contains a full transport UI; unsubscribe this mod." },
                },
                Published = WorkshopDate("19 Nov, 2016"),
                SourceURL = "https://github.com/gmyx/Skylines-ExtendedPublicTransport",
                Updated = WorkshopDate("31 May, 2017"),
            });

            AddMod(new Review(411164732uL, "Extended Public Transport UI (Obsolete)") {
                Affect = Factor.UI
                       | Factor.TransportLines,
                Authors = "AcidF!re",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778uL, Status.Incompatible }, // ScaleUI
                    { 2009172305uL, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150uL , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 411164732uL , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401uL , Status.Incompatible }, // ScaleUI (beta)
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                ContinuationOf = 411164732uL, // Extended Public Transport UI(Obsolete)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      //| ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The vanilla game now contains a full transport UI; unsubscribe this mod." },
                },
                Published = WorkshopDate("29 Mar, 2015"),
                SourceURL = "https://github.com/justacid/Skylines-ExtendedPublicTransport",
                Updated = WorkshopDate("9 Aug, 2015"),
            });

            AddMod(new Review(714056356uL, "Transport Line Rendering Fix") {
                Affect = Factor.TransportLines
                       | Factor.Rendering,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The vanilla game now includes this fix; unsubscribe this mod." },
                },
                Published = WorkshopDate("30 Jun, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TransportLineRenderingFix",
                Updated = WorkshopDate("14 Mar, 2018"),
            });

            // old version
            AddMod(new Review(424106600uL, "Improved Public Transport (IPT)") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                ArchiveURL = "https://web.archive.org/web/20171230215005/http://steamcommunity.com/sharedfiles/filedetails/?id=424106600",
                Authors = "DontCryJustDie",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // was compat with ancient versions of TMPE, but they all changed after mass transit
                    // was also compat with t++ v2 (now obsolete)
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337uL, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2 (BP's version)
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 531401164uL , Status.Incompatible }, // Vehicle Unbuncher
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
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
                Published = WorkshopDate("14 Apr, 2015"),
                ReplaceWith = 928128676uL, // Improved Public Transport 2
                Updated = WorkshopDate("29 Nov, 2016"),
            });

            // old version
            AddMod(new Review(408875519uL, "Transport Lines Manager") {
                Affect = Factor.Boredom
                       | Factor.Naming
                       | Factor.TransportLines
                       | Factor.TransportPreference
                       | Factor.VehicleCapacity,
                ArchiveURL = "https://web.archive.org/web/20180201010016/http://steamcommunity.com/sharedfiles/filedetails/?id=408875519",
                Authors = "Klyte45",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS
                    { 1776052533uL, Status.Incompatible }, // Stops & Stations
                    { 1766839841uL, Status.Incompatible }, // Anxiety Reducer
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1415090282uL, Status.Incompatible }, // AutoLineColor Redux
                    { 1393820309uL, Status.Incompatible }, // Ticket Price Customizer
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1218121337uL, Status.Incompatible }, // Automatic Vehicle Numbers Adjuster
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition [STABLE]
                    { 519691655uL , Status.Incompatible }, // Service Vehicle Selector (original)
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (original)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager (original)
                    { 408760323uL , Status.Incompatible }, // Auto Line Color
                },
                CompatibleWith = GameVersion.NaturalDisasters, // there was update on ND release day, assuming minor bug fixes
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // mass transit
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // jan 2018?
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable, // same repo as new version
                Published = WorkshopDate("8 Apr, 2015"),
                ReplaceWith = 1312767991uL, // Transport Lines Manager 13.1
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
                Updated = WorkshopDate("17 May, 2017"),
            });
        }
    }
}