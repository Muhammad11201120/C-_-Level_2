using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Example_ConsoleApp
{
    public class Book
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    internal class Program
    {
        static void Main( string[] args )
        {
            Book[] books = new Book[]
            {
                new Book { Name = "C#", Price = 100 },
                new Book { Name = "C++", Price = 200 },
                new Book { Name = "JavaScript", Price = 300 },
                new Book { Name = "python", Price = 400 },
                new Book { Name = "html", Price = 500 }
            };

            var myBooks = books.Where( book => book.Price > 200 );

            foreach ( var b in myBooks )
            {
                Console.WriteLine( b.Name );
            }
            Console.ReadKey();
        }
    }
}
