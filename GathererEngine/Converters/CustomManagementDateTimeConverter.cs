using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Management;

namespace GathererEngine.Converters
{
    internal class CustomManagementDateTimeConverter : DateTimeConverterBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Interoperability", "CA1416:Validate platform compatibility", Justification = "Intended to be used on Windows only.")]
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null)
            {
                return null;
            }
            else if(reader.TokenType == JsonToken.String)
            {
                var raw = (string)reader.Value;
                try
                {
                    return ManagementDateTimeConverter.ToDateTime(raw);
                }
                catch
                {
                    return null;
                }
            }
            else if(reader.TokenType == JsonToken.Date)
            {
                return DateTime.Parse(reader.Value.ToString());
            }
            else
            {
                throw new Exception($"Unexpected token parsing date. Expected date, got {reader.TokenType}.");
            }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
