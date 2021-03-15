namespace RetrieverCore.Models.ComputerComponents.Physical
{
    public class BatteryComponent : ComputerComponent
    {
        public BatteryComponent(double wearLevel, double chargeLevel, int status, double designedCapacity)
        {
            WearLevel = wearLevel;
            ChargeLevel = chargeLevel;
            Status = status;
            DesignedCapacity = designedCapacity;
        }

        //BaateryFullChargedCapacity, BatteryStaticData, Win32_Battery
        public double WearLevel { get; }
        public double ChargeLevel { get; }
        public int Status { get; }
        public double DesignedCapacity { get; set; }
    }
}
