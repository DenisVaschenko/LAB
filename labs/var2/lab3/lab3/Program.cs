namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new AllPages(new string[]  { "page1", "page2", "page3" } );
            book1 = new Title("title1", book1);
            book1 = new Date("2015", book1);
            book1 = new Author("name1", book1);
            Book book2 = new Author("name2", book1);
            book1.Display();
            book2.Display();
        }
    }
}
