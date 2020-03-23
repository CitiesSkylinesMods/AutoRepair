/*
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

            Add(1904439843u, "Mayoral City Service Info");

            // todo: likely incompat with City Vitals, Export Electricity
            Add(1893036262u, "Mayor's Dashboard v2");

            // todo, incompat with similar mods
            Add(1875298330u, "Extended Building Info");

            // breaks if C:\Temp folder does not exist
            // likely incompatible with Linux and Mac
            Add(1875697177u, "Integrator: Log Generator");

            Add(new Item(1804882663u, "Monitor It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
            });

            Add(new Item(1785774902u, "Transfer Info (beta)") {
                IncompatibleMods = new List<ulong>() {
                    { 1072157697u }, // Cargo Info (original)
                    { 1739993783u }, // Cargo Info (Fix)
                },
            });

            Add(new Item(1643902284u, "Watch It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-WatchIt",
            });

            Add(new Item(1556715327u, "Show It!") {
                Authors = "Keallu",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // harmony patch management could be better
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/keallu/CSL-ShowIt",
                IncompatibleMods = new List<ulong>() {
                    // todo: building info mods
                },
            });

            Add(new Item(1410077595u, "Stats") {
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-Stats",
            });

            Add(new Item(1186900508u, "DistrictRCI-continued") {
                Authors = "cambrium",
                ContinuationOf = 943410067u, // DistrictRCI fix
                Flags = ItemFlags.MinorBugs // Stats sometimes incorrect (based on user comments)
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 1915645035u }, // 1186900508 DistrictRCI-continued
                    { 1908236993u }, // 1186900508 DistrictRCI-continued
                    { 943410067u }, // DistrictRCI fix
                    { 486496436u }, // DistrictRCI (original version)
                },
                SourceURL = "https://github.com/TheDogKSP/DistrictRCI",
            });

            Add(new Item(1186889659u, "DistrictStats") {
                Authors = "cambrium",
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/TheDogKSP/DistrictStats",
            });

            Add(new Item(944936527u, "Resources for Districts") {
                Authors = "Sherban",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.MinorBugs // doesn't cover industries dlc resources
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/Sherbanm/RID/",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            * /

            // game breaking?
            Add(new Item(1739993783u, "Cargo Info (Fix)") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.ForceMigration,
                IncompatibleMods = new List<ulong>() {
                    { 1785774902u }, // Transfer Info (beta)
                    { 1072157697u }, // Cargo Info (original version)
                },
                Languages = new[] { "en", "de", "ru" },
                ReplaceWith = 1785774902u, // Transfer Info (beta)
            });

            // todo: warn about network traffic
            Add(new Item(1725845818u, "Mayor´s report for android") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable,
            });

            Add(new Item(1133108993u, "Extended Building Information (1.10+)") {
                Authors = "Ellie",
                Affect = Factor.BuildingInfo,
                ContinuationOf = 928988785u, // Extended Building Information
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking // multiple users report 'object ref not set' errors
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() { // will be more
                    { 1875298330u }, // Extended Building Info
                    { 928988785u }, // Extended Building Information
                    { 414469593u }, // Extended Building Information
                },
                ReplaceWith = 1875298330u, // Extended Building Info
                SourceURL = "https://github.com/AmaroqOkami/Cities-Skylines-Extended-Building-Info",
            });

            Add(new Item(1072157697u, "Cargo Info") {
                Authors = "Dr. Nya",
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer versions available
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 1785774902u }, // Transfer Info (beta)
                    { 1739993783u }, // Cargo Info (Fix)
                },
                Languages = new[] { "en", "de", "ru" },
                ReplaceWith = 1785774902u, // Transfer Info (beta)
                SourceURL = "https://github.com/rumkex/Skylines-CargoInfoMod",
            });

            Add(new Item(943410067u, "DistrictRCI fix") {
                Authors = "billw",
                // conflicts with other district rci
                ContinuationOf = 486496436u, // DistrictRCI (original version)
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // newer version available
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() {
                    { 1186900508u }, // DistrictRCI-continued
                    { 1915645035u }, // 1186900508 DistrictRCI-continued
                    { 1908236993u }, // 1186900508 DistrictRCI-continued
                    { 486496436u }, // DistrictRCI (original version)
                },
                ReplaceWith = 1186900508u, // DistrictRCI-continued
                SourceURL = "https://github.com/billw2012/DistrictRCI",
            });
        }
    }
}
*/