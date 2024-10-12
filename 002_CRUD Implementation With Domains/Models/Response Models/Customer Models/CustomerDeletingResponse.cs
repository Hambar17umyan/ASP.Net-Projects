namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Customer_Models
{
    public class CustomerDeletingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public CustomerDeletingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}