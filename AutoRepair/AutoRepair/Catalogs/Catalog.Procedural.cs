namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Procedural object creation/editing.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void ProceduralMods() {

            string catalog = "Procedural";

            AddMod(new Review(2089538184uL, "Designer Fonts for PO") {
                Affect = Factor.Props
                       | Factor.Textures,
                Authors = "potato24x7",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744uL, Status.Required }, // Procedural Objects
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("8 May, 2020"),
                Updated = WorkshopDate("8 May, 2020"),
            });

            AddMod(new Review(2086692479uL, "Scoreboard Font") {
                Affect = Factor.Props
                       | Factor.Textures,
                Authors = "potato24x7",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2086897150uL, Status.Recommended }, // Blank Led animated Sign for PO
                    { 1094334744uL, Status.Required }, // Procedural Objects
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("6 May, 2020"),
                Updated = WorkshopDate("6 May, 2020"),
            });

            AddMod(new Review(1831805509uL, "Dynamic Text Props 2.3.1") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271uL, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005uL, Status.Compatible   }, // Fine Road Anarchy 2 汉化版
                    { 1895440521uL, Status.Compatible   }, // Fine Road Tool 2 汉化版
                    { 1844442251uL, Status.Recommended  }, // Fine Road Tool 2
                    { 1844440354uL, Status.Recommended  }, // Fine Road Anarchy 2
                    { 1840448750uL, Status.Incompatible }, // FineRoadTool 汉化版
                    { 1833197583uL, Status.Recommended  }, // Station Board 6m
                    { 1833197028uL, Status.Recommended  }, // Station Board 12m
                    { 1619685021uL, Status.Recommended  }, // Move It (latest stable)
                    { 1436255148uL, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329uL, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100uL , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972uL , Status.Incompatible }, // Fine Road Tool
                    { 553184329uL , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522uL , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("11 Aug, 2019"),
                SourceURL = "https://github.com/klyte45/DynamicTextProps",
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Custom", "Editable" },
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            AddMod(new Review(1824757296uL, "Procedural Objects Fonts: Montburgh Highways Signage: Highway Shields") {
                Affect = Factor.Props
                       | Factor.Textures,
                Authors = "BobGrey",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744uL, Status.Required }, // Procedural Objects
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("4 Aug, 2019"),
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Colorado", "USA", },
                Updated = WorkshopDate("4 Aug, 2019"),
            });

            AddMod(new Review(1824749264uL, "Procedural Objects Fonts: Montburgh Highway Signage: Arrows") {
                Affect = Factor.Props
                       | Factor.Textures,
                Authors = "BobGrey",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744uL, Status.Required }, // Procedural Objects
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("4 Aug, 2019"),
                Tags = new[] { "Text", "Font", "Procedural", "Lane", "Arrows", "Signs", "Signage", "Props", "Colorado", "USA", },
                Updated = WorkshopDate("4 Aug, 2019"),
            });

            AddMod(new Review(1789133988uL, "Route Shields for PO") {
                Affect = Factor.Props
                       | Factor.Textures,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744uL, Status.Required    }, // Procedural Objects
                    { 1779419233uL, Status.Recommended }, // DOT: Attachments and Blanks
                },
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("2 Jul, 2019"),
                Tags = new[] {
                    "Text", "Font", "Procedural", "Lane", "Arrows", "Signs", "Signage", "Props", "USA",
                    "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Florida",
                    "Georgia", "Hawaii", "Idaho", "Kansas", "Louisiana", "Michigan", "Minnesota", "Missouri",
                    "Nebraska", "Nevada", "New", "South", "North", "Hampshire", "Mexico", "York", "Carolina",
                    "Dakota", "Ohio", "Oklahoma", "Pennsylvania", "Carolina", "Dakota", "Tennessee", "Utah",
                    "Vermont", "Washington", "Wisconsin", "Wyoming", "Columbia", "Turnpike", "Parkway", "Expressway",
                },
                Updated = WorkshopDate("2 Jul, 2019"),
            });

            AddMod(new Review(1094334744uL, "Procedural Objects") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props
                       | Factor.Rendering
                       | Factor.Textures,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2033714682uL, Status.Compatible   }, // Tree and Vehicle Props
                    { 1442713872uL, Status.MinorIssues  }, // Detail http://proceduralobjects.shoutwiki.com/wiki/Known_Issues
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Documentation; http://proceduralobjects.shoutwiki.com/wiki/Main_Page" },
                    { NOTE, "Fonts for Procedural Objects: https://steamcommunity.com/workshop/filedetails/?id=1897915526" },
                    { 1442713872uL, "[Mod: Detail] PO Ploppable Asphalt props might disappear when Detail mod is active: http://proceduralobjects.shoutwiki.com/wiki/Known_Issues" },
                },
                Published = WorkshopDate("29 Jul, 2017"),
                SourceURL = "https://github.com/simon56modder/ProceduralObjects",
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Buildings", "Editor", "Dynamic", },
                Updated = WorkshopDate("14 Apr, 2020"),
            });
        }
    }
}