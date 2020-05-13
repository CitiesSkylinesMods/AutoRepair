namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that provide enhanced statistics or data in-game.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void StatsMods() {

            string catalog = "Stats";

            AddMod(new Review(2074258904uL, "Demographics: Jobs and Employees") {
                Affect = Factor.UI,
                Authors = "BOT COMPOT",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Published = WorkshopDate("26 Apr, 2020"),
                Updated = WorkshopDate("26 Apr, 2020"),
            });

            AddMod(new Review(2051693155uL, "Building Vehicle Manager") {
                Affect = Factor.BuildingInfo
                       | Factor.Despawn
                       | Factor.UI,
                Authors = "kx36",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Currently only works on Industries DLC buildings." },
                },
                Published = WorkshopDate("7 Apr, 2020"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            // likely incompat with any mod that alters:
            // * Levels info panel
            // * building/vehicle color
            // * building stats
            AddMod(new Review(2048266761uL, "Building Usage") {
                Affect = Factor.BuildingCapacity
                       | Factor.BuildingLevel
                       | Factor.StorageCapacity
                       | Factor.VehicleCapacity
                       | Factor.Vehicles,
                Authors = "rcav8tr",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1420955187uL, Status.MinorIssues }, // Real Time
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.EditorBreaking
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1420955187uL, "[Mod: Real Time] Building Usage mod does not account for worker variations due to Real Time shifts." },
                },
                Published = WorkshopDate("4 Apr, 2020"),
                SourceURL = "https://github.com/rcav8tr/BuildingUsage",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            // economy stats
            AddMod(new Review(1994342199uL, "Eco Stats Mod") {
                Affect = Factor.Budget
                       | Factor.Money
                       | Factor.UI,
                Authors = "alfoirazabal",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("10 Feb, 2020"),
                SourceURL = "https://github.com/alfoirazabal/ecostatsmod",
                Updated = WorkshopDate("11 Feb, 2020"),
            });

            // asset counter
            AddMod(new Review(1956926733uL, "Asset Information") {
                Affect = Factor.UI,
                Authors = "Boaz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
            });

            AddMod(new Review(1927186256uL, "Problem Info") {
                Affect = Factor.UI,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 917543381uL , Status.Unknown      }, // No Problem Notifications
                    { 803074771uL , Status.Unknown      }, // No Deathcare
                    { 769744928uL , Status.Unknown      }, // Pollution, Death, Garbage and Crime Remover Mod
                    { 561293123uL , Status.Unknown      }, // Hide Problems AKA Politician's Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("11 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Ctrl+Shift+P to display the problem info panel." },
                },
                Published = WorkshopDate("3 Dec, 2019"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            AddMod(new Review(1904439843uL, "Mayoral City Service Info") {
                Affect = Factor.UI,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Press Ctrl+Shift+K to open the service info window." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            // Mashup of three older mods:
            // * City Vitals Watch
            // * Watch It
            // * Export Electricity
            AddMod(new Review(1893036262uL, "Mayor's Dashboard v2") {
                Affect = Factor.UI, // todo: better factors
                Authors = "Black Defke",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558uL, Status.Incompatible }, // Real Time Offline
                    { 1643902284uL, Status.MinorIssues  }, // Watch It!
                    { 1420955187uL, Status.Incompatible }, // Real Time
                    { 1192503086uL, Status.MinorIssues  }, // Real City V9.0.03.14
                    { 702070768uL , Status.Incompatible }, // Export Electricity
                    { 410151616uL , Status.Incompatible }, // City Vitals Watch
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 410151616uL, // City Vitals Watch
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // todo, incompat with similar mods
            AddMod(new Review(1875298330uL, "Extended Building Info") {
                Affect = Factor.BuildingInfo,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 414469593uL, // Extended Building Information (emf)
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: It works, but doesn't show info for new building types." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/live627/Cities-Skylines-Extended-Building-Info",
            });

            // todo: make better category for external integration mods?
            AddMod(new Review(1875697177uL, "Integrator: Log Generator") {
                Affect = Factor.Other, // todo: better factors
                Authors = "Lachlan",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 410151616uL, Status.Incompatible }, // City Vitals Watch
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 410151616uL, // City Vitals Watch
                Flags = ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Will crash if 'C:\\Temp' folder does not exist; but you can change folder in mod settings." },
                    { NOTE, "Not tested on Mac or Linux, let us know if it works!" },
                },
                Published = WorkshopDate("29 Sep, 2019"),
                Updated = WorkshopDate("3 May, 2020"),
            });

            AddMod(new Review(1804882663uL, "Monitor It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 908700552uL , Status.Incompatible }, // Simulation Speed Benchmark
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("4 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Harmony errors in log on game exit; doesn't seem to cause any problems." },
                },
                SourceURL = "https://github.com/keallu/CSL-MonitorIt",
            });

            AddMod(new Review(1785774902uL, "Transfer Info (beta)") {
                Affect = Factor.UI,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1769420886uL, Status.Required     }, // Panel Hook (beta) for modders
                    { 1739993783uL, Status.Incompatible }, // Cargo Info (Fix)
                    { 1623509958uL, Status.Compatible   }, // Real Gas Station
                    { 1614061108uL, Status.Compatible   }, // Real Construction
                    { 1072157697uL, Status.Incompatible }, // Cargo Info (original)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1072157697uL, // Cargo Info
                Flags = ItemFlags.Abandonware // author commented they lost interest in CSL
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; this mod will not be updated." },
                },
                Published = WorkshopDate("29 Jun, 2019"),
                SourceURL = "https://github.com/vpoteryaev-cs-mods/TransferInfo",
                Updated = WorkshopDate("3 Oct, 2019"),
            });

            AddMod(new Review(1643902284uL, "Watch It!") {
                Affect = Factor.Other, // todo: better factor
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1893036262uL, Status.MinorIssues  }, // Mayor's Dashboard v2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorIssues // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Harmony errors in log on game exit; doesn't seem to cause any problems." },
                    { NOTE, "One report that it's incompatible with More Vehicles / 81 Tiles / AVO mods. See: https://github.com/keallu/CSL-WatchIt/issues/3" },
                    { 1893036262uL, "[Mod: Mayors Dashboard] Has same functionality as Watch It; consider unsubscribing one of these mods." },
                },
                Published = WorkshopDate("3 Feb, 2019"),
                SourceURL = "https://github.com/keallu/CSL-WatchIt",
                Updated = WorkshopDate("20 Oct, 2019"),
            });

            AddMod(new Review(1556715327uL, "Show It!") {
                Affect = Factor.BuildingInfo,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended // by far the best building info mod
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("4 Nov, 2018"),
                SourceURL = "https://github.com/keallu/CSL-ShowIt",
                Updated = WorkshopDate("26 May, 2019"),
            });

            AddMod(new Review(1410077595uL, "Stats") {
                Affect = Factor.Other, // todo: better factor
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceAvailable,
                Languages = new[] { "en", "de", "ru" },
                Locale = "en",
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-Stats",
            });

            AddMod(new Review(1186900508uL, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508uL, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067uL , Status.Incompatible }, // DistrictRCI fix
                    { 486496436uL , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 943410067uL, // DistrictRCI fix
                Flags = ItemFlags.MinorIssues // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                Published = WorkshopDate("31 Oct, 2017"),
                SourceURL = "https://github.com/TheDogKSP/DistrictRCI",
                Updated = WorkshopDate("25 May, 2018"),
            });

            AddMod(new Review(1186889659uL, "DistrictStats") {
                Affect = Factor.Other, // todo: better factor
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.GreenCities,
                SourceURL = "https://github.com/TheDogKSP/DistrictStats",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(2039486691uL, "1133108993 Extended Building Information (1") {
                Affect = Factor.BuildingInfo,
                Authors = "Tykrane",
                Catalog = catalog,
                CloneOf = 1133108993uL, // Extended Building Information (1.10+)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1875298330uL, // Extended Building Info
                SourceURL = "https://github.com/AmaroqOkami/Cities-Skylines-Extended-Building-Info",
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1739993783uL, "Cargo Info (Fix)") {
                Affect = Factor.Other, // todo: better factor
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902uL, Status.Incompatible }, // Transfer Info (beta)
                    { 1623509958uL, Status.Incompatible }, // Real Gas Station
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 1072157697uL, Status.Incompatible }, // Cargo Info (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1072157697uL, // Cargo Info (original version)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceBundled,
                Languages = new[] { "en", "de", "ru" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; the mod will not be updated." },
                },
                Published = WorkshopDate("13 May, 2019"),
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1785774902uL, // Transfer Info (beta)
                Updated = WorkshopDate("21 Jun, 2019"),
            });

            AddMod(new Review(1725845818uL, "Mayor's report for android") {
                Affect = Factor.Other,
                Authors = "gadjou",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1725845818uL, Status.Incompatible }, // Mayor´s report for android
                    { 492187003uL , Status.Incompatible }, // Mayor´s report for android (Obsolete)
                },
                CompatibleWith = GameVersion.Industries,
                ContinuationOf = 492187003uL, // Mayor´s report for android (Obsolete)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Requires exteranal mobile app (Andriod only): https://play.google.com/store/apps/details?id=eu.chabod.mayorReport" },
                    { NOTE, "Looks like it requires changing firewall rules to access 'radiolinkinternet.com'... And source code not available... Mmmm..." },
                },
                Published = WorkshopDate("28 Apr, 2019"),
                Updated = WorkshopDate("28 Apr, 2019"),
            });

            // todo: likely translation mod
            AddMod(new Review(1915645035uL, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "xmastoridis",
                Catalog = catalog,
                CloneOf = 1186900508uL, // DistrictRCI-continued
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508uL, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067uL , Status.Incompatible }, // DistrictRCI fix
                    { 486496436uL , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: likely translation mod
            AddMod(new Review(1908236993uL, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "xmastoridis",
                Catalog = catalog,
                CloneOf = 1186900508uL, // DistrictRCI-continued
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508uL, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067uL , Status.Incompatible }, // DistrictRCI fix
                    { 486496436uL , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Review(1133108993uL, "Extended Building Information (1.10+)") {
                Affect = Factor.BuildingInfo,
                Authors = "Ellie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 928988785uL, // Extended Building Information
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1875298330uL, // Extended Building Info
                SourceURL = "https://github.com/AmaroqOkami/Cities-Skylines-Extended-Building-Info",
            });

            AddMod(new Review(1072157697uL, "Cargo Info") {
                Affect = Factor.Other, // todo: better factor
                Authors = "Dr. Nya",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141uL, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1785774902uL, Status.Incompatible }, // Transfer Info (beta)
                    { 1739993783uL, Status.Incompatible }, // Cargo Info (Fix)
                    { 1637663252uL, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1623509958uL, Status.Incompatible }, // Real Gas Station
                    { 1614061108uL, Status.Incompatible }, // Real Construction
                    { 1192503086uL, Status.Incompatible }, // Real City V9.0.03.14
                    { 1072157697uL, Status.Incompatible }, // Cargo Info (original version)
                },
                Languages = new[] { "en", "de", "ru" },
                LastSeen = WorkshopDate("10 May, 2020"),
                Published = WorkshopDate("16 Jul, 2017"),
                ReplaceWith = 1785774902uL, // Transfer Info (beta)
                SourceURL = "https://github.com/rumkex/Skylines-CargoInfoMod",
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(944936527uL, "Resources for Districts") {
                Affect = Factor.Consumption // todo: district factor?
                       | Factor.Production,
                Authors = "Sherban",
                Catalog = catalog,
                BrokenBy = GameVersion.ParkLife,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Patch_1_9_3_f1,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.MinorIssues // doesn't cover industries dlc resources
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Doesn't cover any resources added by Industries DLC update or later updates." },
                },
                Published = WorkshopDate("11 Jun, 2017"),
                SourceURL = "https://github.com/Sherbanm/RID/",
                Updated = WorkshopDate("1 Aug, 2017"),
            });

            AddMod(new Review(943410067uL, "DistrictRCI fix") {
                Affect = Factor.Other, // todo: better factor
                Authors = "billw",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993uL, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508uL, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067uL , Status.Incompatible }, // DistrictRCI fix
                    { 486496436uL , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.Patch_1_7_2_f1,
                ContinuationOf = 486496436uL, // DistrictRCI (original version)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("12 May, 2020"),
                Published = WorkshopDate("10 Jun, 2017"),
                ReplaceWith = 1186900508uL, // DistrictRCI-continued
                SourceURL = "https://github.com/billw2012/DistrictRCI",
                Updated = WorkshopDate("10 Jun, 2017"),
            });

            AddMod(new Review(928988785uL, "Extended Building Information") {
                Affect = Factor.BuildingInfo,
                Authors = "billw",
                BrokenBy = GameVersion.Patch_1_7_2_f1,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691uL, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330uL, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327uL, Status.Incompatible }, // Show It!
                    { 1133108993uL, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744uL , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785uL , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128uL , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593uL , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691uL , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.MassTransit,
                ContinuationOf = 414469593, // Extended Building Information
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("20 May, 2017"),
                ReplaceWith = 1875298330uL, // Extended Building Info
                SourceURL = "https://github.com/billw2012/Cities-Skylines-Extended-Building-Info",
                Updated = WorkshopDate("20 May, 2017"),
            });

            AddMod(new Review(908700552uL, "Simulation Speed Benchmark") {
                Affect = Factor.UI,
                Authors = "Overhatted",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1804882663uL, Status.Incompatible }, // Monitor It!
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod breaks the UI of other mods. Unsubscribe." },
                    { NOTE, "This mod causes 'Object reference not set to an instance of an object' errors." },
                },
                Published = WorkshopDate("19 Apr, 2017"),
                ReplaceWith = 1804882663uL, // Monitor It!
                SourceURL = "https://cld.pt/dl/download/b2583bc8-2fc9-4124-96e7-195c554c6991/SimulationSpeedBenchmark.zip",
                Updated = WorkshopDate("19 Apr, 2017"),
            });

            AddMod(new Review(492187003uL, "Mayor's report for android (Obsolete)") {
                Affect = Factor.Other,
                Authors = "gadjou",
                BrokenBy = GameVersion.MassTransit,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1725845818uL, Status.Incompatible }, // Mayor´s report for android
                    { 492187003uL , Status.Incompatible }, // Mayor´s report for android (Obsolete)
                },
                CompatibleWith = GameVersion.Patch_1_6_0_f4,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.LargeFileWarning // 12 MB wtf?
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("10 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Requires exteranal mobile app (Andriod only): https://play.google.com/store/apps/details?id=eu.chabod.mayorReport" },
                    { NOTE, "Looks like it requires changing firewall rules... And source code not available... Mmmm..." },
                },
                Published = WorkshopDate("1 Aug, 2015"),
                ReplaceWith = 1725845818uL, // Mayor´s report for android
                Updated = WorkshopDate("1 Aug, 2015"),
            });
        }
    }
}