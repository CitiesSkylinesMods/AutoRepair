using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair {
    /// <summary>
    /// Endless list of tile unlock mods, all incompatible with each other.
    /// </summary>
    public class Tiles {

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Tiles"/> class.
        /// </summary>
        public Tiles() {
            list = new Dictionary<ulong, Item>();
            Populate();
            CrossReference();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Tiles"/> class.
        /// </summary>
        ~Tiles() {
            list.Clear();
        }

        public void CrossReference() {
            // todo
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
                ConflictsWith = ConflictGroups.Tiles,
            });
        }

        public void Populate() {
            Add(1978555062u, "AllSpacesUnlockable");
            Add(1891302645u, "UnlockAreaCountLimitAndFree");
            Add(1878659195u, "UnlockAreaCountLimitAndFree");
            Add(1830615215u, "All 25 Areas purchaseable");
            Add(1778652879u, "MaxArea");
            Add(1723162741u, "UnlockAreaCountLimitAndFree");
        }
    }
}
