using Moq;
using Databases.RetrieverCore.Common.Models;
using RetrieverCore.CoreLogic.Interfaces;
using RetrieverCore.CoreLogic.Services;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.CoreLogicTests.Services
{
    public class ComputerServiceTests : IDisposable
    {
        private IComputerService _service;

        private Mock<IGenericDatabaseRepository<Computer>> _mockComputerRepo;
        private Mock<IGenericComponentRepository> _mockComponentRepo;

        private Win32_ComputerSystem _win32ComputerSystem;
        private List<Win32_ComputerSystem> _win32ComputerSystems;

        private Computer _computer1;
        private Computer _computer2;
        private Computer _computer3;
        private List<Computer> _computers;

        private List<string> _includes;
        private bool _batteryException;
        private bool _win32ComputerSystemException;

        public ComputerServiceTests()
        {
            SetupData();
            SetupRepositories();
            SetupService();
        }
        public void Dispose()
        {
            _service = null;
            _mockComputerRepo = null;
            _mockComponentRepo = null;
            _win32ComputerSystem = null;
            _win32ComputerSystems = null;
            _computer1 = null;
            _computer2 = null;
            _computer3 = null;
            _computers = null;
            _includes = null;
            GC.SuppressFinalize(this);
        }

        #region Tests
        [Fact]
        public async Task GetDesignedComputersAsync_NoErrorsWhileQueryingDatabase_ReturnsResultWithSuccess()
        {
            //Arrange
            //Act
            var result = await _service.GetDesignedComputersAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 2);
            Assert.True(result.Output.ToList()[0] == _computer1);
            Assert.True(result.Output.ToList()[1] == _computer3);
            Assert.True(_includes.Count == 0);
        }

        [Fact]
        public async Task GetDesignedComputersAsync_ErrorWhileQueryingDatabase_ReturnsResultWithFailure()
        {
            //Arrange
            _batteryException = true;

            //Act
            var result = await _service.GetDesignedComputersAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Computer).Name);
        }

        [Fact]
        public async Task GetPhysicalComputersAsync_NoErrorWhileExecutingWMIQuery_ReturnsResultWithSuccess()
        {
            //Arrange
            //Act
            var result = await _service.GetPhysicalComputersAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 1);
        }

        [Fact]
        public async Task GetPhysicalComputersAsync_NoComponentFound_ReturnsResultWithSuccess()
        {
            //Arrange
            _win32ComputerSystems.Clear();

            //Act
            var result = await _service.GetPhysicalComputersAsync();

            //Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.Null(result.Exception);
            Assert.NotNull(result.Output);
            Assert.True(result.Output.Count() == 0);
        }

        [Fact]
        public async Task GetPhysicalComputersAsync_ErrorWhileGatheringWin32ComputerSystemData_ReturnsResultWithFailure()
        {
            //Arrange
            _win32ComputerSystemException = true;

            //Act
            var result = await _service.GetPhysicalComputersAsync();

            //Assert
            Assert.NotNull(result);
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.Exception);
            Assert.Null(result.Output);
            Assert.True(result.Exception.Message == typeof(Win32_ComputerSystem).Name);
        }
        #endregion

        #region Private methods
        private void SetupData()
        {
            _win32ComputerSystem = new Win32_ComputerSystem
            {
                Model = "Model",
                Manufacturer = "Manufacturer"
            };
            _win32ComputerSystems = new List<Win32_ComputerSystem> { _win32ComputerSystem };

            _computer1 = new Computer
            {
                ID = 1,
                Deleted = false,
                Name = "Model1 - Manufacturer1"
            };
            _computer2 = new Computer
            {
                ID = 2,
                Deleted = true,
                Name = "Model2 - Manufacturer2"
            };
            _computer3 = new Computer
            {
                ID = 3,
                Deleted = false,
                Name = "Model3 - Manufacturer3"
            };
            _computers = new List<Computer> { _computer1, _computer2, _computer3 };

            _includes = new List<string>();
            _win32ComputerSystemException = false;
            _batteryException = false;
        }

        private void SetupRepositories()
        {
            _mockComputerRepo = new Mock<IGenericDatabaseRepository<Computer>>();
            _mockComputerRepo.Setup(x => x.GetAsync(It.IsAny<Expression<Func<Computer, bool>>>(), It.IsAny<Expression<Func<Computer, object>>[]>()))
                .Returns<Expression<Func<Computer, bool>>, Expression<Func<Computer, object>>[]>((conditions, includes) =>
                {
                    foreach(var include in includes)
                    {
                        _includes.Add(include.Body.ToString());
                    }
                    if (_batteryException)
                    {
                        throw new Exception(typeof(Computer).Name);
                    }
                    return Task.FromResult(_computers.Where(conditions.Compile()).ToList().AsEnumerable());
                });

            _mockComponentRepo = new Mock<IGenericComponentRepository>();
            _mockComponentRepo.Setup(x => x.Get<Win32_ComputerSystem>())
                .Returns(() =>
                {
                    if (_win32ComputerSystemException)
                    {
                        throw new Exception(typeof(Win32_ComputerSystem).Name);
                    }
                    return _win32ComputerSystems.AsEnumerable();
                });
        }

        private void SetupService()
        {
            _service = new ComputerService(_mockComputerRepo.Object, _mockComponentRepo.Object);
        }
        #endregion
    }
}
