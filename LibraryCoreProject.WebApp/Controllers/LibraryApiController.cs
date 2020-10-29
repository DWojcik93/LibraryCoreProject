﻿using LibraryCoreProject.Core.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace LibraryCoreProject.WebApp.Controllers
{
    [RoutePrefix("api/[controller]")]
    public class LibraryApiController : ApiController
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
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                _logger.LogInformation("Get all method");
                var model = await _manager.GetAllBooks();

                return Ok(new { data = model });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get books: {ex}");
                return BadRequest();
            }
        }

        [HttpGet, Route("{guid:guid}")]
        public async Task<IHttpActionResult> Get(string guid)
        {
            try
            {
                _logger.LogInformation("Get single method");
                var model = await _manager.GetBookById(guid);

                if (model == null)
                    return NotFound();

                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get book: {ex}");
                return BadRequest();
            }
        }
    }
}
