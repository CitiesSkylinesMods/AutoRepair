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
            AddDodgey(1891302387u, "自动推土机");

            AddDodgey(1891302187u, "自动推土机");

            // todo: this might be localisation of older mod, not sure
            AddDodgey(1864205702u, "地图图片叠加 Image Overlay");

            // todo: incompatible with hardmode vanilla mod
            Add(1830455071u, "EasyMode");

            // todo: requires Campus DLC
            Add(1824254667u, "Campus Parks");

            // todo: prolly breaks TM:PE
            // todo: requires Industries DLC
            Add(1816571194u, "No Industries Import");

            AddDodgey(1787941751u, "交通"); // "traffic" ?!

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

            Add(new Item(1689984220u, "Electric Roads Mod 1.2.3") {
                Flags = ItemFlags.SourceUnavailable,
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

            Add(new Item(1415090282u, "AutoLineColor Redux") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/taradinoc/CitiesSkylinesAutoColorMod",
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1415090282u, Status.Incompatible }, // AutoLineColor Redux
                    { 408760323u , Status.Incompatible }, // Auto Line Color
                },
            });



            // editor tool
            Add(new Item(1406275125u, "Asset DLC flags Editor") {
                Flags = ItemFlags.SourceUnavailable,
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

            Add(new Item(1182174575u, "Export Vehicles Positions") {
                Authors = "Simon Ryr",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://gist.github.com/simon56modder/78b3ecab27b7829017f327baf0f9652c",
            });



            // Similar thing to Klyte's addresses mod
            Add(new Item(1179846541u, "Rename buildings") {
                Authors = "Romanoza",
                Affect = Factor.Naming,
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
        }
    }
}
