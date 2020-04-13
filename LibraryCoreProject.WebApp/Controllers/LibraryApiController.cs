using LibraryCoreProject.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryApiController : Controller
    {
        private readonly IBookManager _manager;
        private readonly ILogger<LibraryApiController> _logger;

        public LibraryApiController(IBookManager manager,
                                    ILogger<LibraryApiController> logger)
        {
            _manager = manager;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                _logger.LogInformation("Get method");
                var model = await _manager.GetAllBooks();

                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get books: {ex}");
                return BadRequest();
            }
        }
    }
}
