using Databases.RetrieverCore.Common.Models;
using Moq;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class MainboardServiceTests : IDisposable
    {
        private IMainboardService _service;

        private Mock<IGenericDatabaseRepository<Mainboard>> _mockMainboardRepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private Mainboard _mainboard1;
        private Mainboard _mainboard2;
        private Mainboard _mainboard3;
        private List<Mainboard> _mainboards;

        private Win32_BaseBoard _win32BaseBoard1;
        private List<Win32_BaseBoard> _win32BaseBoards;

        private Win32_MotherboardDevice _win32MotherboardDevice1;
        private List<Win32_MotherboardDevice> _win32MotherboardDevices;

        private bool _mainboardException;
        private bool _win32BaseBoardException;
        private bool _win32MotherboardDeviceException;

        private List<string> _includes;

        public MainboardServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }

        public void Dispose()
        {
            _service = null;
            _mockMainboardRepo = null;
            _mockComponentRepo = null;
            _mainboard1 = null;
            _mainboard2 = null;
            _mainboard3 = null;
            _mainboards = null;
            _win32BaseBoard1 = null;
            _win32BaseBoards = null;
            _win32MotherboardDevice1 = null;
            _win32MotherboardDevices = null;
            _includes = null;
            GC.SuppressFinalize(this);
        }

        #region Tests
        [Fact]
        public async Task GetDesignedMainboardAsync_NoErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedMainboardAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output == _mainboard3);
            Assert.True(_includes.Count == 0);
        }

        [Fact]
        public async Task GetDesignedMainboardAsync_NoEntryWithGivenSetId_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('2', 32));

            //Act
            var result = await _service.GetDesignedMainboardAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedMainboardAsync_ErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            _mainboardException = true;
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedMainboardAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == nameof(Mainboard));
        }

        [Fact]
        public async Task GetPhysicalMainboardAsync_NoErrorsWhileQueryingWMI_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalMainboardAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalMainboardAsync_ErrorWhileGatheringWin32BaseBoard_ReturnsResultWithFailure()
        {
            //Arrange
            _win32BaseBoardException = true;

            //Act
            var result = await _service.GetPhysicalMainboardAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == nameof(Win32_BaseBoard));
        }

        [Fact]
        public async Task GetPhysicalMainboardAsync_ErrorWhileGatheringWin32MotherboardDevice_ReturnsResultWithFailure()
        {
            //Arrange
            _win32MotherboardDeviceException = true;

            //Act
            var result = await _service.GetPhysicalMainboardAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == nameof(Win32_MotherboardDevice));
        }

        [Fact]
        public async Task GetPhysicalMainboardAsync_NoWin32BaseBoardComponentFound_ReturnsResultWithFailure()
        {
            //Arrange
            _win32BaseBoards.Clear();

            //Act
            var result = await _service.GetPhysicalMainboardAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.GetType().FullName == typeof(InvalidOperationException).FullName);
        }

        [Fact]
        public async Task GetPhysicalMainboardAsync_NoWin32MotherboardDeviceComponentFound_ReturnsResultWithFailure()
        {
            //Arrange
            _win32MotherboardDevices.Clear();

            //Act
            var result = await _service.GetPhysicalMainboardAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.GetType().FullName == typeof(InvalidOperationException).FullName);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _mainboardException = false;
            _win32BaseBoardException = false;
            _win32MotherboardDeviceException = false;
            _includes = new List<string>();

            _mainboard1 = new Mainboard
            {
                ID = 1,
                SetID = new Guid(new string('0', 32)),
                Deleted = true,
                Manufacturer = "Manufacturer1",
                Model = "Model1",
                PrimaryBusType = "PrimaryBusType1",
                SecondaryBusType = "SecondaryBusType1"
            };
            _mainboard2 = new Mainboard
            {
                ID = 2,
                SetID = new Guid(new string('1', 32)),
                Deleted = false,
                Manufacturer = "Manufacturer2",
                Model = "Model2",
                PrimaryBusType = "PrimaryBusType2",
                SecondaryBusType = "SecondaryBusType2"
            };
            _mainboard3 = new Mainboard
            {
                ID = 3,
                SetID = new Guid(new string('0', 32)),
                Deleted = false,
                Manufacturer = "Manufacturer3",
                Model = "Model3",
                PrimaryBusType = "PrimaryBusType3",
                SecondaryBusType = "SecondaryBusType3"
            };
            _mainboards = new List<Mainboard> { _mainboard1, _mainboard2, _mainboard3 };

            _win32BaseBoard1 = new Win32_BaseBoard
            {
                Manufacturer = "Manufacturer1",
                Product = "Product1"
            };
            _win32BaseBoards = new List<Win32_BaseBoard> { _win32BaseBoard1 };

            _win32MotherboardDevice1 = new Win32_MotherboardDevice
            {
                PrimaryBusType = "PrimaryBusType1",
                SecondaryBusType = "SecondaryBusType1"
            };
            _win32MotherboardDevices = new List<Win32_MotherboardDevice> { _win32MotherboardDevice1 };
        }

        private void SetupRepositories()
        {
            _mockMainboardRepo = new Mock<IGenericDatabaseRepository<Mainboard>>();
            _mockMainboardRepo.Setup(x => x.SingleAsync(It.IsAny<Expression<Func<Mainboard, bool>>>(), It.IsAny<Expression<Func<Mainboard, object>>[]>()))
                .Returns<Expression<Func<Mainboard, bool>>, Expression<Func<Mainboard, object>>[]>((conditions, includes) =>
                {
                    foreach(var include in includes)
                    {
                        _includes.Add(include.Body.ToString());
                    }
                    if (_mainboardException)
                    {
                        throw new Exception(nameof(Mainboard));
                    }
                    return Task.FromResult(_mainboards.FirstOrDefault(conditions.Compile()));
                });

            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<Win32_BaseBoard>())
                .Returns(() =>
                {
                    if (_win32BaseBoardException)
                    {
                        throw new Exception(nameof(Win32_BaseBoard));
                    }
                    return _win32BaseBoards.AsEnumerable();
                });
            _mockComponentRepo.Setup(x => x.Get<Win32_MotherboardDevice>())
                .Returns(() =>
                {
                    if (_win32MotherboardDeviceException)
                    {
                        throw new Exception(nameof(Win32_MotherboardDevice));
                    }
                    return _win32MotherboardDevices.AsEnumerable();
                });
        }

        private void SetupService()
        {
            _service = new MainboardService(_mockMainboardRepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
