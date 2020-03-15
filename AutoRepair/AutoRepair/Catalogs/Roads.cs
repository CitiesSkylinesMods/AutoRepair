namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Anything that adds roads, changes road textures/colors, etc.
    /// </summary>
    public class Roads {

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Roads"/> class.
        /// </summary>
        public Roads() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Roads"/> class.
        /// </summary>
        ~Roads() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void Add(Item item) {
            item.ItemType = ItemTypes.Mod;
            list.Add(item.WorkshopId, item);
        }

        public void Populate() {

            // Removed from workshop

            Add(new Item(413678178u, "Fine Road Heights") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning
                              | ConflictGroups.FineRoadTool
                              | ConflictGroups.FineRoadAnarchy,
                ReplaceWith = 
            });

            Add(new Item(433567230u, "Advanced Road Anarchy") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning
                              | ConflictGroups.FineRoadTool
                              | ConflictGroups.FineRoadAnarchy,
                ReplaceWith = 
            });

            // Game breaking

            Add(new Item(478820060u, "Network Extensions Project") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable, // it was replaced with TAM source, then later NExt2 source
                ConflictsWith = ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning
                              | ConflictGroups.FineRoadAnarchy
                              | ConflictGroups.FineRoadTool,
                IncompatibleMods = new List<ulong>() {
                    { 625608461u }, // Adaptive Prop Visibility Distance
                },
                ReplaceWith = 812125426u, // Network Extensions 2
            });

            Add(new Item(553184329u, "Sharp Junction Angles") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.RoadsUnited
                              | ConflictGroups.Zoning
                              | ConflictGroups.FineRoadAnarchy
                              | ConflictGroups.FineRoadTool,
                ReplaceWith = 
            });

        }
    }
}
