using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Microsoft.Extensions.Configuration;
using RetrieverCore.Repositories.Interfaces;
using GathererEngine.Models;
using System.Linq;
using RetrieverCore.TestDataGenerator.WindowsEntities;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.TestDataGenerator.Database;
using System.Threading.Tasks;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;

namespace RetrieverCore.CoreLogicTests.Services
{
    
    public class BatteryServiceTests
    {
        private IConfiguration _configuration;
        private List<BatteryStaticData> _batteryStaticDataEntries = BatteryStaticDataFactory.GetForBatteryServiceTests();
        private List<BatteryFullChargedCapacity> _batteryFullChargedCapacityEntires 
            = BatteryFullChargedCapacityFactory.GetForBatteryServiceTests();
        private List<Win32_Battery> _win32_BatteryEntires
            = Win32_BatteryFactory.GetForBatteryServiceTests();
        private IEnumerable<BatteryEntity> _databaseEntieties = BatteryEntityFactory.GetForBatteryServiceTests();

        private string _model0 = "Model0";
        private string _model1 = "Model1";
        private string _errorModel = "Error";
        private Dictionary<string, bool> _exceptionSwitch;
        private Dictionary<string, bool> _dataSwitch;

        private IBatteryService _service;
        private IBatteryService _invalidConfigurationService;

        public BatteryServiceTests()
        {
            var configurationData = new Dictionary<string, string>();
            configurationData["MaxWearLevel"] = "15";
            var builder = new ConfigurationBuilder();
            _configuration = builder.AddInMemoryCollection(configurationData)
                .Build();

            var batteryRepositoryMock = new Mock<IBatteryRepository>();
            batteryRepositoryMock.Setup(p => p.GetBatteriesStaticDataAsync())
                .Returns(() =>
                {
                    if(_exceptionSwitch["GetBatteriesStaticDataAsync"])
                    {
                        throw new Exception("GetBatteriesStaticDataAsync");
                    }
                    if (_dataSwitch["GetBatteriesStaticDataAsync"])
                    {
                        return Task.FromResult(new List<BatteryStaticData>().AsEnumerable());
                    }
                    return Task.FromResult(_batteryStaticDataEntries.AsEnumerable());
                });
            batteryRepositoryMock.Setup(p => p.GetBatteryFullChargedCapacityAsync(It.IsAny<uint>()))
                .Returns<uint>(tag =>
                {
                    if (_exceptionSwitch["GetBatteryFullChargedCapacityAsync"])
                    {
                        throw new Exception("GetBatteryFullChargedCapacityAsync");
                    }
                    if (_dataSwitch["GetBatteryFullChargedCapacityAsync"])
                    {
                        return Task.FromResult(default(BatteryFullChargedCapacity));
                    }
                    return Task.FromResult(_batteryFullChargedCapacityEntires.FirstOrDefault(x => x.Tag == tag));
                });
            batteryRepositoryMock.Setup(p => p.GetWin32BatteryAsync(It.IsAny<string>()))
                .Returns<string>(uniqueIdentifier =>
                {
                    if (_exceptionSwitch["GetWin32BatteryAsync"])
                    {
                        throw new Exception("GetWin32BatteryAsync");
                    }
                    if (_dataSwitch["GetWin32BatteryAsync"])
                    {
                        return Task.FromResult(default(Win32_Battery));
                    }
                    return Task.FromResult(_win32_BatteryEntires.FirstOrDefault(x => x.DeviceID == uniqueIdentifier));
                });
            batteryRepositoryMock.Setup(p => p.GetDesignedBatteriesAsync(_model0))
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetDesignedBatteriesAsync"])
                    {
                        throw new Exception("GetDesignedBatteriesAsync");
                    }
                    if (_dataSwitch["GetDesignedBatteriesAsync"])
                    {
                        return Task.FromResult(new List<BatteryEntity>().AsEnumerable());
                    }
                    return Task.FromResult(_databaseEntieties);
                });
            batteryRepositoryMock.Setup(p => p.GetDesignedBatteriesAsync(_model1))
                .Returns(Task.FromResult(new List<BatteryEntity>().AsEnumerable()));

            batteryRepositoryMock.Setup(p => p.GetDesignedBatteriesAsync(_errorModel))
                .Throws(new Exception());

            _service = new BatteryService(_configuration, batteryRepositoryMock.Object);

            _invalidConfigurationService = new BatteryService(new ConfigurationBuilder().AddInMemoryCollection().Build(), null);

            _exceptionSwitch = new Dictionary<string, bool>();
            _exceptionSwitch["GetBatteriesStaticDataAsync"] = false;
            _exceptionSwitch["GetBatteryFullChargedCapacityAsync"] = false;
            _exceptionSwitch["GetWin32BatteryAsync"] = false;
            _exceptionSwitch["GetDesignedBatteriesAsync"] = false;

