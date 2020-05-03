namespace AutoRepair.Descriptors {
    using AutoRepair.Catalogs;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    using ColossalFramework.PlatformServices;
    using ICities;
    using System;
    using static ColossalFramework.Plugins.PluginManager;

    /// <summary>
    /// Descriptor containing information related to a subscribed item.
    /// </summary>
    public class Subscription {

        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription"/> class for a mod or camera script.
        /// </summary>
        /// 
        /// <param name="plugin">The <see cref="PluginInfo"/> for the mod.</param>
        public Subscription(PluginInfo plugin) {
            if (plugin == null) {
                return;
            }

            Plugin = plugin;

            // Entry = new EntryData(plugin); // m_detailsPending

            IsEnabled = plugin.isEnabled;
            IsOffline = plugin.publishedFileID == PublishedFileId.invalid;
            IsValid = true;

            if (Catalog.Instance.TryGetReview(plugin, out var review)) {
                Review = review;
                IsReviewed = true;
                Name = review.HasFlag(ItemFlags.BadStartup)
                    ? $"({review.WorkshopName})"
                    : GetPluginName(plugin);
            } else {
                Name = GetPluginName(plugin);
            }

            LastDownloaded = PackageEntry.GetLocalModTimeUpdated(plugin.modPath).ToLocalTime();

            if (!IsOffline) {
                WorkshopId = plugin.publishedFileID.AsUInt64;
                WorkshopURL = $"https://steamcommunity.com/sharedfiles/filedetails/?id={WorkshopId}";
            }
        }

        /// <summary>
        /// Gets the <see cref="Descriptors.Review"/> descriptor.
        /// </summary>
        public Review Review { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the item is enabled.
        /// </summary>
        public bool IsEnabled { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the item is offline (in <c>.../Files/</c> or <c>.../Addons/</c> folders).
        /// </summary>
        public bool IsOffline { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the item is in the catalog.
        /// </summary>
        public bool IsReviewed { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this subscription descriptor is valid.
        ///
        /// If it's not, don't touch it.
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets the date/time the files on disk were last updated.
        /// </summary>
        public DateTime LastDownloaded { get; private set; }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the info associated with a mod or camera script.
        /// </summary>
        public PluginInfo Plugin { get; private set; }

        /// <summary>
        /// Gets the Steam Workshop ID for the subscription.
        /// </summary>
        public ulong WorkshopId { get; private set; }

        /// <summary>
        /// Gets the Steam Workshop URL for the subscription.
        ///
        /// Will be null or empty if the subscription is stored offline.
        /// </summary>
        public string WorkshopURL { get; private set; }

        /// <summary>
        /// An human-readable string representing the subscribed item.
        /// </summary>
        /// 
        /// <returns>Returns a string containing the WorkshopId and Name of the subscribed item.</returns>
        public override string ToString() {
            return $"[ID: {WorkshopId}] \"{Name}\"";
        }

        /// <summary>
        /// Gets the name of a plugin, as safely as possible.
        ///
        /// Some plugins run code in their <c>IUserMod.Name</c> property, or run code in thier
        /// static or instance constructors, which can cause exceptions - this method handles those.
        /// </summary>
        /// 
        /// <param name="plugin">The <see cref="PluginInfo"/> for the mod.</param>
        /// 
        /// <returns>The plugin name. If it's in parentheses something went wrong.</returns>
        internal static string GetPluginName(PluginInfo plugin) {
            try {
                if (plugin == null) {
                    return "(PluginInfo is null)";
                }

                if (plugin.userModInstance == null) {
                    return string.IsNullOrEmpty(plugin.name)
                        ? "(userModInstance and name are null)"
                        : $"({plugin.name})";
                }

                return ((IUserMod)plugin.userModInstance).Name;
            }
            catch {
                return $"(error retreiving Name)";
            }
        }
    }
}
