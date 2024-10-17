using _001_Product_Calls_CRUD_.Models.Response_Models;
using System.Collections;

namespace _001_Product_Calls_CRUD_.Controllers
{
    public class AllProductsResponseModel : IEnumerable<ProductResponseModel>
    {
        public List<ProductResponseModel> Products { get; set; }

        public AllProductsResponseModel()
        {
            Products = new List<ProductResponseModel>();
        }

        public void Add(ProductResponseModel model)
        {
            Products.Add(model);
        }

        public IEnumerator<ProductResponseModel> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}