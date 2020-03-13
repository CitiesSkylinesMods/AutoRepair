namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for anything relating to CSL Music mod.
    /// </summary>
    public partial class Music {
        private static Music instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="Music"/> class.
        /// </summary>
        public static Music Instance => instance ?? (instance = new Music());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Music"/> class.
        /// </summary>
        public Music() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Music"/> class.
        /// </summary>
        ~Music() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a music pack to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        /// <param name="copyrighted">Whether the tracks are copyrighted (defaults to <c>true</c>).</param>
        private void AddMusicPack(ulong workshopId, string workshopName, bool copyrighted = true) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "Music",
                ItemType = ItemTypes.Radio,
                Flags = ItemFlags.SourceUnavailable,
                RequiredMods = new List<ulong>() {
                    { 422934383u }, // CSL Music Mod
                },
            });
        }
    }
}
