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
            { 2044086131u, "[Network Extensions 2]: Bug fix replacement mod added to workshop" },
            { 2044145894u, "[Dropouts]: Bug fix replacement mod added to workshop" },
        };

    }
}
