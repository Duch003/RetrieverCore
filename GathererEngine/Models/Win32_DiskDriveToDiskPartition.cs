
using GathererEngine.Attributes;
using GathererEngine.Constants;

namespace GathererEngine.Models
{
    public class Win32_DiskDriveToDiskPartition
    {
        public const string Scope = WmiScope.Cimv2;
        [Use]
        public string Antecedent { get; set; }
        [Use]
        public string Dependent { get; set; }

    }
}