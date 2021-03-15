using GathererEngine.Models;
using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.TestDataGenerator.BuildInLibraries;
using RetrieverCore.TestDataGenerator.Database;
using RetrieverCore.TestDataGenerator.WindowsEntieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class NetworkInterfaceServiceTests
    {
        private INetworkInterfaceService _service;
        private List<Win32_NetworkAdapter> _win32_NetworkAdapterEntries = Win32_NetworkAdapterFactory.GetForNetworkInterfaceServiceTests();
        private List<NetworkInterface> _networkInterfaces = NetworkInterfaceFactory.GetForNetworkInterfaceServiceTests();
        private List<NetworkInterfaceEntity> _databaseEntieties = NetworkInterfaceEntityFactory.GetForNetworkInterfaceServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException_NetworkAdapters = false;
        private bool _noData_NetworkAdapters = false;
        private bool _throwException_NetworkInterfaces = false;
        private bool _noData_NetworkInterfaces = false;


        public NetworkInterfaceServiceTests()
        {
            var mockNetworkInterfaceRepository = new Mock<INetworkInterfaceRepository>();

            mockNetworkInterfaceRepository.Setup(p => p.GetDesignedNetworkInterfacesAsync(_model0))
                .Returns(Task.FromResult(_databaseEntieties.AsEnumerable()));
            mockNetworkInterfaceRepository.Setup(p => p.GetDesignedNetworkInterfacesAsync(_nonExistingModel))
                .Returns(Task.FromResult((IEnumerable<NetworkInterfaceEntity>)null));
            mockNetworkInterfaceRepository.Setup(p => p.GetDesignedNetworkInterfacesAsync(_errorModel))
                .Throws(new Exception());
            mockNetworkInterfaceRepository.Setup(p => p.GetPhysicalNetworkInterfacesAsync())
                .Returns(() =>
                {
                    if (_throwException_NetworkInterfaces)
                    {
                        throw new Exception();
                    }
                    if (_noData_NetworkInterfaces)
                    {
                        return Task.FromResult(new List<NetworkInterface>().AsEnumerable());
                    }
                    return Task.FromResult(_networkInterfaces.AsEnumerable());
                });
            mockNetworkInterfaceRepository.Setup(p => p.GetWin32NetworkAdaptersAsync())
                .Returns(() =>
                {
                    if (_throwException_NetworkAdapters)
                    {
                        throw new Exception();
                    }
                    if (_noData_NetworkAdapters)
                    {
                        return Task.FromResult(new List<Win32_NetworkAdapter>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_NetworkAdapterEntries.AsEnumerable());
                });

            _service = new NetworkInterfaceService(mockNetworkInterfaceRepository.Object);
        }

        [Fact]
        public async Task GetDesignedNetworkInterfacesAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedNetworkInterfacesAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _databaseEntieties.Count);
        }

        [Fact]
        public async Task GetDesignedNetworkInterfacesAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedNetworkInterfacesAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedNetworkInterfacesAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedNetworkInterfacesAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_EverythingWorkFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetPhysicalNetworkInterfacesAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException_NetworkInterfaces = true;

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _throwException_NetworkInterfaces = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetPhysicalNetworkInterfacesAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData_NetworkInterfaces = true;

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _noData_NetworkInterfaces = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalNetworkInterfacesAsync')", result.Exception.Message);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetPhysicalNetworkInterfacesAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            var nullRecord = (NetworkInterface)null;
            _networkInterfaces.Add(nullRecord);

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _networkInterfaces.Remove(nullRecord);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetWin32NetworkAdaptersAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException_NetworkAdapters = true;

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _throwException_NetworkAdapters = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetWin32NetworkAdaptersAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData_NetworkAdapters = true;

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _noData_NetworkAdapters = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalNetworkInterfacesAsync')", result.Exception.Message);
        }

        [Fact]
        public async Task GetPhysicalNetworkInterfacesAsync_GetWin32NetworkAdaptersAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            var nullRecord = (Win32_NetworkAdapter)null;
            _win32_NetworkAdapterEntries.Add(nullRecord);

            //Act
            var result = await _service.GetPhysicalNetworkInterfacesAsync();
            _win32_NetworkAdapterEntries.Remove(nullRecord);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }
    }
}
