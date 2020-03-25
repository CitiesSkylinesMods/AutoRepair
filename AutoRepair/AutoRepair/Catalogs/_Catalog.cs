namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Text;

    /// <summary>
    /// The main catalog of items.
    /// </summary>
    public partial class Catalog {

        private static Catalog instance;

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
        }

        /// <summary>
        /// Gets the list of workshop items, keyed by Steam Workshop ID.
        /// </summary>
        public Dictionary<ulong, Item> Items { get; private set; }

        public Dictionary<Status, int> Tally = new Dictionary<Status, int>() {
            { Status.Unknown     , 0 },
            { Status.Incompatible, 0 },
            { Status.MinorIssues , 0 },
            { Status.Compatible  , 0 },
            { Status.Recommended , 0 },
            { Status.Required    , 0 },
        };

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
            VanillaCatalog(); // mods bundled with base game
            UnsortedCatalog(); // currently uncategorised items

            AchievementsCatalog();
            AudioEffectsCatalog();
            BalanceCatalog();
            BuildingLevelCatalog();
            BuildingThemesCatalog();
            BulldozeCatalog();
            CameraCatalog();
            ContentManagerCatalog();
            DiagnosticCatalog();
            DoshCatalog();
            EmptyingCatalog();
            HideCatalog();
            LoadingCatalog();
            MultiplayerCatalog();
            MusicCatalog();
            NetworksCatalog();
            PaintCatalog();
            PlaceAndMoveCatalog();
            ProceduralCatalog();
            PublicTransportCatalog();
            RepairCatalog();
            SkyclothCatalog();
            ToolbarCatalog();
            TrafficCatalog();
            TreesCatalog();
            VehicleEffectsCatalog();
            VehiclesCatalog();
            VisualEffectsCatalog();

            CatalogAddendum(); // items affected by recent update
        }

        /// <summary>
        /// Validates the items that have been added to catalog to check if thier
        /// references to other items are listed and, if applicable, reciprocated.
        /// </summary>
        [Conditional("DEBUG")]
        private void Validate() {

            bool problems = false;

            StringBuilder log = new StringBuilder(1024 * 10);

            foreach (KeyValuePair<ulong, Item> record in Items) {

                Item item = record.Value;

                bool itemProblems = false;

                StringBuilder itemLog = new StringBuilder(1024);

                if (HasBasicProblems(item, ref itemLog)) {
                    itemProblems = true;
                }

                if (HasCompatibilityProblems(item, ref itemLog)) {
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
        private bool HasBasicProblems(Item item, ref StringBuilder itemLog) {

            bool basicProblems = false;

            // if clone, check it's in catalog
            if (item.CloneOf != 0u && !Items.ContainsKey(item.CloneOf)) {
                basicProblems = true;
                itemLog.AppendFormat(
                    "- CloneOf not in Catalog.Items: {0}\n",
                    item.CloneOf);
            }

            // if continuation, check it's in catalog
            if (item.ContinuationOf != 0u && !Items.ContainsKey(item.ContinuationOf)) {
                basicProblems = true;
                itemLog.AppendFormat(
                    "- ContinuationOf not in Catalog.Items: {0}\n",
                    item.ContinuationOf);
            }

            // if replacement, check it's in catalog
            if (item.ReplaceWith != 0u && !Items.ContainsKey(item.ReplaceWith)) {
                basicProblems = true;
                itemLog.AppendFormat(
                    "- ReplaceWith not in Catalog.Items: {0}\n",
                    item.ReplaceWith);
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
        private bool HasCompatibilityProblems(Item item, ref StringBuilder itemLog) {

            if (item.Compatibility == null || item.Compatibility.Count == 0) {
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

                if (Items.TryGetValue(targetId, out var target)) {

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
                                    "  - Should be: {{ {0,-11}, Status.{1,-12} }}, // {2}\n",
                                    $"{item.WorkshopId}u",
                                    targetStatus,
                                    item.WorkshopName);
                            }

                        } else {

                            compatProblems = true;
                            itemLog.AppendFormat("- No reciprocation from: {0}\n", target);
                            itemLog.AppendFormat(
                                "  - Should be: {{ {0,-11}, Status.{1,-12} }}, // {2}\n",
                                $"{item.WorkshopId}u",
                                targetStatus,
                                item.WorkshopName);
                        }
                    }

                } else {

                    //compatProblems = true;
                    itemLog.AppendFormat("- Compatibility[{0}] not found in Catalog.Items\n", targetId);

                }
            }

            return compatProblems;
        }
    }
}
