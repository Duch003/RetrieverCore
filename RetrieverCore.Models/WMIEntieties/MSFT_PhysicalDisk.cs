using System;
using GathererEngine.Constants;
using RetrieverCore.Models.WMIEntieties.Base;

namespace RetrieverCore.Models.WMIEntieties
{
    public class MSFT_PhysicalDisk : WmiEntityBase
    {
        public MSFT_PhysicalDisk() : base()
        {
            Scope = WmiScope.Storage;
        }

        public UInt16? BusType { get; set; }
        public UInt16?[] CannotPoolReason { get; set; }
        public UInt16? MediaType { get; set; }
        public string Model { get; set; }
        public string[] OperationalDetails { get; set; }
        public UInt16?[] OperationalStatus { get; set; }
        public UInt16?[] SupportedUsages { get; set; }
       
    }
}
