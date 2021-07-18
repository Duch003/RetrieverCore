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
    public class GPUServiceTests : IDisposable
    {
        private IGPUService _service;

        private Mock<IGenericDatabaseRepository<GPU>> _mockGPURepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private Win32_VideoController _win32VideoController1;
        private Win32_VideoController _win32VideoController2;
        private Win32_VideoController _win32VideoController3;
        private List<Win32_VideoController> _win32VideoControllers;

        private GPU _gpu1;
        private GPU _gpu2;
        private GPU _gpu3;
        private List<GPU> _gpus;

        private bool _win32VideoControllerException;
        private bool _gpuException;

        public GPUServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }

        public void Dispose()
        {
            _service = null;
            _mockGPURepo = null;
            _mockComponentRepo = null;
            _win32VideoController1 = null;
            _win32VideoController2 = null;
            _win32VideoController3 = null;
            _win32VideoControllers = null;
            _gpu1 = null;
            _gpu2 = null;
            _gpu3 = null;
            _gpus = null;
            GC.SuppressFinalize(this);
        }

        #region Tests
        [Fact]
        public async Task GetDesignedGPUsAsync_NoErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedGPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 1);
            Assert.True(result.Output.First() == _gpu1);
        }

        [Fact]
        public async Task GetDesignedGPUsAsync_NoEntryWithGivenSetId_ReturnsResultWithSuccess()
        {
            //Arrange
            var setId = new Guid(new string('1', 32));

            //Act
            var result = await _service.GetDesignedGPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetDesignedGPUsAsync_ErrorWhileQueryingDatabase_ReturnsResultWithFailure()
        {
            //Arrange
            _gpuException = true;
            var setId = new Guid(new string('0', 32));

            //Act
            var result = await _service.GetDesignedGPUsAsync(setId);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == nameof(GPU));
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_NoErrorsWhileExecutingWMI_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalGPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 3);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_NoComponentFound_ReturnsResultWithSuccess()
        {
            //Arrange
            _win32VideoControllers.Clear();

            //Act
            var result = await _service.GetPhysicalGPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_ErrorsWhileGatheringWin32PhysicalMemory_ReturnsResultWithFailure()
        {
            //Arrange
            _win32VideoControllerException = true;

            //Act
            var result = await _service.GetPhysicalGPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Win32_VideoController).Name);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _win32VideoControllerException = false;
            _gpuException = false;

            _gpu1 = new GPU
            {
                ID = 1,
                SetID = new Guid(new string('0', 32)),
                Deleted = false,
                Availability = "Availability1",
                Height = 1,
                Width = 1,
                Capacity = 1,
                AdapterDACType = "AdapterDACType1",
                Name = "Name1",
                VideoArchitecture = "VideoArchitecture1",
                NumberOfColors = 1,
                MaxRefreshRate = 1
            };
            _gpu2 = new GPU
            {
                ID = 2,
                SetID = new Guid(new string('0', 32)),
                Deleted = true,
                Availability = "Availability2",
                Height = 2,
                Width = 2,
                Capacity = 2,
                AdapterDACType = "AdapterDACType2",
                Name = "Name2",
                VideoArchitecture = "VideoArchitecture2",
                NumberOfColors = 2,
                MaxRefreshRate = 2
            };
            _gpu3 = new GPU
            {
                ID = 3,
                SetID = new Guid(new string('0', 31) + '1'),
                Deleted = false,
                Availability = "Availability3",
                Height = 3,
                Width = 3,
                Capacity = 3,
                AdapterDACType = "AdapterDACType3",
                Name = "Name3",
                VideoArchitecture = "VideoArchitecture3",
                NumberOfColors = 3,
                MaxRefreshRate = 3
            };
            _gpus = new List<GPU> { _gpu1, _gpu2, _gpu3 };

            _win32VideoController1 = new Win32_VideoController
            {
                Availability = 1,
                AdapterRAM = 1,
                CurrentHorizontalResolution = 1,
                CurrentVerticalResolution = 1,
                Caption = "Caption1",
                AdapterDACType = "AdapterDACType1",
                VideoArchitecture = 1,
                CurrentNumberOfColors = 1,
                MaxRefreshRate = 1
            };
            _win32VideoController2 = new Win32_VideoController
            {
                Availability = 2,
                AdapterRAM = 2,
                CurrentHorizontalResolution = 2,
                CurrentVerticalResolution = 2,
                Caption = "Caption2",
                AdapterDACType = "AdapterDACType2",
                VideoArchitecture = 2,
                CurrentNumberOfColors = 2,
                MaxRefreshRate = 2
            };
            _win32VideoController3 = new Win32_VideoController
            {
                Availability = 3,
                AdapterRAM = 3,
                CurrentHorizontalResolution = 3,
                CurrentVerticalResolution = 3,
                Caption = "Caption3",
                AdapterDACType = "AdapterDACType3",
                VideoArchitecture = 3,
                CurrentNumberOfColors = 3,
                MaxRefreshRate = 3
            };
            _win32VideoControllers = new List<Win32_VideoController> { _win32VideoController1, _win32VideoController2, _win32VideoController3 };
        }

        private void SetupRepositories()
        {
            _mockGPURepo = new Mock<IGenericDatabaseRepository<GPU>>();
            _mockGPURepo.Setup(x => x.GetBySetIdAsync(It.IsAny<Guid>(), It.IsAny<bool>()))
                .Returns<Guid, bool>((setId, deleted) =>
                {
                    if (_gpuException)
                    {
                        throw new Exception(nameof(GPU));
                    }
                    return Task.FromResult(_gpus.Where(x => x.Deleted == deleted && x.SetID == setId).ToList().AsEnumerable());
                });

            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<Win32_VideoController>())
                .Returns(() =>
                {
                    if (_win32VideoControllerException)
                    {
                        throw new Exception(nameof(Win32_VideoController));
                    }
                    return _win32VideoControllers.AsEnumerable();
                });
        }

        private void SetupService()
        {
            _service = new GPUService(_mockGPURepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
