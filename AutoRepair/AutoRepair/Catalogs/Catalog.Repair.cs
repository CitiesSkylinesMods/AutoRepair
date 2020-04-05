namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that help detect and/or repair issues with the game.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void RepairCatalog() {

            string catalog = "Repair";

            AddMod(new Item(2041457644u, "Patch Loader Mod") {
                Affect = Factor.Other,
                Authors = "Krzychu1245, egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMod(new Item(2037888659u, "Instant Return To Desktop") {
                Affect = Factor.LoadSaveExit,
                Authors = "Cgameworld",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.SunsetHarbor,
                SourceURL = "https://github.com/Cgameworld/InstantReturnToDesktop",
            });

            AddMod(new Item(2037862156u, "IsIntercity Fix") {
                Affect = Factor.Other,
                Authors = "Elektrix, aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 445339041, Status.Compatible }, // Air Canada Billboard v1 (AD)
                    { 445339228, Status.Compatible }, // Air Canada Billboard v2 (AD)
                    { 450159784, Status.Compatible }, // Air Canada Hanger - Plane (AD)
                    { 440821655, Status.Compatible }, // Airport Billboard - BA (AD)
                    { 440821109, Status.Compatible }, // Airport Billboard - Easyjet (AD)
                    { 440821462, Status.Compatible }, // Airport Billboard - Virgin Atl (AD)
                    { 445936897, Status.Compatible }, // Airport Light (Now with AD lighting)
                    { 409610041, Status.Compatible }, // Airport Terminal
                    { 441297743, Status.Compatible }, // American Airlines Billboard (AD)
                    { 524258608, Status.Compatible }, // Approach Light System (Realistic)
                    { 453551249, Status.Compatible }, // Bus Terminus 14x1 (AD)
                    { 453797940, Status.Compatible }, // Bus Terminus 5x1 (AD)
                    { 453797824, Status.Compatible }, // Bus Terminus 9x1 (AD)
                    { 448358685, Status.Compatible }, // Cargo ship for HarborPack by --VIP--
                    { 412919278, Status.Compatible }, // Control Tower
                    { 443279242, Status.Compatible }, // Converted Commercial hanger (AD)
                    { 430151916, Status.Compatible }, // Cynth's Modern Subway Station
                    { 410637877, Status.Compatible }, // DFW Airport
                    { 442104086, Status.Compatible }, // DHL Distribution Centre (AD)
                    { 446918250, Status.Compatible }, // DHL Distribution v2 (AD)
                    { 425811150, Status.Compatible }, // Farnborough ATC Tower
                    { 448347015, Status.Compatible }, // HarborPack by --VIP-- (building №1)
                    { 448355071, Status.Compatible }, // HarborPack by --VIP-- (building №2 Ship )
                    { 448373754, Status.Compatible }, // HarborPack by --VIP-- (building №3 Warehouse- left side)
                    { 448369077, Status.Compatible }, // HarborPack by --VIP-- (building №3 Warehouse-Center)
                    { 448378353, Status.Compatible }, // HarborPack by --VIP-- (building №3 Warehouse-right side)
                    { 494979546, Status.Compatible }, // Inner City Metro | 4 tracks | + | V 1.1
                    { 495087750, Status.Compatible }, // Inner City Metro | 4 tracks | = | V 1.1
                    { 502135479, Status.Compatible }, // Inner City Metro | 6 tracks | =|
                    { 495087083, Status.Compatible }, // Inner City Metro | 6 tracks | |_|
                    { 441297882, Status.Compatible }, // KLM Billboard (AD)
                    { 441821707, Status.Compatible }, // KLM Cargo centre (AD)
                    { 449681860, Status.Compatible }, // KLM Hanger with Plane (AD)
                    { 454395291, Status.Compatible }, // Large Bus Station (AD)
                    { 449673453, Status.Compatible }, // Large KLM Hanger (AD)
                    { 453350946, Status.Compatible }, // Large Terminal - Modular version (AD)
                    { 453477695, Status.Compatible }, // Large Terminal - Spoke (AD)
                    { 458116235, Status.Compatible }, // Large Terminal - T Piece (AD)
                    { 453320590, Status.Compatible }, // Large Terminal (AD)
                    { 433435357, Status.Compatible }, // Modern Train Station
                    { 467821842, Status.Compatible }, // Modular Cargo Centre - DHL Pack
                    { 467109588, Status.Compatible }, // Modular Cargo Centre - FedEx Pack (AD)
                    { 466972450, Status.Compatible }, // Modular Cargo Centre - KLM Pack
                    { 469473993, Status.Compatible }, // Modular Cargo Centre - TNT Pack
                    { 445085351, Status.Compatible }, // Modular Terminal Spokes
                    { 433578710, Status.Compatible }, // Moscow Metro Station (AD+)
                    { 522247377, Status.Compatible }, // Mumbai ATC Tower
                    { 455461579, Status.Compatible }, // Parked Train Cargo 16x2 (AD)
                    { 449085072, Status.Compatible }, // Qantas Billboard (AD)
                    { 438702931, Status.Compatible }, // Radar Tower Scenic (AD)
                    { 440739312, Status.Compatible }, // Runway Begin
                    { 440742197, Status.Compatible }, // Runway Centre
                    { 440739764, Status.Compatible }, // Runway End
                    { 411521749, Status.Compatible }, // Rural Station
                    { 429618056, Status.Compatible }, // Simple Inner City Metro
                    { 421624072, Status.Compatible }, // Small Airport Hangar
                    { 446422914, Status.Compatible }, // Small Airport Terminal v1 (AD) - With Runway
                    { 438937962, Status.Compatible }, // Small Hanger no Reqs
                    { 489630720, Status.Compatible }, // Small Inner City Metro | 4 tracks | + | V 1.2
                    { 502665431, Status.Compatible }, // Small Inner City Metro | 4 tracks | =
                    { 495193933, Status.Compatible }, // Small Inner City Metro | 6 tracks | |_|
                    { 445085103, Status.Compatible }, // Small Modular Terminal
                    { 446423109, Status.Compatible }, // Small Terminal Extension (AD)
                    { 447884981, Status.Compatible }, // Travelodge BillBoard (AD)
                    { 441298034, Status.Compatible }, // Turkish Airlines Billboard (AD)
                    { 495785573, Status.Compatible }, // UK Train Station - Generic 1
                    { 496984059, Status.Compatible }, // UK Train Station - Generic 2
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: This mod is required by lots of old workshop assets; keep it enabled until further notice." },
                },
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMod(new Item(2034713132u, "AutoRepair") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                ReleasedDuring = GameVersion.PdxLauncher,
                SourceURL = "https://github.com/CitiesSkylinesMods/AutoRepair",
            });

            AddMod(new Item(1938493221u, "Mini FPS Booster") {
                Affect = Factor.Other,
                Authors = "Krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceUnavailable,
                ReleasedDuring = GameVersion.Campus,
            });

            AddMod(new Item(1777173984u, "Broken Nodes Detector") {
                Affect = Factor.Other,
                Authors = "krzychu1245",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/BrokenNodeDetector",
            });

            AddMod(new Item(1620588636u, "Safenets") {
                Affect = Factor.Other,
                Authors = "thale5",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/thale5/Safenets",
            });

            AddMod(new Item(1243740191u, "Road Removal Tool") {
                Affect = Factor.Other,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-RoadRemovalTool",
            });

            AddMod(new Item(558661484u, "Building Panel Already Exists Icons Fix") {
                Affect = Factor.Toolbar,
                Authors = "BloodyPenguin",
                BrokenBy = GameVersion.SunsetHarbor,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                CompatibleWith = GameVersion.PdxLauncher,
                Flags = ItemFlags.BrokenByUpdate
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Sunset Harbor: Causes 'already built' icons to appear on any service building that's already built (you can still build more though)." },
                },
                ReleasedDuring = GameVersion.AfterDark,
                SourceURL = "https://github.com/bloodypenguin/Skylines-AlreadyBuiltFix",
            });
        }
    }
}
