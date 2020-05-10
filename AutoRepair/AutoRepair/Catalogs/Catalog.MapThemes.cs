namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using UnityEngine;

    /// <summary>
    /// Map themes, cubemap, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void MapThemesMods() {

            string catalog = "MapThemes";

            AddMod(new Review(1899640536uL, "Theme Mixer 2") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Unknown      }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157uL , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                    { 408190203uL , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919uL , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727uL , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282uL , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080uL , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452uL , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191uL , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495uL , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371uL , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433uL , Status.Incompatible }, // No More Purple Pollution
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Languages = new[] { "en", "zh-cn", },
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] Terrain sprites affected by both mods; check sprite settings in both to ensure same effect." },
                },
                Published = WorkshopDate("27 Oct, 2019"),
                SourceURL = "https://github.com/TPBCS/ThemeMixer",
                Updated = WorkshopDate("6 Nov, 2019"),
            });
            if (Application.platform == RuntimePlatform.OSXPlayer) {
                Reviews[1899640536uL].Notes.Add(NOTE, "Mac OS/X users: Un-tick the compiling checkbox in mod options to avoid errors. See Workshop page for details.");
            }

            AddMod(new Review(895061550uL, "Theme Decals") {
                Affect = Factor.MapThemes
                       | Factor.Props,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Unknown      }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 793346248uL , Status.Recommended  }, // Decal Hover Area
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 767233815uL , Status.Required     }, // Decal Prop Fix
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Getting 'If you see this then the mod didn't work'? Make sure the mod is enabled." },
                    { NOTE, "Changes to prop or distance, theme textures or graphics detail will likely require game restart for the decals to update." },
                    { NOTE, "Asset creators, script for creating decals: https://gist.github.com/ronyx69/69130ffd46ab3573f0968aedd11c88eb" },
                    { NOTE, "Asset creators, logo for asset icon: https://drive.google.com/open?id=0B6Ccf1N5h5f7ZE9laHg3cVY0aHM" },
                },
                Published = WorkshopDate("31 Mar, 2017"),
                SourceURL = "https://gist.github.com/ronyx69/a3fff79130e59fd5b7210ed5228ab812",
                Updated = WorkshopDate("21 Aug, 2017"),
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Review(2057906517uL, "dool") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "wsd2004",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Required    }, // Theme Mixer 2
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("12 Apr, 2020"),
                Updated = WorkshopDate("12 Apr, 2020"),
            });

            AddMod(new Review(2053637074uL, "Swinden-Map Theme Mix") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "rlas",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Required    }, // Theme Mixer 2
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("9 Apr, 2020"),
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1445375997uL, "Theme Mixer 汉化版2的") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 775021554uL, // Theme Mixer (original by TPB)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157uL , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                    { 408190203uL , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919uL , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727uL , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282uL , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080uL , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452uL , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191uL , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495uL , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371uL , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433uL , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Laggy
                      | ItemFlags.Obsolete
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("6 May, 2020"),
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use 'Theme Mixer 2' instead; it includes updated Simplified Chinese translation." },
                },
                Published = WorkshopDate("19 Jul, 2018"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("19 Jul, 2018"),
            });

            AddMod(new Review(1283010953uL, "TerrainTextureReplacer Reupload") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Patrick Bateman",
                Catalog = catalog,
                CloneOf = 416966387uL, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("27 Jan, 2018"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("27 Jan, 2018"),
            });

            AddMod(new Review(920832749uL, "TerrainTextureReplacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "奴はやつはし",
                Catalog = catalog,
                CloneOf = 416966387uL, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("6 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("7 May, 2017"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("7 May, 2017"),
            });

            AddMod(new Review(877394445uL, "TerrainTextureReplacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Roenzi",
                Catalog = catalog,
                CloneOf = 416966387uL, // Terrain Texture Replacer (hyperdrive_engage original)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("5 Mar, 2017"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("5 Mar, 2017"),
            });

            // Apparently a rewrite, but still game breaking. Suspect it might just be a clone.
            AddMod(new Review(811664974uL, "TTR - Terrain Texture Replacer") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Penrose",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                ContinuationOf = 416966387uL, // Terrain Texture Replacer (hyperdrive_engage original)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("3 Dec, 2016"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("3 Dec, 2016"),
            });

            // Original "Theme Mixer" mod
            AddMod(new Review(775021554uL, "Theme Mixer [OBSOLETE (Use Theme Mixer 2)]") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 482360157uL , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                    { 408190203uL , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919uL , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727uL , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282uL , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080uL , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452uL , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191uL , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495uL , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371uL , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433uL , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("4 Oct, 2016"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                SourceURL = "https://github.com/TPBCS/ThemeMixer",
                Updated = WorkshopDate("26 Jun, 2018"),
            });

            AddMod(new Review(574674741uL, "Terrain Themes Mod [OBSOLETE]") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "boformer, TPB",
                BrokenBy = GameVersion.Patch_1_3_0_f4, // Map themes added to game
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 554680908uL , Status.Incompatible }, // Environment Colors Changer
                    { 482360157uL , Status.Incompatible }, // No More Purple [Radioactive Green Grass]
                    { 435723412uL , Status.Incompatible }, // Water Color Changer
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                    { 408190203uL , Status.Incompatible }, // No More Purple Pollution [Muddy Water]
                    { 408189919uL , Status.Incompatible }, // No More Purple Pollution [Silty Water]
                    { 408167727uL , Status.Incompatible }, // No More Purple Pollution [Radioactive Green Water]
                    { 408126282uL , Status.Incompatible }, // No More Purple Pollution [Green Water]
                    { 408126080uL , Status.Incompatible }, // No More Purple Pollution [Brown Water]
                    { 407890452uL , Status.Incompatible }, // No More Purple Pollution [Grey Grass]
                    { 407842191uL , Status.Incompatible }, // No More Purple Pollution [Red-Brown Grass]
                    { 407810495uL , Status.Incompatible }, // No More Purple Pollution [Tan Grass]
                    { 407795371uL , Status.Incompatible }, // No More Purple Pollution [Brown Grass]
                    { 407270433uL , Status.Incompatible }, // No More Purple Pollution
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead, or use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("13 Dec, 2015"),
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(416966387uL, "Terrain Texture Replacer") {
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
                    { 1899640536uL, Status.Incompatible }, // Theme Mixer 2
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的 
                    { 1283010953uL, Status.Incompatible }, // TerrainTextureReplacer Reupload
                    { 920832749uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 895061550uL , Status.Incompatible }, // Theme Decals
                    { 877394445uL , Status.Incompatible }, // TerrainTextureReplacer
                    { 811664974uL , Status.Incompatible }, // TTR - Terrain Texture Replacer
                    { 775021554uL , Status.Incompatible }, // Theme Mixer (original by TPB)
                    { 574674741uL , Status.Incompatible }, // Terrain Themes Mod
                    { 416966387uL , Status.Incompatible }, // Terrain Texture Replacer
                },
                LastSeen = WorkshopDate("19 Oct, 2018"), // guess, based on https://web.archive.org/web/20180601000000*/http://steamcommunity.com/sharedfiles/filedetails/?id=416966387
                Published = WorkshopDate("31 Mar, 2015"), // based on adjacent workshop item
                Removed = WorkshopDate("30 Apr, 2019"), // guess, based on https://web.archive.org/web/20190701000000*/http://steamcommunity.com/sharedfiles/filedetails/?id=416966387
                ReplaceWith = 1899640536uL, // Theme Mixer 2
                Suppress = Warning.MissingArchiveURL,
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

            AddMod(new Review(848163552uL, "Las Venturas theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "JOK3R!",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 768219242uL , Status.Incompatible }, // Arrowhead Valley (Official Map Theme)
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("22 Jan, 2017"),
                ReplaceWith = 768219242uL, // Arrowhead Valley (Official Map Theme)
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("22 Jan, 2017"),
            });

            AddMod(new Review(612385904uL, "Tatra Mountains Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Ennedi, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 747671403uL , Status.Incompatible }, // Wet temperate map theme
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("31 Jan, 2016"),
                ReplaceWith = 747671403uL, // Wet temperate map theme
                Updated = WorkshopDate("31 Jan, 2016"),
            });

            AddMod(new Review(612120528uL, "Basalt Rock Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "Ennedi, TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 731703219uL , Status.Incompatible }, // Black Rock Mountain 2.0
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("30 Jan, 2016"),
                ReplaceWith = 731703219uL, // Black Rock Mountain 2.0
                Updated = WorkshopDate("30 Jan, 2016"),
            });

            AddMod(new Review(583748068uL, "Terrain Theme 'Sand as Snow' for partially snowy maps") {
                Affect = Factor.Environment
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20160120021828/http://steamcommunity.com:80/id/TPBAssetStudio/myworkshopfiles?appid=255710",
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1522846208uL, Status.Incompatible }, // Eastern Tundra Theme
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either; linked profile archive
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jan, 2016"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("25 Dec, 2015"), // based on adjacent workshop item
                ReplaceWith = 1522846208uL, // Eastern Tundra Theme
                Updated = WorkshopDate("25 Dec, 2015"),
            });

            AddMod(new Review(582425905uL, "Terrain Theme: Heavy Snow for Ski, Arctic, and Glacier Maps") {
                Affect = Factor.Environment
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20160120021828/http://steamcommunity.com:80/id/TPBAssetStudio/myworkshopfiles?appid=255710",
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 782343087uL , Status.Incompatible }, // Väterchen Frost - Winter theme
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either; linked profile archive
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jan, 2016"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("24 Dec, 2015"), // based on adjacent items
                ReplaceWith = 782343087uL, // Väterchen Frost - Winter theme
                Updated = WorkshopDate("24 Dec, 2015"), // based on adjacent items
            });

            AddMod(new Review(576787837uL, "Celtic Moorlands Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                ArchiveURL = "https://web.archive.org/web/20160120021828/http://steamcommunity.com:80/id/TPBAssetStudio/myworkshopfiles?appid=255710",
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1546100254uL, Status.Incompatible }, // Celtic Coast map theme w names
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.NoWorkshop // can't find it in wbm either; linked profile archive
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jan, 2016"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("16 Dec, 2015"), // based on adjacent item
                ReplaceWith = 1546100254uL, // Celtic Coast map theme w names
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(575257702uL, "Navajo Valley Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 867022805uL , Status.Incompatible }, // Bonita Vista Valley (Official Map Theme) - Desert Map Theme
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jan, 2016"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("14 Dec, 2015"),
                ReplaceWith = 867022805uL, // Bonita Vista Valley (Official Map Theme) - Desert Map Theme
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(574953629uL, "New Caledonia Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 890126198uL , Status.Incompatible }, // New Caledonia (Concrete) v1.1
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("13 Dec, 2015"), 
                ReplaceWith = 890126198uL, // New Caledonia (Concrete) v1.1
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(574941606uL, "Ireland Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB, MrMiyagi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1546100254uL, Status.Incompatible }, // Celtic Coast map theme w names
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("13 Dec, 2015"),
                ReplaceWith = 1546100254uL, // Celtic Coast map theme w names
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(574922953uL, "Arabian Nights Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 937686778uL , Status.Incompatible }, // Abu Simbel
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("13 Dec, 2015"),
                ReplaceWith = 937686778uL, // Abu Simbel
                Updated = WorkshopDate("16 Dec, 2015"),
            });

            AddMod(new Review(574916062uL, "Snowy Terrain Theme") {
                Affect = Factor.Environment
                       | Factor.Textures,
                Authors = "TPB, MrMiyagi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 782343087uL , Status.Incompatible }, // Väterchen Frost - Winter theme
                    { 574674741uL , Status.Required     }, // Terrain Themes Mod (Obsolete)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Map themes were added to vanilla game in Snowfall update, use those instead; use 'Theme Mixer 2' if you want to customise them." },
                },
                Published = WorkshopDate("13 Dec, 2015"),
                ReplaceWith = 782343087uL, // Väterchen Frost - Winter theme
                Updated = WorkshopDate("16 Dec, 2015"),
            });
        }
    }
}