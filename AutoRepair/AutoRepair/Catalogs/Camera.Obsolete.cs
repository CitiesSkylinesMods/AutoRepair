using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoRepair.Catalogs {
    private partial class Camera {
        private void AddObsoleteToList() {
            // looks like First Person Camera, likely game breaking old version
            AddDodgey(1492317158u, "第一人称视角");

            { 411016892u }, // Enhanced Zoom (no longer in workshop)
                    { 651056665u }, // Enhanced Zoom Continued (no longer in workshop)

        }
    }
}
