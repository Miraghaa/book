

using BookApp.core.Models.BaseModels;

namespace BookApp.core.Models
{
    public class Book:BaseModel

    {
        public string Name {get; set;}
        public double Price { get; set; }
    }
}
