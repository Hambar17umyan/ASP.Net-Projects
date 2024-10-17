using _002_CRUD_Implementation_With_Domains.Controllers;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using System.Collections;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Customer_Models
{
    public class AllCustomersGettingResponse : IEnumerable<CustomerGettingResponse>
    {
        private IEnumerable<CustomerGettingResponse> _categories;

        public AllCustomersGettingResponse(IEnumerable<CustomerGettingResponse> categories)
        {
            _categories = categories;
        }
        public IEnumerator<CustomerGettingResponse> GetEnumerator()
        {
            return _categories.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}