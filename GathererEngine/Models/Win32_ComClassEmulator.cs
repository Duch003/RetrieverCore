
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ComClassEmulator
    {
        public const string Scope = WmiScope.Cimv2;
        public string NewVersion { get; set; }
        public string OldVersion { get; set; }

    }
}