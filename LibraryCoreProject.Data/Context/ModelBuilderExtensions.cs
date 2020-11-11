using LibraryCoreProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryCoreProject.Data.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>().HasData(
                  new Library
                  {
                      Id = 1,
                      Name = "Krakowska Biblioteka Publiczna"
                  }
            );

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Books = null,
                    FirstName = "Damian",
                    LastName = "Wójcik",
                    LibraryId = 1
                });

            modelBuilder.Entity<Author>().HasData
                (
                    new Author
                    {
                        Id = 1,
                        FirstName = "John Ronald Reuel",
                        LastName = "Tolkien",
                        Age = 81,
                        StillLive = false,
                        Rate = Enums.Rate.VeryGood,
                        LibraryId = 1
                    },
                    new Author
                    {
                        Id = 2,
                        FirstName = "Stephen Edwin",
                        LastName = "King",
                        Age = 73,
                        StillLive = true,
                        Rate = Enums.Rate.Good,
                        LibraryId = 1
                    },
                    new Author
                    {
                        Id = 3,
                        FirstName = "Adam",
                        LastName = "Mickiewicz",
                        Age = 57,
                        StillLive = false,
                        Rate = Enums.Rate.Master,
                        LibraryId = 1
                    }
                );

            modelBuilder.Entity<Book>().HasData(
                  new Book
                  {
                      Id = 1,
                      Title = "Hobbit",
                      AuthorId = 1,
                      Pages = 320,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1,
                      BookImageId = 1,
                      BookCode = "GHJ-4578"
                  },
                  new Book
                  {
                      Id = 2,
                      Title = "Władca Pierścieni",
                      AuthorId = 1,
                      Pages = 504,
                      Rate = Enums.Rate.Master,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1,
                      BookImageId = 2,
                      BookCode = "GHJ-4578"
                  },
                  new Book
                  {
                      Id = 3,
                      Title = "Zielona Mila",
                      AuthorId = 2,
                      Pages = 416,
                      Rate = Enums.Rate.Master,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1,
                      BookImageId = 3,
                      BookCode = "CDJ-9338"
                  },
                  new Book
                  {
                      Id = 4,
                      Title = "Lśnienie",
                      AuthorId = 2,
                      Pages = 520,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Horror,
                      LibraryId = 1,
                      BookImageId = 4,
                      BookCode = "978-AABC"
                  },
                  new Book
                  {
                      Id = 5,
                      Title = "Pan Taduesz",
                      AuthorId = 3,
                      Pages = 304,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Novel,
                      LibraryId = 1,
                      BookImageId = 5,
                      BookCode = "ZXY-Z570"
                  },
                  new Book
                  {
                      Id = 6,
                      Title = "Sonety Krymskie",
                      AuthorId = 3,
                      Pages = 32,
                      Rate = Enums.Rate.Good,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Novel,
                      LibraryId = 1,
                      BookImageId = 6,
                      BookCode = "845-9657"
                  }
                );

            modelBuilder.Entity<BookImage>().HasData(
                new BookImage
                {
                    Id = 1,
                    BookId = 1,
                    Name = "Hobbit",
                    ImageUrl = "assets/images/hobbit.png"
                },
                new BookImage
                {
                    Id = 2,
                    BookId = 2,
                    Name = "The Lord of Rings",
                    ImageUrl = "assets/images/the-lord-of-rings.png"
                },
                new BookImage
                {
                    Id = 3,
                    BookId = 3,
                    Name = "The Green Mile",
                    ImageUrl = "assets/images/the-green-mile.png"
                },
                new BookImage
                {
                    Id = 4,
                    BookId = 4,
                    Name = "The Shining",
                    ImageUrl = "assets/images/the-shining.png"
                },
                new BookImage
                {
                    Id = 5,
                    BookId = 5,
                    Name = "Pan Taduesz",
                    ImageUrl = "assets/images/pan-tadeusz.png"
                },
                new BookImage
                {
                    Id = 6,
                    BookId = 6,
                    Name = "Sonety Krymskie",
                    ImageUrl = "assets/images/sonety-krymskie.png"
                });
        }
    }
}