using GathererEngine.Models;
using RetrieverCore.Extensions;
using RetrieverCore.TestDataGenerator.BuildInLibraries;
using RetrieverCore.TestDataGenerator.WindowsEntieties;
using System;
using System.Net.NetworkInformation;
using Xunit;

namespace RetrieverCore.ExtensionsTests
{
    public class CommonNetworkInterfaceExtensionTests
    {
        private Win32_NetworkAdapter _networkAdapter = Win32_NetworkAdapterFactory.GetForWin32_CommonNetworkInterfaceExtensionTests();
        private NetworkInterface _networkInterface = NetworkInterfaceFactory.GetForWin32_CommonNetworkInterfaceExtensionTests();

        private Win32_NetworkAdapter _nullAdapter = null;
        private NetworkInterface _nullInterface = null;

        [Fact]
        public void ToCommon_Win32NetworkAdapter_AllInputsAreValid_ReturnsWin32CommonNetworkInterface()
        {
            //Arrange

            //Act
            var result = _networkAdapter.ToCommon(_networkInterface);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.AdapterType, _networkAdapter.AdapterType);
            Assert.Equal(result.Caption, _networkAdapter.Caption);
            Assert.Equal(result.GUID, Guid.Parse(_networkInterface.Id));
            Assert.Equal(result.ProductName, _networkAdapter.ProductName);
            Assert.Equal(result.NetworkInterfaceType, _networkInterface.NetworkInterfaceType);
            Assert.Equal(result.MAC, _networkInterface.GetPhysicalAddress()?.ToString());
        }

        [Fact]
        public void ToCommon_Win32NetworkAdapter_GuidsAreDifferent_ReturnsNull()
        {
            //Arrange
            var guid = _networkAdapter.GUID;
            _networkAdapter.GUID = Guid.NewGuid().ToString();

            //Act
            var result = _networkAdapter.ToCommon(_networkInterface);
            _networkAdapter.GUID = guid;

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCommon_Win32NetworkAdapter_Win32NetworkAdapterIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullAdapter.ToCommon(_networkInterface);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCommon_Win32NetworkAdapter_NetworkInterfaceIsNull_ReturnsWin32CommonNetworkInterface()
        {
            //Arrange

            //Act
            var result = _networkAdapter.ToCommon(_nullInterface);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.AdapterType, _networkAdapter.AdapterType);
            Assert.Equal(result.Caption, _networkAdapter.Caption);
            Assert.Null(result.GUID);
            Assert.Equal(result.ProductName, _networkAdapter.ProductName);
            Assert.Equal(NetworkInterfaceType.Unknown, result.NetworkInterfaceType);
            Assert.Null(result.MAC);
        }

        [Fact]
        public void ToCommon_Win32NetworkAdapter_BothInputsAreNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullAdapter.ToCommon(_nullInterface);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCommon_NetworkInterface_AllInputsAreValid_ReturnsWin32CommonNetworkInterface()
        {
            //Arrange

            //Act
            var result = _networkInterface.ToCommon(_networkAdapter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.AdapterType, _networkAdapter.AdapterType);
            Assert.Equal(result.Caption, _networkAdapter.Caption);
            Assert.Equal(result.GUID, Guid.Parse(_networkInterface.Id));
            Assert.Equal(result.ProductName, _networkAdapter.ProductName);
            Assert.Equal(result.NetworkInterfaceType, _networkInterface.NetworkInterfaceType);
            Assert.Equal(result.MAC, _networkInterface.GetPhysicalAddress()?.ToString());
        }

        [Fact]
        public void ToCommon_NetworkInterface_GuidsAreDifferent_ReturnsNull()
        {
            //Arrange
            var guid = _networkAdapter.GUID;
            _networkAdapter.GUID = Guid.NewGuid().ToString();

            //Act
            var result = _networkInterface.ToCommon(_networkAdapter);
            _networkAdapter.GUID = guid;

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCommon_NetworkInterface_Win32NetworkAdapterIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _networkInterface.ToCommon(_nullAdapter);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToCommon_NetworkInterface_NetworkInterfaceIsNull_ReturnsWin32CommonNetworkInterface()
        {
            //Arrange

            //Act
            var result = _nullInterface.ToCommon(_networkAdapter);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.AdapterType, _networkAdapter.AdapterType);
            Assert.Equal(result.Caption, _networkAdapter.Caption);
            Assert.Null(result.GUID);
            Assert.Equal(result.ProductName, _networkAdapter.ProductName);
            Assert.Equal(NetworkInterfaceType.Unknown, result.NetworkInterfaceType);
            Assert.Null(result.MAC);
        }

        [Fact]
        public void ToCommon_NetworkInterface_BothInputsAreNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullInterface.ToCommon(_nullAdapter);

            //Assert
            Assert.Null(result);
        }
    }
}
