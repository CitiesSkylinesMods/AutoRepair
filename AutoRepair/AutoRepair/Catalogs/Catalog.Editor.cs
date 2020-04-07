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
        private void EditorCatalog() {

            string catalog = "Editor";

            // todo: move to converter cat?
            AddMod(new Item(1552053911u, "TrailerVariation Loader") {
                Affect = Factor.Vehicles,
                Authors = "Acc3ss Violation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 800820816u, Status.Recommended }, // Extended Asset Editor 0.4.11
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: It might increase game loading time if you have lots of vehicles." },
                    { NOTE, "Asset creators: Do NOT use additive shader on submeshes with non-zero variation mask." },
                },
                Published = WorkshopDate("30 Oct, 2018"),
                SourceURL = "https://gist.github.com/Acc3ssViolation/a129c802e7e2eaeb2ef566a0f370afc0",
                Updated = WorkshopDate("30 Oct, 2018"),
            });

            AddMod(new Item(1518485094u, "Mesh Import Rotation Tangents Fix") {
                Affect = Factor.Other,
                Authors = "egi, Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                    { NOTE, "Asset creators, see: http://cslmodding.info/normal-maps" },
                },
                Published = WorkshopDate("21 Sep, 2018"),
                Updated = WorkshopDate("21 Sep, 2018"),
            });

            AddMod(new Item(1406275125u, "Asset DLC flags Editor") {
                Affect = Factor.Other,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("8 Jun, 2018"),
                Updated = WorkshopDate("3 Aug, 2019"),
            });

            AddMod(new Item(1393831156u, "Sub Mesh Flags") {
                Affect = Factor.Other,
                Authors = "TP​​​B",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                //CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If this is working, please let aubergine18 know on mod compatbility checker workshop page." },
                    { NOTE, "Users: This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                    { NOTE, "Asset creators: See important note in workshop description: https://steamcommunity.com/sharedfiles/filedetails/?id=1393831156u" },
                },
                Published = WorkshopDate("25 May, 2018"),
                Updated = WorkshopDate("25 May, 2018"),
            });

            AddMod(new Item(1364044386u, "Theme Editor Maps") {
                Affect = Factor.MapThemes
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("17 Apr, 2018"),
                SourceURL = "https://github.com/TPBCS/ThemeEditorMaps",
                Updated = WorkshopDate("24 May, 2018"),
            });

            AddMod(new Item(1361644472u, "Precise Prop Positioning for Asset Creators") {
                Affect = Factor.Props,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: This mod is for content creation; if you don't use asset editor, you don't need this mod." },
                },
                Published = WorkshopDate("15 Apr, 2018"),
                Updated = WorkshopDate("15 Apr, 2018"),
            });

            // not really editor mod, but is designed for creators
            AddMod(new Item(1122189715u, "Realtime") {
                Affect = Factor.Textures,
                Authors = "Ronyx69, Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {

                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: This mod assists with content creation; if you don't create content, you probably don't need this mod." },
                    { NOTE, "Asset creators, don't make your assets too bright: https://steamcommunity.com/workshop/filedetails/?id=1586722178" },
                },
                Published = WorkshopDate("28 Aug, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/280e5695b3caeac7ef8b356cc36e0a7c",
                Updated = WorkshopDate("28 Aug, 2017"),
            });

            AddMod(new Item(954067599u, "PropRotating Params") {
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users: If a prop lists this mod as requirement, you should still use it." },
                    { NOTE, "Asset authors, use this instead: https://cslmodding.info/shader/proprotating/" },
                },
                Published = WorkshopDate("24 Jun, 2017"),
                Updated = WorkshopDate("24 Sep, 2018"),
            });
        }
    }
}