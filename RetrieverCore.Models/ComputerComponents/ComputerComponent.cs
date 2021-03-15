using System.Collections.Generic;
using System.Linq;

namespace RetrieverCore.Models.ComputerComponents
{
    public abstract class ComputerComponent
    {
        public bool IsFine 
        {
            get
            {
                return !Messages.Any();
            }
        }
        public List<string> Messages { get; private set; } = new List<string>();
    }
}
