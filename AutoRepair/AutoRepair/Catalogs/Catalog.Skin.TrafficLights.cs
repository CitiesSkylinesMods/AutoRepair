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
        private void SkinTrafficLightsMods() {

            string catalog = "Skin.TrafficLights";

            /*
            #      ██ ██    ██ ███    ██  ██████ ████████ ██  ██████  ███    ██ ███████
            #      ██ ██    ██ ████   ██ ██         ██    ██ ██    ██ ████   ██ ██
            #      ██ ██    ██ ██ ██  ██ ██         ██    ██ ██    ██ ██ ██  ██ ███████
            # ██   ██ ██    ██ ██  ██ ██ ██         ██    ██ ██    ██ ██  ██ ██      ██
            #  █████   ██████  ██   ████  ██████    ██    ██  ██████  ██   ████ ███████
            */

            AddMod(new Review(1812157090uL, "[NL] Dutch Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "lennart",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE
                    { 1806963141uL, Status.Compatible   }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.Compatible   }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.Compatible   }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
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
            AddMod(new Review(1550720600uL, "New American Traffic Lights - NYC/NJ Style") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 86 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740uL , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("28 Oct, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1548117573uL, "New American Traffic Lights - Grey Style") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 120 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740uL , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("28 Oct, 2018"),
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(1541164608uL, "New American Traffic Lights - Vanilla Side") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 284 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740uL , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("17 Oct, 2018"),
                Updated = WorkshopDate("17 Oct, 2018"),
            });

            AddMod(new Review(1535107168uL, "New American Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // Current versions of TM:PE - yellow lights not work
                    { 1806963141uL, Status.MinorIssues  }, // TM:PE v11.1.2 LABS
                    { 1637663252uL, Status.MinorIssues  }, // TM:PE V11 STABLE
                    // Old/rogue versions of TM:PE
                    { 2064509439uL, Status.Incompatible }, // TrafficManager
                    { 1957033250uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1604291910uL, Status.Incompatible }, // 498363759 Traffic Manager + Improved AI
                    { 1546870472uL, Status.Incompatible }, // TrafficManager Fixed for industry DLC
                    { 1581695572uL, Status.Incompatible }, // Traffic Manager: President Edition (no longer in workshop)
                    { 1348361731uL, Status.Incompatible }, // Traffic Manager: President Edition ALPHA/DEBUG
                    { 583429740uL , Status.MinorIssues  }, // Traffic Manager: President Edition (LinuxFan)
                    // Traffic Manager + Traffic++ AI (obsolete; game breaking)
                    { 563720449uL , Status.Incompatible }, // Traffic Manager + Improved AI (Japanese Ver.)
                    { 498363759uL , Status.Incompatible }, // Traffic Manager + Improved AI
                    // Traffic++ (obsolete; game breaking)
                    { 626024868uL , Status.Incompatible }, // Traffic++ V2
                    { 492391912uL , Status.Incompatible }, // Improved AI (Traffic++)
                    { 409184143uL , Status.Incompatible }, // Traffic++
                    // Extremely old verisons of Traffic Manager (obsolete; game breaking)
                    { 568443446uL , Status.Incompatible }, // Traffic Manager Plus 1.2.0
                    { 481786333uL , Status.Incompatible }, // Traffic Manager Plus
                    { 427585724uL , Status.Incompatible }, // Traffic Manager (where it all started!!)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.LargeFileWarning // 395 MB
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After enabling the mod, you have to exit to destkop then relaunch the game for it to work properly." },
                    { NOTE, "Some minor issues with vanilla highway roads - see workshop page for details." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 1806963141uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 1637663252uL, "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads - see workshop page for details." },
                    { 583429740uL , "[Mod: TM:PE] Yellow traffic lights don't work while TM:PE is active" },
                },
                Published = WorkshopDate("10 Oct, 2018"),
                Updated = WorkshopDate("29 Oct, 2018"),
            });

            // derived from http://steamcommunity.com/sharedfiles/filedetails/?id=809633246
            AddMod(new Review(1259628682uL, "Taiwanese Traffic Lights (Left Hand Traffic)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "[TW]ChianMingDang",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 1251396095uL, // Taiwanese Traffic Lights (Right Hand Traffic)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 53 MB
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "zh-tw" },
                Locale = "tw",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A right-hand traffic version is available: http://steamcommunity.com/sharedfiles/filedetails/?id=1251396095" },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("6 Jan, 2018"),
                SourceURL = "https://github.com/qwe321iop/Taiwanese-Traffic-Lights",
                Updated = WorkshopDate("6 Jan, 2018"),
            });

            // derived from http://steamcommunity.com/sharedfiles/filedetails/?id=809633246
            AddMod(new Review(1251396095uL, "Taiwanese Traffic Lights (Right Hand Traffic)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "[TW]ChianMingDang",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.LargeFileWarning // 53 MB
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "zh-tw" },
                Locale = "tw",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A left-hand traffic version is available: https://steamcommunity.com/sharedfiles/filedetails/?id=1259628682u" },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("31 Dec, 2017"),
                SourceURL = "https://github.com/qwe321iop/Taiwanese-Traffic-Lights",
                Updated = WorkshopDate("31 Dec, 2017"),
            });

            AddMod(new Review(890420060uL, "S. Korea Traffic Lights (LHT)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "Zuben",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.Compatible   }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.Compatible   }, // NExt2 (original)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.ParkLife,
                ContinuationOf = 888671987uL, // S. Korea Traffic Lights (RHT)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Locale = "ko",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A right-hand traffic version is available: https://steamcommunity.com/sharedfiles/filedetails/?id=888671987" },
                    { NOTE, "Based on source code of similar mod: https://github.com/ako-ako/Japanese-Traffic-Lights-V1.7" },
                },
                Published = WorkshopDate("24 Mar, 2017"),
                Updated = WorkshopDate("24 Mar, 2017"),
            });

            AddMod(new Review(888671987uL, "S. Korea Traffic Lights (RHT)") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "Zuben",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.Compatible   }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.Compatible   }, // NExt2 (original)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.ParkLife,
                ContinuationOf = 810355214uL, // Japanese Traffic Lights (RHT)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Locale = "ko",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A left-hand traffic version is available: http://steamcommunity.com/sharedfiles/filedetails/?id=890420060" },
                    { NOTE, "Based on source code of similar mod: https://github.com/ako-ako/Japanese-Traffic-Lights-V1.7" },
                },
                Published = WorkshopDate("22 Mar, 2017"),
                Updated = WorkshopDate("19 Jul, 2018"),
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
            AddMod(new Review(1519049273uL, "American Railroad Signal Replacer") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ol' rdtg",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Incompatible }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Incompatible }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                    { 1117087491uL, Status.MinorIssues  }, // Remove Road Props
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                    { 418637762uL , Status.MinorIssues  }, // American Roads
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The lights and barriers are non-functional." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 1117087491uL, "[Mod: Remove Road Props] If you remove railway barriers, the American Railroad Signal Replacer can't replace them." },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 418637762uL , "[Mod: American Roads] If you remove railway barriers, the American Railroad Signal Replacer can't replace them." },
                },
                Published = WorkshopDate("22 Sep, 2018"),
                Updated = WorkshopDate("25 Sep, 2018"),
            });

            AddMod(new Review(1249000709uL, "Japanese Railway Crossings 日本風踏切MOD") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "ako_ako",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
                    // traffic light - junctions
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Incompatible }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Incompatible }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Compatible   }, // Hide Traffic Lights
                    { 1117087491uL, Status.MinorIssues  }, // Remove Road Props
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                    { 418637762uL , Status.MinorIssues  }, // American Roads
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable,
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The lights and barriers are non-functional." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 1117087491uL, "[Mod: Remove Road Props] If you remove railway barriers, the Japanese Railway Crossings can't replace them." },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with level crossings on NExt2 roads." },
                    { 418637762uL , "[Mod: American Roads] If you remove railway barriers, the Japanese Railway Crossings can't replace them." },
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
            AddMod(new Review(1108278552uL, "Horizontal Traffic Lights") {
                Affect = Factor.Props
                       | Factor.TrafficLights,
                Authors = "Cristolisto",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // minor issues with NExt2 roads
                    { 2044086131uL, Status.MinorIssues  }, // NExt2 (temp bugfix)
                    { 812125426uL , Status.MinorIssues  }, // NExt2 (original)
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
                    // traffic light - level crossings
                    { 1519049273uL, Status.Compatible   }, // American Railroad Signal Replacer
                    { 1249000709uL, Status.Compatible   }, // Japanese Railway Crossings 日本風踏切MOD
                    // other:
                    { 1962752152uL, Status.Compatible   }, // Busstop Prop Remover
                    { 1320575938uL, Status.Incompatible }, // Hide Traffic Lights
                    { 919020932uL , Status.Compatible   }, // Stop Remover
                },
                CompatibleWith = GameVersion.GreenCities,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // parklife
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users report mod no longer works, or traffic lights on wrong side of road." },
                    { 2044086131uL, "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                    { 812125426uL , "[Mod: Network Extensions 2] Minor issues with some NExt2 roads." },
                },
                Published = WorkshopDate("12 Aug, 2017"),
                Updated = WorkshopDate("12 Aug, 2017"),
            });

        }
    }
}