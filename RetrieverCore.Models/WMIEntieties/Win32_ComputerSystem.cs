using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_ComputerSystem : WmiEntityBase
    {
        public Win32_ComputerSystem() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string Manufacturer { get; set; }
        public string[] OEMStringArray { get; set; }
        public string Model { get; set; }
    }
}