            _dataSwitch = new Dictionary<string, bool>();
            _dataSwitch["GetBatteriesStaticDataAsync"] = false;
            _dataSwitch["GetBatteryFullChargedCapacityAsync"] = false;
            _dataSwitch["GetWin32BatteryAsync"] = false;
            _dataSwitch["GetDesignedBatteriesAsync"] = false;
        }
        private void CleanUp()
        {
            _exceptionSwitch["GetBatteriesStaticDataAsync"] = false;
            _exceptionSwitch["GetBatteryFullChargedCapacityAsync"] = false;
            _exceptionSwitch["GetWin32BatteryAsync"] = false;
            _exceptionSwitch["GetDesignedBatteriesAsync"] = false;

            _dataSwitch["GetBatteriesStaticDataAsync"] = false;
            _dataSwitch["GetBatteryFullChargedCapacityAsync"] = false;
            _dataSwitch["GetWin32BatteryAsync"] = false;
            _dataSwitch["GetDesignedBatteriesAsync"] = false;
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_DataGetheredProperly_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _batteryStaticDataEntries.Count);

            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetBatteriesStaticDataAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetBatteriesStaticDataAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("GetBatteriesStaticDataAsync", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetWin32BatteryAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32BatteryAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("GetWin32BatteryAsync", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetBatteryFullChargedCapacityAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetBatteryFullChargedCapacityAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("GetBatteryFullChargedCapacityAsync", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetBatteriesStaticReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetBatteriesStaticDataAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetBatteriesStaticDataAsync')", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetWin32BatteryAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetWin32BatteryAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal($"Gatherer returned null entity of {nameof(Win32_Battery)}.", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_GetBatteryFullChargedCapacityAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetBatteryFullChargedCapacityAsync"] = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal($"Gatherer returned null entity of {nameof(BatteryFullChargedCapacity)}.", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_TagIsNull_ReturnsResultWithSuccess()
        {
            //Arrange
            var invalidEntity = new BatteryStaticData
            {
                Tag = null,
                UniqueID = "UniqueIdentifier0"
            };
            _batteryStaticDataEntries.Add(invalidEntity);

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 4);

            Assert.True(result.Output.FirstOrDefault(x => x.Messages.Any()) != null);
            Assert.True(result.Output.First(x => x.Messages.Any()).Messages.Count == 1);

            _batteryStaticDataEntries.Remove(invalidEntity);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_UniqueIdentifierIsNull_ReturnsResultWithSuccess()
        {
            //Arrange
            var invalidEntity = new BatteryStaticData
            {
                Tag = 7,
                UniqueID = null
            };
            _batteryStaticDataEntries.Add(invalidEntity);

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 4);

            Assert.True(result.Output.FirstOrDefault(x => x.Messages.Any()) != null);
            Assert.True(result.Output.First(x => x.Messages.Any()).Messages.Count == 1);

            _batteryStaticDataEntries.Remove(invalidEntity);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_UniqueIdentifierIsEmpty_ReturnsResultWithSuccess()
        {
            //Arrange
            var invalidEntity = new BatteryStaticData
            {
                Tag = 7,
                UniqueID = null
            };
            _batteryStaticDataEntries.Add(invalidEntity);

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 4);

            Assert.True(result.Output.FirstOrDefault(x => x.Messages.Any()) != null);
            Assert.True(result.Output.First(x => x.Messages.Any()).Messages.Count == 1);

            _batteryStaticDataEntries.Remove(invalidEntity);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_UniqueIdentifierIsWhitespace_ReturnsResultWithSuccess()
        {
            //Arrange
            var invalidEntity = new BatteryStaticData
            {
                Tag = 7,
                UniqueID = " "
            };
            _batteryStaticDataEntries.Add(invalidEntity);

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 4);

            Assert.True(result.Output.FirstOrDefault(x => x.Messages.Any()) != null);
            Assert.True(result.Output.First(x => x.Messages.Any()).Messages.Count == 1);

            _batteryStaticDataEntries.Remove(invalidEntity);
            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_EverythingWorksFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 3);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_ModelIsNull_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(null);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Contains("Value is null or empty.", result.Exception.Message);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_ModelIsEmpty_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(string.Empty);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Contains("Value is null or empty.", result.Exception.Message);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_ModelIsWhitespace_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(" ");

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Contains("Value is null or empty.", result.Exception.Message);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_ConfigurationContainsNoSuchKey_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _invalidConfigurationService.GetDesignedBatteriesAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal("MaxWearLevel unreadable from configuration.", result.Exception.Message);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_NoSuchModelInDatabase_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(_model1);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);

            CleanUp();
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedBatteriesAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal("No record found in database.", result.Exception.Message);
            Assert.NotNull(result.Exception.InnerException);

            CleanUp();
        }
    }
}
