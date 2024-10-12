namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Customer_Models
{
    public class CustomerUpdatingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public CustomerUpdatingResponse(int id)
        {
            Id = id;
            IsSuccess = true;
        }

        public CustomerUpdatingResponse()
        {
            IsSuccess = false;
        }

        public CustomerUpdatingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}