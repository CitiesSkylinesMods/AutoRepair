namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// CSL Music mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add music packs to the list.
        ///
        /// TODO:
        /// * Add large file warnings where necessary.
        /// * Link to artist websites where known.
        /// * Add workshop author names.
        /// * Add locales where applicable.
        /// </summary>
        private void MusicCatalog() {
            string catalog = "Music";

            Dictionary<ulong, Status> cslMusicMod = new Dictionary<ulong, Status> {
                { 422934383u, Status.Required }, // CSL Music Mod
            };

            /*
            # ███████ ████████  █████  ████████ ██  ██████  ███    ██ ███████
            # ██         ██    ██   ██    ██    ██ ██    ██ ████   ██ ██
            # ███████    ██    ███████    ██    ██ ██    ██ ██ ██  ██ ███████
            #      ██    ██    ██   ██    ██    ██ ██    ██ ██  ██ ██      ██
            # ███████    ██    ██   ██    ██    ██  ██████  ██   ████ ███████
            */

            // Soundtrack From Touhou 8 Imperishable Night (2004) created By ZUN
            AddMod(new Item(2023013451u, "Touhou 8 Soundtrack") {
                Affect = Factor.Other,
                Authors = "v.peterbilt",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(2014962352u, "MapleStory completed music pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(2011828439u, "Midnight Club 3 DUB Edition Remix Soundtrack Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(2003548790u, "F-Zero Soundtrack SNES") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1986583172u, "Pop Shop Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1979801131u, "RPG Town Music Collection") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1977714042u, "Terence McKenna FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
                Locale = "en-us",
            });

            AddMod(new Item(1939689497u, "music pack K-on 自用音乐") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1935185911u, "Animal Crossing GC Radio Station") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1928810625u, "Rock Japan!") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "ja",
            });

            AddMod(new Item(1927877071u, "SimCity NES Music Pack") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1923113557u, "Music Pack: Transport Fever") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1907872124u, "Music Pack: Chris Sawyer's Locomotion") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1894383481u, "Cities XL XXL music") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1887810146u, "The Sims 4 Tropical Music Pack") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1887783546u, "The Sims 4 Spooky Music Pack") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            AddMod(new Item(1876535635u, "Chillhop Essentials - Fall 2019 - chill & lofi hiphop beats") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1867580281u, "101 FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1860387063u, "Metropolis FM - Curated Electronic Music Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1849251185u, "MapleStory Music pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1849248489u, "NEED FOR SPEED Most Wanted 2012 Music Pack") {
                Authors = "",
                Catalog = catalog,
                Affect = Factor.Other,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
                Locale = "*",
            });

            // Can stream as long as song title displayed
            AddMod(new Item(1836790997u, "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)") {
                Affect = Factor.Other,
                Authors = "Asneakyninja1",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.LargeFileWarning // 3.76 GB!
                      | ItemFlags.SourceAvailable
                      | ItemFlags.Streamable,
                SourceURL = "https://www.ninety9lives.com/",
            });

            AddMod(new Item(1836775697u, "Arcadia Bay Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1831829697u, "The Easy Listening Station") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1822078418u, "Music Pack: Chillhop Essentials - Summer 2019") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1815418533u, "Dad Feels FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1814563985u, "AfroBeat4CSL") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1794625110u, "Music Pack: JazzHop Cafe - Spring Mix 2019") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1791020927u, "SimCity (2013) + Cities of Tomorrow Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1787333298u, "Lil Peep Music pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1780166508u, "Ace Combat Music") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1774745517u, "Classics") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1771297364u, "Mr. Monday's Metal Mania Mix Vol. 11") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1769990021u, "Emotional Business Tracks Vol. 2") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1764607719u, "Mr. Monday's Metal Mania Mix Vol. 10") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1764430171u, "Shostakovich_Symphoneies_Music_Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1764130877u, "Shostakovich_String_Quartets_Music_Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1762692942u, "Mr. Monday's Metal Mania Mix Vol. 9") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1761203207u, "Mr. Monday's Metal Mania Mix Vol. 8") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1758033583u, "Soviet Music FM CSL Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1750219658u, "Rammstein FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1749984376u, "Mr. Monday's Metal Mania Mix Vol. 7") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1749674478u, "Mr. Monday's Metal Mania Mix Vol. 6") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1747687461u, "Mr. Monday's Metal Mania Vol. 5") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1746755744u, "Mr. Monday's Metal Mania Vol. 4") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1745927147u, "Music Pack - Crash FM: Burnout Paradise") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1745924501u, "Music Pack - Crash FM: Burnout Revenge") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1745921826u, "Music Pack - Crash FM - Burnout 3") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1745918041u, "Music Pack - Fallout 76 - Appalachia Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1745397514u, "Mr. Monday's Metal Mania Mix Vol. 3") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1744768948u, "Tsargrad Russian Imperial radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1744288199u, "Blast Corps") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1744275985u, "Mr. Monday's Metal Mania Mix Vol. 2") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1744060785u, "C&C Red Alert Retaliation Music") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1743852125u, "Mr. Monday's Metal Mania Mix Vol. 1") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1740593354u, "BABYMETAL Radio (Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1737797719u, "Opeth Radio (Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1716463067u, "Stardew Valley: CSL Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1695888523u, "Gutter Radio Station - Metal Music") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1693073075u, "Morioh Cho Radio(Jojo Radio Station)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1676346063u, "R4: Ridge Racer Type 4 OST Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1667955065u, "Starcraft Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1667954427u, "Starcraft Vol 1 Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1666843975u, "DarkAmbient_rythmical_") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1666828843u, "DarkAmbient_calming_") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1662935352u, "Your Local on The 98.8's") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1656737510u, "YIMBY Radio (Yes In My Backyard)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1608576363u, "OpenTTD Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1599088128u, "Mayor Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1588118049u, "Music Pack: Free For Use Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1583013403u, "Music Pack: LineageII Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1582786251u, "Music Pack: ShenzhenIO Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1581924890u, "Music Pack: Spyro Reignited Trilogy - Complete OST") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1581529605u, "Spotify - All Out 00s") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1581222201u, "Music Pack: Laura Brehm (Progressive House)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1580837351u, "Music Pack: Club MTV - Dance Anthems") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1578138249u, "Music Pack: Minecraft Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1577301964u, "Music Pack: Chillhop Essentials Fall 2018") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1574901147u, "Only Anistep for CSL MUSIC") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1574616741u, "Music Pack: The Jazz Hop Cafe - Jazzhop Christmas") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1574204018u, "Music Pack: The Jazz Hop Cafe - Lofi Christmas") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1573686513u, "Music Pack: Vladivostok FM (TBOGT)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1573683382u, "Music Pack: Electro-Choc (TBOGT)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1569009943u, "Faith Radio - Радио Вера") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1568910950u, "Zone radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1566293203u, "NIGHTFALL RADIO") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1565992217u, "Mirror's Edge Catalyst Ambience Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1564632871u, "Los Santos Rock Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1563236161u, "Non Stop Pop FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1562159034u, "Pokemon Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1559217826u, "Neon Desert Radio Earth") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1551413082u, "Sunless Radio - CSL Music Mod") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1551254449u, "Factorio Radio - CSL Music Mod") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1549204922u, "Liberty Rock Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1549159888u, "K-Rose Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // all tracks from free section on artist website
            AddMod(new Item(1544343001u, "Evil Needle Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1533463444u, "[CSLMM] Wave City Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1527318643u, "K-ZUN Touhou Jazz CSL Music Station") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1521439327u, "Need For Speed Hot Pursuit II Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1521382830u, "Need For Speed Porsche Unleashed Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1521316560u, "Need For Speed High Stakes Soundtrack Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1521193646u, "Need For Speed III Hot Pursuit Soundtrack Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1520526038u, "Need For Speed II SE Soundtrack Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1520422010u, "Need For Speed SE (1994) Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1515080990u, "The Sims 2 Music Mod") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1468593438u, "Simcity Cities of Tomorrow music pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1448884662u, "ROCK FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1412112969u, "Granado Espada Music Pack 2") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1412098032u, "Granado Espada Music Pack 3") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1411460758u, "Granado Espada Music Pack 1") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1400137014u, "Music pack: Everyone's Music") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1394707020u, "SimCity 4 Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1372895052u, "The Soviet Music Pack (Советский музыкальный пакет)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1364831709u, "CSL Music Mod - Alledion's Mega Electronic Mix") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1357175278u, "Music Pack: College Music") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1351895231u, "Little Witch Academia OST (Music pack)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1347144721u, "Music Pack: DiscoverTheVibes") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1344820938u, "Music Pack: Sonic Heroes OST") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1342303998u, "Music Pack: SoundBucket - Good Vibes") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1339803856u, "Music Pack: Monstercat - Glitch Hop") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1338802022u, "Music Pack: Proximity") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1336375564u, "Music Pack: 70s, 80s & 90s") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1336014597u, "Music Pack: Selected Summer") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1335338525u, "Music Pack: Back To The 80s - Retro/Synthwave") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // cz
            AddMod(new Item(1328334744u, "Radio Limonádový Joe 90.3 FM (CZECH)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1326517757u, "Anno 2205 Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1321780524u, "Emotional Business Tracks Vol. 1") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1316514636u, "Malt Shop Mayhem CSL Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1312768486u, "SC2K Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1303848789u, "Sim City 3000 Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1301578707u, "Need For Speed ProStreet Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1301453082u, "Need For Speed Carbon Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1301340848u, "Need for Speed Most Wanted Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1301203414u, "Need for Speed Underground 2 Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1300220114u, "Need for Speed: Underground Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299598752u, "The Sims Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299543983u, "Spyro 2: Ripto's Rage Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299482532u, "Spyro the Dragon Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299441079u, "Fallout 4 Soundtrack ft. Lynda Carter Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299341271u, "Fallout 4 Music from Far Harbor & Nuka World Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299305365u, "Fallout 4 Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299264263u, "Fallout New Vegas Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1299154413u, "Fallout 3 Soundtrack Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1295761551u, "Hardstyle Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1295091678u, "The Sims 3 Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1289991722u, "Vault Archives Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1286392160u, "Thievery Corporation FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1251036114u, "Variety Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1235243107u, "Victoria II Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1217204348u, "SimCity2000 (DOS) Soundtrack (CSL Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1207856769u, "Cafe Ambient Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1207763962u, "SimCity SNES Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1175184387u, "CSL Music Pack:More-Beats-Album") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // kr/ko
            AddMod(new Item(1169775083u, "Bolbbalgan4 - Red Diary Page.1 (CSL Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1162154876u, "Final Fantasy VII music soundtrack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1156097512u, "CSL Music Mod: Michael Jackson Greatest Hits!") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1151983896u, "KMVS 121.5") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // Creative Commons license
            AddMod(new Item(1136663754u, "[CSLMM] Bean City Radio") {
                Affect = Factor.Other,
                Authors = "Xial",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1134666165u, "Fox River Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // no copyright sounds
            AddMod(new Item(1133209057u, "NCS House Radio") {
                Affect = Factor.Other,
                Authors = "DeltaΔ",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1126230172u, "CSL Music Mod - MusicPack : GNR") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1116749094u, "Bolbbalgan4 - Tell Me You Love Me (CSL Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1116530680u, "Empire Radio") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1115835934u, "Bolbbalgan4 - Red Planet (CSL Music Mod)") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            // made free by artist
            AddMod(new Item(1112471996u, "Kevin MacLeod Music pack") {
                Affect = Factor.Other,
                Authors = "Growler",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Streamable,
            });

            AddMod(new Item(1112338965u, "Chillhop Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1111498300u, "Soviet music pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1081461443u, "Music Pack: Sapporossive") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1081195940u, "CSL Music Pack: Wallbass FM") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(972594063u, "Hotline Miami Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(971298487u, "GTA5 Music Pack") {
                Affect = Factor.Other,
                Authors = "",
                Catalog = catalog,
                Compatibility = cslMusicMod,
                Flags = ItemFlags.SourceUnavailable,
            });

        }
    }
}
