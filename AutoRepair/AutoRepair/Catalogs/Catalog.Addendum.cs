namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System;

    /// <summary>
    /// After a game update, this class is used to temporary adjust the catalog
    /// to indicate which items are confirmed compatible or broken, etc.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Specify the version number of the update.
        /// </summary>
        private static readonly Version LatestUpdate = GameVersion.SunsetHarbor;

        /// <summary>
        /// Declare the broken or updated mods.
        /// </summary>
        private void CatalogAddendum() {
            if (GameVersion.Active < LatestUpdate) {
                //return;
            }

            //Log.Info($"Game update {LatestUpdate.ToString()} has affected following items:");

            Broken(576327847u, "81 Tiles (Fixed for 1.2+)"); // very broken
            Broken(1844440354u, "Fine Road Anarchy 2"); // network mouse detection
            Broken(928128676u, "Improved Public Transport 2"); // transport not working
            Broken(1312735149u, "Klyte Commons");
            Broken(667342976u, "Loading Screen Mod"); // doesn't load DLC content
            Broken(833779378u, "Loading Screen Mod [Test]"); // doesn't load DLC content
            Broken(650436109u, "Quay Anarchy");
            Broken(1420955187u, "Real Time");
            Broken(934994075u, "Service Vehicle Selector 2"); // stack overflow
            Broken(465318661u, "Toggleable Whiteness"); // makes fishing paths invisible
            Broken(583429740u, "Traffic Manager: President Edition [STABLE]");
            Broken(1312767991u, "Transport Lines Manager 11.1.2");
            Broken(912329352u, "Building Anarchy"); // breaks placement mode
            Broken(512314255u, "More Network Stuff"); // breaks fishing route bulldoze

            // will be updated quickly after update
            Broken(1637663252u, "TM:PE V11 STABLE");
            Broken(1806963141u, "TM:PE v11.1.2 LABS");
        }

        /// <summary>
        /// Mark an item as compatible with latest version.
        ///
        /// If the item is not yet in catalog, it will be added, otherwise the existing item will be updated.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        internal void Compatible(ulong workshopId, string workshopName) {
            //Log.Info($"- Confirmed compatible: {workshopId} '{workshopName}'");

            if (Items.TryGetValue(workshopId, out Item item)) {
                item.BrokenBy = GameVersion.DefaultUntil;
                item.CompatibleWith = LatestUpdate;
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    Catalog = "Addendum",
                    CompatibleWith = LatestUpdate,
                    Flags = ItemFlags.Unrecognised | ItemFlags.SourceUnavailable,
                    ItemType = ItemTypes.Mod,
                });
            }
        }

        /// <summary>
        /// Mark an item as NOT compatible with latest version.
        ///
        /// If the item is not yet in catalog, it will be added, otherwise the existing item will be updated.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Workshop.</param>
        internal void Broken(ulong workshopId, string workshopName) {
            //Log.Info($"- Broken: {workshopId} '{workshopName}'");

            if (Items.TryGetValue(workshopId, out Item item)) {
                item.BrokenBy = LatestUpdate;
                if (item.CompatibleWith >= LatestUpdate) {
                    item.CompatibleWith = GameVersion.DefaultRelease;
                }
            } else {
                AddMod(new Item(workshopId, workshopName) {
                    Affect = Factor.Other,
                    Authors = "(not specified)",
                    BrokenBy = LatestUpdate,
                    Catalog = "Addendum",
                    Flags = ItemFlags.Unrecognised | ItemFlags.SourceUnavailable,
                    ItemType = ItemTypes.Mod,
                });
            }
        }
    }
}
