namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    public class ProductUpdatingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public ProductUpdatingResponse(int id)
        {
            Id = id;
            IsSuccess = true;
        }

        public ProductUpdatingResponse()
        {
            IsSuccess = false;
        }

        public ProductUpdatingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}