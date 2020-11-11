using LibraryCoreProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Data.Models
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public virtual Author Author { get; set; }

        public int AuthorId { get; set; }

        public int Pages { get; set; }

        public Rate Rate { get; set; }

        public bool IsAvailable { get; set; }

        public DateTime? DateOfRental { get; set; }

        public DateTime? ReturnDate { get; set; }

        public virtual User User { get; set; }

        public int? UserId { get; set; }

        public Category Category { get; set; }

        public virtual Library Library { get; set; }

        public int? LibraryId { get; set; }

        public virtual BookImage BookImage { get; set; }

        public int? BookImageId { get; set; }

        public string BookCode { get; set; }
    }
}
