namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that help detect and/or repair issues with the game.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void RepairCatalog() {
            string catalog = "Repair";

            AddMod(new Item(2034713132u, "AutoRepair") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/CitiesSkylinesMods/AutoRepair",
            });

            AddMod(new Item(1938493221u, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // no known issues!
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1777173984u, "Broken Nodes Detector") {
                Affect = Factor.Other,
                Authors = "krzychu1245",
                Catalog = catalog,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Item(1620588636u, "Safenets") {
                Affect = Factor.Other,
                Authors = "thale5",
                Catalog = catalog,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/thale5/Safenets",
            });

            AddMod(new Item(1243740191u, "Road Removal Tool") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });
        }
    }
}
