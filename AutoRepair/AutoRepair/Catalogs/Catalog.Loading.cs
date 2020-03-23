namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that affect loading process.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        ///
        /// TODO:
        /// * Add authors.
        /// </summary>
        private void LoadingCatalog() {
            string catalog = "Loading";

            AddMod(new Item(1818482110u, "Change Loading Image 2") {
                Affect = Factor.Loading,
                Authors = "BloodyPenguin",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 431125814u, Status.Incompatible }, // ChangeLoadingImage (original version)
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/bloodypenguin/ChangeLoadingImage",
            });

            // todo: check if source still obfu
            AddMod(new Item(1675213439u, "No Intro") {
                Affect = Factor.Loading,
                Authors = "Dendraspis",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1665106193u, Status.Incompatible }, // Skip Intro
                    // tmpe?
                },
                Flags = ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable,
            });

            AddMod(new Item(1665106193u, "Skip Intro") {
                Affect = Factor.Loading,
                Authors = "egi",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                    { 1675213439u, Status.Incompatible }, // No Intro
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/DaEgi01/CitiesSkylines-SkipIntro",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            AddMod(new Item(1733593614u, "Immediate Continue") {
                Affect = Factor.Loading,
                Authors = "Dendraspis",
                BrokenBy = GameVersion.PdxLauncher,
                Catalog = catalog,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.BrokenByUpdate // 1.12.3
                      | ItemFlags.GameBreaking
                      | ItemFlags.SourceObfuscated // big warning sign
                      | ItemFlags.SourceUnavailable
                      | ItemFlags.Obsolete, // vanilla has this since launcher update
            });
        }
    }
}
