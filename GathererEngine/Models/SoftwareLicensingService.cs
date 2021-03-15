using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class SoftwareLicensingService : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public string ClientMachineID { get; set; }
        public string DiscoveredKeyManagementServiceMachineIpAddress { get; set; }
        public string DiscoveredKeyManagementServiceMachineName { get; set; }
        public UInt32? DiscoveredKeyManagementServiceMachinePort { get; set; }
        public UInt32? IsKeyManagementServiceMachine { get; set; }
        public UInt32? KeyManagementServiceCurrentCount { get; set; }
        public bool? KeyManagementServiceDnsPublishing { get; set; }
        public UInt32? KeyManagementServiceFailedRequests { get; set; }
        public bool? KeyManagementServiceHostCaching { get; set; }
        public UInt32? KeyManagementServiceLicensedRequests { get; set; }
        public UInt32? KeyManagementServiceListeningPort { get; set; }
        public string KeyManagementServiceLookupDomain { get; set; }
        public bool? KeyManagementServiceLowPriority { get; set; }
        public string KeyManagementServiceMachine { get; set; }
        public UInt32? KeyManagementServiceNonGenuineGraceRequests { get; set; }
        public UInt32? KeyManagementServiceNotificationRequests { get; set; }
        public UInt32? KeyManagementServiceOOBGraceRequests { get; set; }
        public UInt32? KeyManagementServiceOOTGraceRequests { get; set; }
        public UInt32? KeyManagementServicePort { get; set; }
        public string KeyManagementServiceProductKeyID { get; set; }
        public UInt32? KeyManagementServiceTotalRequests { get; set; }
        public UInt32? KeyManagementServiceUnlicensedRequests { get; set; }
        public UInt32? OA2xBiosMarkerMinorVersion { get; set; }
        public UInt32? OA2xBiosMarkerStatus { get; set; }
        public string OA3xOriginalProductKey { get; set; }
        public string OA3xOriginalProductKeyDescription { get; set; }
        public string OA3xOriginalProductKeyPkPn { get; set; }
        public UInt32? PolicyCacheRefreshRequired { get; set; }
        public UInt32? RemainingWindowsReArmCount { get; set; }
        public UInt32? RequiredClientCount { get; set; }
        public string TokenActivationAdditionalInfo { get; set; }
        public string TokenActivationCertificateThumbprint { get; set; }
        public UInt32? TokenActivationGrantNumber { get; set; }
        public string TokenActivationILID { get; set; }
        public UInt32? TokenActivationILVID { get; set; }
        public string Version { get; set; }
        public UInt32? VLActivationInterval { get; set; }
        public UInt32? VLRenewalInterval { get; set; }
    }
}
