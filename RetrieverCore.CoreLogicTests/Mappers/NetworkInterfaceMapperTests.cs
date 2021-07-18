using RetrieverCore.CoreLogic.Mappers;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Text;
using Tests.RetrieverCore.Common.Implementations;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Mappers
{
    public class NetworkInterfaceMapperTests
    {
        [Fact]
        public void From_AllParametersAreValid_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = "Caption",
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_IdIsDiggerentFromGuid_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('1', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = "Caption",
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_AdapterTypeIsEmpty_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = string.Empty,
                Caption = "Caption",
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_AdapterTypeIsNull_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = null,
                Caption = "Caption",
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.Null(result.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_CaptionIsEmpty_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = string.Empty,
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_CaptionIsNull_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = null,
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_ProductTypeIsEmpty_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = "Caption",
                ProductName = string.Empty,
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_ProductNameIsNull_ReturnsNetworkInterface()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = "Caption",
                ProductName = null,
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == Guid.Parse(networkInterface.Id));
            Assert.True(result.NetworkInterfaceType == networkInterface.NetworkInterfaceType);
            Assert.True(result.MAC == "FC-11-69-CB-BF-9E");
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_NetworkInterfaceIsNull_ReturnsNetworkInterface()
        {
            //Arrange
            FakeNetworkInterface networkInterface = null;
            var win32NetworkAdapter = new Win32_NetworkAdapter
            {
                AdapterType = "AdapterType",
                Caption = "Caption",
                ProductName = "ProductName",
                GUID = new Guid(new string('0', 32)).ToString()
            };

            //Act
            var result = NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter);

            //Asert
            Assert.NotNull(result);
            Assert.True(result.GUID == null);
            Assert.True(result.NetworkInterfaceType == System.Net.NetworkInformation.NetworkInterfaceType.Unknown);
            Assert.True(result.MAC == null);
            Assert.True(result.AdapterType == win32NetworkAdapter.AdapterType);
            Assert.True(result.Caption == win32NetworkAdapter.Caption);
            Assert.True(result.ProductName == win32NetworkAdapter.ProductName);
        }

        [Fact]
        public void From_Win32NetworkAdapterIsNull_ThrowsNullReferenceException()
        {
            //Arrange
            var networkInterface = new FakeNetworkInterface
            {
                IdToReturn = new Guid(new string('0', 32)).ToString(),
                NetworkInterfaceTypeToReturn = System.Net.NetworkInformation.NetworkInterfaceType.Ethernet,
                MAC = "FC-11-69-CB-BF-9E"
            };
            Win32_NetworkAdapter win32NetworkAdapter = null;

            //Act
            //Asert
            Assert.Throws<NullReferenceException>(() => NetworkInterfaceMapper.From(networkInterface, win32NetworkAdapter));
        }
    }
}
