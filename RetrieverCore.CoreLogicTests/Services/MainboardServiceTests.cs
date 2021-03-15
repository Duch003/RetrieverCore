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
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class MainboardServiceTests
    {
        private IMainboardService _service;
        private List<Win32_BaseBoard> _win32_ComputerSystemEntries = Win32_BaseBoardFactory.GetForMainboardServiceTests();
        private List<MainboardEntity> _databaseEntieties = MainboardEntityFactory.GetForMainboardServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException = false;
        private bool _noData = false;

        public MainboardServiceTests()
        {
            var mockMainboardRepository = new Mock<IMainboardRepository>();

            mockMainboardRepository.Setup(p => p.GetDesignedMainboard(_model0))
                .Returns(Task.FromResult(_databaseEntieties[0]));
            mockMainboardRepository.Setup(p => p.GetDesignedMainboard(_nonExistingModel))
                .Returns(Task.FromResult((MainboardEntity)null));
            mockMainboardRepository.Setup(p => p.GetDesignedMainboard(_errorModel))
                .Throws(new Exception());
            mockMainboardRepository.Setup(p => p.GetWin32BaseBoard())
                .Returns(() => 
                {
                    if (_throwException)
                    {
                        throw new Exception();
                    }
                    if(_noData)
                    {
                        return Task.FromResult(default(Win32_BaseBoard));
                    }
                    return Task.FromResult(_win32_ComputerSystemEntries[0]);
                });

            _service = new MainboardService(mockMainboardRepository.Object);
        }

        [Fact]
        public async Task GetDesignedMainboardAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output == _databaseEntieties[0]);
        }

        [Fact]
        public async Task GetDesignedMainboardAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedMainboardAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedMainboardAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalComputerAsync_EverythingWorkFine_ReturnsResultWithSuccess()
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
        public async Task GetPhysicalComputerAsync_GetWin32BaseBoardFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException = true;

            //Act
            var result = await _service.GetPhysicalMainboardAsync();
            _throwException = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalComputerAsync_GetWin32BaseBoardReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData = true;

            //Act
            var result = await _service.GetPhysicalMainboardAsync();
            _noData = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"Gatherer returned null entity of {nameof(Win32_BaseBoard)}.", result.Exception.Message);
        }
    }
}
