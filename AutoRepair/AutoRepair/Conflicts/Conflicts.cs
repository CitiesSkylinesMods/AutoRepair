namespace AutoRepair.Conflicts {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Defines lists of conflicting mods for each conflict category and provides
    /// methods for applying and filtering those items against item descriptors.
    /// </summary>
    public partial class Conflicts {
        private static Conflicts instance;

        /// <summary>
        /// Gets the instance (creating if necessary) of <see cref="Conflicts"/> class.
        /// </summary>
        public static Conflicts Instance => instance ?? (instance = new Conflicts());

        /// <summary>
        /// Lists of incompatible mods keyed by individual <see cref="ConflictGroups"/>.
        /// </summary>
        public Dictionary<ConflictGroups, List<ulong>> Incompatibles;

        /// <summary>
        /// Initializes a new instance of the <see cref="Conflicts"/> class.
        /// </summary>
        public Conflicts() {
            Incompatibles = new Dictionary<ConflictGroups, List<ulong>>();

            AddMultiplayer();
        }

        public void ApplyToItem(Item item) {

        }
    }
}
