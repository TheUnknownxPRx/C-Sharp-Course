using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // instance of class or bbject
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            //Book1 Title
            Console.WriteLine(book1.title);
            //Book1 Author
            Console.WriteLine(book1.author);
            //Book1 Pages
            Console.WriteLine(book1.pages);

            // instance of class or bbject
            Book book2 = new Book();
            book2.title = "LOTR";
            book2.author = "Tolkien";
            book2.pages = 700;

            //Book2 Title
            Console.WriteLine(book2.title);
            //Book2 Author
            Console.WriteLine(book2.author);
            //Book2 Pages
            Console.WriteLine(book2.pages);

            Console.ReadLine();
        }

    }
}
