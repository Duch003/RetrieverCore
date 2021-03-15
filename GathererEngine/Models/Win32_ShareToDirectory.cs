
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ShareToDirectory
    {
        public const string Scope = WmiScope.Cimv2;
        public string Share { get; set; }
        public string SharedElement { get; set; }

    }
}