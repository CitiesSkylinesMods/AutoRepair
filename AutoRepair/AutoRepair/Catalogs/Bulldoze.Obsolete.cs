namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;

    public partial class Bulldoze {

        private void AddObsoleteToList() {
            // likely game breaking automatic bulldoze lang clone
            AddDodgey(1875698406u, "406132323");

            // possibly a locaised version?
            Add(new Item(1759514242u, "639486063 Automatic Bulldoze v2") {
                Flags = ItemFlags.SourceUnavailable
                      | ItemFlags.Abandonware,
                ConflictsWith = ConflictGroups.Bulldoze,
            });
        }
    }
}
