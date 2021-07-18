using Databases.RetrieverCore.Common.Models.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Databases.RetrieverCore.Common.Models
{
    public class Battery : EntityBase
    {
        //BaateryFullChargedCapacity, BatteryStaticData, Win32_Battery
        public double WearLevel { get; set; }
        [NotMapped]
        public double ChargeLevel { get; set; }
        public int Status { get; set; }
        public double DesignedCapacity { get; set; }
    }
}
