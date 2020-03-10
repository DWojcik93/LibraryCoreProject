using AutoMapper;
using LibraryCoreProject.Core.Dtos;
using LibraryCoreProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Profiles
{
    public class LibraryProfile : Profile
    {
        public LibraryProfile()
        {
            CreateMap<Author, AuthorDto>()
                .ReverseMap();

            CreateMap<Book, BookDto>()
                .ReverseMap();

            CreateMap<Library, LibraryDto>()
                .ReverseMap();

            CreateMap<User, UserDto>()
                .ReverseMap();
        }
    }
}
