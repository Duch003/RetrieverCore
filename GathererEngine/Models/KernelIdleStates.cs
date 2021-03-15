
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class KernelIdleStates
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public UInt32 Count { get; set; }
        public string InstanceName { get; set; }
        public UInt32 OldState { get; set; }
        public object State { get; set; }
        public UInt64 TargetProcessors { get; set; }
        public UInt32 TargetState { get; set; }
        public UInt32 Type { get; set; }

    }
}