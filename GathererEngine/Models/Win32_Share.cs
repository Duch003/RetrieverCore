
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Share
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 AccessMask { get; set; }
        public bool AllowMaximum { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 MaximumAllowed { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Status { get; set; }
        public UInt32 Type { get; set; }

    }
}