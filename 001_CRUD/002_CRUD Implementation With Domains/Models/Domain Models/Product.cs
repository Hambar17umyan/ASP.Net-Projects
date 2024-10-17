using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Interfaces;

namespace _002_CRUD_Implementation_With_Domains.Models.Domain_Models
{
    public class Product : IIdHaver
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, Category category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Id = IdHelper.Generate(_startingID, _endingID, _ids);
        }

        private int _startingID = 100000;
        private int _endingID = 1000000 - 1;
        private static HashSet<int> _ids = new HashSet<int>();
    }
}
