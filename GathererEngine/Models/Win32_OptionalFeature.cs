
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_OptionalFeature
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 InstallState { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}