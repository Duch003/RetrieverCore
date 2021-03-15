
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_CIMLogicalDeviceCIMDataFile
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public string Dependent { get; set; }
        public UInt16 Purpose { get; set; }
        public string PurposeDescription { get; set; }

    }
}