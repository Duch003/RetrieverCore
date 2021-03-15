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
    public class GPUServiceTests
    {
        private IGPUService _service;
        private List<Win32_VideoController> _win32_VideoControllerEntries = Win32_VideoControllerFactory.GetForGPUServiceTests();
        private List<GPUEntity> _databaseEntieties = GPUEntityFactory.GetForGPUServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException = false;
        private bool _noData = false;

        public GPUServiceTests()
        {
            var mockGPURepository = new Mock<IGPURepository>();

            mockGPURepository.Setup(p => p.GetDesignedGPUsAsync(_model0))
                .Returns(Task.FromResult(_databaseEntieties.AsEnumerable()));
            mockGPURepository.Setup(p => p.GetDesignedGPUsAsync(_nonExistingModel))
                .Returns(Task.FromResult((IEnumerable<GPUEntity>)null));
            mockGPURepository.Setup(p => p.GetDesignedGPUsAsync(_errorModel))
                .Throws(new Exception());
            mockGPURepository.Setup(p => p.GetWin32VideoControllersAsync())
                .Returns(() =>
                {
                    if (_throwException)
                    {
                        throw new Exception();
                    }
                    if (_noData)
                    {
                        return Task.FromResult(new List<Win32_VideoController>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_VideoControllerEntries.AsEnumerable());
                });

            _service = new GPUService(mockGPURepository.Object);
        }

        [Fact]
        public async Task GetDesignedGPUsAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedGPUsAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _databaseEntieties.Count);
        }

        [Fact]
        public async Task GetDesignedGPUsAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedGPUsAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedGPUsAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedGPUsAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_EverythingWorkFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalGPUsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_GetWin32VideoControllersAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException = true;

            //Act
            var result = await _service.GetPhysicalGPUsAsync();
            _throwException = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_GetWin32VideoControllersAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            Win32_VideoController nullEntity = null;
            _win32_VideoControllerEntries.Add(nullEntity);

            //Act
            var result = await _service.GetPhysicalGPUsAsync();
            _win32_VideoControllerEntries.Remove(nullEntity);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalGPUsAsync_GetWin32VideoControllersAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData = true;

            //Act
            var result = await _service.GetPhysicalGPUsAsync();
            _noData = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalGPUsAsync')", result.Exception.Message);
        }
    }
}
