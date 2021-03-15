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
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class ComputerServiceTests
    {
        private IComputerService _service;
        private List<Win32_ComputerSystem> _win32_ComputerSystemEntries = Win32_ComputerSystemFactory.GetForComputerServiceTests();
        private List<ComputerEntity> _databaseEntieties = ComputerEntityFactory.GetForComputerServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException = false;
        private bool _noData = false;

        public ComputerServiceTests()
        {
            var mockComputerRepository = new Mock<IComputerRepository>();

            mockComputerRepository.Setup(p => p.GetDesignedComputerAsync(_model0))
                .Returns(Task.FromResult(_databaseEntieties[0]));
            mockComputerRepository.Setup(p => p.GetDesignedComputerAsync(_nonExistingModel))
                .Returns(Task.FromResult((ComputerEntity)null));
            mockComputerRepository.Setup(p => p.GetDesignedComputerAsync(_errorModel))
                .Throws(new Exception());
            mockComputerRepository.Setup(p => p.GetWin32ComputerSystemAsync())
                .Returns(() => 
                {
                    if (_throwException)
                    {
                        throw new Exception();
                    }
                    if(_noData)
                    {
                        return Task.FromResult((Win32_ComputerSystem)null);
                    }
                    return Task.FromResult(_win32_ComputerSystemEntries[0]);
                });

            _service = new ComputerService(mockComputerRepository.Object);
        }

        [Fact]
        public async Task GetDesignedComputerAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedComputerAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output == _databaseEntieties[0]);
        }

        [Fact]
        public async Task GetDesignedComputerAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedComputerAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedComputerAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedComputerAsync(_errorModel);

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
            var result = await _service.GetPhysicalComputerAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalComputerAsync_GetPhysicalComputerAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException = true;

            //Act
            var result = await _service.GetPhysicalComputerAsync();
            _throwException = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalComputerAsync_GetPhysicalComputerAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData = true;

            //Act
            var result = await _service.GetPhysicalComputerAsync();
            _noData = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"Gatherer returned null entity of {nameof(Win32_ComputerSystem)}.", result.Exception.Message);
        }
    }
}
