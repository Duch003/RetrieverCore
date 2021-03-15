using System;
using System.Collections.Generic;
using System.Text;

namespace RetrieverCore.Models.ComputerComponents.Sensors
{
    public class TemperatureSensor
    {
        public int CurrentTemperature { get; set; }
        public bool IsActive { get; set; }
        public int CriticalPoint { get; set; }
        public int ThermalStamp { get; set; }
    }
}
