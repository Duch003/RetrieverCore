using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_InstalledOS : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public string GroupComponent { get; set; }
        public string PartComponent { get; set; }
        public bool? PrimaryOS { get; set; }
    }
}
