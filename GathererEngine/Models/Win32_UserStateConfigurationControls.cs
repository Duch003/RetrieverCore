
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_UserStateConfigurationControls
    {
        public const string Scope = WmiScope.Cimv2;
        public byte FolderRedirection { get; set; }
        public byte OfflineFiles { get; set; }
        public byte RoamingUserProfile { get; set; }

    }
}