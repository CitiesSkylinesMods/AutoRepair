namespace AutoRepair.Descriptors {
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Descriptor for a workshop item.
    /// </summary>
    public class Item {

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        /// 
        /// <param name="workshopId">The Steam Workshop ID for this item.</param>
        /// <param name="workshopName">The name of this item as it appears in Steam Workshop.</param>
        public Item(ulong workshopId, string workshopName) {
            WorkshopId = workshopId;
            WorkshopName = workshopName;
        }

        /// <summary>
        /// Gets or sets the <see cref="ItemTypes"/> for this item.
        /// </summary>
        public ItemTypes ItemType { get; set; } = ItemTypes.None;

        /// <summary>
        /// Gets or sets the <see cref="ItemFlags"/> for this item.
        /// </summary>
        public ItemFlags Flags { get; set; } = ItemFlags.None;

        /// <summary>
        /// Gets or sets the Steam Workshop ID for this item.
        /// </summary>
        public ulong WorkshopId { get; set; }

        /// <summary>
        /// Gets or sets the name of this item as it appears in Steam Workshop.
        /// (UGCDetails.title).
        /// </summary>
        public string WorkshopName { get; set; }

        /// <summary>
        /// Gets or sets URL to source code (use "Bundled" if contained in the mod).
        /// </summary>
        public string SourceCode { get; set; }

        /// <summary>
        /// Gets or sets the item's primary language id.
        /// </summary>
        public string Locale { get; set; } = "en";

        /// <summary>
        /// Gets or sets mods that this item requires in order to function properly.
        /// </summary>
        public List<ulong> RequiredMods { get; set; }

        /// <summary>
        /// Gets or sets assets that this item requires.
        /// </summary>
        public List<ulong> RequiredAssets { get; set; }

        /// <summary>
        /// Gets or sets list of useful complimentary mods for this item.
        /// </summary>
        public List<ulong> SuggestedMods { get; set; }

        /// <summary>
        /// Gets or sets list of useful complimentary assets for this item.
        /// </summary>
        public List<ulong> SuggestedAssets { get; set; }

        /// <summary>
        /// Gets or sets mods that this item is incompatible with.
        /// </summary>
        public List<ulong> IncompatibleMods { get; set; }

        /// <summary>
        /// Gets or sets assets that this item is incompatible with.
        /// </summary>
        public List<ulong> IncompatibleAssets { get; set; }

        /// <summary>
        /// Gets or sets flags denoting meta conflict groups.
        /// </summary>
        public ConflictGroups ConflictsWith { get; set; } = ConflictGroups.None;

        /// <summary>
        /// Gets or sets explicitly compatible items.
        ///
        /// Use this to denote compatible or complimentary items within meta conflict groups.
        /// </summary>
        public List<ulong> CompatibleWith { get; set; }

        /// <summary>
        /// Gets or sets recommended replacement Steam Workshop ID.
        ///
        /// Use this to help users upgrade to most recent/reliable version of something.
        /// </summary>
        public ulong ReplaceWith { get; set; }
    }
}
