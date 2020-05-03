namespace AutoRepair.Catalogs {
    using AutoRepair.Descriptors;
    using AutoRepair.Enums;
    using AutoRepair.Util;
    using JetBrains.Annotations;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public partial class Catalog {

#if DEBUG
        public void DumpToCSV() {
            Log.Reset();

            StringBuilder csv = new StringBuilder(1024 * 50);

            CsvDumpBroken(ref csv);

            CsvDumpIncompatible(ref csv);

            CsvDumpGameUpdate(GameVersion.SunsetHarbor, ref csv);

            Log.Info(csv.ToString());
        }

        private void CsvDumpBroken(ref StringBuilder csv) {
            csv.Append("\n\nGAME BREAKING ITEMS:\n\n");
            CsvDumpItemsByFlags(ItemFlags.GameBreaking, ref csv);

            csv.Append("\n\nEDITOR BREAKING ITEMS:\n\n");
            CsvDumpItemsByFlags(ItemFlags.EditorBreaking, ref csv);
        }

        private void CsvDumpItemsByFlags(ItemFlags flags, ref StringBuilder csv) {
            foreach (KeyValuePair<ulong, Review> entry in Reviews) {
                Review item = entry.Value;
                if (item.HasFlag(flags)) {
                    CsvDumpItem(item, ref csv);
                }
            }
        }

        private void CsvDumpIncompatible(ref StringBuilder csv) {
            csv.Append("\n\nINCOMPATIBLE ITEMS:\n\n");
            foreach (KeyValuePair<ulong, Review> entry in Reviews) {
                Review item = entry.Value;

                if (item.WorkshopId == 1383456057u) {
                    continue; // Shi cho gets its own section lol
                }

                if (item.Compatibility == null) {
                    continue; // nothing to do 
                }

                if (item.HasFlag(ItemFlags.GameBreaking)) {
                    continue; // user should remove or replace it instead
                }

                CsvDumpItemCompatibilityByStatus(item, Status.Incompatible, ref csv);
            }
        }

        private void CsvDumpItemCompatibilityByStatus(Review item, Status status, ref StringBuilder csv) {
            foreach (KeyValuePair<ulong, Status> entry in item.Compatibility) {
                if (entry.Value == status) {
                    csv.AppendFormat(
                        "\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\"\n",
                        // source item
                        item.WorkshopName,
                        item.WorkshopId,
                        GetWorkshopURL(item.WorkshopId),
                        // target item
                        GetNameFromId(entry.Key),
                        entry.Key,
                        GetWorkshopURL(entry.Key),
                        GetRelevantNote(item, entry.Key));
                }
            }
        }

        private void CsvDumpGameUpdate(Version version, ref StringBuilder csv) {
            csv.Append("\n\nBROKEN BY UPDATE :\n\n");
            foreach (KeyValuePair<ulong, Review> entry in Reviews) {
                Review item = entry.Value;
                if (item.BrokenBy == version) {
                    CsvDumpItem(item, ref csv);
                }
            }

            csv.Append("\n\nCOMPATIBLE WITH UPDATE :\n\n");
            foreach (KeyValuePair<ulong, Review> entry in Reviews) {
                Review item = entry.Value;
                if (item.CompatibleWith == version && item.BrokenBy < item.CompatibleWith) {
                    CsvDumpItem(item, ref csv);
                }
            }
        }

        private void CsvDumpItem(Review item, ref StringBuilder csv) {
            bool hasReplacement = item.ReplaceWith != 0u;

            string replacementName = hasReplacement
                ? GetNameFromId(item.ReplaceWith)
                : string.Empty;

            csv.AppendFormat(
                "\"{0}\",\"{1}\",\"{2}\",\"{3}\",\"{4}\"\n",
                // item:
                item.WorkshopName,
                item.WorkshopId,
                GetWorkshopURL(item.WorkshopId),
                // replacement:
                hasReplacement ? GetWorkshopURL(item.ReplaceWith) : string.Empty,
                replacementName);
        }

        private string GetRelevantNote(Review item, ulong noteId) {
            if (item.Notes != null && item.Notes.TryGetValue(noteId, out var note)) {
                return note;
            } else {
                return string.Empty;
            }
        }

        private string GetWorkshopURL(ulong workshopId) {
            return $"https://steamcommunity.com/sharedfiles/filedetails/?id={workshopId}";
        }
#endif

        private string GetNameFromId(ulong workshopId) {
            if (Reviews.TryGetValue(workshopId, out Review item)) {
                return item.WorkshopName;
            } else {
                return string.Empty;
            }
        }
    }
}
