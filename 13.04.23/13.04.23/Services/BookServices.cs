using BookApp.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._04._23.Services
{
    internal class BookServices
    {
      private  Book[] books = new Book[0];

       public void Showbooks()
        {
            if (books.Length == 0)
            {
                Console.WriteLine("deqiq kitab var");
            }
            foreach (Book book in books)
            {
                book.Getfullinfo();
            }
        }
       public void Createbook()
        {
            Book Newbookp = new Book();
            Console.WriteLine("add Name");
            Newbookp.Name = Console.ReadLine();
            Console.WriteLine("add Price");
            Newbookp.Price = Console.ReadLine();

            Array.Resize(ref books, books.Length + 1);

            books[books.Length - 1] = Newbookp;
        }
    }
}
