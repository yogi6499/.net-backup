using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiAssignment1.Model;

namespace WebApiAssignment1.Controllers
{
    
    
    public class WelcomeController : Controller
    {
        private IWelcomeMessage welcomeMessage;
        public WelcomeController(IWelcomeMessage _welcomeMessage)
        {
            this.welcomeMessage = _welcomeMessage;
        }
        [Route("api/welcome")]
        public string Get()
        {
            return this.welcomeMessage.GetMessage();
        }
    }
}
