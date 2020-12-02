using AutoMapper;
using LibraryCoreProject.Core.Dtos;
using LibraryCoreProject.Core.Interfaces;
using LibraryCoreProject.Data.Context;
using LibraryCoreProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Managers
{
    public class BookManager : IBookManager
    {
        private readonly LibraryContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<BookManager> _logger;

        public BookManager(LibraryContext context,
            IMapper mapper,
            ILogger<BookManager> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public bool CreateBook(BookDto book)
        {
            try
            {
                _logger.LogInformation("Create book");

                var res = _mapper.Map<BookDto, Book>(book);

                _context.Books.Add(res);
                _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to create book: {ex}");
                return false;
            }
        }

        public bool DeleteBook(int bookId)
        {
            try
            {
                _logger.LogInformation("Delete book");

                var bookToDelete = _context.Books.FirstOrDefault(a => a.Id == bookId);

                _context.Books.Remove(bookToDelete);
                _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to delete book: {ex}");
                return false;
            }
        }

        public async Task<List<BookDto>> GetAllBooks()
        {
            try
            {
                _logger.LogInformation("Get all books");

                var books = await _context.Books
                            .Include(a => a.Author)
                            .Include(a => a.BookImage)
                            .ToListAsync();

                var res = _mapper.Map<List<Book>, List<BookDto>>(books);

                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get books: {ex}");
                return new List<BookDto>();
            }
        }

        public async Task<BookDto> GetBookById(int bookId)
        {
            try
            {
                _logger.LogInformation("Get single method");

                var book = await _context.Books
                               .Include(a => a.Author)
                               .Include(a => a.BookImage)
                               .AsNoTracking()
                               .FirstOrDefaultAsync(a => a.Id == bookId);

                return _mapper.Map<BookDto>(book);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get book: {ex}");
                return null;
            }
        }

        public bool PutBook(BookDto book)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
