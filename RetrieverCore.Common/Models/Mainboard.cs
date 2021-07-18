using Databases.RetrieverCore.Common.Models.Base;

namespace Databases.RetrieverCore.Common.Models
{
    public class Mainboard : EntityBase
    {
        //Win32_BaseBoard
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        //Win32_MotherboardDevice
        public string PrimaryBusType { get; set; }
        public string SecondaryBusType { get; set; }
        ////MSAcpi_ThermalZoneTemperature ADMIN
        //public IEnumerable<TemperatureSensor> TemperatureSensors { get; set; }
        ////Win32_PortConnector
        //public IEnumerable<Port> Ports { get; set; }
        //Win32_Processor
        //public IEnumerable<CPU> CPUs { get; set; }
    }
}
