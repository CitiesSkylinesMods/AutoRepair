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
        private void SkinEnvironmentMods() {

            string catalog = "Skin.Environment";

            AddMod(new Review(2053637074u, "Swinden-Map Theme Mix") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "rlas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Required    }, // Theme Mixer 2
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled,
                Published = WorkshopDate("9 Apr, 2020"),
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            AddMod(new Review(1899640536u, "Theme Mixer 2") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,  
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
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
                CompatibleWith = GameVersion.SunsetHarbor,
                Languages = new[] { "en", "zh-cn", },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Mac OS/X users: Un-tick the compiling checkbox in mod options to avoid errors." },
                    { 1591417160u, "[Mod: Hide It] Terrain sprites affected by both mods; check sprite settings in both to ensure same effect." },
                },
                Published = WorkshopDate("27 Oct, 2019"),
                SourceURL = "https://github.com/TPBCS/ThemeMixer",
                Updated = WorkshopDate("6 Nov, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1445375997u, "Theme Mixer 汉化版2的") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 1899640536u, // Theme Mixer 2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1591417160u, Status.Incompatible }, // Hide It!
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
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
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The replacement version now includes Simplified Chinese translation!" },
                },
                Published = WorkshopDate("19 Jul, 2018"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("19 Jul, 2018"),
            });

            AddMod(new Review(1283010953u, "TerrainTextureReplacer Reupload") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Patrick Bateman",
                Catalog = catalog,
                CloneOf = 416966387u, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("27 Jan, 2018"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("27 Jan, 2018"),
            });

            AddMod(new Review(920832749u, "TerrainTextureReplacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "奴はやつはし",
                Catalog = catalog,
                CloneOf = 416966387u, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "ja",
                Published = WorkshopDate("7 May, 2017"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("7 May, 2017"),
            });

            AddMod(new Review(877394445u, "TerrainTextureReplacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Roenzi",
                Catalog = catalog,
                CloneOf = 416966387u, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("5 Mar, 2017"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("5 Mar, 2017"),
            });

            // Apparently a rewrite, but still game breaking. Suspect it might just be a clone.
            AddMod(new Review(811664974u, "TTR - Terrain Texture Replacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Penrose",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                ContinuationOf = 416966387u, // Terrain Texture Replacer (hyperdrive_engage original)
                Published = WorkshopDate("3 Dec, 2016"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("3 Dec, 2016"),
            });

            // Original "Theme Mixer" mod
            AddMod(new Review(775021554u, "Theme Mixer [OBSOLETE (Use Theme Mixer 2)]") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
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
                Published = WorkshopDate("4 Oct, 2016"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("26 Jun, 2018"),
            });

            AddMod(new Review(574674741u, "Terrain Themes Mod [OBSOLETE]") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "boformer, TPB",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 554680908u , Status.Incompatible }, // Environment Colors Changer
                    { 482360157u , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 435723412u , Status.Incompatible }, // Water Color Changer
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
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
                Published = WorkshopDate("4 Oct, 2016"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("26 Jun, 2018"),
            });

            AddMod(new Review(416966387u, "Terrain Texture Replacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536u, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953u, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749u , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445u , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974u , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554u , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741u , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                //Published = WorkshopDate(""),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("15 Apr, 2015"), // guesstimate based on note here: 811664974u
            });

            /*
            #  ██████  ██      ██████      ████████ ██   ██ ███████ ███    ███ ███████ ███████
            # ██    ██ ██      ██   ██        ██    ██   ██ ██      ████  ████ ██      ██
            # ██    ██ ██      ██   ██        ██    ███████ █████   ██ ████ ██ █████   ███████
            # ██    ██ ██      ██   ██        ██    ██   ██ ██      ██  ██  ██ ██           ██
            #  ██████  ███████ ██████         ██    ██   ██ ███████ ██      ██ ███████ ███████
            */

            // All of these are obsolete as base game introduced map themes.
            // TODO: Try and find replacements if time permits.

            AddMod(new Review(612385904u, "Tatra Mountains Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Ennedi, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 747671403u , Status.Incompatible }, // Wet temperate map theme
                    { 574674741u , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("31 Jan, 2016"),
                ReplaceWith = 747671403u, // Wet temperate map theme
                Updated = WorkshopDate("31 Jan, 2016"),
            });

            AddMod(new Review(612120528u, "Basalt Rock Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Ennedi, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 731703219u , Status.Incompatible }, // Black Rock Mountain 2.0
                    { 574674741u , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("30 Jan, 2016"),
                ReplaceWith = 731703219u, // Black Rock Mountain 2.0
                Updated = WorkshopDate("30 Jan, 2016"),
            });

            AddMod(new Review(583748068u, "Terrain Theme 'Sand as Snow' for partially snowy maps") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1522846208u, Status.Incompatible }, // Eastern Tundra Theme
                    { 574674741u , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1522846208u, // Eastern Tundra Theme
            });

            AddMod(new Review(582425905u, "Terrain Theme: Heavy Snow for Ski, Arctic, and Glacier Maps") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 782343087u , Status.Incompatible }, // Väterchen Frost - Winter theme
                    { 574674741u , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 782343087u, // Väterchen Frost - Winter theme
            });

            AddMod(new Review(576787837u, "Celtic Moorlands Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1546100254u, Status.Incompatible }, // Celtic Coast map theme w names
                    { 574674741u , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1546100254u, // Celtic Coast map theme w names
            });

        }
    }
}