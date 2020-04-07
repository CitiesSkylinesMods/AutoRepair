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
                    { 1548831935u, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 442167376u , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/VehicleColorExpander",
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

            // editor mod
            AddMod(new Item(1288816430u, "Hex Colors") {
                Authors = "targa",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // COMPATIBLE:
                    // 81 Tiles
                    // Advanced Buildings Editor
                    // AnimUV Params
                    // Asset ItemClass Changer
                    // Asset Prefab(+Building) AI Changer
                    // Asset UI Category Changer
                    // Asset UI Priority Changer
                    // Camera Positions Utility
                    // Custom Light Effects
                    // Extended Asset Editor
                    // Fine Road Anarchy
                    // ModTools
                    // More Beautification
                    // More Network Stuff
                    // MoveIt
                    // NetworkSkins
                    // Prefab Hook
                    // Prop & Tree Anarchy
                    // Prop Line Tool
                    // Prop Precision
                    // PropRotating Params
                    // PropSnapping
                    // Transparency LODs Fix
                    // Ultimate Eyecandy

                    { 2016920607u, Status.Incompatible }, // RICO revisited
                    { 1204126182u, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 586012417u , Status.Incompatible }, // Ploppable RICO
                    // RICO Revisited?
                },
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 2016920607u, "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                    { 1204126182u, "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                    { 586012417u , "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                },
                SourceURL = "https://github.com/targettius/cs-hex-colors",
            });

            AddMod(new Item(689937287u, "Surface Painter") {
                Affect = Factor.Textures,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 576327847u , Status.MinorIssues  }, // 81 Tiles (BP version)
                    { 502750307u , Status.Required     }, // Extra Landscaping Tools
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Users reporting 'Array index is out of range' errors." },
                    { NOTE, "Sunset Harbor: Users reporting that the painted textures look strange." },
                    { 672248733u, "[Mod: Ultimate Eye Candy] May cause Surface Painer customisations to reset (unconfirmed reports)." },
                    { 576327847u, "[Mod: 81 Tiles] Surface Painter customisations sometimes reset if 81 Tiles active." },
                },
                SourceURL = "https://github.com/bloodypenguin/Skylines-SurfacePainter",
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
                    { 1442615478u, Status.Recommended }, // Detail Nature
                    { 1094334744u, Status.MinorIssues }, // Procedural Objects
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // Prop Painter and Network Skins 2
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // multiple existing users stating it doesn't work any more
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Shift+Alt+D to toggle visibility of all props." },
                    { NOTE, "Asset creators, see: https://cslmodding.info/mod/detail/" },
                    { NOTE, "Asset creators, example assets: https://drive.google.com/open?id=1xH7qB67NhVrlwtTW6gNfKD8FeRl-DNyl" },
                    { 1094334744u, "[Mod: Procedural Objects] PO Ploppable Asphalt props might disappear when Detail mod is active: http://proceduralobjects.shoutwiki.com/wiki/Known_Issues" },
                },
                Published = WorkshopDate("16 Jul, 2018"),
                SourceURL = "https://gist.github.com/ronyx69/68d57f77e721dabefaefa864cc29616b",
                Updated = WorkshopDate("16 Jul, 2018"),
            });

        }
    }
}
