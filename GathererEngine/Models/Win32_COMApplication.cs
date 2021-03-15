
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_COMApplication
    {
        public const string Scope = WmiScope.Cimv2;
        public string AppID { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}