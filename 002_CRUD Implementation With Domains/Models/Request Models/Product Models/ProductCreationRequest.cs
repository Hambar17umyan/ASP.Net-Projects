using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class ProductCreationRequest
    {
        public ProductCreationRequest(string name, string description, decimal price, CategoryCreationRequest category)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryCreationRequest Category { get; set; }


    }
}