namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Skycloth (flags) replacer and its packs.
    /// 
    /// Muhhhhh skyclothhh.
    ///
    /// Skycloth demands obedience and poem recitals and strange rituals.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinFlagsCatalog() {

            string catalog = "Skin.Flags";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Item(1603398633u, "Flag Params") {
                Affect = Factor.Props,
                Authors = "Ronyx69",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorMod // also required in-game to use the created props
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                ReleasedDuring = GameVersion.Industries,
                Tags = new[] { "Flags", "Props" },
            });

            AddMod(new Item(595017353u, "More Flags ( + flags replacer )") {
                Affect = Factor.Props,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 530771650u, Status.Required    }, // Prefab Hook
                    { 837734529u, Status.Recommended }, // Find It
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-MoreFlags",
                Tags = new[] { "Flags", "Replacer", "Props" },
            });

            /*
            # ██████   █████   ██████ ██   ██ ███████
            # ██   ██ ██   ██ ██      ██  ██  ██
            # ██████  ███████ ██      █████   ███████
            # ██      ██   ██ ██      ██  ██       ██
            # ██      ██   ██  ██████ ██   ██ ███████
            */

            AddMod(new Item(1840528334u, "Ancom flag replacer") {
                Affect = Factor.Props,
                Authors = "Microsoft Word",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer", "Anarchist", "Communism", "Anarchocommunism",
                },
            });

            AddMod(new Item(1821339957u, "Rainbow Armenia Flag") {
                Affect = Factor.Props,
                Authors = "w_jkoopman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "hy-am",
                Tags = new[] {
                    "Flags", "Replacer", "Armenia", "LGBTQ",
                },
            });

            AddMod(new Item(1712774142u, "Osterland Flag"){
                Affect = Factor.Props,
                Authors = "w_jkoopman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer", "Österland", // fictional country
                },
            });

            AddMod(new Item(1652032078u, "Vooperian Flag") {
                Affect = Factor.Props,
                Authors = "bballboy2002",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer", "Vooperia", // fictional country
                },
            });

            AddMod(new Item(1611090578u, "adsii1970's flags (set A)") {
                Affect = Factor.Props,
                Authors = "adsii1970",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer", "Tropico",
                },
            });

            AddMod(new Item(1556479796u, "Polish and Lower Silesian Flags Replacer") {
                Affect = Factor.Props,
                Authors = "Grzegorz Brzęczyszczykiewicz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "pl",
                Tags = new[] {
                    "Flags", "Replacer", "Polish", "Poland", "Silesian", "Wroclaw",
                },
            });

            AddMod(new Item(1408407561u, "Arndorf Flag") {
                Affect = Factor.Props,
                Authors = "w_jkoopman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "de-at",
                Tags = new[] {
                    "Flags", "Replacer", "Austria", "Schärding", "Andorf",
                },
            });

            AddMod(new Item(1308196504u, "Greek Flag Replacer") {
                Affect = Factor.Props,
                Authors = "nieranjo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "el-gr",
                Tags = new[] {
                    "Flags", "Replacer", "Greece", "Greek",
                },
            });

            AddMod(new Item(1269317139u, "Malaysian Flags Mod") {
                Affect = Factor.Props,
                Authors = "[MY] H4F1Z",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "ms-my",
                Tags = new[] {
                    "Flags", "Replacer", "Malasian", "Kuala Lumpur", "Labuan", "Putrajaya",
                    "Johor", "Kedah", "Kelantan", "Malacca", "Negeri Sembilan", "Pahang", "Penang",
                    "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terengganu ",
                },
            });

            AddMod(new Item(1174791765u, "Cities On Flags") {
                Affect = Factor.Props,
                Authors = "SEVEN",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer",
                },
            });

            AddMod(new Item(1173729345u, "Cities On Flags") {
                Affect = Factor.Props,
                Authors = "SEVEN",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer",
                },
            });

            AddMod(new Item(1146305133u, "ELVIS korean Flags set") {
                Affect = Factor.Props,
                Authors = "ELVIS0529",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "ko",
                Tags = new[] {
                    "Flags", "Replacer", "Taegeukgi", "LG", "Samsung", "Korean",
                },
            });

            AddMod(new Item(1137426034u, "Turkey Flag-Türk Bayrağı") {
                Affect = Factor.Props,
                Authors = "Tucizz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Locale = "tr",
                Tags = new[] {
                    "Flags", "Replacer", "Turkish",
                },
            });

            AddMod(new Item(1136317580u, "Vasel flag") {
                Affect = Factor.Props,
                Authors = "Raymond Pelletier",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer",
                },
            });

            AddMod(new Item(1125168068u, "People's Front For Osahra Flag") {
                Affect = Factor.Props,
                Authors = "Blackwolf (Frdm920)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer",
                },
            });

            AddMod(new Item(940455773u, "Osahra flag replacer") {
                Affect = Factor.Props,
                Authors = "Armesto",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 595017353u, Status.Required }, // Flags Replacer
                },
                Flags = ItemFlags.SourceUnavailable,
                Tags = new[] {
                    "Flags", "Replacer",
                },
            });

        }
    }
}