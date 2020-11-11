using LibraryCoreProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Data.Context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
           : base(options)
        { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasIndex(a => a.LastName);

            modelBuilder.Entity<Book>()
                .HasIndex(a => new { a.AuthorId, a.Title });

            modelBuilder.Entity<Book>()
                .HasOne(a => a.BookImage)
                .WithOne(a => a.Book)
                .HasForeignKey<BookImage>(a => a.BookId);

            //W celu nie podejmowania akcji podczas usuwania Biblioteki
            //modelBuilder.Entity<Library>()
            //    .HasMany(a => a.Books)
            //    .WithOne(a => a.Library)
            //    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Seed();
        }
    }
}
