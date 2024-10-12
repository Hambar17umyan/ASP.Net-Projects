using _002_CRUD_Implementation_With_Domains.Data;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Category_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Categroy_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Product_Models;
using _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    [Route("/api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        public CategoryCreationResponse Create(CategoryCreationRequest request)
        {
            var repo = GetRepo();
            var category = new Category(request.Name, request.Description);
            repo.Add(category);
            return new CategoryCreationResponse() { Id = category.Id };
        }

        [HttpGet]
        [Route("{id}")]
        public CategoryGettingResponse Retrieve(int id)
        {
            var repo = GetRepo(); 
            var category = repo.Get(id);
            if (category is null)
                return new CategoryGettingResponse();
            return new CategoryGettingResponse(category);
        }

        [HttpGet]
        public AllCategoriesGettingResponse GetAll()
        {
            var repo = GetRepo();
            return new AllCategoriesGettingResponse(repo.GetAll().Select(x => new CategoryGettingResponse(x.Id, x.Name, x.Description)));
        }

        [HttpPut]
        [Route("{id}")]
        public CategoryUpdatingResponse Update(int id, CategoryUpdatingRequest request)
        {
            var repo = GetRepo();
            var res = repo.Update(id, new Category(request.Name, request.Description) { Id = id });
            return new CategoryUpdatingResponse(res, res ? id : null);
        }

        [HttpDelete]
        [Route("{id}")]
        public CategoryDeletingResponse Delete(int id)
        {
            var repo = GetRepo();
            var res = repo.Delete(id);

            return new CategoryDeletingResponse(res, res ? id : null);
        }

        private static DataRepository<Category> GetRepo() => DataRepository<Category>.GetCategoryRepository();
    }
}
