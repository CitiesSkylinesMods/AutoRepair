namespace AutoRepair.Enums {
    using System;

    [Flags]
    public enum ConflictGroups {

        // none
        None = 0,

        AutoBudget,

        /// <summary>
        /// Things that alter building level, such as "Control Building Level Up" etc.
        /// </summary>
        BuildingLevel,

        /// <summary>
        /// Auto bulldoze mods.
        /// </summary>
        Bulldoze,

        EmployOvereducatedWorkers,

        FineRoadAnarchy,

        FineRoadTool,

        /// <summary>
        /// Difficulty mods (alter money, stats, etc).
        /// </summary>
        Difficulty,

        /// <summary>
        /// Mods that are made obsolete by, or conflict with, Hide It.
        /// </summary>
        HideIt,

        /// <summary>
        /// Conflicts with map theme mods.
        /// </summary>
        MapThemes,

        MilestoneUnlocks,

        /// <summary>
        /// Conflicts with More Vehicles mod.
        /// </summary>
        MoreVehicles,

        /// <summary>
        /// Conflicts with Move It mod.
        /// </summary>
        MoveIt,

        /// <summary>
        /// Conflicts with Cities Skylines Multiplayer (CSM) mod
        /// </summary>
        Multiplayer,

        NetworkExtensions,

        NetworkSkins,

        /// <summary>
        /// Mods tha add numbered rectangles.
        /// </summary>
        NumberedRectangles,

        PollutionRemovers,

        /// <summary>
        /// Conflicts between mods relating to PostProcessFX.
        /// </summary>
        PostProcessFX,

        RoadColorChanger,

        /// <summary>
        /// Conflicts between road customisation mods.
        /// </summary>
        RoadsUnited,

        /// <summary>
        /// Conflicts with tile unlock mods (25 Tiles, 81 Tiles, Purchase It, etc).
        /// </summary>
        Tiles,

        ThemeMixer,

        TMPE,

        /// <summary>
        /// Toolbar changer mods.
        /// </summary>
        Toolbar,

        /// <summary>
        /// Mods that replace or remove traffic lights (excluding TMPE).
        /// </summary>
        TrafficLights,

        /// <summary>
        /// Mods that alter zoning around roads.
        /// </summary>
        Zoning,
    }
}