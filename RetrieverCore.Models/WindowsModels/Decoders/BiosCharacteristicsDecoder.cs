using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class BiosCharacteristicsDecoder
    {
        public static string Decode(UInt16 characteristic)
        {
            switch (characteristic)
            {
                case 0:
                case 1:
                    return "Reserved";
                case 2:
                    return "Unknown";
                case 3:
                    return "BIOS Characteristics Not Supported";
                case 4:
                    return "ISA is supported";
                case 5:
                    return "MCA is supported";
                case 6:
                    return "EISA is supported ";
                case 7:
                    return "PCI is supported ";
                case 8:
                    return "PC Card (PCMCIA) is supported ";
                case 9:
                    return "Plug and Play is supported ";
                case 10:
                    return "APM is supported ";
                case 11:
                    return "BIOS is Upgradeable (Flash) ";
                case 12:
                    return "BIOS shadowing is allowed ";
                case 13:
                    return "VL-VESA is supported ";
                case 14:
                    return "ESCD support is available ";
                case 15:
                    return "Boot from CD is supported ";
                case 16:
                    return "Selectable Boot is supported ";
                case 17:
                    return "BIOS ROM is socketed ";
                case 18:
                    return "Boot From PC Card (PCMCIA) is supported ";
                case 19:
                    return "EDD (Enhanced Disk Drive) Specification is supported ";
                case 20:
                    return "Int 13h - Japanese Floppy for NEC 9800 1.2mb (3.5\", 1k Bytes/Sector, 360 RPM) is supported ";
                case 21:
                    return "Int 13h - Japanese Floppy for Toshiba 1.2mb (3.5\", 360 RPM) is supported ";
                case 22:
                    return "Int 13h - 5.25\" / 360 KB Floppy Services are supported ";
                case 23:
                    return "Int 13h - 5.25\" /1.2MB Floppy Services are supported ";
                case 24:
                    return "Int 13h - 3.5\" / 720 KB Floppy Services are supported ";
                case 25:
                    return "Int 13h - 3.5\" / 2.88 MB Floppy Services are supported ";
                case 26:
                    return "Int 5h, Print Screen Service is supported ";
                case 27:
                    return "Int 9h, 8042 Keyboard services are supported ";
                case 28:
                    return "Int 14h, Serial Services are supported ";
                case 29:
                    return "Int 17h, printer services are supported ";
                case 30:
                    return "Int 10h, CGA/Mono Video Services are supported ";
                case 31:
                    return "NEC PC-98 ";
                case 32:
                    return "ACPI supported ";
                case 33:
                    return "USB Legacy is supported ";
                case 34:
                    return "AGP is supported ";
                case 35:
                    return "I2O boot is supported ";
                case 36:
                    return "LS-120 boot is supported ";
                case 37:
                    return "ATAPI ZIP Drive boot is supported ";
                case 38:
                    return "1394 boot is supported ";
                case 39:
                    return "Smart Battery supported ";
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                    return "Reserved for BIOS vendor";
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                case 63:
                case 64:
                    return "Reserved for system vendor";
                default: 
                    return "Unknown characteristic";
            }
        }
    }
}
