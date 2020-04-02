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
        private void SkinEnvironmentCatalog() {

            string catalog = "Skin.Environment";

            AddMod(new Item(1899640536u, "Theme Mixer 2") {
                Affect = Factor.Environment,
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
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
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

            AddMod(new Item(1445375997u, "Theme Mixer 汉化版2的") {
                Affect = Factor.Environment,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 1899640536u, // Theme Mixer 2
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

            AddMod(new Item(1283010953u, "TerrainTextureReplacer Reupload") {
                Affect = Factor.Environment,
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

            AddMod(new Item(920832749u, "TerrainTextureReplacer") {
                Affect = Factor.Environment,
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

            AddMod(new Item(877394445u, "TerrainTextureReplacer") {
                Affect = Factor.Environment,
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
            AddMod(new Item(811664974u, "TTR - Terrain Texture Replacer") {
                Affect = Factor.Environment,
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
            AddMod(new Item(775021554u, "Theme Mixer [OBSOLETE (Use Theme Mixer 2)]") {
                Affect = Factor.Environment,
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
                    { 416966387u , Status.Incompatible }, // Terrain Texture Replacer
                },
                Published = WorkshopDate("4 Oct, 2016"),
                ReplaceWith = 1899640536u, // Theme Mixer 2
                Updated = WorkshopDate("26 Jun, 2018"),
            });

            AddMod(new Item(416966387u, "Terrain Texture Replacer") {
                Affect = Factor.Environment,
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
        }
    }
}