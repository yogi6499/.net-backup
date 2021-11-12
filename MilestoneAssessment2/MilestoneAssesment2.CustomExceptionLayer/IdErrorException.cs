using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoneAssesment2.CustomExceptionLayer
{
    [Serializable]
    public class DuplicateEmailIDException : Exception
    {
        public DuplicateEmailIDException()
        {
        }

        public DuplicateEmailIDException(string message) : base(message)
        {
        }

        public DuplicateEmailIDException(string message, Exception innerException) : base(message, innerException)
        {
        }

        
    }
}
