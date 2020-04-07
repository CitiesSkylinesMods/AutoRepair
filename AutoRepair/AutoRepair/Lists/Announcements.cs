using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Lists {

    /// <summary>
    /// Announcements that can be shown in settings UI and report.
    /// </summary>
    public class Announcements {

        public static Dictionary<ulong, string> Notes = new Dictionary<ulong, string>() {
            { 812125426u, "[Network Extensions 2]: Original mod has been updated for Sunset Harbor" },
        };

    }
}
