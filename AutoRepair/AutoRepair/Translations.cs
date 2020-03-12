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
                RequiredMods = new List<ulong>() {
                    { 1231957400u }, // Custom Namelists
                },
            };
            list.Add(workshopId, item);
        }

        public void Populate() {
            // Namelists
            AddNamelist(1753697086u, "Russian Localization Fix - Исправление русской локализации", "ru");
            AddNamelist(1752699330u, "Альтернативный русский NamesLists", "ru");
            AddNamelist(1652793447u, "Germanize: Road & District Names", "de");
            AddNamelist(1644667012u, "Germanize: Cim Names", "de");

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
            AddClone(1908236993u, "1186900508 DistrictRCI-continued", 1186900508u);
            AddClone(1900802168u, "Maintenance Fees汉化", 602336261u, "zh-cn");
            AddClone(1898441366u, "Find It!-汉化版", 837734529u, "zh-cn");
            AddClone(1898084870u, "Watch It!-汉化版", 1643902284u, "zh-cn");
            AddClone(1897310477u, "Monitor It!-汉化版", 1804882663u, "zh-cn");
            AddClone(1896212212u, "Smart Intersection Builder 汉化修改版", 1677913611u, "zh-cn");
            AddClone(1895912123u, "Roundabout Builder 汉化版", 1625704117u, "zh-cn");
            AddClone(1895443005u, "Fine Road Anarchy 2 汉化版", 1844440354u, "zh-cn");
            AddClone(1895440521u, "Fine Road Tool 2 汉化版", 1844442251u, "zh-cn");
            AddClone(1894425170u, "Loading Screen Mod 汉化版", 667342976u, "zh-cn");
            AddClone(1894299113u, "Resize It! 汉化版", 1577882296u, "zh-cn");
            AddClone(1894297972u, "Hide It! 汉化版", 1591417160u, "zh-cn");
            AddClone(1894296637u, "Bulldoze It! 汉化版", 1627986403u, "zh-cn");
            AddClone(1893235480u, "[PLT]Prop Line Tool汉化版", 694512541u, "zh-cn");
            AddClone(1893049735u, "Customize It Extended 汉化版", 1806759255u, "zh-cn");
            AddClone(1892205219u, "FPSCamera 汉化版", 650805785u, "zh-cn");
            AddClone(1892174866u, "MoveIt2.6汉化版", 1619685021u, "zh-cn");
            AddClone(1883386307u, "Procedural Objects 魔物模组(PO) Sakuya16汉化版", 1094334744u, "zh-cn");
            AddClone(1881187805u, "Sun Shafts 阳光射线 Sakuya16个人汉化版", 933513277u, "zh-cn");
            AddClone(1880045672u, "Relight 色彩调整 Sakuya16个人汉化版", 1209581656u, "zh-cn");
            AddClone(1870740367u, "Dynamic Resolution 动态分辨率 Sakuya16个人汉化版", 812713438u, "zh-cn");
            AddClone(1870670690u, "Ultimate Eyecandy 终极眼睛糖果滤镜 Sakuya16个人汉化版", 672248733u, "zh-cn");
            AddClone(1869777403u, "TimeWarp Fix 时间光照控制 Sakuya16个人汉化", 814698320u, "zh-cn");
            AddClone(1869743962u, "Clouds & Fog Toggler 去云雾开关 Sakuya16个人汉化版", 523824395u, "zh-cn");
            AddClone(1866904568u, "Ploppable RICO 自由放置建筑 Sakuya16个人汉化版", 586012417u, "zh-cn");
            AddClone(1866239503u, "MOVE IT Sakuya16个人汉化版", 1619685021u, "zh-cn");
            AddClone(1860379049u, "加载优化 Loading Screen", 667342976u, "zh-cn");
            AddClone(1859589059u, "Roundabout Builder 汉化版", 1625704117u, "zh-cn");
            AddClone(1857894421u, "766190099_Move_It_", 1619685021u);
            AddClone(1856282754u, "MoveIt 汉化版", 1619685021u, "zh-cn");
            AddClone(1841047653u, "Network Extensions 2 汉化版", 812125426u, "zh-cn");
            AddClone(1840448750u, "FineRoadTool 汉化版", 651322972u, "zh-cn");
            AddClone(1751128171u, "种树画笔", 406723376u, "zh-cn"); // Tree Brush
            AddClone(1735828984u, "639486063_Automatic_Bulldoze_v2", 639486063u, "ja");
        }
    }
}
