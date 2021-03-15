using GathererEngine.Decoders;
using GathererEngine.Models;
using RetrieverCore.Extensions;
using RetrieverCore.TestDataGenerator.WindowsEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RetrieverCore.ExtensionsTests
{
    public class DiskPartitionExtensionTests
    {
        private Win32_DiskPartition _win32_DiskPartition = Win32_DiskPartitionFactory.GetForDiskPartitionExtensionTests();
        private Win32_LogicalDisk _win32_LogicalDisk = Win32_LogicalDiskFactory.GetForDiskPartitionExtensionTests();

        private Win32_DiskPartition _nullDiskPartition = null;
        private Win32_LogicalDisk _nullLogicalDisk = null;

        [Fact]
        public void ToDiskPartition_Win32DiskPartition_AllInputsAreValid_ReturnsDiskPartition()
        {
            //Arrange

            //Act
            var result = _win32_DiskPartition.ToDiskPartition(_win32_LogicalDisk);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Description, _win32_DiskPartition.Description);
            Assert.Equal(result.DeviceType, _win32_DiskPartition.Type);
            Assert.Equal(result.IsBootable, _win32_DiskPartition.Bootable);
            Assert.Equal(result.IsBootPartition, _win32_DiskPartition.BootPartition);
            Assert.Equal(result.IsPrimaryPartition, _win32_DiskPartition.PrimaryPartition);
            Assert.Equal(result.Size, _win32_DiskPartition.Size);

            Assert.Equal(result.LogicalDiskMediaType, LogicalDiskMediaTypeDecoder.Decode(_win32_LogicalDisk.MediaType.Value));
            Assert.Equal(result.FileSystem, _win32_LogicalDisk.FileSystem);
            Assert.Equal(result.VolumeName, _win32_LogicalDisk.VolumeName);
        }

        [Fact]
        public void ToDiskPartition_Win32DiskPartition_DiskPartitionIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullDiskPartition.ToDiskPartition(_win32_LogicalDisk);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToDiskPartition_Win32DiskPartition_BothInputsAreNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullDiskPartition.ToDiskPartition(_nullLogicalDisk);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToDiskPartition_Win32LogicalDisk_AllInputsAreValid_ReturnsDiskPartition()
        {
            //Arrange

            //Act
            var result = _win32_LogicalDisk.ToDiskPartition(_win32_DiskPartition);

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Description, _win32_DiskPartition.Description);
            Assert.Equal(result.DeviceType, _win32_DiskPartition.Type);
            Assert.Equal(result.IsBootable, _win32_DiskPartition.Bootable);
            Assert.Equal(result.IsBootPartition, _win32_DiskPartition.BootPartition);
            Assert.Equal(result.IsPrimaryPartition, _win32_DiskPartition.PrimaryPartition);
            Assert.Equal(result.Size, _win32_DiskPartition.Size);

            Assert.Equal(result.LogicalDiskMediaType, LogicalDiskMediaTypeDecoder.Decode(_win32_LogicalDisk.MediaType.Value));
            Assert.Equal(result.FileSystem, _win32_LogicalDisk.FileSystem);
            Assert.Equal(result.VolumeName, _win32_LogicalDisk.VolumeName);
        }

        [Fact]
        public void ToDiskPartition_Win32LogicalDisk_DiskPartitionIsNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _win32_LogicalDisk.ToDiskPartition(_nullDiskPartition);

            //Assert
            Assert.Null(result);
        }

        [Fact]
        public void ToDiskPartition_Win32LogicalDisk_BothInputsAreNull_ReturnsNull()
        {
            //Arrange

            //Act
            var result = _nullLogicalDisk.ToDiskPartition(_nullDiskPartition);

            //Assert
            Assert.Null(result);
        }
    }
}
