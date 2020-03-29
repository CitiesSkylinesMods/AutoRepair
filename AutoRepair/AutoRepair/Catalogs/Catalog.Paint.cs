namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that primarily change colour of things.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        private void PaintCatalog() {

            string catalog = "Paint";

            AddMod(new Item(1818462177u, "Vehicle Color Expander") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1808439336u, Status.Compatible   }, // Building Color Expander
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/VehicleColorExpander",
            });

            // todo: prolly incompat with painter mod? asked Klyte for confirmation
            AddMod(new Item(1808439336u, "Building Color Expander") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1818462177u, Status.Compatible   }, // Vehicle Color Expander
                    { 1808439336u, Status.Compatible   }, // Building Color Expander
                    { 1372431101u, Status.Unknown      }, // Painter
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/BuildingColorExpander",
            });

            AddMod(new Item(1869561285u, "Prop Painter 2.6.0") {
                Affect = Factor.Textures
                       | Factor.TileLimit, // 81 tiles mod sometimes breaks it
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Sometimes breaks if 81 Tiles mod active
                    { 1575247594u, Status.MinorIssues  }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066u, Status.MinorIssues  }, // 81MOD
                    { 1361478243u, Status.MinorIssues  }, // 81 Tiles
                    { 1223738434u, Status.MinorIssues  }, // 422554572
                    { 616078328u , Status.MinorIssues  }, // All Tile Start
                    { 576327847u , Status.MinorIssues  }, // 81 Tiles (BP version)
                    { 422554572u , Status.MinorIssues  }, // 81 Tiles Updated
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable, // linked on workshop page, but github repo deleted
                Notes = new Dictionary<ulong, string>() {
                    { 576327847u, "[Mod: 81 Tiles] Prop Painter will sometimes lose its settings if 81 Tiles is active." },
                },
            });

            AddMod(new Item(1372431101u, "Painter") {
                Affect = Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1808439336u, Status.Unknown      }, // Building Color Expander
                    { 1372431101u, Status.Incompatible }, // Painter
                    { 530771650u , Status.Recommended  }, // Prefab hook (enables invert and colorize options)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/Painter",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // seems broken by one of the game updates, but needs some extra testing
            // possibly also conflict with prop painter
            AddMod(new Item(1442713872u, "Detail") {
                Affect = Factor.Textures,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744u, Status.MinorIssues }, // Procedural Objects
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // Prop Painter and Network Skins 2
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // multiple existing users stating it doesn't work any more
                SourceURL = "https://gist.github.com/ronyx69/68d57f77e721dabefaefa864cc29616b",
            });

        }
    }
}
