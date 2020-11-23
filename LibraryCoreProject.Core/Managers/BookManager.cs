using AutoMapper;
using LibraryCoreProject.Core.Dtos;
using LibraryCoreProject.Core.Interfaces;
using LibraryCoreProject.Data.Context;
using LibraryCoreProject.Data.Models;
using Microsoft.EntityFrameworkCore;
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

        public BookManager(LibraryContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public BookDto CreateBook()
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookDto>> GetAllBooks()
        {
            var books = await _context.Books
                .Include(a => a.Author)
                .Include(a => a.BookImage)
                .ToListAsync();
            var res = _mapper.Map<List<Book>, List<BookDto>>(books);
            return res;
        }

        public async Task<BookDto> GetBookById(int bookId)
        {
            var book = await _context.Books
                .Include(a => a.Author)
                .Include(a => a.BookImage)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.Id == bookId);

            return _mapper.Map<BookDto>(book);
        }

        public BookDto PutBook(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
