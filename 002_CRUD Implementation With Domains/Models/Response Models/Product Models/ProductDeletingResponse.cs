namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class ProductDeletingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public ProductDeletingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}