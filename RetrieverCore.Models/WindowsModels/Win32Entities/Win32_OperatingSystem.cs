using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class Win32_OperatingSystem
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f'" +
            " AND PartialProductKey != null";
        public string Caption { get; set; }
        public string BuildNumber { get; set; }
        public DateTime InstallDate { get; set; }
        public string OSArchitecture { get; set; }
    }
}
