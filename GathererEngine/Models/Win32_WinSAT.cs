
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_WinSAT
    {
        public const string Scope = WmiScope.Cimv2;
        public float CPUScore { get; set; }
        public float D3DScore { get; set; }
        public float DiskScore { get; set; }
        public float GraphicsScore { get; set; }
        public float MemoryScore { get; set; }
        public string TimeTaken { get; set; }
        public UInt32 WinSATAssessmentState { get; set; }
        public float WinSPRLevel { get; set; }

    }
}