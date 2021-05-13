using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_Product
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Description { get; set; }
        public string IdentifyingNumber { get; set; }
        public string Name { get; set; }
        public string SKUNumber { get; set; }
        public string UUID { get; set; }
        public string Vendor { get; set; }
        public string Version { get; set; }
    }
}
