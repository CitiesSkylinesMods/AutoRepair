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

            AddMod(new Item(1764637396u, "Toggle It!") {
                Affect = Factor.HideRemove,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Toggle it covers functionality of these mods:
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                    { 1540147921u, Status.Incompatible }, // Grid be Gone
                    { 1536223783u, Status.MinorIssues  }, // Hide Selectors
                    { 917543381u , Status.MinorIssues  }, // No Problem Notifications
                    { 903347963u , Status.Incompatible }, // Transparent Selectors
                    { 877748783u , Status.Incompatible }, // Topographic Lines Toggle
                    { 592076973u , Status.MinorIssues  }, // Zoning toolset (toggle + upgrade tool)
                    { 561293123u , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                    { 553319260u , Status.MinorIssues  }, // Hide Border Line and Asset Editor Grid
                    { 507225392u , Status.MinorIssues  }, // Topographic Info View
                    { 465318661u , Status.Incompatible }, // Toggleable Whiteness
                    { 451193058u , Status.Incompatible }, // The Original Hide Policy Icons
                    { 443904654u , Status.Incompatible }, // Zoning and Districts Co-viewer
                    { 439360165u , Status.Incompatible }, // mabako's Hide District Policy Icons Mod
                    { 437716646u , Status.MinorIssues  }, // Cities Atlas
                    { 433557907u , Status.Incompatible }, // District UI Tweaks: Hide Names
                    { 421443866u , Status.Incompatible }, // Zone Colours
                    { 410842044u , Status.Incompatible }, // Persistent Resource View
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs // harmony patch management could be better, map borders keep reappearing
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/keallu/CSL-ToggleIt",
            });

            AddMod(new Item(1591417160u, "Hide It!") {
                Affect = Factor.HideRemove,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1962752152u, Status.Incompatible }, // Busstop Prop Remover
                    { 1899640536u, Status.MinorIssues  }, // Theme Mixer 2 (both can toggle terrain sprites)
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 564141599u , Status.MinorIssues  }, // No Seagulls
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                Notes = new Dictionary<ulong, string>() {
                    { 1899640536u, "[Mod: Theme Mixer 2] Terrain sprites affected by both mods; check sprite settings in both to ensure same effect." },
                    { 666425898u , "[Mod: No Radioactive Desert] Conflcits with Hide It causing terrain textures to disappear from map." },
                    { 564141599u , "[Mod: No Seagulls] Both mods can remove seagulls. If you want to use No Seagulls mod, disable 'Seagulls' option in Hide It mod." },
                },
                SourceURL = "https://github.com/keallu/CSL-HideIt",
            });

            AddMod(new Item(564141599u, "No Seagulls") {
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706704781 , Status.Incompatible }, // Remove All Animals
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 587536931u , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 421041154u , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328u , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160u, "[Mod: Hide It] Both mods can remove seagulls. If you want to use No Seagulls mod, disable 'Seagulls' option in Hide It mod." },
                },
                SourceURL = "https://github.com/thale5/NoSeagulls",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */



        }
    }
}