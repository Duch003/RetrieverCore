using RetrieverCore.Models.Exceptions;
using GathererEngine.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ArgumentException = RetrieverCore.Models.Exceptions.ArgumentException;

namespace RetrieverCore.CoreLogic.Utlities
{
    public static class Guard
    {
        public static bool IsNullOrWhitespace(string str, out Exception e, [CallerMemberName]string caller = null)
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                e = new ArgumentException("Value is null or empty.", caller);
            }
            else
            {
                e = null;
            }

            return e != null;
        }

        public static bool IsNull<T>(T entity, out Exception e, [CallerMemberName] string caller = null) where T: MappableToDatabaseExtension
        {
            if (entity == null)
            {
                e = new GathererException<T>(caller);
            }
            else
            {
                e = null;
            }

            return e != null;
        }

        public static bool IsEmptyOrAnyNull<T>(IEnumerable<T> entities, out Exception e, [CallerMemberName] string caller = null)
        {
            if (entities == null || !entities.Any())
            {
                e = new ArgumentException("List is null or empty.", caller);
            }
            else if(entities.Any(x => x == null))
            {
                if(entities.FirstOrDefault() is MappableToDatabaseExtension)
                {
                    e = new GathererException<T>(caller);
                }
                else
                {
                    e = new PhysicalElementIsNullException<T>(caller);
                }
            }
            else
            {
                e = null;
            }

            return e != null;
        }

        public static bool IsNull<T>(IEnumerable<T> entities, out Exception e, [CallerMemberName] string caller = null)
        {
            if (entities == null)
            {
                e = new ArgumentException("List is null or empty.", caller);
            }
            else
            {
                e = null;
            }

            return e != null;
        }
    }
}
