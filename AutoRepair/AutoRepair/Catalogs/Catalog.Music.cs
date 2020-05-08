namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// CSL Music mods.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "Legibility.")]
    [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "Legibility.")]
    public partial class Catalog {

        /// <summary>
        /// Helper to add musics; sets default values for a few properties.
        /// </summary>
        /// <param name="item">The item to add.</param>
        internal void AddMusicMod(Review item) {

            item.Affect = Factor.Audio;

            item.Catalog = "Music";

            if (item.Compatibility == null) {
                item.Compatibility = new Dictionary<ulong, Status> {
                    { 422934383uL, Status.Required }, // CSL Music Mod
                };
            }

            if (item.CompatibleWith == GameVersion.DefaultRelease && item.BrokenBy == GameVersion.DefaultUntil) {
                item.CompatibleWith = GameVersion.Active;
            }

            if (!item.HasFlag(ItemFlags.SourceAvailable | ItemFlags.SourceBundled | ItemFlags.SourceUnavailable)) {
                item.Flags |= ItemFlags.SourceBundled;
            }

            AddMod(item);
        }

        /// <summary>
        /// Add music packs to the list.
        ///
        /// TODO:
        /// * Add large file warnings where necessary.
        /// * Link to artist websites where known.
        /// * Add workshop author names.
        /// * Add locales where applicable.
        /// </summary>
        private void MusicMods() {

            string catalog = "Music";

            AddMod(new Review(422934383uL, "CSL Music Mod") {
                Affect = Factor.Audio,
                Authors = "mrnotsoevil",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
                LastSeen = WorkshopDate("3 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Documentation for users and authors: https://github.com/rumangerst/CSLMusicMod/wiki" },
                    { NOTE, "Most music packs / stations are copyrighted and must not be played while streaming." },
                },
                Published = WorkshopDate("15 Apr, 2015"),
                SourceURL = "https://github.com/rumangerst/CSLMusicMod",
                Updated = WorkshopDate("14 Dec, 2018"),
            });

            /*
            # ███████ ████████  █████  ████████ ██  ██████  ███    ██ ███████
            # ██         ██    ██   ██    ██    ██ ██    ██ ████   ██ ██
            # ███████    ██    ███████    ██    ██ ██    ██ ██ ██  ██ ███████
            #      ██    ██    ██   ██    ██    ██ ██    ██ ██  ██ ██      ██
            # ███████    ██    ██   ██    ██    ██  ██████  ██   ████ ███████
            */

            AddMusicMod(new Review(2087941805uL, "Dystopian Radio Public Announcements") {
                Authors = "Zahav",
                LastSeen = WorkshopDate("8 May, 2020"),
                Published = WorkshopDate("7 May, 2020"),
                Updated = WorkshopDate("7 May, 2020"),
            });

            AddMusicMod(new Review(2071736375uL, "Pokemon 3rd Gen Soundtrack") {
                Authors = "Consumedgrub2",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("23 Apr, 2020"),
                Updated = WorkshopDate("23 Apr, 2020"),
            });

            AddMusicMod(new Review(2066240106uL, "The Legend of Zelda: Phantom Hourglass Music Pack") {
                Authors = "Consumedgrub2",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("19 Apr, 2020"),
                Updated = WorkshopDate("19 Apr, 2020"),
            });

            AddMusicMod(new Review(2065332413uL, "Crash FM Radio Station") {
                Authors = "johnyTahn",
                Flags = ItemFlags.LargeFileWarning, // 108 MB
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("18 Apr, 2020"),
                Updated = WorkshopDate("18 Apr, 2020"),
            });

            AddMusicMod(new Review(2062757387uL, "Locomotion Radio") {
                Authors = "samsonite",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("16 Apr, 2020"),
                Updated = WorkshopDate("16 Apr, 2020"),
            });


            AddMusicMod(new Review(2057429333uL, "City Life (2006) Music Pack") {
                Authors = "Autokratao",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("11 Apr, 2020"),
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            AddMusicMod(new Review(2056024655uL, "VAMorgans FM Radio") {
                Authors = "ViceAdmiral Morgan",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusicMod(new Review(2055991875uL, "Industry Giant II - CSL Music Pack") {
                Authors = "(gibberish name)",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusicMod(new Review(2055714904uL, "The Hu") {
                Authors = "ViceAdmiral Morgan",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusicMod(new Review(2049820944uL, "Pokemon FM: A Pokemon Game Music Radio Station (Gen. IV-VI)") {
                Authors = "badplayer95",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Apr, 2020"),
                Updated = WorkshopDate("5 Apr, 2020"),
            });

            AddMusicMod(new Review(2048519799uL, "The Legend Of Zelda: Spirit Tracks Music Pack [IMPROVED]") {
                Authors = "Consumedgrub2",
                Compatibility = new Dictionary<ulong, Status> {
                    { 2039485213uL, Status.Incompatible }, // The Legend Of Zelda: Spirit Tracks Music Pack [IMPROVED]
                    { 422934383uL , Status.Required     }, // CSL Music Mod
                },
                ContinuationOf = 2039485213uL, // The Legend Of Zelda: Spirit Tracks Music Pack
                Flags = ItemFlags.LargeFileWarning, // 115 MB
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("5 Apr, 2020"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            AddMusicMod(new Review(2048091295uL, "Monster Hunter World") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 214 MB
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusicMod(new Review(2048003647uL, "Elite Dangerous") {
                Authors = "Mr. Monday",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusicMod(new Review(2048002477uL, "Advance Wars") {
                Authors = "Mr. Monday",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusicMod(new Review(2042929072uL, "Music Pack: Cubeworld Soundtrack Music Pack") {
                Authors = "Exoidus",
                LastSeen = WorkshopDate("3 May, 2020"),
                Published = WorkshopDate("1 Apr, 2020"),
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMusicMod(new Review(2040635682uL, "Ocarina of Time music pack") {
                Authors = "Consumedgrub2",
                LastSeen = WorkshopDate("2 May, 2020"),
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            AddMusicMod(new Review(2040545346uL, "Zelda Radio for CSLMusicMod") {
                Authors = "Consumedgrub2",
                LastSeen = WorkshopDate("2 May, 2020"),
                Published = WorkshopDate("30 Mar, 2020"),
                Updated = WorkshopDate("31 Mar, 2020"),
            });

            AddMusicMod(new Review(2040390596uL, "Animal Crossing Music Pack") {
                Authors = "Consumedgrub2",
                LastSeen = WorkshopDate("2 May, 2020"),
                Published = WorkshopDate("29 Mar, 2020"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            AddMusicMod(new Review(2039485213uL, "The Legend Of Zelda: Spirit Tracks Music Pack") {
                Authors = "Consumedgrub2",
                Compatibility = new Dictionary<ulong, Status> {
                    { 2048519799uL, Status.Incompatible }, // The Legend Of Zelda: Spirit Tracks Music Pack [IMPROVED]
                    { 422934383uL , Status.Required     }, // CSL Music Mod
                },
                Flags = ItemFlags.LargeFileWarning // guesstimate based on replacement item
                      | ItemFlags.NoWorkshop, // gone as of 23 Apr 2020
                LastSeen = WorkshopDate("5 Apr, 2020"),
                Published = WorkshopDate("29 Mar, 2020"), // based on 2039485212
                Removed = WorkshopDate("23 Apr, 2020"),
                ReplaceWith = 2048519799uL, // The Legend Of Zelda: Spirit Tracks Music Pack [IMPROVED]
                Updated = WorkshopDate("5 Apr, 2020"), // guesstimate based on replacement item by same author
                Suppress = Warning.MissingArchiveURL,
            });

            AddMusicMod(new Review(2037555938uL, "Neon Genesis Evangelion Music Pack") {
                Authors = "PoeticTeacup",
                LastSeen = WorkshopDate("2 May, 2020"),
                Published = WorkshopDate("27 Mar, 2020"),
                Updated = WorkshopDate("27 Mar, 2020"),
            });

            // Soundtrack From Touhou 8 Imperishable Night (2004) created By ZUN
            AddMusicMod(new Review(2023013451uL, "Touhou 8 Soundtrack") {
                Authors = "v.peterbilt",
                Flags = ItemFlags.LargeFileWarning, // 104 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Published = WorkshopDate("15 Mar, 2020"),
                Updated = WorkshopDate("15 Mar, 2020"),
            });

            AddMusicMod(new Review(2014962352uL, "MapleStory completed music pack") {
                Authors = "레베",
                Compatibility = new Dictionary<ulong, Status> {
                    { 1849251185uL, Status.Incompatible }, // MapleStory Music pack
                    { 422934383uL , Status.Required     }, // CSL Music Mod
                },
                ContinuationOf = 1849251185uL, // MapleStory Music pack
                Flags = ItemFlags.Laggy
                      | ItemFlags.LargeFileWarning, // 2 GB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ko",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Likely to cause in-game lag due to huge number of UI components in track list." },
                    { NOTE, "This pack is 2 GB file size. A smaller version (fewer tracks) is available: https://steamcommunity.com/sharedfiles/filedetails/?id=1849251185" },
                },
                Published = WorkshopDate("6 Mar, 2020"),
                Updated = WorkshopDate("6 Mar, 2020"),
            });

            AddMusicMod(new Review(2011828439uL, "Midnight Club 3 DUB Edition Remix Soundtrack Pack") {
                Authors = "MrJacon000",
                Flags = ItemFlags.LargeFileWarning, // 524 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Soundtrack list: https://mrjacon000.weebly.com/mc3-soundtrack.html" },
                },
                Published = WorkshopDate("2 Mar, 2020"),
                Updated = WorkshopDate("26 Mar, 2020"),
            });

            AddMusicMod(new Review(2003548790uL, "F-Zero Soundtrack SNES") {
                Authors = "MrJacon000",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("21 Feb, 2020"),
                Updated = WorkshopDate("21 Feb, 2020"),
            });

            AddMusicMod(new Review(1986583172uL, "Pop Shop Radio") {
                Authors = "TK-421",
                LastSeen = WorkshopDate("2 May, 2020"),
                // Locale = "*", // south africa
                Published = WorkshopDate("2 Feb, 2020"),
                Updated = WorkshopDate("2 Feb, 2020"),
            });

            AddMusicMod(new Review(1979801131uL, "RPG Town Music Collection") {
                Authors = "SuperNerdLand",
                Flags = ItemFlags.LargeFileWarning, // 236 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("26 Jan, 2020"),
                Updated = WorkshopDate("26 Jan, 2020"),
            });

            AddMusicMod(new Review(1977714042uL, "Terence McKenna FM") {
                Authors = "EarthwormDan",
                Flags = ItemFlags.LargeFileWarning // 209 MB
                      | ItemFlags.Streamable,
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en-us",
                Published = WorkshopDate("24 Jan, 2020"),
                Updated = WorkshopDate("24 Jan, 2020"),
            });

            AddMusicMod(new Review(1939689497uL, "music pack K-on 自用音乐") {
                Authors = "立華かなで",
                Flags = ItemFlags.LargeFileWarning, // 98 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "zh-cn",
                Published = WorkshopDate("18 Dec, 2019"),
                Updated = WorkshopDate("18 Dec, 2019"),
            });

            AddMusicMod(new Review(1935185911uL, "Animal Crossing GC Radio Station") {
                Authors = "Smugleaf",
                Flags = ItemFlags.LargeFileWarning, // 384 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("13 Dec, 2019"),
                Updated = WorkshopDate("13 Dec, 2019"),
            });

            AddMusicMod(new Review(1928810625uL, "Rock Japan!") {
                Authors = "Miyafuji Yoshika",
                Flags = ItemFlags.LargeFileWarning, // 318 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("5 Dec, 2019"),
                Updated = WorkshopDate("5 Dec, 2019"),
            });

            AddMusicMod(new Review(1927877071uL, "SimCity NES Music Pack") {
                Authors = "Smugleaf",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("4 Dec, 2019"),
                Updated = WorkshopDate("4 Dec, 2019"),
            });

            AddMusicMod(new Review(1923113557uL, "Music Pack: Transport Fever") {
                Authors = "Kaldie",
                Flags = ItemFlags.LargeFileWarning, // 206 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("28 Nov, 2019"),
                Updated = WorkshopDate("28 Nov, 2019"),
            });

            AddMusicMod(new Review(1907872124uL, "Music Pack: Chris Sawyer's Locomotion") {
                Authors = "Kaldie",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("7 Nov, 2019"),
                Updated = WorkshopDate("7 Nov, 2019"),
            });

            AddMusicMod(new Review(1894383481uL, "Cities XL XXL music") {
                Authors = "Quenkslet",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("20 Oct, 2019"),
                Updated = WorkshopDate("20 Oct, 2019"),
            });

            AddMusicMod(new Review(1887810146uL, "The Sims 4 Tropical Music Pack") {
                Authors = "Adipup",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("12 Oct, 2019"),
                Updated = WorkshopDate("22 Jan, 2020"),
            });

            AddMusicMod(new Review(1887783546uL, "The Sims 4 Spooky Music Pack") {
                Authors = "Adipup",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("12 Oct, 2019"),
                Updated = WorkshopDate("22 Jan, 2020"),
            });

            AddMusicMod(new Review(1876535635uL, "Chillhop Essentials - Fall 2019 - chill & lofi hiphop beats") {
                Authors = "Reece",
                Flags = ItemFlags.LargeFileWarning, // 153 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                //Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Track list: https://www.discogs.com/Various-Chillhop-Essentials-Fall-2019-/master/1660233" },
                },
                Published = WorkshopDate("30 Sep, 2019"),
                Updated = WorkshopDate("30 Sep, 2019"),
            });

            AddMusicMod(new Review(1867580281uL, "101 FM") {
                Authors = "Windy",
                LastSeen = WorkshopDate("2 May, 2020"),
                // Locale = "*",
                Published = WorkshopDate("20 Sep, 2019"),
                Updated = WorkshopDate("20 Sep, 2019"),
            });

            AddMusicMod(new Review(1860387063uL, "Metropolis FM - Curated Electronic Music Radio") {
                Authors = "BV",
                Flags = ItemFlags.LargeFileWarning, // 111 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                // Locale = "*",
                Published = WorkshopDate("11 Sep, 2019"),
                Updated = WorkshopDate("13 Oct, 2019"),
            });

            AddMusicMod(new Review(1849251185uL, "MapleStory Music pack") {
                Authors = "레베",
                Compatibility = new Dictionary<ulong, Status> {
                    { 2014962352uL, Status.Incompatible }, // MapleStory completed music pack
                    { 422934383uL , Status.Required     }, // CSL Music Mod
                },
                Flags = ItemFlags.LargeFileWarning, // 290 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ko",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "If you have lots of disk space (2 GB), a larger pack with more tracks is available: https://steamcommunity.com/sharedfiles/filedetails/?id=2014962352uL" },
                },
                Published = WorkshopDate("30 Aug, 2019"),
                Updated = WorkshopDate("30 Aug, 2019"),
            });

            AddMusicMod(new Review(1849248489uL, "NEED FOR SPEED Most Wanted 2012 Music Pack") {
                Authors = "레베",
                Flags = ItemFlags.LargeFileWarning, // 172 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("30 Aug, 2019"),
                Updated = WorkshopDate("3 Apr, 2020"),
            });

            // Can stream as long as song title displayed
            AddMusicMod(new Review(1836790997uL, "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)") {
                Authors = "Asneakyninja1",
                Flags = ItemFlags.Laggy
                      | ItemFlags.LargeFileWarning // 3.76 GB!
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Streamable,
                LastSeen = WorkshopDate("2 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Likely to cause in-game lag due to huge number of UI components in track list." },
                    { NOTE, "This pack is almost 4 GB file size!" },
                    { NOTE, "Streaming is allowed if the song title is displayed." },
                },
                SourceURL = "https://www.ninety9lives.com/",
            });

            AddMusicMod(new Review(1836775697uL, "Arcadia Bay Radio") {
                Authors = "Viva Max Channel",
                Locale = "en",
                LastSeen = WorkshopDate("2 May, 2020"),
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music is from the game 'Life Is Strange: Before The Storm': https://store.steampowered.com/app/554620/Life_is_Strange_Before_the_Storm/" },
                    { NOTE, "A map based on the game is also available: https://steamcommunity.com/sharedfiles/filedetails/?id=1555624445" },
                },
                Published = WorkshopDate("16 Aug, 2019"),
                Updated = WorkshopDate("16 Aug, 2019"),
            });

            AddMusicMod(new Review(1831829697uL, "The Easy Listening Station") {
                Authors = "Lisa 15",
                Flags = ItemFlags.LargeFileWarning, // 668 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("11 Aug, 2019"),
                Updated = WorkshopDate("11 Aug, 2019"),
            });

            AddMusicMod(new Review(1822078418uL, "Music Pack: Chillhop Essentials - Summer 2019") {
                Authors = "Reece",
                Flags = ItemFlags.LargeFileWarning, // 151 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Track list: https://www.discogs.com/Various-Chillhop-Essentials-Summer-2019/release/13947148" },
                },
                Published = WorkshopDate("1 Aug, 2019"),
                Updated = WorkshopDate("1 Aug, 2019"),
            });

            AddMusicMod(new Review(1815418533uL, "Dad Feels FM") {
                Authors = "Samsung ME6144ST 1000W Microwave",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("26 Jul, 2019"),
                Updated = WorkshopDate("26 Jul, 2019"),
            });

            AddMusicMod(new Review(1814563985uL, "AfroBeat4CSL") {
                Authors = "BlueMarvel1914",
                LastSeen = WorkshopDate("2 May, 2020"),
                // Locale = "en",
                Published = WorkshopDate("25 Jul, 2019"),
                Updated = WorkshopDate("25 Jul, 2019"),
            });

            AddMusicMod(new Review(1794625110uL, "Music Pack: JazzHop Cafe - Spring Mix 2019") {
                Authors = "Reece",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("6 Jul, 2019"),
                Updated = WorkshopDate("6 Jul, 2019"),
            });

            AddMusicMod(new Review(1791020927uL, "SimCity (2013) + Cities of Tomorrow Music Pack") {
                Authors = "Mightylink",
                Flags = ItemFlags.LargeFileWarning, // 317 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A smaller music pack is available (fewer tracks): https://steamcommunity.com/sharedfiles/filedetails/?id=634216395" },
                },
                Published = WorkshopDate("4 Jul, 2019"),
                Updated = WorkshopDate("4 Jul, 2019"),
            });

            AddMusicMod(new Review(1787333298uL, "Lil Peep Music pack") {
                Authors = "JohnnyFromFireArms",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "In-game, the music pack is listed as 'JohnyFromFireArms' not 'Lil Peep'." },
                },
                Published = WorkshopDate("1 Jul, 2019"),
                Updated = WorkshopDate("1 Jul, 2019"),
            });

            AddMusicMod(new Review(1780166508uL, "Ace Combat Music") {
                Authors = "Mobius",
                Flags = ItemFlags.LargeFileWarning, // 159 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("24 Jun, 2019"),
                Updated = WorkshopDate("24 Jun, 2019"),
            });

            AddMusicMod(new Review(1774745517uL, "Classics") {
                Authors = "Decentpower",
                Flags = ItemFlags.LargeFileWarning, // 268 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("19 Jun, 2019"),
                Updated = WorkshopDate("19 Jun, 2019"),
            });

            AddMusicMod(new Review(1771297364uL, "Mr. Monday's Metal Mania Mix Vol. 11") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 478 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("15 Jun, 2019"),
                Updated = WorkshopDate("15 Jun, 2019"),
            });

            AddMusicMod(new Review(1769990021uL, "Emotional Business Tracks Vol. 2") {
                Authors = "[HG]Drebing",
                Flags = ItemFlags.LargeFileWarning, // 91 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("14 Jun, 2019"),
                Updated = WorkshopDate("14 Jun, 2019"),
            });

            AddMusicMod(new Review(1764607719uL, "Mr. Monday's Metal Mania Mix Vol. 10") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 537 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("8 Jun, 2019"),
                Updated = WorkshopDate("8 Jun, 2019"),
            });

            AddMusicMod(new Review(1764430171uL, "Shostakovich_Symphoneies_Music_Pack") {
                Authors = "kage",
                Flags = ItemFlags.NoWorkshop, // removed between 26 Mar, 2020 - 24 Apr, 2020
                LastSeen = WorkshopDate("26 Mar, 2020"),
                Locale = "*",
                Published = WorkshopDate("8 Jun, 2019"), // based on 1764430170
                Removed = WorkshopDate("24 Apr, 2020"),
                Suppress = Warning.MissingArchiveURL,
                Updated = WorkshopDate("8 Jun, 2019"),
            });

            AddMusicMod(new Review(1764130877uL, "Shostakovich_String_Quartets_Music_Pack") {
                Authors = "kage",
                Flags = ItemFlags.LargeFileWarning, // 389 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("8 Jun, 2019"),
                Updated = WorkshopDate("8 Jun, 2019"),
            });

            AddMusicMod(new Review(1762692942uL, "Mr. Monday's Metal Mania Mix Vol. 9") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 594 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("6 Jun, 2019"),
                Updated = WorkshopDate("6 Jun, 2019"),
            });

            AddMusicMod(new Review(1761203207uL, "Mr. Monday's Metal Mania Mix Vol. 8") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 524 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("5 Jun, 2019"),
                Updated = WorkshopDate("5 Jun, 2019"),
            });

            AddMusicMod(new Review(1758033583uL, "Soviet Music FM CSL Radio") {
                Authors = "HereticRubin",
                Flags = ItemFlags.LargeFileWarning, // 212 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ru",
                Published = WorkshopDate("1 Jun, 2019"),
                Updated = WorkshopDate("1 Jun, 2019"),
            });

            AddMusicMod(new Review(1750219658uL, "Rammstein FM") {
                Authors = "SmartArrow",
                Flags = ItemFlags.LargeFileWarning, // 436 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "de",
                Published = WorkshopDate("24 May, 2019"),
                Updated = WorkshopDate("24 May, 2019"),
            });

            AddMusicMod(new Review(1749984376uL, "Mr. Monday's Metal Mania Mix Vol. 7") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 500 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("24 May, 2019"),
                Updated = WorkshopDate("24 May, 2019"),
            });

            AddMusicMod(new Review(1749674478uL, "Mr. Monday's Metal Mania Mix Vol. 6") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 555 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("23 May, 2019"),
                Updated = WorkshopDate("23 May, 2019"),
            });

            AddMusicMod(new Review(1747687461uL, "Mr. Monday's Metal Mania Vol. 5") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 554 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("21 May, 2019"),
                Updated = WorkshopDate("21 May, 2019"),
            });

            AddMusicMod(new Review(1746755744uL, "Mr. Monday's Metal Mania Vol. 4") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 513 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("20 May, 2019"),
                Updated = WorkshopDate("20 May, 2019"),
            });

            AddMusicMod(new Review(1745927147uL, "Music Pack - Crash FM: Burnout Paradise") {
                Authors = "Plague Doctor #141",
                Flags = ItemFlags.LargeFileWarning, // 144 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from game 'Burnout Paradise' - track list: https://www.ea.com/en-gb/games/burnout/burnout-paradise-remastered/news/official-soundtrack" },
                },
                Published = WorkshopDate("19 May, 2019"),
                Updated = WorkshopDate("19 May, 2019"),
            });

            AddMusicMod(new Review(1745924501uL, "Music Pack - Crash FM: Burnout Revenge") {
                Authors = "Plague Doctor #141",
                Flags = ItemFlags.LargeFileWarning, // 147 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from game 'Burnout Revenge' - track list: https://burnout.fandom.com/wiki/Soundtrack_(Burnout_Revenge)" },
                },
                Published = WorkshopDate("19 May, 2019"),
                Updated = WorkshopDate("19 May, 2019"),
            });

            AddMusicMod(new Review(1745921826uL, "Music Pack - Crash FM - Burnout 3") {
                Authors = "Plague Doctor #141",
                Flags = ItemFlags.LargeFileWarning, // 133 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from game 'Burnout 3' - track list: https://burnout.fandom.com/wiki/Soundtrack_(Burnout_3)" },
                },
                Published = WorkshopDate("19 May, 2019"),
                Updated = WorkshopDate("19 May, 2019"),
            });

            AddMusicMod(new Review(1745918041uL, "Music Pack - Fallout 76 - Appalachia Radio") {
                Authors = "Plague Doctor #141",
                Flags = ItemFlags.LargeFileWarning, // 136 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "'Appalachia Radio' from game 'Fallout 76' - track list: https://fallout.fandom.com/wiki/Appalachia_Radio" },
                },
                Published = WorkshopDate("19 May, 2019"),
                Updated = WorkshopDate("19 May, 2019"),
            });

            AddMusicMod(new Review(1745397514uL, "Mr. Monday's Metal Mania Mix Vol. 3") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 530 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMusicMod(new Review(1744768948uL, "Tsargrad Russian Imperial radio") {
                Authors = "Zahav",
                Flags = ItemFlags.LargeFileWarning, // 788 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ru",
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMusicMod(new Review(1744288199uL, "Blast Corps") {
                Authors = "Mr. Monday",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from N64 'Blast Corps' game - track list: https://www.zophar.net/music/nintendo-64-usf/blast-corps" },
                },
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMusicMod(new Review(1744275985uL, "Mr. Monday's Metal Mania Mix Vol. 2") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 497 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("18 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMusicMod(new Review(1744060785uL, "C&C Red Alert Retaliation Music") {
                Authors = "Mr. Monday",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from 'C&C Red Alert 3' game - track list: https://en.wikipedia.org/wiki/Music_of_the_Command_%26_Conquer_series" },
                },
                Published = WorkshopDate("17 May, 2019"),
                Updated = WorkshopDate("17 May, 2019"),
            });

            AddMusicMod(new Review(1743852125uL, "Mr. Monday's Metal Mania Mix Vol. 1") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 487 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("17 May, 2019"),
                Updated = WorkshopDate("18 May, 2019"),
            });

            AddMusicMod(new Review(1740593354uL, "BABYMETAL Radio (Music Mod)") {
                Authors = "LtGenSpartan",
                LastSeen = WorkshopDate("2 May, 2020"),
                Flags = ItemFlags.LargeFileWarning, // 233 MB
                Locale = "ja",
                Published = WorkshopDate("13 May, 2019"),
                Updated = WorkshopDate("4 Jul, 2019"),
            });

            AddMusicMod(new Review(1737797719uL, "Opeth Radio (Music Mod)") {
                Authors = "LtGenSpartan",
                Flags = ItemFlags.Laggy
                      | ItemFlags.LargeFileWarning, // 1.2 GB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en", // despite being Swedish band
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Likely to cause in-game lag due to huge number of UI components in track list." },
                },
                Published = WorkshopDate("11 May, 2019"),
                Updated = WorkshopDate("11 May, 2019"),
            });

            AddMusicMod(new Review(1716463067uL, "Stardew Valley: CSL Music Pack") {
                Authors = "jamma003",
                Flags = ItemFlags.Streamable,
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from 'Stardew Valley' game, published with permission of developer: https://store.steampowered.com/app/413150/Stardew_Valley/" },
                },
                Published = WorkshopDate("19 Apr, 2019"),
                Updated = WorkshopDate("19 Apr, 2019"),
            });

            AddMusicMod(new Review(1695888523uL, "Gutter Radio Station - Metal Music") {
                Authors = "The Man Behind The Mask",
                Flags = ItemFlags.LargeFileWarning, // 450 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("27 Mar, 2019"),
                Updated = WorkshopDate("28 Mar, 2019"),
            });

            AddMusicMod(new Review(1693073075uL, "Morioh Cho Radio(Jojo Radio Station)") {
                Authors = "iOddish",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "ja",
                Published = WorkshopDate("24 Mar, 2019"),
                Updated = WorkshopDate("24 Mar, 2019"),
            });

            AddMusicMod(new Review(1676346063uL, "R4: Ridge Racer Type 4 OST Music Pack") {
                Authors = "Mr. Panda",
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("8 Mar, 2019"),
                Updated = WorkshopDate("8 Mar, 2019"),
            });

            AddMusicMod(new Review(1667955065uL, "Starcraft Music Pack") {
                Authors = "JustUni",
                Flags = ItemFlags.LargeFileWarning, // 200 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("27 Feb, 2019"),
                Updated = WorkshopDate("27 Feb, 2019"),
            });

            AddMusicMod(new Review(1667954427uL, "Starcraft Vol 1 Music Pack") {
                Authors = "JustUni",
                Flags = ItemFlags.LargeFileWarning, // 186 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("27 Feb, 2019"),
                Updated = WorkshopDate("27 Feb, 2019"),
            });

            AddMusicMod(new Review(1666843975uL, "DarkAmbient_rythmical_") {
                Authors = "Rod Zè",
                Flags = ItemFlags.LargeFileWarning, // 364 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("25 Feb, 2019"),
                Updated = WorkshopDate("25 Feb, 2019"),
            });

            AddMusicMod(new Review(1666828843uL, "DarkAmbient_calming_") {
                Authors = "Rod Zè",
                Flags = ItemFlags.LargeFileWarning, // 385 MB
                LastSeen = WorkshopDate("2 May, 2020"),
                Locale = "en",
                Published = WorkshopDate("25 Feb, 2019"),
                Updated = WorkshopDate("25 Feb, 2019"),
            });

            AddMusicMod(new Review(1662935352uL, "Your Local on The 98.8's") {
                Authors = "Miyafuji Yoshika",
                Flags = ItemFlags.LargeFileWarning, // 280 MB
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en-us",
                Published = WorkshopDate("22 Feb, 2019"),
                Updated = WorkshopDate("22 Feb, 2019"),
            });

            AddMusicMod(new Review(1656737510uL, "YIMBY Radio (Yes In My Backyard)") {
                Authors = "YIMBY Arts",
                Flags = ItemFlags.LargeFileWarning, // 270 MB
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "en-us",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Related website: http://yimbyarts.org" },
                    { NOTE, "Youtube channel: https://www.youtube.com/watch?v=2Y8I-hwkBII&list=PLP6Mv_vlpBeKfJnYkcatjrfB5ChjFyJR6" },
                },
                Published = WorkshopDate("16 Feb, 2019"),
                Updated = WorkshopDate("25 Feb, 2019"),
            });

            AddMusicMod(new Review(1608576363uL, "OpenTTD Music Pack") {
                Authors = "ilBone",
                Flags = ItemFlags.LargeFileWarning // 210 MB
                      | ItemFlags.Streamable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from the open source game: https://www.openttd.org/" },
                    { NOTE, "OpenMSX Music Replacement Set for OpenTTD Copyright (C) 2010 OpenMSX Authors and is licensed under GPL v2 open source license." },
                },
                Published = WorkshopDate("30 Dec, 2018"),
                Updated = WorkshopDate("1 Jan, 2019"),
            });

            AddMusicMod(new Review(1599088128uL, "Mayor Radio") {
                Authors = "Marty Chonks",
                Flags = ItemFlags.Laggy
                      | ItemFlags.LargeFileWarning, // 1.865 GB!
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "Music from lots of sim and tycoon games." },
                    { NOTE, "Likely to cause in-game lag due to huge number of UI components in track list." },
                    { NOTE, "This pack is almost 2 GB file size!" },
                },
                Published = WorkshopDate("23 Dec, 2018"),
                Updated = WorkshopDate("16 Dec, 2019"),
            });

            AddMusicMod(new Review(1588118049uL, "Music Pack: Free For Use Music Pack") {
                Authors = "Exoidus",
                Flags = ItemFlags.Streamable,
                LastSeen = WorkshopDate("8 May, 2020"),
                Locale = "*",
                Published = WorkshopDate("11 Dec, 2018"),
                Updated = WorkshopDate("11 Dec, 2018"),
            });

            AddMusicMod(new Review(1583013403uL, "Music Pack: LineageII Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1582786251uL, "Music Pack: ShenzhenIO Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1581924890uL, "Music Pack: Spyro Reignited Trilogy - Complete OST") {
            });

            AddMusicMod(new Review(1581529605uL, "Spotify - All Out 00s") {
            });

            AddMusicMod(new Review(1581222201uL, "Music Pack: Laura Brehm (Progressive House)") {
            });

            AddMusicMod(new Review(1580837351uL, "Music Pack: Club MTV - Dance Anthems") {
            });

            AddMusicMod(new Review(1578138249uL, "Music Pack: Minecraft Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1577301964uL, "Music Pack: Chillhop Essentials Fall 2018") {
            });

            AddMusicMod(new Review(1574901147uL, "Only Anistep for CSL MUSIC") {
            });

            AddMusicMod(new Review(1574616741uL, "Music Pack: The Jazz Hop Cafe - Jazzhop Christmas") {
            });

            AddMusicMod(new Review(1574204018uL, "Music Pack: The Jazz Hop Cafe - Lofi Christmas") {
            });

            AddMusicMod(new Review(1573686513uL, "Music Pack: Vladivostok FM (TBOGT)") {
            });

            AddMusicMod(new Review(1573683382uL, "Music Pack: Electro-Choc (TBOGT)") {
            });

            AddMusicMod(new Review(1569009943uL, "Faith Radio - Радио Вера") {
            });

            AddMusicMod(new Review(1568910950uL, "Zone radio") {
            });

            AddMusicMod(new Review(1566293203uL, "NIGHTFALL RADIO") {
            });

            AddMusicMod(new Review(1565992217uL, "Mirror's Edge Catalyst Ambience Music Pack") {
            });

            AddMusicMod(new Review(1564632871uL, "Los Santos Rock Radio") {
            });

            AddMusicMod(new Review(1563236161uL, "Non Stop Pop FM") {
            });

            AddMusicMod(new Review(1562159034uL, "Pokemon Radio") {
            });

            AddMusicMod(new Review(1559217826uL, "Neon Desert Radio Earth") {
            });

            AddMusicMod(new Review(1551413082uL, "Sunless Radio - CSL Music Mod") {
            });

            AddMusicMod(new Review(1551254449uL, "Factorio Radio - CSL Music Mod") {
            });

            AddMusicMod(new Review(1549204922uL, "Liberty Rock Radio") {
            });

            AddMusicMod(new Review(1549159888uL, "K-Rose Radio") {
            });

            // all tracks from free section on artist website
            AddMusicMod(new Review(1544343001uL, "Evil Needle Music Pack") {
                Flags = ItemFlags.Streamable,
            });

            AddMusicMod(new Review(1533463444uL, "[CSLMM] Wave City Radio") {
            });

            AddMusicMod(new Review(1527318643uL, "K-ZUN Touhou Jazz CSL Music Station") {
            });

            AddMusicMod(new Review(1521439327uL, "Need For Speed Hot Pursuit II Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1521382830uL, "Need For Speed Porsche Unleashed Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1521316560uL, "Need For Speed High Stakes Soundtrack Pack") {
            });

            AddMusicMod(new Review(1521193646uL, "Need For Speed III Hot Pursuit Soundtrack Pack") {
            });

            AddMusicMod(new Review(1520526038uL, "Need For Speed II SE Soundtrack Pack") {
            });

            AddMusicMod(new Review(1520422010uL, "Need For Speed SE (1994) Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1515080990uL, "The Sims 2 Music Mod") {
            });

            AddMusicMod(new Review(1468593438uL, "Simcity Cities of Tomorrow music pack") {
            });

            AddMusicMod(new Review(1448884662uL, "ROCK FM") {
            });

            AddMusicMod(new Review(1412112969uL, "Granado Espada Music Pack 2") {
            });

            AddMusicMod(new Review(1412098032uL, "Granado Espada Music Pack 3") {
            });

            AddMusicMod(new Review(1411460758uL, "Granado Espada Music Pack 1") {
            });

            AddMusicMod(new Review(1400137014uL, "Music pack: Everyone's Music") {
            });

            AddMusicMod(new Review(1394707020uL, "SimCity 4 Radio") {
            });

            AddMusicMod(new Review(1372895052uL, "The Soviet Music Pack (Советский музыкальный пакет)") {
            });

            AddMusicMod(new Review(1364831709uL, "CSL Music Mod - Alledion's Mega Electronic Mix") {
            });

            AddMusicMod(new Review(1357175278uL, "Music Pack: College Music") {
            });

            AddMusicMod(new Review(1351895231uL, "Little Witch Academia OST (Music pack)") {
            });

            AddMusicMod(new Review(1347144721uL, "Music Pack: DiscoverTheVibes") {
            });

            AddMusicMod(new Review(1344820938uL, "Music Pack: Sonic Heroes OST") {
            });

            AddMusicMod(new Review(1342303998uL, "Music Pack: SoundBucket - Good Vibes") {
            });

            AddMusicMod(new Review(1339803856uL, "Music Pack: Monstercat - Glitch Hop") {
            });

            AddMusicMod(new Review(1338802022uL, "Music Pack: Proximity") {
            });

            AddMusicMod(new Review(1336375564uL, "Music Pack: 70s, 80s & 90s") {
            });

            AddMusicMod(new Review(1336014597uL, "Music Pack: Selected Summer") {
            });

            AddMusicMod(new Review(1335338525uL, "Music Pack: Back To The 80s - Retro/Synthwave") {
            });

            AddMusicMod(new Review(1328334744uL, "Radio Limonádový Joe 90.3 FM (CZECH)") {
                Locale = "cz",
            });

            AddMusicMod(new Review(1326517757uL, "Anno 2205 Music Pack") {
            });

            AddMusicMod(new Review(1321780524uL, "Emotional Business Tracks Vol. 1") {
            });

            AddMusicMod(new Review(1316514636uL, "Malt Shop Mayhem CSL Music Pack") {
            });

            AddMusicMod(new Review(1312768486uL, "SC2K Radio") {
            });

            AddMusicMod(new Review(1303848789uL, "Sim City 3000 Music Pack") {
            });

            AddMusicMod(new Review(1301578707uL, "Need For Speed ProStreet Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1301453082uL, "Need For Speed Carbon Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1301340848uL, "Need for Speed Most Wanted Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1301203414uL, "Need for Speed Underground 2 Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1300220114uL, "Need for Speed: Underground Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299598752uL, "The Sims Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299543983uL, "Spyro 2: Ripto's Rage Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299482532uL, "Spyro the Dragon Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299441079uL, "Fallout 4 Soundtrack ft. Lynda Carter Music Pack") {
            });

            AddMusicMod(new Review(1299341271uL, "Fallout 4 Music from Far Harbor & Nuka World Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299305365uL, "Fallout 4 Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299264263uL, "Fallout New Vegas Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1299154413uL, "Fallout 3 Soundtrack Music Pack") {
            });

            AddMusicMod(new Review(1295761551uL, "Hardstyle Radio") {
            });

            AddMusicMod(new Review(1295091678uL, "The Sims 3 Music Pack") {
            });

            AddMusicMod(new Review(1289991722uL, "Vault Archives Music Pack") {
            });

            AddMusicMod(new Review(1286392160uL, "Thievery Corporation FM") {
            });

            AddMusicMod(new Review(1251036114uL, "Variety Radio") {
            });

            AddMusicMod(new Review(1235243107uL, "Victoria II Music Pack") {
            });

            AddMusicMod(new Review(1217204348uL, "SimCity2000 (DOS) Soundtrack (CSL Music Mod)") {
            });

            AddMusicMod(new Review(1207856769uL, "Cafe Ambient Music Pack") {
            });

            AddMusicMod(new Review(1207763962uL, "SimCity SNES Music Pack") {
            });

            AddMusicMod(new Review(1175184387uL, "CSL Music Pack:More-Beats-Album") {
            });

            // kr/ko
            AddMusicMod(new Review(1169775083uL, "Bolbbalgan4 - Red Diary Page.1 (CSL Music Mod)") {
            });

            AddMusicMod(new Review(1162154876uL, "Final Fantasy VII music soundtrack") {
            });

            AddMusicMod(new Review(1156097512uL, "CSL Music Mod: Michael Jackson Greatest Hits!") {
            });

            AddMusicMod(new Review(1151983896uL, "KMVS 121.5") {
            });

            // Creative Commons license
            AddMusicMod(new Review(1136663754uL, "[CSLMM] Bean City Radio") {
                Authors = "Xial",
                Flags = ItemFlags.Streamable,
            });

            AddMusicMod(new Review(1134666165uL, "Fox River Radio") {
            });

            // no copyright sounds
            AddMusicMod(new Review(1133209057uL, "NCS House Radio") {
                Authors = "DeltaΔ",
                Flags = ItemFlags.Streamable,
            });

            AddMusicMod(new Review(1126230172uL, "CSL Music Mod - MusicPack : GNR") {
            });

            AddMusicMod(new Review(1116749094uL, "Bolbbalgan4 - Tell Me You Love Me (CSL Music Mod)") {
            });

            AddMusicMod(new Review(1116530680uL, "Empire Radio") {
            });

            AddMusicMod(new Review(1115835934uL, "Bolbbalgan4 - Red Planet (CSL Music Mod)") {
            });

            // made free by artist
            AddMusicMod(new Review(1112471996uL, "Kevin MacLeod Music pack") {
                Authors = "Growler",
                Flags = ItemFlags.Streamable,
            });

            AddMusicMod(new Review(1112338965uL, "Chillhop Music Pack") {
            });

            AddMusicMod(new Review(1111498300uL, "Soviet music pack") {
            });

            AddMusicMod(new Review(1081461443uL, "Music Pack: Sapporossive") {
            });

            AddMusicMod(new Review(1081195940uL, "CSL Music Pack: Wallbass FM") {
            });

            AddMusicMod(new Review(972594063uL, "Hotline Miami Music Pack") {
            });

            AddMusicMod(new Review(971298487uL, "GTA5 Music Pack") {
            });

            AddMusicMod(new Review(933535612uL, "JOUKINAMI FM (Music Mod)") {
                Authors = "InvocK",
                Flags = ItemFlags.LargeFileWarning, // 155 MB
            });

            AddMusicMod(new Review(927548915uL, "CSL Music Pack: NCS by PHTN Gaming") {
                Authors = "PHTN",
                Flags = ItemFlags.LargeFileWarning, // 290 MB
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Published = WorkshopDate("17 May, 2017"),
                Updated = WorkshopDate("17 May, 2017"),
            });

            AddMusicMod(new Review(887074370uL, "Music Pack: CitiesSynthPop (NEW SONGS)") {
                Authors = "Delaware: The Wolf",
                Flags = ItemFlags.LargeFileWarning, // 203 MB
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Published = WorkshopDate("19 Mar, 2017"),
                Updated = WorkshopDate("28 Oct, 2017"),
            });

            AddMusicMod(new Review(883413573uL, "CSL Music Pack: Vibrance Radio") {
                Authors = "GproKaru",
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Published = WorkshopDate("14 Mar, 2017"),
                Updated = WorkshopDate("14 Mar, 2017"),
            });

            AddMusicMod(new Review(835725734uL, "The Sims Musicpack") {
                Authors = "ThePugFarm",
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Published = WorkshopDate("6 Jan, 2017"),
                Updated = WorkshopDate("6 Jan, 2017"),
            });

            AddMusicMod(new Review(835379029uL, "SimCopter Music Pack") {
                Authors = "OOZ662",
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Published = WorkshopDate("5 Jan, 2017"),
                Updated = WorkshopDate("5 Jan, 2017"),
            });



            AddMusicMod(new Review(634216395uL, "Sim City (2013) Music Pack") {
                Authors = "I SUCK",
                Flags = ItemFlags.LargeFileWarning, // 181 MB
                LastSeen = WorkshopDate("29 Apr, 2020"),
                Locale = "*",
                Notes = new Dictionary<ulong, string>() {
                    { NOTE, "A larger version (more tracks) of this pack is available: https://steamcommunity.com/sharedfiles/filedetails/?id=1791020927" },
                },
                Published = WorkshopDate("28 Feb, 2016"),
                Updated = WorkshopDate("4 Mar, 2017"),
            });
        }
    }
}
