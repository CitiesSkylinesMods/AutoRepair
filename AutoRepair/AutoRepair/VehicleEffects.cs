using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair {
    public class VehicleEffects {

        private const ulong _vehicleEffectsMod = 780720853u;

        private const ulong _extraVehicleEffectsMod = 815103125u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleEffects"/> class.
        /// </summary>
        public VehicleEffects() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="VehicleEffects"/> class.
        /// </summary>
        ~VehicleEffects() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void AddBasic(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { _vehicleEffectsMod },
                },
            });
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void AddExtra(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { _vehicleEffectsMod },
                    { _extraVehicleEffectsMod },
                },
            });
        }

        public void Populate() {
            // https://drive.google.com/file/d/1ATs9XRlt9oCVOazyqFn5h0S517b7BN1L/view
            AddExtra(2008325200u, "Vehicle Effects Definition Pack DBAG");
        }
    }
}
