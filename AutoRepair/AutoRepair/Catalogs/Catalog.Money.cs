namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Mod(s) which add numbered rectangles.
    ///
    /// Composite mods which provide other features should be defined elsewhere.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void MoneyMods() {

            string catalog = "Money";

            AddMod(new Review(2036484892uL, "AutoMoney") {
                Affect = Factor.Money,
                Authors = "bansz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Incompatible }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Incompatible }, // Cash on Demand

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 409171141uL, // Cash on Demand
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Review(2030216556uL, "GrantMeMoney: get cash / money unconditionally") {
                Affect = Factor.Money,
                Authors = "the weatherman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Compatible   }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Compatible   }, // Cash on Demand

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                CompatibleWith = GameVersion.ParadoxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.ParadoxLauncher,
                SourceURL = "https://github.com/NJAldwin/GrantMeMoney",
            });

            // todo: conflict with vanilla
            AddMod(new Review(1949192313uL, "UnlimitedMoney") {
                Affect = Factor.Money,
                Authors = "j.a.pasterkamp",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // these mods are pointless when unlimited money is active:
                    { 2036484892uL, Status.MinorIssues  }, // AutoMoney
                    { 2030216556uL, Status.MinorIssues  }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319uL, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.MinorIssues  }, // CS-Utils
                    { 1367444256uL, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.MinorIssues  }, // 调整金钱
                    { 855704599uL , Status.MinorIssues  }, // Set your own Start Money amount
                    { 409171141uL , Status.MinorIssues  }, // Cash on Demand
                },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The base game comes with its own unlimited money mod, use that instead." },
                },
            });

            AddMod(new Review(1673480325uL, "£5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // same assembly conflicts:
                    { 1673480325uL, Status.Incompatible }, // £5 Million Starting Money
                    { 1671542319uL, Status.Incompatible }, // £2.5 Million Starting Money

                    // similar but non-conflicting mods:
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Compatible   }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Compatible   }, // Cash on Demand

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                ContinuationOf = 1671542319uL, // £2.5 Million Starting Money
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1671542319uL, "£2.5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // same assembly conflicts:
                    { 1673480325uL, Status.Incompatible }, // £5 Million Starting Money
                    { 1671542319uL, Status.Incompatible }, // £2.5 Million Starting Money

                    // similar but non-conflicting mods:
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Compatible   }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Compatible   }, // Cash on Demand

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Review(1367444256uL, "Cash/Money On Demand 500k") {
                Affect = Factor.Money,
                Authors = "Jay",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892uL, Status.Incompatible }, // AutoMoney
                    { 1367444256uL, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Incompatible }, // 调整金钱
                    { 409171141uL , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                ContinuationOf = 409171141uL, // Cash on Demand
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
            });

            // Also has limits display but people really only use it to add money on demand
            AddMod(new Review(1330289236uL, "CS-Utils") {
                Affect = Factor.Money,
                Authors = "kartoffelx86",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Compatible   }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Compatible   }, // Cash on Demand
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            // mod author still actively maintaining the mod
            AddMod(new Review(855704599uL, "Set your own Start Money amount") {
                Affect = Factor.Money,
                Authors = "rickdeschenes",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney

                    // similar but non-conflicting mods:
                    { 2036484892uL, Status.Compatible   }, // AutoMoney
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 1367444256uL, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Compatible   }, // 调整金钱
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                    { 409171141uL , Status.Compatible   }, // Cash on Demand
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Unreliable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "After starting a game, it can take up to 2 game-days before the money is added." },
                },
                Published = WorkshopDate("3 Feb, 2017"),
                SourceURL = "https://github.com/RickDeschenes/Skylines-SetStartMoney",
                Updated = WorkshopDate("24 Apr, 2020"),
            });

            AddMod(new Review(409171141uL, "Cash on Demand") {
                Affect = Factor.Money,
                Authors = "UndergroundHero",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892uL, Status.Incompatible }, // AutoMoney
                    { 1367444256uL, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Incompatible }, // 调整金钱
                    { 409171141uL , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount

                    // other:
                    { 2059655996uL, Status.Compatible   }, // [Beta] PRT-2
                    { 1440928803uL, Status.Compatible   }, // Parallel Road Tool
                    { 1400711138uL, Status.Compatible   }, // [BETA] Parallel Road Tool
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
                SourceURL = "https://github.com/rob-williams/CashOnDemandMod/",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1232451940uL, "调整金钱") {
                Affect = Factor.Money,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 409171141uL, // Cash on Demand
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313uL, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892uL, Status.Incompatible }, // AutoMoney
                    { 1367444256uL, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940uL, Status.Incompatible }, // 调整金钱
                    { 409171141uL , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556uL, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325uL, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319uL, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236uL, Status.Compatible   }, // CS-Utils
                    { 855704599uL , Status.Compatible   }, // Set your own Start Money amount
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
                ReplaceWith = 2036484892uL, // AutoMoney
            });
        }
    }
}
