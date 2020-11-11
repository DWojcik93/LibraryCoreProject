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
        Task<List<BookDto>> GetAllBooks();

        Task<BookDto> GetBookById(int bookId);

        BookDto CreateBook();

        BookDto PutBook(int bookId);

        void DeleteBook(int bookId);

        Task<int> SaveChangesAsync();
    }
}
