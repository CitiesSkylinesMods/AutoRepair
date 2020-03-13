namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Cities Skylines Multiplayer (CSM) mods.
    /// </summary>
    public partial class Multiplayer {
        private static Multiplayer instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="Multiplayer"/> class.
        /// </summary>
        public static Multiplayer Instance => instance ?? (instance = new Multiplayer());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Full list of incompatible mods applicable to <see cref="ConflictGroups.Multiplayer"/>.
        ///
        /// TODO: this is fucking stupid, centralise and automate it.
        /// </summary>
        private readonly List<ulong> incompatibles = new List<ulong>() {
            { 2000408250u }, // CSM
            { 1985701540u }, // CSM
            { 1841616225u }, // CSM
            { 1731754018u }, // CSM
            { 1598623776u }, // CSM - CitySkyline Multiplayer
            { 1598622569u }, // CSM - CitySkyline Multiplayer
            { 1598621063u }, // CSM - CitySkyline Multiplayer
            { 1558438291u }, // Cities: Skylines Multiplayer (CSM) [Beta]
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Multiplayer"/> class.
        /// </summary>
        public Multiplayer() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddObsoleteToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Multiplayer"/> class.
        /// </summary>
        ~Multiplayer() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add CSM mod to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add to the list.</param>
        private void AddMod(Item item) {
            item.Catalog = "Multiplayer";
            item.ItemType = ItemTypes.Mod;
            item.ConflictsWith |= ConflictGroups.Multiplayer;
            item.IncompatibleMods = new List<ulong>(incompatibles);

            if (item.IncompatibleMods.Contains(item.WorkshopId)) {
                item.IncompatibleMods.Remove(item.WorkshopId);
            }

            list.Add(item.WorkshopId, item);
        }

        /// <summary>
        /// Add obsolete CSM mod to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        private void AddOldCSM(ulong workshopId, string workshopName, bool hasWorkshop = true) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "Multiplayer",
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.GameBreaking
                      | ItemFlags.ForceMigration,
                ConflictsWith = ConflictGroups.Multiplayer,
                IncompatibleMods = new List<ulong>(incompatibles),
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
            };

            if (!hasWorkshop) {
                item.Flags |= ItemFlags.NoWorkshop;
            }

            if (item.IncompatibleMods.Contains(item.WorkshopId)) {
                item.IncompatibleMods.Remove(item.WorkshopId);
            }

            list.Add(workshopId, item);
        }
    }
}