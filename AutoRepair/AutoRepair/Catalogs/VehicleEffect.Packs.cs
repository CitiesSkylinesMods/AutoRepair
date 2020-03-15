namespace AutoRepair.Catalogs {
    /// <summary>
    /// Defines vehicle effect packs.
    /// </summary>
    public partial class VehicleEffect {

        /// <summary>
        /// Add effect packs to the list.
        /// </summary>
        private void AddPacksToList() {
            // https://drive.google.com/file/d/1ATs9XRlt9oCVOazyqFn5h0S517b7BN1L/view
            AddExtraPack(2008325200u, "Vehicle Effects Definition Pack DBAG");

            AddExtraPack(1541828679u, "CNSoundPack V0.2.2");
            list[1541828679u].RequiredMods.Add(818641631u); // Ambient Sounds Tuner
            list[1541828679u].CompatibleWith.Add(818641631u); // Ambient Sounds Tuner
        }
    }
}
