using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MS3.ExceptionLayer
{
    public class DuplicateIdException : Exception
    {
        public DuplicateIdException() : base() { }
        public DuplicateIdException(string message) : base(message)
        {
        }
        public DuplicateIdException(String message, Exception innerException) : base(message, innerException) { }
    }

}
