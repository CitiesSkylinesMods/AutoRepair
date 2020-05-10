namespace AutoRepair.Descriptors {
    using AutoRepair.Catalogs;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Descriptor for a workshop item.
    /// </summary>
    public class Review {

        /// <summary>
        /// Used to validate if minimal source flags are set.
        /// </summary>
        internal const ItemFlags SOURCE_DEFINED = ItemFlags.SourceAvailable | ItemFlags.SourceBundled | ItemFlags.SourceUnavailable;

        /// <summary>
        /// Initializes a new instance of the <see cref="Review"/> class.
        ///
        /// If <see cref="ItemType"/> member is not set, the item is ignored.
        /// </summary>
        /// 
        /// <param name="workshopId">The Steam Workshop ID for this item.</param>
        /// <param name="workshopName">The name of this item as it appears in Steam Workshop.</param>
        public Review(ulong workshopId, string workshopName) {
            if (workshopId == 0uL || string.IsNullOrEmpty(workshopName)) {
                throw new ArgumentNullException($"All items must specify both workshop ID '{workshopId}' and name '{workshopName}'.");
            }
            WorkshopId = workshopId;
            WorkshopName = workshopName;
        }

        /// <summary>
        /// Gets or sets flags denoting which factors of the game an item affects or is affeceted by.
        /// Items that affect or are affected by the same factor are potentially incompatible.
        /// </summary>
        public Factor Affect { get; set; } = Factor.None;

        /// <summary>
        /// Gets or sets alternative replacement items. Sometimes there is more than one viable replacement;
        /// in such cases, set <see cref="ReplaceWith"/> to the main one, and list the others as <see cref="Alternatives"/>.
        /// </summary>
        public ulong[] Alternatives { get; set; }

        /// <summary>
        /// Gets or sets the web archive URL, if known, for items that are no longer in the Steam Workshop.
        /// </summary>
        public string ArchiveURL { get; set; }

        /// <summary>
        /// Gets or sets the authors who developed the item. Comma-separated list.
        /// </summary>
        public string Authors { get; set; }

        /// <summary>
        /// Gets or sets the game version which caused the item to stop working.
        /// </summary>
        public Version BrokenBy { get; set; } = GameVersion.DefaultUntil;

        /// <summary>
        /// Gets or sets the name of the catalog that defined this item.
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// Gets or sets the original Steam Workshop ID from which this item was cloned.
        ///
        /// Should be used in conjunction with <see cref="ItemFlags.Clone"/> flag.
        ///
        /// If the mod is a sucessor, rather than a clone, use <see cref="Review.ContinuationOf"/> instead.
        /// </summary>
        public ulong CloneOf { get; set; }

        /// <summary>
        /// Gets or sets the compatibility between this item and other items.
        ///
        /// Keyed by workshop id of the other items. It is common for items to be
        /// listed as incompatible with themselves to make list maintenance easier
        /// (facilitates copy/paste between groups of similar items).
        /// </summary>
        public Dictionary<ulong, Status> Compatibility { get; set; }

        /// <summary>
        /// Gets or sets the latest version of the game this item is known to be compatible with.
        /// </summary>
        public Version CompatibleWith { get; set; } = GameVersion.DefaultRelease;

        /// <summary>
        /// Gets or sets the Steam Workshop ID of the predecessor of this mod.
        /// </summary>
        public ulong ContinuationOf { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ItemFlags"/> for this item.
        /// </summary>
        public ItemFlags Flags { get; set; } = ItemFlags.None;

        /// <summary>
        /// Gets or sets the <see cref="ItemTypes"/> for this item.
        /// </summary>
        public ItemTypes ItemType { get; set; } = ItemTypes.None;

        /// <summary>
        /// Gets or sets the list of language locales that this item natively supports.
        /// </summary>
        public string[] Languages { get; set; }

        /// <summary>
        /// Gets or sets the date on which the item was last seen in the workshop.
        ///
        /// Used to display 'vapour bar' in timeline view.
        /// </summary>
        public DateTime? LastSeen { get; set; }

        /// <summary>
        /// Gets or sets the item's primary language id. Defaults to <c>"en"</c>.
        /// </summary>
        public string Locale { get; set; } = "en";

        /// <summary>
        /// Gets or sets arbitrary notes for the item, which will be displayed in log file.
        ///
        /// Workshop id -> Note.
        ///
        /// String only shown if workshop id subscribed. To make a note always display,
        /// use <see cref="Catalog.NOTE"/> id (value <c>100000000u -> 200000000u</c>).
        /// </summary>
        public Dictionary<ulong, string> Notes { get; set; }

        /// <summary>
        /// Gets or sets the date when the item was published to Steam Workshop.
        /// </summary>
        public DateTime? Published { get; set; }

        /// <summary>
        /// Gets or sets the game version at time when item was first published to workshop, if known.
        /// </summary>
        [Obsolete]
        public Version ReleasedDuring { get; set; } = GameVersion.DefaultRelease;

        /// <summary>
        /// Gets or sets the date on which the item was confirmed as being removed from the workshop.
        /// </summary>
        public DateTime? Removed { get; set; }

        /// <summary>
        /// Gets or sets recommended replacement Steam Workshop ID.
        ///
        /// Use this to help users upgrade to most recent/reliable version of something.
        /// </summary>
        public ulong ReplaceWith { get; set; }

        /// <summary>
        /// Gets or sets DLCs required for this item (<seealso cref="SteamHelper"/>).
        /// </summary>
        public DLCs RequiredDLC { get; set; }

        /// <summary>
        /// Gets or sets the number of <see cref="RequiredModsSelection"/> required.
        /// </summary>
        public Selection RequiredModsSelection { get; set; } = Selection.All;

        /// <summary>
        /// Gets or sets URL to source code.
        /// </summary>
        public string SourceURL { get; set; }

        /// <summary>
        /// Gets or sets flags which can suppress descriptor verification warnings (use with care).
        /// </summary>
        public Warning Suppress { get; set; }

        /// <summary>
        /// Gets or sets tags (labels, keywords) for the item.
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// Gets or sets the date when the item was last updated in Steam Workshop.
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the IUserMod class for this mod has been
        /// inspected to check for bad startup code (code run in constructors or property getters).
        /// </summary>
        public bool UserModInspected { get; set; } = false;

        /// <summary>
        /// Gets or sets the Steam Workshop ID for this item.
        /// </summary>
        public ulong WorkshopId { get; set; }

        /// <summary>
        /// Gets or sets the name of this item as it appears in Steam Workshop.
        /// Note: May be different to <c>UGCDetails.title</c> or <c>PluginInfo.name</c>, etc.
        /// </summary>
        public string WorkshopName { get; set; }

        /// <summary>
        /// Returns a string representation of the item.
        /// </summary>
        /// 
        /// <returns>String representation.</returns>
        public override string ToString() {
            return $"[ID: {WorkshopId}] <{Catalog}> \"{WorkshopName}\"";
        }

        /// <summary>
        /// Returns a string representation of the item.
        /// </summary>
        /// 
        /// <param name="brief">If <c>true</c>, reduce verbosity. Defaults to <c>false</c>.</param>
        /// 
        /// <returns>String representation.</returns>
        public string ToString(bool brief) {
            return brief
                ? HasFlag(ItemFlags.Vanilla)
                    ? $"{WorkshopName}"
                    : $"[ID: {WorkshopId}] \"{WorkshopName}\""
                : $"[ID: {WorkshopId}] <{Catalog}> \"{WorkshopName}\"";
        }

        /// <summary>
        /// Determine whether the item at least one of the specified <see cref="ItemFlags"/>.
        /// </summary>
        /// 
        /// <param name="flags">Flag(s) to check for.</param>
        /// <param name="all">If <c>true</c>, checks that all flags are set.</param>
        /// 
        /// <returns>Returns <c>true</c> if the item has the specified <paramref name="flags"/>, otherwise <c>false</c>.</returns>
        public bool HasFlag(ItemFlags flags, bool all = false) {
            return all
                ? (Flags & flags) == flags
                : (Flags & flags) != ItemFlags.None;
        }

        /// <summary>
        /// Determine whether the item suppresses the specified warning.
        /// </summary>
        /// 
        /// <param name="warning">The <see cref="Warning"/> being checked.</param>
        /// 
        /// <returns>Returns <c>true</c> if <see cref="Suppress"/> contains the <paramref name="warning"/> flag, otherwise <c>false</c>.</returns>
        public bool Suppresses(Warning warning) {
            return (Suppress & warning) != 0;
        }

        /// <summary>
        /// Determines if the item is compatible with the specified <paramref name="workshopId"/>.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of an item in the Steam Workshop.</param>
        /// 
        /// <returns>Returns <c>true</c> if the items are compatible, otherwise <c>false</c>.</returns>
        public bool IsCompatibleWith(ulong workshopId) {
            // if no compatibility list, assume everything is compatible
            if (Compatibility == null || Compatibility.Count == 0) {
                return true;
            }

            // check the status in the list
            if (Compatibility.TryGetValue(workshopId, out var status)) {
                var compatible = Status.Compatible | Status.Recommended | Status.Required;
                return status == Status.Unknown || (status & compatible) != 0;
            } else {
                return true;
            }
        }

        /// <summary>
        /// Verifies data in the <see cref="Review"/> descriptor (does not check other reviews).
        /// </summary>
        /// 
        /// <param name="extendedReporting">If <c>true</c>, do more extensive validation.</param>
        [Conditional("DEBUG")]
        public void Verify(bool extendedReporting = false) {

            try {

                if (!string.IsNullOrEmpty(Catalog) && Catalog == "Addendum") {
                    return;
                }

                bool problems = false;

                StringBuilder log = new StringBuilder(1000);

                log.AppendFormat(
                    "\n{0}:\n",
                    ToString());

                problems = VerifyMandatoryProperties(extendedReporting, ref log) || problems;

                problems = VerifyDateProperties(extendedReporting, ref log) || problems;

                problems = VerifyGameVersionProperties(extendedReporting, ref log) || problems;

                problems = VerifyBranchProperties(extendedReporting, ref log) || problems;

                problems = VerifyUrlProperties(extendedReporting, ref log) || problems;

                problems = VerifyRemainingProperties(extendedReporting, ref log) || problems;

                if (problems) {
                    Log.Info(log.ToString());
                }

            }
            catch (Exception e) {
                Log.Info($"YOU HAVE FAILED THIS DESCRIPTOR: {this}");
                Log.Error(e.ToString());
            }
        }

        /// <summary>
        /// Verifies presence of mandatory properties, logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyMandatoryProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;

            // item type should always be set (check just in case)
            if (ItemType == ItemTypes.None) {
                problems = true;
                log.Append("- ItemType missing\n");
            }

            // items should always affect _something_
            if (Affect == Factor.None) {
                problems = true;
                log.Append("- Affect missing\n");
            }

            // authors should ideally be set
            if (extendedReporting && string.IsNullOrEmpty(Authors)) {
                problems = true;
                log.Append("- Authors missing\n");
            }

            if (string.IsNullOrEmpty(Catalog)) {
                problems = true;
                log.Append("- Catalog missing\n");
            }

            if (Compatibility == null) {
                problems = true;
                log.Append("- Compatibility list missing\n");
            } else if (extendedReporting && Compatibility.Count == 0) {
                problems = true;
                log.Append("- Compatibility list defined, but is empty\n");
            }

            if (Flags == ItemFlags.None) {
                problems = true;
                log.Append("- Flags missing\n");
            }

            return problems;
        }

        /// <summary>
        /// Verifies the <see cref="DateTime"/> properties, logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyDateProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;

            // Published and Updated dates should ideally be set
            if (extendedReporting) { // TODO: always report once most have been defined
                if (Published == null) {
                    problems = true;
                    log.Append("- Published date missing\n");
                }

                if (Updated == null) {
                    problems = true;
                    log.Append("- Updated date missing\n");
                }
            }

            if (LastSeen == null) {
                if (extendedReporting) { // TODO: always report once most have been defined
                    problems = true;
                    log.Append("- LastSeen date missing\n");
                }
            } else {
                if (Published != null && LastSeen < Published) {
                    problems = true;
                    log.Append("- LastSeen < Published\n");
                }
                if (Updated != null && LastSeen < Updated) {
                    problems = true;
                    log.Append("- LastSeen < Updated\n");
                }
                if (Removed != null && LastSeen > Removed) {
                    problems = true;
                    log.Append("- LastSeen > Removed\n");
                }
            }

            // must be neither or both
            if (HasFlag(ItemFlags.NoWorkshop) == (Removed == null)) {
                problems = true;
                log.Append("- The NoWorkshop flag and Removed properties must correlate\n");
            }

            return problems;
        }

        /// <summary>
        /// Verifies the <see cref="GameVersion"/> properties, logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyGameVersionProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;

            if (extendedReporting && CompatibleWith == GameVersion.DefaultRelease) {
                problems = true;
                log.Append("- CompatibleWith missing\n");
            }

            if (!Suppresses(Warning.InvalidVersionSequence)) {

                // TODO: auto-determine ReleasedDuring based on Published date

                if (CompatibleWith < ReleasedDuring) {
                    problems = true;
                    log.Append("- CompatibleWith must be >= ReleasedDuring\n");
                }

                if (BrokenBy < ReleasedDuring) {
                    problems = true;
                    log.Append("- BrokenBy must be >= ReleasedDuring\n");
                }

                if (BrokenBy <= CompatibleWith) {
                    problems = true;
                    log.Append("- BrokenBy must be > CompatibleWith\n");
                }
            }

            // must be neither or both
            if (HasFlag(ItemFlags.BrokenByUpdate) == (BrokenBy == GameVersion.DefaultUntil)) {
                problems = true;
                log.Append("- The BrokenByUpdate flag and BrokenBy properties must correlate\n");
            }

            return problems;
        }

        /// <summary>
        /// Verifies the branching properties (CloneOf, ContinuationOf, ReplaceWith), logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyBranchProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;

            if (CloneOf != 0u && ContinuationOf != 0u) {
                problems = true;
                log.Append("- Can be CloneOf or ContinuationOf, not both\n");
            }

            if (CloneOf != 0uL && IsCompatibleWith(CloneOf)) {
                problems = true;
                log.AppendFormat(
                    "- Must be incompatible with CloneOf item: {0}uL\n",
                    CloneOf);
            }

            if (ContinuationOf != 0uL && IsCompatibleWith(ContinuationOf)) {
                problems = true;
                log.AppendFormat(
                    "- Must be incompatible with ContinuationOf item: {0}uL\n",
                    ContinuationOf);
            }

            if (CloneOf == WorkshopId || ContinuationOf == WorkshopId) {
                problems = true;
                log.Append("- Must not be a CloneOf/ContinuationOf of itself!\n");
            } else if (CloneOf > WorkshopId || ContinuationOf > WorkshopId) {
                problems = true;
                log.Append("- Must not be CloneOf/ContinuationOf a newer item!\n");
            }

            if (ReplaceWith == WorkshopId) {
                problems = true;
                log.Append("- Must not ReplaceWith itself!\n");

            } else if (ReplaceWith != 0u) {

                if (extendedReporting && IsCompatibleWith(ReplaceWith)) {
                    problems = true;
                    log.AppendFormat(
                        "- Should (usually) be incompatible with replacement item: {0}uL\n",
                        ReplaceWith);

                } else if (Compatibility != null && !Compatibility.ContainsKey(ReplaceWith)) {
                    problems = true;
                    log.AppendFormat(
                        "- Must specify (in)compatibility with replacement item: {0}uL\n",
                        ReplaceWith);
                }

            } else if (HasFlag(ItemFlags.ForceMigration)) {
                problems = true;
                log.Append("- ReplaceWith missing\n");
            }

            return problems;
        }

        /// <summary>
        /// Verifies ArchiveURL and SourceURL properties, logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyUrlProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;

            // must be neither or both
            if (!Suppresses(Warning.MissingArchiveURL) && HasFlag(ItemFlags.NoWorkshop) == string.IsNullOrEmpty(ArchiveURL)) {
                problems = true;
                log.Append("- The NoWorkshop flag and ArchiveURL properties must correlate\n");
            }

            if (!HasFlag(SOURCE_DEFINED)) {
                problems = true;
                log.Append("- Must specify either SourceAvailable, SourceBundled or SourceUnavailable flag\n");
            }

            if (HasFlag(ItemFlags.SourceAvailable) && string.IsNullOrEmpty(SourceURL)) {
                problems = true;
                log.Append("- SourceURL missing\n");
            }

            return problems;
        }

        /// <summary>
        /// Verifies properties not checked by other verification methods, logging any problems it finds.
        /// </summary>
        ///
        /// <param name="extendedReporting">If <c>true</c>, do more extensive verification.</param>
        /// <param name="log">The log to append.</param>
        /// 
        /// <returns>Returns <c>true</c> if problems found, otherwise <c>false</c>.</returns>
        internal bool VerifyRemainingProperties(bool extendedReporting, ref StringBuilder log) {

            bool problems = false;
            bool localised = HasFlag(ItemFlags.Localised);
            bool noLocale = string.IsNullOrEmpty(Locale);

            if (extendedReporting && localised && (noLocale || (Languages == null && Locale == "en"))) {
                problems = true;
                log.Append("- Locale/Languages must be if Localised flag set\n");
            }

            if (extendedReporting && (Tags == null || Tags.Count() == 0)) {
                problems = true;
                log.Append("- Tags missing\n");
            }

            return problems;
        }
    }
}
