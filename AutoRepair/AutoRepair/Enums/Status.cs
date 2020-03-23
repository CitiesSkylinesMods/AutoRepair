namespace AutoRepair.Enums {
    using System;
    using System.ComponentModel;

    /// <summary>
    /// The compatibility status between two items.
    /// </summary>
    public enum Status {

        /// <summary>
        /// Compatibility not yet determined.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// There are serious issues (often game-breaking) when the items are used together.
        /// </summary>
        Incompatible = 1,

        /// <summary>
        /// There are minor (not game breaking) issues when the items used together.
        /// </summary>
        MinorIssues = 2,

        /// <summary>
        /// The items are compatible with each other.
        /// </summary>
        Compatible = 4,

        /// <summary>
        /// The items are compatible and it is recommended to use them together.
        /// </summary>
        Recommended = 8,

        /// <summary>
        /// The items are compatible and must be used together (eg. mod dependencies).
        /// </summary>
        Required = 16,
    }
}
