using AutoRepair.Descriptors;
using AutoRepair.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair {
    /// <summary>
    /// Radio stations for CSL Music Mod
    ///
    /// TODO: Add copyright flag to item descriptor.
    /// </summary>
    public class Musics {

        /// <summary>
        /// All radio stations require the CSL Music mod.
        /// </summary>
        private const ulong _cslMusicMod = 422934383u;

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Musics"/> class.
        /// </summary>
        public Musics() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Musics"/> class.
        /// </summary>
        ~Musics() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        /// <param name="copyrighted">Whether the tracks are copyrighted (defaults to <c>true</c>).</param>
        public void AddStation(ulong workshopId, string workshopName, bool copyrighted = true) {
            list.Add(workshopId, new Item(workshopId, workshopName) {
                Flags = ItemFlags.SourceUnavailable,
                ItemType = ItemTypes.Radio,
                RequiredMods = new List<ulong>() {
                    { _cslMusicMod },
                },
            });
        }

        /// <summary>
        /// Populates the list with items.
        /// </summary>
        public void Populate() {
            AddStation(2014962352u, "MapleStory completed music pack");
            AddStation(2011828439u, "Midnight Club 3 DUB Edition Remix Soundtrack Pack");
            AddStation(2003548790u, "F-Zero Soundtrack SNES");
            AddStation(1986583172u, "Pop Shop Radio");
            AddStation(1979801131u, "RPG Town Music Collection");
            AddStation(1977714042u, "Terence McKenna FM", true);
            AddStation(1939689497u, "music pack K-on 自用音乐");
            AddStation(1935185911u, "Animal Crossing GC Radio Station");
            AddStation(1928810625u, "Rock Japan!");
            AddStation(1927877071u, "SimCity NES Music Pack");
            AddStation(1923113557u, "Music Pack: Transport Fever");
            AddStation(1907872124u, "Music Pack: Chris Sawyer's Locomotion");
            AddStation(1894383481u, "Cities XL XXL music");
            AddStation(1887810146u, "The Sims 4 Tropical Music Pack");
            AddStation(1887783546u, "The Sims 4 Spooky Music Pack");
            AddStation(1876535635u, "Chillhop Essentials - Fall 2019 - chill & lofi hiphop beats");
            AddStation(1867580281u, "101 FM");
            AddStation(1860387063u, "Metropolis FM - Curated Electronic Music Radio");
            AddStation(1849251185u, "MapleStory Music pack");
            AddStation(1849248489u, "NEED FOR SPEED Most Wanted 2012 Music Pack");
            AddStation(1836790997u, "Ninety9Lives FM (A Custom CSL Music Station with ‭296 songs!‬)", false);
            AddStation(1836775697u, "Arcadia Bay Radio");
            AddStation(1831829697u, "The Easy Listening Station");
            AddStation(1822078418u, "Music Pack: Chillhop Essentials - Summer 2019");
            AddStation(1815418533u, "Dad Feels FM");
            AddStation(1814563985u, "AfroBeat4CSL");
            AddStation(1794625110u, "Music Pack: JazzHop Cafe - Spring Mix 2019");
            AddStation(1791020927u, "SimCity (2013) + Cities of Tomorrow Music Pack");
            AddStation(1787333298u, "Lil Peep Music pack");
            AddStation(1780166508u, "Ace Combat Music");
            AddStation(1774745517u, "Classics");
            AddStation(1771297364u, "Mr. Monday's Metal Mania Mix Vol. 11");
            AddStation(1769990021u, "Emotional Business Tracks Vol. 2");
            AddStation(1764607719u, "Mr. Monday's Metal Mania Mix Vol. 10");
            AddStation(1764430171u, "Shostakovich_Symphoneies_Music_Pack");
            AddStation(1764130877u, "Shostakovich_String_Quartets_Music_Pack");
            AddStation(1762692942u, "Mr. Monday's Metal Mania Mix Vol. 9");
            AddStation(1761203207u, "Mr. Monday's Metal Mania Mix Vol. 8");
            AddStation(1758033583u, "Soviet Music FM CSL Radio");
            AddStation(1750219658u, "Rammstein FM");
            AddStation(1749984376u, "Mr. Monday's Metal Mania Mix Vol. 7");
            AddStation(1749674478u, "Mr. Monday's Metal Mania Mix Vol. 6");
            AddStation(1747687461u, "Mr. Monday's Metal Mania Vol. 5");
            AddStation(1746755744u, "Mr. Monday's Metal Mania Vol. 4");
            AddStation(1745927147u, "Music Pack - Crash FM: Burnout Paradise");
            AddStation(1745924501u, "Music Pack - Crash FM: Burnout Revenge");
            AddStation(1745921826u, "Music Pack - Crash FM - Burnout 3");
            AddStation(1745918041u, "Music Pack - Fallout 76 - Appalachia Radio");
            AddStation(1745397514u, "Mr. Monday's Metal Mania Mix Vol. 3");
            AddStation(1744768948u, "Tsargrad Russian Imperial radio");
            AddStation(1744288199u, "Blast Corps");
            AddStation(1744275985u, "Mr. Monday's Metal Mania Mix Vol. 2");
            AddStation(1744060785u, "C&C Red Alert Retaliation Music");
            AddStation(1743852125u, "Mr. Monday's Metal Mania Mix Vol. 1");
            AddStation(1740593354u, "BABYMETAL Radio (Music Mod)");
            AddStation(1737797719u, "Opeth Radio (Music Mod)");
            AddStation(1716463067u, "Stardew Valley: CSL Music Pack");
            AddStation(1695888523u, "Gutter Radio Station - Metal Music");
            AddStation(1693073075u, "Morioh Cho Radio(Jojo Radio Station)");
            AddStation(1676346063u, "R4: Ridge Racer Type 4 OST Music Pack");
            AddStation(1667955065u, "Starcraft Music Pack");
            AddStation(1667954427u, "Starcraft Vol 1 Music Pack");
            AddStation(1666843975u, "DarkAmbient_rythmical_");
            AddStation(1666828843u, "DarkAmbient_calming_");
            AddStation(1662935352u, "Your Local on The 98.8's");
            AddStation(1656737510u, "YIMBY Radio (Yes In My Backyard)");
            AddStation(1608576363u, "OpenTTD Music Pack", false);
        }
    }
}
