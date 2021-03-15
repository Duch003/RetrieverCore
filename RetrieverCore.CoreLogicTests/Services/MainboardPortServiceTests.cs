using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using RetrieverCore.TestDataGenerator.Database;
using RetrieverCore.TestDataGenerator.WindowsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class MainboardPortServiceTests
    {
        private IMainboardPortService _service;
        private List<Win32_PortConnector> _win32_PortConnectorEntries = Win32_PortConnectorFactory.GetForMainboardPortsServiceTests();
        private List<Win32_SerialPort> _win32_SerialPortEntries = Win32_SerialPortFactory.GetForMainboardPortServiceTests();
        private List<MainboardPortEntity> _databaseEntieties = MainboardPortEntityFactory.GetForMainboardPortServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException_PortConnectors = false;
        private bool _noData_PortConnectors = false;
        private bool _throwException_SerialPorts = false;
        private bool _noData_SerialPorts = false;

        public MainboardPortServiceTests()
        {
            var mockMainboardPortRepository = new Mock<IMainboardPortRepository>();

            mockMainboardPortRepository.Setup(p => p.GetDesignedMainboardPortsAsync(_model0))
                .Returns(Task.FromResult(_databaseEntieties.AsEnumerable()));
            mockMainboardPortRepository.Setup(p => p.GetDesignedMainboardPortsAsync(_nonExistingModel))
                .Returns(Task.FromResult((IEnumerable<MainboardPortEntity>)null));
            mockMainboardPortRepository.Setup(p => p.GetDesignedMainboardPortsAsync(_errorModel))
                .Throws(new Exception());
            mockMainboardPortRepository.Setup(p => p.GetWin32PortConnectorsAsync())
                .Returns(() =>
                {
                    if (_throwException_PortConnectors)
                    {
                        throw new Exception();
                    }
                    if (_noData_PortConnectors)
                    {
                        return Task.FromResult(new List<Win32_PortConnector>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_PortConnectorEntries.AsEnumerable());
                });
            mockMainboardPortRepository.Setup(p => p.GetWin32SerialPortsAsync())
                .Returns(() =>
                {
                    if (_throwException_SerialPorts)
                    {
                        throw new Exception();
                    }
                    if (_noData_SerialPorts)
                    {
                        return Task.FromResult(new List<Win32_SerialPort>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_SerialPortEntries.AsEnumerable());
                });

            _service = new MainboardPortService(mockMainboardPortRepository.Object);
        }

        [Fact]
        public async Task GetDesignedMainboardPortsAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardPortsAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _databaseEntieties.Count);
        }

        [Fact]
        public async Task GetDesignedMainboardPortsAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardPortsAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedMainboardPortsAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardPortsAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_EverythingWorkFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32PortConnectorsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException_PortConnectors = true;

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _throwException_PortConnectors = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32PortConnectorsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData_PortConnectors = true;

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _noData_PortConnectors = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalMainboardPortsAsync')", result.Exception.Message);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32PortConnectorsAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            var nullRecord = (Win32_PortConnector)null;
            _win32_PortConnectorEntries.Add(nullRecord);

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _win32_PortConnectorEntries.Remove(nullRecord);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32SerialPortsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException_SerialPorts = true;

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _throwException_SerialPorts = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32SerialPortsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData_SerialPorts = true;

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _noData_SerialPorts = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalMainboardPortsAsync')", result.Exception.Message);
        }

        [Fact]
        public async Task GetPhysicalMainboardPortsAsync_GetWin32SerialPortsAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            var nullRecord = (Win32_SerialPort)null;
            _win32_SerialPortEntries.Add(nullRecord);

            //Act
            var result = await _service.GetPhysicalMainboardPortsAsync();
            _win32_SerialPortEntries.Remove(nullRecord);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }
    }
}
