using Moq;
using RetrieverCore.Common.Models;
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
    public class BatteryServiceTests : IDisposable
    {
        private IBatteryService _service;
        private Mock<IGenericDatabaseRepository<Battery>> _mockBatteryRepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private BatteryStaticData _batteryStaticData1;
        private BatteryStaticData _batteryStaticData2;
        private BatteryStaticData _batteryStaticData3;
        private List<BatteryStaticData> _batteryStaticData;

        private BatteryFullChargedCapacity _batteryFullChargedCapacity1;
        private BatteryFullChargedCapacity _batteryFullChargedCapacity2;
        private BatteryFullChargedCapacity _batteryFullChargedCapacity3;
        private List<BatteryFullChargedCapacity> _batteryFullChargedCapacities;

        private Win32_Battery _win32Battery1;
        private Win32_Battery _win32Battery2;
        private Win32_Battery _win32Battery3;
        private List<Win32_Battery> _win32Batteries;

        private Battery _battery1;
        private Battery _battery2;
        private Battery _battery3;
        private List<Battery> _batteries;

        private Guid _throwException;
        private bool _batteryStaticDataException;
        private bool _batteryFullChargedCapacityException;
        private bool _win32BatteryException;

        public BatteryServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }

        public void Dispose()
        {
            _service = null;
            _mockBatteryRepo = null;
            _mockComponentRepo = null;
            _batteryStaticData1 = null;
            _batteryStaticData = null;
            _batteryFullChargedCapacity1 = null;
            _batteryFullChargedCapacities = null;
            _win32Battery1 = null;
            _win32Batteries = null;
            _battery1 = null;
            _batteries = null;
        }

        #region Tests
        [Fact]
        public async Task GetDesignedBatteriesAsync_FiltersOutDeletedEntries_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 31) + "1");

            //Act
            var result = await _service.GetDesignedBatteriesAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 2);
            Assert.Equal(result.Output.ToList()[0], _battery1);
            Assert.Equal(result.Output.ToList()[1], _battery2);
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_NoEntryWithGivenSetId_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 31) + "2");

            //Act
            var result = await _service.GetDesignedBatteriesAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetDesignedBatteriesAsync_ErrorWhileQueryingDatabase_ReturnsResultWithFailure()
        {
            //Arrange
            //Act
            var result = await _service.GetDesignedBatteriesAsync(_throwException);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == _throwException.ToString());
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_NoErrorsWhileExecutingWMIQuery_ReturnsResultWithSuccess()
        {
            //Arrange
            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 3);
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_CannotPairComponentsByDeviceID_ReturnsResultWithFailure()
        {
            //Arrange
            _win32Battery1.DeviceID = "invalid";

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.GetType().FullName == typeof(InvalidOperationException).FullName);
            Assert.True(result.Exception.Message == "Sequence contains no matching element");
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_CannotPairComponentsByUniqueID_ReturnsResultWithFailure()
        {
            //Arrange
            _batteryStaticData1.UniqueID = "invalid";

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.GetType().FullName == typeof(InvalidOperationException).FullName);
            Assert.True(result.Exception.Message == "Sequence contains no matching element");
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_CannotPairComponentsByTag_ReturnsResultWithFailure()
        {
            //Arrange
            _batteryFullChargedCapacity3.Tag = 90;
            _batteryStaticData3.Tag = 190;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.GetType().FullName == typeof(InvalidOperationException).FullName);
            Assert.True(result.Exception.Message == "Sequence contains no matching element");
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_ErrorWhileGatheringBatteryStaticData_ReturnsResultWithFailure()
        {
            //Arrange
            _batteryStaticDataException = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(BatteryStaticData).Name);
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_ErrorWhileGatheringBatteryFullChargedCapacity_ReturnsResultWithFailure()
        {
            //Arrange
            _batteryFullChargedCapacityException = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(BatteryFullChargedCapacity).Name);
        }

        [Fact]
        public async Task GetPhysicalBatteriesAsync_ErrorWhileGatheringWin32Battery_ReturnsResultWithFailure()
        {
            //Arrange
            _win32BatteryException = true;

            //Act
            var result = await _service.GetPhysicalBatteriesAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Win32_Battery).Name);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _throwException = new Guid(new string('9', 32));
            _batteryStaticDataException = false;
            _batteryFullChargedCapacityException = false;
            _win32BatteryException = false;

            _batteryStaticData1 = new BatteryStaticData
            {
                UniqueID = "UniqueID1",
                Tag = 1,
                DesignedCapacity = 8150
            };
            _batteryStaticData2 = new BatteryStaticData
            {
                UniqueID = "UniqueID2",
                Tag = 2,
                DesignedCapacity = 10200
            };
            _batteryStaticData3 = new BatteryStaticData
            {
                UniqueID = "UniqueID3",
                Tag = 3,
                DesignedCapacity = 13133
            };
            _batteryStaticData = new List<BatteryStaticData> { _batteryStaticData1, _batteryStaticData2, _batteryStaticData3 };

            _batteryFullChargedCapacity1 = new BatteryFullChargedCapacity
            {
                Tag = 1,
                FullChargedCapacity = 8500
            };
            _batteryFullChargedCapacity2 = new BatteryFullChargedCapacity
            {
                Tag = 2,
                FullChargedCapacity = 12000
            };
            _batteryFullChargedCapacity3 = new BatteryFullChargedCapacity
            {
                Tag = 3,
                FullChargedCapacity = 13000
            };
            _batteryFullChargedCapacities = new List<BatteryFullChargedCapacity> { _batteryFullChargedCapacity1, 
                _batteryFullChargedCapacity2, _batteryFullChargedCapacity3 };

            _win32Battery1 = new Win32_Battery
            {
                BatteryStatus = 1,
                DeviceID = "UniqueID1",
                EstimatedChargeRemaining = 10
            };
            _win32Battery2 = new Win32_Battery
            {
                BatteryStatus = 2,
                DeviceID = "UniqueID2",
                EstimatedChargeRemaining = 20
            };
            _win32Battery3 = new Win32_Battery
            {
                BatteryStatus = 3,
                DeviceID = "UniqueID3",
                EstimatedChargeRemaining = 30
            };
            _win32Batteries = new List<Win32_Battery> { _win32Battery1, _win32Battery2, _win32Battery3 };

            _battery1 = new Battery
            {
                ID = 1,
                Deleted = false,
                SetID = new Guid(new string('0', 31) + "1"),
                WearLevel = 1,
                Status = 1,
                DesignedCapacity = 1
            };
            _battery2 = new Battery
            {
                ID = 2,
                Deleted = false,
                SetID = new Guid(new string('0', 31) + "1"),
                WearLevel = 2,
                Status = 2,
                DesignedCapacity = 2
            };
            _battery3 = new Battery
            {
                ID = 3,
                Deleted = true,
                SetID = new Guid(new string('0', 31) + "1"),
                WearLevel = 3,
                Status = 3,
                DesignedCapacity = 3
            };
            _batteries = new List<Battery> { _battery1, _battery2, _battery3 };
        }

        private void SetupRepositories()
        {
            _mockBatteryRepo = new Mock<IGenericDatabaseRepository<Battery>>();
            _mockBatteryRepo.Setup(x => x.GetBySetIdAsync(It.IsAny<Guid>(), It.IsAny<bool>()))
                .Returns<Guid, bool>((setId, isDeleted) =>
                {
                    if(setId == _throwException)
                    {
                        throw new Exception(setId.ToString());
                    }
                    return Task.FromResult(_batteries.Where(x => x.SetID == setId && x.Deleted == isDeleted).ToList().AsEnumerable());
                });

            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<BatteryStaticData>())
                .Returns(() =>
                {
                    if (_batteryStaticDataException)
                    {
                        throw new Exception(typeof(BatteryStaticData).Name);
                    }
                    return _batteryStaticData.AsEnumerable();
                });
            _mockComponentRepo.Setup(x => x.Get<Win32_Battery>())
                .Returns(() =>
                {
                    if (_win32BatteryException)
                    {
                        throw new Exception(typeof(Win32_Battery).Name);
                    }
                    return _win32Batteries.AsEnumerable();
                });
            _mockComponentRepo.Setup(x => x.Get<BatteryFullChargedCapacity>())
                .Returns(() =>
                {
                    if (_batteryFullChargedCapacityException)
                    {
                        throw new Exception(typeof(BatteryFullChargedCapacity).Name);
                    }
                    return _batteryFullChargedCapacities.AsEnumerable();
                });
        }

        private void SetupService()
        {
            _service = new BatteryService(_mockBatteryRepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
