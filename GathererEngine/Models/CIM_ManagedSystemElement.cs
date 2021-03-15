
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_ManagedSystemElement
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string CategoryId { get; set; }
        public string Description { get; set; }
        public DateTime InstallDate { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

    }
}