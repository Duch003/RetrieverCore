using GathererEngine;
using RetrieverCore.Models.WMIEntieties;
using RetrieverCore.Models.WMIEntieties.Base;
using RetrieverCore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Local
{
    public class GenericComponentRepository : IGenericComponentRepository
    {
        private static Dictionary<string, IEnumerable<object>> _cache;
        private readonly IGathererEngine _gathererEngine;

        public GenericComponentRepository(IGathererEngine gathererEngine)
        {
            _gathererEngine = gathererEngine;
            _cache = new Dictionary<string, IEnumerable<object>>();
        }

        public virtual IEnumerable<T> Get<T>() where T : WmiEntityBase, new()
        {
            if (_cache.ContainsKey(typeof(T).Name))
            {
                return _cache[typeof(T).Name] as IEnumerable<T>;
            }

            return new List<T>();
        }

        private void Load<T>(T instance) where T : WmiEntityBase, new()
        {
            _cache[instance.GetType().Name] = _gathererEngine.GatherDeviceData<T>(instance.Scope, null, instance.Omit.ToArray());
        }

        public virtual async Task PreloadData()
        {
            await Task.WhenAll(
                Task.Run(() => Load(new BatteryFullChargedCapacity())),
                Task.Run(() => Load(new BatteryStaticData())),
                Task.Run(() => Load(new MSFT_PhysicalDisk())),
                Task.Run(() => Load(new SoftwareLicensingProduct())),
                Task.Run(() => Load(new SoftwareLicensingService())),
                Task.Run(() => Load(new Win32_BaseBoard())),
                Task.Run(() => Load(new Win32_Battery())),
                Task.Run(() => Load(new Win32_ComputerSystem())),
                Task.Run(() => Load(new Win32_DiskDrive())),
                Task.Run(() => Load(new Win32_DiskPartition())),
                Task.Run(() => Load(new Win32_LogicalDisk())),
                Task.Run(() => Load(new Win32_NetworkAdapter())),
                Task.Run(() => Load(new Win32_PhysicalMemory())),
                Task.Run(() => Load(new Win32_PortConnector())),
                Task.Run(() => Load(new Win32_Processor())),
                Task.Run(() => Load(new Win32_SerialPort())),
                Task.Run(() => Load(new Win32_VideoController()))
            );
        }
    }
}
