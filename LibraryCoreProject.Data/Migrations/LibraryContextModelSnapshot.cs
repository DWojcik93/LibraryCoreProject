﻿// <auto-generated />
using System;
using LibraryCoreProject.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryCoreProject.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryCoreProject.Data.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<bool>("StillLive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LastName");

                    b.HasIndex("LibraryId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 81,
                            FirstName = "John Ronald Reuel",
                            LastName = "Tolkien",
                            LibraryId = 1,
                            Rate = 5,
                            StillLive = false
                        },
                        new
                        {
                            Id = 2,
                            Age = 73,
                            FirstName = "Stephen Edwin",
                            LastName = "King",
                            LibraryId = 1,
                            Rate = 4,
                            StillLive = true
                        },
                        new
                        {
                            Id = 3,
                            Age = 57,
                            FirstName = "Adam",
                            LastName = "Mickiewicz",
                            LibraryId = 1,
                            Rate = 6,
                            StillLive = false
                        });
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.Book", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfRental")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("GUID");

                    b.HasIndex("LibraryId");

                    b.HasIndex("UserId");

                    b.HasIndex("AuthorId", "Title");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            GUID = new Guid("1918eada-c237-ea11-a8e1-7ce9d3ea20e9"),
                            AuthorId = 1,
                            Category = 1,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 320,
                            Rate = 5,
                            Title = "Hobbit"
                        },
                        new
                        {
                            GUID = new Guid("cbb3c533-c337-ea11-a8e1-7ce9d3ea20e9"),
                            AuthorId = 1,
                            Category = 1,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 504,
                            Rate = 6,
                            Title = "Władca Pierścieni"
                        },
                        new
                        {
                            GUID = new Guid("14abb767-c337-ea11-a8e1-7ce9d3ea20e9"),
                            AuthorId = 2,
                            Category = 1,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 416,
                            Rate = 6,
                            Title = "Zielona Mila"
                        },
                        new
                        {
                            GUID = new Guid("391cb3c3-9e19-4bf0-ab34-c117108e61ea"),
                            AuthorId = 2,
                            Category = 2,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 520,
                            Rate = 5,
                            Title = "Lśnienie"
                        },
                        new
                        {
                            GUID = new Guid("ba18b119-a8df-4570-9c78-c94e8c21c7c8"),
                            AuthorId = 3,
                            Category = 5,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 304,
                            Rate = 5,
                            Title = "Pan Taduesz"
                        },
                        new
                        {
                            GUID = new Guid("750685c3-2fd7-49cf-ac51-cc11c30c795d"),
                            AuthorId = 3,
                            Category = 5,
                            IsAvailable = true,
                            LibraryId = 1,
                            Pages = 32,
                            Rate = 4,
                            Title = "Sonety Krymskie"
                        });
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.Library", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libraries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Krakowska Biblioteka Publiczna"
                        });
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LibraryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LibraryId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Damian",
                            LastName = "Wójcik",
                            LibraryId = 1
                        });
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.Author", b =>
                {
                    b.HasOne("LibraryCoreProject.Data.Models.Library", "Library")
                        .WithMany("Authors")
                        .HasForeignKey("LibraryId");
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.Book", b =>
                {
                    b.HasOne("LibraryCoreProject.Data.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryCoreProject.Data.Models.Library", "Library")
                        .WithMany("Books")
                        .HasForeignKey("LibraryId");

                    b.HasOne("LibraryCoreProject.Data.Models.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LibraryCoreProject.Data.Models.User", b =>
                {
                    b.HasOne("LibraryCoreProject.Data.Models.Library", "Library")
                        .WithMany("Users")
                        .HasForeignKey("LibraryId");
                });
#pragma warning restore 612, 618
        }
    }
}
