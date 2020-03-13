namespace AutoRepair.Conflicts {
    using AutoRepair.Enums;
    using System.Collections.Generic;

    public partial class Conflicts {
        private void AddMultiplayer() {
            Incompatibles.Add(ConflictGroups.Multiplayer, new List<ulong>() {
                { 2000408250u }, // CSM
                { 1985701540u }, // CSM
                { 1841616225u }, // CSM
                { 1731754018u }, // CSM
                { 1598623776u }, // CSM - CitySkyline Multiplayer
                { 1598622569u }, // CSM - CitySkyline Multiplayer
                { 1598621063u }, // CSM - CitySkyline Multiplayer
                { 1558438291u }, // Cities: Skylines Multiplayer (CSM) [Beta]
            });
        }
    }
}
