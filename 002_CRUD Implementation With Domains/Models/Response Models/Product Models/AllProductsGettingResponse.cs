using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using System.Collections;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class AllProductsGettingResponse : IEnumerable<ProductResponse>
    {
        private List<ProductResponse> _products;

        public AllProductsGettingResponse(IEnumerable<ProductResponse> products)
        {
            _products = products.ToList();
        }
        public IEnumerator<ProductResponse> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}