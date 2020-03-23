namespace AutoRepair.Enums {
    using System;

    /// <summary>
    /// DLCs and content creator packs.
    /// </summary>
    [Flags]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1602:Enumeration items should be documented", Justification = "Brevity.")]
    public enum DLCs {
        None = 0,
        Deluxe = 1, // 346791
        AfterDark = 1 << 1, // 369150
        Snowfall = 1 << 2, // 420610
        NaturalDisasters = 1 << 3, // 515191
        MassTransit = 1 << 4, // 547502
        GreenCities = 1 << 5, // 614580
        ParkLife = 1 << 6, // 715191
        Industries = 1 << 7, // 715194
        Campus = 1 << 8, // 944071
        MatchDay = 1 << 9, // 456200
        Concerts = 1 << 10, // 614581
        Christmas = 1 << 11, // 715192
        ArtDeco = 1 << 12, // 515190
        HighTech = 1 << 13, // 547500
        PearlsFromTheEast = 1 << 14, // 563850
        EuropeanSuburbia = 1 << 15, // 715190
        UniversityCity = 1 << 16, // 1059820
        ModernCityCenter = 1 << 17, // 1148020
    }
}
