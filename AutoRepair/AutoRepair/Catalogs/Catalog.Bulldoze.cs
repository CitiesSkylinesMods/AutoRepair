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
        private void BulldozeMods() {

            string catalog = "Bulldoze";

            AddMod(new Review(2057780822u, "Automatic Bulldoze v3") {
                Affect = Factor.Bulldoze,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 639486063u, // Automatic Bulldoze v2
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "ru", "es", "de", "fr", "pt", "zh" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Differences from v2: Doesn't bulldoze while paused (good!), doesn't check for disaster response buildings." },
                },
                Published = WorkshopDate("12 Apr, 2020"),
                Updated = WorkshopDate("12 Apr, 2020"),
            });

            AddMod(new Review(1656549865u, "Rebuild It!") {
                Affect = Factor.Bulldoze, // well, not really, but only affect that seems remotely relevant
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Incompatible }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Recommended  }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Feb, 2019"),
                SourceURL = "https://github.com/keallu/CSL-RebuildIt",
                Updated = WorkshopDate("13 Oct, 2019"),
            });

            AddMod(new Review(1628521230u, "Bulldoze Everything *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                CompatibleWith = GameVersion.Campus,
                ContinuationOf = 1507233911u, // Automatic Bulldoze *Campus Compatible*
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("18 Jan, 2019"),
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
                Updated = WorkshopDate("18 Jan, 2019"),
            });

            AddMod(new Review(1627986403u, "Bulldoze It!") {
                Affect = Factor.Bulldoze,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637u, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406u, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242u, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865u, Status.Recommended  }, // Rebuild It!
                    { 1628521230u, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403u, Status.Incompatible }, // Bulldoze It!
                    { 1507233911u, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393966192u, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063u , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323u , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("18 Jan, 2019"),
                SourceURL = "https://github.com/keallu/CSL-BulldozeIt",
                Updated = WorkshopDate("19 Feb, 2019"),
            });

            AddMod(new Review(1507233911u, "Automatic Bulldoze *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("9 Sep, 2018"),
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
                Updated = WorkshopDate("15 Sep, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1894296637u, "Bulldoze It! 汉化版") {
                Affect = Factor.Bulldoze,
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1627986403u, // Bulldoze It!
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("20 Oct, 2019"),
                ReplaceWith = 1627986403u, // Bulldoze It!
                Updated = WorkshopDate("20 Oct, 2019"),
            });

            AddMod(new Review(1875698406u, "406132323") {
                Affect = Factor.Bulldoze,
                Authors = "Aliliang",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                CloneOf = 406132323u, // Automatic Bulldoze
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("29 Sep, 2019"),
                ReplaceWith = 2057780822u, // Automatic Bulldoze v3
                SuppressVersionWarnings = true, // author uploaded already-broken mod to workshop lol
                Updated = WorkshopDate("29 Sep, 2019"),
            });

            AddMod(new Review(1759514242u, "639486063 Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Authors = "☯Quebec ツ",
                Catalog = catalog,
                CloneOf = 639486063u, // Automatic Bulldoze v2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("3 Jun, 2019"),
                ReplaceWith = 2057780822u, // Automatic Bulldoze v3
                Updated = WorkshopDate("3 Jun, 2019"),
            });

            AddMod(new Review(1393966192u, "Automatic Bulldoze Simple Edition v1.1.3") {
                Affect = Factor.Bulldoze,
                Authors = "MaZy",
                BrokenBy = new System.Version(1, 11, 1), // Holiday Surprise Patch (lol!!)
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("25 May, 2018"),
                ReplaceWith = 1507233911u, // Automatic Bulldoze * Campus Compatible *
                Updated = WorkshopDate("9 Jun, 2018"),
            });

            AddMod(new Review(639486063u, "Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Authors = "mexahuk",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("6 Mar, 2016"),
                ReplaceWith = 2057780822u, // Automatic Bulldoze v3
                SourceURL = "https://github.com/YuryScherbakov/AutomaticBulldozeV2",
                Updated = WorkshopDate("10 Jun, 2017"),
            });

            AddMod(new Review(503147777u, "Moledozer") {
                Affect = Factor.Bulldoze,
                Authors = "fadster",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1619685021u, Status.Compatible }, // Move It! (current stable)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: User reports say it's breaking bulldozing of ship and aircraft routes." },
                    { NOTE, "Try 'Move It!' mod which has filterable marquee selection for its bulldoze tool." },
                },
                Published = WorkshopDate("20 Aug, 2015"),
                ReplaceWith = 1619685021u, // Move It
                SourceURL = "https://github.com/fadster/Moledozer",
                Updated = WorkshopDate("20 Aug, 2015"),
            });

            AddMod(new Review(406132323u, "Automatic Bulldoze") {
                Affect = Factor.Bulldoze,
                Authors = "Sadler",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822u, Status.Incompatible }, // Automatic Bulldoze v3
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
                Published = WorkshopDate("11 Mar, 2015"),
                ReplaceWith = 2057780822u, // Automatic Bulldoze v3
                Updated = WorkshopDate("22 Mar, 2015"),
            });
        }
    }
}
