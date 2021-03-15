using System.Collections.Generic;

namespace GathererEngine
{
    public interface IGathererEngine
    {
        List<T> GatherDeviceData<T>(string scope, string conditions = null) where T : new();
    }
}