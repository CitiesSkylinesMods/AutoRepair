using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair {
    public class AmbientSounds {

        private const ulong _ambientSoundsTunerMod = 818641631u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="AmbientSounds"/> class.
        /// </summary>
        public AmbientSounds() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AmbientSounds"/> class.
        /// </summary>
        ~AmbientSounds() {
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
                    { _ambientSoundsTunerMod },
                },
            });
        }

        public void Populate() {
            Add(1999271351u, "0xyl0nSoundPackUSA");
            Add(1982045897u, "(for backup)TwotoolusFLY's Siren mod");
            Add(1979269356u, "Swedish Emergency Vehicle Sirens - Sound Pack");
            Add(1977435537u, "OxylonEuroSoundpackSWE");
            Add(1974722022u, "Grand Theft Auto Mission Passed On Upgrade");
            Add(1969438995u, "OxylonEuroSoundpackITA");
            Add(1969435641u, "OxylonEuroSoundpackFRA");
            Add(1969432061u, "OxylonEuroSoundpackNED");
            Add(1969428208u, "OxylonEuroSoundpackAUT");
            Add(1969411916u, "OxylonEuroSoundpackGER");
            Add(1961235713u, "Grand Theft Auto Sirens");
            Add(1764439209u, "DB Announcer");
            Add(1729946947u, "Austrian Sirens");
            Add(1660065880u, "Pre-War Sirens");
            Add(1636310959u, "NS Sound Pack for Ambient Sounds Tuner");
            Add(1629745074u, "ÖBB Sound Pack for Ambient Sounds Tuner");
            Add(1628985258u, "CFF Sound Pack for Ambient Sounds Tuner");
            Add(1624184698u, "SBB Sound Pack for Ambient Sounds Tune");
        }
    }
}
