/*
namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Traffic Light mods / packs:
    /// * Pack = changes the traffic light props (eg. American or Japanese traffic light props).
    /// * Mod = anything else relating to traffic lights (eg. toggle/remove traffic lights).
    /// </summary>
    public partial class TrafficLight {
        private static TrafficLight instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="TrafficLight"/> class.
        /// </summary>
        public static TrafficLight Instance => instance ?? (instance = new TrafficLight());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Full list of incompatible mods applicable to <see cref="Factor.TrafficLights"/>.
        ///
        /// TODO: this is fucking stupid, centralise and automate it.
        /// </summary>
        private readonly List<ulong> incompatibles = new List<ulong>() {
            { 1812157090u }, // [NL] Dutch Traffic Lights
            { 1550720600u }, // New American Traffic Lights - NYC/NJ Style
            { 1548117573u }, // New American Traffic Lights - Grey Style
            { 1541164608u }, // New American Traffic Lights - Vanilla Side
            { 1535107168u }, // New American Traffic Lights (395 MB)
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TrafficLight"/> class.
        /// </summary>
        public TrafficLight() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddPacksToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="TrafficLight"/> class.
        /// </summary>
        ~TrafficLight() {
            list.Clear();
            list = null;
        }

        private Item AddIncompatibles(Item item, List<ulong> incompatibles) {
            // add all incompatibles to start with
            if (item.IncompatibleMods == null) {
                item.IncompatibleMods = new List<ulong>(incompatibles);
            } else {
                item.IncompatibleMods.AddRange(incompatibles);
            }

            // remove self
            if (item.IncompatibleMods.Contains(item.WorkshopId)) {
                item.IncompatibleMods.Remove(item.WorkshopId);
            }

            // remove compatible mods
            if (item.CompatibleWith != null) {
                foreach (ulong mod in item.CompatibleWith) {
                    if (item.IncompatibleMods.Contains(mod)) {
                        item.IncompatibleMods.Remove(mod);
                    }
                }
            }

            // remove required mods
            if (item.RequiredMods != null) {
                foreach (ulong mod in item.RequiredMods) {
                    if (item.IncompatibleMods.Contains(mod)) {
                        item.IncompatibleMods.Remove(mod);
                    }
                }
            }

            // remove suggested mods
            if (item.SuggestedMods != null) {
                foreach (ulong mod in item.SuggestedMods) {
                    if (item.IncompatibleMods.Contains(mod)) {
                        item.IncompatibleMods.Remove(mod);
                    }
                }
            }

            return item;
        }

        /// <summary>
        /// Add CSM mod to the list.
        /// </summary>
        /// 
        /// <param name="item">The item to add to the list.</param>
        private Item AddMod(Item item) {
            item.Catalog = "TrafficLight";
            item.ItemType = ItemTypes.Mod;
            item.Affect |= Factor.TrafficLights;

            item = AddIncompatibles(item, incompatibles);

            list.Add(item.WorkshopId, item);

            return item;
        }

        private Item AddPack(ulong workshopId, string workshopName) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "TrafficLight",
                Flags = ItemFlags.MinorBugs // all of them are a bit glitchy
                      | ItemFlags.SourceUnavailable,
                Affect = Factor.TrafficLights,
                // todo: incompatible with mods that remove/hide traffic lights
            };

            item = AddIncompatibles(item, incompatibles);

            list.Add(workshopId, item);

            return item;
        }
    }
}
*/