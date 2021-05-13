using System.Collections.Generic;
using System.Linq;

namespace RetrieverCore.Models.WMIEntieties.Base
{
    public abstract class WmiEntityBase
    {
        public List<string> Omit { get; }
        public string Scope { get; protected set; }

        public WmiEntityBase()
        {
            Omit = this.GetType().GetProperties().Select(x => x.Name).ToList();
        }
    }
}
