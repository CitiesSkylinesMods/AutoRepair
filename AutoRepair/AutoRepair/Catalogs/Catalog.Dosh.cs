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
        private void DoshCatalog() {

            string catalog = "Dosh";

            // todo: conflict with vanilla
            AddMod(new Item(1949192313u, "UnlimitedMoney") {
                Affect = Factor.Money,
                Authors = "j.a.pasterkamp",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils
                    { 1367444256u, Status.MinorIssues  }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.MinorIssues  }, // 调整金钱
                    { 409171141u , Status.MinorIssues  }, // Cash on Demand

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1673480325u, "£5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                ContinuationOf = 1671542319u, // £2.5 Million Starting Money
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1671542319u, "£2.5 Million Starting Money") {
                Affect = Factor.Money,
                Authors = "Mister Doctor",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            // Ctrl+shift+m to get fraud tokens
            // Based on earlier mod but with larger quantity of numbered rectangles.
            AddMod(new Item(1367444256u, "Cash/Money On Demand 500k") {
                Affect = Factor.Money,
                Authors = "Jay",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                ContinuationOf = 409171141u, // Cash on Demand
                Flags = ItemFlags.SourceUnavailable,
            });

            // Also has limits display but people really only use it to add money on demand
            AddMod(new Item(1330289236u, "CS-Utils") {
                Affect = Factor.Money,
                Authors = "kartoffelx86",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1673480325u, Status.MinorIssues  }, // £5 Million Starting Money
                    { 1671542319u, Status.MinorIssues  }, // £2.5 Million Starting Money
                    { 1330289236u, Status.MinorIssues  }, // CS-Utils

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.SourceUnavailable,
            });

            // Ctrl+shift+m to get fraud tokens
            AddMod(new Item(1232451940u, "调整金钱") {
                Affect = Factor.Money,
                Authors = "TIMIYANG",
                Catalog = catalog,
                CloneOf = 409171141u, // Cash on Demand
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Localised,
                Locale = "zh-cn",
            });

            // Ctrl+shift+m to get fraud tokens
            AddMod(new Item(409171141u, "Cash on Demand") {
                Affect = Factor.Money,
                Authors = "UndergroundHero",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1949192313u, Status.MinorIssues  }, // UnlimitedMoney
                    { 1367444256u, Status.Incompatible }, // Cash/Money On Demand 500k
                    { 1232451940u, Status.Incompatible }, // 调整金钱
                    { 409171141u , Status.Incompatible }, // Cash on Demand

                    { Vanilla.UnlimitedMoney, Status.MinorIssues }, // Unlimited Money (bundled with Cities: Skylines)
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/rob-williams/CashOnDemandMod/",
            });
        }
    }
}
