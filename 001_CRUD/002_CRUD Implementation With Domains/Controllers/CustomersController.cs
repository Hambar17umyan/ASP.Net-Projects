using _002_CRUD_Implementation_With_Domains.Data;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Category_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Customer_Models;
using _002_CRUD_Implementation_With_Domains.Models.Response_Models.Customer_Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    [Route("/api/[controller]")]
    public class CustomersController : ControllerBase
    {
        [HttpPost]
        public CustomerCreationResponse Create(CustomerCreationRequest request)
        {
            var repo = GetRepo();
            var customer = new Customer(
                request.Name,
                request.Email,
                request.Address);

            repo.Add(customer);
            return new CustomerCreationResponse() { Id = customer.Id };
        }

        [HttpGet]
        [Route("{id}")]
        public CustomerGettingResponse Retrieve(int id)
        {
            var repo = GetRepo();
            var customer = repo.Get(id);
            if (customer is null)
                return new CustomerGettingResponse();
            return new CustomerGettingResponse(customer);
        }

        [HttpGet]
        public AllCustomersGettingResponse GetAll()
        {
            var repo = GetRepo();
            return new AllCustomersGettingResponse(repo.GetAll().Select(x => new CustomerGettingResponse(x)));
        }

        [HttpPut]
        [Route("{id}")]
        public CustomerUpdatingResponse Update(int id, CustomerUpdatingRequest request)
        {
            var repo = GetRepo();
            var res = repo.Update(id, new Customer(request.Name, request.Email, request.Address) { Id = id });
            return new CustomerUpdatingResponse(res, res ? id : null);
        }

        [HttpDelete]
        [Route("{id}")]
        public CustomerDeletingResponse Delete(int id)
        {
            var repo = GetRepo();
            var res = repo.Delete(id);

            return new CustomerDeletingResponse(res, res ? id : null);
        }

        private static DataRepository<Customer> GetRepo() => DataRepository<Customer>.GetCustomerRepository();
    }
}
