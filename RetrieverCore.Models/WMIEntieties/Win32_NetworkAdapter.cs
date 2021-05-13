using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_NetworkAdapter : WmiEntityBase
    {
        public Win32_NetworkAdapter() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string AdapterType { get; set; }
        public string Caption { get; set; }
        public string GUID { get; set; }
        public string ProductName { get; set; }
    }
}
