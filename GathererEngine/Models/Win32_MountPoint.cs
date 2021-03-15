
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_MountPoint
    {
        public const string Scope = WmiScope.Cimv2;
        public string Directory { get; set; }
        public string Volume { get; set; }

    }
}