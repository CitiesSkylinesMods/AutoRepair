namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that alter the way roads look.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinTrafficLightsCatalog() {

            string catalog = "Skin.TrafficLights";

            /*
            #      ██ ██    ██ ███    ██  ██████ ████████ ██  ██████  ███    ██ ███████
            #      ██ ██    ██ ████   ██ ██         ██    ██ ██    ██ ████   ██ ██
            #      ██ ██    ██ ██ ██  ██ ██         ██    ██ ██    ██ ██ ██  ██ ███████
            # ██   ██ ██    ██ ██  ██ ██ ██         ██    ██ ██    ██ ██  ██ ██      ██
            #  █████   ██████  ██   ████  ██████    ██    ██  ██████  ██   ████ ███████
            */

            AddMod(new Item(1812157090u, "[NL] Dutch Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "lennart",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE
                    { 1806963141u, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.Compatible   }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "nl",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Shows wrong type of traffic light when using 'Large Avenue with Grass'." },
                },
                Published = WorkshopDate("22 Jul, 2019"),
                Updated = WorkshopDate("26 Aug, 2019"),
            });

            // Currently the yellow arrow signals do not operate with TMPE, but I am looking into adding this feature in the future.
            AddMod(new Item(1550720600u, "New American Traffic Lights - NYC/NJ Style") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 86 MB
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740u , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("28 Oct, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Item(1548117573u, "New American Traffic Lights - Grey Style") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 120 MB
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740u , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("28 Oct, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Item(1541164608u, "New American Traffic Lights - Vanilla Side") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 284 MB
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740u , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("17 Oct, 2018"),
                Updated = WorkshopDate("17 Oct, 2018"),
            });

            AddMod(new Item(1535107168u, "New American Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141u, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252u, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 1957033250u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910u, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472u, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572u, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731u, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740u , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449u , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759u , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868u , Status.Incompatible }, // Traffic++ V2
                    { 492391912u , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143u , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446u , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333u , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724u , Status.Incompatible }, // Traffic Manager (where it all started!!)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 395 MB
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252u, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740u , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("10 Oct, 2018"),
                Updated = WorkshopDate("29 Oct, 2018"),
            });

            // derived from http://steamcommunity.com/sharedfiles/filedetails/?id=809633246
            AddMod(new Item(1259628682u, "Taiwanese Traffic Lights (Left Hand Traffic)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "[TW]ChianMingDang",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 53 MB
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "zh-tw" },
                Locale = "tw",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A right-hand traffic version is available: http://steamcommunity.com/sharedfiles/filedetails/?id=1251396095" },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("6 Jan, 2018"),
                SourceURL = "https://github.com/qwe321iop/Taiwanese-Traffic-Lights",
                Updated = WorkshopDate("6 Jan, 2018"),
            });

            // derived from http://steamcommunity.com/sharedfiles/filedetails/?id=809633246
            AddMod(new Item(1251396095u, "Taiwanese Traffic Lights (Right Hand Traffic)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "[TW]ChianMingDang",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 53 MB
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "zh-tw" },
                Locale = "tw",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A left-hand traffic version is available: https://steamcommunity.com/sharedfiles/filedetails/?id=1259628682u" },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("31 Dec, 2017"),
                SourceURL = "https://github.com/qwe321iop/Taiwanese-Traffic-Lights",
                Updated = WorkshopDate("31 Dec, 2017"),
            });

            /*
            #  ██████ ██████   ██████  ███████ ███████ ██ ███    ██  ██████  ███████
            # ██      ██   ██ ██    ██ ██      ██      ██ ████   ██ ██       ██
            # ██      ██████  ██    ██ ███████ ███████ ██ ██ ██  ██ ██   ███ ███████
            # ██      ██   ██ ██    ██      ██      ██ ██ ██  ██ ██ ██    ██      ██
            #  ██████ ██   ██  ██████  ███████ ███████ ██ ██   ████  ██████  ███████
            */
 
            // these lights are _compatible_ with the junction light packs

            // has minor bugs
            AddMod(new Item(1519049273u, "American Railroad Signal Replacer") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682u, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Compatible   }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Incompatible }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Incompatible }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The lights and barriers are non-functional." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                },
                Published = WorkshopDate("22 Sep, 2018"),
                Updated = WorkshopDate("25 Sep, 2018"),
            });

            AddMod(new Item(1249000709u, "Japanese Railway Crossings 日本風踏切MOD") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ako_ako",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
                    { 1812157090u, Status.Compatible   }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Compatible   }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Compatible   }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Compatible   }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Compatible   }, // New American Traffic Lights
                    { 1259628682u, Status.Compatible   }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Compatible   }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Compatible   }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Incompatible }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Incompatible }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The lights and barriers are non-functional." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                },
                Published = WorkshopDate("29 Dec, 2017"),
                SourceURL = "https://github.com/ako-ako/Japanese-Railway-Crossings",
                Updated = WorkshopDate("18 Jan, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // Broken since ~August 2018
            AddMod(new Item(1108278552u, "Horizontal Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "Cristolisto",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131u, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426u , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
                    { 1812157090u, Status.Incompatible }, // [NL] Dutch Traffic Lights
                    { 1550720600u, Status.Incompatible }, // New American Traffic Lights - NYC/NJ Style
                    { 1548117573u, Status.Incompatible }, // New American Traffic Lights - Grey Style
                    { 1541164608u, Status.Incompatible }, // New American Traffic Lights - Vanilla Side
                    { 1535107168u, Status.Incompatible }, // New American Traffic Lights
                    { 1259628682u, Status.Incompatible }, // Taiwanese Traffic Lights (Left Hand Traffic)
                    { 1251396095u, Status.Incompatible }, // Taiwanese Traffic Lights (Right Hand Traffic)
                    { 1108278552u, Status.Incompatible }, // Horizontal Traffic Lights
                    // traffic light - level crossings
                    { 1519049273u, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709u, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // parklife
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Issues with T-junctions - see workshop page for details." },
                    { 2044086131u, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426u , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("12 Aug, 2017"),
                Updated = WorkshopDate("12 Aug, 2017"),
            });

        }
    }
}