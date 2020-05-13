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

            AddMod(new Review(2057780822uL, "Automatic Bulldoze v3") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 639486063uL, // Automatic Bulldoze v2
                Flags = ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "ru", "es", "de", "fr", "pt", "zh" },
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Differences from v2: Doesn't bulldoze while paused (bugfix), doesn't check for disaster response buildings." },
                },
                Published = WorkshopDate("12 Apr, 2020"),
                Updated = WorkshopDate("12 Apr, 2020"),
            });

            AddMod(new Review(1656549865uL, "Rebuild It!") {
                Affect = Factor.Bulldoze
                       | Factor.Construction,
                Authors = "Keallu",
                Catalog = catalog,
                CatalogLinks = new[] { "Construction" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Recommended  }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("15 Feb, 2019"),
                SourceURL = "https://github.com/keallu/CSL-RebuildIt",
                Updated = WorkshopDate("13 Oct, 2019"),
            });

            AddMod(new Review(1628521230uL, "Bulldoze Everything *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Campus,
                ContinuationOf = 1507233911uL, // Automatic Bulldoze *Campus Compatible*
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("18 Jan, 2019"),
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
                Updated = WorkshopDate("18 Jan, 2019"),
            });

            AddMod(new Review(1627986403uL, "Bulldoze It!") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Recommended  }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("18 Jan, 2019"),
                SourceURL = "https://github.com/keallu/CSL-BulldozeIt",
                Updated = WorkshopDate("19 Feb, 2019"),
            });

            AddMod(new Review(1507233911uL, "Automatic Bulldoze *Campus Compatible*") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "THE CHOSEN ONE[FIN]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("9 Sep, 2018"),
                SourceURL = "https://github.com/yakka34/AutomaticBulldoze",
                Updated = WorkshopDate("15 Sep, 2018"),
            });

            AddMod(new Review(768213484uL, "Subtle Bulldozing, Dragging and More!") {
                Affect = Factor.Audio
                       | Factor.Bulldoze
                       | Factor.Rendering,
                Alternatives = new[] {
                    818641631uL, // Ambient Sounds Tuner 2.0
                },
                Authors = "TPB",
                Catalog = catalog,
                CatalogLinks = new[] { "AudioEffects", "VisualEffects" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 818641631uL , Status.Incompatible }, // Ambient Sounds Tuner 2.0
                    { 455958878uL , Status.Incompatible }, // Ambient Sounds Tuner
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("23 Sep, 2016"),
                Updated = WorkshopDate("26 Sep, 2016"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1894296637uL, "Bulldoze It! 汉化版") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "Catnip.",
                Catalog = catalog,
                CloneOf = 1627986403uL, // Bulldoze It!
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("20 Oct, 2019"),
                ReplaceWith = 1627986403uL, // Bulldoze It!
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("20 Oct, 2019"),
            });

            AddMod(new Review(1875698406uL, "406132323") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "Aliliang",
                BrokenBy = GameVersion.NaturalDisasters, // author uploaded already-broken mod to workshop lol
                Catalog = catalog,
                CloneOf = 406132323uL, // Automatic Bulldoze
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Natural Disasters DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("29 Sep, 2019"),
                ReplaceWith = 2057780822uL, // Automatic Bulldoze v3
                Suppress = Warning.InvalidVersionSequence,
                Updated = WorkshopDate("29 Sep, 2019"),
            });

            AddMod(new Review(1759514242uL, "639486063 Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "☯Quebec ツ",
                Catalog = catalog,
                CloneOf = 639486063uL, // Automatic Bulldoze v2
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("3 Jun, 2019"),
                ReplaceWith = 2057780822uL, // Automatic Bulldoze v3
                Updated = WorkshopDate("3 Jun, 2019"),
            });

            AddMod(new Review(1393966192uL, "Automatic Bulldoze Simple Edition v1.1.3") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "MaZy",
                BrokenBy = GameVersion.HolidaySuprisePatch,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Holiday Surprise Patch released Dec 13 (lol!!)
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // null reference errors for lots of users
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("25 May, 2018"),
                ReplaceWith = 1507233911uL, // Automatic Bulldoze * Campus Compatible *
                Updated = WorkshopDate("9 Jun, 2018"),
            });

            AddMod(new Review(639486063uL, "Automatic Bulldoze v2") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "mexahuk",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Industries,
                ContinuationOf = 406132323uL, // Automatic Bulldoze
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.Localised
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Languages = new[] { "en", "ru", "es", "de", "fr", "pt", "zh" },
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { ISSUE, "Campus: Users report it stopped working after Campus game update." },
                },
                Published = WorkshopDate("6 Mar, 2016"),
                ReplaceWith = 2057780822uL, // Automatic Bulldoze v3
                SourceURL = "https://github.com/YuryScherbakov/AutomaticBulldozeV2",
                Updated = WorkshopDate("10 Jun, 2017"),
            });

            AddMod(new Review(503147777uL, "Moledozer") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    1619685021uL, // Move It
                },
                Authors = "fadster",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1619685021uL, Status.Compatible }, // Move It! (current stable)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { ISSUE, "Sunset Harbor: User reports say it's breaking bulldozing of ship and aircraft routes." },
                    { TIP, "Use 'Move It!' mod instead; it has filterable marquee selection for its bulldoze tool." },
                },
                Published = WorkshopDate("20 Aug, 2015"),
                ReplaceWith = 1619685021uL, // Move It
                SourceURL = "https://github.com/fadster/Moledozer",
                Updated = WorkshopDate("20 Aug, 2015"),
            });

            AddMod(new Review(406132323uL, "Automatic Bulldoze") {
                Affect = Factor.Bulldoze,
                Alternatives = new[] {
                    2057780822uL, // Automatic Bulldoze v3
                    1628521230uL, // Bulldoze Everything *Campus Compatible*
                    1627986403uL, // Bulldoze It!
                    1507233911uL, // Automatic Bulldoze *Campus Compatible*
                },
                Authors = "Sadler",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2057780822uL, Status.Incompatible }, // Automatic Bulldoze v3
                    { 1894296637uL, Status.Incompatible }, // Bulldoze It! 汉化版
                    { 1875698406uL, Status.Incompatible }, // 406132323 (Automatic Bulldoze)
                    { 1759514242uL, Status.Incompatible }, // 639486063 Automatic Bulldoze v2
                    { 1656549865uL, Status.Incompatible }, // Rebuild It!
                    { 1628521230uL, Status.Incompatible }, // Bulldoze Everything *Campus Compatible*
                    { 1627986403uL, Status.Incompatible }, // Bulldoze It!
                    { 1507233911uL, Status.Incompatible }, // Automatic Bulldoze *Campus Compatible*
                    { 1393966192uL, Status.Incompatible }, // Automatic Bulldoze Simple Edition v1.1.3
                    { 639486063uL , Status.Incompatible }, // Automatic Bulldoze v2
                    { 406132323uL , Status.Incompatible }, // Automatic Bulldoze
                },
                CompatibleWith = GameVersion.Snowfall,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // Natural Disasters DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("11 Mar, 2015"),
                ReplaceWith = 2057780822uL, // Automatic Bulldoze v3
                Updated = WorkshopDate("22 Mar, 2015"),
            });
        }
    }
}