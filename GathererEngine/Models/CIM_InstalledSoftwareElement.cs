
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_InstalledSoftwareElement
    {
        public const string Scope = WmiScope.Cimv2;
        public string Software { get; set; }
        public string System { get; set; }

    }
}