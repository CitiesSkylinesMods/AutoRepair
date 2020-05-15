namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods which alter, customise or convert vehicles.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void VehicleMods() {

            string catalog = "Vehicles";

            AddMod(new Review(2069057130uL, "NoBigTruck") {
                Affect = Factor.Consumption
                       | Factor.Vehicles,
                Authors = "macsergey",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // possibly incompat with Advanced District Services
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("21 Apr, 2020"),
                SourceURL = "https://github.com/MacSergey/NoBigTruck",
                Updated = WorkshopDate("21 Apr, 2020"),
            });

            AddMod(new Review(2053661585uL, "Emergency Lights Manager V2") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "ninjanoobslayer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2053661585uL, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1192250578uL, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323uL , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768uL , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1192250578uL, // Emergency Lights Manager
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("9 Apr, 2020"),
                SourceURL = "https://github.com/ninjamods/Emergency-Lights-Manager-V2",
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            AddMod(new Review(1651041757uL, "Auto Rocket Launch 火箭自动发射") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757uL, Status.Compatible  }, // Auto Rocket Launch 火箭自动发射"
                    { 1328542923uL, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919uL, Status.MinorIssues }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Industries, // likely compatible with Campus too, but not confirmed
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/mshsheng/CSL-AutoRocketLaunch",
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            AddMod(new Review(1633580257uL, "Vehicle Wealthizer 2") {
                Affect = Factor.Customize
                       | Factor.Vehicles
                       | Factor.Wealth,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                CompatibleWith = GameVersion.Campus,
                ReleasedDuring = GameVersion.Industries,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1548831935uL, "Advanced Vehicle Options AVO") {
                Affect = Factor.Customize
                       | Factor.Despawn // has options to remove vehicles
                       | Factor.Textures // vehicle colours
                       | Factor.VehicleCapacity // read: https://github.com/CitiesSkylinesMods/TMPE/wiki/Vanilla-capacities
                       | Factor.Velocity,
                Authors = "Tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Compatible   }, // 934994075 Service Vehicle Selector 2
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1818462177uL, Status.Compatible   }, // Vehicle Color Expander (from AVO 1.9.0a onwards)
                    { 1806759255uL, Status.Compatible   }, // Customize It Extended
                    { 1764208250uL, Status.Compatible   }, // More Vehicles (from AVO 1.9.0 onwards)
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 442167376uL, // Advanced Vehicle Options (AVO)
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "May show error first time you load a city, but after that it will work fine." },
                    { NOTE, "User guide: https://github.com/CityGecko/CS-AdvancedVehicleOptions/wiki" },
                    { 1818462177uL, "[Mod: Vehicle Color Expander] AVO will automatically disable conflicting options to ensure compatibility." },
                    { 1312767991uL, "[Mod: Transport Lines Manager] AVO will automatically disable conflicting options to ensure compatibility." },
                    { 928128676uL , "[Mod: Improved Public Transport 2] AVO will automatically disable conflicting options to ensure compatibility." },
                },
                Published = WorkshopDate("27 Oct, 2018"),
                SourceURL = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
                Tags = new[] { "Vehicles", "Capacity", "Tilt", "Nod", "Breaking", "Acceleration", "Colors", "Colours", "Speeds", "Despawn" },
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            // todo: treat as service?
            AddMod(new Review(1328542923uL, "Choose Your Rocket") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757uL, Status.Compatible  }, // Auto Rocket Launch 火箭自动发射"
                    { 1328560775uL, Status.Recommended }, // Soyuz/Союз (Functional rocket)
                    { 1329097226uL, Status.Recommended }, // Saturn V (Functional Rocket)
                    { 1328542923uL, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919uL, Status.Compatible  }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ChirpX,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ChooseYourRocket",
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            AddMod(new Review(1327013919uL, "No Time For Caution") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757uL, Status.MinorIssues }, // Auto Rocket Launch 火箭自动发射"
                    { 1328542923uL, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919uL, Status.Compatible  }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ChirpX,
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            AddMod(new Review(870291141uL, "Random Train Trailers 2.1.2") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Tutorial: https://steamcommunity.com/workshop/filedetails/discussion/870291141/2183537632748656364/" },
                    { NOTE, "Asset creators, see 'Cargo' section: https://steamcommunity.com/workshop/filedetails/discussion/870291141/133258092236504318/" },
                    { NOTE, "Cargo mappings: https://github.com/Acc3ssViolation/RandomTrainTrailers/blob/master/Cargo%20Transfer%20Reasons.txt" },
                },
                Published = WorkshopDate("23 Feb, 2017"),
                SourceURL = "https://github.com/Acc3ssViolation/RandomTrainTrailers",
                Updated = WorkshopDate("23 Oct, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2085902218uL, "Advanced Vehicle Options 1.9.3 BETA") {
                Affect = Factor.Customize
                       | Factor.Despawn // has options to remove vehicles
                       | Factor.Textures // vehicle colours
                       | Factor.VehicleCapacity // read: https://github.com/CitiesSkylinesMods/TMPE/wiki/Vanilla-capacities
                       | Factor.Velocity,
                Authors = "Tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1818462177uL, Status.Compatible   }, // Vehicle Color Expander (from AVO 1.9.0a onwards)
                    { 1806759255uL, Status.Compatible   }, // Customize It Extended
                    { 1764208250uL, Status.Compatible   }, // More Vehicles (from AVO 1.9.0 onwards)
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1312767991uL, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Compatible   }, // Improved Public Transport 2
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1548831935uL, // Advanced Vehicle Options AVO (current stable)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/CityGecko/CS-AdvancedVehicleOptions/wiki" },
                    { 1818462177uL, "[Mod: Vehicle Color Expander] Red fields in AVO indicate possible conflicts." },
                    { 1312767991uL, "[Mod: Transport Lines Manager] Red fields in AVO indicate possible conflicts." },
                    { 928128676uL , "[Mod: Improved Public Transport 2] Red fields in AVO indicate possible conflicts." },
                },
                Published = WorkshopDate("5 May, 2020"),
                Removed = WorkshopDate("11 May, 2020"), // when main AVO was updated to new release
                ReplaceWith = 1548831935uL, // Advanced Vehicle Options AVO
                SourceURL = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement | Warning.QueryAbandonware,
                Tags = new[] { "Vehicles", "Capacity", "Tilt", "Nod", "Breaking", "Acceleration", "Colors", "Colours", "Speeds", "Despawn" },
                Updated = WorkshopDate("5 May, 2020"),
            });

            // Alters PT vehicle capacities to user defined values
            // Changes vehicle AIs, updates existing vehicles
            AddMod(new Review(1550281302uL, "TransportCapacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "behinds",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking // Does not reset vehicle AIs on unloading!
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Does not reset vehicle AIs on unloading!
                      | ItemFlags.Obsolete // just use AVO!
                      | ItemFlags.SaveAltering // Does not reset vehicle AIs proior to game save!
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1548831935uL, // Advanced Vehicle Options AVO (Industries DLC ready)
                Suppress = Warning.OlderReplacement,
                Tags = new[] { "Vehicles", "Capacity", "Transport" },
            });

            // tries, but fails, to set transport vehicle capacity to 60 (70 for blimps)
            AddMod(new Review(1228424498uL, "Bzimage VehicleCapacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "bzimage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.GreenCities,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                ReleasedDuring = GameVersion.GreenCities,
                ReplaceWith = 1548831935uL, // Advanced Vehicle Options AVO
                Tags = new[] { "Vehicles", "Transport", "Capacity" },
            });

            // Cities: Never Trapped on the Horizon
            // Dll states name as "NeverCongestion" (possible author of original mod = Miro)
            // Modifies AIs, vehicles, etc.
            AddMod(new Review(1196714055uL, "城市：地平线永不堵车") {
                Affect = Factor.Velocity
                       | Factor.Vehicles,
                Authors = "回忆时光℡",
                Catalog = catalog,
                //CloneOf = ??,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Incompatible }, // 934994075 Service Vehicle Selector 2
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839uL, Status.Incompatible }, // Unified Railway System
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1637663252uL, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1412844620uL, Status.Incompatible }, // Realistic Walking Speed
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 934994075uL , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385uL , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740uL , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking // Wrong .Net version 4.5 (should be 3.5)
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
            });

            AddMod(new Review(1192250578uL, "Emergency Lights Manager") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "Cryptkeeper",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585uL, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578uL, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323uL , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768uL , Status.Incompatible }, // Emergency Light Changer
                },
                ContinuationOf = 863909323uL, // Emergency Light Changer Plus
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("5 Nov, 2017"),
                ReplaceWith = 2053661585uL, // Emergency Lights Manager V2
                Updated = WorkshopDate("6 Nov, 2017"),
            });

            AddMod(new Review(863909323uL, "Emergency Light Changer Plus") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585uL, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578uL, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323uL , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768uL , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 559172768uL, // Emergency Light Changer
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Feb, 2017"),
                ReplaceWith = 2053661585uL, // Emergency Lights Manager V2
                SourceURL = "https://gist.github.com/stmSantana/b3950c4cf91ebdfe8e33053453e331e2",
                Updated = WorkshopDate("14 Feb, 2017"),
            });

            AddMod(new Review(559172768uL, "Emergency Light Changer") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585uL, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578uL, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323uL , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768uL , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("21 Nov, 2015"),
                ReplaceWith = 2053661585uL, // Emergency Lights Manager V2
                SourceURL = "https://gist.github.com/boformer/c0491f7bc295154940ccf1cf4e94dba4",
                Updated = WorkshopDate("10 Jun, 2016"),
            });

            AddMod(new Review(414326578uL, "Configurable Transport Capacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "Apoc",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                CompatibleWith = GameVersion.ChirpX,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 1764208250uL, Status.Incompatible }, // More Vehicles
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991uL, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600uL , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Parklife
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = new Version(1, 0, 7),
                ReplaceWith = 1548831935uL, // Advanced Vehicle Options AVO (latest)
                SourceURL = "https://github.com/ApocDev/CitiesSkylinesMods/tree/master/TransportCapacity",
                Tags = new[] { "Vehicles", "Transport", "Capacity" },
            });

            AddMod(new Review(442167376uL, "Advanced Vehicle Options (AVO)") {
                Affect = Factor.Customize
                       | Factor.Despawn // has options to remove vehicles
                       | Factor.Textures // vehicle colours
                       | Factor.VehicleCapacity // read: https://github.com/CitiesSkylinesMods/TMPE/wiki/Vanilla-capacities
                       | Factor.Velocity,
                Authors = "Boogieman Sam",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Incompatible }, // Advanced Vehicle Options 1.9.3 BETA
                    { 2076619989uL, Status.Compatible   }, // 934994075 Service Vehicle Selector 2
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1818462177uL, Status.Incompatible }, // Vehicle Color Expander (from AVO 1.9.0a onwards)
                    { 1806759255uL, Status.Compatible   }, // Customize It Extended
                    { 1764208250uL, Status.Incompatible }, // More Vehicles (from AVO 1.9.0 onwards)
                    { 1550281302uL, Status.Incompatible }, // TransportCapacity
                    { 1548831935uL, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1312767991uL, Status.MinorIssues  }, // Transport Lines Manager 13.1
                    { 1228424498uL, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055uL, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075uL , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063uL , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676uL , Status.MinorIssues  }, // Improved Public Transport 2
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578uL , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870uL , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413146544uL , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 413164951uL , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 408875519uL , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware // author no longer plays CSL
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[DLC: Sunset Harbor]: Custom trams and busses are broken." },
                    { NOTE, "[DLC: Industries] Does not categorise industry vehicles properly." },
                    { 1818462177uL, "[Mod: Vehicle Color Expander] Both mods change vehicle color; use one, remove the other." },
                    { 1312767991uL, "[Mod: Transport Lines Manager] Both mods can alter vehicle capacity which might cause issues." },
                    { 928128676uL , "[Mod: Improved Public Transport 2] Both mods can alter vehicle capacity which might cause issues." },
                },
                Published = WorkshopDate("13 May, 2015"),
                ReplaceWith = 1548831935uL, // Advanced Vehicle Options AVO (current stable)
                SourceURL = "https://github.com/SamsamTS/CS-AdvancedVehicleOptions",
                Tags = new[] { "Vehicles", "Capacity", "Colors", "Colours", "Speeds", "Despawn" },
                Updated = WorkshopDate("24 May, 2018"),
            });
        }
    }
}