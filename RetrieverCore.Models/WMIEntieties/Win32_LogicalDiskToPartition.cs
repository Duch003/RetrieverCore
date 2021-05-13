using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_LogicalDiskToPartition : WmiEntityBase
    {
        public Win32_LogicalDiskToPartition() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string Antecedent { get; set; }
        public string Dependent { get; set; }
    }
}