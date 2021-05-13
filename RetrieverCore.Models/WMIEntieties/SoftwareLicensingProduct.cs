using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class SoftwareLicensingProduct : WmiEntityBase
    {
        public const string Conditions = "ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f' AND PartialProductKey != null";
        public SoftwareLicensingProduct() : base()
        {
            Scope = WmiScope.Cimv2;
        }

        public UInt32? LicenseStatus { get; set; }
    }
}
