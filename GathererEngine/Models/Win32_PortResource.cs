using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PortResource
    {
        public const string Scope = WmiScope.Cimv2;
        public bool? Alias { get; set; }
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public UInt64? EndingAddress { get; set; }
        public DateTime? InstallDate { get; set; }
        public string Name { get; set; }
        public UInt64? StartingAddress { get; set; }
        public string Status { get; set; }
    }
}
