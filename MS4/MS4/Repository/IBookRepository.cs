using MS4.Data;
using MS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Repository
{
    public interface IBookRepository
    {
        Task<List<BookModel>> GetAllBooks();

        Task<int> AddBook(BookModel bookModel);

        Task<BookModel> GetBookById(int id);

        Task UpdateBookPriceById(int bookId,BookModel bookModel);
    }
}
