using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace RetrieverCore.IO.Gatherer
{
    public class GathererEngine
    {
        public List<T> GatherDeviceData<T>(string scope, string conditions = null) where T : new()
        {
            var output = new List<T>();
            var win32class = new T().GetType().Name;
            var properties = GetProperties<T>();
            var query = GetQuery<T>(win32class, conditions);
            try
            {
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
                                var value = ManagementDateTimeConverter.ToDateTime(managementObject[property].ToString());
                                outputObject
                                    .GetType()
                                    .GetProperty(property)
                                    .SetValue(outputObject, value, new object[] { });
                            }
                            else
                            {
                                outputObject
                                    .GetType()
                                    .GetProperty(property)
                                    .SetValue(outputObject, managementObject[property], new object[] { });
                            }
                        }

                        output.Add(outputObject);
                    }
                }
            }
            catch(ManagementException me)
            {
                if (me.Message == "Access Denied")
                {
                    var message = $"Could not retrieve information from {nameof(T)}. An administrator privleges are required.";
                    var exception = new UnauthorizedAccessException(message, me);
                    throw exception;
                }
                else
                {
                    throw;
                }
            }
           
            return output;
        }

        private string GetQuery<T>(string win32class, string conditions) where T : new()
        {
            var properties = string.Join(", ", new T()
                .GetType()
                .GetProperties()
                .Select(x => x.Name));

            return $"SELECT {properties} FROM {win32class}" 
                + (string.IsNullOrWhiteSpace(conditions) ? string.Empty : $" WHERE {conditions}");
        }

        private IEnumerable<string> GetProperties<T>() where T : new()
        {
            return new T()
                .GetType()
                .GetProperties()
                .Select(x => x.Name);
        }
    }
}
