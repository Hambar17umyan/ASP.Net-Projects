using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Interfaces;

namespace _002_CRUD_Implementation_With_Domains.Models.Domain_Models
{
    public class Category : IIdHaver
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
            Id = IdHelper.Generate(_startingID, _endingID, _ids);
        }

        private int _startingID = 100;
        private int _endingID = 1000 - 1;
        private static HashSet<int> _ids = new HashSet<int>();
    }
}