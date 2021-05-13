using System;
using GathererEngine.Constants;
using GathererEngine.Extensions;

namespace GathererEngine.Models
{
    public class CIM_Printer
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt32? Attributes { get; set; }
        public UInt16? Availability { get; set; }
        public string[] AvailableJobSheets { get; set; }
        public UInt32? AveragePagesPerMinute { get; set; }
        public UInt16?[] Capabilities { get; set; }
        public string[] CapabilityDescriptions { get; set; }
        public string Caption { get; set; }
        public string[] CharSetsSupported { get; set; }
        public string Comment { get; set; }
        public UInt32? ConfigManagerErrorCode { get; set; }
        public bool? ConfigManagerUserConfig { get; set; }
        public string CreationClassName { get; set; }
        public UInt16?[] CurrentCapabilities { get; set; }
        public string CurrentCharSet { get; set; }
        public UInt16? CurrentLanguage { get; set; }
        public string CurrentMimeType { get; set; }
        public string CurrentNaturalLanguage { get; set; }
        public string CurrentPaperType { get; set; }
        public bool? Default { get; set; }
        public UInt16?[] DefaultCapabilities { get; set; }
        public UInt32? DefaultCopies { get; set; }
        public UInt16? DefaultLanguage { get; set; }
        public string DefaultMimeType { get; set; }
        public UInt32? DefaultNumberUp { get; set; }
        public string DefaultPaperType { get; set; }
        public UInt32? DefaultPriority { get; set; }
        public string Description { get; set; }
        public UInt16? DetectedErrorState { get; set; }
        public string DeviceID { get; set; }
        public bool? Direct { get; set; }
        public bool? DoCompleteFirst { get; set; }
        public string DriverName { get; set; }
        public bool? EnableBIDI { get; set; }
        public bool? EnableDevQueryPrint { get; set; }
        public bool? ErrorCleared { get; set; }
        public string ErrorDescription { get; set; }
        public string[] ErrorInformation { get; set; }
        public UInt16? ExtendedDetectedErrorState { get; set; }
        public UInt16? ExtendedPrinterStatus { get; set; }
        public bool? Hidden { get; set; }
        public UInt32? HorizontalResolution { get; set; }
        public DateTime? InstallDate { get; set; }
        public UInt32? JobCountSinceLastReset { get; set; }
        public bool? KeepPrintedJobs { get; set; }
        public UInt16?[] LanguagesSupported { get; set; }
        public UInt32? LastErrorCode { get; set; }
        public bool? Local { get; set; }
        public string Location { get; set; }
        public UInt16? MarkingTechnology { get; set; }
        public UInt32? MaxCopies { get; set; }
        public UInt32? MaxNumberUp { get; set; }
        public UInt32? MaxSizeSupported { get; set; }
        public string[] MimeTypesSupported { get; set; }
        public string Name { get; set; }
        public string[] NaturalLanguagesSupported { get; set; }
        public bool? Network { get; set; }
        public UInt16?[] PaperSizesSupported { get; set; }
        public string[] PaperTypesAvailable { get; set; }
        public string Parameters { get; set; }
        public string PNPDeviceID { get; set; }
        public string PortName { get; set; }
        public UInt16?[] PowerManagementCapabilities { get; set; }
        public bool? PowerManagementSupported { get; set; }
        public string[] PrinterPaperNames { get; set; }
        public UInt32? PrinterState { get; set; }
        public UInt16? PrinterStatus { get; set; }
        public string PrintJobDataType { get; set; }
        public string PrintProcessor { get; set; }
        public UInt32? Priority { get; set; }
        public bool? Published { get; set; }
        public bool? Queued { get; set; }
        public bool? RawOnly { get; set; }
        public string SeparatorFile { get; set; }
        public string ServerName { get; set; }
        public bool? Shared { get; set; }
        public string ShareName { get; set; }
        public bool? SpoolEnabled { get; set; }
        public DateTime? StartTime { get; set; }
        public string Status { get; set; }
        public UInt16? StatusInfo { get; set; }
        public string SystemCreationClassName { get; set; }
        public string SystemName { get; set; }
        public DateTime? TimeOfLastReset { get; set; }
        public DateTime? UntilTime { get; set; }
        public UInt32? VerticalResolution { get; set; }
        public bool? WorkOffline { get; set; }
    }
}
