using GathererEngine.Models;
using System.Collections.Generic;

namespace RetrieverCore.TestDataGenerator.WindowsEntities
{
    public static class Win32_PortConnectorFactory
    {
        public static List<Win32_PortConnector> GetForMainboardPortsServiceTests()
        {
            var output = new List<Win32_PortConnector>();

            output.Add(new Win32_PortConnector
            {
                PortType = 16,
                ExternalReferenceDesignator = "USB1",
                InternalReferenceDesignator = "J3A1"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 28,
                ExternalReferenceDesignator = "Video",
                InternalReferenceDesignator = "J2A2B"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 0,
                ExternalReferenceDesignator = null,
                InternalReferenceDesignator = "JXDP1 - CPU XDP Port"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 9,
                ExternalReferenceDesignator = "COM A",
                InternalReferenceDesignator = "J2A2A"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 0,
                ExternalReferenceDesignator = null,
                InternalReferenceDesignator = "J9E3 - LPC HOT DOCKING"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 29,
                ExternalReferenceDesignator = null,
                InternalReferenceDesignator = "JSPK1 - Speaker"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 0,
                ExternalReferenceDesignator = "Camera",
                InternalReferenceDesignator = "JEDP1"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 0,
                ExternalReferenceDesignator = "Finger Print sensor",
                InternalReferenceDesignator = "JFP1"
            });

            return output;
        }

        public static List<Win32_PortConnector> GetForWin32_PortConnectorExtensionTests()
        {
            var output = new List<Win32_PortConnector>();

            output.Add(new Win32_PortConnector
            {
                PortType = 16,
                ExternalReferenceDesignator = "USB1",
                InternalReferenceDesignator = "J3A1"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 28,
                ExternalReferenceDesignator = "Video",
                InternalReferenceDesignator = "J2A2B"
            });
            output.Add(new Win32_PortConnector
            {
                PortType = 0,
                ExternalReferenceDesignator = null,
                InternalReferenceDesignator = "JXDP1 - CPU XDP Port"
            });

            return output;
        }
    }
}
