using _002_CRUD_Implementation_With_Domains.Interfaces;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Data
{
    public class DataRepository<T> where T : IIdHaver
    {
        private List<T> _data;
        private DataRepository()
        {
            _data = new List<T>();
        }

        public int Add(T entity)
        {
            _data.Add(entity);
            return entity.Id;
        }

        public T? Get(int id)
        {
            return _data.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return _data;
        }

        public bool Update(int id, T newEntity)
        {
            var obj = Get(id);
            if(obj is null)
            {
                return false;
            }
            _data[_data.IndexOf(obj)] = newEntity;
            return true;
        }

        public bool Delete(int id)
        {
            var obj = Get(id);
            if (obj is null)
            {
                return false;
            }
            _data.Remove(obj);
            return true;
        }

        private static DataRepository<Product> _productRepository = new DataRepository<Product>();
        private static DataRepository<Category> _categoryRepository = new DataRepository<Category>();
        private static DataRepository<Order> _orderRepository = new DataRepository<Order>();
        private static DataRepository<Customer> _customerRepository = new DataRepository<Customer>();

        public static DataRepository<Product> GetProductRepository() => _productRepository;
        public static DataRepository<Category> GetCategoryRepository() => _categoryRepository;
        public static DataRepository<Order> GetOrderRepository() => _orderRepository;
        public static DataRepository<Customer> GetCustomerRepository() => _customerRepository;
    }

}
