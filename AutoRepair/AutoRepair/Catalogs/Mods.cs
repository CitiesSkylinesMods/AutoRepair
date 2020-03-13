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


            Add(new Item(2018193885u, "Sequence Logger") {
                Flags = ItemFlags.Verified,
            });

            Add(new Item(2016920607u, "RICO revisited") {
                Flags = ItemFlags.Verified,
                IncompatibleMods = new List<ulong>() {
                    { 586012417u }, // Ploppable RICO (original)
                },
            });

            Add(new Item(2013398705u, "Duplicate Assembly Scanner (DAS)") {
                Flags = ItemFlags.Verified,
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

            Add(1994342199u, "Eco Stats Mod");

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

            Add(1956926733u, "Asset Information"); // asset counter

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
                SourceCode = "https://github.com/chronofanz/EnhancedDistrictServices",
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

            // todo: incompat with v1
            Add(new Item(1899640536u, "Theme Mixer 2") {
                Flags = ItemFlags.Verified,
                IncompatibleMods = {
                    { 775021554u }, // Theme Mixer (original version)
                    { 574674741u }, // Terrain Themes Mod
                },
            });

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

            // todo: likely incompat with ultimate eyecandy
            Add(1883101331u, "Persistent Fog Adjuster");

            // likely game breaking automatic bulldoze lang clone
            AddDodgey(1875698406u, "406132323");

            // breaks if C:\Temp folder does not exist
            // likely incompatible with Linux and Mac
            Add(1875697177u, "Integrator: Log Generator");

            // todo, incompat with similar mods
            Add(1875298330u, "Extended Building Info");

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

            Add(new Item(1844442251u, "Fine Road Tool 2.0.3") {
                Flags = ItemFlags.Verified,
                ConflictsWith = ConflictGroups.FineRoadAnarchy | ConflictGroups.FineRoadTool,
                CompatibleWith = new List<ulong> {
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 1831805509u }, // Dynamic Text Props
                    { 1393797695u }, // Touch This Tool
                },
            });

            Add(new Item(1844440354u, "Fine Road Anarchy 2") {
                Flags = ItemFlags.Verified,
                ConflictsWith = ConflictGroups.FineRoadAnarchy | ConflictGroups.FineRoadTool,
                CompatibleWith = new List<ulong> {
                    { 1844442251u }, // Fine Road Tool 2
                    { 1831805509u }, // Dynamic Text Props
                    { 1393797695u }, // Touch This Tool
                },
            });

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


            // todo: prolly incompat with first person camera mods
            Add(1828737770u, "StereoscopicView");

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

            Add(new Item(1818482110u, "Change Loading Image 2") {
                IncompatibleMods = {
                    { 431125814u }, // ChangeLoadingImage (original version)
                },
            });

            // todo: prolly incompat with AVO mod?
            Add(new Item(1818462177u, "Vehicle Color Expander") {
                IncompatibleMods = new List<ulong>() {
                    { 442167376u }, // Advanced Vehicle Options (AVO)
                    { 1548831935u }, // Advanced Vehicle Options AVO (Industries DLC ready)
                },
            });

            // todo: prolly breaks TM:PE
            // todo: requires Industries DLC
            Add(1816571194u, "No Industries Import");

            // Bundle of Chinese localised mods
            Add(new Item(1812384654u, string.Empty) {
                Flags = ItemFlags.GameBreaking
                      | ItemFlags.Abandonware,
            });

            Add(new Item(1812157090u, "[NL] Dutch Traffic Lights") {
                ConflictsWith = ConflictGroups.TrafficLights,
            });

            // todo: prolly incompat with painter mod?
            Add(1808439336u, "Building Color Expander");

            // todo: incompat with Plop the Growables?
            Add(1806881627u, "Altering History Fix"); // fix bug with historic building despawning

            Add(new Item(1806759255u, "Customize It Extended") {
                Flags = ItemFlags.Verified,
                IncompatibleMods = new List<ulong>() {
                    { 1369729955u }, // Customize It (original mod)
                },
            });

            Add(new Item(1804882663u, "Monitor It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.Abandonware,
            });

            Add(new Item(1803209875u, "Trees' Respiration 1.0.1") {
                ConflictsWith = ConflictGroups.TMPE,
            });

            Add(1801953480u, "Natural Disasters Overhaul");

            Add(1800844556u, "Zone Mixer 0 (Beta)");

            Add(new Item(1799667916u, "UX Mod - OSD & Keybinds") {
                Flags = ItemFlags.Obsolete,
            });

            Add(new Item(1794015399u, "Render It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                ConflictsWith = ConflictGroups.PostProcessFX,
            });

            Add(new Item(1789133988u, "Route Shields for PO") {
                RequiredMods = new List<ulong>() {
                    { 1094334744u }, // Procedural Objects
                },
            });

            AddDodgey(1787941751u, "交通"); // "traffic" ?!

            Add(new Item(1785774902u, "Transfer Info (beta)") {
                IncompatibleMods = new List<ulong>() {
                    { 1072157697u }, // Cargo Info (original)
                    { 1739993783u }, // Cargo Info (Fix)
                },
            });

            Add(new Item(1783307723u, "Zone It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                ConflictsWith = ConflictGroups.Zoning,
            });

            Add(new Item(1782814610u, "Building Variations") {
                Flags = ItemFlags.Verified,
            });

            Add(new Item(1777173984u, "Broken Nodes Detector") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
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

            // todo: check if source still obfu
            Add(new Item(1760945529u, "Terrain Level Of Detail (TLOD)") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                RequiredMods = new List<ulong>() {
                    { 1680642819u }, // Ultimate Level Of Detail (ULOD)
                },
            });

            // possibly a locaised version?
            Add(new Item(1759514242u, "639486063 Automatic Bulldoze v2") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Abandonware,
                ConflictsWith = ConflictGroups.AutoBulldoze,
            });

            Add(new Item(1759269367u, "CrazyTouristFix") {
                Flags = ItemFlags.SourceAvailable,
            });

            Add(new Item(1758376843u, "Network Skins 2 (Beta)") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 543722850u }, // Network Skins (original)
                    { 1440928803u }, // Parallel Road Tool
                    { 1400711138u }, // [BETA] Parallel Road Tool
                },
            });

            // todo: check if source still obfu
            Add(new Item(1756787990u, "More Advanced InfoViews") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1756089251u, "Zoom It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
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

            Add(new Item(1739993783u, "Cargo Info (Fix)") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                IncompatibleMods = new List<ulong>() {
                    { 1785774902u }, // Transfer Info (beta)
                    { 1072157697u }, // Cargo Info (original version)
                },
                ReplaceWith = 1785774902u, // Transfer Info (beta)
            });

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

            // todo: check if source still obfu
            Add(new Item(1733593614u, "Immediate Continue") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1729576238u, "Date Changer") {
                Flags = ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong> {
                    { 1420955187u }, // Real Time (original)
                    { 1749971558u }, // Real Time Offline
                },
            });

            // todo: warn about network traffic
            Add(new Item(1725845818u, "Mayor´s report for android") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
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

            Add(new Item(1721824249u, "Joystick Camera Control") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/RenaKunisaki/CSL-JoystickCameraControl",
            });

            Add(new Item(1721823173u, "NoOffScreenScroll") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/RenaKunisaki/CSL-NoOffScreenScroll",
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
                SourceCode = "https://github.com/pcfantasy/MoreOutsideInteraction",
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
                SourceCode = "https://github.com/pcfantasy/MoreEffectiveTransfer",
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

            // LOD toggler has conflicting shortcut, and is also obsoleted by ULOD
            Add(new Item(1680642819u, "Ultimate Level Of Detail (ULOD)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/boformer/UltimateLevelOfDetail",
                SuggestedMods = new List<ulong>() {
                    { 556784825u }, // Random Tree Rotation
                    { 625608461u }, // Adaptive Prop Visibility Distance
                    { 898480258u }, // Camera Positions Utility
                    { 812713438u }, // Dynamic Resolution (Fixed for 1.9!)
                },
                IncompatibleMods = new List<ulong>() {
                    { 561888259u }, // LOD Toggler (deprecated)
                },
            });

            Add(new Item(1677913611u, "Smart Intersection Builder") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/Strdate/SmartIntersections",
                RequiredMods = new List<ulong>() {
                    { 1844440354u }, // Fine Road Anarchy 2
                },
            });

            // todo: check if source still obfu
            Add(new Item(1675213439u, "No Intro") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1665106193u }, // Skip Intro
                },
            });

            Add(new Item(1674732053u, "Employ Overeducated Workers V2 (1.11+)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/pcfantasy/EmployOvereducatedWorkers-v2",
                ConflictsWith = ConflictGroups.EmployOvereducatedWorkers,
                CompatibleWith = new List<ulong>() {
                    { 1192503086u }, // Real City V9.0.03.10
                    { 1614061108u }, // Real Construction
                    { 1623509958u }, // Real Gas Station
                    { 1680840913u }, // More Effective Transfer Manager
                },
            });

            Add(new Item(1665106193u, "Skip Intro") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/DaEgi01/CitiesSkylines-SkipIntro",
                IncompatibleMods = new List<ulong>() {
                    { 1675213439u }, // No Intro
                },
            });

            Add(new Item(1664509314u, "Custom Animation Loader (CAL)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/boformer/CustomAnimationLoader",
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
                SourceCode = "https://github.com/keallu/CSL-EmptyIt",
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
                SourceCode = "https://gist.github.com/boformer/3e01770a0c86cf9273ccdcc33d9bbc42",
                IncompatibleMods = new List<ulong>() {
                    { 1403136223u }, // Control Building Level Up v0.5 (Industries)
                    { 410535198u }, // Control Building Level Up v0.4
                    { 1275678215u }, // Force Building Level
                    { 1647722503u }, // Level
                },
            });

            Add(new Item(1658679290u, "Forest Brush v1.3") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/TPBCS/ForestBrush",
                SuggestedAssets = new List<ulong>() {
                    { 1928787248u }, // Weeds
                    { 963853793u }, // Ultra low tri trees
                },
                IncompatibleMods = new List<ulong>() {
                    { 1654658173u }, // Random Tree Brush
                },
            });

            Add(new Item(1656549865u, "Rebuild It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-RebuildIt",
                ConflictsWith = ConflictGroups.AutoBulldoze,
                CompatibleWith = new List<ulong>() {
                    { 1627986403u }, // Bulldoze It!
                },
            });

            Add(new Item(1654658173u, "Random Tree Brush") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Abandonware,
                SourceCode = "https://pastebin.com/8M0gFKZh",
                IncompatibleMods = new List<ulong>() {
                    { 1658679290u }, // Forest Brush v1.3
                },
            });

            Add(new Item(1651041757u, "Auto Rocket Launch 火箭自动发射") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/mshsheng/CSL-AutoRocketLaunch",
                SuggestedMods = new List<ulong>() {
                    { 1327013919u }, // No Time For Caution
                },
            });

            Add(new Item(1651036644u, "Advanced Traffic Congestion Report") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/pcfantasy/TrafficCongestionReport",
            });

            Add(new Item(1649747813, "1649747813") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://gist.github.com/Acc3ssViolation/67c8b829db76e0a81c02ee18995abb2c",
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

            Add(new Item(1645781000u, "Elektrix's Road Tools 2.91") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1643902284u, "Watch It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-WatchIt",
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
                SourceCode = "https://github.com/klyte45/ServiceVehiclesManager",
                IncompatibleMods = new List<ulong>() {
                    { 934994075u }, // Service Vehicle Selector 2
                    { 928128676u }, // Improved Public Transport 2
                },
            });

            Add(new Item(1628521230u, "Bulldoze Everything *Campus Compatible*") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/yakka34/AutomaticBulldoze",
                ConflictsWith = ConflictGroups.AutoBulldoze,
            });

            Add(new Item(1627986403u, "Bulldoze It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-BulldozeIt",
                ConflictsWith = ConflictGroups.AutoBulldoze,
                CompatibleWith = new List<ulong>() {
                    { 1656549865u }, // Rebuild It!
                },
            });

            Add(new Item(1627469414u, "No Parking") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1625704117u, "Roundabout Builder") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/Strdate/AutomaticRoundaboutBuilder",
                RequiredMods = new List<ulong>() {
                    { 1844440354u }, // Fine Road Anarchy 2
                },
            });

            Add(new Item(1623509958u, "Real Gas Station") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/pcfantasy/RealGasStation",
                ConflictsWith = ConflictGroups.HardMode,
                IncompatibleMods = {
                    { 1072157697u }, // Cargo Info
                    { 1739993783u }, // Cargo Info (Fix)
                    { 1435741602u }, // Snooper
                },
            });

            Add(new Item(1622545887u, "Move It! 2.3.0 (Updated for Industries patch)") {
                Flags = ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.MoveIt,
                IncompatibleMods = new List<ulong>() {
                    { 1619685021u }, // Move It (current stable release)
                    { 1866239503u }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u }, // 766190099_Move_It_
                    { 1120637951u }, // [OUTDATED] Move It! Extra Filters
                    { 1856282754u }, // MoveIt 汉化版
                    { 1892174866u }, // MoveIt2.6汉化版
                },
                ReplaceWith = 1619685021u, // Move It (current stable release)
            });

            Add(new Item(1620588636u, "Safenets") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/thale5/Safenets",
            });

            Add(new Item(1619685021u, "Move It") {
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/Quboid/CS-MoveIt",
                ConflictsWith = ConflictGroups.MoveIt,
                IncompatibleMods = new List<ulong>() {
                    { 1622545887u }, // Move It! 2.3.0 (Updated for Industries patch)
                    { 1866239503u }, // MOVE IT Sakuya16个人汉化版
                    { 1857894421u }, // 766190099_Move_It_
                    { 1120637951u }, // [OUTDATED] Move It! Extra Filters
                    { 1856282754u }, // MoveIt 汉化版
                    { 1892174866u }, // MoveIt2.6汉化版
                },
                SuggestedMods = new List<ulong>() {
                    { 787611845u }, // Prop Snapping
                },
            });

            Add(new Item(1614062928u, "Unlock LandScaping") {
                Flags = ItemFlags.SourceUnavailable,
            });

            Add(new Item(1614061108u, "Real Construction") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/pcfantasy/RealConstruction",
                ConflictsWith = ConflictGroups.HardMode
                              | ConflictGroups.MoreVehicles,
                IncompatibleMods = new List<ulong>() {
                    { 1072157697u }, // Cargo Info
                    { 1739993783u }, // Cargo Info (Fix)
                    { 1764208250u }, // More Vehicles
                },
            });

            Add(new Item(1612012531u, "Net Picker 2.0") {
                Flags = ItemFlags.SourceUnavailable,
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
                ConflictsWith = ConflictGroups.HardMode,
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
                SourceCode = "https://github.com/keallu/CSL-StreamIt",
            });

            Add(new Item(1597198847u, "[Legacy] Segment Slope Smoother") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                ReplaceWith = 1645781000u, // Elektrix's Road Tools 2.91
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
                SourceCode = "https://github.com/keallu/CSL-HideIt",
                IncompatibleMods = new List<ulong>() {
                    { 666425898u }, // No Radioactive Desert And More!
                    //{ 1899640536u }. // Theme Mixer 2 (race condition between sprite show/hide)
                },
            });

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
                SourceCode = "https://pastebin.com/sDbefj5J",
                IncompatibleMods = new List<ulong>() {
                    { 457516262u }, // Rail Track Speed Increaser 2.2.1
                },
            });

            // Might cause issues with TM:PE - short segments entering junctions causes AI issues
            Add(new Item(1586027591u, "Tiny Segments") {
                Flags = ItemFlags.SourceUnavailable,
                RequiredMods = {
                    { 1844440354u }, // Fine Road Anarchy 2
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
                SourceCode = "https://github.com/keallu/CSL-ResizeIt",
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

            Add(new Item(1567569285u, "Achieve It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-AchieveIt",
                IncompatibleMods = new List<ulong>() {
                    // todo: achievements mods
                },
            });

            Add(new Item(1562650024u, "Rebalanced Industries") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/Quboid/CSL_RebalancedIndustries",
                IncompatibleMods = new List<ulong>() {
                    { 1369729955u }, // Customize It!
                },
                CompatibleWith = new List<ulong>() {
                    { 1806759255u }, // Customize It Extended
                },
            });

            AddDodgey(1559479494u, "MyTheme");
            AddDodgey(1558675585u, "MyTheme");

            Add(new Item(1556715327u, "Show It!") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCode = "https://github.com/keallu/CSL-ShowIt",
                IncompatibleMods = new List<ulong>() {
                    // todo: building info mods
                },
            });

            AddDodgey(1555378173u, "410344523"); // translated pop balance mod?

            Add(new Item(1553517176u, "Specialized Industry Fix Redux") {
                Flags = ItemFlags.Obsolete
                      | ItemFlags.GameBreaking // broken since Industries DLC
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable,
                SourceCode = "https://github.com/Vectorial1024/SpecializedIndustryFixRedux",
                IncompatibleMods = new List<ulong>() {
                    { 662386761u }, // Specialised Industry Fix [BUGFIX for Vanilla]
                    { 1562650024u }, // Rebalanced Industries
                },
                ReplaceWith = 1562650024u, // Rebalanced Industries
            });

            // todo: also works in editor
            Add(new Item(1552053911u, "TrailerVariation Loader") {
                Flags = ItemFlags.SourceAvailable,
                SourceCode = "https://gist.github.com/Acc3ssViolation/a129c802e7e2eaeb2ef566a0f370afc0",
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

            // todo: create catalog + conflict group for traffic lights
            Add(new Item(1550720600u, "New American Traffic Lights - NYC/NJ Style") {
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompatible mods
            });

            AddDodgey(1550281302u, "TransportCapacity");

            // todo: might have more conflicts
            Add(new Item(1548831935u, "Advanced Vehicle Options AVO (Industries DLC ready)") {
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // https://github.com/CityGecko/CS-AdvancedVehicleOptions/issues
                SourceCode = "https://github.com/CityGecko/CS-AdvancedVehicleOptions",
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

            // todo: create catalog + conflict group for traffic lights
            Add(new Item(1548117573u, "New American Traffic Lights - Grey Style") {
                Flags = ItemFlags.SourceUnavailable,
                // todo: incompatible mods
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


        }
    }
}
