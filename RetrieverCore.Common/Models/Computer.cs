using Databases.RetrieverCore.Common.Models.Base;
using System.Collections.Generic;

namespace Databases.RetrieverCore.Common.Models
{
    public class Computer : EntityBase
    {
        public string Name { get; set; }
        public virtual IList<Battery> Batteries { get; set; }
        public virtual IList<CPU> CPUs { get; set; }
        public virtual IList<GPU> GPUs { get; set; }
        public virtual IList<DDR> DDRs { get; set; }
        public virtual IList<Mainboard> Mainboards { get; set; }
        public virtual IList<NetworkInterface> NetworkInterfaces { get; set; }
        public virtual IList<Storage> Storages { get; set; }
    }
}
