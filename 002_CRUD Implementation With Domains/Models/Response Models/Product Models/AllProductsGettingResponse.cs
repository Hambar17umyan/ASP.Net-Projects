using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using System.Collections;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Product_Models
{
    public class AllProductsGettingResponse : IEnumerable<ProductGettingResponse>
    {
        private List<ProductGettingResponse> _products;

        public AllProductsGettingResponse(IEnumerable<ProductGettingResponse> products)
        {
            _products = products.ToList();
        }
        public IEnumerator<ProductGettingResponse> GetEnumerator()
        {
            return _products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}