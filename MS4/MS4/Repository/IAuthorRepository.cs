using MS4.Data;
using MS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Repository
{
    public interface IAuthorRepository
    {
        Task<int> AddAuthor(AuthorModel authorModel);

        Task<List<AuthorModel>> GetAllAuthors();
        Task<AuthorModel> GetAuthorById(int id);
    }
}
