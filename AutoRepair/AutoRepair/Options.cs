namespace AutoRepair {
    using AutoRepair.Attributes;
    using AutoRepair.Util;
    using UnityEngine;

    /// <summary>
    /// Log file verbosity options.
    /// </summary>
    [StorageFile("AutoRepair.Options.xml")] // path: ...\Steam\steamapps\common\Cities_Skylines
    public class Options {
        private static Options instance;
        public static Options Instance => instance ?? (instance = StorageManager<Options>.Load());

        /// <summary>
        /// Gets or sets a value indicating whether to output some intro text at start of log file.
        /// </summary>
        public bool LogIntroText { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether Source URLs should be logged.
        /// </summary>
        public bool LogDescriptorHeaders { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether Workshop URLs should be logged.
        /// </summary>
        public bool LogWorkshopURLs { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether Source URLs should be logged.
        /// </summary>
        public bool LogSourceURLs { get; set; } = false;

        /// <summary>
        /// Save settings to disk.
        /// </summary>
        public void Save() => StorageManager<Options>.Save();
    }
}