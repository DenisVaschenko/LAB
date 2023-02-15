using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Title : Decorator
    {
        public Title(string title, Book book) : base(title, book.Author, book.Date, book.Pages, book)
        {
            Title = title;
        }
    }
}
