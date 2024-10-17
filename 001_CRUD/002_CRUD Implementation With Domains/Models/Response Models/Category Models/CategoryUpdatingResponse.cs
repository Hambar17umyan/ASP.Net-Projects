namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models
{
    public class CategoryUpdatingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public CategoryUpdatingResponse(int id)
        {
            Id = id;
            IsSuccess = true;
        }

        public CategoryUpdatingResponse()
        {
            IsSuccess = false;
        }

        public CategoryUpdatingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}