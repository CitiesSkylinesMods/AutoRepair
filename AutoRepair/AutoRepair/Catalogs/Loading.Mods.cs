namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public partial class Loading {
        private void AddModsToList() {
            Add(new Item(1818482110u, "Change Loading Image 2") {
                IncompatibleMods = {
                    { 431125814u }, // ChangeLoadingImage (original version)
                },
            });

            // todo: check if source still obfu
            Add(new Item(1733593614u, "Immediate Continue") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete, // vanilla has this since launcher update
            });

            Add(new Item(1620588636u, "Safenets") {
                Flags = ItemFlags.Verified
                      | ItemFlags.Recommended
                      | ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/thale5/Safenets",
            });

            // todo: check if source still obfu
            Add(new Item(1675213439u, "No Intro") {
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
                IncompatibleMods = new List<ulong>() {
                    { 1665106193u }, // Skip Intro
                    // tmpe?
                },
            });

            Add(new Item(1665106193u, "Skip Intro") {
                Flags = ItemFlags.SourceAvailable,
                SourceCodeURL = "https://github.com/DaEgi01/CitiesSkylines-SkipIntro",
                IncompatibleMods = new List<ulong>() {
                    { 1675213439u }, // No Intro
                },
            });

        }
    }
}
