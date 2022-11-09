using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace cst06exception
{
    internal class StupidUserException : Exception
    {
        public StupidUserException(string? message) : base(message)
        {
        }

        public StupidUserException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StupidUserException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
