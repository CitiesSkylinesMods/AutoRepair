namespace AutoRepair.Enums {
    using AutoRepair.Descriptors;
    using System.ComponentModel;

    /// <summary>
    /// Determines how many of the <see cref="Review.RequiredAssets"/> and/or <see cref="Review.RequiredMods"/> are required.
    /// </summary>
    public enum Selection {
        /// <summary>
        /// All required items must be subscribed and enabled.
        /// </summary>
        [Description("All required items required.")]
        All = 0,

        /// <summary>
        /// At leasts one of the required items must be subscribed and enabled.
        /// </summary>
        [Description("Choose one or more required items.")]
        AtLeastOne = 1,

        /// <summary>
        /// Only one of the required items must be subscribed and enabled.
        /// </summary>
        [Description("Choose only one required item.")]
        OnlyOne = 2,
    }
}