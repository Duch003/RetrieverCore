
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_ReliabilityRecords
    {
        public const string Scope = WmiScope.Cimv2;
        public string ComputerName { get; set; }
        public UInt32 EventIdentifier { get; set; }
        public string InsertionStrings { get; set; }
        public string Logfile { get; set; }
        public string Message { get; set; }
        public string ProductName { get; set; }
        public UInt32 RecordNumber { get; set; }
        public string SourceName { get; set; }
        public DateTime TimeGenerated { get; set; }
        public string User { get; set; }

    }
}