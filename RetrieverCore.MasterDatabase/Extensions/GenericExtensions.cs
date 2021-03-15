using System;

namespace RetrieverCore.MasterDatabase.Extensions
{
    public static class GenericExtensions
    {
        public static T? ToNullable<T>(this string raw) where T : struct
        {
            try
            {
                return Convert.ChangeType(raw, typeof(T)) as T?;
            }
            catch
            {
                return null as T?;
            }
        }
    }
}
