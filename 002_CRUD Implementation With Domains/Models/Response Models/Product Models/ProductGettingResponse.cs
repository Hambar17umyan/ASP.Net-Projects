using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Product_Models
{
    public class ProductGettingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public CategoryGettingResponse? Category { get; set; }

        public ProductGettingResponse()
        {
            IsSuccess = false;
        }
        public ProductGettingResponse(int id, string name, string description, decimal price, CategoryGettingResponse category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            IsSuccess = true;
        }

        public ProductGettingResponse(Product product) : this(product.Id, product.Name, product.Description, product.Price, new CategoryGettingResponse(product.Category.Id, product.Category.Name, product.Category.Description))
        {

        }
    }
}