/*
namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public partial class RoadsUnited {
        private static RoadsUnited instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="RoadsUnited"/> class.
        /// </summary>
        public static RoadsUnited Instance => instance ?? (instance = new RoadsUnited());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoadsUnited"/> class.
        /// </summary>
        public RoadsUnited() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
            AddObsoleteToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="RoadsUnited"/> class.
        /// </summary>
        ~RoadsUnited() {
            list.Clear();
            list = null;
        }

        /// <summary>
        /// Add a skin pack to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        /// <param name="ruc2">Set <c>true</c> if the pack requires Roads United: Core 2.0.</param>
        /// <param name="rucP">Set <c>true</c> if the pack required Roads United: Core+.</param>
        private void AddSkinPack(ulong workshopId, string workshopName, bool ruc2, bool rucP) {
            Item item = new Item(workshopId, workshopName) {
                Flags = ItemFlags.MinorBugs 
                      | ItemFlags.SourceUnavailable,
                Affect = Factor.RoadColorChanger
                              | Factor.RoadsUnited,
                CompatibleWith = new List<ulong>(),
                RequiredMods = new List<ulong>(),
                IncompatibleMods = new List<ulong>() {
                    { 1449429720u }, // Road Color 道路颜色修改中文汉化版
                    { 1128766708u }, // Remove Road Textures - Blank Roads
                    { 932192868u }, // Road Options (Road Colors Changer ++)
                    { 726005715u }, // Roads United: Core+
                    { 651610627u }, // [DISCONTINUED] Road Color Changer Continued
                    { 633547552u }, // Roads United Core 2.0
                    { 478820060u }, // Network Extensions Project (original verison)
                    { 417585852u }, // Road Color Changer (no longer in workshop)
                },
            };

            if (ruc2) { // Roads United Core 2.0
                item.CompatibleWith.Add(633547552u);
                item.RequiredMods.Add(633547552u);
                item.IncompatibleMods.Remove(633547552u);
            }

            if (rucP) { // Roads United: Core+
                item.CompatibleWith.Add(726005715u);
                item.IncompatibleMods.Remove(726005715u);
                if (!ruc2) {
                    item.RequiredMods.Add(726005715u);
                }
            }

            list.Add(workshopId, item);
        }
    }
}
*/