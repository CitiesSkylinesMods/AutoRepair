namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that hide or remove stuff.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void HideRemoveMods() {

            string catalog = "HideRemove";

            AddMod(new Review(2062449491uL, "No Vanilla Citizens") {
                Affect = Factor.Other,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("15 Apr, 2020"),
                Updated = WorkshopDate("15 Apr, 2020"),
            });

            AddMod(new Review(1962752152uL, "Busstop Prop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "PC28K",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // similar mods:
                    { 1962752152uL, Status.Incompatible }, // Busstop Prop Remover
                    { 1591417160uL, Status.MinorIssues  }, // Hide It (has same feature)
                    { 919020932uL , Status.Incompatible }, // Stop Remover
                    // compat with tmpe:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // bus stop skins
                    { 1900151000uL, Status.Incompatible }, // 替换为不锈钢公交候车亭
                    { 545878277uL , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                    // traffic light skins - junctions
                    { 1812157090uL, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682uL, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095uL, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552uL, Status.Compatible   }, // Horizontal Traffic Lights
                    { 890420060uL , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987uL , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    { 810355214uL , Status.Compatible   }, // Japanese Traffic Lights (RHT)
                    { 809633246uL , Status.Compatible   }, // Japanese Traffic Lights (LHT)
                    // traffic light skins - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Settings take effect during loading. Once game is loaded, changing settings has no effect, you will need to reload game." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove transport stop props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("7 Jan, 2020"),
                Updated = WorkshopDate("26 Mar, 2020"),
            });

            AddMod(new Review(1764637396uL, "Toggle It!") {
                Affect = Factor.HideRemove,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Toggle it covers functionality of these mods:
                    { 1756787990uL, Status.Incompatible }, // More Advanced InfoViews
                    { 1540147921uL, Status.MinorIssues  }, // Grid be Gone
                    { 1536223783uL, Status.MinorIssues  }, // Hide Selectors
                    { 917543381uL , Status.MinorIssues  }, // No Problem Notifications
                    { 903347963uL , Status.Incompatible }, // Transparent Selectors
                    { 877748783uL , Status.MinorIssues  }, // Topographic Lines Toggle
                    { 592076973uL , Status.MinorIssues  }, // Zoning toolset (toggle + upgrade tool)
                    { 561293123uL , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                    { 553319260uL , Status.MinorIssues  }, // Hide Border Line and Asset Editor Grid
                    { 507225392uL , Status.MinorIssues  }, // Topographic Info View
                    { 465318661uL , Status.Incompatible }, // Toggleable Whiteness
                    { 451193058uL , Status.Incompatible }, // The Original Hide Policy Icons
                    { 443904654uL , Status.Incompatible }, // Zoning and Districts Co-viewer
                    { 439360165uL , Status.Incompatible }, // mabako's Hide District Policy Icons Mod
                    { 437716646uL , Status.MinorIssues  }, // Cities Atlas
                    { 433557907uL , Status.Incompatible }, // District UI Tweaks: Hide Names
                    { 421443866uL , Status.Incompatible }, // Zone Colours
                    { 410842044uL , Status.Incompatible }, // Persistent Resource View
                    // other mods
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1540147921uL, "[Mod: Grid be Gone] If you toggle zoning grid/color with both mods, they both get confused." },
                    { 1536223783uL, "[Mod: Hide Selectors] If you toggle selectors with both mods, they both get confused." },
                    { 877748783u , "[Mod: Topographic Lines Toggle] Both mods can toggle topographic lines; use one and unsubscribe the other." },
                },
                Published = WorkshopDate("8 Jun, 2019"),
                SourceURL = "https://github.com/keallu/CSL-ToggleIt",
                Updated = WorkshopDate("28 Jun, 2019"),
            });

            AddMod(new Review(1706704781uL, "Remove All Animals") {
                Affect = Factor.HideRemove,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706704781uL, Status.Incompatible }, // Remove All Animals
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 587536931uL , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 564141599uL , Status.Incompatible }, // No Seagulls
                    { 421041154uL , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328uL , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove animals. Use one, unsubscribe the other." },
                    { 564141599u , "[Mod: Remove Seagulls] Both mods can remove seagulls. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("8 Apr, 2019"),
                SourceURL = "https://github.com/pcfantasy/RemoveAllAnimals",
                Updated = WorkshopDate("23 Feb, 2020"),
            });

            AddMod(new Review(1627469414uL, "No Parking") {
                Affect = Factor.HideRemove
                       | Factor.TransportPreference,
                Authors = "this is literally me",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // compat with tmpe:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // other:
                    { 600733054uL , Status.Compatible   }, // No On-Street Parking
                    { 1285201733uL, Status.Recommended  }, // Parking Lot Roads
                    { 853655964uL , Status.Recommended  }, // Standard Parking Garage
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some users report that it's only removing parking from some, not all, vanilla buildings." },
                },
                Published = WorkshopDate("17 Jan, 2019"),
                Updated = WorkshopDate("17 Jan, 2019"),
            });

            AddMod(new Review(1591417160uL, "Hide It!") {
                Affect = Factor.HideRemove
                       | Factor.Props
                       | Factor.Textures,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // network props/decals
                    { 2092856384uL, Status.Compatible   }, // Japanese Road Arrows
                    { 2009708489uL, Status.MinorIssues  }, // Road Arrows Replacer [Spain]
                    { 1962752152uL, Status.MinorIssues  }, // Busstop Prop Remover
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                    { 1117087491uL, Status.MinorIssues  }, // Remove Road Props
                    { 956707300uL , Status.MinorIssues  }, // Remove Street Arrows
                    { 952542692uL , Status.MinorIssues  }, // Airport Road Light Remover
                    { 949061920uL , Status.MinorIssues  }, // No Buoys Mod
                    { 919020932uL , Status.MinorIssues  }, // Stop Remover
                    { 418637762uL , Status.MinorIssues  }, // American Roads
                    // terrain sprites
                    { 1899640536uL, Status.MinorIssues  }, // Theme Mixer 2 (both can toggle terrain sprites)
                    { 1445375997uL, Status.Incompatible }, // Theme Mixer 汉化版2的
                    { 548149310uL , Status.MinorIssues  }, // Remove Dirt (Trees and Props)
                    { 417593730uL , Status.MinorIssues  }, // No Tree Dirt
                    // pollution
                    { 666425898uL , Status.Incompatible }, // No Radioactive Desert And More!
                    // animals
                    { 1706704781uL, Status.MinorIssues  }, // Remove All Animals
                    { 587536931uL , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 564141599uL , Status.MinorIssues  }, // No Seagulls
                    { 421041154uL , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328uL , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                    // chirper
                    { 2053655383uL, Status.MinorIssues  }, // Pretty Pixel's Trump Tweets
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 819797131uL , Status.MinorIssues  }, // Reddit For Chirpy: Updated
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 649147853uL , Status.MinorIssues  }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.MinorIssues  }, // ChirpBanner+
                    { 577655208uL , Status.MinorIssues  }, // 2ch for Chirpy
                    { 462946934uL , Status.MinorIssues  }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.MinorIssues  }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.MinorIssues  }, // Chirper-Nachrichten
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 414730498uL , Status.MinorIssues  }, // Twitch Chirper Chat
                    { 412019683uL , Status.MinorIssues  }, // Chitter
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 409924305uL , Status.MinorIssues  }, // SC3K Ticker
                    { 409392231uL , Status.MinorIssues  }, // SuperChirper
                    { 408705348uL , Status.MinorIssues  }, // Reddit For Chirpy
                    { 407871375uL , Status.MinorIssues  }, // ChirpFilter
                    { 406623071uL , Status.MinorIssues  }, // Chirpy Banner
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 406412894uL , Status.MinorIssues  }, // Chirpy Maid
                    { 405963579uL , Status.MinorIssues  }, // Chirper Position Changer/Mover
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // other
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1869777403uL, Status.MinorIssues  }, // TimeWarp Fix 时间光照控制 Sakuya16个人汉化
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 814698320uL , Status.MinorIssues  }, // TimeWarp Fix
                    { 524021335uL , Status.MinorIssues  }, // Time Warp
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 2009708489uL, "[Mod: Road Arrows Replacer] If you remove road arrows with Hide It, the Road Arrows Replacer can't replace them." },
                    { 1962752152uL, "[Mod: Busstop Prop Remover] Both mods can remove stops. Use one, unsubscribe the other." },
                    { 1899640536uL, "[Mod: Theme Mixer 2] Terrain sprites affected by both mods; modify sprite settings in both to ensure same effect." },
                    { 1498036881uL, "[Mod: UltimateMod] Both mods can hide chirper; for compatibility only use Hide It to do that." },
                    { 1706704781uL, "[Mod: Remove All Animals] Both mods can remove animals. Use one, unsubscribe the other." },
                    { 1117087491uL, "[Mod: Remove Road Props] Both mods can remove road props. Use one, unsubscribe the other." },
                    { 956707300uL , "[Mod: Remove Street Arrows] Both mods can remove street arrows. Use one, unsubscribe the other." },
                    { 952542692uL , "[Mod: Airport Road Light Remover] Both mods can remove runway/taxiway lights. Use one, unsubscribe the other." },
                    { 949061920uL , "[Mod: No Buoys Mod] Both mods can remove buoys. Use one, unsubscribe the other." },
                    { 919020932uL , "[Mod: Stop Remover] Both mods can remove stops. Use one, unsubscribe the other." },
                    { 819797131uL , "[Mod: Reddit for Chirpy] For compatibility, do not hide the 'Chirper Button' in Hide It mod." },
                    { 814698320uL , "[Mod: Time Warp] For compatibility, do not hide the 'Zoom Button' in Hide It mod." },
                    { 666425898uL , "[Mod: No Radioactive Desert] Conflcits with Hide It!; causes terrain textures to disappear from map." },
                    { 649147853uL , "[Mod: Birdcage] Both mods can hide chirper; for compatibility only use Hide It to do that." },
                    { 628399273uL , "[Mod: ChirpBanner+] Both mods can hide chirper; for compatibility only use Hide It to do that." },
                    { 564141599uL , "[Mod: No Seagulls] Both mods can remove seagulls. Use one, unsubscribe the other." },
                    { 548149310uL , "[Mod: Remove Dirt (Trees and Props)] Use Hide It instead as it's more reliable; unsubscribe Remove Dirt." },
                    { 418637762uL , "[Mod: American Roads] Both mods can remove road markings/props. Use one, unsubscribe the other." },
                    { 414730498uL , "[Mod: Twitch Chirper Chat] For compatibility, do not hide the 'Chirper Button' in Hide It mod." },
                    { 412019683uL , "[Mod: Chitter] For compatibility, do not hide the 'Chirper Button' in Hide It mod." },
                    { 409392231uL , "[Mod: SuperChirper] Both mods can hide chirper; for compatibility only use Hide It to do that." },
                },
                Published = WorkshopDate("15 Dec, 2018"),
                SourceURL = "https://github.com/keallu/CSL-HideIt",
                Updated = WorkshopDate("12 Oct, 2019"),
            });

            AddMod(new Review(1540147921uL, "Grid be Gone") {
                Affect = Factor.Other, // todo
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.MinorIssues  }, // Toggle It!
                    { 1536223783uL, Status.Recommended  }, // Hide Selectors
                    { 592076973uL , Status.Compatible   }, // Zoning Toolset (toggle + upgrade tool)
                    { 903347963uL , Status.Compatible   }, // Transparent Selectors
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Alt+G to toggle the grid display." },
                    { 1764637396uL, "[Mod: Toggle It!] If you toggle zoning grid/color with both mods, they both get confused." },
                },
                Published = WorkshopDate("15 Oct, 2018"),
                SourceURL = "https://gist.github.com/Quboid/298552b4e4787cefe7faa55cf8a6e6be",
                Updated = WorkshopDate("17 Jan, 2019"),
            });

            AddMod(new Review(1536223783uL, "Hide Selectors") {
                Affect = Factor.Other, // todo
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396uL, Status.MinorIssues  }, // Toggle It!
                    { 1540147921uL, Status.Recommended  }, // Grid be Gone
                    { 903347963uL , Status.Compatible   }, // Transparent Selectors
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Alt+H to toggle the selectors display." },
                    { 1764637396uL, "[Mod: Toggle It!] If you toggle slectors with both mods, they both get confused." },
                },
                Published = WorkshopDate("11 Oct, 2018"),
                SourceURL = "https://gist.github.com/Quboid/628b69e5f778c57a29cbcc8877e0cd59",
                Updated = WorkshopDate("31 Mar, 2019"),
            });

            // doesn't affect level crossings
            AddMod(new Review(1320575938uL, "Hide Traffic Lights") {
                Authors = "Simon Ryr",
                Affect = Factor.HideRemove
                       | Factor.Props
                       | Factor.TrafficLights,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // compat with hide it (hide it doesn't affect traffic lights)
                    { 1591417160uL, Status.Compatible   }, // Hide It!
                    // compat with tmpe:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // traffic light - junctions
                    { 1812157090uL, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682uL, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095uL, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552uL, Status.Incompatible }, // Horizontal Traffic Lights
                    { 890420060uL , Status.Incompatible }, // S. Korea Traffic Lights (LHT)
                    { 888671987uL , Status.Incompatible }, // S. Korea Traffic Lights (RHT)
                    { 810355214uL , Status.Incompatible }, // Japanese Traffic Lights (RHT)
                    { 809633246uL , Status.Incompatible }, // Japanese Traffic Lights (LHT)
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // iterates props in all networks PER TRAFFIC LIGHT PROP!
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Only hides the vanilla traffic light props; vehicles will still act as if traffic lights are present." },
                    { NOTE, "Props are only removed when city is loaded, changing settings in game has no effect." },
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the traffic light props via its 'skip.txt' = much faster." },
                },
                Published = WorkshopDate("4 Mar, 2018"),
                SourceURL = "https://gist.github.com/simon56modder/5fa6c13f751ec97add408ed8c6312ac9",
                Updated = WorkshopDate("4 Mar, 2018"),
            });

            AddMod(new Review(1117087491uL, "Remove Road Props") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other mods that can hide road props:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1117087491uL, Status.Incompatible }, // Remove Road Props
                    { 690066392uL , Status.MinorIssues  }, // American RoadSigns v2.2.0
                    { 418637762uL , Status.Incompatible }, // American Roads
                    // traffic light - level crossings:
                    { 1519049273uL, Status.MinorIssues }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.MinorIssues }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // iterates props in all networks PER PROP!
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the props via its 'skip.txt' = much faster." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove road props. Use one, remove the other." },
                    { 1519049273uL, "[Mod: American Railroad Signal Replacer] If you remove railway barriers, they can't be replaced." },
                    { 1249000709uL, "[Mod: Japanese Railway Crossings] If you remove railway barriers, they can't be replaced." },
                    { 690066392u , "[Mod: American RoadSigns] Both mods can remove road props. Use one, remove the other." },
                },
                Published = WorkshopDate("21 Aug, 2017"),
                SourceURL = "https://gist.github.com/simon56modder/e1e15b53d7ca0d4ac76cb5fbccacc279",
                Updated = WorkshopDate("3 Feb, 2019"),
            });

            AddMod(new Review(956707300uL, "Remove Street Arrows") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2092856384uL, Status.Incompatible }, // Japanese Road Arrows
                    { 2009708489uL, Status.Incompatible }, // Road Arrows Replacer [Spain]
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 956707300uL , Status.Incompatible }, // Remove Street Arrows
                    // compat with tmpe:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // iterates all props in all networks PER ARROW TYPE!
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "It hides vanilla game street arrows (on any road), it won't hide custom street arrows." },
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the arrows (props) via its 'skip.txt' = much faster." },
                    { 2009708489uL, "[Mod: Road Arrows Replacer] Won't be able to replace arrows if they are already removed by Remove Street Arrows." },
                    { 1806963141uL, "[Mod: TM:PE] Compatible: Vehicles will still respect the street arrows even if not visible." },
                    { 1637663252uL, "[Mod: TM:PE] Compatible: Vehicles will still respect the street arrows even if not visible." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove street arrows. Use one, remove the other." },
                },
                Published = WorkshopDate("27 Jun, 2017"),
                SourceURL = "https://gist.github.com/simon56modder/161f68433ad951b3f6b10ad7c392d277",
                Updated = WorkshopDate("27 Jun, 2017"),
            });

            AddMod(new Review(952542692uL, "Airport Road Light Remover") {
                Affect = Factor.HideRemove,
                Authors = "vasimr22",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 953381687uL , Status.Recommended  }, // Basic Airport Road Light Pack
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // parses all runway assets
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // many users report crashes and other errors
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the lights (props) via its 'skip.txt' = much faster." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove runway/taxiway lights. Use one, remove the other." },
                },
                Published = WorkshopDate("22 Jun, 2017"),
                Updated = WorkshopDate("22 Jun, 2017"),
            });

            AddMod(new Review(949061920uL, "No Buoys Mod") {
                Affect = Factor.HideRemove,
                Authors = "noob_vl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "pl" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Buoys can be toggled with Ctrl+Y (shortcut can be customised in options)." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove buoys. Use one, remove the other." },
                },
                Published = WorkshopDate("17 Jun, 2017"),
                SourceURL = "https://github.com/vonLeebpl/NoBuoysMod/tree/master/NoBuoysMod",
                Updated = WorkshopDate("17 Jun, 2017"),
            });

            AddMod(new Review(934958400uL, "Improve FPS ! - Hide Districts [ALPHA]") {
                Affect = Factor.HideRemove
                       | Factor.Props
                       | Factor.Trees,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("28 May, 2017"),
                SourceURL = "https://github.com/simon56modder/HideDistrictsMod",
                Updated = WorkshopDate("28 May, 2017"),
            });

            AddMod(new Review(919020932uL, "Stop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Lost Lime, boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // similar mods:
                    { 1962752152uL, Status.Incompatible }, // Busstop Prop Remover
                    { 1591417160uL, Status.MinorIssues  }, // Hide It (has same feature)
                    { 919020932uL , Status.Incompatible }, // Stop Remover
                    // compat with tmpe:
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // bus stop skins
                    { 545878277uL , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                    // traffic light skins - junctions
                    { 1812157090uL, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600uL, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573uL, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608uL, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168uL, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682uL, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095uL, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552uL, Status.Compatible   }, // Horizontal Traffic Lights
                    { 890420060uL , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987uL , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    { 810355214uL , Status.Compatible   }, // Japanese Traffic Lights (RHT)
                    { 809633246uL , Status.Compatible   }, // Japanese Traffic Lights (LHT)
                    // traffic light skins - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove transport stop props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("4 May, 2017"),
                SourceURL = "https://gist.github.com/boformer/dfbc524d40e0e73fab5f45755ed8d9db",
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddMod(new Review(917543381uL, "No Problem Notifications") {
                Affect = Factor.HideRemove
                       | Factor.UI,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1927186256uL, Status.Unknown      }, // Problem Info
                    { 1764637396uL, Status.MinorIssues  }, // Toggle It!
                    { 769744928uL , Status.Unknown      }, // Pollution, Death, Garbage and Crime Remover Mod
                    { 561293123uL , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod doesn't remove the problems, it just hides the notifications." },
                    { NOTE, "Some notifications added in Campus and Sunset Harbor are not currently supported." },
                    { 1764637396uL, "[Mod: Toggle It!] Both mods can hide notifications and they get a bit confused when used at same time." },
                },
                Published = WorkshopDate("2 May, 2017"),
                Updated = WorkshopDate("10 Nov, 2018"),
            });

            AddMod(new Review(803074771uL, "No Deathcare") {
                Affect = Factor.HideRemove
                       | Factor.Service,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2077426488uL, Status.Incompatible }, // Super Hearse AI [Beta]
                    { 1927186256uL, Status.Unknown      }, // Problem Info
                    { 813835241uL , Status.Incompatible }, // Enhanced Hearse AI [1.6]
                    { 813833476uL , Status.Incompatible }, // Skylines Overwatch [1.6]
                    { 769744928uL , Status.Unknown      }, // Pollution, Death, Garbage and Crime Remover Mod
                    { 583556014uL , Status.Incompatible }, // Enhanced Hearse AI [Fixed for v1.4 +]
                    { 583538182uL , Status.Incompatible }, // Skylines Overwatch [Fixed for v1.3+]
                    { 433249875uL , Status.Incompatible }, // [ARIS] Enhanced Hearse AI
                    { 421028969uL , Status.Incompatible }, // [ARIS] Skylines Overwatch
                    { 413847191uL , Status.Incompatible }, // [Deprecated] SOM - Services Optimization Module
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("20 Nov, 2016"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-NoDeathcare",
                Updated = WorkshopDate("20 Nov, 2016"),
            });

            AddMod(new Review(769744928uL, "Pollution, Death, Garbage and Crime Remover Mod") {
                Affect = Factor.Other,
                Alternatives = new[] {
                    917543381uL , // No Problem Notifications
                    803074771uL , // No Deathcare
                    561293123uL , // Hide Problems AKA Politician's Mod
                },
                Authors = "doctor",
                Catalog = catalog,
                CatalogLinks = new[] { "Services", "Services.Deathcare", "Services.Garbage", "Services.Police", "Crime", "Pollution", "Environment" },
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1927186256uL, Status.Unknown      }, // Problem Info
                    { 917543381uL , Status.Unknown      }, // No Problem Notifications
                    { 803074771uL , Status.Unknown      }, // No Deathcare
                    { 561293123uL , Status.Unknown      }, // Hide Problems AKA Politician's Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Published = WorkshopDate("25 Sep, 2016"),
                SourceURL = "https://bitbucket.org/KUDr/cs-pollutionremovermod/",
                Updated = WorkshopDate("1 Oct, 2016"),
            });

            AddMod(new Review(564141599uL, "No Seagulls") {
                Affect = Factor.HideRemove,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706704781uL, Status.Incompatible }, // Remove All Animals
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 587536931uL , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 421041154uL , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328uL , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1706704781uL, "[Mod: Remove All Animals] Both mods can remove seagulls. Use one, unsubscribe the other." },
                    { 1591417160uL, "[Mod: Hide It] Both mods can remove seagulls. Use one, remove the other." },
                },
                Published = WorkshopDate("28 Nov, 2015"),
                SourceURL = "https://github.com/thale5/NoSeagulls",
                Updated = WorkshopDate("28 Aug, 2019"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(548149310uL, "Remove Dirt (Trees and Props)") {
                Affect = Factor.Environment
                       | Factor.Props
                       | Factor.Trees,
                Authors = "TPB, knighthawkGP, hyperdrive_engage",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 548149310uL , Status.Incompatible }, // Remove Dirt (Trees and Props)
                    { 417593730uL , Status.Incompatible }, // No Tree Dirt
                    // minor issues: surface painter, terraforming tools
                },
                CompatibleWith = GameVersion.Patch_1_9_3_f1,
                ContinuationOf = 417593730uL, // No Tree Dirt
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] Both mods can hide tree dirt; Hide It is more reliable (no 'array index' errors)." },
                },
                Published = WorkshopDate("4 Nov, 2015"),
                ReplaceWith = 1591417160uL, // Hide It!
                Updated = WorkshopDate("8 Nov, 2015"),
            });

            AddMod(new Review(417593730uL, "No Tree Dirt") {
                Affect = Factor.Environment
                       | Factor.Trees,
                Authors = "hyperdrive_engage",
                BrokenBy = GameVersion.Patch_1_1_1,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 548149310uL , Status.Incompatible }, // Remove Dirt (Trees and Props)
                    { 417593730uL , Status.Incompatible }, // No Tree Dirt
                },
                CompatibleWith = GameVersion.EuropeBiome,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] Both mods can hide tree dirt; Hide It is more reliable (no 'array index' errors)." },
                },
                Published = WorkshopDate("4 Nov, 2015"),
                ReplaceWith = 1591417160uL, // Hide It!
                Updated = WorkshopDate("8 Nov, 2015"),
            });

        }
    }
}