namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that add numbered rectangles. Only one can be used at a time.
    /// </summary>
    public partial class NumberedRectangle {
        private static NumberedRectangle instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="NumberedRectangle"/> class.
        /// </summary>
        public static NumberedRectangle Instance => instance ?? (instance = new NumberedRectangle());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberedRectangle"/> class.
        /// </summary>
        public NumberedRectangle() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="NumberedRectangle"/> class.
        /// </summary>
        ~NumberedRectangle() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddMod(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "NumberedRectangle",
                ItemType = ItemTypes.Mod,
                ConflictsWith = ConflictGroups.NumberedRectangles,
            });
        }
    }
}
