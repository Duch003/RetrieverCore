
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_FolderRedirectionHealthConfiguration
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 LastSyncDurationCautionInHours { get; set; }
        public UInt32 LastSyncDurationUnhealthyInHours { get; set; }

    }
}