using System;

namespace RetrieverCore.Models.Exceptions
{
    public class GathererException<T> : Exception
    {
        public string Caller { get; private set; }
        public GathererException(string caller) : base($"Gatherer returned null entity of {typeof(T).Name}.")
        {
            Caller = caller;
        }
    }
}
