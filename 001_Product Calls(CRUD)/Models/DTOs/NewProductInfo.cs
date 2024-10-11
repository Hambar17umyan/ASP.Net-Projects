using _001_Product_Calls_CRUD_.Models.Domain_Models;

namespace _001_Product_Calls_CRUD_.Models.DTOs
{
    public class NewProductInfo
    {
        public NewProductInfo(string name, string description, Category category)
        {
            Name = name;
            Description = description;
            Category = category;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}