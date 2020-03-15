namespace AutoRepair.Enums {
    using AutoRepair.Descriptors;
    using System.ComponentModel;

    /// <summary>
    /// Determines how many of the <see cref="Item.RequiredAssets"/> and/or <see cref="Item.RequiredMods"/> are required.
    /// </summary>
    public enum Selection {
        [Description("All required items required.")]
        All = 0,

        [Description("Choose one or more required items.")]
        AtLeastOne,

        [Description("Choose only one required item.")]
        OnlyOne,
    }
}