using AutoRepair.Descriptors;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {
    /// <summary>
    /// Defines sound packs for the Ambient Sound Tuner mod.
    /// </summary>
    public partial class AmbientSound {

        /// <summary>
        /// Add sound packs to the list.
        /// </summary>
        private void AddPacksToList() {
            Item item;

            AddSoundPack(1999271351u, "0xyl0nSoundPackUSA");
            AddSoundPack(1982045897u, "(for backup)TwotoolusFLY's Siren mod");
            AddSoundPack(1979269356u, "Swedish Emergency Vehicle Sirens - Sound Pack");
            AddSoundPack(1977435537u, "OxylonEuroSoundpackSWE");
            AddSoundPack(1974722022u, "Grand Theft Auto Mission Passed On Upgrade");
            AddSoundPack(1969438995u, "OxylonEuroSoundpackITA");
            AddSoundPack(1969435641u, "OxylonEuroSoundpackFRA");
            AddSoundPack(1969432061u, "OxylonEuroSoundpackNED");
            AddSoundPack(1969428208u, "OxylonEuroSoundpackAUT");
            AddSoundPack(1969411916u, "OxylonEuroSoundpackGER");
            AddSoundPack(1961235713u, "Grand Theft Auto Sirens");
            AddSoundPack(1764439209u, "DB Announcer");
            AddSoundPack(1729946947u, "Austrian Sirens");
            AddSoundPack(1660065880u, "Pre-War Sirens");
            AddSoundPack(1636310959u, "NS Sound Pack for Ambient Sounds Tuner");
            AddSoundPack(1629745074u, "ÖBB Sound Pack for Ambient Sounds Tuner");
            AddSoundPack(1628985258u, "CFF Sound Pack for Ambient Sounds Tuner");
            AddSoundPack(1624184698u, "SBB Sound Pack for Ambient Sounds Tune");
            AddSoundPack(1480332470u, "Polish Sirens Pack [V2.2]");

            item = AddSoundPack(1436056719u, "Kaguki's Realistic Akihabara Sounds");
            item.SuggestedMods = new List<ulong>() {
                { 1431909554u }, // Kaguki JPN Realistic Sounds v6 (TESTING)
            };

            AddSoundPack(1398060749u, "Evo's Korean Sound Overhaul [v0.1d]");
            AddSoundPack(1327734238u, "Deutsche Martinshörner für Ambient Sounds Tuner 2.0");
            AddSoundPack(1316748022u, "Martinshorn/ vormals V10 Siren");
        }
    }
}
