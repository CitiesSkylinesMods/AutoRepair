namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that add starting money. Only one can be used at a time.
    /// </summary>
    public class Moneys {

        private const ulong _flagsReplacerMod = 595017353u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Moneys"/> class.
        /// </summary>
        public Moneys() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Moneys"/> class.
        /// </summary>
        ~Moneys() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void Add(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                ConflictsWith = ConflictGroups.Money,
            });
        }

        public void Populate() {
            Add(1673480325u, "£5 Million Starting Money");
            Add(1671542319u, "£2.5 Million Starting Money");
        }
    }
}
