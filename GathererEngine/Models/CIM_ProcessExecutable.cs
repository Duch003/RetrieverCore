
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_ProcessExecutable
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public UInt64 BaseAddress { get; set; }
        public string Dependent { get; set; }
        public UInt32 GlobalProcessCount { get; set; }
        public UInt32 ModuleInstance { get; set; }
        public UInt32 ProcessCount { get; set; }

    }
}