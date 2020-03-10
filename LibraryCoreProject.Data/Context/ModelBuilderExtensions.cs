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
                      GUID = new Guid("1918eada-c237-ea11-a8e1-7ce9d3ea20e9"),
                      Title = "Hobbit",
                      AuthorId = 1,
                      Pages = 320,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1
                  },
                  new Book
                  {
                      GUID = new Guid("cbb3c533-c337-ea11-a8e1-7ce9d3ea20e9"),
                      Title = "Władca Pierścieni",
                      AuthorId = 1,
                      Pages = 504,
                      Rate = Enums.Rate.Master,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1
                  },
                  new Book
                  {
                      GUID = new Guid("14abb767-c337-ea11-a8e1-7ce9d3ea20e9"),
                      Title = "Zielona Mila",
                      AuthorId = 2,
                      Pages = 416,
                      Rate = Enums.Rate.Master,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.SciFi,
                      LibraryId = 1
                  },
                  new Book
                  {
                      GUID = new Guid("391cb3c3-9e19-4bf0-ab34-c117108e61ea"),
                      Title = "Lśnienie",
                      AuthorId = 2,
                      Pages = 520,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Horror,
                      LibraryId = 1
                  },
                  new Book
                  {
                      GUID = new Guid("ba18b119-a8df-4570-9c78-c94e8c21c7c8"),
                      Title = "Pan Taduesz",
                      AuthorId = 3,
                      Pages = 304,
                      Rate = Enums.Rate.VeryGood,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Novel,
                      LibraryId = 1
                  },
                  new Book
                  {
                      GUID = new Guid("750685c3-2fd7-49cf-ac51-cc11c30c795d"),
                      Title = "Sonety Krymskie",
                      AuthorId = 3,
                      Pages = 32,
                      Rate = Enums.Rate.Good,
                      IsAvailable = true,
                      DateOfRental = null,
                      ReturnDate = null,
                      UserId = null,
                      Category = Enums.Category.Novel,
                      LibraryId = 1
                  }
                );
        }
    }
}