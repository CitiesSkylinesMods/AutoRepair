namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// CSL Music mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Helper to add musics; sets default values for a few properties.
        /// </summary>
        /// <param name="item">The item to add.</param>
        internal void AddMusic(Review item) {

            item.Affect = Factor.Audio;

            item.Catalog = "Music";

            if (item.Compatibility == null) {
                item.Compatibility = new Dictionary<ulong, Status> {
                    { 422934383u, Status.Required }, // CSL Music Mod
                };
            }

            if (item.CompatibleWith == GameVersion.DefaultRelease && item.BrokenBy == GameVersion.DefaultUntil) {
                item.CompatibleWith = GameVersion.Active;
            }

            if (!item.HasFlag(ItemFlags.SourceAvailable | ItemFlags.SourceUnavailable)) {
                item.Flags |= ItemFlags.SourceUnavailable;
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

            AddMod(new Review(422934383u, "CSL Music Mod") {
                Affect = Factor.Audio,
                Authors = "mrnotsoevil",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.SourceAvailable,
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

            AddMusic(new Review(2057429333u, "City Life (2006) Music Pack") {
                Authors = "Autokratao",
                Published = WorkshopDate("11 Apr, 2020"),
                Updated = WorkshopDate("11 Apr, 2020"),
            });

            AddMusic(new Review(2056024655u, "VAMorgans FM Radio") {
                Authors = "ViceAdmiral Morgan",
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusic(new Review(2055991875u, "Industry Giant II - CSL Music Pack") {
                Authors = "(gibberish name)",
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusic(new Review(2055714904u, "The Hu") {
                Authors = "ViceAdmiral Morgan",
                Published = WorkshopDate("10 Apr, 2020"),
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMusic(new Review(2049820944u, "Pokemon FM: A Pokemon Game Music Radio Station (Gen. IV-VI)") {
                Authors = "badplayer95",
                Published = WorkshopDate("5 Apr, 2020"),
                Updated = WorkshopDate("5 Apr, 2020"),
            });

            AddMusic(new Review(2048519799u, "The Legend Of Zelda: Spirit Tracks Music Pack [IMPROVED]") {
                Authors = "Consumedgrub2",
                Flags = ItemFlags.LargeFileWarning, // 115 MB
                Published = WorkshopDate("5 Apr, 2020"),
                Updated = WorkshopDate("7 Apr, 2020"),
            });

            AddMusic(new Review(2048091295u, "Monster Hunter World") {
                Authors = "Mr. Monday",
                Flags = ItemFlags.LargeFileWarning, // 214 MB
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusic(new Review(2048003647u, "Elite Dangerous") {
                Authors = "Mr. Monday",
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusic(new Review(2048002477u, "Advance Wars") {
                Authors = "Mr. Monday",
                Published = WorkshopDate("4 Apr, 2020"),
                Updated = WorkshopDate("4 Apr, 2020"),
            });

            AddMusic(new Review(2042929072u, "Music Pack: Cubeworld Soundtrack Music Pack") {
                Authors = "Exoidus",
                Published = WorkshopDate("1 Apr, 2020"),
                Updated = WorkshopDate("1 Apr, 2020"),
            });

            AddMusic(new Review(2040635682u, "Ocarina of Time music pack") {
                Authors = "Consumedgrub2",
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMusic(new Review(2040545346u, "Zelda Radio for CSLMusicMod") {
                Authors = "Consumedgrub2",
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMusic(new Review(2040390596u, "Animal Crossing Music Pack") {
                Authors = "Consumedgrub2",
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMusic(new Review(2039485213u, "The Legend Of Zelda: Spirit Tracks Music Pack") {
                Authors = "Consumedgrub2",
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            AddMusic(new Review(2037555938u, "Neon Genesis Evangelion Music Pack") {
                Authors = "PoeticTeacup",
                ReleasedDuring = GameVersion.SunsetHarbor,
            });

            // Soundtrack From Touhou 8 Imperishable Night (2004) created By ZUN
            AddMusic(new Review(2023013451u, "Touhou 8 Soundtrack") {
                Authors = "v.peterbilt",
            });

            AddMusic(new Review(2014962352u, "MapleStory completed music pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(2011828439u, "Midnight Club 3 DUB Edition Remix Soundtrack Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(2003548790u, "F-Zero Soundtrack SNES") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1986583172u, "Pop Shop Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1979801131u, "RPG Town Music Collection") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1977714042u, "Terence McKenna FM") {
                Authors = string.Empty,
                Flags = ItemFlags.Streamable,
                Locale = "en-us",
            });

            AddMusic(new Review(1939689497u, "music pack K-on 自用音乐") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1935185911u, "Animal Crossing GC Radio Station") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1928810625u, "Rock Japan!") {
                Authors = string.Empty,
                Locale = "ja",
            });

            AddMusic(new Review(1927877071u, "SimCity NES Music Pack") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1923113557u, "Music Pack: Transport Fever") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1907872124u, "Music Pack: Chris Sawyer's Locomotion") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1894383481u, "Cities XL XXL music") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1887810146u, "The Sims 4 Tropical Music Pack") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1887783546u, "The Sims 4 Spooky Music Pack") {
                Authors = string.Empty,
                Locale = "*",
            });

            AddMusic(new Review(1876535635u, "Chillhop Essentials - Fall 2019 - chill & lofi hiphop beats") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1867580281u, "101 FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1860387063u, "Metropolis FM - Curated Electronic Music Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1849251185u, "MapleStory Music pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1849248489u, "NEED FOR SPEED Most Wanted 2012 Music Pack") {
                Authors = string.Empty,
                Locale = "*",
            });

            // Can stream as long as song title displayed
            AddMusic(new Review(1836790997u, "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)") {
                Authors = "Asneakyninja1",
                Flags = ItemFlags.LargeFileWarning // 3.76 GB!
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Streamable,
                SourceURL = "https://www.ninety9lives.com/",
            });

            AddMusic(new Review(1836775697u, "Arcadia Bay Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1831829697u, "The Easy Listening Station") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1822078418u, "Music Pack: Chillhop Essentials - Summer 2019") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1815418533u, "Dad Feels FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1814563985u, "AfroBeat4CSL") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1794625110u, "Music Pack: JazzHop Cafe - Spring Mix 2019") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1791020927u, "SimCity (2013) + Cities of Tomorrow Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1787333298u, "Lil Peep Music pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1780166508u, "Ace Combat Music") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1774745517u, "Classics") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1771297364u, "Mr. Monday's Metal Mania Mix Vol. 11") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1769990021u, "Emotional Business Tracks Vol. 2") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1764607719u, "Mr. Monday's Metal Mania Mix Vol. 10") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1764430171u, "Shostakovich_Symphoneies_Music_Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1764130877u, "Shostakovich_String_Quartets_Music_Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1762692942u, "Mr. Monday's Metal Mania Mix Vol. 9") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1761203207u, "Mr. Monday's Metal Mania Mix Vol. 8") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1758033583u, "Soviet Music FM CSL Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1750219658u, "Rammstein FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1749984376u, "Mr. Monday's Metal Mania Mix Vol. 7") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1749674478u, "Mr. Monday's Metal Mania Mix Vol. 6") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1747687461u, "Mr. Monday's Metal Mania Vol. 5") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1746755744u, "Mr. Monday's Metal Mania Vol. 4") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1745927147u, "Music Pack - Crash FM: Burnout Paradise") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1745924501u, "Music Pack - Crash FM: Burnout Revenge") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1745921826u, "Music Pack - Crash FM - Burnout 3") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1745918041u, "Music Pack - Fallout 76 - Appalachia Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1745397514u, "Mr. Monday's Metal Mania Mix Vol. 3") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1744768948u, "Tsargrad Russian Imperial radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1744288199u, "Blast Corps") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1744275985u, "Mr. Monday's Metal Mania Mix Vol. 2") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1744060785u, "C&C Red Alert Retaliation Music") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1743852125u, "Mr. Monday's Metal Mania Mix Vol. 1") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1740593354u, "BABYMETAL Radio (Music Mod)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1737797719u, "Opeth Radio (Music Mod)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1716463067u, "Stardew Valley: CSL Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1695888523u, "Gutter Radio Station - Metal Music") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1693073075u, "Morioh Cho Radio(Jojo Radio Station)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1676346063u, "R4: Ridge Racer Type 4 OST Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1667955065u, "Starcraft Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1667954427u, "Starcraft Vol 1 Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1666843975u, "DarkAmbient_rythmical_") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1666828843u, "DarkAmbient_calming_") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1662935352u, "Your Local on The 98.8's") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1656737510u, "YIMBY Radio (Yes In My Backyard)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1608576363u, "OpenTTD Music Pack") {
                Authors = string.Empty,
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1599088128u, "Mayor Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1588118049u, "Music Pack: Free For Use Music Pack") {
                Authors = string.Empty,
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1583013403u, "Music Pack: LineageII Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1582786251u, "Music Pack: ShenzhenIO Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1581924890u, "Music Pack: Spyro Reignited Trilogy - Complete OST") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1581529605u, "Spotify - All Out 00s") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1581222201u, "Music Pack: Laura Brehm (Progressive House)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1580837351u, "Music Pack: Club MTV - Dance Anthems") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1578138249u, "Music Pack: Minecraft Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1577301964u, "Music Pack: Chillhop Essentials Fall 2018") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1574901147u, "Only Anistep for CSL MUSIC") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1574616741u, "Music Pack: The Jazz Hop Cafe - Jazzhop Christmas") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1574204018u, "Music Pack: The Jazz Hop Cafe - Lofi Christmas") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1573686513u, "Music Pack: Vladivostok FM (TBOGT)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1573683382u, "Music Pack: Electro-Choc (TBOGT)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1569009943u, "Faith Radio - Радио Вера") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1568910950u, "Zone radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1566293203u, "NIGHTFALL RADIO") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1565992217u, "Mirror's Edge Catalyst Ambience Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1564632871u, "Los Santos Rock Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1563236161u, "Non Stop Pop FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1562159034u, "Pokemon Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1559217826u, "Neon Desert Radio Earth") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1551413082u, "Sunless Radio - CSL Music Mod") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1551254449u, "Factorio Radio - CSL Music Mod") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1549204922u, "Liberty Rock Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1549159888u, "K-Rose Radio") {
                Authors = string.Empty,
            });

            // all tracks from free section on artist website
            AddMusic(new Review(1544343001u, "Evil Needle Music Pack") {
                Authors = string.Empty,
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1533463444u, "[CSLMM] Wave City Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1527318643u, "K-ZUN Touhou Jazz CSL Music Station") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1521439327u, "Need For Speed Hot Pursuit II Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1521382830u, "Need For Speed Porsche Unleashed Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1521316560u, "Need For Speed High Stakes Soundtrack Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1521193646u, "Need For Speed III Hot Pursuit Soundtrack Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1520526038u, "Need For Speed II SE Soundtrack Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1520422010u, "Need For Speed SE (1994) Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1515080990u, "The Sims 2 Music Mod") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1468593438u, "Simcity Cities of Tomorrow music pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1448884662u, "ROCK FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1412112969u, "Granado Espada Music Pack 2") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1412098032u, "Granado Espada Music Pack 3") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1411460758u, "Granado Espada Music Pack 1") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1400137014u, "Music pack: Everyone's Music") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1394707020u, "SimCity 4 Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1372895052u, "The Soviet Music Pack (Советский музыкальный пакет)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1364831709u, "CSL Music Mod - Alledion's Mega Electronic Mix") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1357175278u, "Music Pack: College Music") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1351895231u, "Little Witch Academia OST (Music pack)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1347144721u, "Music Pack: DiscoverTheVibes") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1344820938u, "Music Pack: Sonic Heroes OST") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1342303998u, "Music Pack: SoundBucket - Good Vibes") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1339803856u, "Music Pack: Monstercat - Glitch Hop") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1338802022u, "Music Pack: Proximity") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1336375564u, "Music Pack: 70s, 80s & 90s") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1336014597u, "Music Pack: Selected Summer") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1335338525u, "Music Pack: Back To The 80s - Retro/Synthwave") {
                Authors = string.Empty,
            });

            // cz
            AddMusic(new Review(1328334744u, "Radio Limonádový Joe 90.3 FM (CZECH)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1326517757u, "Anno 2205 Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1321780524u, "Emotional Business Tracks Vol. 1") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1316514636u, "Malt Shop Mayhem CSL Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1312768486u, "SC2K Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1303848789u, "Sim City 3000 Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1301578707u, "Need For Speed ProStreet Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1301453082u, "Need For Speed Carbon Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1301340848u, "Need for Speed Most Wanted Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1301203414u, "Need for Speed Underground 2 Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1300220114u, "Need for Speed: Underground Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299598752u, "The Sims Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299543983u, "Spyro 2: Ripto's Rage Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299482532u, "Spyro the Dragon Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299441079u, "Fallout 4 Soundtrack ft. Lynda Carter Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299341271u, "Fallout 4 Music from Far Harbor & Nuka World Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299305365u, "Fallout 4 Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299264263u, "Fallout New Vegas Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1299154413u, "Fallout 3 Soundtrack Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1295761551u, "Hardstyle Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1295091678u, "The Sims 3 Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1289991722u, "Vault Archives Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1286392160u, "Thievery Corporation FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1251036114u, "Variety Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1235243107u, "Victoria II Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1217204348u, "SimCity2000 (DOS) Soundtrack (CSL Music Mod)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1207856769u, "Cafe Ambient Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1207763962u, "SimCity SNES Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1175184387u, "CSL Music Pack:More-Beats-Album") {
                Authors = string.Empty,
            });

            // kr/ko
            AddMusic(new Review(1169775083u, "Bolbbalgan4 - Red Diary Page.1 (CSL Music Mod)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1162154876u, "Final Fantasy VII music soundtrack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1156097512u, "CSL Music Mod: Michael Jackson Greatest Hits!") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1151983896u, "KMVS 121.5") {
                Authors = string.Empty,
            });

            // Creative Commons license
            AddMusic(new Review(1136663754u, "[CSLMM] Bean City Radio") {
                Authors = "Xial",
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1134666165u, "Fox River Radio") {
                Authors = string.Empty,
            });

            // no copyright sounds
            AddMusic(new Review(1133209057u, "NCS House Radio") {
                Authors = "DeltaΔ",
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1126230172u, "CSL Music Mod - MusicPack : GNR") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1116749094u, "Bolbbalgan4 - Tell Me You Love Me (CSL Music Mod)") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1116530680u, "Empire Radio") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1115835934u, "Bolbbalgan4 - Red Planet (CSL Music Mod)") {
                Authors = string.Empty,
            });

            // made free by artist
            AddMusic(new Review(1112471996u, "Kevin MacLeod Music pack") {
                Authors = "Growler",
                Flags = ItemFlags.Streamable,
            });

            AddMusic(new Review(1112338965u, "Chillhop Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1111498300u, "Soviet music pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1081461443u, "Music Pack: Sapporossive") {
                Authors = string.Empty,
            });

            AddMusic(new Review(1081195940u, "CSL Music Pack: Wallbass FM") {
                Authors = string.Empty,
            });

            AddMusic(new Review(972594063u, "Hotline Miami Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(971298487u, "GTA5 Music Pack") {
                Authors = string.Empty,
            });

            AddMusic(new Review(933535612u, "JOUKINAMI FM (Music Mod)") {
                Authors = "InvocK",
                Flags = ItemFlags.LargeFileWarning, // 155 MB
            });

            AddMusic(new Review(927548915u, "CSL Music Pack: NCS by PHTN Gaming") {
                Authors = "PHTN",
                Flags = ItemFlags.LargeFileWarning, // 290 MB
                Published = WorkshopDate("17 May, 2017"),
                Updated = WorkshopDate("17 May, 2017"),
            });

        }
    }
}
