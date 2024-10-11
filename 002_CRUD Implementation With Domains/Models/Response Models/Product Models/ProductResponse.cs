using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class ProductResponse
    {
        public ProductResponse(int id, string name, string description, decimal price, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = new CategoryResponse(category.Id, category.Name, category.Description);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public CategoryResponse Category { get; set; }
    }
}