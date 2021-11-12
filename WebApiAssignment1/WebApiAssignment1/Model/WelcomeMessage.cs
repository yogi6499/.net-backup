using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAssignment1.Model
{
    public class WelcomeMessage:IWelcomeMessage
    {
        private string Message { get; set; }
        public WelcomeMessage()
        {
            Message = "yogi";
        }

        public string GetMessage()
        {
            return "Hello"+Message;
        }
    }
}
