namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Change appearance of buildings.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add items to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void SkinBuildingMods() {

            string catalog = "Skin.Buildings";

            // note: may at some point list all the required buildings per theme, but can't be arsed right now
            Dictionary<ulong, Status> buildingThemesMod = new Dictionary<ulong, Status>() {
                { 466158459u, Status.Required }, // Building Themes mod
            };

            AddMod(new Review(1808439336u, "Building Color Expander") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1818462177u, Status.Compatible   }, // Vehicle Color Expander
                    { 1808439336u, Status.Compatible   }, // Building Color Expander
                    { 1372431101u, Status.Compatible   }, // Painter
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "User guide: https://github.com/klyte45/BuildingColorExpander/blob/master/README.md" },
                },
                SourceURL = "https://github.com/klyte45/BuildingColorExpander",
                Tags = new[] { "Buildings", "Colors", "Colours", "Painter", "Customise", "Customize", "Textures", },
            });

            AddMod(new Review(1782814610u, "Building Variations") {
                Affect = Factor.Textures,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Buildings", "Colors", "Colours", "Painter", "Customise", "Customize", "Textures", "Roof", "Tiles", },
            });

            AddMod(new Review(1372431101u, "Painter") {
                Affect = Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1808439336u, Status.Compatible   }, // Building Color Expander
                    { 1372431101u, Status.Incompatible }, // Painter
                    { 530771650u , Status.Recommended  }, // Prefab hook (enables invert and colorize options)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/Painter",
                Tags = new[] { "Buildings", "Colors", "Colours", "Painter", "Customise", "Customize", "Textures", },
            });

            // opposite of no abandonment lol
            AddMod(new Review(1330378440u, "Building States") {
                Affect = Factor.Textures,
                Authors = "CoarzFlovv",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("14 Mar, 2018"),
                Tags = new[] { "Buildings", "States", "Abandonned", "Abandonment", "Derelict", "Destroyed", "Collapsed", "Burnt", },
                Updated = WorkshopDate("5 Apr, 2018"),
            });


            /*
            # ████████ ██   ██ ███████ ███    ███ ███████ ███████
            #    ██    ██   ██ ██      ████  ████ ██      ██
            #    ██    ███████ █████   ██ ████ ██ █████   ███████
            #    ██    ██   ██ ██      ██  ██  ██ ██           ██
            #    ██    ██   ██ ███████ ██      ██ ███████ ███████
            */

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1901228838
            AddMod(new Review(1903967441u, "Building Theme: European Suburbia Decorated") {
                Affect = Factor.Other,
                Authors = "Avanya",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
                RequiredDLC = DLCs.EuropeanSuburbia,
            });

            AddAsset(new Review(1182123078u, "Chalet District Style (Vanilla)") {
                Affect = Factor.Other,
                Authors = "MrMiyagi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1222415977u, Status.Incompatible }, // Christmas Village Building Theme
                    { 1182033583u, Status.Required     }, // Chalet Housing Pack by Tomcat
                    { 697129136u , Status.Required     }, // Chalet Prop Pack
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1747800340u, "Building Theme: University City Districts") {
                Affect = Factor.Other,
                Authors = "MrMiyagi",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
                RequiredDLC = DLCs.UniversityCity,
            });

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1632934634
            AddMod(new Review(1632933031u, "Building Theme:Japanese low residential theme") {
                Affect = Factor.Other,
                Authors = "TOKACHI269",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1182157494
            AddMod(new Review(1222415977u, "Christmas Village Building Theme") {
                Affect = Factor.Other,
                Authors = "MrMiyagi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1182123078u, Status.Incompatible }, // Chalet District Style (Vanilla)
                    { 1182033583u, Status.Required     }, // Chalet Housing Pack by Tomcat
                    { 697129136u , Status.Required     }, // Chalet Prop Pack
                    { 466158459u , Status.Required     }, // Building Themes mod
                },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1182123078u, // Chalet District Style (Vanilla)
                Suppress = Warning.OlderReplacement,
            });
        }
    }
}
