using GathererEngine.Models;
using RetrieverCore.Models.Common.Win32Entieties;
using System;
using System.Net.NetworkInformation;

namespace RetrieverCore.Extensions
{
    public static class CommonNetworkInterfaceExtension
    {
        public static CommonNetworkInterface ToCommon(this Win32_NetworkAdapter networkAdapter, NetworkInterface networkInterface)
        {
            return Map(networkInterface, networkAdapter);
        }

        public static CommonNetworkInterface ToCommon(this NetworkInterface networkInterface, Win32_NetworkAdapter networkAdapter)
        {
            return Map(networkInterface, networkAdapter);
        }

        private static CommonNetworkInterface Map(NetworkInterface networkInterface, Win32_NetworkAdapter networkAdapter)
        {
            if (networkAdapter == null)
            {
                return null;
            }

            if(networkInterface != null && networkAdapter.GUID != networkInterface.Id)
            {
                return null;
            }

            return new CommonNetworkInterface
            {
                AdapterType = networkAdapter.AdapterType,
                Caption = networkAdapter.Caption,
                GUID = string.IsNullOrWhiteSpace(networkInterface?.Id) ? null : Guid.Parse(networkInterface.Id),
                ProductName = networkAdapter.ProductName,
                NetworkInterfaceType = networkInterface?.NetworkInterfaceType ?? NetworkInterfaceType.Unknown,
                MAC = networkInterface?.GetPhysicalAddress()?.ToString()
            };
        }
    }
}
