using RetrieverCore.Models.WMIEntieties;
using System;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class NetworkInterfaceMapper
    {
        public static Common.Models.NetworkInterface From(System.Net.NetworkInformation.NetworkInterface networkInterface, 
            Win32_NetworkAdapter win32NetworkAdapter)
        {
            var output = new Common.Models.NetworkInterface();
            output.AdapterType = win32NetworkAdapter.AdapterType;
            output.Caption = win32NetworkAdapter.Caption;
            output.GUID = string.IsNullOrWhiteSpace(networkInterface?.Id) ? null : Guid.Parse(networkInterface.Id);
            output.ProductName = win32NetworkAdapter.ProductName;
            output.NetworkInterfaceType = networkInterface?.NetworkInterfaceType 
                ?? System.Net.NetworkInformation.NetworkInterfaceType.Unknown;
            output.MAC = networkInterface?.GetPhysicalAddress()?.ToString();

            return output;
        }
    }
}
