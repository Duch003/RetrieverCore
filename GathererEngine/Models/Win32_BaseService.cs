
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_BaseService
    {
        public const string Scope = WmiScope.Cimv2;
        public bool AcceptPause { get; set; }
        public bool AcceptStop { get; set; }
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string Description { get; set; }
        public bool DesktopInteract { get; set; }
        public string DisplayName { get; set; }
        public string ErrorControl { get; set; }
        public UInt32 ExitCode { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string PathName { get; set; }
        public UInt32 ServiceSpecificExitCode { get; set; }
        public string ServiceType { get; set; }
        public bool Started { get; set; }
        public string StartMode { get; set; }
        public string StartName { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt32 TagId { get; set; }

    }
}