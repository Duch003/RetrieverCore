using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_BaseBoard : WmiEntityBase
    {
        public Win32_BaseBoard() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string Manufacturer { get; set; }
        public string Product { get; set; }
        public string Version { get; set; }
    }
}
