using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ExceptionHandlingLayer
{
    public class IdErrorException : Exception
    {
        public IdErrorException()
        {
        }

        public IdErrorException(string message) : base(message)
        {
        }

        public IdErrorException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IdErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
}
