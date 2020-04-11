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

            AddMod(new Review(1614062928u, "Unlock LandScaping") {
                Affect = Factor.Unlockers,
                Authors = "pcfantasy",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Milestone unlockers:
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("4 Jan, 2019"),
                Updated = WorkshopDate("15 Jan, 2019"),
            });

            AddMod(new Review(1567569285u, "Achieve It!") {
                Affect = Factor.Achievements,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                    // Harmony conflicts:
                    { 1383456057u, Status.Incompatible }, // Shicho
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("17 Nov, 2018"),
                SourceURL = "https://github.com/keallu/CSL-AchieveIt",
                Updated = WorkshopDate("27 Mar, 2020"),
            });
            
            AddMod(new Review(1498036881u, "UltimateMod 2.6 ( Higher Income and More Options )") {
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
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                    // Chirper removers:
                    // Disable abandonment:
                    // Milestone unlockers:
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    //{ 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                    // Remove pollution (various types):
                    // Unlimited resources:
                    // Costs/refunds:
                    // Income multipliers:
                    { 1487849798u, Status.Incompatible }, // Higher Income Mod 1.2a
                    // Land value alterations:
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Localised
                      | ItemFlags.SourceUnavailable,
                Languages = new[] { "en", "zh-cn", "ru", "ko" },
                Locale = "en",
                Published = WorkshopDate("30 Aug, 2018"),
                Updated = WorkshopDate("31 Mar, 2020"),
            });

            AddMod(new Review(1444491969u, "Achievements with Mods") {
                Affect = Factor.Achievements,
                Authors = "TianBao",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 407055819u, // Mod Achievement Enabler
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor bug: The lock still appears on trophy icon (achievements should still work)." },
                },
                Published = WorkshopDate("18 Jul, 2018"),
                ReplaceWith = 1567569285u, // Achieve It!
                Updated = WorkshopDate("18 Jul, 2018"),
            });

            // unlocks specific buildings/services, not milestones
            AddMod(new Review(1424264814u, "YAFU - Yet Another Feature Unlocker") {
                Affect = Factor.Unlockers,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1242879105u, Status.MinorIssues  }, // Unlock Any Milestone
                    { 1237383751u, Status.MinorIssues  }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.MinorIssues  }, // EarlyUnlock
                    { 407162294u , Status.MinorIssues  }, // All basic unlocks at the start
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
            AddMod(new Review(1242879105u, "Unlock Any Milestone") {
                Affect = Factor.Unlockers,
                Authors = "Ilion",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928u, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814u, Status.MinorIssues  }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                },
                Flags = ItemFlags.Abandonware // author suggests to use "Extended Game Options" mod
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("25 Dec, 2017"),
                Updated = WorkshopDate("26 Dec, 2017"),
            });

            // Several reported issues with this mod (based on user comment):
            // * laggy (multiple users are reporting this - lots of code running on recurring events!)
            AddMod(new Review(1237383751u, "Extended Game Options") {
                Affect = Factor.Achievements
                       | Factor.Disasters
                       | Factor.Production
                       | Factor.TileLimit
                       | Factor.Unlockers,
                Authors = "Zenya",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                    // milestone unlockers
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928u, Status.Incompatible }, // Unlock LandScaping
                    { 1424264814u, Status.MinorIssues  }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    //{ 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                    // disaster enable in scenarios:
                    { 823348129u , Status.MinorIssues  }, // Disasters Enabler
                    // info views unlockers:
                    // full refunders
                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                    { Vanilla.HardMode, Status.Incompatible }, // Hard Mode (bundled with Cities: Skylines)
                    // tile unlockers:
                    { 2035564927u, Status.Incompatible }, // 25parts_su
                    { 1978555062u, Status.Incompatible }, // AllSpacesUnlockable
                    { 1891302645u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1878659195u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1830615215u, Status.Incompatible }, // All 25 Areas purchaseable
                    { 1778652879u, Status.Incompatible }, // MaxArea
                    { 1723162741u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1612287735u, Status.Incompatible }, // Purchase It!
                    { 1575247594u, Status.Incompatible }, // 576327847 81 Tiles (Fixed for 1
                    { 1560122066u, Status.Incompatible }, // 81MOD
                    { 1457742795u, Status.Incompatible }, // 403798635 All Spaces Unlockable
                    { 1449194984u, Status.Incompatible }, // 25格汉化版
                    { 1361478243u, Status.Incompatible }, // 81 Tiles
                    { 1314938052u, Status.Incompatible }, // UnlockAreaCountLimit
                    { 1270675750u, Status.Incompatible }, // BigCity (25 tiles mod)
                    { 1268806334u, Status.Incompatible }, // UnlockAreaCountLimitAndFree
                    { 1265292380u, Status.Incompatible }, // UnlockAreaCountLimit
                    { 1225712804u, Status.Incompatible }, // 406218372
                    { 1223738434u, Status.Incompatible }, // 422554572 (81 tiles)
                    { 1138679561u, Status.Incompatible }, // AllSpacesUnlock
                    { 616078328u , Status.Incompatible }, // All Tile Start -- not a tile mod, incompat with 81 tiles
                    { 576327847u , Status.Incompatible }, // 81 Tiles (current ver by BP)
                    { 422554572u , Status.Incompatible }, // 81 Tiles (original by emf)
                    { 413498678u , Status.Incompatible }, // All Spaces Unlockable - With Right Price
                    { 406218372u , Status.Incompatible }, // All Spaces Unlockable
                    { 405810376u , Status.Incompatible }, // All 25 Areas purchasable (by tomdotio)
                    { 403798635u , Status.Incompatible }, // All Spaces Unlockable
                    // resource depletion
                    { Vanilla.UnlimitedOilAndOre, Status.Incompatible }, // Unlimited Oil and Ore (bundled with Cities: Skylines)
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The mod runs quite a bit of code every frame; it's reported to cause lag in-game." },
                    { NOTE, "Achievement Unlocker: Icon still has a lock on it (minor bug), but achievements should work." },
                    { NOTE, "[Tile Unlockers] Extended Game Options has it's own tile unlocker, so other tile unlocker mods should be disabled or unsubscribed." },
                    { Vanilla.UnlimitedMoney, "[Mod: Unlimited Money] Full refund option in Extened Game Options is not relevant if unlimited money enabled." },
                },
                Published = WorkshopDate("20 Dec, 2017"),
                SourceURL = "https://github.com/ZenyaIse/Cities-Skylines-Extended-Game-Options",
                Updated = WorkshopDate("27 Mar, 2020"),
            });

            // allows uniques to be placed multiple times
            AddMod(new Review(466834228u, "Not So Unique Buildings") {
                Affect = Factor.Unlockers,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1137224650u, Status.Incompatible }, // 重复建设地标建筑
                    { 466834228u , Status.Incompatible }, // Not So Unique Buildings
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("22 Jun, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-NotSoUniqueBuildings",
                Updated = WorkshopDate("28 Oct, 2018"),
            });

            AddMod(new Review(458519223u, "Unlock All + Wonders & Landmarks") {
                Affect = Factor.Unlockers,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { Vanilla.UnlockAll, Status.Incompatible }, //Unlock All (bundled with Cities: Skylines)
                    { 1614062928u, Status.Incompatible }, // Unlock LandScaping
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6 ( Higher Income and More Options )
                    { 1424264814u, Status.Incompatible }, // YAFU - Yet Another Feature Unlocker
                    { 1242879105u, Status.Incompatible }, // Unlock Any Milestone
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 458519223u , Status.Incompatible }, // Unlock All + Wonders & Landmarks
                    { 410614868u , Status.Incompatible }, // EarlyUnlock
                    { 407162294u , Status.Incompatible }, // All basic unlocks at the start
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("10 Jun, 2015"),
                SourceURL = "https://github.com/bloodypenguin/Skylines-UnlockAllWondersAndLandmarks",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Review(407055819u, "Mod Achievement Enabler") {
                Affect = Factor.Achievements,
                Authors = "extra bad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // Achievements unlockers:
                    { 1567569285u, Status.Incompatible }, // Achieve It!
                    { 1498036881u, Status.Incompatible }, // UltimateMod 2.6
                    { 1444491969u, Status.Incompatible }, // Achievements with Mods
                    { 1237383751u, Status.Incompatible }, // Extended Game Options
                    { 407055819u , Status.Incompatible }, // Mod Achievement Enabler
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues // trophy icon doesn't get updated (makes some users think it's not working)
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Minor bug: The lock still appears on trophy icon (achievements should still work)." },
                },
                Published = WorkshopDate("13 Mar, 2015"),
                ReplaceWith = 1444491969u, // Achievements with Mods
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
            AddMod(new Review(1137224650u, "重复建设地标建筑") {
                Affect = Factor.Unlockers,
                Authors = "回忆时光℡",
                Catalog = catalog,
                CloneOf = 466834228u, // Not So Unique Buildings
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1137224650u, Status.Incompatible }, // 重复建设地标建筑
                    { 466834228u , Status.Incompatible }, // Not So Unique Buildings
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("17 Sep, 2017"),
                ReplaceWith = 466834228u, // Not So Unique Buildings
                Updated = WorkshopDate("17 Sep, 2017"),
            });
        }
    }
}