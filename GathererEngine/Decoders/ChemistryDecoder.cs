using System;

namespace GathererEngine.Decoders
{
    public class ChemistryDecoder
    {
        public static string Decode(UInt16 chemistry)
        {
            switch (chemistry)
            {
                case 1:
                    return "Other";
                case 2:
                    return "Unknown ";
                case 3:
                    return "Lead Acid";
                case 4:
                    return "Nickel Cadmium";
                case 5:
                    return "Nickel Metal Hydride";
                case 6:
                    return "Lithium-ion";
                case 7:
                    return "Zinc air";
                case 8:
                    return "Lithium Polymer";
                default:
                    return "Unknown chemistry";
            }
        }
    }
}
