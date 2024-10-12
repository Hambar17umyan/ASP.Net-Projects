namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Category_Models
{
    public class CategoryDeletingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public CategoryDeletingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}