using Microsoft.AspNetCore.Cors;
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
    
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var author = await _authorRepository.GetAllAuthors();
            return Ok(author);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var book = await _authorRepository.GetAuthorById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }
        [HttpPost]
        public async Task<IActionResult> AddBook([FromBody] AuthorModel authorModel)
        {
            var id = await _authorRepository.AddAuthor(authorModel);
            return CreatedAtAction(nameof(GetAuthorById), new { id = id, Controller = "Author" }, id);
        }
    }
}
