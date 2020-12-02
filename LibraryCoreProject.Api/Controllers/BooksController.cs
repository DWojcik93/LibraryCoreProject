using LibraryCoreProject.Core.Dtos;
using LibraryCoreProject.Core.Interfaces;
using LibraryCoreProject.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Api.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookManager _manager;

        public BooksController(IBookManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await _manager.GetAllBooks());

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            if (id == 0)
                return BadRequest();

            var result = await _manager.GetAllBooks();

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create([FromBody] BookDto book)
        {
            if (book == null)
                return BadRequest();

            if (_manager.CreateBook(book))
                return Ok();
            else
                return BadRequest();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            if (_manager.DeleteBook(id))
                return Ok();
            else
                return BadRequest();
        }
    }
}
