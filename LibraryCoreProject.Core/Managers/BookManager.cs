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

        public void DeleteBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public List<BookDto> GetAllBooks()
        {
            var books = _context.Books.Include(a => a.Author).ToList();
            return _mapper.Map<List<Book>, List<BookDto>>(books);
        }

        public async Task<BookDto> GetBookById(string bookId)
        {
            var book = await _context.Books.Include(a => a.Author).FirstOrDefaultAsync(a => a.GUID.ToString() == bookId);
            return _mapper.Map<BookDto>(book);
        }

        public BookDto PutBook(string bookId)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
