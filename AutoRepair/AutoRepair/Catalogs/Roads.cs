/*
namespace AutoRepair {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Anything that adds roads, changes road textures/colors, etc.
    /// </summary>
    public class Roads {

        private Dictionary<ulong, Item> list;

        /// <summary>
        /// Initializes a new instance of the <see cref="Roads"/> class.
        /// </summary>
        public Roads() {
            list = new Dictionary<ulong, Item>();
            Populate();
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Roads"/> class.
        /// </summary>
        ~Roads() {
            list.Clear();
        }

        /// <summary>
        /// Adds an item to the list.
        /// </summary>
        /// 
        /// <param name="workshopId">The id of the item in Steam Workshop.</param>
        /// <param name="workshopName">The name of the item in Steam Wokrshop.</param>
        public void Add(Item item) {
            item.ItemType = ItemTypes.Mod;
            list.Add(item.WorkshopId, item);
        }

        public void Populate() {

            // Removed from workshop

            Add(new Item(954034590u, "Road Anarchy V2") {
                Authors = "Eluminate [NL]",
                Affect = Factor.RoadsUnited
                              | Factor.Zoning
                              | Factor.FineRoadTool
                              | Factor.FineRoadAnarchy,
                ContinuationOf = 418556522u, // Road Anarchy
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceAvailable,
                IncompatibleMods = new List<ulong>() { // will be more
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 954034590u }, // Road Anarchy V2
                    { 802066100u }, // Fine Road Anarchy
                    { 553184329u }, // Sharp Junction Angles
                    { 433567230u }, // Advanced Road Anarchy
                    { 418556522u }, // Road Anarchy
                },
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
                SourceURL = "https://github.com/LucasMateijsen/City-Skylines-Roads",
            });

            Add(new Item(553184329u, "Sharp Junction Angles") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Affect = Factor.RoadsUnited
                              | Factor.Zoning
                              | Factor.FineRoadAnarchy
                              | Factor.FineRoadTool,
                IncompatibleMods = new List<ulong>() { // will be more
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 954034590u }, // Road Anarchy V2
                    { 802066100u }, // Fine Road Anarchy
                    { 553184329u }, // Sharp Junction Angles
                    { 433567230u }, // Advanced Road Anarchy
                    { 418556522u }, // Road Anarchy
                },
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            Add(new Item(478820060u, "Network Extensions Project") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable, // it was replaced with TAM source, then later NExt2 source
                Affect = Factor.RoadsUnited
                              | Factor.Zoning
                              | Factor.FineRoadAnarchy
                              | Factor.FineRoadTool,
                IncompatibleMods = new List<ulong>() {
                    { 625608461u }, // Adaptive Prop Visibility Distance
                },
                ReplaceWith = 812125426u, // Network Extensions 2
            });

            Add(new Item(433567230u, "Advanced Road Anarchy") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Affect = Factor.RoadsUnited
                              | Factor.Zoning
                              | Factor.FineRoadTool
                              | Factor.FineRoadAnarchy,
                IncompatibleMods = new List<ulong>() { // will be more
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 954034590u }, // Road Anarchy V2
                    { 802066100u }, // Fine Road Anarchy
                    { 553184329u }, // Sharp Junction Angles
                    { 433567230u }, // Advanced Road Anarchy
                    { 418556522u }, // Road Anarchy
                },
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });

            Add(new Item(413678178u, "Fine Road Heights") {
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.GameBreaking
                      | ItemFlags.NoWorkshop
                      | ItemFlags.Obsolete
                      | ItemFlags.SourceUnavailable,
                Affect = Factor.RoadsUnited
                              | Factor.Zoning
                              | Factor.FineRoadTool
                              | Factor.FineRoadAnarchy,
                IncompatibleMods = new List<ulong>() { // will be more
                    { 1844440354u }, // Fine Road Anarchy 2
                    { 954034590u }, // Road Anarchy V2
                    { 802066100u }, // Fine Road Anarchy
                    { 553184329u }, // Sharp Junction Angles
                    { 433567230u }, // Advanced Road Anarchy
                    { 418556522u }, // Road Anarchy
                },
                ReplaceWith = 1844440354u, // Fine Road Anarchy 2
            });
        }
    }
}
*/