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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issue - Toll Booths won't generate money while this mod is active." },
                    { NOTE, "It's marked game-breaking in workshop, but is still usable according to most users." },
                    { NOTE, "Asset creators, see: https://github.com/Unlawful-Productions/Roads_United_Texture_Template" },
                    { 1806963141uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                ReleasedDuring = GameVersion.MatchDay,
                SourceURL = "https://github.com/Unlawful-Productions/RoadsUnited_Core",
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
                    { 726005715uL , Status.Incompatible }, // Roads United: Core+
                    { 651610627uL , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                    { 530771650uL , Status.Required     }, // Prefab Hook
                    { 478820060uL , Status.Incompatible }, // Network Extensions Project (original verison)
                    { 417585852uL , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware // author comment states he will not work on this version any more
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author stated further development is unlikely. The mod sometimes causes problems with road colors." },
                    { NOTE, "Asset creators, see: https://github.com/Killface1980/RoadsUnited_Custom_Theme_Template" },
                    { 1806963141uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252uL, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                ReleasedDuring = GameVersion.Snowfall,
                SourceURL = "https://github.com/Killface1980/Roads_United---DEPRECATED",
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
                Authors = "KraIstGerecht",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
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
                ReleasedDuring = GameVersion.Snowfall,
                ReplaceWith = 763684437uL, // Roads United: North America PLUS
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
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issue: Shows an error when first activated but should be fine after that." },
                },
                Locale = "nl",
            });

            AddMod(new Review(1565201461uL, "Roads United: US Reworked 2018") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Pres",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715uL , Status.Required }, // Roads United: Core+
                    { 633547552uL , Status.Required }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 503 MB
                      | ItemFlags.MinorIssues // some textures not working, and mirroring of highway textures
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issues: Some textures not showing, and highway textures mirrored." },
                },
                RequiredModsSelection = Selection.OnlyOne,
            });

            // Made from mix of: 726004927u and 848896702u
            AddMod(new Review(935747460uL, "Roads United: US Edition - Concrete Only Highways") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "B4NK35",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715uL , Status.Required     }, // Roads United: Core+
                    { 633547552uL , Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 548 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
            });

            AddMod(new Review(848896702uL, "Roads United: US Edition - Reworked") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Pres, Unlawful Enemy Combatant",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
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
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "[Mod: Network Extensions 2] Some issues with elevated roads and tunnels." },
                },
                Published = WorkshopDate("23 Jan, 2017"),
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
                Locale = "eu",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The texture pack often needs selecting twice in RU Core before it will work." },
                },
                Published = WorkshopDate("7 Jan, 2017"),
                Updated = WorkshopDate("7 Jan, 2017"),
            });
        }
    }
}