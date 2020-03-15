using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System.Collections.Generic;

namespace AutoRepair.Catalogs {

    public partial class Paint {
        private void AddModsToList() {
            Add(new Item(1372431101u, "Painter") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/TPBCS/Painter",
                Authors = "TPB",
                SuggestedMods = new List<ulong>() {
                    { 530771650u }, // Prefab hook (enables invert and colorize options)
                },
            });

            // todo: prolly incompat with AVO mod?
            Add(new Item(1818462177u, "Vehicle Color Expander") {
                IncompatibleMods = new List<ulong>() {
                    { 442167376u }, // Advanced Vehicle Options (AVO)
                    { 1548831935u }, // Advanced Vehicle Options AVO (Industries DLC ready)
                },
            });

            // todo: prolly incompat with painter mod?
            Add(1808439336u, "Building Color Expander");

            // seems broken by one of the game updates, but needs some extra testing
            Add(new Item(1442713872u, "Detail") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://gist.github.com/ronyx69/68d57f77e721dabefaefa864cc29616b",
            });
        }
    }
}
