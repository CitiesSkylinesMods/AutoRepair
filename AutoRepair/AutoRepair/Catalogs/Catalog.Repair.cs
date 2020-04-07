namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
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

            AddMod(new Item(2041457644u, "Patch Loader Mod") {
                Affect = Factor.Other,
                Authors = "Krzychu1245, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Item(2037888659u, "Instant Return To Desktop") {
                Affect = Factor.LoadSaveExit,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.SunsetHarbor,
                SourceURL = "https://github.com/Cgameworld/InstantReturnToDesktop",
            });

            AddMod(new Item(2037862156u, "IsIntercity Fix") {
                Affect = Factor.Other,
                Authors = "Elektrix, aubergine18",
                BrokenBy = new Version(1, 13, 0, 8),
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The bug in vanilla game is now fixed; you can unsubscribe this mod." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Item(2034713132u, "AutoRepair") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/CitiesSkylinesMods/AutoRepair",
            });

            AddMod(new Item(1938493221u, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1777173984u, "Broken Nodes Detector") {
                Affect = Factor.Other,
                Authors = "krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Item(1620588636u, "Safenets") {
                Affect = Factor.Other,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/thale5/Safenets",
            });

            AddMod(new Item(1243740191u, "Road Removal Tool") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });

            AddMod(new Item(558661484u, "Building Panel Already Exists Icons Fix") {
                Affect = Factor.Toolbar,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Causes 'already built' icons to appear on any service building that's already built (you can still build more though)." },
                },
                ReleasedDuring = GameVersion.AfterDark,
                SourceURL = "https://github.com/bloodypenguin/Skylines-AlreadyBuiltFix",
            });
        }
    }
}
