using RetrieverCore.Models.WindowsModels.Constants;
using System;

namespace RetrieverCore.Models.WindowsModels.Win32Entities
{
    public class SoftwareLicensingProduct
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f' " +
            "AND PartialProductKey != null";
        public UInt32 LicenseStatus { get; set; }
    }
}
