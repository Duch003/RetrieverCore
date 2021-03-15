using RetrieverCore.LocalDatabase.Models;
using GathererEngine.Decoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetrieverCore.TestDataGenerator.Database
{
    public static class MainboardPortEntityFactory
    {
        public static List<MainboardPortEntity> GetForMainboardPortServiceTests()
        {
            var output = new List<MainboardPortEntity>();

            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(16),
                ExternalName = "USB1",
                InternalName = "J3A1"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(28),
                ExternalName = "Video",
                InternalName = "J2A2B"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(0),
                ExternalName = null,
                InternalName = "JXDP1 - CPU XDP Port"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(9),
                ExternalName = "COM A",
                InternalName = "J2A2A"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(0),
                ExternalName = null,
                InternalName = "J9E3 - LPC HOT DOCKING"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(29),
                ExternalName = null,
                InternalName = "JSPK1 - Speaker"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(0),
                ExternalName = "Camera",
                InternalName = "JEDP1"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = PortTypeDecoder.Decode(0),
                ExternalName = "Finger Print sensor",
                InternalName = "JFP1"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = "RS232 Serial Port",
                InternalName = "COM3",
                ExternalName = "Intel(R) Active Management Technology - SOL (COM3)"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = "RS232 Serial Port",
                InternalName = "COM4",
                ExternalName = "Standardowy port szeregowy przez link Bluetooth (COM4)"
            });
            output.Add(new MainboardPortEntity
            {
                PortType = null,
                InternalName = "COM5",
                ExternalName = "Standardowy port szeregowy przez link Bluetooth (COM5)"
            });

            return output;
        }
    }
}
