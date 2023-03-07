using System;
namespace Demo
{
    class Program
    {
        
        public record BookStore(int ID, string Title, string Author, double Price);
        
        public static void Main()
        {
            BookStore book = new(32,"Dune", "Frank Herbert", 23.5);
            Console.WriteLine($"Id={book.ID}");
            Console.WriteLine($"Title={book.Title}");
            Console.WriteLine($"Author={book.Author}");
            Console.WriteLine($"Price={book.Price}");

            BookStore book2 = new(45,"Harry Potter", "JK Rowling", 22.4);
            Console.WriteLine($"Id={book.ID}");
            Console.WriteLine($"Title={book.Title}");
            Console.WriteLine($"Author={book.Author}");
            Console.WriteLine($"Price={book.Price}");

            BookStore book3 = new(88,"Percy Jackson", "Rick Riorden",20.6);
            Console.WriteLine($"Id={book.ID}");
            Console.WriteLine($"Title={book.Title}");
            Console.WriteLine($"Author={book.Author}");
            Console.WriteLine($"Price={book.Price}");
        }
    }
}

