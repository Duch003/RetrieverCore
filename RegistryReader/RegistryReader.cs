using Microsoft.Win32;
using System.IO;
using System.Security;

namespace RegistryReader
{
    public class RegistryReader : IRegistryReader
    {
        public string ReadRegistryKey(string path, string property, string defaultValue)
        {
            try
            {
                return Registry.GetValue(path, property, defaultValue)?.ToString();
            }
            catch (SecurityException e)
            {
                var message = $"Current user has no permission to read given registry key: {path}, property: <<{property}>>";
                throw new IOException(message, e);
            }
        }
    }
}
