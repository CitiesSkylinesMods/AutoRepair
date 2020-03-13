namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for TM:PE mods.
    /// </summary>
    public partial class TMPE {
        private static TMPE instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="TMPE"/> class.
        /// </summary>
        public static TMPE Instance => instance ?? (instance = new TMPE());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="TMPE"/> class.
        /// </summary>
        public TMPE() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddExtrasToList();
            AddObsoleteToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="TMPE"/> class.
        /// </summary>
        ~TMPE() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a TMPE (or related) mod to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add to the list.</param>
        private void AddMod(Item item) {
            item.Catalog = "TMPE";
            item.ItemType = ItemTypes.Mod;
            item.ConflictsWith = ConflictGroups.TMPE;

            list.Add(item.WorkshopId, item);
        }

        /// <summary>
        /// Add old version of TM:PE to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        /// <param name="hasWorkshop">Does the workshop page still exist? Defaults to <c>true</c>.</param>
        private void AddOldTMPE(ulong workshopId, string workshopName, bool hasWorkshop = true) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "TMPE",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Obsolete,
                SourceCode = "https://github.com/CitiesSkylinesMods/TMPE",
                ItemType = ItemTypes.Mod,
                ConflictsWith = ConflictGroups.TMPE
                              | ConflictGroups.MoreVehicles,
                ReplaceWith = 1637663252u, // TM:PE v11 STABLE
            };

            if (!hasWorkshop) {
                item.Flags |= ItemFlags.NoWorkshop;
            }

            list.Add(workshopId, item);
        }
    }
}
