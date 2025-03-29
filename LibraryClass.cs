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
            public Guid ID;
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public bool isIssued { get; set; }
            public int Quantity { get; set; }
        }
    }
}
