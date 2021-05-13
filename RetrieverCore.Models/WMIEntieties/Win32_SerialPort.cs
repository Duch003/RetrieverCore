using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_SerialPort : WmiEntityBase
    {
        public Win32_SerialPort() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string Caption { get; set; }
        public string DeviceID { get; set; }
        public string Name { get; set; }
        public string ProviderType { get; set; }
    }
}
