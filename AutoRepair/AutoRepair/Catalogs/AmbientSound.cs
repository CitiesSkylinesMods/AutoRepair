namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for anything relating to Ambient Sounds Tuner mod.
    /// </summary>
    public partial class AmbientSound {
        private static AmbientSound instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="AmbientSound"/> class.
        /// </summary>
        public static AmbientSound Instance => instance ?? (instance = new AmbientSound());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientSound"/> class.
        /// </summary>
        public AmbientSound() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AmbientSound"/> class.
        /// </summary>
        ~AmbientSound() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a sound pack to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private Item AddSoundPack(ulong workshopId, string workshopName) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "AmbientSound",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { 818641631u }, // Ambient Sounds Tuner
                },
            };

            list.Add(workshopId, item);

            return item;
        }
    }
}
