using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class LibraryClass
    {
        public class Book
        {
            public int ID;
            public required string Title { get; set; }
            public required string Author { get; set; }
            public int Year { get; set; }
            public bool IsIssued { get; set; }
            public int Quantity { get; set; }
        }
    }
}
