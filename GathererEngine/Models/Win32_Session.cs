
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_Session
    {
        public const string Scope = WmiScope.Cimv2;
        public string AuthenticationPackage { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string LogonId { get; set; }
        public UInt32 LogonType { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }

    }
}