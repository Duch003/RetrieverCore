
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_OfflineFilesCache
    {
        public const string Scope = WmiScope.Cimv2;
        public bool Active { get; set; }
        public bool Enabled { get; set; }
        public string Location { get; set; }

    }
}