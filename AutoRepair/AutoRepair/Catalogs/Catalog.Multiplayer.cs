namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using System.Collections.Generic;

    /// <summary>
    /// Currently active CSM mods.
    /// </summary>
    public partial class Catalog {

        /// <summary>
        /// Add mods to list.
        /// </summary>
        private void MultiplayerMods() {

            string catalog = "Multiplayer";

            Dictionary<ulong, Status> multiplayerIncompatible = new Dictionary<ulong, Status>() {
                { 2040225526u, Status.Incompatible }, // Multiplayer
                { 2030131871u, Status.Incompatible }, // CSM
                { 2027716634u, Status.Incompatible }, // CitiesSkylinesMultiplayer_2002.2.0
                { 2021598295u, Status.Incompatible }, // 1558438291 [Beta] CSM - Cities_ Skylines Multiplayer
                { 2000408250u, Status.Incompatible }, // CSM
                { 1985701540u, Status.Incompatible }, // CSM
                { 1841616225u, Status.Incompatible }, // CSM
                { 1731754018u, Status.Incompatible }, // CSM
                { 1598623776u, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1598622569u, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1598621063u, Status.Incompatible }, // CSM - CitySkyline Multiplayer
                { 1558438291u, Status.Incompatible }, // Cities: Skylines Multiplayer (CSM) [Beta] "official release"
                { 1556669944u, Status.Incompatible }, // CSM
            };

            // This seems to be the current "official" version
            // although there are several versions released after it.
            // Strangely, none of the uploaders are very talkative
            AddMod(new Review(1558438291u, "Cities: Skylines Multiplayer (CSM) [Beta]") {
                Affect = Factor.Multiplayer,
                Authors = "xylisn",
                Catalog = catalog,
                Compatibility = multiplayerIncompatible,
                ContinuationOf = 1556669944u, // CSM
                Flags = ItemFlags.SourceAvailable
                      | ItemFlags.MinorIssues, // doesn't sync full game features
                SourceURL = "https://github.com/DominicMaas/Tango",
            });

            /*
            #  ██████  ██████  ███████  ██████  ██      ███████ ████████ ███████
            # ██    ██ ██   ██ ██      ██    ██ ██      ██         ██    ██
            # ██    ██ ██████  ███████ ██    ██ ██      █████      ██    █████
            # ██    ██ ██   ██      ██ ██    ██ ██      ██         ██    ██
            #  ██████  ██████  ███████  ██████  ███████ ███████    ██    ███████
            */

            // and another clone!
            AddMod(new Review(2040225526u, "Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "State Farm",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // looks like yet another clone, waiting for feedback from author
            AddMod(new Review(2030131871u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "wihtewolf1712",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // waiting for response from author, currently assuming _yet another clone_
            AddMod(new Review(2027716634u, "CitiesSkylinesMultiplayer_2002.2.0") {
                Affect = Factor.Multiplayer,
                Authors = "Ceddicedced",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            // Struggled to get any meaningful info from author, assuming clone
            AddMod(new Review(2021598295u, "1558438291 [Beta] CSM - Cities_ Skylines Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "Leñador de Abedules",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(2000408250u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = string.Empty,
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.NoWorkshop // removed on or around 12/Mar/2020
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.MissingArchiveURL | Warning.OlderReplacement,
            });

            AddMod(new Review(1985701540u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "himete",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1841616225u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "Stutenandy",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1731754018u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "motacy",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598623776u, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598622569u, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1598621063u, "CSM - CitySkyline Multiplayer") {
                Affect = Factor.Multiplayer,
                Authors = "WartraxX",
                Catalog = catalog,
                CloneOf = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // 1558438291u has since been updated
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
                Suppress = Warning.OlderReplacement,
            });

            AddMod(new Review(1556669944u, "CSM") {
                Affect = Factor.Multiplayer,
                Authors = "Daniel",
                Catalog = catalog,
                Compatibility = multiplayerIncompatible,
                Flags = ItemFlags.Abandonware
                      | ItemFlags.ForceMigration
                      | ItemFlags.MinorIssues
                      | ItemFlags.Obsolete // replaced by 1558438291u "official" release
                      | ItemFlags.SourceUnavailable,
                ReplaceWith = 1558438291u, // Cities: Skylines Multiplayer (CSM) [Beta]
            });
        }
    }
}
