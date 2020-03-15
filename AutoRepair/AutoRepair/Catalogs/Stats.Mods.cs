using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    public partial class Stats {
        private void AddModsToList() {

            Add(1994342199u, "Eco Stats Mod");

            Add(1956926733u, "Asset Information"); // asset counter

            // breaks if C:\Temp folder does not exist
            // likely incompatible with Linux and Mac
            Add(1875697177u, "Integrator: Log Generator");

            // todo, incompat with similar mods
            Add(1875298330u, "Extended Building Info");

            Add(new Item(1804882663u, "Monitor It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Verified
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.Abandonware,
            });

            Add(new Item(1785774902u, "Transfer Info (beta)") {
                IncompatibleMods = new List<ulong>() {
                    { 1072157697u }, // Cargo Info (original)
                    { 1739993783u }, // Cargo Info (Fix)
                },
            });

            // game breaking?
            Add(new Item(1739993783u, "Cargo Info (Fix)") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                IncompatibleMods = new List<ulong>() {
                    { 1785774902u }, // Transfer Info (beta)
                    { 1072157697u }, // Cargo Info (original version)
                },
                ReplaceWith = 1785774902u, // Transfer Info (beta)
            });

            // todo: warn about network traffic
            Add(new Item(1725845818u, "Mayor´s report for android") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1643902284u, "Watch It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-WatchIt",
            });

            Add(new Item(1556715327u, "Show It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Verified
                      | ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable
                      | ItemFlags.MinorBugs, // harmony patch management could be better
                SourceCodeURL = "https://github.com/keallu/CSL-ShowIt",
                IncompatibleMods = new List<ulong>() {
                    // todo: building info mods
                },
            });

            Add(new Item(1410077595u, "Stats") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/DaEgi01/CitiesSkylines-Stats",
            });

        }
    }
}
