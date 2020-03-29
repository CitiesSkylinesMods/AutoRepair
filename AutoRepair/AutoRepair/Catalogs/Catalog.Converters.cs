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

            AddMod(new Item(795514116u, "Train Converter") {
                Affect = Factor.Customize
                       | Factor.Vehicles,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039036102u, Status.Recommended  }, // Metro Station Converter
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 530771650u , Status.Recommended  }, // Prefab Hook
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Now works with vanilla game - no DLC required!" },
                    { NOTE, "Installation: Enable Prefab Hook and Train Converter, then exit to desktop and restart game." },
                },
                ReleasedDuring = GameVersion.Stadiums,
                SourceURL = "https://github.com/bloodypenguin/Skylines-VehicleConverter",
            });
        }
    }
}