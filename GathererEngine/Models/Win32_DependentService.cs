
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_DependentService
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public string Dependent { get; set; }
        public UInt16 TypeOfDependency { get; set; }

    }
}