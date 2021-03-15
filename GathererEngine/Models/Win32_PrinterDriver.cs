
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_PrinterDriver
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string ConfigFile { get; set; }
        public string CreationClassName { get; set; }
        public string DataFile { get; set; }
        public string DefaultDataType { get; set; }
        public string DependentFiles { get; set; }
        public string Description { get; set; }
        public string DriverPath { get; set; }
        public string FilePath { get; set; }
        public string HelpFile { get; set; }
        public string InfName { get; set; }
        public DateTime InstallDate { get; set; }
        public string MonitorName { get; set; }
        public string Name { get; set; }
        public string OEMUrl { get; set; }
        public bool Started { get; set; }
        public string StartMode { get; set; }
        public string Status { get; set; }
        public string SupportedPlatform { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public UInt16 Version { get; set; }

    }
}