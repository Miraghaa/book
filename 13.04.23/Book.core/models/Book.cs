
namespace BookApp.core.models
{
    public class Book
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public void Getfullinfo()
        {
            Console.WriteLine(Name + "" + Price);
        }
    }
}
