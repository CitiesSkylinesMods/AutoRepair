namespace AutoRepair.Catalogs {
    /// <summary>
    /// Obsolete TM:PE mods.
    /// </summary>
    public partial class TMPE {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void AddObsoleteToList() {

            AddOldTMPE(1957033250u, "TrafficManager Fixed for industry DLC");
            AddOldTMPE(1604291910u, "498363759 Traffic Manager + Improved AI");
            AddOldTMPE(1546870472u, "TrafficManager Fixed for industry DLC", false);

        }
    }
}
