
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Registry
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public UInt32 CurrentSize { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 MaximumSize { get; set; }
        public string Name { get; set; }
        public UInt32 ProposedSize { get; set; }
        public string Status { get; set; }

    }
}