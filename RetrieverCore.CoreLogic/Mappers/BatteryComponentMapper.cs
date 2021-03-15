using RetrieverCore.Models.ComputerComponents.Physical;
using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class BatteryComponentMapper
    {
        public static BatteryComponent From(BatteryFullChargedCapacity fullChargedCapacity, Win32_Battery win32Battery, BatteryStaticData staticData)
        {
            return new BatteryComponent(
                wearLevel: CalculateVearLevel(
                    fullChargedCapacity.FullChargedCapacity ?? double.NaN,
                    staticData.DesignedCapacity ?? double.NaN),
                chargeLevel: win32Battery.EstimatedChargeRemaining ?? double.NaN,
                status: win32Battery.BatteryStatus ?? -1,
                designedCapacity: staticData.DesignedCapacity ?? double.NaN
            );
        }

        public static BatteryComponent From(BatteryEntity entity, double maxWearLevel)
        {
            return new BatteryComponent(
                wearLevel: maxWearLevel,
                chargeLevel: -1,
                status: -1,
                designedCapacity: entity.DesignedCapacity
            );
        }

        private static double CalculateVearLevel(double fullChargeCapacity, double designedCapacity)
        {
            if (double.IsNaN(fullChargeCapacity) || double.IsNaN(designedCapacity))
            {
                return double.NaN;
            }

            var rawlevel = 1 - ( fullChargeCapacity / designedCapacity );
            var wearlevel = Math.Round(rawlevel, 2);

            return wearlevel * 100;
        }
    }
}
