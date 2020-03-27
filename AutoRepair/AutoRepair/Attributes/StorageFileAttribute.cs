namespace AutoRepair.Attributes {
    using System;

    /// <summary>
    /// Defines file name for a storage container.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class StorageFileAttribute : Attribute {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFileAttribute"/> class.
        /// </summary>
        /// 
        /// <param name="value">The file name.</param>
        public StorageFileAttribute(string value) {
            Value = value;
        }

        /// <summary>
        /// Gets the full file path.
        /// </summary>
        public string Value { get; private set; }
    }
}
