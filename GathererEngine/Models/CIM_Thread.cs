
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_Thread
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CreationClassName { get; set; }
        public string CSCreationClassName { get; set; }
        public string CSName { get; set; }
        public string Description { get; set; }
        public UInt64 ElapsedTime { get; set; }
        public UInt16 ExecutionState { get; set; }
        public string Handle { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt64 KernelModeTime { get; set; }
        public string Name { get; set; }
        public string OSCreationClassName { get; set; }
        public string OSName { get; set; }
        public UInt32 Priority { get; set; }
        public UInt32 PriorityBase { get; set; }
        public string ProcessCreationClassName { get; set; }
        public string ProcessHandle { get; set; }
        public UInt32 StartAddress { get; set; }
        public string Status { get; set; }
        public UInt32 ThreadState { get; set; }
        public UInt32 ThreadWaitReason { get; set; }
        public UInt64 UserModeTime { get; set; }

    }
}