
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_QuickFixEngineering
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public string FixComments { get; set; }
        public string HotFixID { get; set; }
        public DateTime InstallDate { get; set; }
        public string InstalledBy { get; set; }
        public string InstalledOn { get; set; }
        public string Name { get; set; }
        public string ServicePackInEffect { get; set; }
        public string Status { get; set; }

    }
}