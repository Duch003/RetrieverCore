using System.Collections.Generic;

namespace RetrieverCore.IO.Types
{
    public interface IAssemblyReader
    {
        IEnumerable<string> GetTypes(string namespacePart, string assembly);
        string GetTypeField(string type, string field, string assembly);
    }
}