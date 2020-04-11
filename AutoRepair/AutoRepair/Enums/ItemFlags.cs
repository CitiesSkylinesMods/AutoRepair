namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    [Flags]
    public enum ItemFlags {

        /// <summary>
        /// No flags defined; probably by mistake.
        /// </summary>
        None = 0,

        /*
        # ███████ ████████  █████  ████████ ██    ██ ███████
        # ██         ██    ██   ██    ██    ██    ██ ██
        # ███████    ██    ███████    ██    ██    ██ ███████
        #      ██    ██    ██   ██    ██    ██    ██      ██
        # ███████    ██    ██   ██    ██     ██████  ███████
        */

        /// <summary>
        /// Author no longer maintains the item.
        /// </summary>
        [Description("Item no longer maintained")]
        Abandonware = 1,

        /// <summary>
        /// Item is designed for use in content editor (may also work in-game).
        /// </summary>
        [Description("Designed for use in editors")]
        EditorMod = 1 << 1,

        /// <summary>
        /// Force migration to a more reliable item; usally only for game/editor breaking stuff.
        /// </summary>
        [Description("Mandatory migration required")]
        ForceMigration = 1 << 2,

        /// <summary>
        /// Translation of existing item, or item contains multiple locales.
        /// </summary>
        [Description("Localisation of an existing item")]
        Localised = 1 << 3,

        /// <summary>
        /// Not publicly available in workshop; removed, hidden or friends-only.
        /// </summary>
        [Description("Item removed from workshop")]
        NoWorkshop = 1 << 4,

        /// <summary>
        /// Obsolete; features now in vanilla game or superseded by better alternatives.
        /// </summary>
        [Description("No longer relevant")]
        Obsolete = 1 << 5,

        /// <summary>
        /// An item so good/useful that everyone should have it (eg. LSM, Move It, etc).
        ///
        /// USE SPARINGLY!
        /// </summary>
        [Description("Recommended for all users")]
        Recommended = 1 << 6,

        /// <summary>
        /// Item is safe for steaming, according to author.
        /// </summary>
        [Description("Streamable; no copyright issues")]
        Streamable = 1 << 7,

        /// <summary>
        /// Item is missing from the catalog; very new or old items.
        /// </summary>
        [Description("Item is not in catalog")]
        Unrecognised = 1 << 8,

        /// <summary>
        /// Item is bundled with base game; it is not from the Workshop.
        /// </summary>
        [Description("Bundled with the base game")]
        Vanilla = 1 << 9,

        /*
        # ██ ███████ ███████ ██    ██ ███████ ███████
        # ██ ██      ██      ██    ██ ██      ██
        # ██ ███████ ███████ ██    ██ █████   ███████
        # ██      ██      ██ ██    ██ ██           ██
        # ██ ███████ ███████  ██████  ███████ ███████
        */

        /// <summary>
        /// Runs code on instantiation (eg. <c>static .ctor()</c>) or inspection (eg. <c>.Name</c> getter).
        ///
        /// Likely to break anything that scans mods (such as compatibility checkers).
        /// </summary>
        [Description("Runs code on instantiation or inspection")]
        BadStartup = 1 << 10,

        /// <summary>
        /// Broken by a game update; no longer works or causes errors.
        /// </summary>
        [Description("Broken by recent game update")]
        BrokenByUpdate = 1 << 11,

        /// <summary>
        /// Breaks the content editors or assets created with them.
        /// </summary>
        [Description("Breaks the content editors")]
        EditorBreaking = 1 << 12,

        /// <summary>
        /// Very badly broken; prevents games loading or breaks saves beyond repair.
        /// </summary>
        [Description("Game-breaking")]
        GameBreaking = 1 << 13,

        /// <summary>
        /// Significantly reduces frame-rate in-game.
        /// </summary>
        [Description("Can cause lag in-game")]
        Laggy = 1 << 14,

        /// <summary>
        /// Filesize is excessively large compared to similar items.
        /// </summary>
        [Description("Excessively lage filesize")]
        LargeFileWarning = 1 << 15,

        /// <summary>
        /// Minor bugs; does not break saves, easy to recover from (eg. by unsubscribing the mod).
        /// </summary>
        [Description("Some minor bugs")]
        MinorIssues = 1 << 16,

        /// <summary>
        /// Save games created with this item will not load without it.
        /// </summary>
        [Description("Save games created with this will not load without it")]
        SaveAltering = 1 << 17,

        /// <summary>
        /// Significantly increases load times.
        /// </summary>
        [Description("Increases city load times")]
        SlowLoad = 1 << 18,

        /// <summary>
        /// Some users, but not all, report major loss of functionality or serious bugs.
        /// </summary>
        [Description("Some users report serious issues")]
        Unreliable = 1 << 19,

        /*
        # ███████  ██████  ██    ██ ██████   ██████ ███████
        # ██      ██    ██ ██    ██ ██   ██ ██      ██
        # ███████ ██    ██ ██    ██ ██████  ██      █████
        #      ██ ██    ██ ██    ██ ██   ██ ██      ██
        # ███████  ██████   ██████  ██   ██  ██████ ███████
        */

        /// <summary>
        /// Source code available online.
        /// </summary>
        [Description("Source available")]
        SourceAvailable = 1 << 20,

        /// <summary>
        /// Source code bundled with the mod.
        /// </summary>
        [Description("Source bundled with item")]
        SourceBundled = 1 << 21,

        /// <summary>
        /// Compiled mod code is obfuscated and unreadable.
        /// </summary>
        [Description("Warning: Source obfuscated")]
        SourceObfuscated = 1 << 22,

        /// <summary>
        /// The source code is available, but appears to be outdated.
        /// </summary>
        [Description("Source available, but outdated")]
        SourceOudated = 1 << 23,

        /// <summary>
        /// Source code is not available.
        /// </summary>
        [Description("Source not available")]
        SourceUnavailable = 1 << 24,
    }
}