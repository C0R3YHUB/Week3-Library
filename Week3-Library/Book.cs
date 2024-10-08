using System;
using System.Collections.Generic;
using System.Linq;
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
            //Create a new instance of book class
            Book book = new Book();

            book.Title = "C# For Beginners";
            book.Author = "CoreyHughes";
            book.ISBN = "12345678";
            book.NoOfPages = 200;

            //Creating second object
            Book book2 = new Book();

            book2.Title = "C# Methods & Classes";
            book2.Author = "MorganHughes";
            book2.ISBN = "87654321";
            book2.NoOfPages = 346;

            //Output book information to console
            book.DisplayInfo();
            book2.DisplayInfo();
            
            //Output the book information


         /* Console.WriteLine($"Book Title: {book.Title}");
            Console.WriteLine($"Book Author: {book.Author}");
            Console.WriteLine($"Book ISBN: {book.ISBN}");

            //Output the second book information


            Console.WriteLine("  ");
            Console.WriteLine($"Book Title: {book2.Title}");
            Console.WriteLine($"Book Author: {book2.Author}");
            Console.WriteLine($"Book ISBN: {book2.ISBN}");
            */

        }
    }
}
