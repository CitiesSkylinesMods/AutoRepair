namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that hide or remove stuff.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void HideCatalog() {

            string catalog = "Hide";

            // Requires TM:PE
            AddMod(new Item(2019097300u, "Hide TM:PE Unconnected Tracks") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings, // not really, but close enough
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1637663252u, Status.Compatible   }, // TM:PE STABLE
                    { 1806963141u, Status.Required     }, // TM:PE LABS
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1758376843u, Status.Compatible   }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1939169189u, Status.Compatible   }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Compatible   }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1147015481u, Status.Compatible   }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Compatible   }, // Remove Road Textures - Blank Roads
                    { 583429740u , Status.Incompatible }, // TM:PE 10.20
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/kianzarrin/HideUnconnectedTracks",
                Tags = new[] { "TMPE", "TM:PE", "Tram", "Train", "Network", "Skins", "Junctions", "Tracks" },
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1939169189u, "Hide Crosswalks V3.0 [EXPERIMENTAL]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1637663252u, Status.Compatible   }, // TM:PE STABLE
                    { 1806963141u, Status.Recommended  }, // TM:PE LABS
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1758376843u, Status.Recommended  }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 583429740u , Status.Incompatible }, // TM:PE 10.20
                },
                ContinuationOf = 1934023593u, // Hide TMPE crosswalks V2.5 [BETA]
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1934023593u, "Hide TMPE crosswalks V2.5 [BETA]") {
                Affect = Factor.HideRemove
                       | Factor.RoadMarkings,
                Authors = "kian.zarrin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1637663252u, Status.Recommended  }, // TM:PE STABLE
                    { 1806963141u, Status.Compatible   }, // TM:PE LABS
                    { 2019097300u, Status.Compatible   }, // Hide TM:PE Unconnected Tracks
                    { 1758376843u, Status.Recommended  }, // Network Skins 2
                    { 1680642819u, Status.Recommended  }, // Ultimate Level of Detail (ULOD)
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 583429740u , Status.Incompatible }, // TM:PE 10.20
                },
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/kianzarrin/HideTMPECrosswalks",
                Tags = new[] { "TMPE", "TM:PE", "Crosswalks", "Crossings", "Network", "Skins", "Junctions", "Pedestrian" },
            });
        }
    }
}