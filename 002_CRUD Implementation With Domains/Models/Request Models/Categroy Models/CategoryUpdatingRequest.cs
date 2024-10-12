namespace _002_CRUD_Implementation_With_Domains.Models.Request_Models.Categroy_Models
{
    public class CategoryUpdatingRequest
    {
        public CategoryUpdatingRequest(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
