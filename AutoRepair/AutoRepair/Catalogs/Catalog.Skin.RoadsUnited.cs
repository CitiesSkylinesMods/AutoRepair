namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Roads United mods and skins.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add items to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinRoadsUnitedMods() {

            string catalog = "Skin.RoadsUnited";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Review(726005715uL, "Roads United: Core+") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "Unlawful Enemy Combatant",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE v11 STABLE
                    { 1573387594uL, Status.Incompatible }, // [NL] Roads United: The Netherlands
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 680748394uL , Status.Incompatible }, // [Deprecated] Roads United: North America
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project (original verison)
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware // no updates since 2018, author not posting any comments
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { ISSUE       , "Toll Booths won't generate money while this mod is active." },
                    { NOTE        , "It's marked game-breaking in workshop, but is still usable according to most users." },
                    { TIP         , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                    { CREATORS    , "Road skin template: https://github.com/Unlawful-Productions/Roads_United_Texture_Template" },
                    { 1806963141uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                Published = WorkshopDate("17 Jul, 2016"),
                SourceURL = "https://github.com/Unlawful-Productions/RoadsUnited_Core",
                Updated = WorkshopDate("2 Jan, 2018"),
            });

            AddMod(new Review(633547552uL, "Roads United Core 2.0") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "Killface",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE v11 STABLE
                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整
                    { 1128766708uL, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 935747460uL , Status.Incompatible }, // Roads United: US Edition - Concrete Only Highways
                    { 932192868uL , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 848896702uL , Status.Incompatible }, // Roads United: US Edition - Reworked
                    { 837112310uL , Status.Incompatible }, // Roads United: Europe
                    { 763684437uL , Status.Incompatible }, // Roads United: North America PLUS
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 726004927uL , Status.Incompatible }, // Roads United: US Edition
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 530771650uL , Status.Required     }, // Prefab Hook
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project (original verison)
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware // author comment states he will not work on this version any more
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable
                      | ItemFlags.SourceOudated,
                LastSeen = WorkshopDate("11 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE        , "Author stated further development is unlikely. The mod sometimes causes problems with road colors." },
                    { TIP         , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                    { CREATORS    , "Road skin template: https://github.com/Killface1980/RoadsUnited_Custom_Theme_Template" },
                    { 1806963141uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                Published = WorkshopDate("27 Feb, 2016"),
                SourceURL = "https://github.com/Killface1980/Roads_United---DEPRECATED",
                Suppress = Warning.QueryAbandonware,
                Updated = WorkshopDate("12 Jan, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(680748394uL, "[Deprecated] Roads United: North America") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "KraIstGerecht",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 763684437uL , Status.Incompatible }, // Roads United: North America PLUS
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 633547552uL , Status.Required     }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.ArtDeco,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { TIP, "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("8 May, 2016"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                Updated = WorkshopDate("8 May, 2016"),
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Review(1573387594uL, "[NL] Roads United: The Netherlands") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "lennart",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 633547552uL , Status.Required     }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issue: Shows an error when first activated but should be fine after that." },
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("24 Nov, 2018"),
                Updated = WorkshopDate("7 Jul, 2019"),
            });

            AddMod(new Review(1565201461uL, "Roads United: US Reworked 2018") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "Pres",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 726005715uL , Status.Required }, // Roads United: Core+
                    { 633547552uL , Status.Required }, // Roads United Core 2.0

                    { 1449429720uL, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167uL, Status.Incompatible }, // 道路颜色调整 (Road Color Changer)
                    { 932192868uL , Status.MinorIssues  }, // Road Options (Road Colors Changer ++)
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 543722850uL , Status.Incompatible }, // Network Skins (Park Life compatible)
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 503 MB
                      | ItemFlags.MinorIssues // some textures not working, and mirroring of highway textures
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issues: Some textures not showing, and highway textures mirrored." },
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                    { 932192868uL , "[Mod: Road Color Changer] The 'Road Color Changer' mod breaks the skins of these roads." },
                },
                Published = WorkshopDate("15 Nov, 2018"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                RequiredModsSelection = Selection.OnlyOne,
                Updated = WorkshopDate("15 Nov, 2018"),
            });

            // Made from mix of: 726004927u and 848896702u
            AddMod(new Review(935747460uL, "Roads United: US Edition - Concrete Only Highways") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "B4NK35",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 548 MB
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("29 May, 2017"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                Updated = WorkshopDate("29 May, 2017"),
            });

            AddMod(new Review(848896702uL, "Roads United: US Edition - Reworked") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "Pres, Unlawful Enemy Combatant",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 726004927uL , Status.Incompatible }, // Roads United: US Edition
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 726004927uL, // Roads United: US Edition
                Flags = ItemFlags.Abandonware // description states it will not be updated
                      | ItemFlags.LargeFileWarning // 367 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Mod: Network Extensions 2] Some issues with elevated roads and tunnels." },
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("23 Jan, 2017"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                Updated = WorkshopDate("2 May, 2017"),
            });

            AddMod(new Review(837112310uL, "Roads United: Europe") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Meow",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware // description states it will not be updated
                      | ItemFlags.LargeFileWarning // 445 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "eu",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The texture pack often needs selecting twice in RU Core before it will work." },
                    { NOTE, "Author states this road skin pack will not be updated." },
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("7 Jan, 2017"),
                Updated = WorkshopDate("7 Jan, 2017"),
            });

            AddMod(new Review(763684437uL, "Roads United: North America PLUS") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "KraIstGerecht",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 680748394uL , Status.Incompatible }, // [Deprecated] Roads United: North America
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware // replaced by normal road assets
                      | ItemFlags.LargeFileWarning // 445 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This skin pack will not be continued; the author recommends using N.A.R.L. roads pack (see replacement link)."},
                },
                Published = WorkshopDate("14 Sep, 2016"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                Updated = WorkshopDate("17 Dec, 2016"),
            });

            AddMod(new Review(726004927uL, "Roads United: US Edition") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Alternatives = new[] {
                    1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                    1565201461uL, // Roads United: US Reworked 2018
                    935747460uL , // Roads United: US Edition - Concrete Only Highways
                    848896702uL , // Roads United: US Edition - Reworked
                    763684437uL , // Roads United: North America PLUS
                    726004927uL , // Roads United: US Edition
                },
                Authors = "Unlawful Enemy Combatant",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1967320745uL, Status.Incompatible }, // N.A.R.L. = North American Roads Liberated (road assets)
                    { 848896702uL , Status.Incompatible }, // Roads United: US Edition - Reworked
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 515 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { TIP , "Consider using normal road assets instead; 'Loading Screen Mod' can often reduce their RAM usage." },
                },
                Published = WorkshopDate("17 Jul, 2016"),
                ReplaceWith = 1967320745uL, // N.A.R.L. = North American Roads Liberated (road assets)
                Updated = WorkshopDate("2 Jan, 2018"),
            });
        }
    }
}