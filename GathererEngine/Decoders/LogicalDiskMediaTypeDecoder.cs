using System;

namespace GathererEngine.Decoders
{
    public class LogicalDiskMediaTypeDecoder
    {
        public static string Decode(UInt32 type)
        {
            switch (type)
            {
                case 1:
                    return "5 -Inch Floppy Disk";
                case 2:
                    return "3 -Inch Floppy Disk";
                case 3:
                    return "3 -Inch Floppy Disk";
                case 4:
                    return "3 -Inch Floppy Disk";
                case 5:
                    return "3 -Inch Floppy Disk";
                case 6:
                    return "5 -Inch Floppy Disk";
                case 7:
                    return "5 -Inch Floppy Disk";
                case 8:
                    return "5 -Inch Floppy Disk";
                case 9:
                    return "5 -Inch Floppy Disk";
                case 10:
                    return "5 -Inch Floppy Disk";
                case 11:
                    return "Removable media other than floppy";
                case 12:
                    return "Fixed hard disk media";
                case 13:
                    return "3 -Inch Floppy Disk";
                case 14:
                    return "3 -Inch Floppy Disk";
                case 15:
                    return "5 -Inch Floppy Disk";
                case 16:
                    return "5 -Inch Floppy Disk";
                case 17:
                    return "3 -Inch Floppy Disk";
                case 18:
                    return "3 -Inch Floppy Disk";
                case 19:
                    return "5 -Inch Floppy Disk";
                case 20:
                    return "3 -Inch Floppy Disk";
                case 21:
                    return "3 -Inch Floppy Disk";
                case 22:
                    return "8-Inch Floppy Disk";
                default:
                    return "Unknown";
            }
        }
    }
}
