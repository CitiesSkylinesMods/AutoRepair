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
            AddMod(new Review(1806881627u, "Altering History Fix") {
                Affect = Factor.BuildingLevel
                       | Factor.Despawn,
                Authors = "C#",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1658773932u, Status.Unknown      }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Unknown      }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Unknown      }, // Force Building Level
                    { 1196714353u, Status.Unknown      }, // 建筑升级平衡MOD
                    { 924884948u , Status.Unknown      }, // Plop the Growables
                    { 523818382u , Status.Unknown      }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.Campus,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
                Tags = new[] { "Historic", "Building", "Level", "History", "Despawn" },
            });

            // Note: Plop the Growables has settings which can override this mod
            AddMod(new Review(1658773932u, "Historical Districts") {
                Affect = Factor.BuildingLevel,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1658773932u, Status.Incompatible }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Unknown      }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Unknown      }, // Force Building Level
                    { 1196714353u, Status.Unknown      }, // 建筑升级平衡MOD
                    { 924884948u , Status.MinorIssues  }, // Plop the Growables
                    { 523818382u , Status.Compatible   }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
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
            AddMod(new Review(1647722503u, "Level") {
                Affect = Factor.BuildingLevel,
                Authors = "yoojt2",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Incompatible }, // Altering History Fix
                    { 1658773932u, Status.Incompatible }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Unknown      }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Unknown      }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Unknown      }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.Industries,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Unreliable
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                Locale = "ko",
                ReleasedDuring = GameVersion.Industries,
            });

            AddMod(new Review(1403136223u, "Control Building Level Up v0.5 (Industries)") {
                Affect = Factor.BuildingLevel,
                Authors = "boformer",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1658773932u, Status.Unknown      }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Unknown      }, // Plop the Growables
                    { 523818382u , Status.Compatible   }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
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

            AddMod(new Review(523818382u, "Force Level Up") {
                Affect = Factor.BuildingLevel,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1749971558u, Status.MinorIssues  }, // Real Time Offline
                    { 1658773932u, Status.Compatible   }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1420955187u, Status.MinorIssues  }, // Real Time
                    { 1403136223u, Status.Compatible   }, // Control Building Level Up v0.5 (Industries)
                    { 1383456057u, Status.Incompatible }, // Shicho
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Compatible   }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
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

            AddMod(new Review(1330381737u, "Historic Buildings (Make Historical)") {
                Affect = Factor.BuildingLevel,
                Authors = "CoarzFlovv",
                BrokenBy = GameVersion.Industries,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Incompatible }, // Altering History Fix
                    { 1658773932u, Status.Incompatible }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Incompatible }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Incompatible }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.ParkLife,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // vanilla game now has this function
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using the 'Make historical' feature (building info panels) of the base game instead." },
                },
                ReleasedDuring = GameVersion.ChirpX,
                ReplaceWith = 1658773932u, // Historical Districts
            });

            AddMod(new Review(1275678215u, "Force Building Level") {
                Affect = Factor.BuildingLevel,
                Authors = "CoarzFlovv",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1658773932u, Status.Unknown      }, // Historical Districts
                    { 1647722503u, Status.Unknown      }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Incompatible }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Incompatible }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                CompatibleWith = GameVersion.ParkLife,
                ContinuationOf = 410535198, // Control Building Level Up v0.4
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Consider using the 'Make historical' feature (building info panels) of the base game instead." },
                },
                ReleasedDuring = GameVersion.GreenCities,
                ReplaceWith = 523818382u, // Force Level Up
                SourceURL = "https://github.com/coarxflow/Skylines-ControlBuildingLevelUpMod",
                SuppressOlderReplacementWarning = true,
            });

            // Building Upgrade Balance Mod
            AddMod(new Review(1196714353u, "建筑升级平衡MOD") {
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
                    { 1806881627u, Status.Unknown      }, // Altering History Fix
                    { 1658773932u, Status.Unknown      }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Unknown      }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Unknown      }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
                Locale = "zh-cn",
            });

            AddMod(new Review(410535198u, "Control Building Level Up v0.4") {
                Affect = Factor.BuildingLevel,
                Authors = "DirtyDan",
                BrokenBy = GameVersion.GreenCities, // guesstimate
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Incompatible }, // Altering History Fix
                    { 1658773932u, Status.Incompatible }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Incompatible }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Compatible   }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
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
                ReplaceWith = 1403136223, // Control Building Level Up v0.5
                SourceURL = "https://github.com/DirtyDan88/Skylines-ControlBuildingLevelUpMod",
            });

            // Changed the algorithm that determined when buildings would level up
            // Rather than purely land-value based, it was primarily based on people working/living in the building.
            AddMod(new Review(409654587u, "Level Up Balance Mod") {
                Affect = Factor.BuildingLevel
                       | Factor.Education
                       | Factor.Employment
                       | Factor.Happiness,
                Authors = "Nohealforu",
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking // Broke sometime in 2018
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceUnavailable,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1806881627u, Status.Incompatible }, // Altering History Fix
                    { 1658773932u, Status.Incompatible }, // Historical Districts
                    { 1647722503u, Status.Incompatible }, // Level
                    { 1403136223u, Status.Incompatible }, // Control Building Level Up v0.5 (Industries)
                    { 1330381737u, Status.Incompatible }, // Historic Buildings (Make Historical)
                    { 1275678215u, Status.Incompatible }, // Force Building Level
                    { 1196714353u, Status.Incompatible }, // 建筑升级平衡MOD
                    { 924884948u , Status.Incompatible }, // Plop the Growables
                    { 523818382u , Status.Incompatible }, // Force Level Up
                    { 466158459u , Status.Incompatible }, // Building Themes
                    { 410535198u , Status.Incompatible }, // Control Building Level Up v0.4
                    { 409654587u , Status.Incompatible }, // Level Up Balance Mod
                },
            });
        }
    }
}