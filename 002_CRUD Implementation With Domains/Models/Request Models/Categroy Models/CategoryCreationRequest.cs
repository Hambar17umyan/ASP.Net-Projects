namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class CategoryCreationRequest
    {
        public CategoryCreationRequest(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}