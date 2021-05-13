using System.Collections.Generic;

namespace GathererEngine
{
    public interface IGathererEngine
    {
        List<T> GatherDeviceData<T>(string scope, string conditions = null, params string[] omit) where T : new();
        List<Dictionary<string, object>> GatherDeviceData(string win32class, string scope, string conditions = null, params string[] properties);
    }
}