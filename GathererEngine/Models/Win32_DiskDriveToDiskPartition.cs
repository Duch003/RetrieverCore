using GathererEngine.Constants;

namespace GathererEngine.Models
{
    public class Win32_DiskDriveToDiskPartition
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public string Dependent { get; set; }

    }
}