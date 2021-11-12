using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Data
{
    
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } 
        public string Country { get; set; } 
        public string Address { get; set; }
    }
}
