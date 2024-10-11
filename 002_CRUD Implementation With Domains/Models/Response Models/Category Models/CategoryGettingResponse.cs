using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class CategoryGettingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public CategoryGettingResponse()
        {
            IsSuccess = false;
        }

        public CategoryGettingResponse(Category category) : this(category.Id, category.Name, category.Description)
        {

        }

        public CategoryGettingResponse(int? id, string? name, string? description)
        {
            Id = id;
            Name = name;
            Description = description;
            IsSuccess = true;
        }
    }
}