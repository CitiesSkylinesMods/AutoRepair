using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    public partial class Eyecandy {
        private void AddModsToList() {
            // todo: likely incompat with ultimate eyecandy
            Add(1883101331u, "Persistent Fog Adjuster");

            Add(new Item(1794015399u, "Render It!") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                ConflictsWith = ConflictGroups.PostProcessFX,
            });

            // todo: check if source still obfu
            Add(new Item(1760945529u, "Terrain Level Of Detail (TLOD)") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                RequiredMods = new List<ulong>() {
                    { 1680642819u }, // Ultimate Level Of Detail (ULOD)
                },
            });

            // LOD toggler has conflicting shortcut, and is also obsoleted by ULOD
            Add(new Item(1680642819u, "Ultimate Level Of Detail (ULOD)") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/boformer/UltimateLevelOfDetail",
                SuggestedMods = new List<ulong>() {
                    { 898480258u }, // Camera Positions Utility
                    { 812713438u }, // Dynamic Resolution (Fixed for 1.9!)
                    { 625608461u }, // Adaptive Prop Visibility Distance
                    { 556784825u }, // Random Tree Rotation
                },
                IncompatibleMods = new List<ulong>() {
                    { 561888259u }, // LOD Toggler (deprecated)
                },
            });

            // Based on author comments and my personal testing, some minor bugs:
            // * Shadow acne or detatched shadows depending on settings
            // * Conflicts with some Daylight Classic mod settings
            Add(new Item(1209581656u, "Relight") {
                Authors = "Ronyx69, TPB, Simon Ryr",
                Flags = ItemFlags.MinorBugs
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 643364914u }, // Softer Shadows
                },
                SourceCodeURL = "https://gist.github.com/ronyx69/a75400389e7561164bacabadf0095a2b",
                SuggestedMods = new List<ulong>() {
                    { 762520291u }, // Shadow Strength Adjuster
                    { 672248733u }, // Ultimate Eye Candy
                },
            });

        }
    }
}
