
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_ProductSoftwareFeatures
    {
        public const string Scope = WmiScope.Cimv2;
        public string Component { get; set; }
        public string Product { get; set; }

    }
}