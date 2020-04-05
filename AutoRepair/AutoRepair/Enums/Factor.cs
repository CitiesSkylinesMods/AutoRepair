namespace AutoRepair.Enums {
    using AutoRepair.Descriptors;
    using System;

    /// <summary>
    /// These flags are used to define which factors an item affects or is affected by.
    ///
    /// Items which affect or are affected by the same factors are potentially incompatible.
    /// </summary>
    [Flags]
    public enum Factor : ulong {

        /// <summary>
        /// Default; Probably a mistake.
        /// </summary>
        None = 0UL,

        /// <summary>
        /// Anything not covered by the other factors.
        /// </summary>
        Other = 1UL,

        /// <summary>
        /// Enables achievements while mods are enabled.
        /// </summary>
        Achievements = 1UL << 1,

        /// <summary>
        /// Citizen aging.
        /// </summary>
        Aging = 1UL << 3,

        /// <summary>
        /// Audio effects, volume, etc.
        /// </summary>
        Audio = 1UL << 4,

        /// <summary>
        /// Boredom caused by commute wait time (eg. time spent on travelling or waiting for transport).
        /// </summary>
        Boredom = 1UL << 5,

        /// <summary>
        /// Service or transport budgets.
        /// </summary>
        Budget = 1UL << 6,

        /// <summary>
        /// Human capacity (residents or workers) of buildings.
        /// </summary>
        BuildingCapacity = 1UL << 7,

        /// <summary>
        /// Building info panel.
        /// </summary>
        BuildingInfo = 1UL << 8,

        /// <summary>
        /// Building level.
        /// </summary>
        BuildingLevel = 1UL << 9,

        /// <summary>
        /// Auto bulldoze mods.
        /// </summary>
        Bulldoze = 1UL << 10,

        /// <summary>
        /// Camera related (controls, first person, alternate camera, etc).
        /// </summary>
        Camera = 1UL << 11,

        /// <summary>
        /// Construction cost, time (for buildings, networks, etc).
        /// </summary>
        Construction = 1UL << 12,

        /// <summary>
        /// Consumption rates. This includes stuff like water, garbage, electricity, goods, etc.
        /// </summary>
        Consumption = 1UL << 13,

        /// <summary>
        /// Customise or convert a value or asset.
        /// </summary>
        Customize = 1UL << 13,

        /// <summary>
        /// Mods which modify RCI demand.
        /// </summary>
        DemandRCI = 1UL << 14,

        /// <summary>
        /// Mods which alter vehicle despawning.
        /// </summary>
        Despawn = 1UL << 15,

        /// <summary>
        /// Mods which alter education balance.
        /// </summary>
        Education = 1UL << 16,

        /// <summary>
        /// Mods which alter employment / jobs.
        /// </summary>
        Employment = 1UL << 17,

        /// <summary>
        /// Auto-emptying mods (for cemeteries, snow dumps, landfill, etc).
        /// </summary>
        Emptying = 1UL << 18,

        /// <summary>
        /// Entertainment value and/or range.
        /// </summary>
        Entertainment = 1UL << 19,

        /// <summary>
        /// Sky, weather, disasters, etc.
        /// </summary>
        Environment = 1UL << 20,

        /// <summary>
        /// Disasters (storms, tsunami, earthquake, etc).
        /// </summary>
        Disasters = 1UL << 22,

        /// <summary>
        /// Happiness of cims (eg. what alters it, or what it alters).
        /// </summary>
        Happiness = 1UL << 23,

        /// <summary>
        /// Health (healthcare, deathcare, death rate, recovery, etc).
        /// </summary>
        Health = 1UL << 24,

        /// <summary>
        /// Hides or removes stuff.
        /// </summary>
        HideRemove = 1UL << 25,

        /// <summary>
        /// Mods which alter number and/or demographics of new residents.
        /// </summary>
        Immigrants = 1UL << 26,

        /// <summary>
        /// Land value (either directly or indirectly).
        /// </summary>
        LandValue = 1UL << 27,

        /// <summary>
        /// Loading/saving/exit process (app startup, loading screen, autosave, quit to desktop).
        /// </summary>
        LoadSaveExit = 1UL << 28,

        /// <summary>
        /// Maintenance cost of buildings, roads, etc.
        /// </summary>
        MaintenanceCost = 1UL << 29,

        /// <summary>
        /// Conflicts with map theme mods.
        /// </summary>
        MapThemes = 1UL << 30,

        /// <summary>
        /// Mods which unlock milestones, etc.
        /// </summary>
        Unlockers = 1UL << 31,

        /// <summary>
        /// Any mod that automatically adds numbered rectangles when starting new city.
        /// </summary>
        Money = 1UL << 32,

        /// <summary>
        /// Conflicts with Cities Skylines Multiplayer (CSM) mod
        /// </summary>
        Multiplayer = 1UL << 33,

        /// <summary>
        /// Changes or affects names of roads, buildings, districts, cims, vehicles, etc.
        /// </summary>
        Naming = 1UL << 2,

        /// <summary>
        /// Mods which alter outside connections (max connections, network types, etc).
        /// </summary>
        OutsideConnection = 1UL << 34,

        /// <summary>
        /// Pathfinder (vehicle/cim routing).
        /// </summary>
        Pathfinder = 1UL << 35,

        /// <summary>
        /// Placement/movement of buildings, roads, etc.
        /// </summary>
        PlaceAndMove = 1UL << 36,

        /// <summary>
        /// Mods which affect or are affected by pollution (<seealso cref="Production"/>).
        /// </summary>
        Pollution = 1UL << 37,

        /// <summary>
        /// Production of buildings. This includes stuff like water, electricity, goods, garbage, etc.
        /// </summary>
        Production = 1UL << 38,

        /// <summary>
        /// Props of any kind (including decals).
        /// </summary>
        Props = 1UL << 39,

        /// <summary>
        /// Graphics rendering (LUT, effects, LOD quality, etc).
        /// </summary>
        Rendering = 1UL << 40,

        /// <summary>
        /// Revenue (earnings) from tax, transport fees, etc.
        /// </summary>
        Revenue = 1UL << 41,

        /// <summary>
        /// Road markings including arrows, crosswalks and even the main texture.
        /// </summary>
        RoadMarkings = 1UL << 42,

        /// <summary>
        /// Affects services (including buildings, vehicles, coverage, etc).
        /// </summary>
        Service = 1UL << 43,

        /// <summary>
        /// Storage capacity of buildings or vehicles (including restocking).
        /// </summary>
        StorageCapacity = 1UL << 44,

        /// <summary>
        /// Textures and colorization.
        /// </summary>
        Textures = 1UL << 45,

        /// <summary>
        /// Conflicts with tile unlock mods (25 Tiles, 81 Tiles, Purchase It, etc).
        /// </summary>
        TileLimit = 1UL << 46,

        /// <summary>
        /// Mods which alter the flow of time (eg. changing date or hour).
        /// </summary>
        Timeflow = 1UL << 47,

        /// <summary>
        /// Mods which alter the rate at which time progresses.
        /// </summary>
        Timerate = 1UL << 48,

        /// <summary>
        /// Toolbar UI region near bottom of screen (build bars, button bar, info bar, etc).
        /// </summary>
        Toolbar = 1UL << 49,

        /// <summary>
        /// Build tools augmentation (move it, anarchy mods, etc).
        /// </summary>
        Tools = 1UL << 50,

        /// <summary>
        /// Mods that replace or remove traffic lights (excluding TMPE).
        /// </summary>
        TrafficLights = 1UL << 51,

        /// <summary>
        /// Transport lines (placement, naming, etc).
        /// </summary>
        TransportLines = 1UL << 52,

        /// <summary>
        /// Citizen transport type preferences.
        /// </summary>
        TransportPreference = 1UL << 53,

        /// <summary>
        /// Trees and shrubs (but not prop-based plants).
        /// </summary>
        Trees = 1UL << 54,

        /// <summary>
        /// Vehicle passenger or cargo capacity.
        /// </summary>
        VehicleCapacity = 1UL << 55,

        /// <summary>
        /// Vehicle info panel.
        /// </summary>
        VehicleInfo = 1UL << 56,

        /// <summary>
        /// Conflicts with More Vehicles mod.
        /// </summary>
        VehicleLimit = 1UL << 57,

        /// <summary>
        /// Anything to do with vehicles.
        /// </summary>
        Vehicles = 1UL << 57,

        /// <summary>
        /// Velocity of cims, vehicles, or networks.
        /// </summary>
        Velocity = 1UL << 58,

        /// <summary>
        /// Wealth of cims (salary, expenditure, etc).
        /// </summary>
        Wealth = 1UL << 59,

        /// <summary>
        /// Mods that alter zoning around roads.
        /// </summary>
        Zoning = 1UL << 60,
    }
}