namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for anything relating to Building Themes mod.
    /// </summary>
    public partial class BuildingTheme {
        private static BuildingTheme instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="BuildingTheme"/> class.
        /// </summary>
        public static BuildingTheme Instance => instance ?? (instance = new BuildingTheme());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingTheme"/> class.
        /// </summary>
        public BuildingTheme() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="BuildingTheme"/> class.
        /// </summary>
        ~BuildingTheme() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a building theme item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddThemePack(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "BuildingTheme",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { 466158459u }, // Building Themes mod
                },
            });
        }
    }
}
