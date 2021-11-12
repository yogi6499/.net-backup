using Microsoft.EntityFrameworkCore;
using MS4.Data;
using MS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookContext _context;

        public AuthorRepository(BookContext context)
        {
            _context = context;
        }
        public async Task<int> AddAuthor(AuthorModel authorModel)
        {
            var author = new Author()
            {
                
                AuthorId = authorModel.AuthorId,
                AuthorName=authorModel.AuthorName,
                Address=authorModel.Address,
                Country=authorModel.Country
            };
            _context.Authors.Add(author);
            await _context.SaveChangesAsync();
            return author.AuthorId;
        }

        public async Task<List<AuthorModel>> GetAllAuthors()
        {
            var records = await _context.Authors.Select(x => new AuthorModel()
            {
                AuthorId = x.AuthorId,
                AuthorName = x.AuthorName,
                Address = x.Address,
                Country = x.Country
            }).ToListAsync();
            return records;
        }
        public async Task<AuthorModel> GetAuthorById(int id)
        {
            var records = await _context.Authors.Where(x => x.AuthorId == id).Select(x => new AuthorModel()
            {
                AuthorId = x.AuthorId,
                AuthorName = x.AuthorName,
                Address = x.Address,
                Country = x.Country
            }).FirstOrDefaultAsync();
            return records;
        }
    }
}
