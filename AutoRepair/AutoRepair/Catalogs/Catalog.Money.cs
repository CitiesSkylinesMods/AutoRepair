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
        private void MoneyCatalog() {

            string catalog = "Money";

            AddMod(new Item(2036484892u, "AutoMoney") {
                Affect = Factor.Money,
                Authors = "bansz",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 409171141, // Cash on Demand
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Item(2030216556u, "GrantMeMoney: get cash / money unconditionally") {
                Affect = Factor.Money,
                Authors = "the weatherman",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2036484892u, Status.Compatible   }, // AutoMoney
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                    { 1367444256u, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Compatible   }, // 调整金钱
                    { 409171141u , Status.Compatible   }, // Cash on Demand
                },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/NJAldwin/GrantMeMoney",
            });

            // todo: conflict with vanilla
            AddMod(new Item(1949192313u, "UnlimitedMoney") {
                Affect = Factor.Money,
                Authors = "j.a.pasterkamp",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // these mods are pointless when unlimited money is active:
                    { 2036484892u, Status.MinorIssues  }, // AutoMoney
                    { 2030216556u, Status.MinorIssues  }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils
                    { 1367444256u, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.MinorIssues  }, // 调整金钱
                    { 409171141u , Status.MinorIssues  }, // Cash on Demand
                },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "The base game comes with its own unlimited money mod, use that instead." },
                },
            });

            AddMod(new Item(1673480325u, "£5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // same assembly conflicts:
                    { 1673480325u, Status.Incompatible }, // £5 Million Starting Money
                    { 1671542319u, Status.Incompatible }, // £2.5 Million Starting Money

                    // similar but non-conflicting mods:
                    { 2036484892u, Status.Compatible   }, // AutoMoney
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                    { 1367444256u, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Compatible   }, // 调整金钱
                    { 409171141u , Status.Compatible   }, // Cash on Demand
                },
                ContinuationOf = 1671542319u, // £2.5 Million Starting Money
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1671542319u, "£2.5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // same assembly conflicts:
                    { 1673480325u, Status.Incompatible }, // £5 Million Starting Money
                    { 1671542319u, Status.Incompatible }, // £2.5 Million Starting Money

                    // similar but non-conflicting mods:
                    { 2036484892u, Status.Compatible   }, // AutoMoney
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                    { 1367444256u, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Compatible   }, // 调整金钱
                    { 409171141u , Status.Compatible   }, // Cash on Demand
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1367444256u, "Cash/Money On Demand 500k") {
                Affect = Factor.Money,
                Authors = "Jay",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892u, Status.Incompatible }, // AutoMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                },
                ContinuationOf = 409171141u, // Cash on Demand
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
            });

            // Also has limits display but people really only use it to add money on demand
            AddMod(new Item(1330289236u, "CS-Utils") {
                Affect = Factor.Money,
                Authors = "kartoffelx86",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // similar but non-conflicting mods:
                    { 2036484892u, Status.Compatible   }, // AutoMoney
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                    { 1367444256u, Status.Compatible   }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Compatible   }, // 调整金钱
                    { 409171141u , Status.Compatible   }, // Cash on Demand
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1232451940u, "调整金钱") {
                Affect = Factor.Money,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 409171141u, // Cash on Demand
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892u, Status.Incompatible }, // AutoMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
            });

            AddMod(new Item(409171141u, "Cash on Demand") {
                Affect = Factor.Money,
                Authors = "UndergroundHero",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // pointless if any of these mods are active:
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { Vanilla.UnlimitedMoney, Status.MinorIssues },

                    // shortcut conflicts
                    { 2036484892u, Status.Incompatible }, // AutoMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    // similar but non-conflicting mods:
                    { 2030216556u, Status.Compatible   }, // GrantMeMoney: get cash / money unconditionally
                    { 1673480325u, Status.Compatible   }, // £5 Million Starting Money
                    { 1671542319u, Status.Compatible   }, // £2.5 Million Starting Money
                    { 1330289236u, Status.Compatible   }, // CS-Utils
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Use Ctrl+Shift+M (Mac users: Cmd+Shift+M) to add cash." },
                },
                SourceURL = "https://github.com/rob-williams/CashOnDemandMod/",
            });
        }
    }
}
