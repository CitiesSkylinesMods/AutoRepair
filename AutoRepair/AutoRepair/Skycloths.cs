namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Muhhhhh skyclothhh.
    ///
    /// Skycloth demands obedience and poem recitals.
    /// </summary>
    public class Skycloths {

        private const ulong _flagsReplacerMod = 595017353u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Skycloths"/> class.
        /// </summary>
        public Skycloths() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Skycloths"/> class.
        /// </summary>
        ~Skycloths() {
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
                    { _flagsReplacerMod },
                },
            });
        }

        public void Populate() {
            Add(1840528334u, "Ancom flag replacer");
            Add(1821339957u, "Rainbow Armenia Flag");
            Add(1712774142u, "Osterland Flag");
            Add(1652032078u, "Vooperian Flag");
            Add(1611090578u, "adsii1970's flags (set A)");
        }
    }
}
