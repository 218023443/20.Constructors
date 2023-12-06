using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _20.Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Porter","JK",400);
            Console.WriteLine(book1.title);
            Console.ReadLine(); 
        }
    }
}
