namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class CategoryResponse
    {
        public CategoryResponse(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }


    }
}