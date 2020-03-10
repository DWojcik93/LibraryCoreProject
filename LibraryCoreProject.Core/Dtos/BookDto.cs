using LibraryCoreProject.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCoreProject.Core.Dtos
{
    public class BookDto
    {
        public Guid GUID { get; set; }
        public string Title { get; set; }
        public virtual AuthorDto Author { get; set; }
        public int Pages { get; set; }
        public Rate Rate { get; set; }
        public Category Category { get; set; }
    }
}
