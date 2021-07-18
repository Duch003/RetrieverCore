using Databases.RetrieverCore.Common.Models;
using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class DDRServiceTests : IDisposable
    {
        private IDDRService _service;

        private Mock<IGenericDatabaseRepository<DDR>> _mockDDRRepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private Win32_PhysicalMemory _win32PhysicalMemory1;
        private Win32_PhysicalMemory _win32PhysicalMemory2; 
        private Win32_PhysicalMemory _win32PhysicalMemory3;
        private List<Win32_PhysicalMemory> _win32PhysicalMemories;

        private DDR _ddr1;
        private DDR _ddr2;
        private DDR _ddr3;
        private List<DDR> _ddrs;

        private bool _win32PhysicalMemoryException;
        private bool _ddrException;

        public DDRServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }

        public void Dispose()
        {
            _service = null;
            _mockDDRRepo = null;
            _mockComponentRepo = null;
            _win32PhysicalMemory1 = null;
            _win32PhysicalMemory2 = null;
            _win32PhysicalMemory3 = null;
            _win32PhysicalMemories = null;
            _ddr1 = null;
            _ddr2 = null;
            _ddr3 = null;
            _ddrs = null;
            GC.SuppressFinalize(this);
        }

        #region Tests
        [Fact]
        public async Task GetDesignedDDRsAsync_NoErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedDDRsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 1);
            Assert.True(result.Output.First() == _ddr2);
        }

        [Fact]
        public async Task GetDesignedDDRsAsync_NoEntryWithGivenSetId_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('1', 32));

            //Act
            var result = await _service.GetDesignedDDRsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetDesignedDDRsAsync_ErrorWhileQueryingDatabase_ReturnsResultWithFailure()
        {
            //Arrange
            _ddrException = true;
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedDDRsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(DDR).Name);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_NoErrorsWhileExecutingWMI_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalDDRsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 3);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_NoComponentFound_ReturnsResultWithSuccess()
        {
            //Arrange
            _win32PhysicalMemories.Clear();

            //Act
            var result = await _service.GetPhysicalDDRsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_ErrorsWhileGatheringWin32PhysicalMemory_ReturnsResultWithFailure()
        {
            //Arrange
            _win32PhysicalMemoryException = true;

            //Act
            var result = await _service.GetPhysicalDDRsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Win32_PhysicalMemory).Name);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _win32PhysicalMemoryException = false;
            _ddrException = false;

            _win32PhysicalMemory1 = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 1000,
                FormFactor = 1,
                Manufacturer = "Manufacturer1"
            };
            _win32PhysicalMemory2 = new Win32_PhysicalMemory
            {
                Capacity = 8589934592,
                ConfiguredClockSpeed = 2000,
                FormFactor = 2,
                Manufacturer = "Manufacturer2"
            };
            _win32PhysicalMemory3 = new Win32_PhysicalMemory
            {
                Capacity = 17179869184,
                ConfiguredClockSpeed = 3000,
                FormFactor = 3,
                Manufacturer = "Manufacturer3"
            };
            _win32PhysicalMemories = new List<Win32_PhysicalMemory> { _win32PhysicalMemory1, _win32PhysicalMemory2, _win32PhysicalMemory3 };

            _ddr1 = new DDR
            {
                ID = 1,
                Deleted = true,
                SetID = new Guid(new string('0', 32)),
                Capacity = 1,
                Clocking = 1,
                FormFactor = "FormFactor1",
                Vendor = "Manufacturer1"
            };
            _ddr2 = new DDR
            {
                ID = 2,
                Deleted = false,
                SetID = new Guid(new string('0', 32)),
                Capacity = 2,
                Clocking = 2,
                FormFactor = "FormFactor2",
                Vendor = "Manufacturer2"
            };
            _ddr3 = new DDR
            {
                ID = 3,
                Deleted = false,
                SetID = new Guid(new string('0', 31) + "1"),
                Capacity = 3,
                Clocking = 3,
                FormFactor = "FormFactor3",
                Vendor = "Manufacturer3"
            };
            _ddrs = new List<DDR> { _ddr1, _ddr2, _ddr3 };
        }

        private void SetupRepositories()
        {
            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<Win32_PhysicalMemory>())
                .Returns(() =>
                {
                    if (_win32PhysicalMemoryException)
                    {
                        throw new Exception(typeof(Win32_PhysicalMemory).Name);
                    }
                    return _win32PhysicalMemories.AsEnumerable();
                });

            _mockDDRRepo = new Mock<IGenericDatabaseRepository<DDR>>();
            _mockDDRRepo.Setup(x => x.GetBySetIdAsync(It.IsAny<Guid>(), It.IsAny<bool>()))
                .Returns<Guid, bool>((setId, deleted) =>
                {
                    if (_ddrException)
                    {
                        throw new Exception(typeof(DDR).Name);
                    }
                    return Task.FromResult(_ddrs.Where(x => x.Deleted == deleted && x.SetID == setId).ToList().AsEnumerable());
                });
        }

        private void SetupService()
        {
            _service = new DDRService(_mockDDRRepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
