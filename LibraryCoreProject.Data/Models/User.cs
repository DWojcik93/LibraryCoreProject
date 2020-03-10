using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Data.Models
{
    public class User
    {
        public User()
        {
            Books = new Collection<Book>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        [ForeignKey("LibraryId")]
        public virtual Library Library { get; set; }
        public int? LibraryId { get; set; }
    }
}
