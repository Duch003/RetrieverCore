using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RetrieverCore.Repositories.Interfaces
{
    public interface IMainboardPortRepository
    {
        Task<IEnumerable<MainboardPortEntity>> GetDesignedMainboardPortsAsync(string model);
        Task<IEnumerable<Win32_PortConnector>> GetWin32PortConnectorsAsync();
        Task<IEnumerable<Win32_SerialPort>> GetWin32SerialPortsAsync();
    }
}