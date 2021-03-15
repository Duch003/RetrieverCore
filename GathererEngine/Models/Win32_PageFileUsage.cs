
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_PageFileUsage
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 AllocatedBaseSize { get; set; }
        public string Caption { get; set; }
        public UInt32 CurrentUsage { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public UInt32 PeakUsage { get; set; }
        public string Status { get; set; }
        public bool TempPageFile { get; set; }

    }
}