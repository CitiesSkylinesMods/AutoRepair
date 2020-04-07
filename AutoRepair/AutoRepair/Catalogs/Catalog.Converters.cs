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
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have lots of tree and vehicle assets, loading cities may take significnatly longer." },
                },
                ReleasedDuring = GameVersion.ParadoxLauncher,
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
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1577882296u, Status.Compatible   }, // Resize It!
                    { 1420955187u, Status.Compatible   }, // Real Time
                    { 1288816430u, Status.Incompatible }, // Hex Colors
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
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/algernon-A/Ploppable-RICO-Revisited",
            });

            // todo: requires Campus DLC
            AddMod(new Item(1824254667u, "Campus Parks") {
                Affect = Factor.Customize
                       | Factor.PlaceAndMove,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1393452031u, Status.Required      }, // Parkify
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Allows parks to be placed in Campus areas. If mod is removed, they will despawn." },
                },
                Published = WorkshopDate("3 Aug, 2019"),
                RequiredDLC = DLCs.Campus,
                SourceURL = "https://github.com/bloodypenguin/Skylines-CampusParks",
                Tags = new[] { "Vehicles", "Cargo", "Truck", "Ship", "Aircraft", "Airplane", },
                Updated = WorkshopDate("4 Aug, 2019"),
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

            // require dlc: park life
            AddMod(new Item(1393452031u, "Parkify") {
                Affect = Factor.Customize,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Converts some vanilla game unique buildings in to Park Life park buildings."},
                    { NOTE, "Also adds missing boats to the Marina and Fishing Tours buildings from After Dark DLC (if you have it)." },
                },
                Published = WorkshopDate("24 May, 2018"),
                RequiredDLC = DLCs.ParkLife,
                Updated = WorkshopDate("8 Jun, 2018"),
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
                    { 2016920607u, Status.Incompatible }, // Ploppable RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1577882296u, Status.Compatible   }, // Resize It!
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1288816430u, Status.Incompatible }, // Hex Colors
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
                ReplaceWith = 2016920607u, // RICO revisited
            });

            AddMod(new Item(586012417u, "Ploppable RICO") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                Authors = "AJ3D, BloodyPenguin, boformer, Tailgunner",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082u, Status.Incompatible }, // Realistic Population revisited
                    { 2016920607u, Status.Incompatible }, // Ploppable RICO revisited
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1597852915u, Status.Incompatible }, // More Advanced Toolbar
                    { 1587482024u, Status.Incompatible }, // 真实人口，低密度只有一户人，高密度人口容量变大
                    { 1577882296u, Status.Compatible   }, // Resize It!
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1288816430u, Status.Incompatible }, // Hex Colors
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Causes residential buildings to have 0/0 households, collapsing your economy." },
                },
                Published = WorkshopDate("28 Dec, 2015"),
                ReplaceWith = 2016920607u, // Ploppable RICO revisited
                Updated = WorkshopDate("26 Oct, 2018"),
            });
        }
    }
}