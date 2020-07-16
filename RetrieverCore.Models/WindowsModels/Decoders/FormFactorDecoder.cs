using System;

namespace RetrieverCore.Models.WindowsModels.Decoders
{
    public class FormFactorDecoder
    {
        public static string Decode(UInt16 formFactor)
        {
            switch (formFactor)
            {
                case 0:
                default:
                    return "Unknown";
                case 1:
                    return "Other";
                case 2:
                    return "SIP";
                case 3:
                    return "DIP";
                case 4:
                    return "ZIP";
                case 5:
                    return "SOJ";
                case 6:
                    return "Proprietary";
                case 7:
                    return "SIMM";
                case 8:
                    return "DIMM";
                case 9:
                    return "TSOP";
                case 10:
                    return "PGA";
                case 11:
                    return "RIM";
                case 12:
                    return "SODIMM";
                case 13:
                    return "SRIMM";
                case 14:
                    return "SMD";
                case 15:
                    return "SSMP";
                case 16:
                    return "QFP";
                case 17:
                    return "TQFP";
                case 18:
                    return "SOIC";
                case 19:
                    return "LCC";
                case 20:
                    return "PLCC";
                case 21:
                    return "BGA";
                case 22:
                    return "FPBGA";
                case 23:
                    return "LGA";
            }
        }
    }
}
