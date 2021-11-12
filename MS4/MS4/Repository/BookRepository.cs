using Microsoft.EntityFrameworkCore;
using MS4.Data;
using MS4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly BookContext _context;

        public BookRepository(BookContext context)
        {
            _context = context;
        }
        public async Task<int> AddBook(BookModel bookModel)
        {
            var book = new Books()
            {
                BookId = bookModel.BookId,
                BookTitile = bookModel.BookTitile,
                Price = bookModel.Price,
                Language = bookModel.Language,
                AuthorId = bookModel.AuthorId
            };
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book.BookId;
        }

        public async Task<List<BookModel>> GetAllBooks()
        {
            var records = await _context.Books.Select(x => new BookModel()
            {
                BookId = x.BookId,
                BookTitile=x.BookTitile,
                Price=x.Price,
                Language=x.Language,
                AuthorId=x.AuthorId
            }).ToListAsync();
            return records;
        }

        public async Task<BookModel> GetBookById(int id)
        {
            var records = await _context.Books.Where(x => x.BookId == id).Select(x => new BookModel()
            {
                BookId = x.BookId,
                BookTitile = x.BookTitile,
                Price = x.Price,
                Language = x.Language,
                AuthorId = x.AuthorId
            }).FirstOrDefaultAsync();
            return records;
        }

        public async Task UpdateBookPriceById(int bookId,BookModel bookModel)
        {
            var book = await _context.Books.FindAsync(bookId);
            if (book != null)
            {
                book.Price = bookModel.Price;
                await _context.SaveChangesAsync();
            }
        }
    }
}
