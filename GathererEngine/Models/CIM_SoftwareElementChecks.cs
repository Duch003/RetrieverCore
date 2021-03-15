
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_SoftwareElementChecks
    {
        public const string Scope = WmiScope.Cimv2;
        public string Check { get; set; }
        public string Element { get; set; }
        public UInt16 Phase { get; set; }

    }
}