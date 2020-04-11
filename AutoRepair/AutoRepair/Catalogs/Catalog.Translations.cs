namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /* Language clone mods
    AddClone(1994431441u, "PostProcessFX", 412146081u);
    AddClone(1985556066u, "4546", 426460372u); // "Favorite Cims" mod
    AddClone(1918293613u, "Building Themes 建筑主题编辑器 Sakuya16汉化版", 466158459u, "zh-cn");
    AddClone(1917517350u, "右下角现实时间显示 Hour Clock 20160223", 407100916u);
    AddClone(1915645482u, "654707599 Citizen Lifecycle Rebalance v2", 654707599u);
    AddClone(1915645035u, "1186900508 DistrictRCI-continued", 1186900508u);
    AddClone(1912626605u, "Configure Outside Connections Limits", 734025380u);
    AddClone(1912610854u, "505480567 More Beautification", 505480567u);
    AddClone(1911736890u, "1181352643 District Service Limit 3", 1181352643u);
    //AddClone(1909943267u, "2、解锁25格地图"); // need to find original item
    AddClone(1908242850u, "812125426 Network Extensions 2", 812125426u);
    AddClone(1908238573u, "406723376 Tree Brush", 406723376u);
    AddGameBreakingClone(1908236993u, "1186900508 DistrictRCI-continued", 1186900508u);
    AddClone(1900802168u, "Maintenance Fees汉化", 602336261u, "zh-cn");
    AddClone(1898441366u, "Find It!-汉化版", 837734529u, "zh-cn");
    AddClone(1898084870u, "Watch It!-汉化版", 1643902284u, "zh-cn");
    AddClone(1897310477u, "Monitor It!-汉化版", 1804882663u, "zh-cn");
    AddClone(1896212212u, "Smart Intersection Builder 汉化修改版", 1677913611u, "zh-cn");
    AddClone(1895912123u, "Roundabout Builder 汉化版", 1625704117u, "zh-cn");
    AddGameBreakingClone(1894425170u, "Loading Screen Mod 汉化版", 667342976u, "zh-cn");
    AddClone(1894299113u, "Resize It! 汉化版", 1577882296u, "zh-cn");
    AddClone(1894297972u, "Hide It! 汉化版", 1591417160u, "zh-cn");
    AddClone(1893235480u, "[PLT]Prop Line Tool汉化版", 694512541u, "zh-cn");
    AddClone(1893049735u, "Customize It Extended 汉化版", 1806759255u, "zh-cn");
    AddClone(1892205219u, "FPSCamera 汉化版", 650805785u, "zh-cn");
    AddClone(1883386307u, "Procedural Objects 魔物模组(PO) Sakuya16汉化版", 1094334744u, "zh-cn");
    AddClone(1881187805u, "Sun Shafts 阳光射线 Sakuya16个人汉化版", 933513277u, "zh-cn");
    AddClone(1880045672u, "Relight 色彩调整 Sakuya16个人汉化版", 1209581656u, "zh-cn");
    AddClone(1870740367u, "Dynamic Resolution 动态分辨率 Sakuya16个人汉化版", 812713438u, "zh-cn");
    AddClone(1870670690u, "Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版", 672248733u, "zh-cn");
    AddClone(1869777403u, "TimeWarp Fix 时间光照控制 Sakuya16个人汉化", 814698320u, "zh-cn");
    AddClone(1869743962u, "Clouds & Fog Toggler 去云雾开关 Sakuya16个人汉化版", 523824395u, "zh-cn");
    AddClone(1866904568u, "Ploppable RICO 自由放置建筑 Sakuya16个人汉化版", 586012417u, "zh-cn");
    AddClone(1860379049u, "加载优化 Loading Screen", 667342976u, "zh-cn");
    AddClone(1859589059u, "Roundabout Builder 汉化版", 1625704117u, "zh-cn");
    AddClone(1841047653u, "Network Extensions 2 汉化版", 812125426u, "zh-cn");
    AddGameBreakingClone(1840448750u, "FineRoadTool 汉化版", 651322972u, "zh-cn");
    AddClone(1751128171u, "种树画笔", 406723376u, "zh-cn"); // Tree Brush
    AddClone(1735828984u, "639486063_Automatic_Bulldoze_v2", 639486063u, "ja");

    // todo: game breaking, auto bulldoze, need to set different 
    AddClone(1402634444u, "406132323", 406132323u);
    */

    /// <summary>
    /// Game language translations.
    ///
    /// Note: Mods translated in to other languages should go in to more specific catalogs.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// List of all the ali mods.
        ///
        /// Note: Also incorporated in to Font Selector mod.
        /// </summary>
        internal Dictionary<ulong, Status> aliMods = new Dictionary<ulong, Status>() {
            { 412149127u , Status.Incompatible }, // Font Selector
            // ali mods:
            { 1988319487u, Status.Incompatible },
            { 1943193013u, Status.Incompatible },
            { 1939503380u, Status.Incompatible },
            { 1879010148u, Status.Incompatible },
            { 1842948393u, Status.Incompatible },
            { 1842940377u, Status.Incompatible },
            { 1700403881u, Status.Incompatible },
            { 1684556269u, Status.Incompatible },
            { 1680979061u, Status.Incompatible },
            { 1625610864u, Status.Incompatible },
            { 1548868991u, Status.Incompatible },
            { 1546750969u, Status.Incompatible },
            { 1546742761u, Status.Incompatible },
            { 1408154706u, Status.Incompatible },
            { 1396970654u, Status.Incompatible },
            { 1394163871u, Status.Incompatible },
            { 1357099637u, Status.Incompatible },
            { 1357086606u, Status.Incompatible },
            { 1334668143u, Status.Incompatible },
            { 1334667876u, Status.Incompatible },
            { 1322239426u, Status.Incompatible },
            { 1290370842u, Status.Incompatible },
            { 1218794439u, Status.Incompatible },
            { 1216481923u, Status.Incompatible },
            { 966361998u , Status.Incompatible },
            { 965590422u , Status.Incompatible },
            { 964727801u , Status.Incompatible },
            { 949461510u , Status.Incompatible },
            { 940398690u , Status.Incompatible },
            { 929222270u , Status.Incompatible },
            { 929211897u , Status.Incompatible },
            { 928628465u , Status.Incompatible },
            { 928477022u , Status.Incompatible },
            { 926909781u , Status.Incompatible },
        };

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void TranslationMods() {

            string catalog = "Translations";

            ulong latestAliMod = 1988319487u; // ali213_mod_01

            AddMod(new Review(1231957400u, "Custom Namelists") {
                Affect = Factor.Other, // todo
                Authors = "Markus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356u, Status.Incompatible }, // Twitch Citizens
                    { 1322787091u, Status.Unknown      }, // Addresses & Names Mod 2.0.1
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 950011274u , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 937334007u , Status.Incompatible }, // Japanese Localization RD
                    { 935356978u , Status.Incompatible }, // CSL Names Pack Example [1.0.0]
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                    { 933961247u , Status.Unknown      }, // Russian text fix
                },
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("15 Dec, 2017"),
                SourceURL = "https://github.com/markusmitbrille/cities-skylines-custom-namelists",
                Updated = WorkshopDate("20 Dec, 2017"),
            });

            AddMod(new Review(935356978u, "CSL Names Pack Example [1.0.0]") {
                Affect = Factor.Other, // todo
                Authors = "TGC",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // use Custom Name Lists mod instead
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 935350530u , Status.Required     }, // CSL Custom Names [1.0.0]
                    { 933961247u , Status.Unknown      }, // Russian text fix
                },
                Published = WorkshopDate("29 May, 2017"),
                ReplaceWith = 1231957400u, // Custom Namelists
                Updated = WorkshopDate("29 May, 2017"),
            });

            AddMod(new Review(935350530u, "CSL Custom Names [1.0.0]") {
                Affect = Factor.Other, // todo
                Authors = "TGC",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356u, Status.Incompatible }, // Twitch Citizens
                    { 1322787091u, Status.Unknown      }, // Addresses & Names Mod 2.0.1
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 937334007u , Status.Incompatible }, // Japanese Localization RD
                    { 935356978u , Status.Compatible   }, // CSL Names Pack Example [1.0.0]
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                    { 933961247u , Status.Unknown      }, // Russian text fix
                },
                Published = WorkshopDate("29 May, 2017"),
                ReplaceWith = 1231957400u, // Custom Namelists
                Updated = WorkshopDate("29 May, 2017"),
            });

            // changes existing russian translation text, replacing some words with shorter ones
            AddMod(new Review(933961247u, "Russian text fix") {
                Affect = Factor.Other,
                Authors = "TGC",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1753697086u, Status.Unknown      }, // Russian Localization Fix - Исправление русской локализации
                    { 1752699330u, Status.Unknown      }, // Альтернативный русский NamesLists
                    { 1231957400u, Status.Unknown      }, // Custom Namelists
                    { 935356978u , Status.Unknown      }, // CSL Names Pack Example [1.0.0]
                    { 935350530u , Status.Unknown      }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("27 May, 2017"),
                Updated = WorkshopDate("27 May, 2017"),
            });

            /*
            # ███    ██  █████  ███    ███ ███████ ██      ██ ███████ ████████ ███████
            # ████   ██ ██   ██ ████  ████ ██      ██      ██ ██         ██    ██
            # ██ ██  ██ ███████ ██ ████ ██ █████   ██      ██ ███████    ██    ███████
            # ██  ██ ██ ██   ██ ██  ██  ██ ██      ██      ██      ██    ██         ██
            # ██   ████ ██   ██ ██      ██ ███████ ███████ ██ ███████    ██    ███████
            */

            AddMod(new Review(2055299197u, "上海路名") {
                Affect = Factor.Other, // todo
                Authors = "BobLiu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMod(new Review(1753697086u, "Russian Localization Fix - Исправление русской локализации") {
                Affect = Factor.Other, // todo
                Authors = "White_Drake (UA)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1752699330u, Status.Incompatible }, // Альтернативный русский NamesLists
                    { 1231957400u, Status.Required     }, // Custom Namelists
                    { 933961247u , Status.Unknown      }, // Russian text fix
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 1752699330u, // Альтернативный русский NamesLists
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "ru",
                Published = WorkshopDate("27 May, 2019"),
                Updated = WorkshopDate("27 May, 2019"),
            });

            AddMod(new Review(1752699330u, "Альтернативный русский NamesLists") {
                Affect = Factor.Other, // todo
                Authors = "White_Drake (UA)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1753697086u, Status.Incompatible }, // Russian Localization Fix - Исправление русской локализации
                    { 1231957400u, Status.Required     }, // Custom Namelists
                    { 933961247u , Status.Unknown      }, // Russian text fix
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "ru",
                Published = WorkshopDate("26 May, 2019"),
                ReplaceWith = 1753697086u, // Russian Localization Fix - Исправление русской локализации
                Updated = WorkshopDate("26 May, 2019"),
            });

            AddMod(new Review(1652793447u, "Germanize: Road & District Names") {
                Affect = Factor.Other, // todo
                Authors = "Fabdiwabdi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "de",
                Published = WorkshopDate("11 Feb, 2019"),
                Updated = WorkshopDate("11 Feb, 2019"),
            });

            AddMod(new Review(1644667012u, "Germanize: Cim Names") {
                Affect = Factor.Other, // todo
                Authors = "Fabdiwabdi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "de",
                Published = WorkshopDate("4 Feb, 2019"),
                Updated = WorkshopDate("6 Feb, 2019"),
            });

            AddMod(new Review(1327691796u, "Bayreuther Straßen- und Stadtteilliste") {
                Affect = Factor.Other, // todo
                Authors = "Viss Valdyr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "de",
                Published = WorkshopDate("11 Mar, 2018"),
                Updated = WorkshopDate("11 Mar, 2018"),
            });

            AddMod(new Review(1301101044u, "CNL Japanese Blank Road Name") {
                Affect = Factor.Other, // todo
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                    { 950011274u , Status.Incompatible }, // Japanese Romaji Names [BETA]
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "ja",
                Published = WorkshopDate("14 Feb, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1299863509u, "CNL Japanese Localization Name Lists") {
                Affect = Factor.Other, // todo
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                    { 950011274u , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 937334007u , Status.Incompatible }, // Japanese Localization RD
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 937334007u, // Japanese Localization RD
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "ja",
                Published = WorkshopDate("12 Feb, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1298626701u, "CNL Blank Road Name MOD") {
                Affect = Factor.Other, // todo
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "*",  // language agnostic
                Published = WorkshopDate("11 Feb, 2018"),
                Updated = WorkshopDate("11 Feb, 2018"),
            });

            AddMod(new Review(1261047747u, "Wiener Strassennamen/Viennese street names") {
                Affect = Factor.Other, // todo
                Authors = "x||x",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "de-at",
                Published = WorkshopDate("7 Jan, 2018"),
                Updated = WorkshopDate("7 Jan, 2018"),
            });

            AddMod(new Review(1249641304u, "Custom Names Lists") {
                Affect = Factor.Other, // todo
                Authors = "Ilion",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is just template for authors; see workshop page for details." },
                },
                Published = WorkshopDate("30 Dec, 2017"),
                Updated = WorkshopDate("12 Apr, 2018"),
            });

            AddMod(new Review(1231958156u, "Vienna Namelist") {
                Affect = Factor.Other, // todo
                Authors = "Markus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                Locale = "de-at",
                Published = WorkshopDate("15 Dec, 2017"),
                Updated = WorkshopDate("15 Dec, 2017"),
            });

            // covers multiple regions: Iran Uzbekistan Turkmenistan Afghanistan Pashtun Pakhtun Pashto
            // Pakhto Kurd Kurdistan O'zbekiston Baluch Balochistan Baluchistan Tajikistan Iranian
            AddMod(new Review(1255835366u, "Central Asian Names") {
                Affect = Factor.Other, // todo
                Authors = "alborzka",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                //Languages = new[] { }, // todo
                Languages = new[] { "ku", "uz", "fa", "fa-af", "ps", },
                Locale = "*",
                Published = WorkshopDate("3 Jan, 2018"),
                Tags = new[] {
                    "Iran", "Uzbekistan", "Turkmenistan", "Afghanistan", "Pashtun", "Pakhtun", "Pashto", "Pakhto",
                    "Kurd", "Kurdistan", "O'zbekiston", "Baluch", "Balochistan", "Baluchistan", "Tajikistan", "Iranian",
                },
                Updated = WorkshopDate("3 Jan, 2018"),
            });

            // probably obsolete - custom name lists mod is much better apporach
            AddMod(new Review(950011274u, "Japanese Romaji Names [BETA]") {
                Authors = "Homusubi",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1301101044u, Status.Incompatible }, // CNL Japanese Blank Road Name
                    { 1299863509u, Status.Incompatible }, // CNL Japanese Localization Name Lists
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 937334007u , Status.Incompatible }, // Japanese Localization RD
                    { 935350530u , Status.Required     }, // CSL Custom Names [1.0.0]
                },
                Locale = "ja",
                Published = WorkshopDate("18 Jun, 2017"),
                ReplaceWith = 1299863509u, // CNL Japanese Localization Name Lists
                Updated = WorkshopDate("28 Jun, 2017"),
            });

            // use namelist alternative instead: 1299863509u, 
            AddMod(new Review(937334007u, "Japanese Localization RD") {
                Affect = Factor.Other, // todo
                Authors = "Gansaku",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with custom name lists mod?
                    { 1322787091u, Status.Incompatible }, // Addresses & Names Mod 2.0.1
                    { 1299863509u, Status.Incompatible }, // CNL Japanese Localization Name Lists
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                    { 950011274u , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 935350530u , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is incompatible with all other namelists; use the replacement item instead." },
                },
                Published = WorkshopDate("1 Jun, 2017"),
                ReplaceWith = 1299863509u, // CNL Japanese Localization Name Lists
                SourceURL = "https://github.com/gansaku/JapaneseLocalizationRD",
                Updated = WorkshopDate("1 Jun, 2017"),
            });

            /*
            # ████████ ██████   █████  ███    ██ ███████ ██       █████  ████████ ██  ██████  ███    ██ ███████
            #    ██    ██   ██ ██   ██ ████   ██ ██      ██      ██   ██    ██    ██ ██    ██ ████   ██ ██
            #    ██    ██████  ███████ ██ ██  ██ ███████ ██      ███████    ██    ██ ██    ██ ██ ██  ██ ███████
            #    ██    ██   ██ ██   ██ ██  ██ ██      ██ ██      ██   ██    ██    ██ ██    ██ ██  ██ ██      ██
            #    ██    ██   ██ ██   ██ ██   ████ ███████ ███████ ██   ██    ██    ██  ██████  ██   ████ ███████
            */

            string aliDetails = "Details of mod: https://forum.paradoxplaza.com/forum/index.php?threads/get-steam-to-remove-this-item-from-the-workshop.975808/#post-21997231";

            // currently most recent one
            AddMod(new Review(1988319487u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "luotianzhi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("4 Feb, 2020"),
                Updated = WorkshopDate("4 Feb, 2020"),
            });

            AddMod(new Review(1418444018u, "417245527 Mod Thai-Language 6") {
                Affect = Factor.Other, // todo
                Authors = "[O]ne_Step",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 417245527u, Status.Incompatible }, // not in workshop
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 417245527u, // not in workshop
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "th",
                Published = WorkshopDate("22 Jun, 2018"),
                Updated = WorkshopDate("22 Jun, 2018"),
            });

            // Very well maintained mod, very active author
            AddMod(new Review(938512234u, "Traditional Chinese Translation V2 社群正體中文化 V2") {
                Affect = Factor.Other, // todo
                Authors = "alien0512.tw",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412149127u, Status.Required    }, // Font Selector
                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-tw",
                Published = WorkshopDate("3 Jun, 2017"),
                Updated = WorkshopDate("31 Mar, 2020"),
            });

            // Very well maintained mod, very active author
            // 100% Turkish Cities Skylines May 2019 by Turkish PATCH & Riza symbol54
            AddMod(new Review(936338233u, "%100 TÜRKÇE 2019 Mayıs ayı Cities Skylines TÜRKÇE YAMA by symbol54 & Rıza") {
                Affect = Factor.Other,
                Authors = " byBashkann(symbol54), Riza",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {

                },
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "tr",
                Published = WorkshopDate("30 May, 2017"),
                Updated = WorkshopDate("29 Mar, 2020"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1943193013u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "cute",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("22 Dec, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("22 Dec, 2019"),
            });

            AddMod(new Review(1939503380u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "382661337",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("18 Dec, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("18 Dec, 2019"),
            });

            AddMod(new Review(1879010148u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "喂奶",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("3 Oct, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("3 Oct, 2019"),
            });

            AddMod(new Review(1842948393u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "Jony-y",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("23 Aug, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("23 Aug, 2019"),
            });

            AddMod(new Review(1842940377u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "qq_q33",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("23 Aug, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("23 Aug, 2019"),
            });

            AddMod(new Review(1700403881u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "Lemon",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("1 Apr, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("1 Apr, 2019"),
            });

            AddMod(new Review(1684556269u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "1061303312",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("16 Mar, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("16 Mar, 2019"),
            });

            AddMod(new Review(1680979061u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "136681275",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("12 Mar, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("12 Mar, 2019"),
            });

            AddMod(new Review(1625610864u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "903590283",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("15 Jan, 2019"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("15 Jan, 2019"),
            });

            AddMod(new Review(1548868991u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "代号037",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("27 Oct, 2018"),
                ReplaceWith = latestAliMod,
                SourceURL = "https://gist.github.com/anonymous/4e9b615e04366fbba1c10eff57387eab",
                Updated = WorkshopDate("27 Oct, 2018"),
            });

            AddMod(new Review(1546750969u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "fireangel",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("24 Oct, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("24 Oct, 2018"),
            });

            AddMod(new Review(1546742761u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "切斯特威廉尼米兹 海军",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("24 Oct, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("24 Oct, 2018"),
            });

            AddMod(new Review(1408154706u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "WSYYY",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("10 Jun, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("10 Jun, 2018"),
            });

            AddMod(new Review(1396970654u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "东皇丶沫凪",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("28 May, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("28 May, 2018"),
            });

            AddMod(new Review(1394163871u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "丿燃情丶流逝",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("25 May, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("25 May, 2018"),
            });

            AddMod(new Review(1357099637u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "jack760826",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("9 Apr, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("9 Apr, 2018"),
            });

            AddMod(new Review(1357086606u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "jack760826",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("9 Apr, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("9 Apr, 2018"),
            });

            AddMod(new Review(1334668143u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "邓大哥",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("18 Mar, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("18 Mar, 2018"),
            });

            AddMod(new Review(1334667876u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "邓大哥",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("18 Mar, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("18 Mar, 2018"),
            });

            AddMod(new Review(1322239426u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "希维",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("6 Mar, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("6 Mar, 2018"),
            });

            AddMod(new Review(1290370842u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "梦染",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("3 Feb, 2018"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("3 Feb, 2018"),
            });

            AddMod(new Review(1218794439u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "767068841",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("2 Dec, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("2 Dec, 2017"),
            });

            AddMod(new Review(1216481923u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "朱哥",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("30 Nov, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("26 Aug, 2018"),
            });

            AddMod(new Review(966361998u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "Migi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("6 Jul, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("6 Jul, 2017"),
            });

            AddMod(new Review(965590422u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "yuhuooo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("5 Jul, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("5 Jul, 2017"),
            });

            AddMod(new Review(964727801u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "Huskos",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("5 Jul, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("5 Jul, 2017"),
            });

            AddMod(new Review(949461510u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "丿MX灬神话",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("18 Jun, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("18 Jun, 2017"),
            });

            AddMod(new Review(940398690u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "503624885",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("5 Jun, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("5 Jun, 2017"),
            });

            AddMod(new Review(929222270u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "anyebuzu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("20 May, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddMod(new Review(929211897u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "william0903",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("20 May, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddMod(new Review(928628465u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "yuluo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("19 May, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddMod(new Review(928477022u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "BeiCheng",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("19 May, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddMod(new Review(926909781u, "ali213_mod_01") {
                Affect = Factor.Other, // todo
                Authors = "MCOO",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, aliDetails },
                },
                Published = WorkshopDate("16 May, 2017"),
                ReplaceWith = latestAliMod,
                Updated = WorkshopDate("16 May, 2017"),
            });
        }
    }
}
