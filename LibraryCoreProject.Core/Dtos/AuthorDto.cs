using LibraryCoreProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Dtos
{
    public class AuthorDto
    {
        public AuthorDto()
        {
            Books = new Collection<BookDto>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public bool StillLive { get; set; }

        public Rate Rate { get; set; }

        public virtual ICollection<BookDto> Books { get; set; }
    }
}
