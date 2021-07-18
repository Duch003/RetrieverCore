using Databases.RetrieverCore.Common.Models;
using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class CPUServiceTests : IDisposable
    {
        private ICPUService _service;

        private Mock<IGenericDatabaseRepository<CPU>> _mockCPURepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private Win32_Processor _win32Processor1;
        private Win32_Processor _win32Processor2;
        private Win32_Processor _win32Processor3;
        private List<Win32_Processor> _win32Processors;

        private CPU _cpu1;
        private CPU _cpu2;
        private CPU _cpu3;
        private List<CPU> _cpus;

        private bool _cpuException;
        private bool _win32ProcessorException;

        public CPUServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }

        public void Dispose()
        {
            _service = null;
            _mockCPURepo = null;
            _mockComponentRepo = null;
            _win32Processor1 = null;
            _win32Processor2 = null;
            _win32Processor3 = null;
            _win32Processors = null;
            _cpu1 = null;
            _cpu2 = null;
            _cpu3 = null;
            _cpus = null;
            GC.SuppressFinalize(this);
        }

        #region Tests
        [Fact]
        public async Task GetDesignedCPUsAsync_NoErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedCPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 1);
            Assert.True(result.Output.First() == _cpu1);
        }

        [Fact]
        public async Task GetDesignedCPUsAsync_NoEntryWithGivenSetId_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('1', 32));

            //Act
            var result = await _service.GetDesignedCPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetDesignedCPUsAsync_ErrorWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 32));
            _cpuException = true;

            //Act
            var result = await _service.GetDesignedCPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(CPU).Name);
        }

        [Fact]
        public async Task GetPhysicalCPUsAsync_NoErrorsWhileExecutingWMI_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalCPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 3);
        }

        [Fact]
        public async Task GetPhysicalCPUsAsync_NoComponentFound_ReturnsResultWithSuccess()
        {
            //Arrange
            _win32Processors.Clear();

            //Act
            var result = await _service.GetPhysicalCPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetPhysicalCPUsAsync_ErrorWhileExecutingWMIQuery_ReturnsResultWithFailure()
        {
            //Arrange
            _win32ProcessorException = true;

            //Act
            var result = await _service.GetPhysicalCPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Win32_Processor).Name);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _cpuException = false;
            _win32ProcessorException = false;

            _win32Processor1 = new Win32_Processor
            {
                Architecture = 1,
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                Name = "Name1",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = 1,
                Caption = "Caption1",
                Family = 1,
                UpgradeMethod = 1
            };
            _win32Processor2 = new Win32_Processor
            {
                Architecture = 2,
                CurrentClockSpeed = 2,
                L2CacheSize = 2,
                L3CacheSize = 2,
                Name = "Name2",
                NumberOfCores = 2,
                NumberOfLogicalProcessors = 2,
                ProcessorType = 2,
                Caption = "Caption2",
                Family = 2,
                UpgradeMethod = 2
            };
            _win32Processor3 = new Win32_Processor
            {
                Architecture = 3,
                CurrentClockSpeed = 3,
                L2CacheSize = 3,
                L3CacheSize = 3,
                Name = "Name3",
                NumberOfCores = 3,
                NumberOfLogicalProcessors = 3,
                ProcessorType = 3,
                Caption = "Caption3",
                Family = 3,
                UpgradeMethod = 3
            };
            _win32Processors = new List<Win32_Processor> { _win32Processor1, _win32Processor2, _win32Processor3 };

            _cpu1 = new CPU
            {
                ID = 1,
                Deleted = false,
                SetID = new Guid(new string('0', 32)),
                Architecture = "Architecture1",
                CurrentClockSpeed = 1,
                L2CacheSize = 1,
                L3CacheSize = 1,
                ModelWithVendor = "ModelWithVendor1",
                NumberOfCores = 1,
                NumberOfLogicalProcessors = 1,
                ProcessorType = "ProcessorType1",
                Caption = "Caption1",
                Family = "Family1",
                UpgradeMethod = "UpgradeMethod1"
            };
            _cpu2 = new CPU
            {
                ID = 2,
                Deleted = false,
                SetID = new Guid(new string('0', 31) + "1"),
                Architecture = "Architecture2",
                CurrentClockSpeed = 2,
                L2CacheSize = 2,
                L3CacheSize = 2,
                ModelWithVendor = "ModelWithVendor2",
                NumberOfCores = 2,
                NumberOfLogicalProcessors = 2,
                ProcessorType = "ProcessorType2",
                Caption = "Caption2",
                Family = "Family2",
                UpgradeMethod = "UpgradeMethod2"
            };
            _cpu3 = new CPU
            {
                ID = 3,
                Deleted = true,
                SetID = new Guid(new string('0', 32)),
                Architecture = "Architecture3",
                CurrentClockSpeed = 3,
                L2CacheSize = 3,
                L3CacheSize = 3,
                ModelWithVendor = "ModelWithVendor3",
                NumberOfCores = 3,
                NumberOfLogicalProcessors = 3,
                ProcessorType = "ProcessorType3",
                Caption = "Caption3",
                Family = "Family3",
                UpgradeMethod = "UpgradeMethod3"
            };
            _cpus = new List<CPU> { _cpu1, _cpu2, _cpu3 };
        }

        private void SetupRepositories()
        {
            _mockCPURepo = new Mock<IGenericDatabaseRepository<CPU>>();
            _mockCPURepo.Setup(x => x.GetBySetIdAsync(It.IsAny<Guid>(), It.IsAny<bool>()))
                .Returns<Guid, bool>((setId, deleted) =>
                {
                    if (_cpuException)
                    {
                        throw new Exception(typeof(CPU).Name);
                    }
                    return Task.FromResult(_cpus.Where(x => x.SetID == setId && x.Deleted == deleted).ToList().AsEnumerable());
                });

            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<Win32_Processor>())
                .Returns(() =>
                {
                    if (_win32ProcessorException)
                    {
                        throw new Exception(typeof(Win32_Processor).Name);
                    }
                    return _win32Processors.AsEnumerable();
                });
        }

        private void SetupService()
        {
            _service = new CPUService(_mockCPURepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
