using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookTitile { get; set; }
        public double Price { get; set; }
        public string Language { get; set; }
        public int AuthorId { get; set; }
    }
}
