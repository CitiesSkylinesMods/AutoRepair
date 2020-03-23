/*
using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {
    /// <summary>
    /// Texture packs.
    /// </summary>
    public partial class Skins {

        /// <summary>
        /// Add packs to list.
        /// </summary>
        private void AddPacksToList() {
            string catalog = "Skins.Packs";

            // Minor incompatibilities with TMPE
            // See: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core

            AddMod(new Item(1573387594u, "[NL] Roads United: The Netherlands") {
                Authors = "lennart",
                Catalog = catalog,
                Flags = ItemFlags.MinorBugs // error when activated
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 726005715u }, // Roads United: Core+
                },
                Locale = "nl",
                RequiredMods = new List<ulong>() {
                    { 633547552u }, // Roads United Core 2.0
                },
            });

            AddMod(new Item(1565201461u, "Roads United: US Reworked 2018") {
                Authors = "Pres",
                Catalog = catalog,
                Flags = ItemFlags.LargeFileWarning // 503.136 MB
                      | ItemFlags.MinorBugs // some textures not working, and mirroring of highway textures
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                RequiredMods = new List<ulong>() {
                    { 726005715u }, // Roads United: Core+
                    { 633547552u }, // Roads United Core 2.0
                },
                RequiredModsSelection = Selection.OnlyOne,
            });

            // Made from mix of: 726004927u and 848896702u
            Add(new Item(935747460u, "Roads United: US Edition - Concrete Only Highways") {
                Authors = "B4NK35",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 547.958 MB
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 633547552u }, // Roads United Core 2.0
                },
                Locale = "en-us",
                RequiredMods = new List<ulong>() {
                    { 726005715u }, // Roads United: Core+
                },
            });
        }
    }
}
*/