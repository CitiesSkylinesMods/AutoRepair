using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair {
    public class BuildingThemes {

        private const ulong _buildingThemesMod = 466158459u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingThemes"/> class.
        /// </summary>
        public BuildingThemes() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="BuildingThemes"/> class.
        /// </summary>
        ~BuildingThemes() {
            list.Clear();
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
                RequiredMods = new List<ulong>() {
                    { _buildingThemesMod },
                },
            });
        }

        public void Populate() {
            // todo: probably requires DLC?
            // collection: https://steamcommunity.com/workshop/filedetails/?id=1901228838
            Add(1903967441u, "Building Theme: European Suburbia Decorated");

            // todo: DLC required
            Add(1747800340u, "Building Theme: University City Districts");

            Add(1632933031u, "Building Theme:Japanese low residential theme");
        }
    }
}
