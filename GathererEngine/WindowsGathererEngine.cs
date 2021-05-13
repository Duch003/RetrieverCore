using GathererEngine.Extensions;
using GathererEngine.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;

namespace GathererEngine
{
    public class WindowsGathererEngine : IGathererEngine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Meant to be used only on Windows machiines.")]
        public List<T> GatherDeviceData<T>(string scope, string conditions = null, params string[] omit) where T : new()
        {
            var output = new List<T>();
            var win32class = typeof(T).Name;
            var properties = GetProperties<T>();
            var query = GetQuery<T>(win32class, conditions, omit);

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Meant to be used only on Windows machiines.")]
        public List<Dictionary<string, object>> GatherDeviceData(string win32class, string scope, string conditions = null, params string[] properties)
        {
            if (!properties.Any())
            {
                properties = new string[] { "*" };
            }
            var output = new List<Dictionary<string, object>>();
            var query = GetQuery(win32class, conditions, properties);

            using (var searcher = new ManagementObjectSearcher(scope, query))
            {
                var collection = searcher.Get();

                foreach (var managementObject in collection)
                {
                    var outputObject = new Dictionary<string, object>();

                    foreach (var property in properties)
                    {
                        if (outputObject.GetType().GetProperty(property).PropertyType.Name == nameof(DateTime) && managementObject[property] != null)
                        {
                            var value = ManagementDateTimeConverter
                                .ToDateTime(managementObject[property].ToString());

                            outputObject[property] = value;
                        }
                        else
                        {
                            var value = managementObject[property] is null
                                ? managementObject[property]
                                    .GetType()
                                    .GetDefault()
                                : managementObject[property];

                            outputObject[property] = value;
                        }
                    }

                    output.Add(outputObject);
                }
            }

            return output;
        }

        private string GetQuery<T>(string win32class, string conditions, params string[] omit) where T : new()
        {
            var properties = string.Join(", ", typeof(T)
                .GetType()
                .GetProperties()
                .Where(x => !omit.Contains(x.Name))
                .Select(x => x.Name));

            return $"SELECT {properties} FROM {win32class}"
                + ( string.IsNullOrWhiteSpace(conditions) ? string.Empty : $" WHERE {conditions}" );
        }

        private string GetQuery(string win32class, string conditions, string[] properties)
        {
            var classProps = string.Join(", ", properties);
            return $"SELECT {classProps} FROM {win32class}"
                + ( string.IsNullOrWhiteSpace(conditions) ? string.Empty : $" WHERE {conditions}" );
        }

        private IEnumerable<string> GetProperties<T>() where T : new()
        {
            return typeof(T)
                .GetType()
                .GetProperties()
                .Select(x => x.Name);
        }
    }
}
