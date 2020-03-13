namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public partial class VehicleEffect {

        private const ulong _vehicleEffectsMod = 780720853u;

        private const ulong _extraVehicleEffectsMod = 815103125u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleEffect"/> class.
        /// </summary>
        public VehicleEffect() {
            list = new Dictionary<ulong, Item>();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="VehicleEffect"/> class.
        /// </summary>
        ~VehicleEffect() {
            list.Clear();
        }

        /// <summary>
        /// Adds a basic effects pack to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void AddBasicPack(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "VehicleEffect",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { _vehicleEffectsMod },
                },
            });
        }

        /// <summary>
        /// Adds an extra effects pack to the list (one that requires Extra Vehicle Effects mod).
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void AddExtraPack(ulong workshopId, string workshopName) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Catalog = "VehicleEffect",
                ItemType = ItemTypes.Mod,
                RequiredMods = new List<ulong>() {
                    { _vehicleEffectsMod },
                    { _extraVehicleEffectsMod },
                },
            });
        }
    }
}
