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
            AddMod(1673480325u, "£5 Million Starting Money");
            AddMod(1671542319u, "£2.5 Million Starting Money");
        }
    }
}
