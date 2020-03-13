namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Currently supported TM:PE mods.
    /// </summary>
    public partial class TMPE {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void AddModsToList() {

            AddMod(new Item(1806963141u, "TM:PE v11.1.2 LABS") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Translation, // localised to lots of languages
                Locale = "en-us",
                CompatibleWith = new List<ulong>() {
                    { 1764208250u }, // More Vehicles
                    { 1939169189u }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 2019097300u }, // Hide TM:PE Unconnected Tracks
                },
            });

            AddMod(new Item(1637663252u, "TM:PE V11 STABLE") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Laggy // TM:PE does put lots of strain on CPU :/
                      | ItemFlags.MinorBugs // https://github.com/CitiesSkylinesMods/TMPE/labels/BUG
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Translation, // localised to lots of languages
                Locale = "en-us",
                CompatibleWith = new List<ulong>() {
                    { 1764208250u }, // More Vehicles
                    { 1939169189u }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u }, // Hide TMPE crosswalks V2.5 [BETA]
                    { 2019097300u }, // Hide TM:PE Unconnected Tracks
                },
            });
        }
    }
}
