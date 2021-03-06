
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Group
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public DateTime InstallDate { get; set; }
        public bool LocalAccount { get; set; }
        public string Name { get; set; }
        public string SID { get; set; }
        public byte SIDType { get; set; }
        public string Status { get; set; }

    }
}