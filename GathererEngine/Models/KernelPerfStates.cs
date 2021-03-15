
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class KernelPerfStates
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public UInt16 BusyAdjThreshold { get; set; }
        public UInt32 Count { get; set; }
        public UInt32 CurrentState { get; set; }
        public UInt32 FeedbackHandler { get; set; }
        public string InstanceName { get; set; }
        public UInt32 LowestPerfState { get; set; }
        public UInt32 MaxFrequency { get; set; }
        public UInt32 MaxPerfState { get; set; }
        public UInt32 MinPerfState { get; set; }
        public byte PolicyType { get; set; }
        public UInt32 PStateContext { get; set; }
        public UInt32 PStateHandler { get; set; }
        public byte Reserved { get; set; }
        public UInt32 Reserved1 { get; set; }
        public UInt64 Reserved2 { get; set; }
        public object State { get; set; }
        public UInt64 TargetProcessors { get; set; }
        public UInt32 ThermalConstraint { get; set; }
        public UInt32 TimerInterval { get; set; }
        public UInt32 TStateContext { get; set; }
        public UInt32 TStateHandler { get; set; }
        public byte Type { get; set; }

    }
}