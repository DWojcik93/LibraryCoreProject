using LibraryCoreProject.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Interfaces
{
    public interface IBookManager
    {
        List<BookDto> GetAllBooks();
        Task<BookDto> GetBookById(string bookId);
        BookDto CreateBook();
        BookDto PutBook(string bookId);
        void DeleteBook(string bookId);
        Task<int> SaveChangesAsync();
    }
}
