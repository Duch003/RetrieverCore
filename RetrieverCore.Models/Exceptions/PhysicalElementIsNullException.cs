using System;

namespace RetrieverCore.Models.Exceptions
{
    public class PhysicalElementIsNullException<T> : Exception
    {
        public string Caller { get; private set; }

        public PhysicalElementIsNullException(string caller) : base($"Library returned null entity of {typeof(T).Name}.")
        {
            Caller = caller;
        }
    }
}
