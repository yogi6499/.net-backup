using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
    }
}
