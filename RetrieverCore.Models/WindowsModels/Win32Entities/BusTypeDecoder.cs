using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class BusTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 0:
                default:
                    return "Unknown";
                case 1:
                    return "SCSI";
                case 2:
                    return "ATAPI";
                case 3:
                    return "ATA";
                case 4:
                    return "IEEE 1394";
                case 5:
                    return "SSA";
                case 6:
                    return "Fibre Channel";
                case 7:
                    return "USB";
                case 8:
                    return "RAID";
                case 9:
                    return "iSCSI";
                case 10:
                    return "Serial Attached SCSI(SAS)";
                case 11:
                    return "Serial ATA (SATA)";
                case 12:
                    return "Secure Digital (SD)";
                case 13:
                    return "Multimedia Card (MMC)";
                case 14:
                    return "This value is reserved for system use (MAX)";
                case 15:
                    return "File-Backed Virtual";
                case 16:
                    return "Storage Spaces";
                case 17:
                    return "NVMe";
                case 18:
                    return "This value is reserved for system use.";
            }
        }
    }
}
