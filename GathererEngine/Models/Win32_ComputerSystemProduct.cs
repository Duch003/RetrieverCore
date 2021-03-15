
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ComputerSystemProduct
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