namespace AutoRepair.Lists {
    using AutoRepair.Catalogs;
    using System.Collections.Generic;

    /// <summary>
    /// Announcements that can be shown in settings UI and report.
    /// </summary>
    public class Announcements {

        public static Dictionary<ulong, string> Notes = new Dictionary<ulong, string>() {
            { Catalog.NOTE, "Parallel Road Tool updated; is now compatible with Fine Road Tool." },
        };
    }
}
