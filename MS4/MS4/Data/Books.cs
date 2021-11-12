using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Data
{
    
    public class Books
    {
        [Key]
        public int BookId { get; set; } 
        public string BookTitile { get; set; } 
        public double Price { get; set; } 
        public string Language { get; set; } 
        public int AuthorId { get; set; }
    }
}
