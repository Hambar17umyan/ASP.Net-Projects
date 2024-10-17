namespace _002_CRUD_Implementation_With_Domains.Models.Request_Models.Customer_Models
{
    public class CustomerUpdatingRequest
    {
        public CustomerUpdatingRequest(string name, string email, string address)
        {
            Name = name;
            Email = email;
            Address = address;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
