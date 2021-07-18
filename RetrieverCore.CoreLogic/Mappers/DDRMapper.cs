using GathererEngine.Decoders;
using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models;
using RetrieverCore.Models.WMIEntieties;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class DDRMapper
    {
        public static DDR From(Win32_PhysicalMemory win32PhysicalMemory)
        {
            var output = new DDR();
            output.Capacity = win32PhysicalMemory.Capacity.HasValue 
                ? (double)win32PhysicalMemory.Capacity.Value / Constants.Gibibyte
                : double.NaN;
            output.Clocking = win32PhysicalMemory.ConfiguredClockSpeed.HasValue
                ? (int)win32PhysicalMemory.ConfiguredClockSpeed.Value
                : Constants.DefaultNumericValue;
            output.FormFactor = FormFactorDecoder.Decode(win32PhysicalMemory.FormFactor ?? 0);
            output.Vendor = string.IsNullOrWhiteSpace(win32PhysicalMemory.Manufacturer) 
                ? "Unknown manufacturer" 
                : win32PhysicalMemory.Manufacturer;

            return output;
        }
    }
}
