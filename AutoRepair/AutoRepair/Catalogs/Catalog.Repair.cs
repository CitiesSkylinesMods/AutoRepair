namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that help detect and/or repair issues with the game.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void RepairMods() {

            string catalog = "Repair";

            AddMod(new Review(2041457644u, "Patch Loader Mod") {
                Affect = Factor.Other,
                Authors = "Krzychu1245, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Review(2037888659u, "Instant Return To Desktop") {
                Affect = Factor.LoadSaveExit,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.SunsetHarbor,
                SourceURL = "https://github.com/Cgameworld/InstantReturnToDesktop",
            });

            AddMod(new Review(2034713132u, "AutoRepair") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/CitiesSkylinesMods/AutoRepair",
            });

            AddMod(new Review(1938493221u, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Review(1777173984u, "Broken Nodes Detector") {
                Affect = Factor.Other,
                Authors = "krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Review(1620588636u, "Safenets") {
                Affect = Factor.Other,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/thale5/Safenets",
            });

            AddMod(new Review(1243740191u, "Road Removal Tool") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2037862156u, "IsIntercity Fix") {
                Affect = Factor.Other,
                Authors = "Elektrix, aubergine18",
                BrokenBy = GameVersion.Patch_1_13_0_f8,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe; the bug in vanilla game is now fixed!" },
                },
                Published = WorkshopDate("28 Mar, 2020"),
                Updated = WorkshopDate("28 Mar, 2020"),
            });

            AddMod(new Review(558661484u, "Building Panel Already Exists Icons Fix") {
                Affect = Factor.Toolbar,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe; the bug in vanilla game is now fixed!" },
                },
                Published = WorkshopDate("20 Nov, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-AlreadyBuiltFix",
                Updated = WorkshopDate("20 Nov, 2015"),
            });
        }
    }
}
