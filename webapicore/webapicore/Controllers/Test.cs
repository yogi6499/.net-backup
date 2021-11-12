using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapicore.Controllers
{
    public class Test:Controller
    {
        [Route("api/names")]
        public IEnumerable<string> names()
        {
            return new List<string> { "Yogi", "sandeep", "vicky" };
        }
    }
}
