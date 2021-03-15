using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class Win32_AssociatedProcessorMemory : MappableToDatabaseExtension
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public UInt32? BusSpeed { get; set; }
        public string Dependent { get; set; }
    }
}
