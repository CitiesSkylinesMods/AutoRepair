namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that convert buildings/vehicles/etc in to different category of thing.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        private void ConvertersCatalog() {

            string catalog = "Converters";

            AddMod(new Item(2039036102u, "Metro Station Converter") {
                Affect = Factor.Customize,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 816260433u, Status.Incompatible }, // Metro Overhaul Mod (MOM)
                    { 795514116u, Status.Recommended  }, // Train Converter
                    { 530771650u, Status.Required     }, // Prefab Hook
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Installation: Enable Prefab Hook and Metro Station Converter, then exit to desktop and restart game." },
                    { NOTE, "Stations converted by default: https://steamcommunity.com/workshop/filedetails/discussion/2039036102/2152098843854887518/" },
                    { NOTE, "Stations will revert to their normal state if the mod is removed." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Item(2033714682u, "Tree and Vehicle Props") {
                Affect = Factor.LoadSaveExit
                       | Factor.Props
                       | Factor.Trees
                       | Factor.Vehicles,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 787611845u , Status.Recommended  }, // Prop Snapping
                    { 791221322u , Status.Recommended  }, // Prop Precision
                    { 593588108u , Status.Recommended  }, // Prop & Tree Anarchy
                    { 1094334744u, Status.Compatible   }, // Procedural Objects
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.PdxLauncher,
            });

            AddMod(new Item(2016920607u, "RICO revisited") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "algernon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Compatible   }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Ploppable-RICO-errors" },
                    { NOTE, "Asset creators, see: https://steamcommunity.com/sharedfiles/filedetails/?id=628080291 " },
                    { NOTE, "Asset creators, also see: https://steamcommunity.com/sharedfiles/filedetails/?id=615114749" },
                },
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/algernon-A/Ploppable-RICO-Revisited",
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Installation: Enable Prefab Hook and Industries Vehicle Converter, then exit to desktop and restart game." },
                    { NOTE, "Default postal vehicle conversions: https://steamcommunity.com/workshop/filedetails/discussion/1546357276/1732090362062857499/" },
                    { NOTE, "Default cargo plane conversions: https://steamcommunity.com/workshop/filedetails/discussion/1546357276/1732090362062870068/" },
                    { NOTE, "Vehicles will revert to their normal state if the mod is removed." },
                },
                ReleasedDuring = GameVersion.Industries,
                RequiredDLC = DLCs.Industries,
                Tags = new[] { "Vehicles", "Cargo", "Truck", "Ship", "Aircraft", "Airplane", },
            });

            AddMod(new Item(795514116u, "Train Converter") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039036102u, Status.Recommended  }, // Metro Station Converter
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 530771650u , Status.Required     }, // Prefab Hook
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Now works with vanilla game - no DLC required!" },
                    { NOTE, "Installation: Enable Prefab Hook and Train Converter, then exit to desktop and restart game." },
                    { NOTE, "Default train conversions: https://steamcommunity.com/workshop/filedetails/discussion/795514116/276237094327064093/" },
                    { NOTE, "Trains will revert to their normal state if the mod is removed." },
                },
                ReleasedDuring = GameVersion.Stadiums,
                SourceURL = "https://github.com/bloodypenguin/Skylines-VehicleConverter",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1204126182u, "Ploppable Rico High Density Fix") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "(unknown)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 586012417u, // Ploppable RICO (original)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Troubleshooting guide: https://github.com/CitiesSkylinesMods/TMPE/wiki/Ploppable-RICO-errors" },
                    { NOTE, "Asset creators, see: https://steamcommunity.com/sharedfiles/filedetails/?id=628080291 " },
                    { NOTE, "Asset creators, also see: https://steamcommunity.com/sharedfiles/filedetails/?id=615114749" },
                },
                ReplaceWith = 2016920607u, // RICO revisited
            });
        }
    }
}