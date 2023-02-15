using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class Book
    {
        public Book(string title, string author, string date,string[] pages)
        {
            Title = title;
            Author = author;
            Date = date;
            Pages = pages;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public string[] Pages { get; set; }
        public void Display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Author);
            Console.WriteLine(Date);
            foreach(string x in Pages)
            {
                Console.WriteLine(x);
            }
        }
    }
}
