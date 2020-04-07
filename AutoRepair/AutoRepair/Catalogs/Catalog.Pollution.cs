namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Map themes, cubemap, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void PollutionCatalog() {

            string catalog = "Pollution";

            AddMod(new Item(666425898u, "No Radioactive Desert And More!") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160u, Status.Incompatible }, // Hide It!
                    { 791968744u , Status.Incompatible }, // Dynamic Foliage // overrides the same codepaths
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160u, "[Mod: Hide It!] Conflcits with No Radioactive Desert; causes terrain textures to disappear from map." },
                },
                Published = WorkshopDate("16 Apr, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-NoOrangeTrees",
                Updated = WorkshopDate("29 Nov, 2016"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(482360157u, "No More Purple [Radioactive Green Grass]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("16 Jul, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("16 Jul, 2015"),
            });

            AddMod(new Item(408190203u, "No More Purple Pollution [Muddy Water]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("15 Mar, 2015"),
            });

            AddMod(new Item(408189919u, "No More Purple Pollution [Silty Water]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Item(408167727u, "No More Purple Pollution [Radioactive Green Water]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("15 Mar, 2015"),
            });

            AddMod(new Item(408126282u, "No More Purple Pollution [Green Water]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("15 Mar, 2015"),
            });

            AddMod(new Item(408126080u, "No More Purple Pollution [Brown Water]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("15 Mar, 2015"),
            });

            AddMod(new Item(407890452u, "No More Purple Pollution [Grey Grass]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Item(407842191u, "No More Purple Pollution [Red-Brown Grass]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Item(407810495u, "No More Purple Pollution [Tan Grass]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Item(407795371u, "No More Purple Pollution [Brown Grass]") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            AddMod(new Item(407270433u, "No More Purple Pollution") {
                Affect = Factor.Pollution
                       | Factor.Textures,
                Authors = "Jeb Bush but super communist",
                BrokenBy = GameVersion.AfterDark,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 775021554u , Status.Incompatible }, // Theme Mixer [OBSOLETE (Use Theme Mixer 2)]
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod [OBSOLETE]
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 408190203u , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919u , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727u , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282u , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080u , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452u , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191u , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495u , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371u , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433u , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"),
                ReplaceWith = 666425898u, // No Radioactive Desert And More!
                SourceURL = "https://github.com/ericsundberg/NoMorePurple",
                Updated = WorkshopDate("14 Mar, 2015"),
            });
        }
    }
}