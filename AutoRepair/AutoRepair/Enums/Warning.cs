namespace AutoRepair.Enums {
    using System.ComponentModel;

    public enum Warning {
        /// <summary>
        /// No suppressible problems found.
        /// </summary>
        None,

        /// <summary>
        /// Items without workshop page should specify URL to web archive.
        /// </summary>
        MissingArchiveURL = 1,

        /// <summary>
        /// Replacement items should be more recent than item being replaced.
        /// </summary>
        OlderReplacement = 1 << 1,

        /// <summary>
        /// BrokenBy should be after CompatibleWith which should be after ReleasedDuring.
        /// </summary>
        InvalidVersionSequence = 1 << 2,
    }
}