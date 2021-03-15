using GathererEngine.Extensions;
using GathererEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace GathererEngine
{
    public class GathererEngine : IGathererEngine
    {
        private string _assemblyName = "RetrieverCore.Models";
        private string _namespacePart = "GathererEngine.Models.";

        public GathererEngine()
        {

        }

        public List<T> GatherDeviceData<T>(string scope, string conditions = null) where T : new()
        {
            var output = new List<T>();
            var win32class = typeof(T).Name;
            var properties = GetProperties<T>();
            var query = GetQuery<T>(win32class, conditions);

            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var collection = searcher.Get();

                foreach (var managementObject in collection)
                {
                    var outputObject = new T();

                    foreach (var property in properties)
                    {
                        if (outputObject.GetType().GetProperty(property).PropertyType.Name == nameof(DateTime) && managementObject[property] != null)
                        {
                            var value = ManagementDateTimeConverter
                                .ToDateTime(managementObject[property].ToString());

                            outputObject
                                .GetType()
                                .GetProperty(property)
                                .SetValue(outputObject, value, Array.Empty<object>());
                        }
                        else
                        {
                            var value = managementObject[property] is null
                                ? managementObject[property]
                                    .GetType()
                                    .GetDefault()
                                : managementObject[property];

                            outputObject
                                .GetType()
                                .GetProperty(property)
                                .SetValue(outputObject, value, Array.Empty<object>());
                        }
                    }

                    output.Add(outputObject);
                }
            }

            return output;
        }

        //private IEnumerable<string> GetAllWin32Entities()
        //{
        //    return _assemblyReader.GetTypes(_namespacePart, _assemblyName);
        //}

        //private string GetWin32EntityScope(string win32EntityClass)
        //{
        //    var fullyQualifiedName = _namespacePart + win32EntityClass;
        //    return _assemblyReader.GetTypeField(fullyQualifiedName, "Scope", _assemblyName);
        //}

        //private string GetWin32EntityConditions(string win32EntityClass)
        //{
        //    var fullyQualifiedName = _namespacePart + win32EntityClass;
        //    return _assemblyReader.GetTypeField(fullyQualifiedName, "Conditions", _assemblyName);
        //}

        private string GetQuery<T>(string win32class, string conditions) where T : new()
        {
            var properties = string.Join(", ", typeof(T)
                .GetType()
                .GetProperties()
                .Where(x => x.GetCustomAttributes(true).Any(a => a is UseAttribute))
                .Select(x => x.Name));

            return $"SELECT {properties} FROM {win32class}"
                + ( string.IsNullOrWhiteSpace(conditions) ? string.Empty : $" WHERE {conditions}" );
        }

        //private string GetAllQuery(string win32class, string conditions)
        //{
        //    return $"SELECT * FROM {win32class}"
        //        + ( string.IsNullOrWhiteSpace(conditions) ? string.Empty : $" WHERE {conditions}" );
        //}

        private IEnumerable<string> GetProperties<T>() where T : new()
        {
            return typeof(T)
                .GetType()
                .GetProperties()
                .Select(x => x.Name);
        }
    }
}
