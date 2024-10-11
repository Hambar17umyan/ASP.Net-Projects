using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Interfaces;

namespace _002_CRUD_Implementation_With_Domains.Models.Domain_Models
{
    public class Customer : IIdHaver
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer(string name, string email, string address)
        {
            Id = IdHelper.Generate(_startingId, _endingId, _ids);
            Name = name;
            Email = email;
            Address = address;
        }

        private int _startingId = 1000000;
        private int _endingId = 10000000 - 1;
        private static HashSet<int> _ids = new HashSet<int>();
    }
}
