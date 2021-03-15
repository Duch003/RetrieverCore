using System;

namespace GathererEngine.Decoders
{
    public class ConnectorTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 0:
                default:
                    return "Unknown";
                case 1:
                    return "Other";
                case 2:
                    return "Male";
                case 3:
                    return "Female";
                case 4:
                    return "Shielded";
                case 5:
                    return "Unshielded";
                case 6:
                    return "SCSI (A) High-Density (50 pins)";
                case 7:
                    return "SCSI (A) Low-Density (50 pins)";
                case 8:
                    return "SCSI (P) High-Density (68 pins)";
                case 9:
                    return "SCSI SCA-I (80 pins)";
                case 10:
                    return "SCSI SCA-II (80 pins)";
                case 11:
                    return "SCSI Fibre Channel (DB-9, Copper)";
                case 12:
                    return "SCSI Fibre Channel (Fibre)";
                case 13:
                    return "SCSI Fibre Channel SCA-II (40 pins)";
                case 14:
                    return "SCSI Fibre Channel SCA-II (20 pins)";
                case 15:
                    return "SCSI Fibre Channel BNC";
                case 16:
                    return "ATA 3-1/2 Inch (40 pins)";
                case 17:
                    return "ATA 2-1/2 Inch (44 pins)";
                case 18:
                    return "ATA-2";
                case 19:
                    return "ATA-3";
                case 20:
                    return "ATA/66";
                case 21:
                    return "DB-9";
                case 22:
                    return "DB-15";
                case 23:
                    return "DB-25";
                case 24:
                    return "DB-36";
                case 25:
                    return "RS-232C";
                case 26:
                    return "RS-422";
                case 27:
                    return "RS-423";
                case 28:
                    return "RS-485";
                case 29:
                    return "RS-449";
                case 30:
                    return "V.35";
                case 31:
                    return "X.21";
                case 32:
                    return "IEEE-488";
                case 33:
                    return "AUI";
                case 34:
                    return "UTP Category 3";
                case 35:
                    return "UTP Category 4";
                case 36:
                    return "UTP Category 5";
                case 37:
                    return "BNC";
                case 38:
                    return "RJ11";
                case 39:
                    return "RJ45";
                case 40:
                    return "Fiber MIC";
                case 41:
                    return "Apple AUI";
                case 42:
                    return "Apple GeoPort";
                case 43:
                    return "PCI";
                case 44:
                    return "ISA";
                case 45:
                    return "EISA";
                case 46:
                    return "VESA";
                case 47:
                    return "PCMCIA";
                case 48:
                    return "PCMCIA Type I";
                case 49:
                    return "PCMCIA Type II";
                case 50:
                    return "PCMCIA Type III";
                case 51:
                    return "ZV Port";
                case 52:
                    return "CardBus";
                case 53:
                    return "USB";
                case 54:
                    return "IEEE 1394";
                case 55:
                    return "HIPPI";
                case 56:
                    return "HSSDC (6 pins)";
                case 57:
                    return "GBIC";
                case 58:
                    return "DIN";
                case 59:
                    return "Mini-DIN";
                case 60:
                    return "Micro-DIN";
                case 61:
                    return "PS/2";
                case 62:
                    return "Infrared";
                case 63:
                    return "HP-HIL";
                case 64:
                    return "Access.bus";
                case 65:
                    return "NuBus";
                case 66:
                    return "Centronics";
                case 67:
                    return "Mini-Centronics";
                case 68:
                    return "Mini-Centronics Type-14";
                case 69:
                    return "Mini-Centronics Type-20";
                case 70:
                    return "Mini-Centronics Type-26";
                case 71:
                    return "Bus Mouse";
                case 72:
                    return "ADB";
                case 73:
                    return "AGP";
                case 74:
                    return "VME Bus";
                case 75:
                    return "VME64";
                case 76:
                    return "Proprietary";
                case 77:
                    return "Proprietary Processor Card Slot";
                case 78:
                    return "Proprietary Memory Card Slot";
                case 79:
                    return "Proprietary I/O Riser Slot";
                case 80:
                    return "PCI-66MHZ";
                case 81:
                    return "AGP2X";
                case 82:
                    return "AGP4X";
                case 83:
                    return "PC-98";
                case 84:
                    return "PC-98Hireso";
                case 85:
                    return "PC-H98";
                case 86:
                    return "PC-98Note";
                case 87:
                    return "PC-98Full";
                case 88:
                    return "Mini-Jack";
                case 89:
                    return "On Board Floppy";
                case 90:
                    return "9 Pin Dual Inline (pin 10 cut)";
                case 91:
                    return "25 Pin Dual Inline (pin 26 cut)";
                case 92:
                    return "50 Pin Dual Inline";
                case 93:
                    return "68 Pin Dual Inline";
                case 94:
                    return "On Board Sound Input from CD-ROM";
                case 95:
                    return "68 Pin Dual Inline";
                case 96:
                    return "On Board Sound Connector";
                case 97:
                    return "Mini-Jack";
                case 98:
                    return "PCI-X";
                case 99:
                    return "Sbus IEEE 1396-1993 32 Bit";
                case 100:
                    return "Sbus IEEE 1396-1993 64 Bit";
                case 101:
                    return "MCA";
                case 102:
                    return "GIO";
                case 103:
                    return "XIO";
                case 104:
                    return "HIO";
                case 105:
                    return "NGIO";
                case 106:
                    return "PMC";
                case 107:
                    return "MTRJ";
                case 108:
                    return "VF-45";
                case 109:
                    return "Future I/O";
                case 110:
                    return "SC";
                case 111:
                    return "SG";
                case 112:
                    return "Electrical";
                case 113:
                    return "Optical";
                case 114:
                    return "Ribbon";
                case 115:
                    return "GLM";
                case 116:
                    return "1x9";
                case 117:
                    return "Mini SG";
                case 118:
                    return "LC";
                case 119:
                    return "HSSC";
                case 120:
                    return "VHDCI Shielded (68 pins)";
                case 121:
                    return "InfiniBand";
            }
        }
    }
}
