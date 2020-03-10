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
    public class Library
    {
        public Library()
        {
            Books = new Collection<Book>();
            Authors = new Collection<Author>();
            Users = new Collection<User>();
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
