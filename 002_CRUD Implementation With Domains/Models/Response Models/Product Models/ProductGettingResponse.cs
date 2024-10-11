using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class ProductGettingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public Category? Category { get; set; }

        public ProductGettingResponse()
        {
            IsSuccess = false;
        }
        public ProductGettingResponse(int id, string name, string description, decimal price, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsSuccess = true;
        }

        public ProductGettingResponse(Product product) : this(product.Id, product.Name, product.Description, product.Price, product.Category)
        {

        }
    }
}