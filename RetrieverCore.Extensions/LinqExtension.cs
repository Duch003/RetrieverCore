using System;
using System.Collections.Generic;

namespace RetrieverCore.Extensions
{
    public static class LinqExtension
    {
        public static IEnumerable<U> ForEach<T, U>(this IEnumerable<T> list, Func<T, U> action)
        {
            var output = new List<U>();

            foreach(var item in list)
            {
                var result = action(item);
                output.Add(result);
            }

            return output;
        }
    }
}
