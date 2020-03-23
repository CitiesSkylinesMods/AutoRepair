/*
namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Catalog manager for tile unlock mods.
    /// </summary>
    public partial class Tile {
        private static Tile instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="Tile"/> class.
        /// </summary>
        public static Tile Instance => instance ?? (instance = new Tile());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tile"/> class.
        /// </summary>
        public Tile() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Tile"/> class.
        /// </summary>
        ~Tile() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        /// <param name="replaceWith">Id of applicable replacement mod from Steam Workshop (defualts to Purchase It! mod).</param>
        /// <param name="gameBreaking">Set to <c>true</c> if the mod is game breaking.</param>
        ///
        /// <returns>Returns the item that was added.</returns>
        private Item AddMod(ulong workshopId, string workshopName, ulong replaceWith = 1612287735u, bool gameBreaking = false) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "Tile",
                ItemType = ItemTypes.Mod,
                Flags = ItemFlags.SourceUnavailable,
                Affect = Factor.TileLimit,
                ReplaceWith = replaceWith,
            };

            if (gameBreaking) {
                item.Flags |= ItemFlags.GameBreaking | ItemFlags.ForceMigration;
            }

            list.Add(workshopId, item);
            return item;
        }

        private void AddMod(Item item) {
            item.Catalog = "Tile";
            item.ItemType = ItemTypes.Mod;
            item.Affect = Factor.TileLimit;

            list.Add(item.WorkshopId, item);
        }
    }
}
*/