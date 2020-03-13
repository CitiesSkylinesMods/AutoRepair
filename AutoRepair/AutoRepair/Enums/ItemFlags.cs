namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ItemFlags {

        // no applicable flags
        None = 0,

        /* Maintenance status flags */

        // Confirmed working after game update
        // see GameVersion in ModInfo struct
        [Description("Confirmed as working")]
        Verified,

        // No sign of activity from the author
        [Description("Item no longer maintained")]
        Abandonware,

        // It's no longer required, likely due to incoproation in base game or some parent mod.
        [Description("No longer relevant")]
        Obsolete,

        // Removed from workshop by author or admin
        [Description("Item removed from workshop")]
        NoWorkshop,

        // The mod is not in our reference dictionary
        [Description("Item is not in catalog")]
        Unrecognised,

        /* Source code */

        SourceAvailable,

        SourceObfuscated,

        SourceOudated,

        SourceUnavailable,

        /* Reliability status flags */

        // Can sometimes break saves (but some users don't have problems)
        // See Warnings in ModInfo struct
        [Description("Some users report bugs")]
        Unreliable,

        /*
        // Currently broken by game update (awaiting fix)
        [Description("Broken by recent game update")]
        BrokenByUpdate,
        */

        // Bugs that don't break saves
        [Description("Some minor bugs")]
        MinorBugs,

        // Unmaintained and very badly broken
        // Will always force migration (see below)
        [Description("Game-breaking")]
        GameBreaking,

        /* Other status flags */

        // Force migration to replacement mod(s)
        // Example use: Temp fix uploaded to workshop, original then fixed,
        // so force migration to move people back to original
        // Must specify Item.ReplaceWith
        [Description("Mandatory migration required")]
        ForceMigration,

        // Eats too much CPU
        // See Warnings in ModInfo struct
        [Description("Can cause lag in-game")]
        Laggy,

        // Mod alters save in such a way that the save won't load if mod not enabled
        // For example, More Vehicles, 81 Tiles
        // See Warnings in ModInfo struct
        [Description("Save games created with this will not load without it")]
        SaveChanging,

        // Does it break the asset/theme/map editor?
        [Description("Breaks the asset/theme/map editors")]
        BreaksEditors,

        // Just a translation of existing mod, likely unmaintained
        [Description("Translation of an existing mod")]
        Translation,

        /// <summary>
        /// Recommend item to user if:
        ///
        /// * It's not yet subscribed and they don't have any conflicting/incompatible items, and
        /// * They have required mods, or, there are no required mods
        /// </summary>
        [Description("Recommended for all users")]
        Recommended,
    }
}