namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /* Language clone mods
    AddClone(1994431441uL, "PostProcessFX", 412146081u);
    AddClone(1985556066uL, "4546", 426460372u); // "Favorite Cims" mod
    AddClone(1918293613uL, "Building Themes 建筑主题编辑器 Sakuya16汉化版", 466158459uL, "zh-cn");
    AddClone(1917517350uL, "右下角现实时间显示 Hour Clock 20160223", 407100916u);
    AddClone(1915645482uL, "654707599 Citizen Lifecycle Rebalance v2", 654707599u);
    AddClone(1915645035uL, "1186900508 DistrictRCI-continued", 1186900508u);
    AddClone(1912626605uL, "Configure Outside Connections Limits", 734025380u);
    AddClone(1912610854uL, "505480567 More Beautification", 505480567u);
    AddClone(1911736890uL, "1181352643 District Service Limit 3", 1181352643u);
    //AddClone(1909943267uL, "2、解锁25格地图"); // need to find original item
    AddClone(1908242850uL, "812125426 Network Extensions 2", 812125426u);
    AddClone(1908238573uL, "406723376 Tree Brush", 406723376u);
    AddGameBreakingClone(1908236993uL, "1186900508 DistrictRCI-continued", 1186900508u);
    AddClone(1900802168uL, "Maintenance Fees汉化", 602336261uL, "zh-cn");
    AddClone(1898441366uL, "Find It!-汉化版", 837734529uL, "zh-cn");
    AddClone(1898084870uL, "Watch It!-汉化版", 1643902284uL, "zh-cn");
    AddClone(1897310477uL, "Monitor It!-汉化版", 1804882663uL, "zh-cn");
    AddClone(1896212212uL, "Smart Intersection Builder 汉化修改版", 1677913611uL, "zh-cn");
    AddClone(1895912123uL, "Roundabout Builder 汉化版", 1625704117uL, "zh-cn");
    AddGameBreakingClone(1894425170uL, "Loading Screen Mod 汉化版", 667342976uL, "zh-cn");
    AddClone(1894299113uL, "Resize It! 汉化版", 1577882296uL, "zh-cn");
    AddClone(1894297972uL, "Hide It! 汉化版", 1591417160uL, "zh-cn");
    AddClone(1893235480uL, "[PLT]Prop Line Tool汉化版", 694512541uL, "zh-cn");
    AddClone(1893049735uL, "Customize It Extended 汉化版", 1806759255uL, "zh-cn");
    AddClone(1892205219uL, "FPSCamera 汉化版", 650805785uL, "zh-cn");
    AddClone(1883386307uL, "Procedural Objects 魔物模组(PO) Sakuya16汉化版", 1094334744uL, "zh-cn");
    AddClone(1881187805uL, "Sun Shafts 阳光射线 Sakuya16个人汉化版", 933513277uL, "zh-cn");
    AddClone(1880045672uL, "Relight 色彩调整 Sakuya16个人汉化版", 1209581656uL, "zh-cn");
    AddClone(1870740367uL, "Dynamic Resolution 动态分辨率 Sakuya16个人汉化版", 812713438uL, "zh-cn");
    AddClone(1870670690uL, "Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版", 672248733uL, "zh-cn");
    AddClone(1869777403uL, "TimeWarp Fix 时间光照控制 Sakuya16个人汉化", 814698320uL, "zh-cn");
    AddClone(1869743962uL, "Clouds & Fog Toggler 去云雾开关 Sakuya16个人汉化版", 523824395uL, "zh-cn");
    AddClone(1866904568uL, "Ploppable RICO 自由放置建筑 Sakuya16个人汉化版", 586012417uL, "zh-cn");
    AddClone(1859589059uL, "Roundabout Builder 汉化版", 1625704117uL, "zh-cn");
    AddClone(1841047653uL, "Network Extensions 2 汉化版", 812125426uL, "zh-cn");
    AddGameBreakingClone(1840448750uL, "FineRoadTool 汉化版", 651322972uL, "zh-cn");
    AddClone(1751128171uL, "种树画笔", 406723376uL, "zh-cn"); // Tree Brush
    AddClone(1735828984uL, "639486063_Automatic_Bulldoze_v2", 639486063uL, "ja");

    // todo: game breaking, auto bulldoze, need to set different 
    AddClone(1402634444uL, "406132323", 406132323u);
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
            { 812789818uL , Status.Incompatible }, // Simplified Chinese (the replacement for all ali mods)
            { 412149127uL , Status.Incompatible }, // Font Selector
            // ali mods:
            { 1988319487uL, Status.Incompatible }, // latestAliMod
            { 1943193013uL, Status.Incompatible },
            { 1939503380uL, Status.Incompatible },
            { 1879010148uL, Status.Incompatible },
            { 1842948393uL, Status.Incompatible },
            { 1842940377uL, Status.Incompatible },
            { 1700403881uL, Status.Incompatible },
            { 1684556269uL, Status.Incompatible },
            { 1680979061uL, Status.Incompatible },
            { 1625610864uL, Status.Incompatible },
            { 1548868991uL, Status.Incompatible },
            { 1546750969uL, Status.Incompatible },
            { 1546742761uL, Status.Incompatible },
            { 1408154706uL, Status.Incompatible },
            { 1396970654uL, Status.Incompatible },
            { 1394163871uL, Status.Incompatible },
            { 1357099637uL, Status.Incompatible },
            { 1357086606uL, Status.Incompatible },
            { 1334668143uL, Status.Incompatible },
            { 1334667876uL, Status.Incompatible },
            { 1322239426uL, Status.Incompatible },
            { 1290370842uL, Status.Incompatible },
            { 1218794439uL, Status.Incompatible },
            { 1216481923uL, Status.Incompatible },
            { 966361998uL , Status.Incompatible },
            { 965590422uL , Status.Incompatible },
            { 964727801uL , Status.Incompatible },
            { 949461510uL , Status.Incompatible },
            { 940398690uL , Status.Incompatible },
            { 929222270uL , Status.Incompatible },
            { 929211897uL , Status.Incompatible },
            { 928628465uL , Status.Incompatible },
            { 928477022uL , Status.Incompatible },
            { 926909781uL , Status.Incompatible },
            { 914688845uL , Status.Incompatible },
            { 903794180uL , Status.Incompatible },
            { 876928994uL , Status.Incompatible },
            { 871014462uL , Status.Incompatible },
            { 863689916uL , Status.Incompatible },
            { 862313211uL , Status.Incompatible },
            { 850468043uL , Status.Incompatible },
            { 846218733uL , Status.Incompatible },
            { 842155271uL , Status.Incompatible },
            { 842154595uL , Status.Incompatible },
            { 817060520uL , Status.Incompatible },
            { 815690119uL , Status.Incompatible },
            { 815555292uL , Status.Incompatible },
            { 813860002uL , Status.Incompatible },
            { 812206041uL , Status.Incompatible },
            { 811815834uL , Status.Incompatible },
            { 811140929uL , Status.Incompatible },
            { 809550172uL , Status.Incompatible },
            { 724251353uL , Status.Incompatible },
            { 711844849uL , Status.Incompatible },
        };

        internal ulong latestAliMod = 1988319487uL; // ali213_mod_01

        internal Dictionary<ulong, string> aliNotes = new Dictionary<ulong, string>(1) {
            { NOTE, "See: https://forum.paradoxplaza.com/forum/index.php?threads/get-steam-to-remove-this-item-from-the-workshop.975808/#post-21997231" },
        };

        /// <summary>
        /// Helper to add ali mods; sets default values for a few properties.
        /// </summary>
        /// <param name="item">The item to add.</param>
        internal void AddAliMod(Review item) {

            item.Affect = Factor.UI;

            item.Catalog = "Translations";

            if (item.Compatibility == null) {

                item.Compatibility = new Dictionary<ulong, Status>(aliMods);
            }

            if (item.CompatibleWith == GameVersion.DefaultRelease && item.BrokenBy == GameVersion.DefaultUntil) {

                item.CompatibleWith = GameVersion.Active;
            }

            if (item.Flags == ItemFlags.None) {

                item.Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised;

            } else if (!item.HasFlag(ItemFlags.SourceAvailable | ItemFlags.SourceUnavailable)) {

                item.Flags |= ItemFlags.SourceUnavailable;
            }

            item.Locale = "zh-cn";

            item.Notes = aliNotes;

            if (item.WorkshopId != latestAliMod) {
                item.ReplaceWith = latestAliMod;
            }

            AddMod(item);
        }

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
        private void TranslationMods() {

            string catalog = "Translations";

            AddMod(new Review(2060345623uL, "CSLTranslationComparisonTable") {
                Affect = Factor.Other,
                Authors = "ibotaro",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceBundled,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "See workshop page for detailed usage information." },
                    { NOTE, "The html doc it creates connects to external servers (they look OK, just normal stuff like jquery, etc)." },
                },
                Published = WorkshopDate("14 Apr, 2020"),
                Updated = WorkshopDate("14 Apr, 2020"),
            });

            AddMod(new Review(1231957400uL, "Custom Namelists") {
                Affect = Factor.UI,
                Authors = "Markus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356uL, Status.Incompatible }, // Twitch Citizens
                    { 1322787091uL, Status.Unknown      }, // Addresses & Names Mod 2.0.1
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 958161597uL , Status.Incompatible }, // Twitch Viewer Integrator
                    { 950011274uL , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 937334007uL , Status.Incompatible }, // Japanese Localization RD
                    { 935356978uL , Status.Incompatible }, // CSL Names Pack Example [1.0.0]
                    { 935350530uL , Status.Incompatible }, // CSL Custom Names [1.0.0]
                    { 933961247uL , Status.Unknown      }, // Russian text fix
                    { 714711792uL , Status.Incompatible }, // TwitchTV Viewers
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                },
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("15 Dec, 2017"),
                SourceURL = "https://github.com/markusmitbrille/cities-skylines-custom-namelists",
                Updated = WorkshopDate("20 Dec, 2017"),
            });

            AddMod(new Review(935356978uL, "CSL Names Pack Example [1.0.0]") {
                Affect = Factor.UI,
                Authors = "TGC",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 935350530uL , Status.Required     }, // CSL Custom Names [1.0.0]
                    { 933961247uL , Status.Unknown      }, // Russian text fix
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete // use Custom Name Lists mod instead
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("29 May, 2017"),
                ReplaceWith = 1231957400uL, // Custom Namelists
                Updated = WorkshopDate("29 May, 2017"),
            });

            AddMod(new Review(935350530uL, "CSL Custom Names [1.0.0]") {
                Affect = Factor.UI,
                Authors = "TGC",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1865667356uL, Status.Incompatible }, // Twitch Citizens
                    { 1322787091uL, Status.Unknown      }, // Addresses & Names Mod 2.0.1
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 958161597uL , Status.Incompatible }, // Twitch Viewer Integrator
                    { 937334007uL , Status.Incompatible }, // Japanese Localization RD
                    { 935356978uL , Status.Compatible   }, // CSL Names Pack Example [1.0.0]
                    { 935350530uL , Status.Incompatible }, // CSL Custom Names [1.0.0]
                    { 933961247uL , Status.Unknown      }, // Russian text fix
                    { 714711792uL , Status.Incompatible }, // TwitchTV Viewers
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("29 May, 2017"),
                ReplaceWith = 1231957400uL, // Custom Namelists
                Updated = WorkshopDate("29 May, 2017"),
            });

            // changes existing russian translation text, replacing some words with shorter ones
            AddMod(new Review(933961247uL, "Russian text fix") {
                Affect = Factor.Other,
                Authors = "TGC",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1753697086uL, Status.Unknown      }, // Russian Localization Fix - Исправление русской локализации
                    { 1752699330uL, Status.Unknown      }, // Альтернативный русский NamesLists
                    { 1231957400uL, Status.Unknown      }, // Custom Namelists
                    { 935356978uL , Status.Unknown      }, // CSL Names Pack Example [1.0.0]
                    { 935350530uL , Status.Unknown      }, // CSL Custom Names [1.0.0]
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
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

            AddMod(new Review(2055299197uL, "上海路名") {
                Affect = Factor.UI,
                Authors = "BobLiu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMod(new Review(1753697086uL, "Russian Localization Fix - Исправление русской локализации") {
                Affect = Factor.UI,
                Authors = "White_Drake (UA)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1752699330uL, Status.Incompatible }, // Альтернативный русский NamesLists
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                    { 933961247uL , Status.Unknown      }, // Russian text fix
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 1752699330uL, // Альтернативный русский NamesLists
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ru",
                Published = WorkshopDate("27 May, 2019"),
                Updated = WorkshopDate("27 May, 2019"),
            });

            AddMod(new Review(1752699330uL, "Альтернативный русский NamesLists") {
                Affect = Factor.UI,
                Authors = "White_Drake (UA)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1753697086uL, Status.Incompatible }, // Russian Localization Fix - Исправление русской локализации
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                    { 933961247uL , Status.Unknown      }, // Russian text fix
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ru",
                Published = WorkshopDate("26 May, 2019"),
                ReplaceWith = 1753697086uL, // Russian Localization Fix - Исправление русской локализации
                Updated = WorkshopDate("26 May, 2019"),
            });

            AddMod(new Review(1652793447uL, "Germanize: Road & District Names") {
                Affect = Factor.UI,
                Authors = "Fabdiwabdi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "de",
                Published = WorkshopDate("11 Feb, 2019"),
                Updated = WorkshopDate("11 Feb, 2019"),
            });

            AddMod(new Review(1644667012uL, "Germanize: Cim Names") {
                Affect = Factor.UI,
                Authors = "Fabdiwabdi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "de",
                Published = WorkshopDate("4 Feb, 2019"),
                Updated = WorkshopDate("6 Feb, 2019"),
            });

            AddMod(new Review(1327691796uL, "Bayreuther Straßen- und Stadtteilliste") {
                Affect = Factor.UI,
                Authors = "Viss Valdyr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "de",
                Published = WorkshopDate("11 Mar, 2018"),
                Updated = WorkshopDate("11 Mar, 2018"),
            });

            AddMod(new Review(1301101044uL, "CNL Japanese Blank Road Name") {
                Affect = Factor.UI,
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                    { 950011274uL , Status.Incompatible }, // Japanese Romaji Names [BETA]
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("14 Feb, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1299863509uL, "CNL Japanese Localization Name Lists") {
                Affect = Factor.UI,
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                    { 950011274uL , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 937334007uL , Status.Incompatible }, // Japanese Localization RD
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 937334007u, // Japanese Localization RD
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("12 Feb, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1298626701uL, "CNL Blank Road Name MOD") {
                Affect = Factor.UI,
                Authors = "stmSantana",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "*",  // language agnostic
                Published = WorkshopDate("11 Feb, 2018"),
                Updated = WorkshopDate("11 Feb, 2018"),
            });

            AddMod(new Review(1261047747uL, "Wiener Strassennamen/Viennese street names") {
                Affect = Factor.UI,
                Authors = "x||x",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "de-at",
                Published = WorkshopDate("7 Jan, 2018"),
                Updated = WorkshopDate("7 Jan, 2018"),
            });

            AddMod(new Review(1249641304uL, "Custom Names Lists") {
                Affect = Factor.UI,
                Authors = "Ilion",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is just template for authors; see workshop page for details." },
                },
                Published = WorkshopDate("30 Dec, 2017"),
                Updated = WorkshopDate("12 Apr, 2018"),
            });

            AddMod(new Review(1231958156uL, "Vienna Namelist") {
                Affect = Factor.UI,
                Authors = "Markus",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "de-at",
                Published = WorkshopDate("15 Dec, 2017"),
                Updated = WorkshopDate("15 Dec, 2017"),
            });

            // covers multiple regions: Iran Uzbekistan Turkmenistan Afghanistan Pashtun Pakhtun Pashto
            // Pakhto Kurd Kurdistan O'zbekiston Baluch Balochistan Baluchistan Tajikistan Iranian
            AddMod(new Review(1255835366uL, "Central Asian Names") {
                Affect = Factor.UI,
                Authors = "alborzka",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400uL, Status.Required     }, // Custom Namelists
                },
                CompatibleWith = GameVersion.Active,
                Flags = ItemFlags.SourceBundled
                      | ItemFlags.Localised,
                //Languages = new[] { }, // todo
                Languages = new[] { "ku", "uz", "fa", "fa-af", "ps", },
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("3 Jan, 2018"),
                Tags = new[] {
                    "Iran", "Uzbekistan", "Turkmenistan", "Afghanistan", "Pashtun", "Pakhtun", "Pashto", "Pakhto",
                    "Kurd", "Kurdistan", "O'zbekiston", "Baluch", "Balochistan", "Baluchistan", "Tajikistan", "Iranian",
                },
                Updated = WorkshopDate("3 Jan, 2018"),
            });

            // probably obsolete - custom name lists mod is much better apporach
            AddMod(new Review(950011274uL, "Japanese Romaji Names [BETA]") {
                Affect = Factor.UI,
                Authors = "Homusubi",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1301101044uL, Status.Incompatible }, // CNL Japanese Blank Road Name
                    { 1299863509uL, Status.Incompatible }, // CNL Japanese Localization Name Lists
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 937334007uL , Status.Incompatible }, // Japanese Localization RD
                    { 935350530uL , Status.Required     }, // CSL Custom Names [1.0.0]
                },
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("18 Jun, 2017"),
                ReplaceWith = 1299863509uL, // CNL Japanese Localization Name Lists
                Updated = WorkshopDate("28 Jun, 2017"),
            });

            // use namelist alternative instead: 1299863509u, 
            AddMod(new Review(937334007uL, "Japanese Localization RD") {
                Affect = Factor.UI,
                Authors = "Gansaku",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat with custom name lists mod?
                    { 1322787091uL, Status.Incompatible }, // Addresses & Names Mod 2.0.1
                    { 1299863509uL, Status.Incompatible }, // CNL Japanese Localization Name Lists
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 950011274uL , Status.Incompatible }, // Japanese Romaji Names [BETA]
                    { 935350530uL , Status.Incompatible }, // CSL Custom Names [1.0.0]
                },
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This is incompatible with all other namelists; use the replacement item instead." },
                },
                Published = WorkshopDate("1 Jun, 2017"),
                ReplaceWith = 1299863509uL, // CNL Japanese Localization Name Lists
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

            // currently most recent one
            AddAliMod(new Review(1988319487uL, "ali213_mod_01") {
                Authors = "luotianzhi",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Feb, 2020"),
                Updated = WorkshopDate("4 Feb, 2020"),
            });

            AddMod(new Review(1418444018uL, "417245527 Mod Thai-Language 6") {
                Affect = Factor.UI,
                Authors = "[O]ne_Step",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 417245527uL, Status.Incompatible }, // not in workshop
                },
                CompatibleWith = GameVersion.Active,
                ContinuationOf = 417245527u, // not in workshop
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "th",
                Published = WorkshopDate("22 Jun, 2018"),
                Updated = WorkshopDate("22 Jun, 2018"),
            });

            // Very well maintained mod, very active author
            AddMod(new Review(938512234uL, "Traditional Chinese Translation V2 社群正體中文化 V2") {
                Affect = Factor.UI,
                Authors = "alien0512.tw",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412149127uL, Status.Required    }, // Font Selector
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "zh-tw",
                Published = WorkshopDate("3 Jun, 2017"),
                Updated = WorkshopDate("31 Mar, 2020"),
            });

            // Very well maintained mod, very active author
            // 100% Turkish Cities Skylines May 2019 by Turkish PATCH & Riza symbol54
            AddMod(new Review(936338233uL, "%100 TÜRKÇE 2019 Mayıs ayı Cities Skylines TÜRKÇE YAMA by symbol54 & Rıza") {
                Affect = Factor.UI,
                Authors = " byBashkann(symbol54), Riza",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "tr",
                Published = WorkshopDate("30 May, 2017"),
                Updated = WorkshopDate("29 Mar, 2020"),
            });

            // Very well maintained mod, very active author.
            // Even translates the radio stations!
            AddMod(new Review(873572803uL, "Cities: Skylines - Czech translation") {
                Affect = Factor.UI,
                Authors = "[OTB]Orodreth, Woytman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "cz",
                Published = WorkshopDate("27 Feb, 2017"),
                Updated = WorkshopDate("8 Apr, 2020"),
            });

            // Very well maintained mod, very active author
            // Even translates the radio stations!
            AddMod(new Review(853916642uL, "Slovenský preklad - Slovenčina (SLOVAK)") {
                Affect = Factor.UI,
                Authors = "IP94",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "sk",
                Published = WorkshopDate("31 Jan, 2017"),
                Updated = WorkshopDate("12 Apr, 2020"),
            });

            AddMod(new Review(846246651uL, "Thai translate Mod (มอด แปลไทย)") {
                Affect = Factor.UI,
                Authors = "IP94",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Patch_1_6_3_f1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Locale = "th",
                Published = WorkshopDate("20 Jan, 2017"),
                Updated = WorkshopDate("20 Jan, 2017"),
            });

            AddMod(new Review(812789818uL, "Simplified Chinese") {
                Affect = Factor.UI,
                Authors = "风晓得Ome",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods),
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("5 Dec, 2016"),
                Updated = WorkshopDate("23 May, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddAliMod(new Review(1943193013uL, "ali213_mod_01") {
                Authors = "cute",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("22 Dec, 2019"),
                Updated = WorkshopDate("22 Dec, 2019"),
            });

            AddAliMod(new Review(1939503380uL, "ali213_mod_01") {
                Authors = "382661337",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("18 Dec, 2019"),
                Updated = WorkshopDate("18 Dec, 2019"),
            });

            AddAliMod(new Review(1879010148uL, "ali213_mod_01") {
                Authors = "喂奶",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("3 Oct, 2019"),
                Updated = WorkshopDate("3 Oct, 2019"),
            });

            AddAliMod(new Review(1842948393uL, "ali213_mod_01") {
                Authors = "Jony-y",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("23 Aug, 2019"),
                Updated = WorkshopDate("23 Aug, 2019"),
            });

            AddAliMod(new Review(1842940377uL, "ali213_mod_01") {
                Authors = "qq_q33",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("23 Aug, 2019"),
                Updated = WorkshopDate("23 Aug, 2019"),
            });

            AddAliMod(new Review(1700403881uL, "ali213_mod_01") {
                Authors = "Lemon",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("1 Apr, 2019"),
                Updated = WorkshopDate("1 Apr, 2019"),
            });

            AddAliMod(new Review(1684556269uL, "ali213_mod_01") {
                Authors = "1061303312",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("16 Mar, 2019"),
                Updated = WorkshopDate("16 Mar, 2019"),
            });

            AddAliMod(new Review(1680979061uL, "ali213_mod_01") {
                Authors = "136681275",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("12 Mar, 2019"),
                Updated = WorkshopDate("12 Mar, 2019"),
            });

            AddAliMod(new Review(1625610864uL, "ali213_mod_01") {
                Authors = "903590283",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("15 Jan, 2019"),
                Updated = WorkshopDate("15 Jan, 2019"),
            });

            AddAliMod(new Review(1548868991uL, "ali213_mod_01") {
                Authors = "代号037",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Localised,
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("27 Oct, 2018"),
                SourceURL = "https://gist.github.com/anonymous/4e9b615e04366fbba1c10eff57387eab",
                Updated = WorkshopDate("27 Oct, 2018"),
            });

            AddAliMod(new Review(1546750969uL, "ali213_mod_01") {
                Authors = "fireangel",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("24 Oct, 2018"),
                Updated = WorkshopDate("24 Oct, 2018"),
            });

            AddAliMod(new Review(1546742761uL, "ali213_mod_01") {
                Authors = "切斯特威廉尼米兹 海军",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("24 Oct, 2018"),
                Updated = WorkshopDate("24 Oct, 2018"),
            });

            AddAliMod(new Review(1408154706uL, "ali213_mod_01") {
                Authors = "WSYYY",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Jun, 2018"),
                Updated = WorkshopDate("10 Jun, 2018"),
            });

            AddAliMod(new Review(1396970654uL, "ali213_mod_01") {
                Authors = "东皇丶沫凪",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("28 May, 2018"),
                Updated = WorkshopDate("28 May, 2018"),
            });

            AddAliMod(new Review(1394163871uL, "ali213_mod_01") {
                Authors = "丿燃情丶流逝",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("25 May, 2018"),
                Updated = WorkshopDate("25 May, 2018"),
            });

            AddAliMod(new Review(1357099637uL, "ali213_mod_01") {
                Authors = "jack760826",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("9 Apr, 2018"),
                Updated = WorkshopDate("9 Apr, 2018"),
            });

            AddAliMod(new Review(1357086606uL, "ali213_mod_01") {
                Authors = "jack760826",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("9 Apr, 2018"),
                Updated = WorkshopDate("9 Apr, 2018"),
            });

            AddAliMod(new Review(1334668143uL, "ali213_mod_01") {
                Authors = "邓大哥",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("18 Mar, 2018"),
                Updated = WorkshopDate("18 Mar, 2018"),
            });

            AddAliMod(new Review(1334667876uL, "ali213_mod_01") {
                Authors = "邓大哥",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("18 Mar, 2018"),
                Updated = WorkshopDate("18 Mar, 2018"),
            });

            AddAliMod(new Review(1322239426uL, "ali213_mod_01") {
                Authors = "希维",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("6 Mar, 2018"),
                Updated = WorkshopDate("6 Mar, 2018"),
            });

            AddAliMod(new Review(1290370842uL, "ali213_mod_01") {
                Authors = "梦染",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("3 Feb, 2018"),
                Updated = WorkshopDate("3 Feb, 2018"),
            });

            AddAliMod(new Review(1218794439uL, "ali213_mod_01") {
                Authors = "767068841",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("2 Dec, 2017"),
                Updated = WorkshopDate("2 Dec, 2017"),
            });

            AddAliMod(new Review(1216481923uL, "ali213_mod_01") {
                Authors = "朱哥",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("30 Nov, 2017"),
                Updated = WorkshopDate("26 Aug, 2018"),
            });

            AddAliMod(new Review(966361998uL, "ali213_mod_01") {
                Authors = "Migi",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("6 Jul, 2017"),
                Updated = WorkshopDate("6 Jul, 2017"),
            });

            AddAliMod(new Review(965590422uL, "ali213_mod_01") {
                Authors = "yuhuooo",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Jul, 2017"),
                Updated = WorkshopDate("5 Jul, 2017"),
            });

            AddAliMod(new Review(964727801uL, "ali213_mod_01") {
                Authors = "Huskos",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Jul, 2017"),
                Updated = WorkshopDate("5 Jul, 2017"),
            });

            AddAliMod(new Review(949461510uL, "ali213_mod_01") {
                Authors = "丿MX灬神话",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("18 Jun, 2017"),
                Updated = WorkshopDate("18 Jun, 2017"),
            });

            AddAliMod(new Review(940398690uL, "ali213_mod_01") {
                Authors = "503624885",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Jun, 2017"),
                Updated = WorkshopDate("5 Jun, 2017"),
            });

            AddAliMod(new Review(929222270uL, "ali213_mod_01") {
                Authors = "anyebuzu",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("20 May, 2017"),
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddAliMod(new Review(929211897uL, "ali213_mod_01") {
                Authors = "william0903",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("20 May, 2017"),
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddAliMod(new Review(928628465uL, "ali213_mod_01") {
                Authors = "yuluo",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("19 May, 2017"),
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddAliMod(new Review(928477022uL, "ali213_mod_01") {
                Authors = "BeiCheng",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("19 May, 2017"),
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddAliMod(new Review(926909781uL, "ali213_mod_01") {
                Authors = "MCOO",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("16 May, 2017"),
                Updated = WorkshopDate("16 May, 2017"),
            });

            AddAliMod(new Review(914688845uL, "ali213_mod_01") {
                Authors = "327899396",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("16 May, 2017"),
                Updated = WorkshopDate("16 May, 2017"),
            });

            AddAliMod(new Review(903794180uL, "ali213_mod_01") {
                Authors = "xieshudan1",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("12 Apr, 2017"),
                Updated = WorkshopDate("12 Apr, 2017"),
            });

            AddAliMod(new Review(876928994uL, "ali213_mod_01") {
                Authors = "菜鸟也疯狂",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Mar, 2017"),
                Updated = WorkshopDate("4 Mar, 2017"),
            });

            AddAliMod(new Review(871014462uL, "ali213_mod_01") {
                Authors = "1292543404",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("24 Feb, 2017"),
                Updated = WorkshopDate("24 Feb, 2017"),
            });

            AddAliMod(new Review(863689916uL, "ali213_mod_01") {
                Authors = "jack-芭比学姐",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("14 Feb, 2017"),
                Updated = WorkshopDate("14 Feb, 2017"),
            });

            AddAliMod(new Review(862313211uL, "ali213_mod_01") {
                Authors = "法外狂徒",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("12 Feb, 2017"),
                Updated = WorkshopDate("12 Feb, 2017"),
            });

            AddAliMod(new Review(850468043uL, "ali213_mod_01") {
                Authors = "91刘先生",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("26 Jan, 2017"),
                Updated = WorkshopDate("26 Jan, 2017"),
            });

            AddAliMod(new Review(846218733uL, "ali213_mod_01") {
                Authors = "FengKuangXQ",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("20 Jan, 2017"),
                Updated = WorkshopDate("20 Jan, 2017"),
            });

            AddAliMod(new Review(842155271uL, "ali213_mod_01") {
                Authors = "名字取什么好呢",
                CloneOf = 842154595uL, // see below
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("14 Jan, 2017"),
                Updated = WorkshopDate("14 Jan, 2017"),
            });

            AddAliMod(new Review(842154595uL, "ali213_mod_01") {
                Authors = "名字取什么好呢",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("14 Jan, 2017"),
                Updated = WorkshopDate("14 Jan, 2017"),
            });

            AddAliMod(new Review(817060520uL, "ali213_mod_01") {
                Authors = "Manitoba",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("12 Dec, 2016"),
                Updated = WorkshopDate("12 Dec, 2016"),
            });

            AddAliMod(new Review(815690119uL, "ali213_mod_01") {
                Authors = "zhang27818",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Dec, 2016"),
                Updated = WorkshopDate("10 Dec, 2016"),
            });

            AddAliMod(new Review(815555292uL, "ali213_mod_01") {
                Authors = "DY.(2)",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Dec, 2016"),
                Updated = WorkshopDate("10 Dec, 2016"),
            });

            AddAliMod(new Review(813860002uL, "ali213_mod_01") {
                Authors = "皇甫家人",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("7 Dec, 2016"),
                Updated = WorkshopDate("7 Dec, 2016"),
            });

            AddAliMod(new Review(812206041uL, "ali213_mod_01") {
                Authors = "Li",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Dec, 2016"),
                Updated = WorkshopDate("4 Dec, 2016"),
            });

            AddAliMod(new Review(811815834uL, "ali213_mod_01") {
                Authors = "神经病没有好转",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Dec, 2016"),
                Updated = WorkshopDate("4 Dec, 2016"),
            });

            AddAliMod(new Review(811140929uL, "ali213_mod_01") {
                Authors = "Li",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("3 Dec, 2016"),
                Updated = WorkshopDate("3 Dec, 2016"),
            });

            AddAliMod(new Review(809550172uL, "ali213_mod_01") {
                Authors = "474529098",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("30 Nov, 2016"),
                Updated = WorkshopDate("30 Nov, 2016"),
            });

            AddAliMod(new Review(724251353, "ali213_mod_01") {
                Authors = "兄弟~你选错队友了！",
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("14 Jul, 2016"),
                Updated = WorkshopDate("14 Jul, 2016"),
            });

            AddAliMod(new Review(711844849uL, "ali213_mod_01") {
                Authors = "假桃桃",
                LastSeen = WorkshopDate("15 May, 2020"),
                Published = WorkshopDate("27 Jun, 2016"),
                Updated = WorkshopDate("27 Jun, 2016"),
            });

            // todo: set each ali mod as continuation of previous one
        }
    }
}