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

            AddMod(new Review(1962752152u, "Busstop Prop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "PC28K",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // similar mods:
                    { 1962752152u, Status.Incompatible }, // Busstop Prop Remover
                    { 1591417160u, Status.MinorIssues  }, // Hide It (has same feature)
                    { 919020932u , Status.Incompatible }, // Stop Remover
                    // compat with tmpe:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // bus stop skins
                    { 545878277u , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                    // traffic light skins - junctions
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682u, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Compatible   }, // Horizontal Traffic Lights
                    { 890420060u , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987u , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    // traffic light skins - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Settings take effect during loading. Once game is loaded, changing settings has no effect, you will need to reload game." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove transport stop props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("7 Jan, 2020"),
                Updated = WorkshopDate("26 Mar, 2020"),
            });

            AddMod(new Review(1764637396u, "Toggle It!") {
                Affect = Factor.HideRemove,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Toggle it covers functionality of these mods:
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                    { 1540147921u, Status.MinorIssues  }, // Grid be Gone
                    { 1536223783u, Status.MinorIssues  }, // Hide Selectors
                    { 917543381u , Status.MinorIssues  }, // No Problem Notifications
                    { 903347963u , Status.Incompatible }, // Transparent Selectors
                    { 877748783u , Status.Incompatible }, // Topographic Lines Toggle
                    { 592076973u , Status.MinorIssues  }, // Zoning toolset (toggle + upgrade tool)
                    { 561293123u , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                    { 553319260u , Status.MinorIssues  }, // Hide Border Line and Asset Editor Grid
                    { 507225392u , Status.MinorIssues  }, // Topographic Info View
                    { 465318661u , Status.Incompatible }, // Toggleable Whiteness
                    { 451193058u , Status.Incompatible }, // The Original Hide Policy Icons
                    { 443904654u , Status.Incompatible }, // Zoning and Districts Co-viewer
                    { 439360165u , Status.Incompatible }, // mabako's Hide District Policy Icons Mod
                    { 437716646u , Status.MinorIssues  }, // Cities Atlas
                    { 433557907u , Status.Incompatible }, // District UI Tweaks: Hide Names
                    { 421443866u , Status.Incompatible }, // Zone Colours
                    { 410842044u , Status.Incompatible }, // Persistent Resource View
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1540147921u, "[Mod: Grid be Gone] If you toggle zoning grid/color with both mods, they both get confused." },
                    { 1536223783u, "[Mod: Hide Selectors] If you toggle selectors with both mods, they both get confused." },
                },
                Published = WorkshopDate("8 Jun, 2019"),
                SourceURL = "https://github.com/keallu/CSL-ToggleIt",
                Updated = WorkshopDate("28 Jun, 2019"),
            });

            AddMod(new Review(1706704781u, "Remove All Animals") {
                Affect = Factor.HideRemove,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706704781u, Status.Incompatible }, // Remove All Animals
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 587536931u , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 564141599u , Status.Incompatible }, // No Seagulls
                    { 421041154u , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328u , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160u, "[Mod: Hide It] Both mods can remove animals. Use one, unsubscribe the other." },
                    { 564141599u , "[Mod: Remove Seagulls] Both mods can remove seagulls. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("8 Apr, 2019"),
                SourceURL = "https://github.com/pcfantasy/RemoveAllAnimals",
                Updated = WorkshopDate("23 Feb, 2020"),
            });

            AddMod(new Review(1627469414u, "No Parking") {
                Affect = Factor.HideRemove
                       | Factor.TransportPreference,
                Authors = "this is literally me",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // compat with tmpe:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // other:
                    { 600733054u , Status.Compatible   }, // No On-Street Parking
                    { 1285201733u, Status.Recommended  }, // Parking Lot Roads
                    { 853655964u , Status.Recommended  }, // Standard Parking Garage
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

            AddMod(new Review(1591417160u, "Hide It!") {
                Affect = Factor.HideRemove
                       | Factor.Props
                       | Factor.Textures,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // network props/decals
                    { 2009708489u, Status.MinorIssues  }, // Road Arrows Replacer [Spain]
                    { 1962752152u, Status.MinorIssues  }, // Busstop Prop Remover
                    { 1320575938u, Status.Compatible   }, // Hide Traffic Lights
                    { 1117087491u, Status.MinorIssues  }, // Remove Road Props
                    { 956707300u , Status.MinorIssues  }, // Remove Street Arrows
                    { 952542692u , Status.MinorIssues  }, // Airport Road Light Remover
                    { 949061920u , Status.MinorIssues  }, // No Buoys Mod
                    { 919020932u , Status.MinorIssues  }, // Stop Remover
                    { 418637762u , Status.MinorIssues  }, // American Roads
                    // terrain sprites
                    { 1899640536u, Status.MinorIssues  }, // Theme Mixer 2 (both can toggle terrain sprites)
                    { 1445375997u, Status.Incompatible }, // Theme Mixer 汉化版2的
                    // pollution
                    { 666425898u , Status.Incompatible }, // No Radioactive Desert And More!
                    // animals
                    { 1706704781 , Status.MinorIssues }, // Remove All Animals
                    { 587536931u , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 564141599u , Status.MinorIssues  }, // No Seagulls
                    { 421041154u , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328u , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                    // other
                    { 1440928803u, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138u, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1383456057u, Status.Incompatible }, // Shicho (Harmony clash)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 2009708489u, "[Mod: Road Arrows Replacer] If you remove road arrows with Hide It, the Road Arrows Replacer can't replace them." },
                    { 1962752152u, "[Mod: Busstop Prop Remover] Both mods can remove stops. Use one, unsubscribe the other." },
                    { 1899640536u, "[Mod: Theme Mixer 2] Terrain sprites affected by both mods; modify sprite settings in both to ensure same effect." },
                    { 1706704781u, "[Mod: Remove All Animals] Both mods can remove animals. Use one, unsubscribe the other." },
                    { 1117087491u, "[Mod: Remove Road Props] Both mods can remove road props. Use one, unsubscribe the other." },
                    { 956707300u , "[Mod: Remove Street Arrows] Both mods can remove street arrows. Use one, unsubscribe the other." },
                    { 952542692u , "[Mod: Airport Road Light Remover] Both mods can remove runway/taxiway lights. Use one, unsubscribe the other." },
                    { 949061920u , "[Mod: No Buoys Mod] Both mods can remove buoys. Use one, unsubscribe the other." },
                    { 919020932u , "[Mod: Stop Remover] Both mods can remove stops. Use one, unsubscribe the other." },
                    { 666425898u , "[Mod: No Radioactive Desert] Conflcits with Hide It!; causes terrain textures to disappear from map." },
                    { 564141599u , "[Mod: No Seagulls] Both mods can remove seagulls. Use one, unsubscribe the other." },
                    { 418637762u , "[Mod: American Roads] Both mods can remove road markings/props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("15 Dec, 2018"),
                SourceURL = "https://github.com/keallu/CSL-HideIt",
                Updated = WorkshopDate("12 Oct, 2019"),
            });

            AddMod(new Review(1540147921u, "Grid be Gone") {
                Affect = Factor.Other, // todo
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396u, Status.MinorIssues  }, // Toggle It!
                    { 1536223783u, Status.Recommended  }, // Hide Selectors
                    { 592076973u , Status.Compatible   }, // Zoning Toolset (toggle + upgrade tool)
                    { 903347963u , Status.Compatible   }, // Transparent Selectors
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Alt+G to toggle the grid display." },
                    { 1764637396u, "[Mod: Toggle It!] If you toggle zoning grid/color with both mods, they both get confused." },
                },
                Published = WorkshopDate("15 Oct, 2018"),
                SourceURL = "https://gist.github.com/Quboid/298552b4e4787cefe7faa55cf8a6e6be",
                Updated = WorkshopDate("17 Jan, 2019"),
            });

            AddMod(new Review(1536223783u, "Hide Selectors") {
                Affect = Factor.Other, // todo
                Authors = "Quboid",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396u, Status.MinorIssues  }, // Toggle It!
                    { 1540147921u, Status.Recommended  }, // Grid be Gone
                    { 903347963u , Status.Compatible   }, // Transparent Selectors
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Alt+H to toggle the selectors display." },
                    { 1764637396u, "[Mod: Toggle It!] If you toggle slectors with both mods, they both get confused." },
                },
                Published = WorkshopDate("11 Oct, 2018"),
                SourceURL = "https://gist.github.com/Quboid/628b69e5f778c57a29cbcc8877e0cd59",
                Updated = WorkshopDate("31 Mar, 2019"),
            });

            // doesn't affect level crossings
            AddMod(new Review(1320575938u, "Hide Traffic Lights") {
                Authors = "Simon Ryr",
                Affect = Factor.HideRemove
                       | Factor.Props
                       | Factor.TrafficLights,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // compat with hide it (hide it doesn't affect traffic lights)
                    { 1591417160u, Status.Compatible   }, // Hide It!
                    // compat with tmpe:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    { 890420060u , Status.Incompatible }, // S. Korea Traffic Lights (LHT)
                    { 888671987u , Status.Incompatible }, // S. Korea Traffic Lights (RHT)
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
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

            AddMod(new Review(1117087491u, "Remove Road Props") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // other mods that can hide road props:
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 1117087491u, Status.Incompatible }, // Remove Road Props
                    { 690066392u , Status.MinorIssues  }, // American RoadSigns v2.2.0
                    { 418637762u , Status.Incompatible }, // American Roads
                    // traffic light - level crossings:
                    { 1519049273u, Status.MinorIssues }, // American Railroad Signal Replacer
                    { 1249000709u, Status.MinorIssues }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // iterates props in all networks PER PROP!
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the props via its 'skip.txt' = much faster." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove road props. Use one, remove the other." },
                    { 1519049273u, "[Mod: American Railroad Signal Replacer] If you remove railway barriers, they can't be replaced." },
                    { 1249000709u, "[Mod: Japanese Railway Crossings] If you remove railway barriers, they can't be replaced." },
                    { 690066392u , "[Mod: American RoadSigns] Both mods can remove road props. Use one, remove the other." },
                },
                Published = WorkshopDate("21 Aug, 2017"),
                SourceURL = "https://gist.github.com/simon56modder/e1e15b53d7ca0d4ac76cb5fbccacc279",
                Updated = WorkshopDate("3 Feb, 2019"),
            });

            AddMod(new Review(956707300u, "Remove Street Arrows") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Simon Ryr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2009708489u, Status.Incompatible }, // Road Arrows Replacer [Spain]
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 956707300u , Status.Incompatible }, // Remove Street Arrows
                    // compat with tmpe:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // iterates all props in all networks PER ARROW TYPE!
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "It hides vanilla game street arrows (on any road), it won't hide custom street arrows." },
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the arrows (props) via its 'skip.txt' = much faster." },
                    { 2009708489u, "[Mod: Road Arrows Replacer] Won't be able to replace arrows if they are already removed by Remove Street Arrows." },
                    { 1806963141u, "[Mod: TM:PE] Compatible: Vehicles will still respect the street arrows even if not visible." },
                    { 1637663252u, "[Mod: TM:PE] Compatible: Vehicles will still respect the street arrows even if not visible." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove street arrows. Use one, remove the other." },
                },
                Published = WorkshopDate("27 Jun, 2017"),
                SourceURL = "https://gist.github.com/simon56modder/161f68433ad951b3f6b10ad7c392d277",
                Updated = WorkshopDate("27 Jun, 2017"),
            });

            AddMod(new Review(952542692u, "Airport Road Light Remover") {
                Affect = Factor.HideRemove,
                Authors = "vasimr22",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 953381687u , Status.Recommended  }, // Basic Airport Road Light Pack
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SlowLoad // parses all runway assets
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable, // many users report crashes and other errors
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using 'Loading Screen Mod' instead; skip the lights (props) via its 'skip.txt' = much faster." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove runway/taxiway lights. Use one, remove the other." },
                },
                Published = WorkshopDate("22 Jun, 2017"),
                Updated = WorkshopDate("22 Jun, 2017"),
            });

            AddMod(new Review(949061920u, "No Buoys Mod") {
                Affect = Factor.HideRemove,
                Authors = "noob_vl",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "pl" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Buoys can be toggled with Ctrl+Y (shortcut can be customised in options)." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove buoys. Use one, remove the other." },
                },
                Published = WorkshopDate("17 Jun, 2017"),
                SourceURL = "https://github.com/vonLeebpl/NoBuoysMod/tree/master/NoBuoysMod",
                Updated = WorkshopDate("17 Jun, 2017"),
            });

            AddMod(new Review(934958400u, "Improve FPS ! - Hide Districts [ALPHA]") {
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

            AddMod(new Review(919020932u, "Stop Remover") {
                Affect = Factor.HideRemove
                       | Factor.Props,
                Authors = "Lost Lime, boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // similar mods:
                    { 1962752152u, Status.Incompatible }, // Busstop Prop Remover
                    { 1591417160u, Status.MinorIssues  }, // Hide It (has same feature)
                    { 919020932u , Status.Incompatible }, // Stop Remover
                    // compat with tmpe:
                    { 1806963141u, Status.Compatible   }, // TM:PE v11 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE v11 STABLE
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // bus stop skins
                    { 545878277u , Status.Incompatible }, // [GBS] German Bus Stop Mod [NC]
                    // traffic light skins - junctions
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682u, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Compatible   }, // Horizontal Traffic Lights
                    { 890420060u , Status.Compatible   }, // S. Korea Traffic Lights (LHT)
                    { 888671987u , Status.Compatible   }, // S. Korea Traffic Lights (RHT)
                    // traffic light skins - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160u, "[Mod: Hide It] Both mods can remove transport stop props. Use one, unsubscribe the other." },
                },
                Published = WorkshopDate("4 May, 2017"),
                SourceURL = "https://gist.github.com/boformer/dfbc524d40e0e73fab5f45755ed8d9db",
                Updated = WorkshopDate("19 May, 2017"),
            });

            AddMod(new Review(917543381u, "No Problem Notifications") {
                Affect = Factor.HideRemove
                       | Factor.UI,
                Authors = "TPB",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396u, Status.MinorIssues  }, // Toggle It!
                    { 561293123u , Status.Incompatible }, // Hide Problems AKA Politician's Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod doesn't remove the problems, it just hides the notifications." },
                    { NOTE, "Some notifications added in Campus and Sunset Harbor are not currently supported." },
                    { 1764637396u, "[Mod: Toggle It!] Both mods can hide notifications and they get a bit confused when used at same time." },
                },
                Published = WorkshopDate("2 May, 2017"),
                Updated = WorkshopDate("10 Nov, 2018"),
            });

            AddMod(new Review(564141599u, "No Seagulls") {
                Affect = Factor.HideRemove,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1706704781u, Status.Incompatible }, // Remove All Animals
                    { 1591417160u, Status.MinorIssues  }, // Hide It!
                    { 587536931u , Status.Incompatible }, // Remove Seagulls [Fixed for v1.4+]
                    { 421041154u , Status.Incompatible }, // [ARIS] Remove Seagulls
                    { 417145328u , Status.Incompatible }, // [Deprecated] Kill the Seagulls!
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 1706704781u, "[Mod: Remove All Animals] Both mods can remove seagulls. Use one, unsubscribe the other." },
                    { 1591417160u, "[Mod: Hide It] Both mods can remove seagulls. Use one, remove the other." },
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


        }
    }
}