
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NTDomain
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string ClientSiteName { get; set; }
        public string CreationClassName { get; set; }
        public string DcSiteName { get; set; }
        public string Description { get; set; }
        public string DnsForestName { get; set; }
        public string DomainControllerAddress { get; set; }
        public Int32 DomainControllerAddressType { get; set; }
        public string DomainControllerName { get; set; }
        public string DomainGuid { get; set; }
        public string DomainName { get; set; }
        public bool DSDirectoryServiceFlag { get; set; }
        public bool DSDnsControllerFlag { get; set; }
        public bool DSDnsDomainFlag { get; set; }
        public bool DSDnsForestFlag { get; set; }
        public bool DSGlobalCatalogFlag { get; set; }
        public bool DSKerberosDistributionCenterFlag { get; set; }
        public bool DSPrimaryDomainControllerFlag { get; set; }
        public bool DSTimeServiceFlag { get; set; }
        public bool DSWritableFlag { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string NameFormat { get; set; }
        public string PrimaryOwnerContact { get; set; }
        public string PrimaryOwnerName { get; set; }
        public string Roles { get; set; }
        public string Status { get; set; }

    }
}