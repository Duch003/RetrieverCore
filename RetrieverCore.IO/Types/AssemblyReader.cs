using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RetrieverCore.IO.Types
{
    public class AssemblyReader : IAssemblyReader
    {
        public IEnumerable<string> GetTypes(string namespacePart, string assembly)
        {
            var loadedAssembly = Assembly.Load(assembly);

            var output = loadedAssembly
                .GetTypes()
                .Where(x => x.FullName.Contains(namespacePart))
                .Select(x => x.Name)
                .ToList();
            return output;
        }

        public string GetTypeField(string type, string field, string assembly)
        {
            var instance = Activator.CreateInstance(assembly, type);
            var thisClassInstance = instance.Unwrap();

            if(thisClassInstance.GetType().GetField(field, BindingFlags.Static | BindingFlags.Public) != null)
            {
                return thisClassInstance.GetType().GetField(field, BindingFlags.Static | BindingFlags.Public).GetValue(thisClassInstance)?.ToString();
            }
            else
            {
                return null;
            }
        }
    }
}
