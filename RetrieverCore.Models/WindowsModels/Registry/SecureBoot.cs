using System;

namespace RetrieverCore.Models.WindowsModels.Registry
{
    public class SecureBoot
    {
        public const string Path = @"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\SecureBoot\State";
        public const string Property = "UEFISecureBootEnabled";
        public const string DefaultValue = "2";
        public UInt32 UEFISecureBootEnabled { get; set; }
    }
}
