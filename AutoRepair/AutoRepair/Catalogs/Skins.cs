namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for anything relating to Themes.
    /// </summary>
    public partial class Skins {
        private static Skins instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="Skins"/> class.
        /// </summary>
        public static Skins Instance => instance ?? (instance = new Skins());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        private List<ulong> incompatibles = new List<ulong>() {
            { 1899640536u }, // Theme Mixer 2
            { 1445375997u }, // Theme Mixer 汉化版2的 (775021554u)
            { 775021554u }, // Theme Mixer (no longer in workshop)
            { 574674741u }, // Terrain Themes Mod
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Skins"/> class.
        /// </summary>
        public Skins() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
            AddObsoleteToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Skins"/> class.
        /// </summary>
        ~Skins() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a sound pack to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddThemePack(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "MapThemes",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                },
            });
        }

        /// <summary>
        /// Add obsolete theme mod to list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddObsolete(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "MapThemes",
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.MapThemes,
                ReplaceWith = 1899640536u, // Theme Mixer 2
            });
        }
    }
}
