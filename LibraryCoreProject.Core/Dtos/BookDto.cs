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
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int Pages { get; set; }

        public Rate Rate { get; set; }

        public string Category { get; set; }

        public bool IsAvailable { get; set; }

        public string BookCode { get; set; }

        public string ImageUrl { get; set; }
    }
}
