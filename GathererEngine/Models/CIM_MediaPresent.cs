
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class CIM_MediaPresent
    {
        public const string Scope = WmiScope.Cimv2;
        public string Antecedent { get; set; }
        public string Dependent { get; set; }

    }
}