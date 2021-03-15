
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_SystemDevices
    {
        public const string Scope = WmiScope.Cimv2;
        public string GroupComponent { get; set; }
        public string PartComponent { get; set; }

    }
}