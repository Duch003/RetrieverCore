
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class WmiMonitorBasicDisplayParams
    {
        public const string Scope = WmiScope.Wmi;
        public bool Active { get; set; }
        public byte DisplayTransferCharacteristic { get; set; }
        public string InstanceName { get; set; }
        public byte MaxHorizontalImageSize { get; set; }
        public byte MaxVerticalImageSize { get; set; }
        public object SupportedDisplayFeatures { get; set; }
        public byte VideoInputType { get; set; }

    }
}