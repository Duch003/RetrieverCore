using GathererEngine.Models;
using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.LocalDatabase.Models;
using RetrieverCore.Repositories.Interfaces;
using RetrieverCore.TestDataGenerator.Database;
using RetrieverCore.TestDataGenerator.WindowsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class StorageServiceTests
    {
        private List<Win32_DiskDrive> _diskDrives = Win32_DiskDriveFactory.GetForStorageServiceTests();
        private List<Win32_LogicalDisk> _logicalDiscs = Win32_LogicalDiskFactory.GetForStorageServiceTests();
        private List<Win32_DiskPartition> _diskPartitions = Win32_DiskPartitionFactory.GetForStorageServiceTests();
        private List<Win32_DiskDriveToDiskPartition> _diskDrivesToDiskPartitions = Win32_DiskDriveToDiskPartitionFactory.GetForStorageServiceTests();
        private List<Win32_LogicalDiskToPartition> _logicalDisksToDiskPartitions = Win32_LogicalDiskToPartitionFactory.GetForStorageServiceTests();
        private List<MSFT_PhysicalDisk> _pysicalDiscs = MSFT_PhysicalDiskFactory.GetForStorageServiceTests();
        private List<StorageEntity> _storageEntieties = StorageEntityFactory.GetForStorageServiceTests();

        IStorageRepository _repository;
        IStorageService _service;

        private string _model0 = "Model0";
        private string _model1 = "Model1";
        private string _errorModel = "Error";

        private Dictionary<string, bool> _exceptionSwitch;
        private Dictionary<string, bool> _dataSwitch;

        public StorageServiceTests()
        {
            var storageRepositoryMock = new Mock<IStorageRepository>();
            storageRepositoryMock.Setup(x => x.GetDesignedStoragesAsync(_model0))
                .Returns(Task.FromResult(_storageEntieties.AsEnumerable()));
            storageRepositoryMock.Setup(x => x.GetDesignedStoragesAsync(_model1))
                .Returns(Task.FromResult(new List<StorageEntity>().AsEnumerable()));
            storageRepositoryMock.Setup(x => x.GetDesignedStoragesAsync(_errorModel))
                .Throws(new Exception());
           
            storageRepositoryMock.Setup(x => x.GetMSFTPhysicalDiscsAsync())
                .Returns(() => 
                {
                    if (_exceptionSwitch["GetMSFTPhysicalDiscsAsync"])
                    {
                        throw new Exception("GetMSFTPhysicalDiscsAsync");
                    }
                    if (_dataSwitch["GetMSFTPhysicalDiscsAsync"])
                    {
                        return Task.FromResult(new List<MSFT_PhysicalDisk>().AsEnumerable());
                    }
                    return Task.FromResult(_pysicalDiscs.AsEnumerable());
                });
            storageRepositoryMock.Setup(x => x.GetWin32DiskDrivesAsync())
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetWin32DiskDrivesAsync"])
                    {
                        throw new Exception("GetWin32DiskDrivesAsync");
                    }
                    if (_dataSwitch["GetWin32DiskDrivesAsync"])
                    {
                        return Task.FromResult(new List<Win32_DiskDrive>().AsEnumerable());
                    }
                    return Task.FromResult(_diskDrives.AsEnumerable());
                });
            storageRepositoryMock.Setup(x => x.GetWin32DiskDriveToDiskPartitionsAsync())
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetWin32DiskDriveToDiskPartitionsAsync"])
                    {
                        throw new Exception("GetWin32DiskDriveToDiskPartitionsAsync");
                    }
                    if (_dataSwitch["GetWin32DiskDriveToDiskPartitionsAsync"])
                    {
                        return Task.FromResult(new List<Win32_DiskDriveToDiskPartition>().AsEnumerable());
                    }
                    return Task.FromResult(_diskDrivesToDiskPartitions.AsEnumerable());
                });
            storageRepositoryMock.Setup(x => x.GetWin32DiskPartitionsAsync())
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetWin32DiskPartitionsAsync"])
                    {
                        throw new Exception("GetWin32DiskPartitionsAsync");
                    }
                    if (_dataSwitch["GetWin32DiskPartitionsAsync"])
                    {
                        return Task.FromResult(new List<Win32_DiskPartition>().AsEnumerable());
                    }
                    return Task.FromResult(_diskPartitions.AsEnumerable());
                });
            storageRepositoryMock.Setup(x => x.GetWin32LogicalDiscsAsync())
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetWin32LogicalDiscsAsync"])
                    {
                        throw new Exception("GetWin32LogicalDiscsAsync");
                    }
                    if (_dataSwitch["GetWin32LogicalDiscsAsync"])
                    {
                        return Task.FromResult(new List<Win32_LogicalDisk>().AsEnumerable());
                    }
                    return Task.FromResult(_logicalDiscs.AsEnumerable());
                });
            storageRepositoryMock.Setup(x => x.GetWin32LogicalDiscsToPartitionsAsync())
                .Returns(() =>
                {
                    if (_exceptionSwitch["GetWin32LogicalDiscsToPartitionsAsync"])
                    {
                        throw new Exception("GetWin32LogicalDiscsToPartitionsAsync");
                    }
                    if (_dataSwitch["GetWin32LogicalDiscsToPartitionsAsync"])
                    {
                        return Task.FromResult(new List<Win32_LogicalDiskToPartition>().AsEnumerable());
                    }
                    return Task.FromResult(_logicalDisksToDiskPartitions.AsEnumerable());
                });

            _repository = storageRepositoryMock.Object;

            _service = new StorageService(_repository);

            _exceptionSwitch = new Dictionary<string, bool>();
            _exceptionSwitch["GetWin32DiskDrivesAsync"] = false;
            _exceptionSwitch["GetWin32DiskPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32LogicalDiscsAsync"] = false;
            _exceptionSwitch["GetMSFTPhysicalDiscsAsync"] = false;

            _dataSwitch = new Dictionary<string, bool>();
            _dataSwitch["GetWin32DiskDrivesAsync"] = false;
            _dataSwitch["GetWin32DiskPartitionsAsync"] = false;
            _dataSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = false;
            _dataSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = false;
            _dataSwitch["GetWin32LogicalDiscsAsync"] = false;
            _dataSwitch["GetMSFTPhysicalDiscsAsync"] = false;
        }

        private void CleanUp()
        {
            _exceptionSwitch["GetWin32DiskDrivesAsync"] = false;
            _exceptionSwitch["GetWin32DiskPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = false;
            _exceptionSwitch["GetWin32LogicalDiscsAsync"] = false;
            _exceptionSwitch["GetMSFTPhysicalDiscsAsync"] = false;

            _dataSwitch["GetWin32DiskDrivesAsync"] = false;
            _dataSwitch["GetWin32DiskPartitionsAsync"] = false;
            _dataSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = false;
            _dataSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = false;
            _dataSwitch["GetWin32LogicalDiscsAsync"] = false;
            _dataSwitch["GetMSFTPhysicalDiscsAsync"] = false;
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_DataGatheredProperly_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _diskDrives.Count());

            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskDrivesAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32DiskDrivesAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            
            Assert.True(result.Exception.Message == "GetWin32DiskDrivesAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskPartitionsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32DiskPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.True(result.Exception.Message == "GetWin32DiskPartitionsAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskDriveToDiskPartitionsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.True(result.Exception.Message == "GetWin32DiskDriveToDiskPartitionsAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32LogicalDiscsToPartitionsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.True(result.Exception.Message == "GetWin32LogicalDiscsToPartitionsAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32LogicalDiscsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetWin32LogicalDiscsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.True(result.Exception.Message == "GetWin32LogicalDiscsAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetMSFTPhysicalDiscsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _exceptionSwitch["GetMSFTPhysicalDiscsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.True(result.Exception.Message == "GetMSFTPhysicalDiscsAsync");
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskDrivesAsyncReturnsNoData_ReturnsResultWithSuccess()
        {
            //Arrange
            _dataSwitch["GetWin32DiskDrivesAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(!result.Output.Any());
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetMSFTPhysicalDiscsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetMSFTPhysicalDiscsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetMSFTPhysicalDiscsAsync')", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskPartitionsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetWin32DiskPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetWin32DiskPartitionsAsync')", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32DiskDriveToDiskPartitionsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetWin32DiskDriveToDiskPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetWin32DiskDriveToDiskPartitionsAsync')", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32LogicalDiscsToPartitionsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetWin32LogicalDiscsToPartitionsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetWin32LogicalDiscsToPartitionsAsync')", result.Exception.Message);
            CleanUp();
        }

        [Fact]
        public async Task GetPhysicalStoragesAsync_GetWin32LogicalDiscsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _dataSwitch["GetWin32LogicalDiscsAsync"] = true;

            //Act
            var result = await _service.GetPhysicalStoragesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);

            Assert.Equal("List is null or empty. (Caller: 'GetWin32LogicalDiscsAsync')", result.Exception.Message);
            CleanUp();
        }
    }
}
