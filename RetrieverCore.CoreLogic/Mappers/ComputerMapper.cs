using RetrieverCore.Common.Models;
using RetrieverCore.Models.WMIEntieties;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class ComputerMapper
    {
        public static Computer From(Win32_ComputerSystem win32ComputerSystem)
        {
            var output = new Computer();
            var manufacturer = !string.IsNullOrWhiteSpace(win32ComputerSystem.Manufacturer) 
                ? win32ComputerSystem.Manufacturer 
                : "Unknown manufacturer";
            var model = !string.IsNullOrWhiteSpace(win32ComputerSystem.Model)
                ? win32ComputerSystem.Model
                : "Unknown model";
            output.Name = $"{manufacturer} - {model}";
            return output;
        }
    }
}
