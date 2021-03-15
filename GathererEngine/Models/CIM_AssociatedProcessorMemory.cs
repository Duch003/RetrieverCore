
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_AssociatedProcessorMemory
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public UInt32 BusSpeed { get; set; }
        public string Dependent { get; set; }

    }
}