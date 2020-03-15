namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public class Mods {

        private const ulong _hideIt = 1591417160u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Mods"/> class.
        /// </summary>
        public Mods() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Mods"/> class.
        /// </summary>
        ~Mods() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add.</param>
        public void Add(Item item) {
            item.ItemType = ItemTypes.Mod;
            list.Add(item.WorkshopId, item);
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        public void Add(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
            });
        }

        // todo: flag the item as dodgey
        public void AddDodgey(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
            });
        }

        public void Populate() {

            Add(new Item(2016920607u, "RICO revisited") {
                Flags = ItemFlags.Verified,
                IncompatibleMods = new List<ulong>() {
                    { 586012417u }, // Ploppable RICO (original)
                },
            });


            Add(new Item(2009708489u, "Road Arrows Replacer [Spain]") {
                IncompatibleMods = new List<ulong>() {
                    { 956707300u }, // Remove Street Arrows
                    //? { _hideIt },
                },
                RequiredAssets = new List<ulong>() {
                    { 2008960441u }, // Spanish Arrow Decals Pack
                },
            });

            AddDodgey(2009172305u, "EPTUI TLM Integration (Beta)");

            Add(new Item(1962752152u, "Busstop Prop Remover") {
                IncompatibleMods = new List<ulong>() {
                    { _hideIt },
                    { 919020932u }, // Stop Remover
                    { 545878277u }, // [GBS] German Bus Stop Mod [NC]
                },
            });

            Add(new Item(1959342332u, "CSUR ToolBox") {
                Flags = ItemFlags.Verified,
                RequiredMods = new List<ulong>() {
                    { 1959183067u }, // CSUR Loader
                },
            });

            // Todo - list more assets?
            Add(new Item(1959183067u, "CSUR Loader") {
                Flags = ItemFlags.Verified,
                RequiredMods = new List<ulong>() {
                    { 1959342332u }, // CSUR ToolBox
                },
                RequiredAssets = new List<ulong>() {
                    { 1959210164u }, // CSUR Basic Pack [R1]
                },
            });

            Add(1957515502u, "OpenStreetMap Import - generate roads from OSM with street names and road-type selection");

            // todo: probably incompatible with TMPE
            Add(1953042839u, "Unified Railway System");

            // todo: conflict with vanilla
            Add(1949192313u, "UnlimitedMoney");


            Add(new Item(1938493221u, "Mini FPS Booster") {
                Flags = ItemFlags.Recommended,
            });

            Add(1927186256u, "Problem Info");

            Add(1925527132u, "Advanced Road Tools"); // for creating intersections

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            Add(new Item(1922400472u, "Enhanced District Services") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/chronofanz/EnhancedDistrictServices",
                SuggestedMods = new List<ulong>() {
                    { 1721492498u }, // Optimised Outside Connections
                },
                IncompatibleMods = new List<ulong>() {
                    { 1680840913u }, // More Effective Transfer Manager
                },
            });

            AddDodgey(1920431318u, "Biogas-pw"); // dafuq?

            Add(1904439843u, "Mayoral City Service Info");

            // map editor mod
            Add(1902022083u, "TerrainRiverTool");

            // replaces bus shelters, likely incompat with similar mods
            Add(1900151000u, "替换为不锈钢公交候车亭");

            // todo: prolly incompat with realtime/realconstruciton mods
            Add(1899943042u, "No Scaffolding Animation");

            Add(1899449152, "Game Day Timer");

            // map editor mod, also works in-game
            Add(1894371878u, "TotalTerrainTool");

            // todo: likely incompat with City Vitals, Export Electricity
            Add(1893036262u, "Mayor's Dashboard v2");

            AddDodgey(1891302387u, "自动推土机");

            AddDodgey(1891302187u, "自动推土机");

            // possibly incompat with TM:PE
            Add(1890830956u, "Undo It!");

            Add(new Item(1886877404u, "Custom Effect Loader") {
                Flags = ItemFlags.Verified,
                SuggestedAssets = {
                    { 1889349343u },
                    { 1886961495u },
                },
            });

            // Sometimes breaks if 81 Tiles mod active
            // Same issue as surface painter
            Add(1869561285u, "Prop Painter 2.6.0");

            // likely incompat with Customize It Extended
            Add(1865667356u, "Twitch Citizens");

            // todo: this might be localisation of older mod, not sure
            AddDodgey(1864205702u, "地图图片叠加 Image Overlay");

            Add(1859100867u, "Klyte's Framework 1.1");

            // road editor mod
            Add(1845697704u, "Network Dump Tools");

            // weird mod collection manager
            Add(new Item(1842879635u, "SwitchMAD_light") {
                IncompatibleMods = new List<ulong>() {
                    { 1838385855u }, // SwitchMAD
                },
            });

            // weird mod collection manager
            Add(new Item(1838385855u, "SwitchMAD") {
                IncompatibleMods = new List<ulong>() {
                    { 1842879635u }, // SwitchMAD_light
                },
            });

            Add(new Item(1831805509, "Dynamic Text Props 2.3.1") {
                ConflictsWith = ConflictGroups.FineRoadAnarchy
                              | ConflictGroups.FineRoadTool,
                CompatibleWith = new List<ulong>() {
                    { 1844442251u }, // Fine Road Tool 2
                    { 1844440354u }, // Fine Road Anarchy 2
                },
                SuggestedAssets = new List<ulong>() {
                    { 1833197583u }, // Station Board 6m
                    { 1833197028u }, // Station Board 12m
                },
            });

            // todo: incompatible with hardmode vanilla mod
            Add(1830455071u, "EasyMode");

            Add(new Item(1824757296u, "Procedural Objects Fonts: Montburgh Highways Signage: Highway Shields") {
                RequiredMods = new List<ulong>() {
                    { 1094334744u }, // Procedural Objects
                },
            });

            Add(new Item(1824749264u, "Procedural Objects Fonts: Montburgh Highway Signage: Arrows") {
                RequiredMods = new List<ulong>() {
                    { 1094334744u }, // Procedural Objects
                },
            });

            // todo: requires Campus DLC
            Add(1824254667u, "Campus Parks");

            // todo: prolly breaks TM:PE
            // todo: requires Industries DLC
            Add(1816571194u, "No Industries Import");

            // Bundle of Chinese localised mods
            Add(new Item(1812384654u, string.Empty) {
                Flags = ItemFlags.GameBreaking
                      | ItemFlags.Abandonware,
            });

            // todo: incompat/obsolete with Plop the Growables?
            Add(1806881627u, "Altering History Fix"); // fix bug with historic building despawning

            Add(new Item(1806759255u, "Customize It Extended") {
                Flags = ItemFlags.Verified,
                IncompatibleMods = new List<ulong>() {
                    { 1369729955u }, // Customize It (original mod)
                },
            });

            Add(new Item(1803209875u, "Trees' Respiration 1.0.1") {
                ConflictsWith = ConflictGroups.TMPE,
            });

            Add(1801953480u, "Natural Disasters Overhaul");

            Add(1800844556u, "Zone Mixer 0 (Beta)"); // incompat with zone tools?

            Add(new Item(1799667916u, "UX Mod - OSD & Keybinds") {
                Flags = ItemFlags.Obsolete,
            });

            Add(new Item(1789133988u, "Route Shields for PO") {
                RequiredMods = new List<ulong>() {
                    { 1094334744u }, // Procedural Objects
                },
            });

            AddDodgey(1787941751u, "交通"); // "traffic" ?!

            Add(new Item(1782814610u, "Building Variations") {
                Flags = ItemFlags.Verified,
            });

            // todo: check if this causes stuck cims
            Add(new Item(1776052533u, "Stops & Stations") {
                Flags = ItemFlags.SourceAvailable,
            });

            // todo: check if source still obfu
            Add(new Item(1773106708u, "More Advanced OptionsPanel") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 973512634u }, // Sort Mod Settings
                    { 1762394554u }, // Wider Options Panel
                },
            });

            // todo: Daylight Classic _sometimes_ conflicts - find way to depict that
            Add(new Item(1771841274u, "HDRI Haven Cubemap Pack 2") {
                RequiredMods = new List<ulong>() {
                    { 1183931915u }, // Cubemap replacer
                },
                IncompatibleMods = new List<ulong>() {
                    // { 530871278u }, // Daylight classic
                },
            });

            // sounds like bit of a nightmare
            Add(new Item(1769420886u, "Panel Hook (beta) for modders") {
                Flags = ItemFlags.SourceAvailable,
            });

            Add(new Item(1768810491u, "Measure It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            // todo: check if compat with Stops & Stations mod, TM:PE, etc.
            Add(new Item(1766839841u, "Anxiety Reducer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1765325082u, "Customizable Education") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorBugs // somtimes loses settings
                      | ItemFlags.Abandonware,
                IncompatibleMods = new List<ulong>() {
                    { 654707599u }, // Citizen Lifecycle Rebalance
                    { 1915645482u }, // Citizen Lifecycle Rebalance v2
                },
            });

            Add(new Item(1764637396u, "Toggle It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            Add(new Item(1764208250u, "More Vehicles") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.SaveChanging,
                ConflictsWith = ConflictGroups.MoreVehicles
                              | ConflictGroups.TMPE, // v11+ are compatible
                CompatibleWith = new List<ulong>() {
                    { 1637663252u }, // TM:PE v11 STABLE
                    { 1806963141u }, // TM:PE v11 LABS
                },
                IncompatibleMods = new List<ulong>() {
                    { 583429740u }, // TM:PE 10.20 and earlier
                    { 1548831935u }, // Advanced Vehicle Options (new one; v1.9.0 should fix)
                    { 442167376u }, // Advanced Vehicle Options (original)
                    { 576327847u }, // 81 Tiles (BP version)
                    { 422554572u }, // 81 Tiles (original version)
                    { 1560122066u }, // 81MOD
                    { 1575247594u }, // 576327847 81 Tiles (Fixed for 1
                    { 1361478243u }, // 81 Tiles (prolly a localised version)
                },
            });

            // clone of: Extended Public Transport UI (Obsolete)
            Add(new Item(1763358249u, "411164732") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.LongBroken
                      | ItemFlags.Obsolete,
                IncompatibleMods = new List<ulong>() {
                    { 411164732u }, // Extended Public Transport UI (Obsolete)
                    { 802489150u }, // Extended Public Transport UI (+DLCs!)
                },
            });

            // todo: check if source still obfu
            Add(new Item(1762394554u, "Wider Options Panel") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 973512634u }, // Sort Mod Settings
                    { 1773106708u }, // More Advanced OptionsPanel
                },
            });

            // todo: check if source still obfu
            Add(new Item(1761648213u, "More Advanced District Snapping") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 510802741u }, // [DEPRECATED] Toggle District Snapping
                },
            });

            Add(new Item(1759269367u, "CrazyTouristFix") {
                Flags = ItemFlags.SourceAvailable,
            });

            // todo: check if source still obfu
            Add(new Item(1756787990u, "More Advanced InfoViews") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1751039059u, "Taxes Helper Mod") {
                Flags = ItemFlags.SourceAvailable,
            });

            Add(new Item(1749971558u, "Real Time Offline") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 605590542u }, // Rush Hour II
                    { 629713122u }, // Climate Control
                    { 702070768u }, // Export Electricity
                    { 1893036262u }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 649522495u }, // District Service Limit (oriignal)
                    { 1729576238u }, // Date Changer
                    { 1420955187u }, // Real Time (original by dymanoid)
                },
            });

            // todo: prolly incompatible with similar mods
            Add(new Item(1744522363u, "Money Back (Refund)") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Abandonware,
            });

            Add(new Item(1741725093u, "Note It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            AddDodgey(1740517576u, "ССМП"); // ??

            // todo: likely incompat with similar mods
            Add(1739888663u, "Budget Balancer");

            // todo: auto subscribe if user has the broken version?
            Add(new Item(1737575423u, "[ Backward Compatibility ]  New Roads For Network Extension 2") {
                RequiredMods = new List<ulong>() {
                    { 812125426u },
                    { 1243740191u },
                },
                IncompatibleMods = new List<ulong>() {
                    { 929114228u },
                },
            });

            Add(new Item(1729576238u, "Date Changer") {
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong> {
                    { 1420955187u }, // Real Time (original)
                    { 1749971558u }, // Real Time Offline
                },
            });

            Add(new Item(1723583521u, "Total Autobudget (Buffer Increase fix) deprecated") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                IncompatibleMods = new List<ulong>() {
                    { 1541897355u }, // Total Autobudget
                },
                ReplaceWith = 1541897355u, // Total Autobudget
            });

            Add(new Item(1721492498u, "Optimised Outside Connections") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1719979486u, "Philippines Realistic Sound Mod: Return!") {
                Flags = ItemFlags.GameBreaking
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            // todo: requires dlcs
            Add(1718245521u, "No Park Building Fires");

            Add(1706704781u, "Remove All Animals");

            Add(new Item(1706703944u, "More Outside Interaction") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
                IncompatibleMods = {
                    { 569008960u }, // Employ Overeducated Workers (original)
                    { 1114249433u }, // Employ Overeducated Workers (1.10+)
                    { 649522495u }, // District Service Limit (original)
                    { 1181352643u }, // District Service Limit 3.0
                    { 1911736890u }, // 1181352643 District Service Limit 3
                },
            });

            Add(new Item(1691909129u, "Rotate Brush") {
                Flags = ItemFlags.SourceUnavailable,
                SuggestedMods = {
                    { 502750307u }, // Extra Landscaping Tools
                    { 689937287u }, // Surface Painter
                },
            });

            Add(new Item(1689984220u, "Electric Roads Mod 1.2.3") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1680840913u, "More Effective Transfer Manager") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
                ConflictsWith = ConflictGroups.EmployOvereducatedWorkers,
                CompatibleWith = new List<ulong>() {
                    { 1674732053u }, // Employ Overeducated Workers V2 (1.11+)
                },
                IncompatibleMods = {
                    { 569008960u }, // Employ Overeducated Workers (original)
                    { 1114249433u }, // Employ Overeducated Workers (1.10+)
                    { 649522495u }, // District Service Limit (original)
                    { 1181352643u }, // District Service Limit 3.0
                    { 1911736890u }, // 1181352643 District Service Limit 3
                    { 1922400472u }, // Enhanced District Services
                },
            });

            Add(new Item(1677913611u, "Smart Intersection Builder") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Strdate/SmartIntersections",
                RequiredMods = new List<ulong>() {
                    { 1844440354u }, // Fine Road Anarchy 2
                },
            });

            Add(new Item(1674732053u, "Employ Overeducated Workers V2 (1.11+)") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete, // use Industry 4.0 city/district policy
                SourceCodeURL = "https://github.com/pcfantasy/EmployOvereducatedWorkers-v2",
                ConflictsWith = ConflictGroups.EmployOvereducatedWorkers,
                CompatibleWith = new List<ulong>() {
                    { 1192503086u }, // Real City V9.0.03.10
                    { 1614061108u }, // Real Construction
                    { 1623509958u }, // Real Gas Station
                    { 1680840913u }, // More Effective Transfer Manager
                },
            });

            Add(new Item(1664509314u, "Custom Animation Loader (CAL)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/boformer/CustomAnimationLoader",
                SuggestedAssets = new List<ulong>() {
                    { 1706978404u }, // Animated Excavator アニメーションユンボ
                    { 2010704792u }, // Animated Excavator CAT 365C L
                },
            });

            Add(new Item(1661072176u, "Empty It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-EmptyIt",
                IncompatibleMods = new List<ulong>() {
                    { 407873631u }, // Automatic Emptying
                    { 1182722930u }, // Automatic Empty
                    { 896806060u }, // 407873631 Automatic Emptying
                    { 1456061226u }, // Better Cemetery AI
                    { 686588890u }, // Automatic Emptying: Extended
                },
            });

            // Note: Plop the Growables has settings which can override this mod
            Add(new Item(1658773932u, "Historical Districts") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/boformer/3e01770a0c86cf9273ccdcc33d9bbc42",
                IncompatibleMods = new List<ulong>() {
                    { 1403136223u }, // Control Building Level Up v0.5 (Industries)
                    { 410535198u }, // Control Building Level Up v0.4
                    { 1275678215u }, // Force Building Level
                    { 1647722503u }, // Level
                },
            });

            Add(new Item(1658679290u, "Forest Brush v1.3") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/TPBCS/ForestBrush",
                SuggestedAssets = new List<ulong>() {
                    { 1928787248u }, // Weeds
                    { 963853793u }, // Ultra low tri trees
                },
                IncompatibleMods = new List<ulong>() {
                    { 1654658173u }, // Random Tree Brush
                },
            });

            Add(new Item(1654658173u, "Random Tree Brush") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Abandonware,
                SourceCodeURL = "https://pastebin.com/8M0gFKZh",
                IncompatibleMods = new List<ulong>() {
                    { 1658679290u }, // Forest Brush v1.3
                },
            });

            Add(new Item(1651041757u, "Auto Rocket Launch 火箭自动发射") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/mshsheng/CSL-AutoRocketLaunch",
                SuggestedMods = new List<ulong>() {
                    { 1327013919u }, // No Time For Caution
                },
            });

            Add(new Item(1651036644u, "Advanced Traffic Congestion Report") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/pcfantasy/TrafficCongestionReport",
            });

            // todo: wtf is this really?
            Add(new Item(1649747813, "1649747813") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/Acc3ssViolation/67c8b829db76e0a81c02ee18995abb2c",
                IncompatibleMods = new List<ulong>() {
                    { 815103125u }, // Extra Vehicle Effects (Plugin for Vehicle Effects Mod)
                },
            });

            Add(new Item(1648585256u, "NoBailOutWarning") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1647722503u, "Level") {
                Locale = "ko",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Unreliable
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1658773932u }, // Historical Districs
                    { 1403136223u }, // Control Building Level Up v0.5 (Industries)
                    { 410535198u }, // Control Building Level Up v0.4
                    { 1275678215u }, // Force Building Level
                },
            });

            Add(new Item(1637106958u, "Lock Forestry") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1633580257u, "Vehicle Wealthizer 2") {
                Flags = ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.TMPE,
                CompatibleWith = new List<ulong>() {
                    { 1637663252u }, // TM:PE V11 STABLE
                    { 1806963141u }, // TM:PE v11 LABS
                },
            });

            Add(new Item(1632320836u, "Service Vehicles Manager 2.0.1") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/klyte45/ServiceVehiclesManager",
                IncompatibleMods = new List<ulong>() {
                    { 934994075u }, // Service Vehicle Selector 2
                    { 928128676u }, // Improved Public Transport 2
                },
            });

            Add(new Item(1627469414u, "No Parking") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1625704117u, "Roundabout Builder") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Strdate/AutomaticRoundaboutBuilder",
                RequiredMods = new List<ulong>() {
                    { 1844440354u }, // Fine Road Anarchy 2
                },
            });

            Add(new Item(1623509958u, "Real Gas Station") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/pcfantasy/RealGasStation",
                ConflictsWith = ConflictGroups.Difficulty,
                IncompatibleMods = {
                    { 1072157697u }, // Cargo Info
                    { 1739993783u }, // Cargo Info (Fix)
                    { 1435741602u }, // Snooper
                },
            });

            Add(new Item(1614062928u, "Unlock LandScaping") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1614061108u, "Real Construction") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/pcfantasy/RealConstruction",
                ConflictsWith = ConflictGroups.Difficulty
                              | ConflictGroups.MoreVehicles,
                IncompatibleMods = new List<ulong>() {
                    { 1072157697u }, // Cargo Info
                    { 1739993783u }, // Cargo Info (Fix)
                    { 1764208250u }, // More Vehicles
                },
            });

            Add(new Item(1603398633u, "Flag Params") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
            });

            Add(new Item(1603319148u, "576997275 Remove Need For Pipes") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 576997275u }, // Remove Need For Pipes
                },
                ReplaceWith = 576997275u, // Remove Need For Pipes
            });

            Add(new Item(1598546349u, "Mary's Mod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.Difficulty,
            });

            Add(new Item(1597852915u, "More Advanced Toolbar") {
                Flags = ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.Toolbar,
                IncompatibleMods = new List<ulong>() {
                    { 563229150u }, // Advanced Toolbar
                    { 1577882296u }, // Resize It!
                    { 1383456057u }, // Shicho - Fundamental support mod for hardcore builders
                    { 451906822u }, // Enhanced Build Panel (WIP)
                    { 540758804u }, // Search Box Mod
                    { 586012417u }, // Ploppable RICO
                },
            });

            Add(new Item(1597285962u, "Stream It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-StreamIt",
            });

            Add(new Item(1596838226u, "Heavy Outside Traffic") {
                Flags = ItemFlags.SourceUnavailable,
                IncompatibleMods = {
                    { 1721492498u }, // Optimised Outside Connections
                },
            });

            Add(new Item(1595663918u, "InfoPanelOnLoad") {
                Flags = ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1756787990u }, // More Advanced InfoViews
                },
                ReplaceWith = 1756787990u, // More Advanced InfoViews
            });

            // todo: Daylight Classic _sometimes_ conflicts - find way to depict that
            Add(new Item(1591584836u, "HDRI 2K Cubemap Pack") {
                RequiredMods = new List<ulong>() {
                    { 1183931915u }, // Cubemap replacer
                },
                IncompatibleMods = new List<ulong>() {
                    // { 530871278u }, // Daylight classic
                },
            });

            Add(new Item(1591417160u, "Hide It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-HideIt",
                IncompatibleMods = new List<ulong>() {
                    { 666425898u }, // No Radioactive Desert And More!
                    //{ 1899640536u }. // Theme Mixer 2 (race condition between sprite show/hide)
                },
            });

            // removes building needs at night
            Add(new Item(1591311030u, "Don't Bulldoze At Night") {
                Flags = ItemFlags.SourceUnavailable,
                RequiredMods = new List<ulong>() {
                    { 1420955187u }, // Real Time
                },
            });

            // Real population, only one household at low density, high density population becomes larger
            Add(new Item(1587482024u, "真实人口，低密度只有一户人，高密度人口容量变大") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 426163185u }, // Realistic Population and Consumption Mod v8.4.0
                },
                ReplaceWith = 426163185u, // Realistic Population and Consumption Mod v8.4.0
            });

            Add(new Item(1586774819u, "Other Rail Track Speed Increaser") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://pastebin.com/sDbefj5J",
                IncompatibleMods = new List<ulong>() {
                    { 457516262u }, // Rail Track Speed Increaser 2.2.1
                },
            });

            // todo: Daylight Classic _sometimes_ conflicts - find way to depict that
            Add(new Item(1585691173u, "HDRI Haven Cubemap Pack") {
                RequiredMods = new List<ulong>() {
                    { 1183931915u }, // Cubemap replacer
                },
                IncompatibleMods = new List<ulong>() {
                    // { 530871278u }, // Daylight classic
                },
            });

            Add(new Item(1577882296u, "Resize It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-ResizeIt",
                ConflictsWith = ConflictGroups.Toolbar,
                IncompatibleMods = new List<ulong>() {
                    { 563229150u }, // Advanced Toolbar
                    { 1597852915u }, // More Advanced Toolbar
                    { 1383456057u }, // Shicho - Fundamental support mod for hardcore builders
                    { 451906822u }, // Enhanced Build Panel (WIP)
                    { 540758804u }, // Search Box Mod
                },
            });

            AddDodgey(1570376078u, "自动推土机");

            Add(new Item(1562650024u, "Rebalanced Industries") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Quboid/CSL_RebalancedIndustries",
                IncompatibleMods = new List<ulong>() {
                    { 1369729955u }, // Customize It!
                },
                CompatibleWith = new List<ulong>() {
                    { 1806759255u }, // Customize It Extended
                },
            });

            AddDodgey(1559479494u, "MyTheme");
            AddDodgey(1558675585u, "MyTheme");

            AddDodgey(1555378173u, "410344523"); // translated pop balance mod?

            Add(new Item(1553517176u, "Specialized Industry Fix Redux") {
                Flags = ItemFlags.Obsolete
                      | ItemFlags.GameBreaking // broken since Industries DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Vectorial1024/SpecializedIndustryFixRedux",
                IncompatibleMods = new List<ulong>() {
                    { 662386761u }, // Specialised Industry Fix [BUGFIX for Vanilla]
                    { 1562650024u }, // Rebalanced Industries
                },
                ReplaceWith = 1562650024u, // Rebalanced Industries
            });

            // todo: also works in editor
            Add(new Item(1552053911u, "TrailerVariation Loader") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/Acc3ssViolation/a129c802e7e2eaeb2ef566a0f370afc0",
                SuggestedMods = new List<ulong>() {
                    { 800820816u }, // Extended Asset Editor 0.4.11
                },
            });

            // todo: prolly incompat with WG mods
            Add(new Item(1551563197u, "EnhancedBuildingCapacity - Fixed") {
                Flags = ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 410344523u }, // PopBalanceMod
                    { 408706691u }, // Proper Hardness
                    { 411190402u }, // Building Simulation Overhaul (no longer in workshop)
                },
            });

            AddDodgey(1550281302u, "TransportCapacity");

            // todo: might have more conflicts
            Add(new Item(1548831935u, "Advanced Vehicle Options AVO (Industries DLC ready)") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // https://github.com/CityGecko/CS-AdvancedVehicleOptions/issues
                SourceCodeURL = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
                IncompatibleMods = new List<ulong>() {
                    { 442167376u }, // Advanced Vehicle Options (AVO)
                },
            });

            Add(new Item(1548749050u, "Mark-a-Route Reuploaded") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                IncompatibleMods = new List<ulong>() {
                    { 649674529u }, // Mark-a-route (no longer in workshop)
                },
            });

            AddDodgey(1547491802, "Chengguanju");

            // todo: suggested assets
            Add(new Item(1546357276u, "Industries Vehicle Converter") {
                Flags = ItemFlags.SourceUnavailable,
                RequiredMods = new List<ulong>() {
                    { 530771650u }, // Prefab Hook (Mod Dependency)
                },
            });

            // shows vehicles in tunnels, likely to be removed from workshop
            Add(new Item(1544546832u, "TRMod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                // todo; prolly incompat with NExt2
            });

            AddDodgey(1544326926u, "重复建设地标建筑");

            Add(new Item(1541897355u, "Total Autobudget") {
                Flags = ItemFlags.MinorBugs // can sometimes break services
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/ZenyaIse/Cities-Skylines-Total-Autobudget",
                // todo: incompat with other budget mods
            });

            Add(new Item(1540147921u, "Grid be Gone") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/Quboid/298552b4e4787cefe7faa55cf8a6e6be",
                SuggestedMods = new List<ulong>() {
                    { 1536223783u }, // Hide Selectors
                },
            });

            Add(new Item(1536223783u, "Hide Selectors") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/Quboid/628b69e5f778c57a29cbcc8877e0cd59",
                SuggestedMods = new List<ulong>() {
                    { 1540147921u }, // Grid be Gone
                },
                CompatibleWith = new List<ulong>() {
                    { 903347963 }, // Transparent Selectors
                },
            });

            Add(new Item(1530376523u, "Railway Replacer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1526302248u, "Spinny RGB Circle") {
                Flags = ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1502721219u }, // [Deprecated] Spinny Red Circle
                },
            });

            Add(new Item(1523608557u, "American Sign Replacer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1522785644u, "Infinite Demand Mod") {
                Flags = ItemFlags.SourceUnavailable,
            });

            // editor mod
            Add(new Item(1518485094u, "Mesh Import Rotation Tangents Fix") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1518296436u, "Driving Mod") {
                Flags = ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.TMPE,
            });

            Add(new Item(1502721219u, "[Deprecated] Spinny Red Circle") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                IncompatibleMods = new List<ulong>() {
                    { 1526302248u }, // Spinny RGB Circle
                },
                ReplaceWith = 1526302248u, // Spinny RGB Circle
            });

            Add(new Item(1499486217u, "Ragnarok EXTREME EDITION") {
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompat with other ragnarock and maybe similar mods
            });

            Add(new Item(1498036881u, "UltimateMod 2.4 ( Higher Income and More Options )") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1487849798u, "Higher Income Mod 1.2a") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                // todo: find replacement
            });

            Add(new Item(1485051886u, "Cimtographer - rebuild for 1.10.1-f3") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs
                      | ItemFlags.Unreliable,
                SourceCodeURL = "https://github.com/rdiekema/Cities-Skylines-Mapper/commit/4bb1557b97226cd84728593799be2710bb129c19",
                IncompatibleMods = new List<ulong>() {
                    { 416064574u }, // Cimtographer
                },
            });

            Add(new Item(1456061226u, "Better Cemetery AI") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/seanke/BetterCemeteryAI",
            });

            // Click the "M" mark in the upper left corner to display each type of functional building in different colors
            Add(new Item(1455265809u, "ServiceMap") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                // todo: might conflict with TMPE
            });

            Add(new Item(1452259306u, "Aedificium RELOADED [BETA] - OBSOLETE") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                IncompatibleMods = new List<ulong>() {
                    { 793489846u }, // Aedificium - Hotloading workshop items while you play
                },
            });

            // Seems possibly broken by Campus update, or NS2... Users reporting it only lays one road.
            Add(new Item(1440928803u, "Parallel Road Tool") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                SourceCodeURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
                IncompatibleMods = new List<ulong>() {
                    { 1400711138u }, // [BETA] Parallel Road Tool
                    { 1758376843u }, // Network Skins 2 (Beta)
                },
            });

            // todo: need speed catalog as there are more of these things
            Add(new Item(1425061566u, "V10Speed") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/V10lator/V10Speed",
                IncompatibleMods = {
                    { 412292157u }, // More Simulation Speed Options
                    // real time, and other speed sliders
                },
            });

            // todo: chk compat with feature unlockers
            Add(new Item(1424264814u, "YAFU - Yet Another Feature Unlocker") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Celisuis/YAFU",
            });

            Add(new Item(1420955187u, "Real Time") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/dymanoid/RealTime",
            });

            Add(new Item(1415090282u, "AutoLineColor Redux") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/taradinoc/CitiesSkylinesAutoColorMod",
                IncompatibleMods = new List<ulong>() {
                    { 408760323u }, // Auto Line Color
                },
            });

            Add(new Item(1412844620u, "Realistic Walking Speed") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/DaEgi01/CitiesSkylines-RealisticWalkingSpeed",
            });

            Add(new Item(1410003347u, "Additive Shader") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/ronyx69/41d2368485b4eea89958c368fab878b8",
            });

            // editor tool
            Add(new Item(1406275125u, "Asset DLC flags Editor") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1403960464u, "Maintenance Fees (Parklife Ready)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/Xial/Maintenancefee",
                IncompatibleMods = {
                    { 602336261u }, // Maintenance Fees
                },
            });

            Add(new Item(1403136223u, "Control Building Level Up v0.5 (Industries)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/boformer/c0a449426ae681bbe4f4e54693df4b8c",
                IncompatibleMods = new List<ulong>() {
                    { 410535198u }, // Control Building Level Up v0.4
                    // todo: prolly others
                },
            });

            // Seems possibly broken by Campus update, or NS2... Users reporting it only lays one road.
            Add(new Item(1400711138u, "[BETA] Parallel Road Tool") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                SourceCodeURL = "https://github.com/ST-Apps/CS-ParallelRoadTool",
                IncompatibleMods = new List<ulong>() {
                    { 1440928803u }, // Parallel Road Tool
                    { 1758376843u }, // Network Skins 2 (Beta)
                },
                RequiredMods = new List<ulong>() {
                    { 1844440354u },
                },
            });

            Add(new Item(1398502258u, "Dam Upkeep Scaling") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1394468624u, "Advanced Stop Selection (ex MTSE)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/bloodypenguin/Skylines-ImprovedStopSelection",
                IncompatibleMods = new List<ulong>() {
                    { 442957897u }, // [Obsolete] Multi-Track Station Enabler
                    { 532863263u }, // [deprecated] Multi-Track Station Enabler 1.2.0
                    // todo: t++
                },
            });

            // editor
            Add(new Item(1393831156u, "Sub Mesh Flags") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1393820309u, "Ticket Price Customizer") {
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompat with similar mods? eg. by klyte
            });

            Add(new Item(1393797695u, "Touch This! Tool 3") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/klyte45/TouchThisTool",
                // todo: incompat with older touch tool no longer in workshop
            });

            // require dlc: park life
            Add(new Item(1393452031u, "Parkify") {
                Flags = ItemFlags.SourceUnavailable,
            });

            AddDodgey(1391679732u, "CS-RP");

            Add(new Item(1388613752u, "Tree Movement Control") {
                Flags = ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1383456057u }, // Shicho - Fundamental support mod for hardcore builders
                    { 842981708u }, // Random Tree Rotation
                },
            });

            Add(new Item(1386697922u, "Garbage Bin Controller") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorBugs, // LSM skipping vanilla garbage bin = game breaks
                SuggestedAssets = new List<ulong>() {
                    { 1390252175u }, // Japanese Plastic Bucket
                    { 1389908178u }, // Wheelie Bin - Color Variation
                    { 1386088603u }, // Metal bin - 01
                },
            });

            Add(new Item(1385468094u, "PollutionRemoverMod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                // todo: incompat with other pol removers
            });

            Add(new Item(1383456057u, "Shicho - Fundamental support mod for hardcore builders") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                SourceCodeURL = "https://github.com/SETNAHQ/Shicho",
                // tood: big list of incompatibilities
            });

            AddDodgey(1379361024u, "bd96432_mod_2"); // likely a translation mod

            Add(new Item(1369729955u, "Customize It!") {
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/TPBCS/CustomizeIt",
                Authors = "TPB",
                ReplaceWith = 1806759255u, // Customize It Extended
            });

            // editor mod
            Add(new Item(1364044386u, "Theme Editor Maps") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/TPBCS/ThemeEditorMaps",
                Authors = "TPB",
            });

            // editor mod
            Add(new Item(1361644472u, "Precise Prop Positioning for Asset Creators") {
                Flags = ItemFlags.SourceUnavailable,
                Authors = "TPB",
            });

            Add(new Item(1349895184u, "Tree LOD Fix") {
                Authors = "TPB",
                Flags = ItemFlags.SourceUnavailable,
                // recommend ulod?
            });

            Add(new Item(1348627392u, "Tides") {
                Authors = "TPB",
                Flags = ItemFlags.SourceUnavailable,
                // possibly incompat with rainfall / other water mods?
            });

            Add(new Item(1330381737u, "Historic Buildings (Make Historical)") {
                Authors = "CoarzFlovv",
                Flags = ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // vanilla game now has this function
                      | ItemFlags.SourceUnavailable,
            });

            // opposite of no abandonment lol
            Add(new Item(1330378440u, "Building States") {
                Authors = "CoarzFlovv",
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1328542923u, "Choose Your Rocket") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/bloodypenguin/Skylines-ChooseYourRocket",
                SuggestedAssets = new List<ulong>() {
                    { 1328560775u }, // Soyuz/Союз (Functional rocket)
                    { 1329097226u }, // Saturn V (Functional Rocket)
                },
            });

            Add(new Item(1327013919u, "No Time For Caution") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1324539315u, "Land Ships") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/bloodypenguin/Skylines-LandShips",
                SuggestedMods = new List<ulong>() {
                    { 707759735u }, // Ship Path Anarchy
                },
            });

            // todo: move to translations;
            Add(new Item(1322787091u, "Addresses & Names Mod 2.0.1") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 1231957400u }, // Custom Namelists
                },
                SourceCodeURL = "https://github.com/klyte45/AddressesMod",
            });

            Add(new Item(1320575938u, "Hide Traffic Lights") {
                Authors = "Simon Ryr",
                ConflictsWith = ConflictGroups.TrafficLights,
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/simon56modder/5fa6c13f751ec97add408ed8c6312ac9",
            });

            // maybe translation?
            Add(new Item(1317859996u, "650805785 First Person Camera_ Updated") {
                Authors = "KoLoNyAlı MeNdİL",
                Flags = ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 650805785u }, // First Person Camera: Updated
                },
                ReplaceWith = 650805785u,
            });

            Add(new Item(1312767991u, "Transport Lines Manager 13.1") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // ipt2
                    // svs - svc vehicle sel
                    // auto line color
                    // more vehicles
                },
                SourceCodeURL = "https://github.com/klyte45/TransportLinesManager",
            });

            Add(new Item(1312735149u, "Klyte Commons") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/klyte45/KlyteCommons",
            });

            Add(new Item(1304997689u, "Light Trail") {
                Authors = "sqrl",
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1300411488u, "Dynamic Fireworks") {
                Authors = "sqrl",
                Flags = ItemFlags.SourceUnavailable,
            });

            // editor mod
            Add(new Item(1288816430u, "Hex Colors") {
                Authors = "targa",
                CompatibleWith = new List<ulong>() {
                    // 81 Tiles
                    // Advanced Buildings Editor
                    // AnimUV Params
                    // Asset ItemClass Changer
                    // Asset Prefab(+Building) AI Changer
                    // Asset UI Category Changer
                    // Asset UI Priority Changer
                    // Camera Positions Utility
                    // Custom Light Effects
                    // Extended Asset Editor
                    // Fine Road Anarchy
                    // ModTools
                    // More Beautification
                    // More Network Stuff
                    // MoveIt
                    // NetworkSkins
                    // Prefab Hook
                    // Prop & Tree Anarchy
                    // Prop Line Tool
                    // Prop Precision
                    // PropRotating Params
                    // PropSnapping
                    // Transparency LODs Fix
                    // Ultimate Eyecandy
                },
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 586012417u }, // Ploppable RICO
                    // RICO Revisited?
                },
                SourceCodeURL = "https://github.com/targettius/cs-hex-colors",
            });

            Add(new Item(1275678215u, "Force Building Level") {
                Authors = "CoarzFlovv",
                ConflictsWith = ConflictGroups.BuildingLevel,
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // todo
                },
                SourceCodeURL = "https://github.com/coarxflow/Skylines-ControlBuildingLevelUpMod",
            });

            Add(new Item(1274199764u, "Network Tiling") {
                Authors = "Ronyx69",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/ronyx69/4f06181c8082188418cd0c224f630a09",
            });

            Add(new Item(1269478692u, "Trains stop on both sides of the station") {
                Authors = "Jaddy",
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report crashes or that it doesn't work
                IncompatibleMods = new List<ulong>() {
                    { 1394468624u }, // Advanced Stop Selection
                    // MTSE etc.
                },
                ReplaceWith = 1394468624u, // Advanced Stop Selection
            });

            Add(new Item(1263262833u, "Pollution Solution") {
                Authors = "Shadow Link",
                ConflictsWith = ConflictGroups.PollutionRemovers,
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // todo
                },
                SourceCodeURL = "https://github.com/rkanter/PollutionSolution/",
            });

            Add(new Item(1242879105u, "Unlock Any Milestone") {
                Authors = "Ilion",
                ConflictsWith = ConflictGroups.MilestoneUnlocks,
                Flags = ItemFlags.Abandonware // author suggests to use "Extended Game Options" mod
                      //| ItemFlags.Obsolete (still works according to comments)
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1237383751u }, // Extended Game Options
                    { 410614868u }, // EarlyUnlock
                    { 407162294u }, // All basic unlocks at the start
                    // todo: will be more
                },
            });

            // Known issues (based on author comment):
            // * Cannot see values that you set the offsets for
            // * Unable to save/load option settings
            // * Does not update visual budget panel, but does update budget in the background
            // Was previously named "Water and Electricity Controller".
            Add(new Item(1239683428u, "Budget Controller") {
                Authors = "wboler05",
                ConflictsWith = ConflictGroups.AutoBudget,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // todo
                },
                SourceCodeURL = "https://github.com/wboler05/CS-BudgetController",
            });

            // Several reported issues with this mod (based on user comment):
            // * laggy (multiple users are reporting this - lots of code running on recurring events!)
            // * milestone unlock not working
            // * achievement enabler not working
            Add(new Item(1237383751u, "Extended Game Options") {
                Authors = "Zenya",
                ConflictsWith = ConflictGroups.MilestoneUnlocks, // will be more
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 1242879105u }, // Unlock Any Milestone
                    { 823348129u }, // Disasters Enabler
                    { 410614868u }, // EarlyUnlock
                    { 407162294u }, // All basic unlocks at the start
                    // todo: will be more
                },
                SourceCodeURL = "https://github.com/ZenyaIse/Cities-Skylines-Extended-Game-Options",
            });

            // nobody knows what it does
            // suspect it increases the passenger/cargo capacity?
            AddDodgey(1228424498u, "Bzimage VehicleCapacity");

            // refund full construction cost when bulldozing
            Add(new Item(1227735337u, "Full Refund Cost[Industries Compatible]") {
                Authors = "C#",
                Flags = ItemFlags.SourceUnavailable,
                // todo check conflict with other refund mods
            });

            // Completely redundant mod as vanilla has auto-save
            Add(new Item(1225712349u, "406123642") {
                Authors = "丿CK独狼灬",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Clone // 406123642u: AutoSave - Configurable
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Translation,
            });

            // An update to 406841580u - SimCity Fudged Population, but with better UI.
            // Dev still responsive as of Feb 2020, confirms mod still works.
            Add(new Item(1224627683u, "Fudged Population Enhanced") {
                Authors = "khollenbeck",
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 406841580u }, // SimCity Fudged Population
                    // possibly incompat with anything that changes the game's info bar
                },
                SourceCodeURL = "https://github.com/krishollenbeck/cities_skylines_enhanced_fudged_population_mod",
            });

            // Based on user comments some major bugs with this:
            // * Causes problems with route creation
            // * Often adds too many vehicles (even after waiting for it to settle after few day/night cycles)
            Add(new Item(1218121337u, "Automatic Vehicle Numbers Adjuster") {
                Authors = "Overhatted",
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                IncompatibleMods = new List<ulong>() {
                    // likely IPT, TLM and maybe others
                },
                SourceCodeURL = "https://cld.pt/dl/download/0d0cc60b-6568-4618-90f5-ed687b9d8eed/AutomaticVehicleNumbersAdjuster.zip",
            });

            Add(new Item(1217239330u, "Profitable Offices") {
                Authors = "Mrnr1",
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    // possible conflict with 550479679u (eg. duplicate assembly name)
                },
                SourceCodeURL = "https://github.com/mrnr1/CS-Profitable-Offices/",
            });
        }
    }
}
