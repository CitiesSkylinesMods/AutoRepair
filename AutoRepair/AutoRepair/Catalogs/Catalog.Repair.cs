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
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void RepairMods() {

            string catalog = "Repair";

            AddMod(new Review(2041457644uL, "Patch Loader Mod") {
                Affect = Factor.Other,
                Authors = "Krzychu1245, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 Apr, 2020"),
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Review(2037888659uL, "Instant Return To Desktop") {
                Affect = Factor.LoadSaveExit,
                Authors = "Cgameworld",
                Catalog = catalog,
                CatalogLinks = new[] { "LoadSave" },
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Locale = "*",
                ReleasedDuring = GameVersion.SunsetHarbor,
                SourceURL = "https://github.com/Cgameworld/InstantReturnToDesktop",
            });

            AddMod(new Review(2034713132uL, "AutoRepair") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/CitiesSkylinesMods/AutoRepair",
            });

            AddMod(new Review(1938493221uL, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Review(1777173984uL, "Broken Nodes Detector") {
                Affect = Factor.Other,
                Authors = "krzychu1245",
                Catalog = catalog,
                CatalogLinks = new[] { "Networks" },
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                SourceURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Review(1620588636uL, "Safenets") {
                Affect = Factor.Other,
                Authors = "thale5",
                Catalog = catalog,
                CatalogLinks = new[] { "Networks" },
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                SourceURL = "https://github.com/thale5/Safenets",
            });

            AddMod(new Review(1243740191uL, "Road Removal Tool") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                CatalogLinks = new[] { "Networks" },
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });

            AddMod(new Review(820157360uL, "Spawn Points Fix") {
                Affect = Factor.Other
                       | Factor.Pathfinder,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                CatalogLinks = new[] { "PublicTransport", "Services" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 816260433uL , Status.Compatible    }, // Metro Overhaul Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Asset creators) You can edit spawn points with 'Advanced Buildings Editor' mod: https://steamcommunity.com/sharedfiles/filedetails/?id=790347696" },
                    { 816260433uL , "[Mod: Metro Overhaul Mod] Both mods have spawn point fix; 'Spawn Points Fix' mod will deactivate if MOM is active." },
                },
                Published = WorkshopDate("17 Dec, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-SpawnPointsFix",
                Updated = WorkshopDate("27 May, 2017"),
            });

            AddMod(new Review(812107110uL, "Less Steam") {
                Affect = Factor.UI,
                Authors = "thale5",
                Catalog = catalog,
                CatalogLinks = new[] { "LoadSave" },
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("4 Dec, 2016"),
                SourceURL = "https://github.com/thale5/LessSteam",
                Updated = WorkshopDate("19 Aug, 2017"),
            });

            AddMod(new Review(767233815uL, "Decal Prop Fix") {
                Affect = Factor.Props
                       | Factor.Rendering,
                Authors = "boformer, Ronyx69",
                Catalog = catalog,
                CatalogLinks = new[] { "VisualEffects" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { TIP     , "Decal collections: https://steamcommunity.com/workshop/filedetails/discussion/767233815/343787283746289706/" },
                    { CREATORS, "Asset creation guide: http://steamcommunity.com/workshop/filedetails/discussion/767233815/343787283746272981/" },
                    { CREATORS, "Decal shader guide: https://cslmodding.info/shader/decal/" },
                },
                Published = WorkshopDate("20 Sep, 2016"),
                SourceURL = "https://steamcommunity.com/linkfilter/?url=https://gist.github.com/boformer/1017014acdd9888eab3847272cee9102",
                Updated = WorkshopDate("20 Sep, 2016"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2037862156uL, "IsIntercity Fix") {
                Affect = Factor.Other,
                Authors = "Elektrix, aubergine18",
                BrokenBy = GameVersion.Patch_1_13_0_f8, // incorporated in to vanilla game
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete // vanilla fixed in SH
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe; the bug in vanilla game is now fixed since 1.13.0-f8 release!" },
                },
                Published = WorkshopDate("28 Mar, 2020"),
                Updated = WorkshopDate("28 Mar, 2020"),
            });

            AddMod(new Review(558661484uL, "Building Panel Already Exists Icons Fix") {
                Affect = Factor.Toolbar,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor, // incorporated in to vanilla game
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // vanilla fixed in SH
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Incorrectly shows 'already built' icon for all service buildings." },
                    { NOTE, "Unsubscribe; the bug in vanilla game is now fixed since Sunset Harbor release!" },
                },
                Published = WorkshopDate("20 Nov, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-AlreadyBuiltFix",
                Updated = WorkshopDate("20 Nov, 2015"),
            });

            AddMod(new Review(409068574uL, "Commercial Demand Fix - No Longer Needed!") {
                Affect = Factor.Consumption
                       | Factor.DemandRCI,
                ArchiveURL = "https://web.archive.org/web/20150415153041/http://steamcommunity.com/sharedfiles/filedetails/?id=409068574",
                Authors = "Nohealforu",
                BrokenBy = GameVersion.Patch_1_0_6b, // incorportated in to vanilla game
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Patch_1_0_5,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete // vanilla fixed in patch 1.06b
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("15 Apr, 2015"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Unsubscribe; the bug in vanilla game is fixed since game version 1.06b." },
                },
                Published = WorkshopDate("16 Mar, 2015"), // based on 409068575
                Removed = WorkshopDate("22 Dec, 2018"), // rough guesstimate based on web archive
                Updated = WorkshopDate("19 Mar, 2015"), // based on webarchive
            });
        }
    }
}