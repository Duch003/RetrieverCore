
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ImplementedCategory
    {
        public const string Scope = WmiScope.Cimv2;
        public string Category { get; set; }
        public string Component { get; set; }

    }
}