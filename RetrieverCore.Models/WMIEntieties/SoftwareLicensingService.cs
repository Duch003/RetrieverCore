using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class SoftwareLicensingService : WmiEntityBase
    {
        public SoftwareLicensingService() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string OA3xOriginalProductKey { get; set; }
    
    }
}
