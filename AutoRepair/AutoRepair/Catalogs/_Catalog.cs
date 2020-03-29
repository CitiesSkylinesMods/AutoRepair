namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// The main catalog of items.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Internal reference to active instance.
        /// </summary>
        private static Catalog instance;

        /// <summary>
        /// Value to use for notes. Access via <see cref="NOTE"/> property to ensure it increments.
        /// </summary>
        private static ulong note = 100000000u;

        /// <summary>
        /// Gets id to use for "always show" Notes fields in item descriptors.
        ///
        /// Values from <c>100000000u</c> to <c>200000000u</c> are treated as "always show".
        ///
        /// Values less than <c>100000000u</c> are reserved for vanilla game stuff (DLCs, bundled mods, etc).
        /// </summary>
        public static ulong NOTE => ++note;

        /// <summary>
        /// Gets the reference to the catalog instance.
        /// </summary>
        public static Catalog Instance => instance ?? (instance = new Catalog());

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog"/> class.
        /// </summary>
        public Catalog() {
            Items = new Dictionary<ulong, Item>();
            AddCatalogs();
            Validate();
            LogTally();
            //DumpCatalog();
        }

        /// <summary>
        /// Gets the list of workshop items, keyed by Steam Workshop ID.
        /// </summary>
        public Dictionary<ulong, Item> Items { get; private set; }


        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        public Dictionary<Status, int> Tally = new Dictionary<Status, int>() {
            { Status.Unknown     , 0 },
            { Status.Incompatible, 0 },
            { Status.MinorIssues , 0 },
            { Status.Compatible  , 0 },
            { Status.Recommended , 0 },
            { Status.Required    , 0 },
        };

        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private readonly Dictionary<Status, Status> ValidReciprocalsFor = new Dictionary<Status, Status>() {
            { Status.Unknown     , Status.Unknown },
            { Status.Incompatible, Status.Incompatible },
            { Status.MinorIssues , Status.MinorIssues },
            { Status.Compatible  , Status.Compatible | Status.Recommended | Status.Required },
            { Status.Recommended , Status.Compatible | Status.Recommended | Status.Required },
            { Status.Required    , Status.Compatible | Status.Recommended },
        };

        [Conditional("DEBUG")]
        private void LogTally() {

            StringBuilder log = new StringBuilder(500);

            log.Append("\nSTATS:\n");

            foreach (KeyValuePair<Status, int> stat in Tally) {
                log.AppendFormat(
                    "{0} x {1}\n",
                    stat.Value,
                    stat.Key);
            }

            Log.Info(log.ToString());
        }

        [Conditional("DEBUG")]
        private void DumpCatalog() {

            StringBuilder log = new StringBuilder(1024 * 100);

            log.Append("\nCATALOG:\n");

            foreach (KeyValuePair<ulong, Item> entry in Items) {
                log.AppendFormat("- {0}\n", entry.Value);
            }

            /* this throws exception, don't have time right now to investigate or fix
            List<Item> sortedItems = (List<Item>)Items.Values.OrderBy(i => i.WorkshopId);
            foreach (Item item in sortedItems) {
                log.AppendFormat("- {0}\n", item);
            }
            */

            Log.Info(log.ToString());
        }

        /// <summary>
        /// Adds a mod item to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add.</param>
        ///
        /// <returns>Returns the item.</returns>
        private Item AddMod(Item item) {
            item.ItemType = ItemTypes.Mod;

            if (Items.ContainsKey(item.WorkshopId)) {
                Log.Info($"### ERROR: {item} already in Items list!");
                return item;
            }

            item.Validate();

            Items.Add(item.WorkshopId, item);

            return item;
        }

        /// <summary>
        /// Adds an asset item to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add.</param>
        ///
        /// <returns>Returns the item.</returns>
        private Item AddAsset(Item item) {
            item.ItemType = ItemTypes.Asset;

            if (Items.ContainsKey(item.WorkshopId)) {
                Log.Info($"### ERROR: {item} already in Items list!");
                return item;
            }

            item.Validate();

            Items.Add(item.WorkshopId, item);

            return item;
        }

        private void AddCatalogs() {
            try {
                VanillaCatalog(); // mods bundled with base game
                UnsortedCatalog(); // currently uncategorised items

                AssetsCatalog(); // actual assets, not mods

                AchievementsCatalog();
                AudioEffectsCatalog();
                BalanceCatalog();
                BuildingLevelCatalog();
                BuildingThemesCatalog();
                BulldozeCatalog();
                CameraCatalog();
                ContentManagerCatalog();
                ConvertersCatalog();
                DiagnosticCatalog();
                EmptyingCatalog();
                HideCatalog();
                LoadSaveCatalog();
                MoneyCatalog();
                MultiplayerCatalog();
                MusicCatalog();
                NetworksCatalog();
                PaintCatalog();
                PlaceAndMoveCatalog();
                ProceduralCatalog();
                PublicTransportCatalog();
                RepairCatalog();
                ServicesCatalog();
                SkinRoadsCatalog();
                SkinRoadsUnitedCatalog();
                SkyclothCatalog();
                StatsCatalog();
                ToolbarCatalog();
                TrafficCatalog();
                TreesCatalog();
                UnlimitersCatalog();
                VehicleEffectsCatalog();
                VehiclesCatalog();
                VisualEffectsCatalog();

                CatalogAddendum(); // items affected by recent update + temporary kludges
            }
            catch (Exception e) {
                Log.Error(e.ToString());
            }
        }

        public bool Has(ulong workshopId) {
            return Items.ContainsKey(workshopId);
        }

        public bool TryGetValue(ulong workshopId, out Item item) {
            if (Items.TryGetValue(workshopId, out var result)) {
                item = result;
                return true;
            } else {
                item = null;
                return false;
            }
        }

        /// <summary>
        /// Validates the items that have been added to catalog to check if thier
        /// references to other items are listed and, if applicable, reciprocated.
        /// </summary>
        /// 
        /// <param name="extendedReporting">If <c>true</c>, do more extensive validation checks.</param>
        [Conditional("DEBUG")]
        private void Validate(bool extendedReporting = false) {

            bool problems = false;

            StringBuilder log = new StringBuilder(1024 * 50);

            foreach (KeyValuePair<ulong, Item> record in Items) {

                Item item = record.Value;

                bool itemProblems = false;

                StringBuilder itemLog = new StringBuilder(1024 * 5);

                if (HasBasicProblems(item, extendedReporting, ref itemLog)) {
                    itemProblems = true;
                }

                if (HasCompatibilityProblems(item, extendedReporting, ref itemLog)) {
                    itemProblems = true;
                }

                if (itemProblems) {
                    problems = true;

                    log.AppendFormat("\n{0}:\n{1}", item, itemLog);
                }
            }

            if (problems) {
                Log.Info(log.ToString());
            }
        }

        /// <summary>
        /// Checks that an item's <c>CloneOf</c>, <c>ContinuationOf</c> and <c>ReplaceWith</c>
        /// fields, if used, have corresponding items in <c>Catalog.Items</c>.
        /// </summary>
        /// 
        /// <param name="item">The item to validate.</param>
        /// <param name="itemLog">The item log string builder.</param>
        /// 
        /// <returns>Returns <c>true</c> if there are problems, otherwise <c>false</c>.</returns>
        private bool HasBasicProblems(Item item, bool extendedReporting, ref StringBuilder itemLog) {

            bool basicProblems = false;

            if (extendedReporting) {
                // if clone, check it's in catalog
                if (item.CloneOf != 0u && !Has(item.CloneOf)) {
                    basicProblems = true;
                    itemLog.AppendFormat(
                        "- CloneOf not in Catalog.Items: {0}\n",
                        item.CloneOf);
                }

                // if continuation, check it's in catalog
                if (item.ContinuationOf != 0u && !Has(item.ContinuationOf)) {
                    basicProblems = true;
                    itemLog.AppendFormat(
                        "- ContinuationOf not in Catalog.Items: {0}\n",
                        item.ContinuationOf);
                }

                // if replacement, check it's in catalog
                if (item.ReplaceWith != 0u && !Has(item.ReplaceWith)) {
                    basicProblems = true;
                    itemLog.AppendFormat(
                        "- ReplaceWith not in Catalog.Items: {0}\n",
                        item.ReplaceWith);
                }
            }

            return basicProblems;
        }

        /// <summary>
        /// If the item specifies a <c>Compatibility</c> dictionary, check that the items
        /// listed within it a) exist in <c>Catalog.Items</c> and the target item has
        /// a reciprocal entry in its own <c>Compatibility</c> dictionary.
        /// </summary>
        /// 
        /// <param name="item">The item to validate.</param>
        /// <param name="itemLog">The item log string builder.</param>
        /// 
        /// <returns>Returns <c>true</c> if there are problems, otherwise <c>false</c>.</returns>
        private bool HasCompatibilityProblems(Item item, bool extendedReporting, ref StringBuilder itemLog) {

            if (item.Compatibility == null || item.Compatibility.Count == 0 || item.Catalog == "Addendum") {
                return false;
            }

            bool compatProblems = false;

            foreach (KeyValuePair<ulong, Status> reference in item.Compatibility) {
                ulong targetId = reference.Key;
                Status targetStatus = reference.Value;

                if (targetStatus == Status.None) {
                    compatProblems = true;
                    itemLog.AppendFormat("- ### Invalid status for: Compatibility[{0}]\n", targetId);
                    continue;
                }

                if (targetId == item.WorkshopId) {
                    continue;
                }

                Tally[targetStatus] += 1;

                if (Items.TryGetValue(targetId, out var target) && target.Catalog != "Addendum") {

                    // skip reciprocal checks for required/recommended targets
                    // (could maybe add in later, requiring compatible reciprocate, but too much work for now)
                    if ((targetStatus & (Status.Required | Status.Recommended)) == 0) {

                        if (target.Compatibility == null) {

                            compatProblems = true;
                            itemLog.AppendFormat("- Compatibility field missing: {0}\n", target);

                        } else if (target.Compatibility.TryGetValue(item.WorkshopId, out var status)) {

                           if ((ValidReciprocalsFor[targetStatus] & status) == 0) {

                                compatProblems = true;
                                itemLog.AppendFormat("- Reciprocate mismatch from: {0}\n", target);
                                itemLog.AppendFormat(
                                    "  - Change to: {{ {0,-11}, Status.{1,-12} }}, // {2}\n",
                                    $"{item.WorkshopId}u",
                                    targetStatus,
                                    item.WorkshopName);
                            }

                        } else {

                            compatProblems = true;
                            itemLog.AppendFormat("- No reciprocation from: {0}\n", target);
                            itemLog.AppendFormat(
                                "  - Add: {{ {0,-11}, Status.{1,-12} }}, // {2}\n",
                                $"{item.WorkshopId}u",
                                targetStatus,
                                item.WorkshopName);
                        }
                    }

                } else if (extendedReporting) {

                    compatProblems = true;
                    itemLog.AppendFormat("- Compatibility[{0}] not found in Catalog.Items\n", targetId);

                }
            }

            return compatProblems;
        }
    }
}
