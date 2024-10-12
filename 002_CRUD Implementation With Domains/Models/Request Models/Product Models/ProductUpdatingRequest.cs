using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Category_Models;

namespace _002_CRUD_Implementation_With_Domains.Models.Request_Models.Product_Models
{
    public class ProductUpdatingRequest
    {
        public ProductUpdatingRequest(string name, string description, decimal price, CategoryCreationRequest category)
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