namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods primarily aimed at content creators.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void EditorMods() {

            string catalog = "Editor";

            AddMod(new Review(2060128290uL, "Feature: No Binary") {
                Affect = Factor.Other,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Published = WorkshopDate("13 Apr, 2020"),
                Updated = WorkshopDate("13 Apr, 2020"),
            });

            // todo: move to editor cat
            AddMod(new Review(1845697704uL, "Network Dump Tools") {
                Affect = Factor.Textures,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "In Graphics Settings, set 'Texture Quality' to 'High' before dumping to get best quality." },
                },
                Published = WorkshopDate("26 Aug, 2019"),
                SourceURL = "https://github.com/Cgameworld/NetworkDumpTools",
                Updated = WorkshopDate("1 Dec, 2019"),
            });

            // todo: move to converter cat?
            AddMod(new Review(1552053911uL, "TrailerVariation Loader") {
                Affect = Factor.Vehicles,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 800820816uL , Status.Recommended  }, // Extended Asset Editor 0.4.11
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) It might increase game loading time if you have lots of vehicles." },
                    { NOTE, "(Creators) Do NOT use additive shader on submeshes with non-zero variation mask." },
                },
                Published = WorkshopDate("30 Oct, 2018"),
                SourceURL = "https://gist.github.com/Acc3ssViolation/a129c802e7e2eaeb2ef566a0f370afc0",
                Updated = WorkshopDate("30 Oct, 2018"),
            });

            AddMod(new Review(1518485094uL, "Mesh Import Rotation Tangents Fix") {
                Affect = Factor.Other,
                Authors = "egi, Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                    { NOTE, "(Creators) See: http://cslmodding.info/normal-maps" },
                },
                Published = WorkshopDate("21 Sep, 2018"),
                Updated = WorkshopDate("21 Sep, 2018"),
            });

            AddMod(new Review(1406275125uL, "Asset DLC flags Editor") {
                Affect = Factor.Other,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("8 Jun, 2018"),
                Updated = WorkshopDate("3 Aug, 2019"),
            });

            AddMod(new Review(1393831156uL, "Sub Mesh Flags") {
                Affect = Factor.Other,
                Authors = "TP​​​B",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                //CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "There are some reports of this mod not working; if it works for you please let aubergine18 know on mod compatibility checker workshop page." },
                    { NOTE, "(Users) This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                    { NOTE, "(Creators) Flag support depends on vehicle/building type. See workshop page for details." },
                },
                Published = WorkshopDate("25 May, 2018"),
                Updated = WorkshopDate("25 May, 2018"),
            });

            AddMod(new Review(1364044386uL, "Theme Editor Maps") {
                Affect = Factor.MapThemes
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("17 Apr, 2018"),
                SourceURL = "https://github.com/TPBCS/ThemeEditorMaps",
                Updated = WorkshopDate("24 May, 2018"),
            });

            AddMod(new Review(1361644472uL, "Precise Prop Positioning for Asset Creators") {
                Affect = Factor.Props,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("15 Apr, 2018"),
                Updated = WorkshopDate("15 Apr, 2018"),
            });

            // not really editor mod, but is designed for creators
            AddMod(new Review(1122189715uL, "Realtime") {
                Affect = Factor.Textures,
                Authors = "Ronyx69, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {

                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod assists with content creation; if you don't create content, you probably don't need this mod." },
                    { NOTE, "(Creators) Don't make your assets too bright: https://steamcommunity.com/workshop/filedetails/?id=1586722178" },
                },
                Published = WorkshopDate("28 Aug, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/280e5695b3caeac7ef8b356cc36e0a7c",
                Updated = WorkshopDate("28 Aug, 2017"),
            });

            AddMod(new Review(954067599uL, "PropRotating Params") {
                Affect = Factor.Props,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorMod
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) Some props require this mod to function properly." },
                    { NOTE, "(Creators) Use prop rotating shader instead: https://cslmodding.info/shader/proprotating/" },
                },
                Published = WorkshopDate("24 Jun, 2017"),
                Updated = WorkshopDate("24 Sep, 2018"),
            });

            AddMod(new Review(881161181uL, "More Asset Tags") {
                Affect = Factor.UI,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("04 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "List of asset tags: http://steamcommunity.com/workshop/filedetails/discussion/881161181/133259227524945380/" },
                },
                Published = WorkshopDate("11 Mar, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-MoreAssetTags",
                Updated = WorkshopDate("28 Mar, 2020"),
            });

            AddMod(new Review(800820816uL, "Extended Asset Editor 0.4.11") {
                Affect = Factor.UI,
                Authors = "Acc3ss Violation",
                //BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1886877404uL, Status.MinorIssues  }, // Custom Effect Loader
                    { 1552053911uL, Status.Required     }, // TrailerVariation Loader
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "(Users) This mod assists with content creation; if you don't create content, you probably don't need this mod." },
                    { NOTE, "The 'Remove' button sometimes hides the trailer panel. Reselect a trailer using the dropdown to make it show again." },
                    { NOTE, "List of variations: https://docs.google.com/spreadsheets/d/1XtRwR8cCTLlm6olfzFGhukSO2koaDPt-FJnZgXv73kw/edit#gid=0" },
                    { NOTE, "Sunset Harbor: Users report the 'Save Asset' button is unreliable, and tram trailers are not importing." },
                    { 1886877404uL, "[Mod: Custom Effect Loader] Vehicles edited/published while CEL + EAE are active might have hard-dependency on CEL." },
                },
                Published = WorkshopDate("16 Nov, 2016"),
                SourceURL = "https://github.com/Acc3ssViolation/ExtendedAssetEditor",
                Updated = WorkshopDate("2 Nov, 2018"),
            });

            AddMod(new Review(790347696uL, "Advanced Buildings Editor") {
                Affect = Factor.UI,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 482851182uL , Status.Incompatible }, // Prop Probability Changer
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Looks like this mod is broken since Sunset Harbor update; check workshop page." },
                },
                Published = WorkshopDate("30 Oct, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-AdvancedBuildingsEdtior",
                Updated = WorkshopDate("20 May, 2017"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // https://web.archive.org/web/20170801000000*/http://steamcommunity.com/sharedfiles/filedetails/?id=482851182
            AddMod(new Review(482851182uL, "Prop Probability Changer") {
                Affect = Factor.Props,
                Authors = "boformer", // mendtioned in desc of 502513265uL asset - 19 Aug, 2015
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 790347696uL , Status.Incompatible }, // Advanced Buildings Editor
                },
                CompatibleWith = GameVersion.Stadiums, // based on last seen; people were still using it then
                Flags = ItemFlags.Abandonware
                      //| ItemFlags.BrokenByUpdate - but no idea which one
                      | ItemFlags.EditorBreaking
                      | ItemFlags.EditorMod
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable, // checked boformers github but could not find it
                LastSeen = WorkshopDate("30 Oct, 2016"), // BP linked to it from 790347696uL
                Published = WorkshopDate("17 Jul, 2015"), // adjacent workshop item
                Removed = WorkshopDate("5 Feb, 2017"), // web archive
                Updated = WorkshopDate("17 Jul, 2015"), // unable to find further info
            });
        }
    }
}