using RetrieverCore.Models.WMIEntieties.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IGenericComponentRepository
    {
        IEnumerable<T> Get<T>() where T : WmiEntityBase, new();
        Task PreloadData();
    }
}