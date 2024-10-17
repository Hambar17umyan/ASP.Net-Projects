using _002_CRUD_Implementation_With_Domains.Controllers;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using System.Collections;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models
{
    public class AllCategoriesGettingResponse : IEnumerable<CategoryGettingResponse>
    {
        private IEnumerable<CategoryGettingResponse> _categories;

        public AllCategoriesGettingResponse(IEnumerable<CategoryGettingResponse> categories)
        {
            _categories = categories;
        }
        public IEnumerator<CategoryGettingResponse> GetEnumerator()
        {
            return _categories.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}