using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    public partial class Repair {
        private void AddModsToList() {
            AddMod(new Item(2018193885u, "Sequence Logger") {
                Authors = "aubergine18",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/CitiesSkylinesMods/SequenceLogger",
            });

            AddMod(new Item(2013398705u, "Duplicate Assembly Scanner (DAS)") {
                Authors = "aubergine18",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/CitiesSkylinesMods/DuplicateAssemblyScanner",
            });

            AddMod(new Item(1777173984u, "Broken Nodes Detector") {
                Authors = "krzychu1245",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Item(1382357530u, "Sprite Dumper Extended") {
                Authors = "Boogieman Sam",
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/SamsamTS/CS-SpriteDumperExtended",
            });

            AddMod(new Item(1243740191u, "Road Removal Tool") {
                Authors = "egi",
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.Verified,
                SourceCodeURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });


        }
    }
}
