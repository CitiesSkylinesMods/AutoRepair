namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mods that control building level up.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void BuildingLevelMods() {

            string catalog = "BuildingLevel";

            // fix bug with historic building despawning
            AddMod(new Review(1806881627uL, "Altering History Fix") {
                Affect = Factor.BuildingLevel
                       | Factor.Despawn,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1658773932uL, Status.Unknown      }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Unknown      }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Unknown      }, // Force Building Level
                    { 1196714353uL, Status.Unknown      }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Unknown      }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Unknown      }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
                Tags = new[] { "Historic", "Building", "Level", "History", "Despawn" },
            });

            // Note: Plop the Growables has settings which can override this mod
            AddMod(new Review(1658773932uL, "Historical Districts") {
                Affect = Factor.BuildingLevel,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Unknown      }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Unknown      }, // Force Building Level
                    { 1196714353uL, Status.Unknown      }, // 建筑升级平衡MOD
                    { 924884948uL , Status.MinorIssues  }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Compatible   }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { 924884948u ,"[Mod: Plop the Growables] Settings in PtG can override the historical districts settings." },
                },
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://gist.github.com/boformer/3e01770a0c86cf9273ccdcc33d9bbc42",
            });

            // Auto-maximises level of growables when built.
            AddMod(new Review(1647722503uL, "Level") {
                Affect = Factor.BuildingLevel,
                Authors = "yoojt2",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Incompatible }, // Altering History Fix
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Unknown      }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Unknown      }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Unknown      }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Unreliable
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Locale = "ko",
                ReleasedDuring = GameVersion.Industries,
            });

            AddMod(new Review(1403136223uL, "Control Building Level Up v0.5 (Industries)") {
                Affect = Factor.BuildingLevel,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1658773932uL, Status.Unknown      }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Unknown      }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Compatible   }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.SunsetHarbor, // likely works in campus too
                ContinuationOf = 410535198, // Control Building Level Up v0.4
                Flags = ItemFlags.Laggy
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using the 'Make historical' feature (building info panels) of the base game instead." },
                },
                ReleasedDuring = GameVersion.Industries,
                SourceURL = "https://gist.github.com/boformer/c0a449426ae681bbe4f4e54693df4b8c",
            });

            AddMod(new Review(523818382uL, "Force Level Up") {
                Affect = Factor.BuildingLevel,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1749971558uL, Status.MinorIssues  }, // Real Time Offline
                    { 1658773932uL, Status.Compatible   }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1420955187uL, Status.MinorIssues  }, // Real Time
                    { 1403136223uL, Status.Compatible   }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Compatible   }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/Skylines-ForceBuildingUpgrade",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1330381737uL, "Historic Buildings (Make Historical)") {
                Affect = Factor.BuildingLevel,
                Authors = "CoarzFlovv",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Incompatible }, // Altering History Fix
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 552309905uL , Status.Incompatible }, // No Abandonment
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Incompatible }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.Obsolete // vanilla game now has this function
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The vanilla game now has historic building feature; you can unsubscribe this mod." },
                    { NOTE, "Tip: Use 'No Abandonment' mod if you don't want buildings to despawn." },
                },
                Published = WorkshopDate("14 Mar, 2018"),
                ReplaceWith = 924884948uL, // Plop the Growables
                SourceURL = "https://github.com/coarxflow/resilient-owners", // this mod is a subset of resilient owners
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("11 Jun, 2018"),
            });

            AddMod(new Review(1275678215uL, "Force Building Level") {
                Affect = Factor.BuildingLevel,
                Authors = "CoarzFlovv",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1658773932uL, Status.Unknown      }, // Historical Districts
                    { 1647722503uL, Status.Unknown      }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Incompatible }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.ParkLife,
                ContinuationOf = 410535198, // Control Building Level Up v0.4
                Flags = ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using the 'Make historical' feature (building info panels) of the base game instead." },
                },
                Published = WorkshopDate("20 Jan, 2018"),
                ReplaceWith = 523818382uL, // Force Level Up
                SourceURL = "https://github.com/coarxflow/Skylines-ControlBuildingLevelUpMod",
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("11 Jun, 2018"),
            });

            // Building Upgrade Balance Mod
            AddMod(new Review(1196714353uL, "建筑升级平衡MOD") {
                Affect = Factor.BuildingLevel
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Happiness,
                Authors = "回忆时光℡",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking // Original broke sometime in 2018
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Unknown      }, // Altering History Fix
                    { 1658773932uL, Status.Unknown      }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Unknown      }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Unknown      }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                Locale = "zh-cn",
            });

            AddMod(new Review(820547325uL, "Resilient Owners (Make Historical)") {
                Affect = Factor.BuildingLevel,
                Authors = "CoarzFlovv",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Incompatible }, // Altering History Fix
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 821539759uL , Status.Incompatible }, // Disable Zone Check
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 552309905uL , Status.Incompatible }, // No Abandonment
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Incompatible }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.Patch_1_9_3_f1,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Park Life: Causes crashes since Park Life update." },
                    { NOTE, "Industries: The vanilla game has 'Historic Building' feature since Industries update." },
                    { NOTE, "Tip: Use 'No Abandonment' mod if you don't want buildings to despawn." },
                },
                Published = WorkshopDate("18 Dec, 2016"),
                ReplaceWith = 552309905uL, // No Abandonment
                SourceURL = "https://github.com/coarxflow/resilient-owners",
                Suppress = Warning.OlderReplacement,
                Updated = WorkshopDate("14 Mar, 2018"),
            });

            AddMod(new Review(410535198uL, "Control Building Level Up v0.4") {
                Affect = Factor.BuildingLevel,
                Authors = "DirtyDan",
                BrokenBy = GameVersion.GreenCities, // guesstimate
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627uL, Status.Incompatible }, // Altering History Fix
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Compatible   }, // Building Themes
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.MassTransit,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using the 'Make historical' feature (building info panels) of the base game instead." },
                },
                ReleasedDuring = GameVersion.InitialRelease,
                ReplaceWith = 1403136223uL, // Control Building Level Up v0.5
                SourceURL = "https://github.com/DirtyDan88/Skylines-ControlBuildingLevelUpMod",
            });

            // Changed the algorithm that determined when buildings would level up
            // Rather than purely land-value based, it was primarily based on people working/living in the building.
            AddMod(new Review(409654587uL, "Level Up Balance Mod") {
                Affect = Factor.BuildingLevel
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Happiness,
                ArchiveURL = "https://web.archive.org/web/20160620100049/http://steamcommunity.com/sharedfiles/filedetails/?id=409654587",
                Authors = "Nohealforu",
                BrokenBy = GameVersion.ParkLife,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2025147082uL, Status.Incompatible }, // Realistic Population revisited
                    { 1806881627uL, Status.Incompatible }, // Altering History Fix
                    { 1674732053uL, Status.Incompatible }, // Employ Overeducated Workers V2 (1.11+)
                    { 1658773932uL, Status.Incompatible }, // Historical Districts
                    { 1647722503uL, Status.Incompatible }, // Level
                    { 1551563197uL, Status.Incompatible }, // EnhancedBuildingCapacity - Fixed
                    { 1403136223uL, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737uL, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215uL, Status.Incompatible }, // Force Building Level
                    { 1196714353uL, Status.Incompatible }, // 建筑升级平衡MOD
                    { 1114249433uL, Status.Incompatible }, // Employ Overeducated Workers (1.10+)
                    { 924884948uL , Status.Incompatible }, // Plop the Growables
                    { 820547325uL , Status.Incompatible }, // Resilient Owners (Make Historical)
                    { 569008960uL , Status.Incompatible }, // Employ Overeducated Workers
                    { 523818382uL , Status.Incompatible }, // Force Level Up
                    { 466158459uL , Status.Incompatible }, // Building Themes
                    { 426163185uL , Status.Incompatible }, // Realistic Population and Consumption Mod v8.4.0
                    { 411190402uL , Status.Incompatible }, // Building Simulation Overhaul
                    { 410535198uL , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587uL , Status.Incompatible }, // Level Up Balance Mod
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                LastSeen = WorkshopDate("20 Jun, 2016"),
                Published = WorkshopDate("18 Mar, 2015"), // based on adjacent workshop ids; web archive shows "Mar 31, 2015"!
                Removed = WorkshopDate("20 Jun, 2018"), // rough guesstimate
                ReplaceWith = 2025147082uL, // Realistic Population revisited
                Updated = WorkshopDate("24 Sep, 2015"), // from web archive
            });
        }
    }
}