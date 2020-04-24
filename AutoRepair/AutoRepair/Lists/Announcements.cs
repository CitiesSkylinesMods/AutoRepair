namespace AutoRepair.Lists {
    using AutoRepair.Catalogs;
    using System.Collections.Generic;

    /// <summary>
    /// Announcements that can be shown in settings UI and report.
    /// </summary>
    public class Announcements {

        public static Dictionary<ulong, string> Notes = new Dictionary<ulong, string>() {
            { Catalog.NOTE, "Mon 20th April @ 13:00 UTC: Third attempt to migrate _all_ mods to Harmony 2" },
            { 2040656402uL, "'Harmony 2.0.0.9 (Mod Dependency)' will be auto-subscribed and enabled." },
            { Catalog.NOTE, "Report problems on the 'Harmony 2.0.0.9 (Mod Dependency)' workshop page." },
        };

    }
}
