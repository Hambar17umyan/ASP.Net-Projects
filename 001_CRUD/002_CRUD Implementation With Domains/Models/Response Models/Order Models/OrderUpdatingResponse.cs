namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Order_Models
{
    public class OrderUpdatingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public OrderUpdatingResponse(int id)
        {
            Id = id;
            IsSuccess = true;
        }

        public OrderUpdatingResponse()
        {
            IsSuccess = false;
        }

        public OrderUpdatingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}
