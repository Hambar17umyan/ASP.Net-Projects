using _001_Product_Calls_CRUD_.Models.DTOs;

namespace _001_Product_Calls_CRUD_.Models.Request_Models
{
    public record class ProductRequestModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }

        public ProductRequestModel(string name, string description, Category category)
        {
            Name = name;
            Description = description;
            Category = category;
        }
    }
}
