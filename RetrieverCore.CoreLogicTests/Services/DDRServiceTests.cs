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
    public class DDRServiceTests
    {
        private IDDRService _service;
        private List<Win32_PhysicalMemory> _win32_PhysicalMemoryEntries = Win32_PhysicalMemoryFactory.GetForDDRServiceTests();
        private List<DDREntity> _databaseEntieties = DDREntityFactory.GetForDDRServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException = false;
        private bool _noData = false;

        public DDRServiceTests()
        {
            var mockDDRRepository = new Mock<IDDRRepository>();

            mockDDRRepository.Setup(p => p.GetDesignedDDRsAsync(_model0))
                .Returns(Task.FromResult(_databaseEntieties.AsEnumerable()));
            mockDDRRepository.Setup(p => p.GetDesignedDDRsAsync(_nonExistingModel))
                .Returns(Task.FromResult((IEnumerable<DDREntity>)null));
            mockDDRRepository.Setup(p => p.GetDesignedDDRsAsync(_errorModel))
                .Throws(new Exception());
            mockDDRRepository.Setup(p => p.GetWin32PhysicalMemoriesAsync())
                .Returns(() =>
                {
                    if (_throwException)
                    {
                        throw new Exception();
                    }
                    if (_noData)
                    {
                        return Task.FromResult(new List<Win32_PhysicalMemory>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_PhysicalMemoryEntries.AsEnumerable());
                });

            _service = new DDRService(mockDDRRepository.Object);
        }

        [Fact]
        public async Task GetDesignedDDRsAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedDDRsAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _databaseEntieties.Count);
        }

        [Fact]
        public async Task GetDesignedDDRsAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedDDRsAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedDDRsAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedDDRsAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_EverythingWorkFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalDDRsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_GetWin32PhysicalMemoriesAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException = true;

            //Act
            var result = await _service.GetPhysicalDDRsAsync();
            _throwException = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_GetWin32PhysicalMemoriesAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            Win32_PhysicalMemory nullEntity = null;
            _win32_PhysicalMemoryEntries.Add(nullEntity);

            //Act
            var result = await _service.GetPhysicalDDRsAsync();
            _win32_PhysicalMemoryEntries.Remove(nullEntity);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalDDRsAsync_GetWin32PhysicalMemoriesReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData = true;

            //Act
            var result = await _service.GetPhysicalDDRsAsync();
            _noData = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalDDRsAsync')", result.Exception.Message);
        }
    }
}
