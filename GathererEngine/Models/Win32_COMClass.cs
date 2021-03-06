
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_COMClass
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string ComponentId { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}