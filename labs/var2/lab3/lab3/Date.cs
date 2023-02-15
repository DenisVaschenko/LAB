using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Date : Decorator
    {
        public Date(string date, Book book) : base(book.Title, book.Author, date, book.Pages, book)
        {
            Date = date;
        }
    }
}