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
        private void StatsCatalog() {

            string catalog = "Stats";

            // economy stats
            AddMod(new Item(1994342199u, "Eco Stats Mod") {
                Affect = Factor.Budget
                       | Factor.Money,
                Authors = "alfoirazabal",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/alfoirazabal/ecostatsmod",
            });

            // asset counter
            AddMod(new Item(1956926733u, "Asset Information") {
                Affect = Factor.Other,
                Authors = "Boaz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
            });

            AddMod(new Item(1904439843u, "Mayoral City Service Info") {
                Affect = Factor.Other,
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
            AddMod(new Item(1893036262u, "Mayor's Dashboard v2") {
                Affect = Factor.Other, // todo: better factors
                Authors = "Black Defke",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1749971558u, Status.Incompatible }, // Real Time Offline
                    { 1643902284u, Status.MinorIssues  }, // Watch It!
                    { 1420955187u, Status.Incompatible }, // Real Time
                    { 702070768u , Status.Incompatible }, // Export Electricity
                    { 410151616u , Status.Incompatible }, // City Vitals Watch
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 410151616u, // City Vitals Watch
                Flags = ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            // todo, incompat with similar mods
            AddMod(new Item(1875298330u, "Extended Building Info") {
                Affect = Factor.BuildingInfo,
                Authors = "live627",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 414469593u, // Extended Building Information (emf)
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: It works, but doesn't show info for new building types." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/live627/Cities-Skylines-Extended-Building-Info",
            });

            // todo: make better category for external integration mods?
            AddMod(new Item(1875697177u, "Integrator: Log Generator") {
                Affect = Factor.Other, // todo: better factors
                Authors = "Lachlan",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 410151616u, Status.Incompatible }, // City Vitals Watch
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 410151616u, // City Vitals Watch
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Will crash if 'C:\\Temp' folder does not exist; but you can change folder in mod settings." },
                    { NOTE, "Not tested on Mac or Linux, let us know if it works!" },
                    { NOTE, "Sunset Harbor: Seems to be throwing errors since the update." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1804882663u, "Monitor It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Harmony errors in log on game exit; doesn't seem to cause any problems." },
                },
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/keallu/CSL-MonitorIt",
            });

            AddMod(new Item(1643902284u, "Watch It!") {
                Affect = Factor.Other, // todo: better factor
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1893036262u, Status.MinorIssues  }, // Mayor's Dashboard v2
                    { 1383456057u, Status.Incompatible }, // Shicho
                    // https://github.com/keallu/CSL-WatchIt/issues/3 :
                    { 1548831935u, Status.Incompatible }, // Advanced Vehicle Options (latest)
                    { 1764208250u, Status.Incompatible }, // More Vehicles
                    { 576327847u , Status.Incompatible }, // 81 Tiles
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Harmony errors in log on game exit; doesn't seem to cause any problems." },
                    { NOTE, "Watch It may crash if used with More Vehicles / 81 Tiles / AVO mods. See: https://github.com/keallu/CSL-WatchIt/issues/3" },
                    { 1893036262u, "[Mod: Mayors Dashboard] Has same functionality as Watch It; consider unsubscribing one of these mods." },
                },
                Published = WorkshopDate("3 Feb, 2019"),
                SourceURL = "https://github.com/keallu/CSL-WatchIt",
                Updated = WorkshopDate("20 Oct, 2019"),
            });

            AddMod(new Item(1556715327u, "Show It!") {
                Affect = Factor.BuildingInfo,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended // by far the best building info mod
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://github.com/keallu/CSL-ShowIt",
            });

            AddMod(new Item(1410077595u, "Stats") {
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

            AddMod(new Item(1186900508u, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "cambrium",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508u, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067u , Status.Incompatible }, // DistrictRCI fix
                    { 486496436u , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 943410067u, // DistrictRCI fix
                Flags = ItemFlags.MinorBugs // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                ReleasedDuring = GameVersion.GreenCities,
                SourceURL = "https://github.com/TheDogKSP/DistrictRCI",
            });

            AddMod(new Item(1186889659u, "DistrictStats") {
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

            AddMod(new Item(944936527u, "Resources for Districts") {
                Affect = Factor.Consumption // todo: district factor?
                       | Factor.Production,
                Authors = "Sherban",
                Catalog = catalog,
                BrokenBy = GameVersion.ParkLife,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.GreenCities,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // doesn't cover industries dlc resources
                      | ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.MassTransit,
                SourceURL = "https://github.com/Sherbanm/RID/",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(2039486691u, "1133108993 Extended Building Information (1") {
                Affect = Factor.BuildingInfo,
                Authors = "Tykrane",
                Catalog = catalog,
                CloneOf = 1133108993u, // Extended Building Information (1.10+)
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1875298330u, // Extended Building Info
                SourceURL = "https://github.com/AmaroqOkami/Cities-Skylines-Extended-Building-Info",
            });

            AddMod(new Item(1785774902u, "Transfer Info (beta)") {
                Affect = Factor.Other, // todo: better factor
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1769420886u, Status.Required     }, // Panel Hook (beta) for modders
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1614061108u, Status.Compatible   }, // Real Construction
                    { 1072157697u, Status.Incompatible }, // Cargo Info (original)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1072157697u, // Cargo Info
                Flags = ItemFlags.Abandonware // author commented they lost interest in CSL
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; this mod will not be updated." },
                },
                Published = WorkshopDate("29 Jun, 2019"),
                ReleasedDuring = GameVersion.Campus,
                SourceURL = "https://github.com/vpoteryaev-cs-mods/TransferInfo",
                Updated = WorkshopDate("3 Oct, 2019"),
            });

            AddMod(new Item(1739993783u, "Cargo Info (Fix)") {
                Affect = Factor.Other, // todo: better factor
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1785774902u, Status.Incompatible }, // Transfer Info (beta)
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1072157697u, Status.Incompatible }, // Cargo Info (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                ContinuationOf = 1072157697u, // Cargo Info (original version)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceBundled,
                Languages = new[] { "en", "de", "ru" },
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; the mod will not be updated." },
                },
                Published = WorkshopDate("13 May, 2019"),
                ReleasedDuring = GameVersion.Industries,
                ReplaceWith = 1785774902u, // Transfer Info (beta)
                Updated = WorkshopDate("21 Jun, 2019"),
            });

            // todo: warn about network traffic
            AddMod(new Item(1725845818u, "Mayor´s report for android") {
                Affect = Factor.Other,
                Authors = "gadjou",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Requires exteranal mobile app (Andriod only): https://play.google.com/store/apps/details?id=eu.chabod.mayorReport" },
                    { NOTE, "Looks like it requires changing firewall rules... And source code not available... Mmmm..." },
                },
                ReleasedDuring = GameVersion.Industries,
            });

            // todo: likely translation mod
            AddMod(new Item(1915645035u, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "xmastoridis",
                Catalog = catalog,
                CloneOf = 1186900508u, // DistrictRCI-continued
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508u, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067u , Status.Incompatible }, // DistrictRCI fix
                    { 486496436u , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            // todo: likely translation mod
            AddMod(new Item(1908236993u, "DistrictRCI-continued") {
                Affect = Factor.Other, // todo: better factor
                Authors = "xmastoridis",
                Catalog = catalog,
                CloneOf = 1186900508u, // DistrictRCI-continued
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508u, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067u , Status.Incompatible }, // DistrictRCI fix
                    { 486496436u , Status.Incompatible }, // DistrictRCI (original version)
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Some bugs with the text captions, but the graphs seem more or less correct." },
                },
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1133108993u, "Extended Building Information (1.10+)") {
                Affect = Factor.BuildingInfo,
                Authors = "Ellie",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2039486691u, Status.Incompatible }, // 1133108993 Extended Building Information (1
                    { 1875298330u, Status.Incompatible }, // Extended Building Info (live627)
                    { 1556715327u, Status.Incompatible }, // Show It!
                    { 1133108993u, Status.Incompatible }, // Extended Building Information (1.10+)
                    { 938049744u , Status.Incompatible }, // Proper Hardness Fixed
                    { 928988785u , Status.Incompatible }, // Extended Building Information (billw)
                    { 670422128u , Status.Incompatible }, // Extended Building Information (Hedgehog)
                    { 414469593u , Status.Incompatible }, // Extended Building Information (emf)
                    { 408706691u , Status.Incompatible }, // Proper Hardness
                },
                ContinuationOf = 928988785u, // Extended Building Information
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1875298330u, // Extended Building Info
                SourceURL = "https://github.com/AmaroqOkami/Cities-Skylines-Extended-Building-Info",
            });

            AddMod(new Item(1072157697u, "Cargo Info") {
                Affect = Factor.Other, // todo: better factor
                Authors = "Dr. Nya",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceAvailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806963141u, Status.Incompatible }, // TM:PE v11.1.2 LABS
                    { 1785774902u, Status.Incompatible }, // Transfer Info (beta)
                    { 1739993783u, Status.Incompatible }, // Cargo Info (Fix)
                    { 1637663252u, Status.Incompatible }, // TM:PE V11 STABLE
                    { 1614061108u, Status.Incompatible }, // Real Construction
                    { 1072157697u, Status.Incompatible }, // Cargo Info (original version)
                },
                Languages = new[] { "en", "de", "ru" },
                ReplaceWith = 1785774902u, // Transfer Info (beta)
                SourceURL = "https://github.com/rumkex/Skylines-CargoInfoMod",
            });

            AddMod(new Item(943410067u, "DistrictRCI fix") {
                Affect = Factor.Other, // todo: better factor
                Authors = "billw",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1915645035u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1908236993u, Status.Incompatible }, // 1186900508 DistrictRCI-continued
                    { 1186900508u, Status.Incompatible }, // DistrictRCI-continued
                    { 943410067u , Status.Incompatible }, // DistrictRCI fix
                    { 486496436u , Status.Incompatible }, // DistrictRCI (original version)
                },
                ContinuationOf = 486496436u, // DistrictRCI (original version)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable,
                ReplaceWith = 1186900508u, // DistrictRCI-continued
                SourceURL = "https://github.com/billw2012/DistrictRCI",
            });
        }
    }
}