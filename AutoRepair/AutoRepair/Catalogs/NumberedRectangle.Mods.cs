using AutoRepair.Descriptors;
using AutoRepair.Enums;

namespace AutoRepair.Catalogs {
    /// <summary>
    /// Mod(s) which add numbered rectangles.
    ///
    /// Composite mods which provide other features should _not_ be defined elsewhere.
    /// </summary>
    public partial class NumberedRectangle {

        /// <summary>
        /// Add mods to the list.
        /// </summary>
        private void AddModsToList() {
            string catalog = "NumberedRectangle.Mods";

            AddMod(1673480325u, "£5 Million Starting Money");
            AddMod(1671542319u, "£2.5 Million Starting Money");
            AddMod(1367444256u, "Cash/Money On Demand 500k");

            // also has limits display but people really only use it to add money on demand
            Add(new Item(1330289236u, "CS-Utils") {
                Authors = "kartoffelx86",
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
            });

            // Ctrl+shift+m to get fraud tokens
            // Possibly a clone of existing mod?
            Add(new Item(1232451940u, "调整金钱") {
                Authors = "TIMIYANG",
                Catalog = catalog,
                Flags = ItemFlags.SourceUnavailable,
            });
        }
    }
}
