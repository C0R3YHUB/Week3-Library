using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Library
{
    class Book
    {
        string Title;
        string Author;
        string ISBN;
        int NoOfPages;

        //Creating Constructor for book object
        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            Title = bookTitle;
            Author = bookAuthor;    
            ISBN = bookISBN;
            NoOfPages = bookNoOfPages;

        }


        void DisplayInfo()
        {
            Console.WriteLine($"Book Information");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Number of Pages: {NoOfPages}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //Create new instance of the book class
            Book book = new Book("C# For Beginners", "Corey Hughes", "12345678", 200);
            Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);


            //Output book info to console
            book.DisplayInfo();
            book2.DisplayInfo();


        }
    }
}
