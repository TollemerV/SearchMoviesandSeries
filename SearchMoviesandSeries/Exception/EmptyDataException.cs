using System;
using System.Runtime.Serialization;

namespace SearchMovie
{
    [Serializable]
    internal class EmptyDataException : Exception
    {
        public EmptyDataException()
        {
        }

        public EmptyDataException(string message) : base(message)
        {
        }

        public EmptyDataException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyDataException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}