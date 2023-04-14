using BookApp.Services.Implementations;

Console.WriteLine("0 close app");
Console.WriteLine("1 Show books");
Console.WriteLine("2 Create book");

BookService bookService = new BookService();
string Request=Console.ReadLine();

while (Request != "0")
{
    switch (Request)
    {
        case "1":
            bookService.ShowBooks(); 
            break;
        case "2":
            bookService.CreateBook();
            break;
        default:
            Console.WriteLine("Add valid option");
            break;
    }

    Console.WriteLine("0 close app");
    Console.WriteLine("1 Show books");
    Console.WriteLine("2 Create book");

    Request = Console.ReadLine();

}