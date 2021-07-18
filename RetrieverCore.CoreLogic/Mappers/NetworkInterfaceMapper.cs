using RetrieverCore.Models.WMIEntieties;
using System;
using System.Text;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class NetworkInterfaceMapper
    {
        public static Databases.RetrieverCore.Common.Models.NetworkInterface From(System.Net.NetworkInformation.NetworkInterface networkInterface, 
            Win32_NetworkAdapter win32NetworkAdapter)
        {
            var output = new Databases.RetrieverCore.Common.Models.NetworkInterface();
            output.AdapterType = win32NetworkAdapter.AdapterType;
            output.Caption = win32NetworkAdapter.Caption;
            output.GUID = string.IsNullOrWhiteSpace(networkInterface?.Id) ? null : Guid.Parse(networkInterface.Id);
            output.ProductName = win32NetworkAdapter.ProductName;
            output.NetworkInterfaceType = networkInterface?.NetworkInterfaceType 
                ?? System.Net.NetworkInformation.NetworkInterfaceType.Unknown;
            var mac = networkInterface?.GetPhysicalAddress().GetAddressBytes();
            output.MAC = mac == null || mac.Length == 0 ? null : Encoding.ASCII.GetString(mac);

            return output;
        }
    }
}
