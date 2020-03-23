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

            string[] v11languages = new[] {
                "de",
                "en", // DEFAULT
                "en-gb",
                "es",
                "fr",
                "hu",
                "it",
                "ja",
                "ko",
                "nl",
                "pl",
                "pt",
                "ru",
                "tr",
                "uk",
                "zh",
                "zh-tw",
            };

            AddMod(new Item(1829496988u, "Adjust Pathfinding") {
                Affect = Factor.Pathfinder
                       | Factor.Vehicles,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Compatible }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible }, // TM:PE v11 STABLE
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
                    { 1939169189u, Status.Recommended  }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                },
                ContinuationOf = 1637663252u, // TM:PE V11 STABLE (Krzychu1245)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised, // localised to lots of languages
                Languages = v11languages,
                Locale = "en",
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
                    { 2019097300u, Status.Recommended  }, // Hide TM:PE Unconnected Tracks
                    { 1939169189u, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Recommended  }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1764208250u, Status.Compatible   }, // More Vehicles
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1586027591u, Status.MinorIssues  }, // Tiny Segments (issues with short roads at junctions)
                    { 1196714055u, Status.Incompatible }, // 城市：地平线永不堵车 (changes vehicle speeds in bad ways)
                    { 949504539u , Status.MinorIssues  }, // SingleTrainTrackAI https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 631930385u , Status.Incompatible }, // Realistic Vehicle Speed
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
                },
                ContinuationOf = 583429740u, // TM:PE 10.20 (LinuxFan)
                Flags = ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised, // localised to lots of languages
                Languages = v11languages,
                Locale = "en",
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
                    // https://github.com/CitiesSkylinesMods/TMPE/issues/787
                    { 1806963141u, Status.MinorIssues }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues }, // TM:PE V11 STABLE
                },
                Flags = ItemFlags.SourceAvailable,
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
                    { 1806963141u, Status.Incompatible }, // TM:PE V11 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
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
                    { 1806963141u, Status.Incompatible }, // TM:PE V11 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
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
                    { 1806963141u, Status.Incompatible }, // TM:PE V11 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
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
                    { 1806963141u, Status.Incompatible }, // TM:PE V11 LABS
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 583429740u , Status.Incompatible }, // Traffic Manager: President Edition (LinuxFan)
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
                ReleasedDuring = GameVersion.ChirpX,
                ReplaceWith = 1637663252u, // TM:PE V11 STABLE
                SourceURL = "https://github.com/thardie/Cities-Skylines-Traffic-Manager-President-Edition",
                Tags = new[] {
                    "TMPE", "Priority", "Speeds", "Signs", "Traffic", "Lights", "Vehicles",
                    "Restrictions", "Pathfinder", "Pedestrians", "Crossings", "Parking",
                },
            });
        }
    }
}
