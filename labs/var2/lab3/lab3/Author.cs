using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Author : Decorator
    {
        public Author(string author, Book book): base(book.Title, author, book.Date, book.Pages, book)
        {
            Author = author;
        }
    }
}
