using GathererEngine.Decoders;
using GathererEngine.Models;
using RetrieverCore.Models.Common.Win32Entieties;

namespace RetrieverCore.Extensions
{
    public static class CommonPortTypeExtension
    {
        public static CommonPortType MapToCommon(this Win32_SerialPort entity)
        {
            if (entity == null)
            {
                return null;
            }

            var output = new CommonPortType
            {
                Device = entity.ProviderType,
                InternalName = entity.DeviceID,
                ExternalName = entity.Name
            };

            return output;
        }

        public static CommonPortType MapToCommon(this Win32_PortConnector entity)
        {
            if (entity == null)
            {
                return null;
            }

            var output = new CommonPortType
            {
                Device = PortTypeDecoder.Decode(entity.PortType ?? ushort.MaxValue),
                InternalName = entity.InternalReferenceDesignator,
                ExternalName = entity.ExternalReferenceDesignator
            };

            return output;
        }
    }
}
