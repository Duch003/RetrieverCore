
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class MS_SM_HbaApiVersion
    {
        public const string Scope = WmiScope.Wmi;
        public string Description { get; set; }
        public UInt32 HbaApiVersion { get; set; }
        public UInt32 WmiHbaApiVersion { get; set; }

    }
}