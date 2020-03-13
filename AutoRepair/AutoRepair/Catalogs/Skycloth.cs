namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for anything relating to Ambient Sounds Tuner mod.
    /// 
    /// Muhhhhh skyclothhh.
    ///
    /// Skycloth demands obedience and poem recitals and strange rituals.
    /// </summary>
    public partial class Skycloth {
        private static Skycloth instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="Skycloth"/> class.
        /// </summary>
        public static Skycloth Instance => instance ?? (instance = new Skycloth());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Skycloth"/> class.
        /// </summary>
        public Skycloth() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Skycloth"/> class.
        /// </summary>
        ~Skycloth() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddFlagPack(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "Skycloth",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { 595017353u }, // Flags Replacer mod
                },
            });
        }
    }
}
