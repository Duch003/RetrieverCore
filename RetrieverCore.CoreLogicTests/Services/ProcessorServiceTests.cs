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
    public class ProcessorServiceTests
    {
        private IProcessorService _service;
        private List<Win32_Processor> _win32_ProcessorEntries = Win32_ProcessorFactory.GetForProcessorServiceTests();
        private List<ProcessorEntity> _databaseEntieties = ProcessorEntityFactory.GetFroProcessorServiceTests();

        private string _model0 = "Model0";
        private string _nonExistingModel = "NonExisting";
        private string _errorModel = "Error";
        private bool _throwException = false;
        private bool _noData = false;

        public ProcessorServiceTests()
        {
            var mockProcessorRepository = new Mock<IProcessorRepository>();

            mockProcessorRepository.Setup(p => p.GetDesignedProcessors(_model0))
                .Returns(Task.FromResult(_databaseEntieties.AsEnumerable()));
            mockProcessorRepository.Setup(p => p.GetDesignedProcessors(_nonExistingModel))
                .Returns(Task.FromResult((IEnumerable<ProcessorEntity>)null));
            mockProcessorRepository.Setup(p => p.GetDesignedProcessors(_errorModel))
                .Throws(new Exception());
            mockProcessorRepository.Setup(p => p.GetWin32Processors())
                .Returns(() =>
                {
                    if (_throwException)
                    {
                        throw new Exception();
                    }
                    if (_noData)
                    {
                        return Task.FromResult(new List<Win32_Processor>().AsEnumerable());
                    }
                    return Task.FromResult(_win32_ProcessorEntries.AsEnumerable());
                });

            _service = new ProcessorService(mockProcessorRepository.Object);
        }

        [Fact]
        public async Task GetDesignedProcessorsAsync_ModelExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedProcessorsAsync(_model0);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == _databaseEntieties.Count);
        }

        [Fact]
        public async Task GetDesignedProcessorsAsync_ModelDoesNotExist_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedProcessorsAsync(_nonExistingModel);

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetDesignedProcessorsAsync_DatabaseError_ReturnsResultWithFail()
        {
            //Arrange

            //Act
            var result = await _service.GetDesignedProcessorsAsync(_errorModel);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalProcessorsAsync_EverythingWorkFine_ReturnsResultWithSuccess()
        {
            //Arrange

            //Act
            var result = await _service.GetPhysicalProcessorsAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
        }

        [Fact]
        public async Task GetPhysicalProcessorsAsync_GetWin32ProcessorsAsyncFails_ReturnsResultWithFail()
        {
            //Arrange
            _throwException = true;

            //Act
            var result = await _service.GetPhysicalProcessorsAsync();
            _throwException = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }

        [Fact]
        public async Task GetPhysicalProcessorsAsync_GetWin32ProcessorsAsyncContainsNull_ReturnsResultWithFail()
        {
            //Arrange
            Win32_Processor nullEntity = null;
            _win32_ProcessorEntries.Add(nullEntity);

            //Act
            var result = await _service.GetPhysicalProcessorsAsync();
            _win32_ProcessorEntries.Remove(nullEntity);

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
        }
        [Fact]
        public async Task GetPhysicalProcessorsAsync_GetWin32ProcessorsAsyncReturnsNoData_ReturnsResultWithFail()
        {
            //Arrange
            _noData = true;

            //Act
            var result = await _service.GetPhysicalProcessorsAsync();
            _noData = false;

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.Equal($"List is null or empty. (Caller: 'GetPhysicalProcessorsAsync')", result.Exception.Message);
        }
    }
}
