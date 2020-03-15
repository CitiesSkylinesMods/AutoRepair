namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Traffic Light mods / packs:
    /// * Pack = changes the traffic light props (eg. American or Japanese traffic light props).
    /// * Mod = anything else relating to traffic lights (eg. toggle/remove traffic lights).
    /// </summary>
    public partial class AnarchyTool {
        private static AnarchyTool instance;

        /// <summary>
        /// Gets (creating if necessary) the instance of <see cref="TrafficLight"/> class.
        /// </summary>
        public static AnarchyTool Instance => instance ?? (instance = new AnarchyTool());

        /// <summary>
        /// The catalog of items.
        /// </summary>
        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Full list of incompatible mods applicable to ########## there are two conflict groups.
        ///
        /// TODO: this is fucking stupid, centralise and automate it.
        /// </summary>
        private readonly List<ulong> incompatibles = new List<ulong>() {
            // todo
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AnarchyTool"/> class.
        /// </summary>
        public AnarchyTool() {
            list = new Dictionary<ulong, Item>();
            AddModsToList();
            AddObsoleteToList();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AnarchyTool"/> class.
        /// </summary>
        ~AnarchyTool() {
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
            item.Catalog = "AnarchyTool";
            item.ItemType = ItemTypes.Mod;
            item.ConflictsWith |= ConflictGroups.TrafficLights;

            item = AddIncompatibles(item, incompatibles);

            list.Add(item.WorkshopId, item);

            return item;
        }

        private Item AddPack(ulong workshopId, string workshopName) {
            Item item = new Item(workshopId, workshopName) {
                Catalog = "AnarchyTool",
                Flags = ItemFlags.MinorBugs // all of them are a bit glitchy
                      | ItemFlags.SourceUnavailable,
                ConflictsWith = ConflictGroups.TrafficLights,
                // todo: incompatible with mods that remove/hide traffic lights
            };

            item = AddIncompatibles(item, incompatibles);

            list.Add(workshopId, item);

            return item;
        }
    }
}