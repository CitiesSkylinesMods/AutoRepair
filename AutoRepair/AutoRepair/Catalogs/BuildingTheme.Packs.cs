namespace AutoRepair.Catalogs {
    /// <summary>
    /// Defines theme packs for the Building Themes mod.
    /// </summary>
    public partial class BuildingTheme {

        /// <summary>
        /// Add theme packs to the list.
        /// </summary>
        private void AddPacksToList() {
            // todo: probably requires DLC?
            // collection: https://steamcommunity.com/workshop/filedetails/?id=1901228838
            AddThemePack(1903967441u, "Building Theme: European Suburbia Decorated");

            // todo: DLC required
            AddThemePack(1747800340u, "Building Theme: University City Districts");

            AddThemePack(1632933031u, "Building Theme:Japanese low residential theme");

            AddThemePack(1222415977u, "Christmas Village Building Theme"); // alt: vanilla district style: 1182123078u
        }
    }
}
