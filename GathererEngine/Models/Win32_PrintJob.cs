
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_PrintJob
    {
        public const string Scope = WmiScope.Cimv2;
        public string Caption { get; set; }
        public string Color { get; set; }
        public string DataType { get; set; }
        public string Description { get; set; }
        public string Document { get; set; }
        public string DriverName { get; set; }
        public DateTime ElapsedTime { get; set; }
        public string HostPrintQueue { get; set; }
        public DateTime InstallDate { get; set; }
        public UInt32 JobId { get; set; }
        public string JobStatus { get; set; }
        public string Name { get; set; }
        public string Notify { get; set; }
        public string Owner { get; set; }
        public UInt32 PagesPrinted { get; set; }
        public UInt32 PaperLength { get; set; }
        public string PaperSize { get; set; }
        public UInt32 PaperWidth { get; set; }
        public string Parameters { get; set; }
        public string PrintProcessor { get; set; }
        public UInt32 Priority { get; set; }
        public UInt32 Size { get; set; }
        public UInt32 SizeHigh { get; set; }
        public DateTime StartTime { get; set; }
        public string Status { get; set; }
        public UInt32 StatusMask { get; set; }
        public DateTime TimeSubmitted { get; set; }
        public UInt32 TotalPages { get; set; }
        public DateTime UntilTime { get; set; }

    }
}