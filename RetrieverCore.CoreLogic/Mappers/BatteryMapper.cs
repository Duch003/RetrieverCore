using Databases.RetrieverCore.Common.Models;
using RetrieverCore.Models.WMIEntieties;
using System;

namespace RetrieverCore.CoreLogic.Mappers
{
    public static class BatteryMapper
    {
        public static Battery From(BatteryFullChargedCapacity fullChargedCapacity, Win32_Battery win32Battery, BatteryStaticData staticData)
        {
            var output = new Battery();
            output.WearLevel = CalculateVearLevel(fullChargedCapacity.FullChargedCapacity ?? double.NaN, staticData.DesignedCapacity ?? double.NaN);
            output.ChargeLevel = win32Battery.EstimatedChargeRemaining ?? double.NaN;
            output.Status = win32Battery.BatteryStatus ?? -1;
            output.DesignedCapacity = staticData.DesignedCapacity ?? double.NaN;
            return output;
        }

        private static double CalculateVearLevel(double fullChargeCapacity, double designedCapacity)
        {
            if (double.IsNaN(fullChargeCapacity) || double.IsNaN(designedCapacity) || designedCapacity == 0)
            {
                return double.NaN;
            }

            return Math.Round((1 - ( fullChargeCapacity / designedCapacity )) * 100, 2);
        }
    }
}
