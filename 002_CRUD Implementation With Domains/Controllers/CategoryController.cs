using _002_CRUD_Implementation_With_Domains.Data;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    [ApiController]
    [Route("categories")]
    public class CategoryController : ControllerBase
    {
        [HttpPost]
        public CategoryCreationResponse Create1([FromBody] CategoryCreationRequest request)
        {
            var repo = DataRepository<Category>.GetCategoryRepository();
            var category = new Category(request.Name, request.Description);
            repo.Add(category);
            return new CategoryCreationResponse() { Id = category.Id };
        }

        [HttpGet]
        [Route("{id}")]
        public CategoryGettingResponse Retrieve1(int id)
        {
            var repo = DataRepository<Category>.GetCategoryRepository();
            var category = repo.Get(id);
            if (category is null)
                return new CategoryGettingResponse();
            return new CategoryGettingResponse(category);
        }

        [HttpGet]
        public AllCategoriesGettingResponse GetAll1()
        {
            var repo = DataRepository<Category>.GetCategoryRepository();
            return new AllCategoriesGettingResponse(repo.GetAll().Select(x=>new CategoryGettingResponse(x.Id, x.Name, x.Description)));
        }

        [HttpPut]
        [Route("{id}")]
        public CategoryUpdatingResponse Update1(int id, [FromBody] ProductUpdatingRequest request)
        {
            var repo = DataRepository<Category>.GetCategoryRepository();
            var res = repo.Update(id, new Category(request.Name, request.Description) { Id = id });
            return new CategoryUpdatingResponse(res, res ? id : null);


        }

        [HttpDelete]
        [Route("{id}")]
        public CategoryDeletingResponse Delete1(int id)
        {
            var repo = DataRepository<Category>.GetCategoryRepository();
            var res = repo.Delete(id);

            return new CategoryDeletingResponse(res, res ? id : null);
        }
    }
}
