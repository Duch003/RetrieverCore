
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_SerialPortSetting
    {
        public const string Scope = WmiScope.Cimv2;
        public string Element { get; set; }
        public string Setting { get; set; }

    }
}