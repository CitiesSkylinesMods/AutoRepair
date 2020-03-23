namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that primarily relate to trees.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void TreesCatalog() {

            string catalog = "Trees";

            AddMod(new Item(1803209875u, "Trees' Respiration 1.0.1") {
                Affect = Factor.Environment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Trees,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with tmpe
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/TreesRespiration",
                Tags = new[] { "Trees", "Pollution", "Environment", "Noise", "Health" },
            });

            AddMod(new Item(1658679290u, "Forest Brush v1.3") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "TPB, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248u, Status.Recommended  }, // Weeds
                    { 1654658173u, Status.Incompatible }, // Random Tree Brush
                    { 963853793u , Status.Recommended  }, // Ultra low tri trees
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/ForestBrush",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Item(1654658173u, "Random Tree Brush") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "toster.",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248u, Status.Recommended  }, // Weeds
                    { 1658679290u, Status.Incompatible }, // Forest Brush v1.3
                    { 963853793u , Status.Recommended  }, // Ultra low tri trees
                },
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Abandonware,
                SourceURL = "https://pastebin.com/8M0gFKZh",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Item(1637106958u, "Lock Forestry") {
                Affect = Factor.Environment
                       | Factor.HideRemove
                       | Factor.PlaceAndMove
                       | Factor.Production
                       | Factor.Textures
                       | Factor.Trees
                       | Factor.Zoning,
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 593588108u, Status.Recommended }, // Prop & Tree Anarchy
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "Farming", "Forestry", "Environment", "Detailing", "Industry", },
            });

            AddMod(new Item(1388613752u, "Tree Movement Control") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "saki7, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho - Fundamental support mod for hardcore builders
                    { 842981708u , Status.Incompatible }, // Random Tree Rotation
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "Wind", "Swaying", "Environment", "Detailing", },
            });

            // render catalog?
            AddMod(new Item(1349895184u, "Tree LOD Fix") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // recommend ulod?
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "LODs", "Graphics", "Environment", "Detailing", },
            });
        }
    }
}