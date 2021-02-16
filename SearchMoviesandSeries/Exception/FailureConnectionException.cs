using System;
using System.Runtime.Serialization;

namespace SearchMovie
{
    [Serializable]
    internal class FailureConnectionException : Exception
    {

        public string message = "##### LOST CONNECTION #####";
        public FailureConnectionException()
        {

        }

        public FailureConnectionException(string message) : base(message)
        {
        }

        public FailureConnectionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FailureConnectionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}