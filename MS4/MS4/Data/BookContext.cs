using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
