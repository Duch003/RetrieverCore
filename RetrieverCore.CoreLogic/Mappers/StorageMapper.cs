using GathererEngine.Decoders;
using RetrieverCore.Common.Models;
using RetrieverCore.Models;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class StorageMapper
    {
        public static Storage From(Win32_DiskDrive win32DiskDrive, MSFT_PhysicalDisk msftPhysicalDisk, IEnumerable<Partition> partitions)
        {
            var output = new Storage();
            output.Capacity = win32DiskDrive.Size.HasValue 
                ? win32DiskDrive.Size.Value / Constants.Gibibyte
                : Constants.DefaultNumericValue;
            output.DiskDriveMediaType = win32DiskDrive.MediaType;
            output.InterfaceType = win32DiskDrive.InterfaceType;
            output.Caption = win32DiskDrive.Caption;
            output.Capabilities = win32DiskDrive.CapabilityDescriptions;
            output.Model = win32DiskDrive.Model;
            output.Partitions = partitions;
            output.PhysicalDiskMediaType = PhysicalDiskMediaTypeDecoder.Decode(msftPhysicalDisk.MediaType ?? 0);
            output.BusType = BusTypeDecoder.Decode(msftPhysicalDisk.BusType ?? 0);

            return output;
        }
    }
}
