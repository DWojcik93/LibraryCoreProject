using AutoMapper;
using LibraryCoreProject.Core.Dtos;
using LibraryCoreProject.Core.Helpers;
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
                .ForMember(a => a.FullName, b => b.MapFrom(c => $"{c.Author.FirstName} {c.Author.LastName}"))
                .ForMember(a => a.Category, b => b.MapFrom(c => EnumerableExpressionHelper.GetStringFromEnumInt((int)c.Category)))
                .ReverseMap();

            CreateMap<Library, LibraryDto>()
                .ReverseMap();

            CreateMap<User, UserDto>()
                .ReverseMap();
        }
    }
}
