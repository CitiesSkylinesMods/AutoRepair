namespace AutoRepair.Enums {
    using System;

    [Flags]
    public enum ConflictGroups {

        // none
        None = 0,

        AutoBulldoze,

        EmployOvereducatedWorkers,

        FineRoadAnarchy,

        FineRoadTool,

        /// <summary>
        /// Mods that alter costs, etc., to make game harder or easier.
        /// </summary>
        HardMode,

        /// <summary>
        /// Mods that are made obsolete by, or conflict with, Hide It.
        /// </summary>
        HideIt,

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

        /// <summary>
        /// Mods tha add numbered rectangles.
        /// </summary>
        NumberedRectangles,

        /// <summary>
        /// Conflicts between mods relating to PostProcessFX.
        /// </summary>
        PostProcessFX,

        /// <summary>
        /// Conflicts between road customisation mods.
        /// </summary>
        RoadsUnited,

        /// <summary>
        /// Conflicts with tile unlock mods (25 Tiles, 81 Tiles, Purchase It, etc).
        /// </summary>
        Tiles,

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