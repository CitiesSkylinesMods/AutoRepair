namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods considered to be add-ons for TM:PE.
    /// </summary>
    public partial class TMPE {

        /// <summary>
        /// Add packs to list.
        /// </summary>
        private void AddExtrasToList() {

            // Requires TM:PE
            AddMod(new Item(2019097300u, "Hide TM:PE Unconnected Tracks") {
                Flags = ItemFlags.Verified,
                CompatibleWith = new List<ulong>() {
                    { 1637663252u }, // TM:PE STABLE
                    { 1806963141u }, // TM:PE LABS
                    { 1939169189u }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                    { 1934023593u }, // Hide TMPE crosswalks V2.5 [BETA]
                },
                RequiredMods = new List<ulong>() {
                    { 1806963141u }, // TM:PE v11 LABS
                },
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1934023593u, "Hide TMPE crosswalks V2.5 [BETA]") {
                Flags = ItemFlags.Verified,
                CompatibleWith = new List<ulong>() {
                    { 1637663252u }, // TM:PE STABLE
                    { 1806963141u }, // TM:PE LABS
                    { 583429740u }, // TM:PE 10.20 (remove from game version 1.12.4 or later)
                    { 2019097300u }, // Hide TM:PE Unconnected Tracks
                },
                SuggestedMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1680642819u }, // Ultimate Level of Detail (ULOD)
                    { 1637663252u }, // TM:PE STABLE
                },
                IncompatibleMods = new List<ulong>() {
                    { 1939169189u }, // Hide Crosswalks V3.0 [EXPERIMENTAL]
                },
            });

            // Requires either TM:PE and/or Network Skins 2
            AddMod(new Item(1939169189u, "Hide Crosswalks V3.0 [EXPERIMENTAL]") {
                CompatibleWith = new List<ulong>() {
                    { 1637663252u }, // TM:PE STABLE
                    { 1806963141u }, // TM:PE LABS
                    { 583429740u }, // TM:PE 10.20 (remove from game version 1.12.4 or later)
                    { 2019097300u }, // Hide TM:PE Unconnected Tracks
                },
                SuggestedMods = new List<ulong>() {
                    { 1758376843u }, // Network Skins 2
                    { 1680642819u }, // Ultimate Level of Detail (ULOD)
                    { 1806963141u }, // TM:PE LABS
                },
                IncompatibleMods = new List<ulong>() {
                    { 1934023593u }, // Hide TMPE crosswalks V2.5 [BETA]
                },
            });

            // Can be used on it's own
            AddMod(new Item(1829496988u, "Adjust Pathfinding") {
                CompatibleWith = {
                    { 1806963141u }, // TM:PE v11 LABS
                    { 1637663252u }, // TM:PE v11 STABLE
                },
            });
        }
    }
}
