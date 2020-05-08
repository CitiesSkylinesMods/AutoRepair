namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Anything that primarily relates to Chirper.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void ChirperMods() {

            string catalog = "Chirper";

            // chirps gibberish
            AddMod(new Review(2053655383uL, "Pretty Pixel's Trump Tweets") {
                Affect = Factor.UI,
                Authors = "Gerald",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // chirp fitlers:
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                },
                Flags = ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It] The 'Chirper Button' option, if used, is not compatible with Trump Tweets mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Trump Tweets mod." },
                },
                Published = WorkshopDate("9 Apr, 2020"),
                Updated = WorkshopDate("9 Apr, 2020"),
            });

            // hide chirper, make chirper draggable, change transparency, filter non-important
            AddMod(new Review(649147853uL, "Birdcage - More Chirper controls") {
                Affect = Factor.UI,
                Authors = "Asser", // formerly SexyFishHorse
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.MinorIssues  }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.MinorIssues  }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // chirp fitlers:
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    // chirper movers:
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                    // other
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid

                },
                CompatibleWith = GameVersion.ParadoxLauncher, // liklely compat with SH
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Might conflict with any mods that add custom chirps, filter chirps, or hide/move chirper." },
                    { 1591417160uL, "[Mod: Hide It!] Both mods can hide chirper; only use that feature in one mod (ideally Hide It!), not the other." },
                    { 1498036881uL, "[Mod: Ultimate Mod] Both mods can hide chirper; only use that feature in one mod, not the other." },
                    { 628399273uL , "[Mod: ChirpBanner+] Both mods can filter chirps; only use that feature in one mod, not the other." },
                },
                Published = WorkshopDate("20 Mar, 2016"),
                SourceURL = "https://github.com/SexyFishHorse/CitiesSkylines-Birdcage",
                Updated = WorkshopDate("1 Nov, 2018"),
            });

            // replaces chirper with ticker-tape banner at top of screen
            // has chirper hider option, also option to filter useless chirps
            AddMod(new Review(628399273uL, "ChirpBanner+") {
                Affect = Factor.UI,
                Authors = "aq.trans",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.MinorIssues  }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // ChirpBanner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // chirp fitlers:
                    { 407871375uL , Status.Unknown      }, // ChirpFilter
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Unknown      }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Unknown      }, // 2ch for Chirpy
                    { 414730498uL , Status.Unknown      }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.MinorIssues  }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.ParadoxLauncher, // liklely compat with SH
                ContinuationOf = 406623071uL, // ChirpBanner
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Might conflict with any mods that add custom chirps, filter chirps, or hide chirper." },
                    { 1591417160uL, "[Mod: Hide It!] Both mods can hide chirper; only use that feature in one mod (ideally Hide It!), not the other." },
                    { 1498036881uL, "[Mod: Ultimate Mod] Both mods can hide chirper; only use that feature in one mod, not the other." },
                    { 649147853uL , "[Mod: Birdcage] Both mods can filter chirps; only use that feature in one mod, not the other." },
                    { 405963579uL , "[Mod: Chirper Position Changer/Mover] For compatibility, don't hide chirper." },
                },
                Published = WorkshopDate("20 Feb, 2016"),
                SourceURL = "https://github.com/aqtrans/CS-ChirpBanner",
                Updated = WorkshopDate("16 Mar, 2020"),
            });

            // filters useless chirps
            AddMod(new Review(407871375uL, "ChirpFilter") {
                Affect = Factor.UI,
                Authors = "Zuppi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Unknown      }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Compatible   }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // chirp fitlers:
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It] The 'Chirper Button' option, if used, is not compatible with ChirpFilter mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with ChirpFilter mod." },
                },
                Published = WorkshopDate("14 Mar, 2015"),
                SourceURL = "https://github.com/Zuppi/ChirpFilter",
                Updated = WorkshopDate("22 Mar, 2015"),
            });

            AddMod(new Review(406506125uL, "ByeByeBirdie") {
                Affect = Factor.UI,
                Authors = "Kranky",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("12 Mar, 2015"),
                Updated = WorkshopDate("12 Mar, 2015"),
            });

            AddMod(new Review(405963579uL, "Chirper Position Changer/Mover") {
                Affect = Factor.UI,
                Authors = "MrLawbreaker",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.MinorIssues  }, // ChirpBanner+
                    { 409392231uL , Status.MinorIssues  }, // SuperChirper
                    { 406623071uL , Status.Unknown      }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To reset position, press Ctrl + O (letter 'o')." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Chirper Position Changer/Mover mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Chirper Position Changer/Mover mod." },
                },
                Published = WorkshopDate("10 Mar, 2015"),
                SourceURL = "https://github.com/MrLawbreaker/SkylinesMod_FreeMoveChirper",
                Updated = WorkshopDate("18 Mar, 2015"),
            });

            // source found via: https://www.reddit.com/r/CSModAudits/comments/2yl5op/chirpy_exterminator_simssi/
            AddMod(new Review(405791507uL, "Chirpy Exterminator") {
                Affect = Factor.UI,
                Authors = "simssi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("5 May, 2020"),
                Published = WorkshopDate("10 Mar, 2015"),
                SourceURL = "https://gist.github.com/paavohuhtala/170111af1d4c08244c48",
                Updated = WorkshopDate("10 Mar, 2015"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // probably obsolete; no activity in the linked subreddit
            AddMod(new Review(819797131uL, "Reddit For Chirpy: Updated") {
                Affect = Factor.UI,
                Authors = "tony56a",
                BrokenBy = GameVersion.Campus,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Unknown      }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Compatible   }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // online chirpers:
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 408705348uL, // Reddit For Chirpy
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Users report this mod is unreliable since Campus game update." },
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Reddit For Chirpy mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Reddit For Chirpy mod." },
                },
                Published = WorkshopDate("17 Dec, 2016"),
                Updated = WorkshopDate("5 Jul, 2018"),
            });

            AddMod(new Review(810373922uL, "Remove Chirper") {
                Affect = Factor.UI,
                Authors = "Rob",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Some users report that the mod is broken." },
                },
                Published = WorkshopDate("2 Dec, 2016"),
                ReplaceWith = 649147853uL, // Birdcage
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("2 Dec, 2016"),
            });

            // probably obsolete; based on the original reddit chirper
            AddMod(new Review(577655208uL, "2ch for Chirpy") {
                Affect = Factor.UI,
                Authors = "Akira Ishizaki",
                //BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Unknown      }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Compatible   }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // online chirpers:
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                },
                CompatibleWith = GameVersion.Patch_1_3_1_f1,
                ContinuationOf = 408705348uL, // Reddit For Chirpy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Localised
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Locale = "ja",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Probably unreliable since Natural Disasters game update." },
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with 2ch for Chirpy mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with 2ch for Chirpy mod." },
                },
                Published = WorkshopDate("17 Dec, 2015"),
                SourceURL = "https://github.com/akira-ishizaki/Skylines-2chForChirpy",
                Updated = WorkshopDate("5 Apr, 2016"),
            });

            AddMod(new Review(462946934uL, "News de SimCity 3000 : Téléscripteur 3K") {
                Affect = Factor.UI,
                Authors = "tony_r_68 (Zed68)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 409924305uL, // SC3K Ticker
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Laggy
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod still pushes messages even when disabled; to stop it you have to completely unsubscribe it." },
                    { NOTE, "To remove this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("17 Jun, 2015"),
                Updated = WorkshopDate("17 Jun, 2015"),
            });

            AddMod(new Review(462969497uL, "SimCity 3000 News: News Ticker 3K") {
                Affect = Factor.UI,
                Authors = "tony_r_68 (Zed68)",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4,
                ContinuationOf = 409924305uL, // SC3K Ticker
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Laggy
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod still pushes messages even when disabled; to stop it you have to completely unsubscribe it." },
                    { NOTE, "To remove this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("17 Jun, 2015"),
                Updated = WorkshopDate("17 Jun, 2015"),
            });

            AddMod(new Review(423936348uL, "Chirper-Nachrichten") {
                Affect = Factor.UI,
                Authors = "SoulKeeper2k",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_1_0b,
                ContinuationOf = 409924305uL, // SC3K Ticker
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod still pushes messages even when disabled; to stop it you have to completely unsubscribe it." },
                    { NOTE, "To remove this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("12 Apr, 2015"),
                Updated = WorkshopDate("12 Apr, 2015"),
            });

            AddMod(new Review(422603366uL, "Disable Chirper") {
                Affect = Factor.UI,
                Authors = "React",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("10 Apr, 2015"),
                ReplaceWith = 649147853uL, // Birdcage
                Updated = WorkshopDate("10 Apr, 2015"),
            });

            // renames cims, adds custom chirps
            AddMod(new Review(414730498uL, "Twitch Chirper Chat") {
                Affect = Factor.UI,
                Authors = "RabidCrab",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Unknown      }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Compatible   }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // incompat with custom name lists or anything that alters cim names
                    { 1865667356uL, Status.Incompatible }, // Twitch Citizens
                    { 1806759255uL, Status.Unknown      }, // Customize It Extended
                    { 1369729955uL, Status.Compatible   }, // Customize It!
                    { 1231957400uL, Status.Incompatible }, // Custom Namelists
                    { 935350530uL , Status.Incompatible }, // CSL Custom Names [1.0.0]
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                },
                CompatibleWith = GameVersion.Patch_1_11_1_f4, // based on user comments
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "See workshop page for details of how to configure the mod." },
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper (use 'Clear' button), save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Twitch Chirper Chat mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Twitch Chirper Chat mod." },
                },
                Published = WorkshopDate("27 Mar, 2015"),
                SourceURL = "https://github.com/RabidCrab/TwitchChirperChat",
                Updated = WorkshopDate("1 Nov, 2017"),
            });

            AddMod(new Review(412019683uL, "Chitter") {
                Affect = Factor.UI,
                Authors = "mio991",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_0_6b,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "There is no clear guidance on how to use the mod; Twitter and game have changed a lot since 2015, the mod is probably broken." },
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Chitter mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Chitter mod." },
                },
                Published = WorkshopDate("22 Mar, 2015"),
                SourceURL = "https://github.com/mio991/ModChitter",
                Updated = WorkshopDate("23 Mar, 2015"),
            });

            AddMod(new Review(411307025uL, "Chirp Remover") {
                Affect = Factor.UI,
                Authors = "BarryOSeven",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.Incompatible }, // Hide It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                    { 405963579uL , Status.Incompatible }, // Chirper Position Changer/Mover
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("21 Mar, 2015"),
                ReplaceWith = 649147853uL, // Birdcage
                Updated = WorkshopDate("21 Mar, 2015"),
            });

            AddMod(new Review(409924305uL, "SC3K Ticker") {
                Affect = Factor.UI,
                Authors = "Evildropbear", // via 423936348uL
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // sc tickers:
                    { 462946934uL , Status.Incompatible }, // News de SimCity 3000 : Téléscripteur 3K
                    { 462969497uL , Status.Incompatible }, // SimCity 3000 News: News Ticker 3K
                    { 423936348uL , Status.Incompatible }, // Chirper-Nachrichten
                    { 409924305uL , Status.Incompatible }, // SC3K Ticker
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_1_0b,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("17 Jun, 2015"), // based on 462969497uL / 462946934uL linking to it
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod still pushes messages even when disabled; to stop it you have to completely unsubscribe it." },
                    { NOTE, "To remove this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                },
                Published = WorkshopDate("18 Mar, 2015"), // based on adjacent workshop item
                Removed = WorkshopDate("1 Jan, 2018"), // complete guess
                ReplaceWith = 462969497uL, // SimCity 3000 News: News Ticker 3K
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("18 Mar, 2015"), // not enough info to determine if it was updated
            });

            // clear chirps, mute chirps, filter chirps, hashtag removal, hide chirper
            AddMod(new Review(409392231uL, "SuperChirper") {
                Affect = Factor.UI,
                Authors = ".A",
                // BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // chirper movers:
                    { 405963579uL , Status.MinorIssues  }, // Chirper Position Changer/Mover
                    // chirp fitlers:
                    { 407871375uL , Status.Incompatible }, // ChirpFilter
                    // other:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 414730498uL , Status.Incompatible }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                },
                CompatibleWith = GameVersion.Patch_1_5_2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Natural Disasters: Some users report issues since game verison 1.6.0-f4." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with SuperChirper mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with SuperChirper mod." },
                },
                Published = WorkshopDate("17 Mar, 2015"),
                ReplaceWith = 649147853uL, // Birdcage
                SourceURL = "https://github.com/AtheMathmo/SuperChirperMod",
                Updated = WorkshopDate("9 Apr, 2015"),
            });

            AddMod(new Review(408705348uL, "Reddit For Chirpy") {
                Affect = Factor.UI,
                Authors = "mabako",
                BrokenBy = GameVersion.NaturalDisasters,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Compatible   }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // online chirpers:
                    { 819797131uL , Status.Incompatible }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Incompatible }, // 2ch for Chirpy
                    { 408705348uL , Status.Incompatible }, // Reddit For Chirpy
                },
                CompatibleWith = GameVersion.Stadiums,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SaveAltering
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To disable this mod: Pause game, delete all chirps in chirper, save game; then you can exit and disable the mod." },
                    { NOTE, "You might be able to use 'Safe Mode' features of 'Loading Screen Mod' to recover a broken save that used this mod." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Reddit For Chirpy mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Reddit For Chirpy mod." },
                },
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 819797131uL, // Reddit For Chirpy: Updated
                SourceURL = "https://github.com/mabako/reddit-for-city-skylines",
                Updated = WorkshopDate("3 Apr, 2015"),
            });

            // replaced chirper with a ticker-tape banner at top of screen
            AddMod(new Review(406623071uL, "Chirpy Banner") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20151122135431/http://steamcommunity.com/sharedfiles/filedetails/?id=406623071",
                Authors = "brittany",
                BrokenBy = GameVersion.Snowfall,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.MinorIssues  }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // ChirpBanner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                    // custom chirps:
                    { 2053655383uL, Status.Incompatible }, // Pretty Pixel's Trump Tweets
                    // other:
                    { 405963579uL , Status.Unknown      }, // Chirper Position Changer/Mover
                    { 819797131uL , Status.Compatible   }, // Reddit For Chirpy: Updated
                    { 577655208uL , Status.Compatible   }, // 2ch for Chirpy
                    { 419090722uL , Status.Required     }, // Mod Corral
                    { 414730498uL , Status.Compatible   }, // Twitch Chirper Chat
                    { 412019683uL , Status.Incompatible }, // Chitter
                    { 408705348uL , Status.Compatible   }, // Reddit For Chirpy
                    { 407871375uL , Status.Compatible   }, // ChirpFilter
                    { 406412894uL , Status.Incompatible }, // Chirpy Maid
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // avail Nov 2015, gone by Jun 2016
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("22 Nov, 2015"), // based on web archive
                Published = WorkshopDate("12 Mar, 2015"), // based on adjacent items
                Removed = WorkshopDate("20 Jun, 2016"), // based on web archive
                ReplaceWith = 628399273uL, // ChirpBanner+
                SourceURL = "https://github.com/brittanygh/CS-ChirpBanner",
                Updated = WorkshopDate("8 Apr, 2015"), // based on web archive; but could be subsequent updates
            });

            // clear all chirps
            AddMod(new Review(406412894uL, "Chirpy Maid") {
                Affect = Factor.UI,
                Authors = "TaskyTM",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // chirper removers/filters:
                    { 649147853uL , Status.Incompatible }, // Birdcage - More Chirper controls
                    { 628399273uL , Status.Incompatible }, // ChirpBanner+
                    { 409392231uL , Status.Incompatible }, // SuperChirper
                    { 406623071uL , Status.Incompatible }, // Chirpy Banner
                    // chirper removers:
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
                    { 1498036881uL, Status.MinorIssues  }, // UltimateMod 2.8 ( Higher Income and More Options )
                    { 810373922uL , Status.Incompatible }, // Remove Chirper
                    { 422603366uL , Status.Incompatible }, // Disable Chirper
                    { 411307025uL , Status.Incompatible }, // Chirp Remover
                    { 406506125uL , Status.Incompatible }, // ByeByeBirdie
                    { 405791507uL , Status.Incompatible }, // Chirpy Exterminator
                },
                CompatibleWith = GameVersion.Patch_1_2_2_f2,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Probably broken due to game updates since 2015." },
                    { 1591417160uL, "[Mod: Hide It!] The 'Chirper Button' option, if used, is not compatible with Chirpy Maid mod." },
                    { 1498036881uL, "[Mod: Ultimate Mod] The 'Disable Chirpy' option, if used, is not compatible with Chirpy Maid mod." },
                },
                Published = WorkshopDate("11 Mar, 2015"),
                ReplaceWith = 649147853uL, // Birdcage
                SourceURL = "https://github.com/skymodteam/skymod-chirpymaid",
                Updated = WorkshopDate("13 Mar, 2015"),
            });
        }
    }
}