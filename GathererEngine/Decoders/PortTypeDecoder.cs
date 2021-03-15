using System;

namespace GathererEngine.Decoders
{
    public class PortTypeDecoder
    {
        public static string Decode(UInt16 type)
        {
            switch (type)
            {
                case 0:
                    return "None";
                case 1:
                    return "Parallel Port XT/AT Compatible";
                case 2:
                    return "Parallel Port PS/2";
                case 3:
                    return "Parallel Port ECP";
                case 4:
                    return "Parallel Port EPP";
                case 5:
                    return "Parallel Port ECP/EPP";
                case 6:
                    return "Serial Port XT/AT Compatible";
                case 7:
                    return "Serial Port 16450 Compatible";
                case 8:
                    return "Serial Port 16550 Compatible";
                case 9:
                    return "Serial Port 16550A Compatible";
                case 10:
                    return "SCSI Port";
                case 11:
                    return "MIDI Port";
                case 12:
                    return "Joy Stick Port";
                case 13:
                    return "Keyboard Port";
                case 14:
                    return "Mouse Port";
                case 15:
                    return "SSA SCSI";
                case 16:
                    return "USB";
                case 17:
                    return "FireWire (IEEE P1394)";
                case 18:
                    return "PCMCIA Type II";
                case 19:
                    return "PCMCIA Type II";
                case 20:
                    return "PCMCIA Type III";
                case 21:
                    return "Cardbus";
                case 22:
                    return "Access Bus Port";
                case 23:
                    return "SCSI II";
                case 24:
                    return "SCSI Wide";
                case 25:
                    return "PC-98";
                case 26:
                    return "PC-98-Hireso";
                case 27:
                    return "PC-H98";
                case 28:
                    return "Video Port";
                case 29:
                    return "Audio Port";
                case 30:
                    return "Modem Port";
                case 31:
                    return "Network Port";
                case 32:
                    return "8251 Compatible";
                case 33:
                    return "8251 FIFO Compatible";
                default:
                    return "Unknown";
            }
        }
    }
}
