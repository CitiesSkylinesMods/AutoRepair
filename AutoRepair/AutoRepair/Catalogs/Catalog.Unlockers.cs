namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Milestone and other unlocker mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void UnlockerMods() {

            string catalog = "Unlockers";

            AddMod(new Review(1614062928uL, "Unlock LandScaping") {
                Affect = Factor.Unlockers,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Milestone unlockers:
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.Incompatible }, // EarlyUnlock
                    { 407162294uL , Status.Incompatible }, // All basic unlocks at the start
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("4 Jan, 2019"),
                Updated = WorkshopDate("15 Jan, 2019"),
            });

            AddMod(new Review(1567569285uL, "Achieve It!") {
                Affect = Factor.Achievements,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                    // other stuff:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("17 Nov, 2018"),
                SourceURL = "https://github.com/keallu/CSL-AchieveIt",
                Updated = WorkshopDate("27 Mar, 2020"),
            });

            AddMod(new Review(1498036881uL, "UltimateMod 2.8 ( Higher Income and More Options )") {
                Affect = Factor.Achievements
                       | Factor.Budget
                       | Factor.Bulldoze
                       | Factor.Construction
                       | Factor.Consumption
                       | Factor.Entertainment
                       | Factor.Education
                       | Factor.HideRemove
                       | Factor.LandValue
                       | Factor.MaintenanceCost
                       | Factor.Money
                       | Factor.PlaceAndMove
                       | Factor.Pollution
                       | Factor.Service
                       | Factor.Unlockers,
                Authors = "mcclane96[GER]",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                    // Chirper:
                    { 2053655383uL, Status.MinorIssues  }, // Pretty Pixel's Trump Tweets
                    { 1591417160uL, Status.MinorIssues  }, // Hide It!
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
                    // Disable abandonment:

                    // Milestone unlockers:
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    //{ 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.Incompatible }, // EarlyUnlock
                    { 407162294uL , Status.Incompatible }, // All basic unlocks at the start
                    // Remove pollution (various types):

                    // Unlimited resources:
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                    // Costs/refunds:

                    // Income multipliers:
                    { 1487849798uL, Status.Incompatible }, // Higher Income Mod 1.2a
                    // Land value alterations:
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "zh-cn", "ru", "ko" },
                LastSeen = WorkshopDate("6 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { 1591417160uL, "[Mod: Hide It!] Both mods can hide chirper; for compatibility only use Hide It to do that." },
                    { 819797131uL , "[Mod: Reddit for Chirpy] For compatibility, do not 'Disable Chirper' in UltimateMod." },
                    { 649147853uL , "[Mod: Birdcage] Both mods can hide chirper; use one, not the other." },
                    { 628399273uL , "[Mod: ChirpBanner+] Both mods can hide chirper; use one, not the other." },
                    { 414730498uL , "[Mod: Twitch Chirper Chat] For compatibility, do not 'Disable Chirper' in UltimateMod." },
                    { 412019683uL , "[Mod: Chitter] For compatibility, do not 'Disable Chirper' in UltimateMod." },
                    { 409392231uL , "[Mod: SuperChirper] Both mods can hide chirper; use one, not the other." },
                },
                Published = WorkshopDate("30 Aug, 2018"),
                Updated = WorkshopDate("31 Mar, 2020"),
            });

            AddMod(new Review(1444491969uL, "Achievements with Mods") {
                Affect = Factor.Achievements,
                Authors = "TianBao",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 407055819uL, // Mod Achievement Enabler
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor bug: The lock still appears on trophy icon (achievements should still work)." },
                },
                Published = WorkshopDate("18 Jul, 2018"),
                ReplaceWith = 1567569285uL, // Achieve It!
                Updated = WorkshopDate("18 Jul, 2018"),
            });

            // unlocks specific buildings/services, not milestones
            AddMod(new Review(1424264814uL, "YAFU - Yet Another Feature Unlocker") {
                Affect = Factor.Unlockers,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105uL, Status.MinorIssues  }, // Unlock Any Milestone
                    { 1237383751uL, Status.MinorIssues  }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.MinorIssues  }, // EarlyUnlock
                    { 407162294uL , Status.MinorIssues  }, // All basic unlocks at the start
                },
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("27 Jun, 2018"),
                SourceURL = "https://github.com/Celisuis/YAFU",
                Updated = WorkshopDate("2 Jul, 2018"),
            });

            // still works according to user comments
            // This mod is based on and extends the mods:
            // -"EarlyUnlock" https://steamcommunity.com/sharedfiles/filedetails/?id=410614868
            // -"All basic unlocks at the start" https://steamcommunity.com/sharedfiles/filedetails/?id=407162294
            AddMod(new Review(1242879105uL, "Unlock Any Milestone") {
                Affect = Factor.Unlockers,
                Authors = "Ilion",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928uL, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814uL, Status.MinorIssues  }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.Incompatible }, // EarlyUnlock
                    { 407162294uL , Status.Incompatible }, // All basic unlocks at the start
                },
                Flags = ItemFlags.Abandonware // author suggests to use "Extended Game Options" mod
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("25 Dec, 2017"),
                Updated = WorkshopDate("26 Dec, 2017"),
            });

            // Several reported issues with this mod (based on user comment):
            // * laggy (multiple users are reporting this - lots of code running on recurring events!)
            AddMod(new Review(1237383751uL, "Extended Game Options") {
                Affect = Factor.Achievements
                       | Factor.Disasters
                       | Factor.Production
                       | Factor.TileLimit
                       | Factor.Unlockers,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928uL, Status.Incompatible }, // Unlock LandScaping
                    { 1424264814uL, Status.MinorIssues  }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    //{ 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.Incompatible }, // EarlyUnlock
                    { 407162294uL , Status.Incompatible }, // All basic unlocks at the start
                    // disaster enable in scenarios:
                    { 823348129uL , Status.MinorIssues  }, // Disasters Enabler
                    // info views unlockers:
                    // full refunders
                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                    // tile unlockers:
                    { 2035564927uL, Status.Incompatible }, // 25parts_su
                    { 1978555062uL, Status.Incompatible }, // AllSpacesUnlockable
                    { 1891302645uL, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1878659195uL, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1830615215uL, Status.Incompatible }, // All 25 Areas purchaseable
                    { 1778652879uL, Status.Incompatible }, // MaxArea
                    { 1723162741uL, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1612287735uL, Status.Incompatible }, // Purchase It!
                    { 1575247594uL, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066uL, Status.Incompatible }, // 81MOD
                    { 1457742795uL, Status.Incompatible }, // 403798635 All Spaces Unlockable
                    { 1449194984uL, Status.Incompatible }, // 25格汉化版
                    { 1361478243uL, Status.Incompatible }, // 81 Tiles
                    { 1314938052uL, Status.Incompatible }, // UnlockAreaCountLimit
                    { 1270675750uL, Status.Incompatible }, // BigCity (25 tiles mod)
                    { 1268806334uL, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1265292380uL, Status.Incompatible }, // UnlockAreaCountLimit
                    { 1225712804uL, Status.Incompatible }, // 406218372
                    { 1223738434uL, Status.Incompatible }, // 422554572 (81 tiles)
                    { 1138679561uL, Status.Incompatible }, // AllSpacesUnlock
                    { 839931599uL , Status.Incompatible }, // UnlockAreaCountLimit
                    { 616078328uL , Status.Incompatible }, // All Tile Start -- not a tile mod, incompat with 81 tiles
                    { 576327847uL , Status.Incompatible }, // 81 Tiles (current ver by BP)
                    { 422554572uL , Status.Incompatible }, // 81 Tiles (original by emf)
                    { 413498678uL , Status.Incompatible }, // All Spaces Unlockable - With Right Price
                    { 406218372uL , Status.Incompatible }, // All Spaces Unlockable
                    { 405810376uL , Status.Incompatible }, // All 25 Areas purchasable (by tomdotio)
                    { 403798635uL , Status.Incompatible }, // All Spaces Unlockable
                    // resource depletion
                    { Vanilla.UnlimitedOilAndOre, Status.Incompatible }, // Unlimited Oil and Ore (bundled with Cities: Skylines)
                    { 852103955uL , Status.Incompatible }, // InfiniteOilAndOre
                    { 409644467uL , Status.Incompatible }, // InfiniteOilAndOre
                    // other
                    { 2090425593uL, Status.Compatible   }, // Game Speed mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod runs quite a bit of code every frame; it's reported to cause lag in-game." },
                    { NOTE, "Achievement Unlocker: Icon still has a lock on it (minor bug), but achievements should work." },
                    { NOTE, "[Tile unlocker mods] Extended Game Options has it's own tile unlocker, so other tile unlocker mods should be disabled or unsubscribed." },
                    { Vanilla.UnlimitedMoney, "[Mod: Unlimited Money] Full refund option in Extened Game Options is not relevant if unlimited money enabled." },
                    { 823348129uL , "[Mod: Disasters Enabler] Extended Game Options has identical feature; you can unsubscribe Disasters Enabler mod." },
                },
                Published = WorkshopDate("20 Dec, 2017"),
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Extended-Game-Options",
                Updated = WorkshopDate("27 Mar, 2020"),
            });

            AddMod(new Review(794268416uL, "Steamy - More Steam controls") {
                Affect = Factor.Achievements
                       | Factor.UI,
                Authors = "Asser", // formerly sexyfishhorse
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 411253368uL , Status.Incompatible }, // Steam notification mover
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Achievements flag was inverted, and this mod hasn't been updated; achievement enabler likely not working." },
                },
                Published = WorkshopDate("5 Nov, 2016"),
                SourceURL = "https://github.com/SexyFishHorse/CitiesSkylines-Steamy",
                Updated = WorkshopDate("1 Nov, 2018"),
            });

            // allows uniques to be placed multiple times
            AddMod(new Review(466834228uL, "Not So Unique Buildings") {
                Affect = Factor.Unlockers,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1137224650uL, Status.Incompatible }, // 重复建设地标建筑
                    { 466834228uL , Status.Incompatible }, // Not So Unique Buildings
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("22 Jun, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-NotSoUniqueBuildings",
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(458519223uL, "Unlock All + Wonders & Landmarks") {
                Affect = Factor.Unlockers,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928uL, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814uL, Status.Incompatible }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105uL, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 458519223uL , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868uL , Status.Incompatible }, // EarlyUnlock
                    { 407162294uL , Status.Incompatible }, // All basic unlocks at the start
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("10 Jun, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-UnlockAllWondersAndLandmarks",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Review(407055819uL, "Mod Achievement Enabler") {
                Affect = Factor.Achievements,
                Authors = "extra bad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285uL, Status.Incompatible }, // Achieve It!
                    { 1498036881uL, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969uL, Status.Incompatible }, // Achievements with Mods
                    { 1237383751uL, Status.Incompatible }, // Extended Game Options
                    { 794268416uL , Status.Incompatible }, // Steamy - More Steam controls
                    { 407055819uL , Status.Incompatible }, // Mod Achievement Enabler
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor bug: The lock still appears on trophy icon (achievements should still work)." },
                },
                Published = WorkshopDate("13 Mar, 2015"),
                ReplaceWith = 1444491969uL, // Achievements with Mods
                SourceURL = "https://gist.github.com/anonymous/c524671571c3879381b2",
                Updated = WorkshopDate("13 Mar, 2015"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // "Repeated construction of landmark buildings"
            // An unaltered clone of Not So Unique Buildings
            // It's not even translated!
            AddMod(new Review(1137224650uL, "重复建设地标建筑") {
                Affect = Factor.Unlockers,
                Authors = "回忆时光℡",
                Catalog = catalog,
                CloneOf = 466834228uL, // Not So Unique Buildings
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1137224650uL, Status.Incompatible }, // 重复建设地标建筑
                    { 466834228uL , Status.Incompatible }, // Not So Unique Buildings
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("6 May, 2020"),
                Published = WorkshopDate("17 Sep, 2017"),
                ReplaceWith = 466834228uL, // Not So Unique Buildings
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("17 Sep, 2017"),
            });
        }
    }
}