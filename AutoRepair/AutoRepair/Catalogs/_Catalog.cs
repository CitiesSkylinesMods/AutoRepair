namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using AutoRepair.Lists;
    using AutoRepair.Util;
    using ColossalFramework.PlatformServices;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using static ColossalFramework.Plugins.PluginManager;

    /// <summary>
    /// The main catalog of items.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
    [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
    public partial class Catalog {

        /// <summary>
        /// Culture used for the <see cref="WorkshopDate(string)"/> method.
        /// </summary>
        private static readonly CultureInfo WorkshopCulture = new CultureInfo("en-GB");

        /// <summary>
        /// Internal reference to active instance.
        /// </summary>
        private static Catalog instance;

        /// <summary>
        /// Value to use for notes. Access via <see cref="NOTE"/> property to ensure it increments.
        /// </summary>
        private static ulong note = 100000000u;

        /// <summary>
        /// Initializes a new instance of the <see cref="Catalog"/> class.
        /// </summary>
        public Catalog() {
            Log.Info("Catalog Opened\n");
            Reviews = new Dictionary<ulong, Review>();
            AddReviews();
            Validate();
            LogTally();
        }

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
        /// Gets the number of items currently defined in the catalog.
        /// </summary>
        public int Count => Reviews == null ? 0 : Reviews.Count;

        /// <summary>
        /// Gets the list of reviewed Steam Workshop items.
        /// </summary>
        public Dictionary<ulong, Review> Reviews { get; private set; }

        /// <summary>
        /// Opens the catalog (creates instance).
        /// </summary>
        /// 
        /// <returns>Returns the catalog instance.</returns>
        public static Catalog Open() {
            return Instance;
        }

        /// <summary>
        /// Closes the catalog to allow gc to recover used RAM.
        /// </summary>
        public static void Close() {
            Log.Info("Catalog Closed\n");
            if (instance?.Reviews != null) {
                instance.Reviews.Clear();
            }
            instance = null;
        }

        /// <summary>
        /// Check if a Steam Workshop item has a review in the catalog.
        /// </summary>
        /// 
        /// <param name="workshopId">The Steam Workshop id for the item.</param>
        /// 
        /// <returns>Returns <c>true</c> if reviewed, otherwise <c>false</c>.</returns>
        public bool Has(ulong workshopId) {
            return Reviews.ContainsKey(workshopId);
        }

        /// <summary>
        /// Retrieve a review for the specified item.
        /// </summary>
        ///
        /// <param name="plugin">The <see cref="PluginInfo"/> to review.</param>
        /// <param name="review">The assessment, if found.</param>
        /// 
        /// <returns>Returns <c>true</c> if the item was found, otherwise <c>false</c>.</returns>
        public bool TryGetReview(PluginInfo plugin, out Review review) {

            if (Reviews.TryGetValue(plugin.publishedFileID.AsUInt64, out var value)) {
                review = value;
                return true;
            }

            review = null;
            return false;
        }

        /// <summary>
        /// Retrieve a review for the specified item.
        /// </summary>
        /// 
        /// <param name="publishedFileId">The <see cref="PublishedFileId"/> to review.</param>
        /// <param name="review">The assessment, if found.</param>
        /// 
        /// <returns>Returns <c>true</c> if the item was found, otherwise <c>false</c>.</returns>
        public bool TryGetReview(PublishedFileId publishedFileId, out Review review) {

            if (Reviews.TryGetValue(publishedFileId.AsUInt64, out var value)) {
                review = value;
                return true;
            }

            review = null;
            return false;
        }

        /// <summary>
        /// Retrieve a review for the specified item.
        /// </summary>
        /// 
        /// <param name="workshopId">The Steam Workshop ID to review.</param>
        /// <param name="review">The assessment, if found.</param>
        /// 
        /// <returns>Returns <c>true</c> if the item was found, otherwise <c>false</c>.</returns>
        public bool TryGetReview(ulong workshopId, out Review review) {

            if (Reviews.TryGetValue(workshopId, out var value)) {
                review = value;
                return true;
            }

            review = null;
            return false;
        }

        /// <summary>
        /// Add a mod review to the catalog.
        /// </summary>
        /// 
        /// <param name="review">The review of the mod.</param>
        private void AddMod(Review review) {
            if (Has(review.WorkshopId)) {
                Log.Info($"### ERROR: AddMod() already in list:\n- Existing: {Reviews[review.WorkshopId]}\n- Duplicate: {review}\n");
                return;
            }

            review.ItemType = ItemTypes.Mod;

            // to help track down which item is failing:
            // uncomment following and edit catalog if you are getting duplicate key errors
            /*
            if (review.Catalog == "Balance") {
                Log.Info($"# {review.WorkshopName}");
            }
            /**/

            review.Validate();

            Reviews.Add(review.WorkshopId, review);
        }

        /// <summary>
        /// Add an asset review to the catalog.
        /// </summary>
        /// 
        /// <param name="item">The review of the asset.</param>
        private void AddAsset(Review item) {
            item.ItemType = ItemTypes.Asset;

            if (Has(item.WorkshopId)) {
                Log.Info($"### ERROR: AddAsset() already in list:\n- Existing: {Reviews[item.WorkshopId]}\n- Duplicate: {item}\n");
                return;
            }

            //review.Validate();

            Reviews.Add(item.WorkshopId, item);
        }

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

            foreach (KeyValuePair<ulong, Review> entry in Reviews) {
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

        private void AddReviews() {
            Stopwatch timer = Stopwatch.StartNew();

            try {
                VanillaMods(); // mods bundled with base game
                UnsortedMods(); // currently uncategorised items

                AssetsCatalog(); // actual assets, not mods

                AudioEffectMods();
                BalanceMods();
                BuildingLevelMods();
                BulldozeMods();
                CameraMods();
                SocialMods();
                ContentManagerMods();
                ConverterMods();
                DiagnosticMods();
                EnvironmentMods();
                EditorMods();
                EmptyingMods();
                HideRemoveMods();
                LoadSaveMods();
                MapThemesMods();
                MoneyMods();
                MultiplayerMods();
                MusicMods();
                NetworkMods();
                OutsideConnectionMods();
                PaintMods();
                PlaceAndMoveMods();
                PollutionMods();
                ProceduralMods();
                PublicTransportMods();
                RepairMods();
                ServiceMods();
                SkinBuildingMods();
                SkinNetworkMods();
                SkinRoadsUnitedMods();
                SkinTrafficLightsMods();
                SkinUIMods();
                SkyclothsMods();
                StatsMods();
                ToolbarMods();
                TrafficMods();
                TranslationMods();
                TreeMods();
                UnlimiterMods();
                UnlockerMods();
                VehicleEffectMods();
                VehicleMods();
                VisualEffectMods();

                CatalogAddendum(); // items affected by recent update + temporary kludges
            }
            catch (Exception e) {
                Log.Error(e.ToString());
            }

            timer.Stop();
            Log.Info($"Catalog initialisation took {timer.ElapsedMilliseconds}ms");
        }

        /// <summary>
        /// Tries to parse a date string from Steam Workshop page in to a <see cref="DateTime"/> instance.
        ///
        /// Format it expects is: d MMM, yyyy
        /// </summary>
        /// 
        /// <param name="dateStr">The string copied from sidebar on item Workshop page.</param>
        /// 
        /// <returns>A <see cref="DateTime"/> instance.</returns>
        public DateTime WorkshopDate(string dateStr) {
            try {
                return DateTime.ParseExact(dateStr, "d MMM, yyyy", WorkshopCulture);
            } catch {
                Log.Info($"Invlaid date format '{dateStr}'; last added item was {Reviews.Last().Key}");
                return default;
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

            //VerifyIds();

            bool problems = false;

            StringBuilder log = new StringBuilder(1024 * 100);

            foreach (KeyValuePair<ulong, Review> record in Reviews) {

                Review item = record.Value;

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
        /// <param name="extendedReporting">If <c>false</c>, only basic reporting is performed.</param>
        /// <param name="itemLog">The item log string builder.</param>
        /// 
        /// <returns>Returns <c>true</c> if there are problems, otherwise <c>false</c>.</returns>
        private bool HasBasicProblems(Review item, bool extendedReporting, ref StringBuilder itemLog) {

            bool basicProblems = false;

            // clone/continuation checks
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
            }

            // unrecognised locale check
            if (!Locale.Has(item.Locale)) {
                basicProblems = true;
                itemLog.AppendFormat(
                    "- Unrecognised locale (add to Locale.FromId list): {0}\n",
                    item.Locale);
            }

            // older replacement check
            if (!item.Suppresses(Warning.OlderReplacement)
                && item.WorkshopId > item.ReplaceWith // older item
                && item.ReplaceWith > 1000 // that isn't vanilla
            ) {
                basicProblems = true;
                itemLog.AppendFormat(
                    "- Caution: ReplaceWith is older: {0}uL\n",
                    item.ReplaceWith);
            }

            // todo: check for unrecognised locales in Languages list if present

            // check ReplaceWith - in catalog? recursive? unsquised chain?
            Review target = item;
            ulong nextTarget = target.ReplaceWith;
            List<ulong> chain = new List<ulong>() { nextTarget };
            bool recursion = false;
            bool debug = false; // eg: item.WorkshopId == 1393966192u;

            if (debug) {
                itemLog.Append($" Debugging...\n");
            }

            while (nextTarget != 0uL) {

                if (debug) {
                    itemLog.Append($" Debug: nextTarget = {nextTarget}\n");
                }

                if (Has(nextTarget)) {

                    if (debug) {
                        itemLog.Append($" Debug: Has(nextTarget) = true\n");
                    }

                    target = Reviews[nextTarget];
                    nextTarget = target.ReplaceWith;

                    if (debug) {
                        itemLog.Append($" Debug: Queue nextTarget = {nextTarget}\n");
                    }

                    if (nextTarget != 0uL) {
                        if (chain.Contains(nextTarget)) {
                            recursion = true;

                            if (debug) {
                                itemLog.Append($" Debug: Recursion detected\n");
                            }
                        }

                        chain.Add(nextTarget);

                        if (debug) {
                            itemLog.Append($" Debug: chain.Count = {chain.Count}\n");
                        }

                        if (recursion) {
                            basicProblems = true;
                            itemLog.Append("- WARNING! Recursion in ReplaceWith chain!\n");
                            break;
                        }
                    }

                } else {

                    if (debug) {
                        itemLog.Append($" Debug: Has(nextTarget) = false\n");
                    }

                    if (extendedReporting) {
                        basicProblems = true;
                        itemLog.AppendFormat(
                            "- ReplaceWith not in Catalog.Items: {0}uL\n",
                            target.ReplaceWith);
                    }

                    break;
                }
            }

            if (debug) {
                itemLog.Append($" Debug: squish? chain.Count = {chain.Count}\n");
            }

            if (chain.Count > 1) {
                itemLog.Append("- Squish ReplaceWith chain:\n");
                foreach (ulong replacement in chain) {
                    itemLog.AppendFormat("  - {0} \"{1}\"\n", replacement, GetNameFromId(replacement));
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
        private bool HasCompatibilityProblems(Review item, bool extendedReporting, ref StringBuilder itemLog) {

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

                if (Reviews.TryGetValue(targetId, out var target) && target.Catalog != "Addendum") {

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
                                    "  - Change to: {{ {0,-12}, Status.{1,-12} }}, // {2}\n",
                                    $"{item.WorkshopId}uL",
                                    targetStatus,
                                    item.WorkshopName);
                            }

                        } else {

                            compatProblems = true;
                            itemLog.AppendFormat("- No reciprocation from: {0}\n", target);
                            itemLog.AppendFormat(
                                "  - Add: {{ {0,-12}, Status.{1,-12} }}, // {2}\n",
                                $"{item.WorkshopId}uL",
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
