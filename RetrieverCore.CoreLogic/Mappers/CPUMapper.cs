using GathererEngine.Decoders;
using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models;
using RetrieverCore.Models.WMIEntieties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class CPUMapper
    {
        public static CPU From(Win32_Processor win32Processor)
        {
            var output = new CPU();
            output.Architecture = ArchitectureDecoder.Decode(win32Processor.Architecture ?? ushort.MaxValue);
            output.CurrentClockSpeed = (int?)win32Processor.CurrentClockSpeed ?? Constants.DefaultNumericValue;
            output.L2CacheSize = (int?)win32Processor.L2CacheSize ?? Constants.DefaultNumericValue;
            output.L3CacheSize = (int?)win32Processor.L3CacheSize ?? Constants.DefaultNumericValue;
            output.ModelWithVendor = string.IsNullOrWhiteSpace(win32Processor.Name) 
                ? "Unknown" 
                : win32Processor.Name;
            output.NumberOfCores = (int?)win32Processor.NumberOfCores ?? Constants.DefaultNumericValue;
            output.NumberOfLogicalProcessors = (int?)win32Processor.NumberOfLogicalProcessors ?? Constants.DefaultNumericValue;
            output.ProcessorType = ProcessorTypeDecoder.Decode(win32Processor.ProcessorType ?? 0);
            output.Caption = string.IsNullOrWhiteSpace(win32Processor.Caption) 
                ? "-" 
                : win32Processor.Caption;
            output.Family = FamilyDecoder.Decode(win32Processor.Family ?? 0);
            output.UpgradeMethod = UpgrageMethodDecoder.Decode(win32Processor.UpgradeMethod ?? 0);

            return output;
        }
    }
}
