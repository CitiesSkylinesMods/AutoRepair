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
        private void PaintMods() {

            string catalog = "Paint";

            AddMod(new Review(1818462177uL, "Vehicle Color Expander") {
                Affect = Factor.Textures,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2085902218uL, Status.Compatible   }, // Advanced Vehicle Options 1.9.3 BETA
                    { 1808439336uL, Status.Compatible   }, // Building Color Expander
                    { 1548831935uL, Status.Compatible   }, // Advanced Vehicle Options AVO (Industries DLC ready)
                    { 442167376uL , Status.Incompatible }, // Advanced Vehicle Options (AVO)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/VehicleColorExpander",
            });

            AddMod(new Review(1869561285uL, "Prop Painter 2.6.0") {
                Affect = Factor.Textures
                       | Factor.TileLimit, // 81 tiles mod sometimes breaks it
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Sometimes breaks if 81 Tiles mod active
                    { 1575247594uL, Status.MinorIssues  }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066uL, Status.MinorIssues  }, // 81MOD
                    { 1361478243uL, Status.MinorIssues  }, // 81 Tiles
                    { 1223738434uL, Status.MinorIssues  }, // 422554572
                    { 616078328uL , Status.MinorIssues  }, // All Tile Start
                    { 576327847uL , Status.MinorIssues  }, // 81 Tiles (BP version)
                    { 422554572uL , Status.MinorIssues  }, // 81 Tiles Updated
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable, // linked on workshop page, but github repo deleted
                Notes = new Dictionary<ulong, string>() {
                    { 576327847uL, "[Mod: 81 Tiles] Prop Painter will sometimes lose its settings if 81 Tiles is active." },
                },
            });

            // editor mod
            AddMod(new Review(1288816430uL, "Hex Colors") {
                Affect = Factor.UI,
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

                    { 2016920607uL, Status.Incompatible }, // RICO revisited
                    { 1204126182uL, Status.Incompatible }, // Ploppable Rico High Density Fix
                    { 586012417uL , Status.Incompatible }, // Ploppable RICO
                },
                Flags = ItemFlags.EditorMod
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 2016920607uL, "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                    { 1204126182uL, "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                    { 586012417uL , "[Ploppable RICO] Breaks the Hex Color in the asset editor." },
                },
                SourceURL = "https://github.com/targettius/cs-hex-colors",
            });

            AddMod(new Review(689937287uL, "Surface Painter") {
                Affect = Factor.Textures,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 576327847uL , Status.MinorIssues  }, // 81 Tiles (BP version)
                    { 502750307uL , Status.Required     }, // Extra Landscaping Tools
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Users reporting 'Array index is out of range' errors - but might be mod conflict." },
                    { NOTE, "Sunset Harbor: Users reporting that the painted textures look strange - might be Procedural Objects mod?" },
                    { 672248733uL, "[Mod: Ultimate Eye Candy] May cause Surface Painer customisations to reset (unconfirmed reports)." },
                    { 576327847uL, "[Mod: 81 Tiles] Surface Painter customisations sometimes reset if 81 Tiles active - might be due to Ultimate Eye Candy mod?" },
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
            AddMod(new Review(1442713872uL, "Detail") {
                Affect = Factor.Textures,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1442615478uL, Status.Recommended }, // Detail Nature
                    { 1094334744uL, Status.MinorIssues }, // Procedural Objects
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // Prop Painter and Network Skins 2
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // multiple existing users stating it doesn't work any more
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Shift+Alt+D to toggle visibility of all props." },
                    { NOTE, "Asset creators, see: https://cslmodding.info/mod/detail/" },
                    { NOTE, "Asset creators, example assets: https://drive.google.com/open?id=1xH7qB67NhVrlwtTW6gNfKD8FeRl-DNyl" },
                    { 1094334744uL, "[Mod: Procedural Objects] PO Ploppable Asphalt props might disappear when Detail mod is active: http://proceduralobjects.shoutwiki.com/wiki/Known_Issues" },
                },
                Published = WorkshopDate("16 Jul, 2018"),
                SourceURL = "https://gist.github.com/ronyx69/68d57f77e721dabefaefa864cc29616b",
                Updated = WorkshopDate("16 Jul, 2018"),
            });

        }
    }
}
