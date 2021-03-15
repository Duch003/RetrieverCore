
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_LogicalDiskBasedOnPartition
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public string Dependent { get; set; }
        public UInt64 EndingAddress { get; set; }
        public UInt64 StartingAddress { get; set; }

    }
}