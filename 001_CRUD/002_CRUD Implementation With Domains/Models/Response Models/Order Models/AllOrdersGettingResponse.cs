using _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models;
using System.Collections;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Order_Models
{
    public class AllOrdersGettingResponse : IEnumerable<OrderGettingResponse>
    {
        private IEnumerable<OrderGettingResponse> _orders;

        public AllOrdersGettingResponse(IEnumerable<OrderGettingResponse> orders)
        {
            _orders = orders;
        }
        public IEnumerator<OrderGettingResponse> GetEnumerator()
        {
            return _orders.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
