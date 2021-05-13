using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_PnPDevice
    {
        public const string Scope = WmiScope.Cimv2;
        public string SameElement { get; set; }
        public string SystemElement { get; set; }
    }
}
