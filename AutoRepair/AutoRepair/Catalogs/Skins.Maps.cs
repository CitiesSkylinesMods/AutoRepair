using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {
    public partial class Skins {

        private void AddModsToList() {

            string catalog = "Skins.Maps";

            AddMod(new Item(1899640536u, "Theme Mixer 2") {
                Authors = "TPB",
                Catalog = catalog,
                Flags = ItemFlags.Verified,
                IncompatibleMods = {
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1445375997u, "Theme Mixer 汉化版2的") {
                Authors = "TIMIYANG",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                Locale = "zh-cn",
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            AddMod(new Item(1283010953u, "TerrainTextureReplacer Reupload") {
                Authors = "Patrick Bateman",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            AddMod(new Item(920832749u, "TerrainTextureReplacer") {
                Authors = "奴はやつはし",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                Locale = "ja",
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            AddMod(new Item(877394445u, "TerrainTextureReplacer") {
                Authors = "Roenzi",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 920832749u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            // Apparently a rewrite, but still game breaking. Suspect it might just be a clone.
            AddMod(new Item(811664974u, "TTR - Terrain Texture Replacer") {
                Authors = "Penrose",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            // Original "Theme Mixer" mod
            AddMod(new Item(775021554u, "Theme Mixer [OBSOLETE (Use Theme Mixer 2)]") {
                Authors = "TPB",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 574674741u }, // Terrain Themes Mod
                    { 416966387u }, // Terrain Texture Replacer
                },
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });

            AddMod(new Item(416966387u, "Terrain Texture Replacer") {
                Authors = "hyperdrive_engage",
                Catalog = catalog,
                ConflictsWith = ConflictGroups.ThemeMixer,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1899640536u }, // Theme Mixer 2
                    { 1445375997u }, // Theme Mixer 汉化版2的 
                    { 1283010953u }, // TerrainTextureReplacer Reupload
                    { 920832749u }, // TerrainTextureReplacer
                    { 877394445u }, // TerrainTextureReplacer
                    { 811664974u }, // TTR - Terrain Texture Replacer
                    { 775021554u }, // Theme Mixer (original by TPB)
                    { 574674741u }, // Terrain Themes Mod
                },
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });
        }
    }
}
