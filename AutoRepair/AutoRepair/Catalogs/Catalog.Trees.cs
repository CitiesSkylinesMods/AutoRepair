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
        private void TreeMods() {

            string catalog = "Trees";

            AddMod(new Review(1803209875uL, "Trees' Respiration 1.0.1") {
                Affect = Factor.Environment
                       | Factor.Health
                       | Factor.Pollution
                       | Factor.Trees,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/TreesRespiration",
                Tags = new[] { "Trees", "Pollution", "Environment", "Noise", "Health" },
            });

            AddMod(new Review(1658679290uL, "Forest Brush v1.3") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "TPB, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1928787248uL, Status.Recommended  }, // Weeds
                    { 1654658173uL, Status.Incompatible }, // Random Tree Brush
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 963853793uL , Status.Recommended  }, // Ultra low tri trees
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/ForestBrush",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Review(1654658173uL, "Random Tree Brush") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "toster.",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248uL, Status.Recommended  }, // Weeds
                    { 1658679290uL, Status.Incompatible }, // Forest Brush v1.3
                    { 963853793uL , Status.Recommended  }, // Ultra low tri trees
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://pastebin.com/8M0gFKZh",
                Tags = new[] { "Trees", "Brush", "Forest", "Landscape", "Random", "Paint", "Environment", "Detailing", },
            });

            AddMod(new Review(1637106958uL, "Lock Forestry") {
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
                    { 593588108uL, Status.Recommended }, // Prop & Tree Anarchy
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Trees", "Forest", "Landscape", "Farming", "Forestry", "Environment", "Detailing", "Industry", },
            });

            AddMod(new Review(1388613752uL, "Tree Movement Control") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "saki7, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1388613752uL, Status.Incompatible }, // Tree Movement Control
                    { 842981708uL , Status.Incompatible }, // Random Tree Rotation for Natural Disasters
                    { 556784825uL , Status.Incompatible }, // Random Tree Rotation (original, now fixed)
                },
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("18 May, 2018"),
                Tags = new[] { "Trees", "Forest", "Landscape", "Wind", "Swaying", "Environment", "Detailing", },
                Updated = WorkshopDate("24 May, 2018"),
            });

            // render catalog?
            AddMod(new Review(1349895184uL, "Tree LOD Fix") {
                Affect = Factor.Environment
                       | Factor.Rendering
                       | Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1680642819uL, Status.Compatible }, // Ultimate Level of Detail (ULOD)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: An error sometimes appears on startup, but it seems to work properly after that." },
                    { NOTE, "This mod improves quality of tree LODs with almost no impact on performance." },
                    { 1680642819uL, "[Mod: ULOD] If Tree LOD Fix enabled, try setting tree LOD range lower for faster performance." },
                },
                Published = WorkshopDate("2 Apr, 2018"),
                Tags = new[] { "Trees", "Forest", "Landscape", "LODs", "Graphics", "Environment", "Detailing", },
                Updated = WorkshopDate("5 Apr, 2018"),
            });

            AddMod(new Review(910440715uL, "Plant Scaling") {
                Affect = Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod takes effect whilst placing trees on the map:" },
                    { NOTE, "Press Ctrl + Up/Down to incease/decrease min scale." },
                    { NOTE, "Press Alt + Up/Down to incease/decrease max scale." },
                    { NOTE, "Press Ctrl + Alt + Up/Down to incease/decrease both min and max scale." },
                    { NOTE, "With shortcuts above, pressing Right arrow will increase/decrease faster." },
                    { NOTE, "Press Home to reset to default." },
                },
                Published = WorkshopDate("22 Apr, 2017"),
                Updated = WorkshopDate("13 Nov, 2018"),
            });

            AddMod(new Review(877950833uL, "Vanilla Trees Remover") {
                Affect = Factor.Trees,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1758376843uL, Status.MinorIssues  }, // Neetwork Skins 2
                    { 593588108uL , Status.Required     }, // Prop & Tree Anarchy
                    { 543722850uL , Status.MinorIssues  }, // Network Skins
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Removing trees from the map is permanent (for that city). However, trees removed from buildings/roads will return if you change mod settings." },
                    { 1758376843uL, "[Mod: Network Skins 2] For best compatibility, disable road tree removal in Vanilla Trees Remover." },
                    { 543722850uL , "[Mod: Network Skins] For best compatibility, disable road tree removal in Vanilla Trees Remover." },
                },
                Published = WorkshopDate("6 Mar, 2017"),
                Updated = WorkshopDate("26 May, 2019"),
            });

            AddMod(new Review(869134690uL, "Tree Snapping") {
                Affect = Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1349895184uL, Status.Recommended  }, // Tree LOD Fix
                    { 869134690uL , Status.Incompatible }, // Tree Snapping
                    { 455403039uL , Status.Incompatible }, // Unlimited Trees Mod v1.1
                    { 413502249uL , Status.Incompatible }, // Unlimited Trees (original)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 455403039uL, "[Mod: Unlimited Trees] Causes trees to float in the air when used with Tree Snapping mod." },
                },
                Published = WorkshopDate("21 Feb, 2017"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-TreeSnapping",
                Updated = WorkshopDate("24 May, 2018"),
            });

            AddMod(new Review(556784825uL, "Random Tree Rotation") {
                Affect = Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1388613752uL, Status.Incompatible }, // Tree Movement Control
                    { 842981708uL , Status.Incompatible }, // Random Tree Rotation for Natural Disasters
                    { 556784825uL , Status.Incompatible }, // Random Tree Rotation (original, now fixed)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("17 Nov, 2015"),
                ReplaceWith = 1388613752uL, // Tree Movement Control
                SourceURL = "https://gist.github.com/boformer/5f8e9269b02d5b8809da",
                Updated = WorkshopDate("12 Mar, 2019"),
            });

            AddMod(new Review(455403039uL, "Unlimited Trees Mod v1.12") {
                Affect = Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "DRen72, knighthawkGP, BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1928787248uL, Status.Recommended  }, // Weeds
                    { 1658679290uL, Status.Recommended  }, // Forest Brush
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1388613752uL, Status.Recommended  }, // Tree Movement Control
                    { 1349895184uL, Status.Recommended  }, // Tree LOD Fix
                    { 963853793uL , Status.Recommended  }, // Ultra low tri trees
                    { 869134690uL , Status.Incompatible }, // Tree Snapping
                    { 556784825uL , Status.Recommended  }, // Random Tree Rotation
                    { 455403039uL , Status.Incompatible }, // Unlimited Trees Mod v1.1
                    { 413502249uL , Status.Incompatible }, // Unlimited Trees (original)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 413502249uL, // Unlimied Trees by Mabako
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "May cause lag on older computers or old graphics cards (although game is highly optimised for distant trees). May increase RAM consumption." },
                    { 869134690uL, "[Mod: Tree Snapping] Causes trees to float in the air when used with Unlimited Trees mod." },
                },
                Published = WorkshopDate("5 Jun, 2015"),
                SourceURL = "https://github.com/bloodypenguin/TreeUnlimiter",
                Updated = WorkshopDate("24 May, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(842981708uL, "Random Tree Rotation for Natural Disasters") {
                Affect = Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "Judazzz, boformer",
                BrokenBy = GameVersion.NaturalDisasters, // this mod didn't fix the flickering issue
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1388613752uL, Status.Incompatible }, // Tree Movement Control
                    { 842981708uL , Status.Incompatible }, // Random Tree Rotation for Natural Disasters
                    { 556784825uL , Status.Incompatible }, // Random Tree Rotation (original, now fixed)
                },
                CompatibleWith = GameVersion.NaturalDisasters,
                ContinuationOf = 556784825uL, // Random Tree Rotation
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // original mod updated
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Causes trees to flicker when zoomed out; unsubscribe and use replacement mod instead." },
                },
                Published = WorkshopDate("15 Jan, 2017"),
                ReplaceWith = 556784825uL, // Random Tree Rotation
                Suppress = Warning.InvalidVersionSequence | Warning.OlderReplacement,
                Updated = WorkshopDate("15 Jan, 2017"),
            });

            // can't find it on wayback machine
            // original mod id found in old dll file: https://github.com/Knighth/TreeUnlimiter/blob/master/mabako_Original_Unlimiter.dll
            // KnighthawkGP created a git repo with decompiled dll (listed above) on 6 Jun 2015, so it was already dead by then
            AddMod(new Review(413502249uL, "Unlimited Trees") {
                Affect = Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "Mabako",
                BrokenBy = GameVersion.EuropeBiome,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 869134690uL , Status.Incompatible }, // Tree Snapping
                    { 455403039uL , Status.Incompatible }, // Unlimited Trees Mod v1.1
                    { 413502249uL , Status.Incompatible }, // Unlimited Trees (original)
                },
                CompatibleWith = GameVersion.Patch_1_0_7c,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.EditorBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Mod tries to self-enable and runs detours on startup; do NOT use this version of Tree Unlimiter." },
                    { NOTE, "Could not find original source by Mabako, but found archive of decompiled dll (listed as Source URL)." },
                    { 869134690uL, "[Mod: Tree Snapping] Causes trees to float in the air when used with Unlimited Trees mod." },
                },
                Published = WorkshopDate("24 Mar, 2015"), // based on workshop id 413502248 :)
                ReplaceWith = 455403039uL, // Unlimited Trees Mod v1.12
                SourceURL = "https://github.com/Knighth/TreeUnlimiter", // note: not by original author; but close enough
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("24 Mar, 2015"), // no idea if there were any updates
                UserModInspected = true,
            });

            AddMod(new Review(406723376uL, "Tree Brush") {
                Affect = Factor.Environment
                       | Factor.PlaceAndMove
                       | Factor.Trees,
                Authors = "Destroyer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1928787248uL, Status.Recommended  }, // Weeds
                    { 963853793uL , Status.Recommended  }, // Ultra low tri trees
                    { 502750307uL , Status.Incompatible }, // Extra Landscaping Tools
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The 'Broken and Incompatible Mods' google sheet states this mod is dead, however some users report that it still works." },
                },
                Published = WorkshopDate("12 Mar, 2015"),
                ReplaceWith = 502750307uL, // Extra Landscaping Tools
                Updated = WorkshopDate("21 Oct, 2017"),
            });
        }
    }
}