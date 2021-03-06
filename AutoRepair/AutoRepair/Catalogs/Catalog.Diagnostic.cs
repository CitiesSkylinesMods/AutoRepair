namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Mods that perform diagnostic functions; mostly used by developers/support.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void DiagnosticMods() {
            string catalog = "Diagnostic";

            AddMod(new Review(2055465280u, "Extended Error Reporting") {
                Affect = Factor.Other,
                Authors = "Strad",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                Published = WorkshopDate("10 Apr, 2020"),
                SourceURL = "https://github.com/Strdate/HealkitMod",
                Updated = WorkshopDate("10 Apr, 2020"),
            });

            AddMod(new Review(2018193885u, "Sequence Logger") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/SequenceLogger",
            });

            AddMod(new Review(2013398705u, "Duplicate Assembly Scanner (DAS)") {
                Affect = Factor.Other,
                Authors = "aubergine18",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                CompatibleWith = GameVersion.SunsetHarbor,
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/CitiesSkylinesMods/DuplicateAssemblyScanner",
            });

            // todo: move to different catalog
            AddMod(new Review(1382357530u, "Sprite Dumper Extended") {
                Affect = Factor.Other,
                Authors = "Boogieman Sam",
                Catalog = catalog,
                Compatibility = new Dictionary<ulong, Status>() {
                },
                Flags = ItemFlags.SourceAvailable,
                SourceURL = "https://github.com/SamsamTS/CS-SpriteDumperExtended",
            });
        }
    }
}
