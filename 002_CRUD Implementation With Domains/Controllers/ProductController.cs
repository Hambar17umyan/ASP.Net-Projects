using _002_CRUD_Implementation_With_Domains.Data;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    [ApiController]
    [Route("/api/products")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public ProductCreationResponse Create([FromBody] ProductCreationRequest request)
        {
            var repo = DataRepository<Product>.GetProductRepository();
            var product = new Product(
                request.Name,
                request.Description,
                request.Price,
                new Category(request.Category.Name, request.Category.Description));

            repo.Add(product);
            return new ProductCreationResponse() { Id = product.Id };
        }

        [HttpGet]
        [Route("{id}")]
        public ProductGettingResponse Retrieve(int id)
        {
            var repo = DataRepository<Product>.GetProductRepository();
            var product = repo.Get(id);
            if (product is null)
                return new ProductGettingResponse();
            return new ProductGettingResponse(product);
        }

        [HttpGet]
        public AllProductsGettingResponse GetAll()
        {
            var repo = DataRepository<Product>.GetProductRepository();
            return new AllProductsGettingResponse(repo.GetAll().Select(x => new ProductResponse(x.Id, x.Name, x.Description, x.Price, x.Category)));
        }

        [HttpPut]
        [Route("{id}")]
        public ProductUpdatingResponse Update(int id, [FromBody] ProductUpdatingRequest request)
        {
            var repo = DataRepository<Product>.GetProductRepository();
            var res = repo.Update(id, new Product(request.Name, request.Description, request.Price, new Category(request.Category.Name, request.Category.Description)) { Id = id });
            return new ProductUpdatingResponse(res, res ? id : null);
        }

        [HttpDelete]
        [Route("{id}")]
        public ProductDeletingResponse Delete(int id)
        {
            var repo = DataRepository<Product>.GetProductRepository();
            var res = repo.Delete(id);

            return new ProductDeletingResponse(res, res ? id : null);
        }
    }
}
