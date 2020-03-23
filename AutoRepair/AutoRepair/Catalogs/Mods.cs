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
                Compatibility = new Dictionary<ulong, Status>() {
                    { 586012417u, Status.Incompatible }, // Ploppable RICO (original)
                },
            });

            Add(new Item(2009708489u, "Road Arrows Replacer [Spain]") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 956707300u, Status.Incompatible }, // Remove Street Arrows
                    //? { _hideIt },
                    { 2008960441u, Status.Required }, // Spanish Arrow Decals Pack
                },
            });

            AddDodgey(2009172305u, "EPTUI TLM Integration (Beta)");

            Add(new Item(1962752152u, "Busstop Prop Remover") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { _hideIt, Status.Incompatible },
                    { 919020932u, Status.Incompatible }, // Stop Remover
                    { 545878277u, Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                },
            });

            Add(new Item(1959342332u, "CSUR ToolBox") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959183067u, Status.Required }, // CSUR Loader
                },
            });

            // Todo - list more assets?
            Add(new Item(1959183067u, "CSUR Loader") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1959342332u, Status.Required }, // CSUR ToolBox
                    { 1959210164u, Status.Required }, // CSUR Basic Pack [R1]
                },
            });

            Add(1957515502u, "OpenStreetMap Import - generate roads from OSM with street names and road-type selection");

            // todo: probably incompatible with TMPE
            Add(1953042839u, "Unified Railway System");

            Add(new Item(1938493221u, "Mini FPS Booster") {
                Flags = ItemFlags.Recommended,
            });

            Add(1927186256u, "Problem Info");

            // todo: probably incompatible with multiple other district service mods
            // possibly breaks when used on existing saves
            Add(new Item(1922400472u, "Enhanced District Services") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/chronofanz/EnhancedDistrictServices",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1721492498u, Status.Recommended }, // Optimised Outside Connections
                    { 1680840913u, Status.Incompatible }, // More Effective Transfer Manager
                },
            });

            AddDodgey(1920431318u, "Biogas-pw"); // dafuq?

            // replaces bus shelters, likely incompat with similar mods
            Add(1900151000u, "替换为不锈钢公交候车亭");

            // todo: prolly incompat with realtime/realconstruciton mods
            Add(1899943042u, "No Scaffolding Animation");

            Add(1899449152, "Game Day Timer");

            AddDodgey(1891302387u, "自动推土机");

            AddDodgey(1891302187u, "自动推土机");

            Add(new Item(1886877404u, "Custom Effect Loader") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1889349343u, Status.Recommended },
                    { 1886961495u, Status.Recommended },
                },
            });

            // likely incompat with Customize It Extended
            Add(1865667356u, "Twitch Citizens");

            // todo: this might be localisation of older mod, not sure
            AddDodgey(1864205702u, "地图图片叠加 Image Overlay");

            Add(1859100867u, "Klyte's Framework 1.1");

            // road editor mod
            Add(1845697704u, "Network Dump Tools");

            // weird mod collection manager
            Add(new Item(1842879635u, "SwitchMAD_light") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1838385855u, Status.Incompatible }, // SwitchMAD
                },
            });

            // weird mod collection manager
            Add(new Item(1838385855u, "SwitchMAD") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1842879635u, Status.Incompatible }, // SwitchMAD_light
                },
            });

            // todo: incompatible with hardmode vanilla mod
            Add(1830455071u, "EasyMode");

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

            Add(1801953480u, "Natural Disasters Overhaul");

            Add(1800844556u, "Zone Mixer 0 (Beta)"); // incompat with zone tools?

            Add(new Item(1799667916u, "UX Mod - OSD & Keybinds") {
                Flags = ItemFlags.Obsolete,
            });

            AddDodgey(1787941751u, "交通"); // "traffic" ?!

            Add(new Item(1782814610u, "Building Variations") {
            });

            // todo: check if this causes stuck cims
            Add(new Item(1776052533u, "Stops & Stations") {
                Flags = ItemFlags.SourceAvailable,
            });

            // sounds like bit of a nightmare
            Add(new Item(1769420886u, "Panel Hook (beta) for modders") {
                Flags = ItemFlags.SourceAvailable,
            });

            Add(new Item(1768810491u, "Measure It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            // todo: check if compat with Stops & Stations mod, TM:PE, etc.
            Add(new Item(1766839841u, "Anxiety Reducer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1764637396u, "Toggle It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });



            // clone of: Extended Public Transport UI (Obsolete)
            Add(new Item(1763358249u, "411164732") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 411164732u, Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 802489150u, Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
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
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1893036262u, Status.Incompatible }, // Mayor's Dashboard v2 (includes code from Export Electricity)
                    { 1729576238u, Status.Incompatible }, // Date Changer
                    { 1420955187u, Status.Incompatible }, // Real Time (original by dymanoid)
                    { 702070768u , Status.Incompatible }, // Export Electricity
                    { 649522495u , Status.Incompatible }, // District Service Limit (oriignal)
                    { 629713122u , Status.Incompatible }, // Climate Control
                    { 605590542u , Status.Incompatible }, // Rush Hour II
                },
            });

            // todo: prolly incompatible with similar mods
            Add(new Item(1744522363u, "Money Back (Refund)") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Abandonware,
            });

            Add(new Item(1741725093u, "Note It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
            });

            AddDodgey(1740517576u, "ССМП"); // ??

            // todo: likely incompat with similar mods
            Add(1739888663u, "Budget Balancer");

            // todo: auto subscribe if user has the broken version?
            Add(new Item(1737575423u, "[ Backward Compatibility ]  New Roads For Network Extension 2") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812125426u, Status.Required },
                    { 1243740191u, Status.Required },
                    { 929114228u, Status.Incompatible },
                },
            });

            Add(new Item(1729576238u, "Date Changer") {
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Incompatible }, // Real Time (original)
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                },
            });

            Add(new Item(1723583521u, "Total Autobudget (Buffer Increase fix) deprecated") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1541897355u, Status.Incompatible }, // Total Autobudget
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
                Affect = Factor.Employment
                              | Factor.ServiceLimit,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreOutsideInteraction",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                },
            });

            Add(new Item(1689984220u, "Electric Roads Mod 1.2.3") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1680840913u, "More Effective Transfer Manager") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/MoreEffectiveTransfer",
                Affect = Factor.Employment,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1922400472u, Status.Incompatible }, // Enhanced District Services
                    { 1911736890u, Status.Incompatible }, // 1181352643 District Service Limit 3
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 649522495u , Status.Incompatible }, // District Service Limit (original)
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers (original)
                },
            });

            Add(new Item(1664509314u, "Custom Animation Loader (CAL)") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/boformer/CustomAnimationLoader",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706978404u, Status.Recommended }, // Animated Excavator アニメーションユンボ
                    { 2010704792u, Status.Recommended }, // Animated Excavator CAT 365C L
                },
            });

            Add(new Item(1651036644u, "Advanced Traffic Congestion Report") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/TrafficCongestionReport",
            });

            Add(new Item(1648585256u, "NoBailOutWarning") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1632320836u, "Service Vehicles Manager 2.0.1") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/ServiceVehiclesManager",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 934994075u, Status.Incompatible }, // Service Vehicle Selector 2
                    { 928128676u, Status.Incompatible }, // Improved Public Transport 2
                },
            });

            Add(new Item(1627469414u, "No Parking") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1623509958u, "Real Gas Station") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902u, Status.Compatible }, // Transfer Info (beta)
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1435741602u, Status.Incompatible }, // Snooper
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/RealGasStation",
            });

            Add(new Item(1614062928u, "Unlock LandScaping") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1614061108u, "Real Construction") {
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902u, Status.Compatible   }, // Transfer Info (beta)
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1435741602u, Status.Incompatible }, // Snooper
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                },
                Affect = Factor.VehicleLimit,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/pcfantasy/RealConstruction",
            });

            Add(new Item(1603319148u, "576997275 Remove Need For Pipes") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 576997275u, Status.Incompatible }, // Remove Need For Pipes
                },
                ReplaceWith = 576997275u, // Remove Need For Pipes
            });

            Add(new Item(1598546349u, "Mary's Mod") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1597285962u, "Stream It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceURL = "https://github.com/keallu/CSL-StreamIt",
            });

            Add(new Item(1595663918u, "InfoPanelOnLoad") {
                Flags = ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                },
                ReplaceWith = 1756787990u, // More Advanced InfoViews
            });

            Add(new Item(1591417160u, "Hide It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceURL = "https://github.com/keallu/CSL-HideIt",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 666425898u, Status.Incompatible }, // No Radioactive Desert And More!
                    //{ 1899640536u }. // Theme Mixer 2 (race condition between sprite show/hide)
                },
            });

            // removes building needs at night
            Add(new Item(1591311030u, "Don't Bulldoze At Night") {
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187u, Status.Required }, // Real Time
                },
            });

            Add(new Item(1586774819u, "Other Rail Track Speed Increaser") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://pastebin.com/sDbefj5J",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 457516262u, Status.Incompatible }, // Rail Track Speed Increaser 2.2.1
                },
            });

            AddDodgey(1570376078u, "自动推土机");

            AddDodgey(1559479494u, "MyTheme");
            AddDodgey(1558675585u, "MyTheme");

            AddDodgey(1555378173u, "410344523"); // translated pop balance mod?


            // todo: also works in editor
            Add(new Item(1552053911u, "TrailerVariation Loader") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/Acc3ssViolation/a129c802e7e2eaeb2ef566a0f370afc0",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 800820816u, Status.Recommended }, // Extended Asset Editor 0.4.11
                },
            });


            Add(new Item(1548749050u, "Mark-a-Route Reuploaded") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 649674529u, Status.Incompatible }, // Mark-a-route (no longer in workshop)
                },
            });

            AddDodgey(1547491802, "Chengguanju");

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
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Total-Autobudget",
                // todo: incompat with other budget mods
            });

            Add(new Item(1540147921u, "Grid be Gone") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/Quboid/298552b4e4787cefe7faa55cf8a6e6be",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1536223783u, Status.Recommended }, // Hide Selectors
                },
            });

            Add(new Item(1536223783u, "Hide Selectors") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/Quboid/628b69e5f778c57a29cbcc8877e0cd59",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1540147921u, Status.Recommended }, // Grid be Gone
                    { 903347963u , Status.Compatible }, // Transparent Selectors
                },
            });

            Add(new Item(1530376523u, "Railway Replacer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1526302248u, "Spinny RGB Circle") {
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1502721219u, Status.Incompatible }, // [Deprecated] Spinny Red Circle
                },
            });

            Add(new Item(1523608557u, "American Sign Replacer") {
                Flags = ItemFlags.SourceUnavailable,
            });

            // editor mod
            Add(new Item(1518485094u, "Mesh Import Rotation Tangents Fix") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1502721219u, "[Deprecated] Spinny Red Circle") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1526302248u, Status.Incompatible }, // Spinny RGB Circle
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

            Add(new Item(1485051886u, "Cimtographer - rebuild for 1.10.1-f3") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs
                      | ItemFlags.Unreliable,
                SourceURL = "https://github.com/rdiekema/Cities-Skylines-Mapper/commit/4bb1557b97226cd84728593799be2710bb129c19",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 416064574u, Status.Incompatible }, // Cimtographer
                },
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
                Compatibility = new Dictionary<ulong, Status>() {
                    { 793489846u, Status.Incompatible }, // Aedificium - Hotloading workshop items while you play
                },
            });

            // todo: need speed catalog as there are more of these things
            Add(new Item(1425061566u, "V10Speed") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/V10lator/V10Speed",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412292157u, Status.Incompatible }, // More Simulation Speed Options
                    // real time, and other speed sliders
                },
            });

            // todo: chk compat with feature unlockers
            Add(new Item(1424264814u, "YAFU - Yet Another Feature Unlocker") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Celisuis/YAFU",
            });

            Add(new Item(1420955187u, "Real Time") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/dymanoid/RealTime",
            });

            Add(new Item(1415090282u, "AutoLineColor Redux") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/taradinoc/CitiesSkylinesAutoColorMod",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
            });

            Add(new Item(1410003347u, "Additive Shader") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/ronyx69/41d2368485b4eea89958c368fab878b8",
            });

            // editor tool
            Add(new Item(1406275125u, "Asset DLC flags Editor") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1394468624u, "Advanced Stop Selection (ex MTSE)") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ImprovedStopSelection",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 442957897u, Status.Incompatible }, // [Obsolete] Multi-Track Station Enabler
                    { 532863263u, Status.Incompatible }, // [deprecated] Multi-Track Station Enabler 1.2.0
                    // todo: t++
                },
            });

            // editor
            Add(new Item(1393831156u, "Sub Mesh Flags") {
                Flags = ItemFlags.SourceUnavailable,
            });

            // require dlc: park life
            Add(new Item(1393452031u, "Parkify") {
                Flags = ItemFlags.SourceUnavailable,
            });

            AddDodgey(1391679732u, "CS-RP");

            Add(new Item(1386697922u, "Garbage Bin Controller") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.MinorBugs, // LSM skipping vanilla garbage bin = game breaks
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1390252175u, Status.Recommended }, // Japanese Plastic Bucket
                    { 1389908178u, Status.Recommended }, // Wheelie Bin - Color Variation
                    { 1386088603u, Status.Recommended }, // Metal bin - 01
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
                SourceURL = "https://github.com/SETNAHQ/Shicho",
                // tood: big list of incompatibilities
            });

            AddDodgey(1379361024u, "bd96432_mod_2"); // likely a translation mod

            // editor mod
            Add(new Item(1364044386u, "Theme Editor Maps") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TPBCS/ThemeEditorMaps",
                Authors = "TPB",
            });

            // editor mod
            Add(new Item(1361644472u, "Precise Prop Positioning for Asset Creators") {
                Flags = ItemFlags.SourceUnavailable,
                Authors = "TPB",
            });

            Add(new Item(1348627392u, "Tides") {
                Authors = "TPB",
                Flags = ItemFlags.SourceUnavailable,
                // possibly incompat with rainfall / other water mods?
            });

            // opposite of no abandonment lol
            Add(new Item(1330378440u, "Building States") {
                Authors = "CoarzFlovv",
                Flags = ItemFlags.SourceUnavailable,
            });



            Add(new Item(1324539315u, "Land Ships") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-LandShips",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 707759735u, Status.Recommended }, // Ship Path Anarchy
                },
            });

            // todo: move to translations;
            Add(new Item(1322787091u, "Addresses & Names Mod 2.0.1") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1231957400u, Status.Incompatible }, // Custom Namelists
                },
                SourceURL = "https://github.com/klyte45/AddressesMod",
            });

            Add(new Item(1320575938u, "Hide Traffic Lights") {
                Authors = "Simon Ryr",
                Affect = Factor.TrafficLights,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/simon56modder/5fa6c13f751ec97add408ed8c6312ac9",
            });



            Add(new Item(1312767991u, "Transport Lines Manager 13.1") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                    // incompatible:
                    // ipt2
                    // svs - svc vehicle sel
                    // more vehicles
                },
                SourceURL = "https://github.com/klyte45/TransportLinesManager",
            });

            Add(new Item(1312735149u, "Klyte Commons") {
                Authors = "Klyte45",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/klyte45/KlyteCommons",
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
                Compatibility = new Dictionary<ulong, Status>() {
                    // COMPATIBLE:
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

                    { 586012417u, Status.Incompatible }, // Ploppable RICO
                    // RICO Revisited?
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/targettius/cs-hex-colors",
            });

            Add(new Item(1274199764u, "Network Tiling") {
                Authors = "Ronyx69",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/ronyx69/4f06181c8082188418cd0c224f630a09",
            });

            Add(new Item(1269478692u, "Trains stop on both sides of the station") {
                Authors = "Jaddy",
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // some users report crashes or that it doesn't work
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1394468624u, Status.Incompatible }, // Advanced Stop Selection
                    // MTSE etc.
                },
                ReplaceWith = 1394468624u, // Advanced Stop Selection
            });

            Add(new Item(1263262833u, "Pollution Solution") {
                Authors = "Shadow Link",
                Affect = Factor.Pollution,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                SourceURL = "https://github.com/rkanter/PollutionSolution/",
            });

            Add(new Item(1242879105u, "Unlock Any Milestone") {
                Authors = "Ilion",
                Affect = Factor.Milestones,
                Flags = ItemFlags.Abandonware // author suggests to use "Extended Game Options" mod
                      //| ItemFlags.Obsolete (still works according to comments)
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 410614868u, Status.Incompatible }, // EarlyUnlock
                    { 407162294u, Status.Incompatible }, // All basic unlocks at the start
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
                Affect = Factor.Budget,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                SourceURL = "https://github.com/wboler05/CS-BudgetController",
            });

            // Several reported issues with this mod (based on user comment):
            // * laggy (multiple users are reporting this - lots of code running on recurring events!)
            // * milestone unlock not working
            // * achievement enabler not working
            Add(new Item(1237383751u, "Extended Game Options") {
                Authors = "Zenya",
                Affect = Factor.Milestones, // will be more
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 823348129u , Status.Incompatible }, // Disasters Enabler
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                    // todo: will be more
                },
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Extended-Game-Options",
            });

            // refund full construction cost when bulldozing
            Add(new Item(1227735337u, "Full Refund Cost[Industries Compatible]") {
                Authors = "C#",
                Flags = ItemFlags.SourceUnavailable,
                // todo check conflict with other refund mods
            });

            // Completely redundant mod as vanilla has auto-save
            Add(new Item(1225712349u, "406123642") {
                Authors = "丿CK独狼灬",
                CloneOf = 406123642u, // AutoSave - Configurable
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 406123642u, Status.Incompatible }, // AutoSave - Configurable
                },
                Locale = "zh-cn",
            });



            // Based on user comments some major bugs with this:
            // * Causes problems with route creation
            // * Often adds too many vehicles (even after waiting for it to settle after few day/night cycles)
            Add(new Item(1218121337u, "Automatic Vehicle Numbers Adjuster") {
                Authors = "Overhatted",
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // incompat: likely IPT, TLM and maybe others
                },
                SourceURL = "https://cld.pt/dl/download/0d0cc60b-6568-4618-90f5-ed687b9d8eed/AutomaticVehicleNumbersAdjuster.zip",
            });

            Add(new Item(1217239330u, "Profitable Offices") {
                Authors = "Mrnr1",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // possible conflict with 550479679u (eg. duplicate assembly name)
                },
                SourceURL = "https://github.com/mrnr1/CS-Profitable-Offices/",
            });

            // https://github.com/pcfantasy/RealCity/blob/master/Resources/incompatible_mods.txt
            // https://steamcommunity.com/workshop/filedetails/discussion/1192503086/1488866180603720344/
            Add(new Item(1192503086u, "Real City V9.0.03.14") {
                Authors = "pcfantasy, Singlewolf",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1674732053u, Status.Compatible   }, // Employ Overeducated Workers V2 (1.11+)
                    { 1637663252u, Status.Compatible   }, // TM:PE V11 STABLE
                    { 1562650024u, Status.Incompatible }, // Rebalanced Industries
                    { 1435741602u, Status.Incompatible }, // Snooper
                    { 1181352643u, Status.Incompatible }, // District Service Limit 3.0
                    { 1114249433u, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 1072157697u, Status.Incompatible }, // Cargo Info
                    { 569008960u , Status.Incompatible }, // Employ Overeducated Workers
                    { 519781146u , Status.Incompatible }, // Difficulty Tuning
                    { 409240984u , Status.Incompatible }, // Difficulty Options
                    // todo: minor incompat - list money mods here
                    { 1553517176u, Status.MinorIssues  }, // Specialized Industry Fix Redux
                    { 702070768u , Status.MinorIssues  }, // Export Electricity
                },
                Affect = Factor.Employment
                       | Factor.Money,
                Flags = ItemFlags.Laggy // causes lag on big cities
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "ru", "zh", "zh-cn" }, // https://github.com/pcfantasy/RealCity/blob/master/Resources
                Locale = "en",
                SourceURL = "https://github.com/pcfantasy/RealCity/",
            });

            Add(new Item(1192250578u, "Emergency Lights Manager") {
                Authors = "Cryptkeeper",
                ContinuationOf = 863909323u, // Emergency Lights Changer Plus
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 863909323u, Status.Incompatible }, // Emergency Lights Changer Plus
                    { 559172768u, Status.Incompatible }, // Emergency Light Changer
                },
            });

            Add(new Item(1182174575u, "Export Vehicles Positions") {
                Authors = "Simon Ryr",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/simon56modder/78b3ecab27b7829017f327baf0f9652c",
            });

            Add(new Item(1181352643u, "District Service Limit 3.0") {
                Authors = "cambrium",
                Affect = Factor.ServiceLimit,
                ContinuationOf = 649522495u, // District Service Limit
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo - incompat
                },
                SourceURL = "https://github.com/TheDogKSP/cs-districts",
            });

            // Similar thing to Klyte's addresses mod
            Add(new Item(1179846541u, "Rename buildings") {
                Authors = "Romanoza",
                Affect = Factor.Addresses,
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo: incompat - klyte addresses, possibly also customize it extended, and custom name lists
                },
            });

            Add(new Item(1176756723u, "Increased Pollution Radius") {
                Authors = "BloodyPenguin",
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo - incompat: pollution remover mods, but only those that actually remove pollution (eg. pollution solution)
                },
                SourceURL = "https://github.com/bloodypenguin/Skylines-IncreasedPollutionRadius",
            });

            Add(new Item(1174585364u, "Rescue Fullwidth Digits") {
                Authors = "Gansaku",
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1147015481u, "No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets") {
                Authors = "Madgemade",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 812125426u , Status.Compatible   }, // Network Extensions 2
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                },
                Flags = ItemFlags.SlowLoad
                      | ItemFlags.SourceUnavailable,
            });

            // "Repeated construction of landmark buildings"
            // An unaltered clone of Not So Unique Buildings
            // It's not even translated!
            Add(new Item(1137224650u, "重复建设地标建筑") {
                Authors = "回忆时光℡",
                CloneOf = 466834228u, // Not So Unique Buildings
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 466834228u, Status.Incompatible }, // Not So Unique Buildings
                },
            });

            Add(new Item(1128766708u, "Remove Road Textures - Blank Roads") {
                Authors = "Madgemade",
                Affect = Factor.RoadMarkings,
                Flags = ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1939169189u, Status.Incompatible }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u, Status.Incompatible }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 1147015481u, Status.Incompatible }, // No Crosswalks - Remove Crosswalks/Crossings - Including Road Assets
                },
            });

            Add(new Item(1122189715u, "Realtime") {
                Authors = "Ronyx69, Simon Ryr",
                Flags = ItemFlags.EditorMod // it's not really, but this will flag it for attention of asset creators
                      | ItemFlags.SourceAvailable,
                // todo: possibly assembly nane conflict with Real Time mod by dymanoid
                SourceURL = "https://gist.github.com/ronyx69/280e5695b3caeac7ef8b356cc36e0a7c",
            });

            Add(new Item(1117087491u, "Remove Road Props") {
                Authors = "Simon Ryr",
                Affect = Factor.HideRemove,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 690066392u, Status.Incompatible }, // American RoadSigns v2.2.0
                    // anything else that removes road props
                },
                SourceURL = "https://gist.github.com/simon56modder/e1e15b53d7ca0d4ac76cb5fbccacc279",
            });

            Add(new Item(1115699323u, "Immersive Water 0.9.0.0 (beta release)") {
                Authors = "Runaurufu",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SaveChanging // users report broken saves
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // lots of users report issues
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                SourceURL = "https://bitbucket.org/Runaurufu/cities-skylines-immersive-water/src",
            });

            Add(new Item(959894658u, "Custom Light Effects") {
                Authors = "Ronyx69, vasimr22",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // memory leaks = crashes
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1886877404u, // Custom Effects Loader
            });

            Add(new Item(958161597u, "Twitch Viewer Integrator") {
                Authors = "kiwiploetze",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable, // multiple users state it doesn't work
                Compatibility = new Dictionary<ulong, Status>() {
                    // likely conflicts with custom name lists
                    { 1865667356u, Status.Incompatible }, // Twitch Citizens
                    { 714711792u, Status.Incompatible }, // TwitchTV Viewers
                    { 414730498u, Status.Incompatible }, // Twitch Chirper Chat
                },
                ReplaceWith = 1865667356u, // Twitch Citizens
                SourceURL = "https://github.com/kiwiploetze/TwitchIntegrator",
            });

            Add(new Item(956707300u, "Remove Street Arrows") {
                Authors = "Simon Ryr",
                Affect = Factor.HideRemove,
                Flags = ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    // todo
                },
                SourceURL = "https://gist.github.com/simon56modder/161f68433ad951b3f6b10ad7c392d277",
            });

            Add(new Item(954067599u, "PropRotating Params") {
                Authors = "Ronyx69",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.EditorMod
                      | ItemFlags.Obsolete // Use instead: https://cslmodding.info/shader/proprotating/
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(952542692u, "Airport Road Light Remover") {
                Authors = "vasimr22",
                Affect = Factor.HideRemove,
                Flags = ItemFlags.SlowLoad // parses all runway assets
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // many users report crashes and other errors
                Compatibility = new Dictionary<ulong, Status>() {
                    // Hide It - incompat
                    { 953381687u, Status.Recommended }, // Basic Airport Road Light Pack
                },
            });

            // probably obsolete - custom name lists mod is much better apporach
            Add(new Item(950011274u, "Japanese Romaji Names [BETA]") {
                Authors = "Homusubi",
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 935350530u, Status.Required }, // CSL Custom Names [1.0.0]
                },
                Locale = "ja",
            });

            Add(new Item(949061920u, "No Buoys Mod") {
                Authors = "noob_vl",
                Affect = Factor.HideRemove,
                Flags = ItemFlags.SourceAvailable,
                Languages = new[] { "en", "pl" },
                SourceURL = "https://github.com/vonLeebpl/NoBuoysMod/tree/master/NoBuoysMod",
            });

            // https://cslmodding.info/shader/animuv/
            Add(new Item(940299505u, "AnimUV Params") {
                Authors = "Ronyx69",
                Flags = ItemFlags.SourceUnavailable,
            });
        }
    }
}
