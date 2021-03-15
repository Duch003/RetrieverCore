
using GathererEngine.Constants;
using System;

namespace GathererEngine.Models
{
    public class Msft_Providers
    {
        public const string Scope = WmiScope.Cimv2;
        public string HostingGroup { get; set; }
        public UInt32 HostingSpecification { get; set; }
        public UInt32 HostProcessIdentifier { get; set; }
        public string Locale { get; set; }
        public string Namespace { get; set; }
        public string provider { get; set; }
        public UInt64 ProviderOperation_AccessCheck { get; set; }
        public UInt64 ProviderOperation_CancelQuery { get; set; }
        public UInt64 ProviderOperation_CreateClassEnumAsync { get; set; }
        public UInt64 ProviderOperation_CreateInstanceEnumAsync { get; set; }
        public UInt64 ProviderOperation_CreateRefreshableEnum { get; set; }
        public UInt64 ProviderOperation_CreateRefreshableObject { get; set; }
        public UInt64 ProviderOperation_CreateRefresher { get; set; }
        public UInt64 ProviderOperation_DeleteClassAsync { get; set; }
        public UInt64 ProviderOperation_DeleteInstanceAsync { get; set; }
        public UInt64 ProviderOperation_ExecMethodAsync { get; set; }
        public UInt64 ProviderOperation_ExecQueryAsync { get; set; }
        public UInt64 ProviderOperation_FindConsumer { get; set; }
        public UInt64 ProviderOperation_GetObjectAsync { get; set; }
        public UInt64 ProviderOperation_GetObjects { get; set; }
        public UInt64 ProviderOperation_GetProperty { get; set; }
        public UInt64 ProviderOperation_NewQuery { get; set; }
        public UInt64 ProviderOperation_ProvideEvents { get; set; }
        public UInt64 ProviderOperation_PutClassAsync { get; set; }
        public UInt64 ProviderOperation_PutInstanceAsync { get; set; }
        public UInt64 ProviderOperation_PutProperty { get; set; }
        public UInt64 ProviderOperation_QueryInstances { get; set; }
        public UInt64 ProviderOperation_SetRegistrationObject { get; set; }
        public UInt64 ProviderOperation_StopRefreshing { get; set; }
        public UInt64 ProviderOperation_ValidateSubscription { get; set; }
        public string TransactionIdentifier { get; set; }
        public string User { get; set; }

    }
}