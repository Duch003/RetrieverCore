using RetrieverCore.Models.ComputerComponents.Ports;
using RetrieverCore.Models.ComputerComponents.Sensors;
using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class MainboardComponent
    {
        //Win32_BaseBoard
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        //Win32_MotherboardDevice
        public string PrimaryBusType { get; set; }
        public string SecondaryBusType { get; set; }
        public string Status { get; set; }
        public string Availability { get; set; }
        //MSAcpi_ThermalZoneTemperature ADMIN
        public IEnumerable<TemperatureSensor> TemperatureSensors { get; set; }
        //Win32_PortConnector
        public IEnumerable<Port> Ports { get; set; }
        //Win32_Processor
        public IEnumerable<ProcessorComponent> CPUs { get; set; }


    }
}
