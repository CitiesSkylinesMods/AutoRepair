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

            AddMod(new Review(726005715u, "Roads United: Core+") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "Unlawful Enemy Combatant",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE v11 STABLE
                    { 1573387594u, Status.Incompatible }, // [NL] Roads United: The Netherlands
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 680748394u , Status.Incompatible }, // [Deprecated] Roads United: North America
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 478820060u , Status.Incompatible }, // Network Extensions Project (original verison)
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware // no updates since 2018, author not posting any comments
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issue - Toll Booths won't generate money while this mod is active." },
                    { NOTE, "It's marked game-breaking in workshop, but is still usable according to most users." },
                    { NOTE, "Asset creators, see: https://github.com/Unlawful-Productions/Roads_United_Texture_Template" },
                    { 1806963141u, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252u, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                },
                ReleasedDuring = GameVersion.MatchDay,
                SourceURL = "https://github.com/Unlawful-Productions/RoadsUnited_Core",
            });

            AddMod(new Review(633547552u, "Roads United Core 2.0") {
                Affect = Factor.Props
                       | Factor.RoadMarkings
                       | Factor.Textures
                       | Factor.Trees,
                Authors = "Killface",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE v11 STABLE
                    { 1449429720u, Status.Incompatible }, // Road Color 道路颜色修改中文汉化版
                    { 1189186167u, Status.Incompatible }, // 道路颜色调整
                    { 1128766708u, Status.Incompatible }, // Remove Road Textures - Blank Roads
                    { 935747460u , Status.Incompatible }, // Roads United: US Edition - Concrete Only Highways
                    { 932192868u , Status.Incompatible }, // Road Options (Road Colors Changer ++)
                    { 726005715u , Status.Incompatible }, // Roads United: Core+
                    { 651610627u , Status.Incompatible }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u , Status.Incompatible }, // Roads United Core 2.0
                    { 530771650u , Status.Required     }, // Prefab Hook
                    { 478820060u , Status.Incompatible }, // Network Extensions Project (original verison)
                    { 417585852u , Status.Incompatible }, // Road Color Changer (original mod)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware // author comment states he will not work on this version any more
                      | ItemFlags.SlowLoad
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author stated further development is unlikely. The mod sometimes causes problems with road colors." },
                    { NOTE, "Asset creators, see: https://github.com/Killface1980/RoadsUnited_Custom_Theme_Template" },
                    { 1806963141u, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
                    { 1637663252u, "[Mod: TM:PE] Minor issues - see: https://github.com/CitiesSkylinesMods/TMPE/wiki/Roads-United-Core" },
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

            AddMod(new Review(680748394u, "[Deprecated] Roads United: North America") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "KraIstGerecht",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715u, Status.Incompatible }, // Roads United: Core+
                    { 633547552u, Status.Required     }, // Roads United Core 2.0
                    { 763684437u, Status.Incompatible }, // Roads United: North America PLUS
                },
                CompatibleWith = GameVersion.ArtDeco,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.LargeFileWarning
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Snowfall,
                ReplaceWith = 763684437u, // Roads United: North America PLUS
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Review(1573387594u, "[NL] Roads United: The Netherlands") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "lennart",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715u, Status.Incompatible }, // Roads United: Core+
                    { 633547552u, Status.Required     }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issue: Shows an error when first activated but should be fine after that." },
                },
                Locale = "nl",
            });

            AddMod(new Review(1565201461u, "Roads United: US Reworked 2018") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "Pres",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715u, Status.Required }, // Roads United: Core+
                    { 633547552u, Status.Required }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.LargeFileWarning // 503.136 MB
                      | ItemFlags.MinorIssues // some textures not working, and mirroring of highway textures
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor issues: Some textures not showing, and highway textures mirrored." },
                },
                RequiredModsSelection = Selection.OnlyOne,
            });

            // Made from mix of: 726004927u and 848896702u
            AddMod(new Review(935747460u, "Roads United: US Edition - Concrete Only Highways") {
                Affect = Factor.RoadMarkings
                       | Factor.Textures,
                Authors = "B4NK35",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 726005715u, Status.Required     }, // Roads United: Core+
                    { 633547552u, Status.Incompatible }, // Roads United Core 2.0
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 547.958 MB
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
            });
        }
    }
}