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
        private void ConverterMods() {

            string catalog = "Converters";

            AddMod(new Review(2039036102u, "Metro Station Converter") {
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

            AddMod(new Review(2033714682u, "Tree and Vehicle Props") {
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

            AddMod(new Review(2016920607u, "Ploppable RICO revisited") {
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
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 927293560u , Status.Compatible   }, // Geli-Districts v3.0
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
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
            AddMod(new Review(1824254667u, "Campus Parks") {
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

            AddMod(new Review(1546357276u, "Industries Vehicle Converter") {
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
            AddMod(new Review(1393452031u, "Parkify") {
                Affect = Factor.Customize,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[DLC: Park Life] Converts some vanilla game unique buildings in to Park Life park buildings."},
                    { NOTE, "[DLC: After Dark] Also adds missing boats to the Marina and Fishing Tours buildings." },
                },
                Published = WorkshopDate("24 May, 2018"),
                RequiredDLC = DLCs.ParkLife | DLCs.AfterDark,
                Updated = WorkshopDate("8 Jun, 2018"),
            });

            AddMod(new Review(928103306u, "Ship Converter") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 530771650u , Status.Required     }, // Prefab Hook (Mod Dependency)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[DLC: Mass Transit] Converts some ships in to Ferries." },
                    { NOTE, "Converts ship/boat buildings to be able to float on water." },
                    { NOTE, "Enables Steam Boat (from museum) to be plopped separately."},
                },
                Published = WorkshopDate("18 May, 2017"),
                RequiredDLC = DLCs.MassTransit,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ShipConverter",
                Updated = WorkshopDate("18 May, 2017"),
            });

            AddMod(new Review(924884948u, "Plop the Growables") {
                Affect = Factor.Customize
                       | Factor.PlaceAndMove,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1658773932u, Status.MinorIssues  }, // Historical Districts
                    { 1647722503u, Status.Unknown      }, // Level
                    { 1619685021u, Status.Compatible   }, // Move It 2.7.0
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1403136223u, Status.Unknown      }, // Control Building Level Up v0.5 (Industries)
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Unknown      }, // 建筑升级平衡MOD
                    { 837734529u , Status.Required     }, // Find It!
                    { 821539759u , Status.Incompatible }, // Disable Zone Check
                    { 766190099u , Status.Incompatible }, // Move It (original ver)
                    { 523818382u , Status.Compatible   }, // Force Level Up
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 821539759u, "[Mod: Disable Zone Check] Causes buildings that were placed with Plop the Growables to despawn." },
                },
                Published = WorkshopDate("13 May, 2017"),
                SourceURL = "https://github.com/TPBCS/PlopTheGrowables",
                Updated = WorkshopDate("12 Oct, 2019"),
            });

            AddMod(new Review(795514116u, "Train Converter") {
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

            AddMod(new Review(1204126182u, "Ploppable Rico High Density Fix") {
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
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
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
                SuppressArchiveWarning = true,
            });

            AddMod(new Review(586012417u, "Ploppable RICO") {
                Affect = Factor.Naming
                       | Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.Construction
                       | Factor.Customize
                       | Factor.DemandRCI
                       | Factor.Employment,
                ArchiveURL = "https://web.archive.org/web/20200412231453/https://steamcommunity.com/sharedfiles/filedetails/?id=586012417",
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
                    { 931330091u , Status.Incompatible }, // 410344523 PopBalanceMod
                    { 888017364u , Status.Incompatible }, // Quartz (Sapphire) - Fixed 1.11
                    { 586012417u , Status.Incompatible }, // Ploppable RICO (original)
                    { 576970398u , Status.Incompatible }, // Quartz (former Sapphire) - UI skin framework
                    { 426163185u , Status.Compatible   }, // Realistic Population and Consumption Mod v8.4.0
                    { 421770876u , Status.Incompatible }, // Sapphire - UI skin framework
                    { 410344523u , Status.Incompatible }, // PopBalanceMod
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Causes residential buildings to have 0/0 households, collapsing your economy." },
                },
                Published = WorkshopDate("28 Dec, 2015"),
                ReplaceWith = 2016920607u, // Ploppable RICO revisited
                SourceURL = "https://github.com/AJ3D/Ploppable-RICO",
                Updated = WorkshopDate("26 Oct, 2018"),
            });
        }
    }
}