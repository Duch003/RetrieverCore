
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NetworkLoginProfile
    {
        public const string Scope = WmiScope.Cimv2;
        public DateTime AccountExpires { get; set; }
        public UInt32 AuthorizationFlags { get; set; }
        public UInt32 BadPasswordCount { get; set; }
        public string Caption { get; set; }
        public UInt32 CodePage { get; set; }
        public string Comment { get; set; }
        public UInt32 CountryCode { get; set; }
        public string Description { get; set; }
        public UInt32 Flags { get; set; }
        public string FullName { get; set; }
        public string HomeDirectory { get; set; }
        public string HomeDirectoryDrive { get; set; }
        public DateTime LastLogoff { get; set; }
        public DateTime LastLogon { get; set; }
        public string LogonHours { get; set; }
        public string LogonServer { get; set; }
        public UInt64 MaximumStorage { get; set; }
        public string Name { get; set; }
        public UInt32 NumberOfLogons { get; set; }
        public string Parameters { get; set; }
        public DateTime PasswordAge { get; set; }
        public DateTime PasswordExpires { get; set; }
        public UInt32 PrimaryGroupId { get; set; }
        public UInt32 Privileges { get; set; }
        public string Profile { get; set; }
        public string ScriptPath { get; set; }
        public string SettingID { get; set; }
        public UInt32 UnitsPerWeek { get; set; }
        public string UserComment { get; set; }
        public UInt32 UserId { get; set; }
        public string UserType { get; set; }
        public string Workstations { get; set; }

    }
}