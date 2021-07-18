using System;

namespace Databases.RetrieverCore.Common.Models.Extensions
{
    public static class GenericExtension
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
