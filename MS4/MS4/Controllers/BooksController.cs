using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MS4.Models;
using MS4.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MS4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            return Ok(books);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _bookRepository.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody]BookModel bookModel)
        {
            var id = await _bookRepository.AddBook(bookModel);
            return CreatedAtAction(nameof(GetBookById), new { id = id, Controller = "Books" }, id);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdatePrice([FromBody] BookModel bookModel,[FromRoute] int id)
        {
            await _bookRepository.UpdateBookPriceById(id, bookModel);
            return Ok();
        }
    }
}
