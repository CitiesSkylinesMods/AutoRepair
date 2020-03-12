namespace AutoRepair.Enums {
    using System.ComponentModel;

    public enum ItemTypes {
        [Description("Not defined (probably an error)")]
        None,

        [Description("Asset")]
        Asset,

        [Description("Camera Script")]
        Camera,

        [Description("Mod")]
        Mod,

        [Description("Radio station")]
        Radio,
    }
}