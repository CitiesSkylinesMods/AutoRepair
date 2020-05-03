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
        /// Helper to add flag mods; sets default values for a few properties.
        /// </summary>
        /// <param name="item">The item to add.</param>
        private void AddFlagMod(Review item) {

            item.Affect = Factor.Props;

            item.Catalog = "Skycloths";

            if (item.Compatibility == null) {
                item.Compatibility = new Dictionary<ulong, Status> {
                    { 595017353uL, Status.Required }, // Flags Replacer
                };
            }

            if (item.CompatibleWith == GameVersion.DefaultRelease && item.BrokenBy == GameVersion.DefaultUntil) {
                item.CompatibleWith = GameVersion.Active;
            }

            if (!item.HasFlag(ItemFlags.SourceAvailable | ItemFlags.SourceBundled | ItemFlags.SourceUnavailable)) {
                item.Flags |= ItemFlags.SourceUnavailable;
            }

            if (item.Tags == null) {
                item.Tags = new[] { "Flags", "Replacer" };
            }

            AddMod(item);
        }

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkyclothsMods() {

            string catalog = "Skycloths";

            /*
            # ███    ███  ██████  ██████  ███████
            # ████  ████ ██    ██ ██   ██ ██
            # ██ ████ ██ ██    ██ ██   ██ ███████
            # ██  ██  ██ ██    ██ ██   ██      ██
            # ██      ██  ██████  ██████  ███████
            */

            AddMod(new Review(1603398633uL, "Flag Params") {
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

            AddMod(new Review(595017353uL, "More Flags ( + flags replacer )") {
                Affect = Factor.Props,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 530771650uL, Status.Required    }, // Prefab Hook
                    { 837734529uL, Status.Recommended }, // Find It
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

            AddFlagMod(new Review(1840528334uL, "Ancom flag replacer") {
                Authors = "Microsoft Word",
                Tags = new[] {
                    "Flags", "Replacer", "Anarchist", "Communism", "Anarchocommunism",
                },
            });

            AddFlagMod(new Review(1821339957uL, "Rainbow Armenia Flag") {
                Authors = "w_jkoopman",
                Locale = "hy-am",
                Tags = new[] {
                    "Flags", "Replacer", "Armenia", "LGBTQ",
                },
            });

            AddFlagMod(new Review(1712774142uL, "Osterland Flag") {
                Authors = "w_jkoopman",
                Tags = new[] {
                    "Flags", "Replacer", "Österland", // fictional country
                },
            });

            AddFlagMod(new Review(1652032078uL, "Vooperian Flag") {
                Authors = "bballboy2002",
                Tags = new[] {
                    "Flags", "Replacer", "Vooperia", // fictional country
                },
            });

            AddFlagMod(new Review(1611090578uL, "adsii1970's flags (set A)") {
                Authors = "adsii1970",
                Tags = new[] {
                    "Flags", "Replacer", "Tropico",
                },
            });

            AddFlagMod(new Review(1556479796uL, "Polish and Lower Silesian Flags Replacer") {
                Authors = "Grzegorz Brzęczyszczykiewicz",
                Locale = "pl",
                Tags = new[] {
                    "Flags", "Replacer", "Polish", "Poland", "Silesian", "Wroclaw",
                },
            });

            AddFlagMod(new Review(1408407561uL, "Arndorf Flag") {
                Authors = "w_jkoopman",
                Locale = "de-at",
                Tags = new[] {
                    "Flags", "Replacer", "Austria", "Schärding", "Andorf",
                },
            });

            AddFlagMod(new Review(1308196504uL, "Greek Flag Replacer") {
                Authors = "nieranjo",
                Locale = "el-gr",
                Tags = new[] {
                    "Flags", "Replacer", "Greece", "Greek",
                },
            });

            AddFlagMod(new Review(1269317139uL, "Malaysian Flags Mod") {
                Authors = "[MY] H4F1Z",
                Locale = "ms-my",
                Tags = new[] {
                    "Flags", "Replacer", "Malasian", "Kuala Lumpur", "Labuan", "Putrajaya",
                    "Johor", "Kedah", "Kelantan", "Malacca", "Negeri Sembilan", "Pahang", "Penang",
                    "Perak", "Perlis", "Sabah", "Sarawak", "Selangor", "Terengganu ",
                },
            });

            AddFlagMod(new Review(1174791765uL, "Cities On Flags") {
                Authors = "SEVEN",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            AddFlagMod(new Review(1173729345uL, "Cities On Flags") {
                Authors = "SEVEN",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            AddFlagMod(new Review(1146305133uL, "ELVIS korean Flags set") {
                Authors = "ELVIS0529",
                Locale = "ko",
                Tags = new[] {
                    "Flags", "Replacer", "Taegeukgi", "LG", "Samsung", "Korean",
                },
            });

            AddFlagMod(new Review(1137426034uL, "Turkey Flag-Türk Bayrağı") {
                Authors = "Tucizz",
                Locale = "tr",
                Tags = new[] {
                    "Flags", "Replacer", "Turkish",
                },
            });

            AddFlagMod(new Review(1136317580uL, "Vasel flag") {
                Authors = "Raymond Pelletier",
            });

            AddFlagMod(new Review(1125168068uL, "People's Front For Osahra Flag") {
                Authors = "Blackwolf (Frdm920)",
            });

            AddFlagMod(new Review(940455773uL, "Osahra flag replacer") {
                Authors = "Armesto",
            });

            AddFlagMod(new Review(912789280uL, "F.A.L.G.S.C Flag") {
                Authors = "Winter",
                Published = WorkshopDate("25 Apr, 2017"),
                Tags = new[] {
                    "Flags", "Replacer", "Luxury", "Fully", "Automated", "Gay", "Space", "Communism",
                },
                Updated = WorkshopDate("25 Apr, 2017"),
            });

            AddFlagMod(new Review(910129741uL, "ROK(South Korea) Flag Replacer") {
                Authors = "PARAdoxiBLE",
                Published = WorkshopDate("21 Apr, 2017"),
                Updated = WorkshopDate("21 Apr, 2017"),
            });

            AddFlagMod(new Review(894085281uL, "German flag replacer mod") {
                Authors = "zar",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sometimes shows a LOD error while loading; ignore it, the flag should still work." },
                },
                Published = WorkshopDate("29 Mar, 2017"),
                Updated = WorkshopDate("29 Mar, 2017"),
            });

            AddFlagMod(new Review(861115663uL, "Canadian Flags Mod") {
                Authors = "APeeler",
                Languages = new[] {
                    "en", "en-ca", "fr", "fr-ca",
                },
                Locale = "en-ca",
                Published = WorkshopDate("10 Feb, 2017"),
                Tags = new[] {
                    "Flags", "Replacer",
                    "Newfoundland", "Labrador", "Nova", "Scotia", "Prince", "Edward", "Island", "New", "Brunswick", "Quebec", "Ontario",
                    "Manitoba", "Saskatchewan", "Alberta", "British", "Columbia", "Yukon", "Northwest", "Territories",
                    "Nunavut", "Mi'kmaq", "Acadian", "Red", "Ensign", "Royal",
                },
                Updated = WorkshopDate("10 Feb, 2017"),
            });

            AddFlagMod(new Review(857488326uL, "Cagliostro Flag Replaser") {
                Authors = "CityOfTokyo",
                Published = WorkshopDate("5 Feb, 2017"),
                Updated = WorkshopDate("5 Feb, 2017"),
            });

            AddFlagMod(new Review(817019068uL, "Danish flag replacer") {
                Authors = "Jens Møller",
                Flags = ItemFlags.SourceAvailable,
                Locale = "da",
                Published = WorkshopDate("12 Dec, 2016"),
                SourceURL = "https://github.com/jensz12/Cities-Danish-Flag",
                Tags = new[] {
                    "Flags", "Replacer", "Denmark", "Danis", "European", "Nordic", "Dansk",
                },
                Updated = WorkshopDate("12 Dec, 2016"),
            });
        }
    }
}