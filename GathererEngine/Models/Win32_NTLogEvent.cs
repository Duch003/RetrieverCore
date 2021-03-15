
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Win32_NTLogEvent
    {
        public const string Scope = WmiScope.Cimv2;
        public UInt16 Category { get; set; }
        public string CategoryString { get; set; }
        public string ComputerName { get; set; }
        public byte Data { get; set; }
        public UInt16 EventCode { get; set; }
        public UInt32 EventIdentifier { get; set; }
        public byte EventType { get; set; }
        public string InsertionStrings { get; set; }
        public string Logfile { get; set; }
        public string Message { get; set; }
        public UInt32 RecordNumber { get; set; }
        public string SourceName { get; set; }
        public DateTime TimeGenerated { get; set; }
        public DateTime TimeWritten { get; set; }
        public string Type { get; set; }
        public string User { get; set; }

    }
}