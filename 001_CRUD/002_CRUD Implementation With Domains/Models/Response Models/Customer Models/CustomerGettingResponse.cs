using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Customer_Models
{
    public class CustomerGettingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public CustomerGettingResponse()
        {
            IsSuccess = false;
        }

        public CustomerGettingResponse(Customer customer) : this(customer.Id, customer.Name, customer.Email, customer.Address)
        {

        }

        public CustomerGettingResponse(int? id, string? name, string? email, string? address)
        {
            IsSuccess = true;
            Id = id;
            Name = name;
            Email = email;
            Address = address;
        }
    }
}