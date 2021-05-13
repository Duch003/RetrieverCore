using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class Win32_DiskDriveToDiskPartition : WmiEntityBase
    {
        public Win32_DiskDriveToDiskPartition() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public string Antecedent { get; set; }
        public string Dependent { get; set; }
    }
}