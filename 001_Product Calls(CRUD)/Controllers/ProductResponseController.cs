using _001_Product_Calls_CRUD_.Data;
using _001_Product_Calls_CRUD_.Models.DTOs;
using _001_Product_Calls_CRUD_.Models.Request_Models;
using _001_Product_Calls_CRUD_.Models.Response_Models;
using Microsoft.AspNetCore.Mvc;

namespace _001_Product_Calls_CRUD_.Controllers
{
    [ApiController]
    [Route("/api/Products")]
    public class ProductResponseController : ControllerBase
    {
        [HttpPost]
        [Route("Add")]
        public int AddProduct([FromQuery] string name, [FromQuery] string description, [FromQuery] Category category)
        {
            var request = new ProductRequestModel(name, description, category);
            var repo = DataRepository.GetProductResponseRepository();
            var product = Helper.CreateProduct(request);
            repo.AddProduct(product);
            return product.Id;

        }

        [HttpGet]
        [Route("Get/Single")]
        public ProductResponseModel GetProduct([FromQuery] int id)
        {
            var repo = DataRepository.GetProductResponseRepository();
            var product = repo.GetProduct(id);
            if (product == null)
                return new ProductResponseModel();
            return Helper.CreateProductResponse(product);
        }

        [HttpGet]
        [Route("Get/All")]
        public AllProductsResponseModel GetAllProducts()
        {
            var repo = DataRepository.GetProductResponseRepository();
            var products = repo.GetProducts();

            var res = new AllProductsResponseModel()
            {
                Products = products.Select(Helper.CreateProductResponse).ToList()
            };

            return res;
        }

        [HttpDelete]
        [Route("Delete/Single")]
        public DeletingProductResponse DeleteProduct(int id)
        {
            var repo = DataRepository.GetProductResponseRepository();
            var res = repo.DeleteProduct(id);
            return new DeletingProductResponse() { IsSuccess = res };
        }

        [HttpDelete]
        [Route("Delete/All")]
        public void DeleteAllProducts()
        {
            var repo = DataRepository.GetProductResponseRepository();
            repo.DeleteAllProducts();
        }

        [HttpPut]
        [Route("Update")]
        public void Update([FromQuery]int id, [FromQuery]string Name, [FromQuery]string description, [FromQuery]Category category)
        {
            var repo = DataRepository.GetProductResponseRepository();
            var updated = new NewProductInfo(Name, description, category);
            repo.UpdateProduct(id, updated);
        }
    }
}
