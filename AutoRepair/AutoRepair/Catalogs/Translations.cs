namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public class Translations {

        private const ulong _hideIt = 1591417160u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Translations"/> class.
        /// </summary>
        public Translations() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Translations"/> class.
        /// </summary>
        ~Translations() {
            list.Clear();
        }

        /// <summary>
        /// Adds a translated clone mod item to the list.
        /// </summary>
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        /// <param name="originalId">The Steam Workshop ID of the original item that was translated.</param>
        /// <param name="locale">The translated language, if known.</param>
        public void AddClone(ulong workshopId, string workshopName, ulong originalId, string locale = "??") {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.Translation
                      | ItemFlags.Abandonware,
                IncompatibleMods = new List<ulong>() {
                    { originalId },
                },
                Locale = locale,
                ReplaceWith = originalId,
            });
        }

        /// <summary>
        /// Adds a game-breaking (forced migration) translated clone mod item to the list.
        /// </summary>
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        /// <param name="originalId">The Steam Workshop ID of the original item that was translated.</param>
        /// <param name="locale">The translated language, if known.</param>
        public void AddGameBreakingClone(ulong workshopId, string workshopName, ulong originalId, string locale = "??") {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.Translation
                      | ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration,
                IncompatibleMods = new List<ulong>() {
                    { originalId },
                },
                Locale = locale,
                ReplaceWith = originalId,
            });
        }

        public void AddGameTranslation(ulong workshopId, string workshopName, string locale = "??") {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                Locale = locale,
            });
        }

        public void AddNamelist(ulong workshopId, string workshopTitle, string locale = "??") {
            Item item = new Item(workshopId, workshopTitle) {
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.Translation,
                Locale = locale,
                IncompatibleMods = new List<ulong>() {
                    { 1322787091u }, // Addresses & Names Mod 2.0.1
                },
                RequiredMods = new List<ulong>() {
                    { 1231957400u }, // Custom Namelists
                },
            };
            list.Add(workshopId, item);
        }

        public void Populate() {
            AddMod(new Item(1231957400u, "Custom Namelists") {
                Authors = "Markus",
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // todo: check if compat with Addresses & Names Mod 2.0.1
                },
                SourceCodeURL = "https://github.com/markusmitbrille/cities-skylines-custom-namelists",
            });

            // Namelists
            AddNamelist(1753697086u, "Russian Localization Fix - Исправление русской локализации", "ru");
            AddNamelist(1752699330u, "Альтернативный русский NamesLists", "ru");
            AddNamelist(1652793447u, "Germanize: Road & District Names", "de");
            AddNamelist(1644667012u, "Germanize: Cim Names", "de");
            AddNamelist(1327691796u, "Bayreuther Straßen- und Stadtteilliste", "de");
            AddNamelist(1301101044u, "CNL Japanese Blank Road Name", "ja");
            AddNamelist(1299863509u, "CNL Japanese Localization Name Lists", "ja");
            AddNamelist(1298626701u, "CNL Blank Road Name MOD", "*"); // language agnostic
            AddNamelist(1261047747u, "Wiener Strassennamen/Viennese street names", "de-at");
            AddNamelist(1249641304u, "Custom Names Lists", "*"); // example list templates
            AddNamelist(1231958156u, "Vienna Namelist", "de-at");

            // covers multiple regions: Iran Uzbekistan Turkmenistan Afghanistan Pashtun Pakhtun Pashto
            // Pakhto Kurd Kurdistan O'zbekiston Baluch Balochistan Baluchistan Tajikistan Iranian
            AddNamelist(1255835366u, "Central Asian Names", "*");

            // Game translations
            AddGameTranslation(1988319487u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1943193013u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1939503380u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1879010148u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1842948393u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1842940377u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1700403881u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1684556269u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1680979061u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1625610864u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1548868991u, "ali213_mod_01", "zh-cn"); // https://gist.github.com/anonymous/4e9b615e04366fbba1c10eff57387eab
            AddGameTranslation(1546750969u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1546742761u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1418444018u, "417245527 Mod Thai-Language 6", "th");
            AddGameTranslation(1408154706u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1396970654u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1394163871u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1357099637u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1357086606u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1334668143u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1334667876u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1322239426u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1290370842u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1218794439u, "ali213_mod_01", "zh-cn");
            AddGameTranslation(1216481923u, "ali213_mod_01", "zh-cn");

            // Language clone mods
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
            AddClone(1894296637u, "Bulldoze It! 汉化版", 1627986403u, "zh-cn");
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
        }
    }
}
