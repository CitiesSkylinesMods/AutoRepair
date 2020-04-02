namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that automatically bulldoze destroyed/abandoned buildings.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void BulldozeCatalog() {

            string catalog = "Bulldoze";

            AddMod(new Item(1656549865u, "Rebuild It!") {
                Affect = Factor.Bulldoze, // well, not really, but only affect that seems remotely relevant
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Recommended  }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-RebuildIt",
            });

            AddMod(new Item(1628521230u, "Bulldoze Everything *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                ContinuationOf = 1507233911u, // Automatic Bulldoze *Campus Compatible*
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
            });

            AddMod(new Item(1627986403u, "Bulldoze It!") {
                Affect = Factor.Bulldoze,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Recommended  }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-BulldozeIt",
            });

            AddMod(new Item(1507233911u, "Automatic Bulldoze *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1894296637u, "Bulldoze It! 汉化版") {
                Affect = Factor.Bulldoze,
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1627986403u, // Bulldoze It!
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Locale = "zh-cn",
                ReplaceWith = 1627986403u, // Bulldoze It!
            });

            AddMod(new Item(1875698406u, "406132323") {
                Affect = Factor.Bulldoze,
                Authors = "Aliliang",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                CloneOf = 406132323u, // Automatic Bulldoze
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Natural Disasters DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
                ReplaceWith = 639486063u, // Automatic Bulldoze v2
                SuppressVersionWarnings = true, // author uploaded already-broken mod to workshop lol
            });

            AddMod(new Item(1759514242u, "639486063 Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Authors = "☯Quebec ツ",
                Catalog = catalog,
                CloneOf = 639486063u, // Automatic Bulldoze v2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 639486063u, // Automatic Bulldoze v2
            });

            AddMod(new Item(1393966192u, "Automatic Bulldoze Simple Edition v1.1.3") {
                Affect = Factor.Bulldoze,
                Authors = "MaZy",
                BrokenBy = new System.Version(1, 11, 1), // Holiday Surprise Patch (lol!!)
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Holiday Surprise Patch released Dec 13 (lol!!)
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable, // null reference errors for lots of users
                ReleasedDuring = GameVersion.ParkLife,
                ReplaceWith = 1507233911u, // Automatic Bulldoze * Campus Compatible *
            });

            AddMod(new Item(639486063u, "Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Authors = "mexahuk",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Industries,
                ContinuationOf = 406132323u, // Automatic Bulldoze
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "en", "ru", "es", "de", "fr", "pt", "zh" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Seems to have stopped working for many users since Campus update" },
                },
                ReleasedDuring = GameVersion.Snowfall,
                ReplaceWith = 1507233911u, // Automatic Bulldoze * Campus Compatible *
                SourceURL = "https://github.com/YuryScherbakov/AutomaticBulldozeV2",
            });

            AddMod(new Item(406132323u, "Automatic Bulldoze") {
                Affect = Factor.Bulldoze,
                Authors = "Sadler",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Natural Disasters DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 639486063u, // Automatic Bulldoze v2
            });
        }
    }
}
