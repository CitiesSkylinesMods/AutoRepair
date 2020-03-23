namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
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
        }

        /// <summary>
        /// Gets the list of workshop items, keyed by Steam Workshop ID.
        /// </summary>
        public Dictionary<ulong, Item> Items { get; private set; }

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
                Log.Info($"# ERROR: Item {item.WorkshopId} <{item.Catalog}> {item.WorkshopName} already in Items list!");
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
                Log.Info($"# ERROR: Item {item.WorkshopId} <{item.Catalog}> {item.WorkshopName} already in Items list!");
                return item;
            }

            item.Validate();

            Items.Add(item.WorkshopId, item);

            return item;
        }

        private void AddCatalogs() {
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
            RepairCatalog();
            SkyclothCatalog();
            ToolbarCatalog();
            TrafficCatalog();
            TreesCatalog();
            VehicleEffectsCatalog();
            VehiclesCatalog();
            VisualEffectsCatalog();
        }

        /// <summary>
        /// Validates the items that have been added to catalog to check if thier
        /// references to other items are listed and, if applicable, reciprocated.
        /// </summary>
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

                    log.AppendFormat(
                        "\n{0} <{1}> \"{2}\":\n{3}",
                        item.WorkshopId,
                        item.Catalog,
                        item.WorkshopName,
                        itemLog);
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

                if (Items.TryGetValue(targetId, out var target)) {

                    // we can skip reciprocal checks for required/recommended targets
                    if ((targetStatus & (Status.Required | Status.Recommended)) == 0) {

                        if (target.Compatibility == null || target.Compatibility.Count == 0) {

                            compatProblems = true;
                            itemLog.AppendFormat(
                                "- Compatibility field missing: {0} <{1}> \"{2}\"\n",
                                targetId,
                                target.Catalog,
                                target.WorkshopName);

                        } else if (target.Compatibility.TryGetValue(item.WorkshopId, out var status)) {

                            if (status != targetStatus) {

                                compatProblems = true;
                                itemLog.AppendFormat(
                                    "- Reciprocated status mismatch from: {0} <{1}> \"{2}\"\n",
                                    targetId,
                                    target.Catalog,
                                    target.WorkshopName);
                            }

                        } else {

                            compatProblems = true;
                            itemLog.AppendFormat(
                                "- No reciprocation from: {0} <{1}> \"{2}\"\n",
                                targetId,
                                target.Catalog,
                                target.WorkshopName);
                        }
                    }

                } else {

                    compatProblems = true;
                    itemLog.AppendFormat(
                        "- Compatibility[{0}] not found in Catalog.Items\n",
                        targetId);

                }
            }

            return compatProblems;
        }
    }
}
