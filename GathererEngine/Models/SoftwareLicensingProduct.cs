using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class SoftwareLicensingProduct : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public const string Conditions = "ApplicationID = '55c92734-d682-4d71-983e-d6ec3f16059f' AND PartialProductKey != null";
        public string ADActivationCsvlkPid { get; set; }
        public string ADActivationCsvlkSkuId { get; set; }
        public string ADActivationObjectDN { get; set; }
        public string ADActivationObjectName { get; set; }
        public string ApplicationID { get; set; }
        public string AutomaticVMActivationHostDigitalPid2 { get; set; }
        public string AutomaticVMActivationHostMachineName { get; set; }
        public DateTime? AutomaticVMActivationLastActivationTime { get; set; }
        public string Description { get; set; }
        public string DiscoveredKeyManagementServiceMachineIpAddress { get; set; }
        public string DiscoveredKeyManagementServiceMachineName { get; set; }
        public UInt32? DiscoveredKeyManagementServiceMachinePort { get; set; }
        public DateTime? EvaluationEndDate { get; set; }
        public UInt32? ExtendedGrace { get; set; }
        public UInt32? GenuineStatus { get; set; }
        public UInt32? GracePeriodRemaining { get; set; }
        public string IAID { get; set; }
        public string ID { get; set; }
        public UInt32? IsKeyManagementServiceMachine { get; set; }
        public UInt32? KeyManagementServiceCurrentCount { get; set; }
        public UInt32? KeyManagementServiceFailedRequests { get; set; }
        public UInt32? KeyManagementServiceLicensedRequests { get; set; }
        public string KeyManagementServiceLookupDomain { get; set; }
        public string KeyManagementServiceMachine { get; set; }
        public UInt32? KeyManagementServiceNonGenuineGraceRequests { get; set; }
        public UInt32? KeyManagementServiceNotificationRequests { get; set; }
        public UInt32? KeyManagementServiceOOBGraceRequests { get; set; }
        public UInt32? KeyManagementServiceOOTGraceRequests { get; set; }
        public UInt32? KeyManagementServicePort { get; set; }
        public string KeyManagementServiceProductKeyID { get; set; }
        public UInt32? KeyManagementServiceTotalRequests { get; set; }
        public UInt32? KeyManagementServiceUnlicensedRequests { get; set; }
        public string LicenseDependsOn { get; set; }
        public string LicenseFamily { get; set; }
        public bool? LicenseIsAddon { get; set; }
        public UInt32? LicenseStatus { get; set; }
        public UInt32? LicenseStatusReason { get; set; }
        public string MachineURL { get; set; }
        public string Name { get; set; }
        public string OfflineInstallationId { get; set; }
        public string PartialProductKey { get; set; }
        public string ProcessorURL { get; set; }
        public string ProductKeyChannel { get; set; }
        public string ProductKeyID { get; set; }
        public string ProductKeyID2 { get; set; }
        public string ProductKeyURL { get; set; }
        public UInt32? RemainingAppReArmCount { get; set; }
        public UInt32? RemainingSkuReArmCount { get; set; }
        public UInt32? RequiredClientCount { get; set; }
        public string TokenActivationAdditionalInfo { get; set; }
        public string TokenActivationCertificateThumbprint { get; set; }
        public UInt32? TokenActivationGrantNumber { get; set; }
        public string TokenActivationILID { get; set; }
        public UInt32? TokenActivationILVID { get; set; }
        public DateTime? TrustedTime { get; set; }
        public string UseLicenseURL { get; set; }
        public string ValidationURL { get; set; }
        public UInt32? VLActivationInterval { get; set; }
        public UInt32? VLActivationType { get; set; }
        public UInt32? VLActivationTypeEnabled { get; set; }
        public UInt32? VLRenewalInterval { get; set; }
    }
}
