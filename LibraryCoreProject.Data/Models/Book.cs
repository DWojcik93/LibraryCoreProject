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
        public Guid GUID { get; set; }

        [StringLength(255)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual Author Author { get; set; }
        public int Pages { get; set; }
        public Rate Rate { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? DateOfRental { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public Category Category { get; set; }

        [ForeignKey("LibraryId")]
        public virtual Library Library { get; set; }
        public int? LibraryId { get; set; }
    }
}
