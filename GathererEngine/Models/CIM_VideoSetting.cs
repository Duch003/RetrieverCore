using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_VideoSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string Element { get; set; }
        public string Setting { get; set; }
    }
}
