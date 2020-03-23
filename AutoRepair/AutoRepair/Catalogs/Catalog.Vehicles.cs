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
        private void VehiclesCatalog() {

            string catalog = "Vehicles";

            AddMod(new Item(1764208250u, "More Vehicles") {
                Affect = Factor.VehicleLimit // mods which don't properly check vehicle limits will break
                       | Factor.TileLimit // incompat with 81 tiles
                       | Factor.Toolbar, // date/event display can be broken by toolbar & quartz/sapphire mods
                Authors = "dymanoid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 1575247594u, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066u, Status.Incompatible }, // 81MOD
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options (new one; v1.9.0 should fix)
                    { 1361478243u, Status.Incompatible }, // 81 Tiles (prolly a localised version)
                    { 888017364u , Status.MinorIssues  }, // Quartz (Sapphire) - Fixed 1.11
                    { 781767563u , Status.MinorIssues  }, // Extended InfoPanel
                    { 583429740u , Status.Incompatible }, // TM:PE 10.20 and earlier
                    { 576970398u , Status.MinorIssues  }, // Quartz (former Sapphire) - UI skin framework
                    { 576327847u , Status.Incompatible }, // 81 Tiles (BP version)
                    { 422554572u , Status.Incompatible }, // 81 Tiles (original version)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (original)
                    { 421770876u , Status.MinorIssues  }, // Sapphire - UI skin framework
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.SaveChanging,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/dymanoid/MoreVehicles",
                Tags = new[] { "Vehicles", "Parked", "Parking", "Limits", "Unlimiter" },
            });

            AddMod(new Item(1651041757u, "Auto Rocket Launch 火箭自动发射") {
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

            AddMod(new Item(1633580257u, "Vehicle Wealthizer 2") {
                Affect = Factor.Customize
                       | Factor.Vehicles
                       | Factor.Wealth,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1637663252u, Status.Compatible }, // TM:PE V11 STABLE
                    { 1806963141u, Status.Compatible }, // TM:PE v11 LABS
                    // incompat with tmpe 10.20 and earlier
                },
                CompatibleWith = GameVersion.Campus,
                ReleasedDuring = GameVersion.Industries,
                Flags = ItemFlags.SourceUnavailable,
            });

            // todo: might have more conflicts
            AddMod(new Item(1548831935u, "Advanced Vehicle Options AVO (Industries DLC ready)") {
                Affect = Factor.Customize
                       | Factor.Despawn // has options to remove vehicles
                       | Factor.Textures // vehicle colours
                       | Factor.VehicleCapacity // read: https://github.com/CitiesSkylinesMods/TMPE/wiki/Vanilla-capacities
                       | Factor.Velocity,
                Authors = "Tim",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764208250u, Status.Compatible   }, // More Vehicles (from v1.9.0 onwards)
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991u, Status.Compatible   }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 928128676u , Status.Compatible   }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // https://github.com/CityGecko/CS-AdvancedVehicleOptions/issues
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
                Tags = new[] { "Vehicles", "Capacity", "Tilt", "Nod", "Breaking", "Acceleration", "Colors", "Colours", "Speeds", "Despawn" },
            });

            AddMod(new Item(1546357276u, "Industries Vehicle Converter") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 530771650u, Status.Required }, // Prefab Hook (Mod Dependency)
                    // todo: suggested assets
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Industries,
                RequiredDLC = DLCs.Industries,
                Tags = new[] { "Vehicles", "Cargo", "Truck", "Ship", "Aircraft", "Airplane", },
            });

            // todo: treat as service?
            AddMod(new Item(1328542923u, "Choose Your Rocket") {
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

            AddMod(new Item(1327013919u, "No Time For Caution") {
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
            AddMod(new Item(1550281302u, "TransportCapacity") {
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
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorBreaking // Does not reset vehicle AIs on unloading!
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // Does not reset vehicle AIs on unloading!
                      | ItemFlags.Obsolete // just use AVO!
                      | ItemFlags.SaveChanging // Does not reset vehicle AIs proior to game save!
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1548831935u, // Advanced Vehicle Options AVO (Industries DLC ready)
                Tags = new[] { "Vehicles", "Capacity", "Transport" },
            });

            // tries, but fails, to set transport vehicle capacity to 60 (70 for blimps)
            AddMod(new Item(1228424498u, "Bzimage VehicleCapacity") {
                Affect = Factor.Customize
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "bzimage",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
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
            AddMod(new Item(1196714055u, "城市：地平线永不堵车") {
                Affect = Factor.Velocity
                       | Factor.Vehicles,
                Authors = "回忆时光℡",
                Catalog = catalog,
                //CloneOf = ??,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Incompatible }, // TM:PE v11 LABS (aubergine18)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE v11 STABLE (Krzychu1245)
                    { 1550281302u, Status.Incompatible }, // TransportCapacity
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (current stable)
                    { 1412844620u, Status.Incompatible }, // Realistic Walking Speed
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1312767991u, Status.Incompatible }, // Transport Lines Manager 13.1
                    { 1228424498u, Status.Incompatible }, // Bzimage VehicleCapacity
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking // Wrong .Net version 4.5 (should be 3.5)
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
            });
            AddMod(new Item(414326578u, "Configurable Transport Capacity") {
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
                    { 928128676u , Status.Incompatible }, // Improved Public Transport 2
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                    { 414326578u , Status.Incompatible }, // Configurable Transport Capacity
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