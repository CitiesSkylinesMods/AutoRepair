namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Stuff that alters user interface.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        private void SkinUIMods() {

            string catalog = "Skin.UI";

            AddMod(new Review(2040218778u, "ScaleUI") {
                Affect = Factor.UI,
                Authors = "*",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // likely incompatible with TMPE
                    { 2040218778u, Status.Incompatible }, // ScaleUI
                    { 2009172305u, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150u , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 419090722u , Status.Incompatible }, // Mod Corral
                    { 411164732u , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401u , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                ContinuationOf = 409338401u, // ScaleUI (beta)
                Flags = ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Can break UI of other mods during scaling (close buttons move, panels go off-screen, etc.)" },
                    { NOTE, "Breaks UI of all versions of Extended Public Transport UI mods." },
                },
                Published = WorkshopDate("29 Mar, 2020"),
                SourceURL = "https://github.com/joeyjojojunior/skylines-scaleui",
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            // sounds like bit of a nightmare
            // todo: move to dependencies cat?
            AddMod(new Review(1769420886u, "Panel Hook (beta) for modders") {
                Affect = Factor.BuildingInfo
                       | Factor.VehicleInfo,
                Authors = "vpoteryaev",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    // tmpe?
                    // snooper?
                    // klyte mods?
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Author states they no longer play C:SL; this mod will not be updated." },
                },
                Published = WorkshopDate("14 Jun, 2019"),
                SourceURL = "https://github.com/vpoteryaev-cs-mods/PanelHook",
                Updated = WorkshopDate("11 Jul, 2019"),
            });

            AddMod(new Review(1768810491u, "Measure It!") {
                Affect = Factor.Other,
                Authors = "Keallu",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("13 Jun, 2019"),
                SourceURL = "https://github.com/keallu/CSL-MeasureIt",
                Updated = WorkshopDate("3 Jul, 2019"),
            });

            AddMod(new Review(1526302248u, "Spinny RGB Circle") {
                Affect = Factor.UI,
                Authors = "Fox, Serial Bread",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1502721219u, Status.Incompatible }, // [Deprecated] Spinny Red Circle
                },
                Flags = ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Adjustable thiccness, now with 16.7 million colors." },
                },
                Published = WorkshopDate("29 Sep, 2018"),
                Updated = WorkshopDate("29 Sep, 2018"),
            });

            AddMod(new Review(412149127u, "Font Selector") {
                Affect = Factor.UI,
                Authors = "hippo",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>(aliMods) {
                    { 408286108u , Status.Incompatible }, // SkylinesFont
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceUnavailable,
                Published = WorkshopDate("9 Apr, 2015"),
                Updated = WorkshopDate("14 Feb, 2018"),
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Review(1799667916u, "UX Mod - OSD & Keybinds") {
                Affect = Factor.Other,
                Authors = "kvakvs",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() { },
                Flags = ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This was going to be a UI helper mod for TM:PE v11, but we decided to just build it in to TM:PE instead. Unsubscribe." },
                },
                Published = WorkshopDate("11 Jul, 2019"),
                SourceURL = "https://github.com/kvakvs/Skylines-UX",
                Updated = WorkshopDate("11 Jul, 2019"),
            });

            AddMod(new Review(1756787990u, "More Advanced InfoViews") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1764637396u, Status.Incompatible }, // Toggle It!
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                    { 1595663918u, Status.Incompatible }, // InfoPanelOnLoad
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("31 May, 2019"),
                Updated = WorkshopDate("9 Jun, 2019"),
            });

            AddMod(new Review(1595663918u, "InfoPanelOnLoad") {
                Affect = Factor.UI,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1756787990u, Status.Incompatible }, // More Advanced InfoViews
                    { 1595663918u, Status.Incompatible }, // InfoPanelOnLoad
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceObfuscated // checked 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
                Published = WorkshopDate("20 Dec, 2018"),
                ReplaceWith = 1756787990u, // More Advanced InfoViews
                Updated = WorkshopDate("20 Dec, 2018"),
            });

            AddMod(new Review(1502721219u, "[Deprecated] Spinny Red Circle") {
                Affect = Factor.UI,
                Authors = "Fox, Serial Bread",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1526302248u, Status.Incompatible }, // Spinny RGB Circle
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Discontinued due to insufficient thiccness and lack of colours." },
                },
                Published = WorkshopDate("3 Sep, 2018"),
                ReplaceWith = 1526302248u, // Spinny RGB Circle
                Updated = WorkshopDate("3 Sep, 2018"),
            });

            AddMod(new Review(419090722u, "Mod Corral") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150415205521/http://steamcommunity.com/sharedfiles/filedetails/?id=419090722",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778u, Status.Incompatible }, // ScaleUI
                    { 409338401u , Status.Compatible   }, // ScaleUI (beta)
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("3 Apr, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-ModCorral",
                Updated = WorkshopDate("12 Apr, 2015"),
            });

            AddMod(new Review(413584409u, "BetterLoadPanel") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150415230208/http://steamcommunity.com/sharedfiles/filedetails/?id=413584409",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // avail Nov 2015, gone by Jun 2016
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod is obsolete as the base game now has these features. Unsubscribe." },
                },
                Published = WorkshopDate("4 Apr, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-BetterLoadPanel",
                Updated = WorkshopDate("8 Apr, 2015"),
            });

            AddMod(new Review(409338401u, "ScaleUI (beta)") {
                Affect = Factor.UI,
                Authors = "permutation",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778u, Status.Incompatible }, // ScaleUI
                    { 2009172305u, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 802489150u , Status.Incompatible }, // Extended Public Transport UI (+DLCs!)
                    { 419090722u , Status.Compatible   }, // Mod Corral
                    { 411164732u , Status.Incompatible }, // Extended Public Transport UI (Obsolete)
                    { 409338401u , Status.Incompatible }, // ScaleUI (beta)
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                ContinuationOf = 407225523u, // TextScaleMod
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete // new ver avail
                      | ItemFlags.SourceAvailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "To reset scale to default, hit Ctrl+0 (zero)." },
                },
                Published = WorkshopDate("17 Mar, 2015"),
                ReplaceWith = 2040218778u, // ScaleUI
                SourceURL = "https://github.com/githubpermutation/skylines-scaleui",
                Updated = WorkshopDate("14 Apr, 2015"),
            });

            // Runs code in it's .Name property
            // That code includes UIView.GetAView() without checking to see if it's null
            // Will throw exception to any mod querying its name during splash screens
            AddMod(new Review(408286108u, "SkylinesFont") {
                Affect = Factor.UI,
                Authors = "WiseClock",
                BrokenBy = GameVersion.Patch_1_1_1,
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 412149127u , Status.Incompatible }, // Font Selector
                    { 408286108u , Status.Incompatible }, // SkylinesFont
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                CompatibleWith = GameVersion.Patch_1_1_0,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BadStartup
                      | ItemFlags.BrokenByUpdate
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceUnavailable,
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "This mod causes an error on app startup and can cause other mods to break; unsubscribe it!" },
                },
                Published = WorkshopDate("15 Mar, 2015"),
                ReplaceWith = 412149127u, // Font Selector
                Updated = WorkshopDate("16 Mar, 2015"),
                UserModInspected = true,
            });

            AddMod(new Review(407225523u, "TextScaleMod") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20150703140007/http://steamcommunity.com/sharedfiles/filedetails/?id=407225523",
                Authors = "alex3305",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 2040218778u, Status.Incompatible }, // ScaleUI
                    { 2009172305u, Status.Incompatible }, // EPTUI TLM Integration (Beta)
                    { 419090722u , Status.Incompatible }, // Mod Corral
                    { 412149127u , Status.Incompatible }, // Font Selector
                    { 409338401u , Status.Incompatible }, // ScaleUI (beta)
                    { 408286108u , Status.Incompatible }, // SkylinesFont
                    { 407225523u , Status.Incompatible }, // TextScaleMod
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // gone by Jan 2019
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("13 Mar, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/alex3305/CitiesSkylinesTextScaleMod",
                Updated = WorkshopDate("14 Mar, 2015"),
            });

            // Compatible with Reddit for Chirpy mod by 'mabako' and Chirp Filter mod by 'Zuppi' 
            AddMod(new Review(406623071u, "Chirpy Banner") {
                Affect = Factor.UI,
                ArchiveURL = "https://web.archive.org/web/20151122135431/http://steamcommunity.com/sharedfiles/filedetails/?id=406623071",
                Authors = "brittany",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 419090722u , Status.Required     }, // Mod Corral
                },
                Flags = ItemFlags.Abandonware
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop // avail Nov 2015, gone by Jun 2016
                      | ItemFlags.SourceAvailable,
                Published = WorkshopDate("14 Mar, 2015"), // guessing based on github initial commit
                SourceURL = "https://github.com/brittanygh/CS-ChirpBanner",
                Updated = WorkshopDate("8 Apr, 2015"),
            });
        }
    }
}