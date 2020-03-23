namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Building Themes Mod and it's theme packs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add items to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void BuildingThemesCatalog() {

            string catalog = "BuildingThemes";

            // note: may at some point list all the required buildings per theme, but can't be arsed right now
            Dictionary<ulong, Status> buildingThemesMod = new Dictionary<ulong, Status>() {
                { 466158459u, Status.Required }, // Building Themes mod
            };

            /*
            # ████████ ██   ██ ███████ ███    ███ ███████ ███████
            #    ██    ██   ██ ██      ████  ████ ██      ██
            #    ██    ███████ █████   ██ ████ ██ █████   ███████
            #    ██    ██   ██ ██      ██  ██  ██ ██           ██
            #    ██    ██   ██ ███████ ██      ██ ███████ ███████
            */

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1901228838
            AddMod(new Item(1903967441u, "Building Theme: European Suburbia Decorated") {
                Affect = Factor.Other,
                Authors = "Avanya",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
                RequiredDLC = DLCs.EuropeanSuburbia,
            });

            AddAsset(new Item(1182123078u, "Chalet District Style (Vanilla)") {
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

            AddMod(new Item(1747800340u, "Building Theme: University City Districts") {
                Affect = Factor.Other,
                Authors = "MrMiyagi",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
                RequiredDLC = DLCs.UniversityCity,
            });

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1632934634
            AddMod(new Item(1632933031u, "Building Theme:Japanese low residential theme") {
                Affect = Factor.Other,
                Authors = "TOKACHI269",
                Catalog = catalog,
                Compatibility = buildingThemesMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // collection: https://steamcommunity.com/workshop/filedetails/?id=1182157494
            AddMod(new Item(1222415977u, "Christmas Village Building Theme") {
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
            });
        }
    }
}
