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

            AddMod(new Review(2053661585u, "Emergency Lights Manager V2") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "ninjanoobslayer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585u, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578u, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323u , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1192250578u, // Emergency Lights Manager
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("9 Apr, 2020"),
                SourceURL = "https://github.com/ninjamods/Emergency-Lights-Manager-V2",
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            AddMod(new Review(1651041757u, "Auto Rocket Launch 火箭自动发射") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "mshsheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757u, Status.Compatible  }, // Auto Rocket Launch 火箭自动发射"
                    { 1328542923u, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919u, Status.MinorIssues }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Industries, // likely compatible with Campus too, but not confirmed
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/mshsheng/CSL-AutoRocketLaunch",
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            AddMod(new Review(1633580257u, "Vehicle Wealthizer 2") {
                Affect = Factor.Customize
                       | Factor.Vehicles
                       | Factor.Wealth,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE V11 STABLE
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                },
                CompatibleWith = GameVersion.Campus,
                ReleasedDuring = GameVersion.Industries,
                Flags = ItemFlags.SourceUnavailable,
            });

            // todo: might have more conflicts
            AddMod(new Review(1548831935u, "Advanced Vehicle Options AVO") {
                Affect = Factor.Customize
                       | Factor.Despawn // has options to remove vehicles
                       | Factor.Textures // vehicle colours
                       | Factor.VehicleCapacity // read: https://github.com/CitiesSkylinesMods/TMPE/wiki/Vanilla-capacities
                       | Factor.Velocity,
                Authors = "Tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1818462177u, Status.Compatible   }, // Vehicle Color Expander (from AVO 1.9.0a onwards)
                    { 1764208250u, Status.Compatible   }, // More Vehicles (from AVO 1.9.0 onwards)
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 934994075u , Status.Compatible   }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 413170870u , Status.Incompatible }, // SuperBigTransport 80 v1.1
                    { 413146544u , Status.Incompatible }, // SuperBigTransport 60 v1.1
                    { 413164951u , Status.Incompatible }, // SuperBigTransport Restore v1.1
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // https://github.com/CityGecko/CS-AdvancedVehicleOptions/issues
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "May show error first time you load a city, but after that it will work fine." },
                    { 1818462177u, "[Mod: Vehicle Color Expander] AVO color features will self-disable if Vehicle Color Expander mod is active." },
                },
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
                Tags = new[] { "Vehicles", "Capacity", "Tilt", "Nod", "Breaking", "Acceleration", "Colors", "Colours", "Speeds", "Despawn" },
            });

            // todo: treat as service?
            AddMod(new Review(1328542923u, "Choose Your Rocket") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757u, Status.Compatible  }, // Auto Rocket Launch 火箭自动发射"
                    { 1328560775u, Status.Recommended }, // Soyuz/Союз (Functional rocket)
                    { 1329097226u, Status.Recommended }, // Saturn V (Functional Rocket)
                    { 1328542923u, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919u, Status.Compatible  }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ChirpX,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ChooseYourRocket",
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            AddMod(new Review(1327013919u, "No Time For Caution") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1651041757u, Status.MinorIssues }, // Auto Rocket Launch 火箭自动发射"
                    { 1328542923u, Status.Compatible  }, // Choose Your Rocket
                    { 1327013919u, Status.Compatible  }, // No Time For Caution
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ChirpX,
                Tags = new[] { "Vehicles", "Rocket", "Spaceship", "ChirpX", "Mars", "Launcher" },
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // Alters PT vehicle capacities to user defined values
            // Changes vehicle AIs, updates existing vehicles
            AddMod(new Review(1550281302u, "TransportCapacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "behinds",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
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
                ReplaceWith = 1548831935u, // Advanced Vehicle Options AVO (Industries DLC ready)
                SuppressOlderReplacementWarning = true,
                Tags = new[] { "Vehicles", "Capacity", "Transport" },
            });

            // tries, but fails, to set transport vehicle capacity to 60 (70 for blimps)
            AddMod(new Review(1228424498u, "Bzimage VehicleCapacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "bzimage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                CompatibleWith = GameVersion.GreenCities,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                ReleasedDuring = GameVersion.GreenCities,
                ReplaceWith = 1548831935u, // Advanced Vehicle Options AVO
                Tags = new[] { "Vehicles", "Transport", "Capacity" },
            });

            // Cities: Never Trapped on the Horizon
            // Dll states name as "NeverCongestion" (possible author of original mod = Miro)
            // Modifies AIs, vehicles, etc.
            AddMod(new Review(1196714055u, "城市：地平线永不堵车") {
                Affect = Factor.Velocity
                       | Factor.Vehicles,
                Authors = "回忆时光℡",
                Catalog = catalog,
                //CloneOf = ??,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1953042839u, Status.Incompatible }, // Unified Railway System
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1412844620u, Status.Incompatible }, // Realistic Walking Speed
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 934994075u , Status.Incompatible }, // Service Vehicle Selector 2
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking // Wrong .Net version 4.5 (should be 3.5)
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
            });

            AddMod(new Review(1192250578u, "Emergency Lights Manager") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "Cryptkeeper",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585u, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578u, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323u , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u , Status.Incompatible }, // Emergency Light Changer
                },
                ContinuationOf = 863909323u, // Emergency Light Changer Plus
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("5 Nov, 2017"),
                ReplaceWith = 2053661585u, // Emergency Lights Manager V2
                Updated = WorkshopDate("6 Nov, 2017"),
            });

            AddMod(new Review(863909323u, "Emergency Light Changer Plus") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585u, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578u, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323u , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 559172768u, // Emergency Light Changer
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Feb, 2017"),
                ReplaceWith = 2053661585u, // Emergency Lights Manager V2
                SourceURL = "https://gist.github.com/stmSantana/b3950c4cf91ebdfe8e33053453e331e2",
                Updated = WorkshopDate("14 Feb, 2017"),
            });

            AddMod(new Review(559172768u, "Emergency Light Changer") {
                Affect = Factor.Rendering
                       | Factor.Vehicles,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2053661585u, Status.Incompatible }, // Emergency Lights Manager V2
                    { 1192250578u, Status.Incompatible }, // Emergency Lights Manager
                    { 863909323u , Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u , Status.Incompatible }, // Emergency Light Changer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("21 Nov, 2015"),
                ReplaceWith = 2053661585u, // Emergency Lights Manager V2
                SourceURL = "https://gist.github.com/boformer/c0491f7bc295154940ccf1cf4e94dba4",
                Updated = WorkshopDate("10 Jun, 2016"),
            });

            AddMod(new Review(414326578u, "Configurable Transport Capacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "Apoc",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                CompatibleWith = GameVersion.ChirpX,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车
                    { 929654063u , Status.Incompatible }, // Transport Lines Manager Reborn 8.0.3
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 424106600u , Status.Incompatible }, // Improved Public Transport (IPT)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                    { 408875519u , Status.Incompatible }, // Transport Lines Manager
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Parklife
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = new Version(1, 0, 7),
                ReplaceWith = 1548831935u, // Advanced Vehicle Options AVO (latest)
                SourceURL = "https://github.com/ApocDev/CitiesSkylinesMods/tree/master/TransportCapacity",
                Tags = new[] { "Vehicles", "Transport", "Capacity" },
            });
        }
    }
}