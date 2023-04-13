
using _13._04._23.Services;
using BookApp.core.models;
BookServices bookServices = new BookServices();


Console.WriteLine("0.close app");
Console.WriteLine("1.Show book");
Console.WriteLine("2.Create book");

string informationbook=Console.ReadLine();

while(informationbook != null)
{
    switch(informationbook)
    {
        case "1":
            bookServices.Showbooks();
            break;
            case "2":
            bookServices.Createbook();
            break;
        default:
            Console.WriteLine("duzgun secim edin");
            break;
    }
    Console.WriteLine("0.close app");
    Console.WriteLine("1.Show book");
    Console.WriteLine("2.Price book");

     informationbook = Console.ReadLine();
}
 