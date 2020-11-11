using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCoreProject.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(maxLength: 255, nullable: true),
                    Age = table.Column<int>(nullable: true),
                    StillLive = table.Column<bool>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    LibraryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    LibraryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 255, nullable: true),
                    AuthorId = table.Column<int>(nullable: false),
                    Pages = table.Column<int>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    DateOfRental = table.Column<DateTime>(nullable: true),
                    ReturnDate = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    LibraryId = table.Column<int>(nullable: true),
                    BookImageId = table.Column<int>(nullable: true),
                    BookCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Libraries_LibraryId",
                        column: x => x.LibraryId,
                        principalTable: "Libraries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookImage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    BookId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookImage_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Krakowska Biblioteka Publiczna" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "FirstName", "LastName", "LibraryId", "Rate", "StillLive" },
                values: new object[,]
                {
                    { 1, 81, "John Ronald Reuel", "Tolkien", 1, 5, false },
                    { 2, 73, "Stephen Edwin", "King", 1, 4, true },
                    { 3, 57, "Adam", "Mickiewicz", 1, 6, false }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "LibraryId" },
                values: new object[] { 1, "Damian", "Wójcik", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookCode", "BookImageId", "Category", "DateOfRental", "IsAvailable", "LibraryId", "Pages", "Rate", "ReturnDate", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "GHJ-4578", 1, 1, null, true, 1, 320, 5, null, "Hobbit", null },
                    { 2, 1, "GHJ-4578", 2, 1, null, true, 1, 504, 6, null, "Władca Pierścieni", null },
                    { 3, 2, "CDJ-9338", 3, 1, null, true, 1, 416, 6, null, "Zielona Mila", null },
                    { 4, 2, "978-AABC", 4, 2, null, true, 1, 520, 5, null, "Lśnienie", null },
                    { 5, 3, "ZXY-Z570", 5, 5, null, true, 1, 304, 5, null, "Pan Taduesz", null },
                    { 6, 3, "845-9657", 6, 5, null, true, 1, 32, 4, null, "Sonety Krymskie", null }
                });

            migrationBuilder.InsertData(
                table: "BookImage",
                columns: new[] { "Id", "BookId", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 1, "assets/images/hobbit.png", "Hobbit" },
                    { 2, 2, "assets/images/the-lord-of-rings.png", "The Lord of Rings" },
                    { 3, 3, "assets/images/the-green-mile.png", "The Green Mile" },
                    { 4, 4, "assets/images/the-shining.png", "The Shining" },
                    { 5, 5, "assets/images/pan-tadeusz.png", "Pan Taduesz" },
                    { 6, 6, "assets/images/sonety-krymskie.png", "Sonety Krymskie" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_LastName",
                table: "Authors",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_LibraryId",
                table: "Authors",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_BookImage_BookId",
                table: "BookImage",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryId",
                table: "Books",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_UserId",
                table: "Books",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId_Title",
                table: "Books",
                columns: new[] { "AuthorId", "Title" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_LibraryId",
                table: "Users",
                column: "LibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookImage");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
