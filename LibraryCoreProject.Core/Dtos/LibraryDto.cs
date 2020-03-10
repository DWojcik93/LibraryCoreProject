using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Dtos
{
    public class LibraryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookDto> Books { get; set; }
        public virtual ICollection<AuthorDto> Authors { get; set; }
        public virtual ICollection<UserDto> Users { get; set; }
    }
}
