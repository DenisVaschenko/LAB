using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Decorator : Book
    {
        Book _book;
        public Decorator(string title, string author, string date,string[] pages, Book book): base(title, author, date, pages)
        {
            _book = book;
        }
    }
}
