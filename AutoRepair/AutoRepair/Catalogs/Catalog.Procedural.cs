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
        private void ProceduralCatalog() {

            string catalog = "Procedural";

            AddMod(new Item(1831805509, "Dynamic Text Props 2.3.1") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                Authors = "Klyte45",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2043038271u, Status.Incompatible }, // Fine Road Anarchy
                    { 1895443005u, Status.Compatible   }, // Fine Road Anarchy 2 汉化版
                    { 1895440521u, Status.Compatible   }, // Fine Road Tool 2 汉化版
                    { 1844442251u, Status.Recommended  }, // Fine Road Tool 2
                    { 1844440354u, Status.Recommended  }, // Fine Road Anarchy 2
                    { 1840448750u, Status.Incompatible }, // FineRoadTool 汉化版
                    { 1833197583u, Status.Recommended  }, // Station Board 6m
                    { 1833197028u, Status.Recommended  }, // Station Board 12m
                    { 1619685021u, Status.Recommended  }, // Move It (latest stable)
                    { 1436255148u, Status.Incompatible }, // Fine Road Anarchy 汉化版1.3.5
                    { 1362508329u, Status.Incompatible }, // TC01 - FineRoadAnarchy! (2018)
                    { 802066100u , Status.Incompatible }, // Fine Road Anarchy
                    { 651322972u , Status.Incompatible }, // Fine Road Tool
                    { 553184329u , Status.Incompatible }, // Sharp Junction Angles
                    { 418556522u , Status.Incompatible }, // Road Anarchy
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/klyte45/DynamicTextProps",
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Custom", "Editable" },
            });

            AddMod(new Item(1824757296u, "Procedural Objects Fonts: Montburgh Highways Signage: Highway Shields") {
                Affect = Factor.Props,
                Authors = "BobGrey",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744u, Status.Required }, // Procedural Objects
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Colorado", "USA", },
            });

            AddMod(new Item(1824749264u, "Procedural Objects Fonts: Montburgh Highway Signage: Arrows") {
                Affect = Factor.Props,
                Authors = "BobGrey",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744u, Status.Required }, // Procedural Objects
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] { "Text", "Font", "Procedural", "Lane", "Arrows", "Signs", "Signage", "Props", "Colorado", "USA", },
            });

            AddMod(new Item(1789133988u, "Route Shields for PO") {
                Affect = Factor.Props,
                Authors = "Elektrix",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1094334744u, Status.Required    }, // Procedural Objects
                    { 1779419233u, Status.Recommended }, // DOT: Attachments and Blanks
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Text", "Font", "Procedural", "Lane", "Arrows", "Signs", "Signage", "Props", "USA",
                    "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Florida",
                    "Georgia", "Hawaii", "Idaho", "Kansas", "Louisiana", "Michigan", "Minnesota", "Missouri",
                    "Nebraska", "Nevada", "New", "South", "North", "Hampshire", "Mexico", "York", "Carolina",
                    "Dakota", "Ohio", "Oklahoma", "Pennsylvania", "Carolina", "Dakota", "Tennessee", "Utah",
                    "Vermont", "Washington", "Wisconsin", "Wyoming", "Columbia", "Turnpike", "Parkway", "Expressway",
                },
            });

            AddMod(new Item(1094334744u, "Procedural Objects") {
                Affect = Factor.PlaceAndMove
                       | Factor.Props,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2033714682u, Status.Compatible   }, // Tree and Vehicle Props
                    { 1442713872u, Status.MinorIssues  }, // Detail http://proceduralobjects.shoutwiki.com/wiki/Known_Issues
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Documentation; http://proceduralobjects.shoutwiki.com/wiki/Main_Page" },
                    { NOTE, "Fonts for Procedural Objects: https://steamcommunity.com/workshop/filedetails/?id=1897915526" },
                    { 1442713872u, "[Mod: Detail] PO Ploppable Asphalt props might disappear when Detail mod is active: http://proceduralobjects.shoutwiki.com/wiki/Known_Issues" },
                },
                ReleasedDuring = GameVersion.MassTransit,
                SourceURL = "https://github.com/simon56modder/ProceduralObjects",
                Tags = new[] { "Text", "Font", "Procedural", "Signs", "Signage", "Props", "Buildings", "Editor", "Dynamic", },
            });
        }
    }
}