using _001_Product_Calls_CRUD_.Models.DTOs;

namespace _001_Product_Calls_CRUD_.Models.Response_Models
{
    public class ProductResponseModel
    {
        public ProductResponseModel(int id, string name, string description, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            IsSuccess = true;
        }

        public ProductResponseModel()
        {
            IsSuccess = false;
        }

        public bool IsSuccess { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public Category Category { get; set; }
    }
}
