using System;

namespace RetrieverCore.Models.Exceptions
{
    public class ArgumentException : Exception
    {
        public string Caller { get; private set; }

        public ArgumentException(string message, string caller) : base($"{message} (Caller: \'{caller}\')")
        {
            Caller = caller;
        }
    }
}
