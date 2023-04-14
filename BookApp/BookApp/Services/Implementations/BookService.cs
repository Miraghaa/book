using BookApp.Services.Interfaces;
using BookApp.core.Models;


namespace BookApp.Services.Implementations
{
    internal class BookService : IBookService
    {
        private Book[] Books = { };
        public void ShowBooks()
        {
            if (Books.Length == 0)
            { Console.WriteLine("No avialable books "); }
            foreach (Book book in Books)
            { Console.WriteLine($"Name {book.Name} Price {book.Price} Euros ({book.CreatedDate}) "); }
        }

        public void CreateBook()
        {
            Book NewBook = new Book();
            Console.WriteLine("Add name");
            string Name = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Enter the name again idiot ");
                Name = Console.ReadLine();
            }
            NewBook.Name = Name;
            Console.WriteLine("Add Price");
            string StrPrice = Console.ReadLine();
            while (NewBook.Price == 0)
            {
                try {NewBook.Price = double.Parse(StrPrice);}
                catch
                {
                    Console.WriteLine("You can only enter number stupid");
                    StrPrice = Console.ReadLine();
                }
            }
            NewBook.CreatedDate = DateTime.UtcNow.AddHours(4);

            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = NewBook;
        }
    }
}