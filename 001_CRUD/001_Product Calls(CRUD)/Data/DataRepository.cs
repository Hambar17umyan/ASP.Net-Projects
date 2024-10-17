using _001_Product_Calls_CRUD_.Models.Domain_Models;
using _001_Product_Calls_CRUD_.Models.DTOs;

namespace _001_Product_Calls_CRUD_.Data
{
    public class DataRepository
    {
        private List<Product> _products;
        private static DataRepository _productResponseRepository;

        static DataRepository()
        {
            _productResponseRepository = new DataRepository();
        }
        private DataRepository()
        {
            _products = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product? GetProduct(int id)
        {
            return (_products.Find(x => x.Id == id));
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void UpdateProduct(int id, NewProductInfo product)
        {
            for(var i = 0; i < _products.Count; i++)
            {
                if(_products[i].Id == id)
                    _products[i] = Helper.CreateProduct(product);
            }
        }

        public bool DeleteProduct(int id)
        {
            var prod = _products.FirstOrDefault(x => x.Id == id);
            if(prod != null)
            {
                _products.Remove(prod);
                return true;
            }
            return false;
        }

        public void DeleteAllProducts()
        {
            _products = new List<Product>();
        }


        public static DataRepository GetProductResponseRepository()
        {
            return _productResponseRepository;
        }

    }
}
