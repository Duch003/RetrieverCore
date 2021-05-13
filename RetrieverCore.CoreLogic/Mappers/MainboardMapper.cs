using GathererEngine.Decoders;
using RetrieverCore.Common.Models;
using RetrieverCore.Models.WMIEntieties;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class MainboardMapper
    {
        public static Mainboard From(Win32_BaseBoard win32BaseBoard, Win32_MotherboardDevice win32MotherboardDevice)
        {
            var output = new Mainboard();
            output.Availability = AvailabilityDecoder.Decode(win32MotherboardDevice.Availability ?? 0);
            output.Manufacturer = win32BaseBoard.Manufacturer;
            output.Model = win32BaseBoard.Product;
            output.PrimaryBusType = win32MotherboardDevice.PrimaryBusType;
            output.SecondaryBusType = win32MotherboardDevice.SecondaryBusType;

            return output;
        }
    }
}
