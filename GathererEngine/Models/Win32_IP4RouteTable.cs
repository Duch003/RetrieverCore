
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_IP4RouteTable
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32 Age { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string Destination { get; set; }
        public string Information { get; set; }
        public DateTime InstallDate { get; set; }
        public Int32 InterfaceIndex { get; set; }
        public string Mask { get; set; }
        public Int32 Metric1 { get; set; }
        public Int32 Metric2 { get; set; }
        public Int32 Metric3 { get; set; }
        public Int32 Metric4 { get; set; }
        public Int32 Metric5 { get; set; }
        public string Name { get; set; }
        public string NextHop { get; set; }
        public UInt32 Protocol { get; set; }
        public string Status { get; set; }
        public UInt32 Type { get; set; }

    }
}