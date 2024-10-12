namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Order_Models
{
    public class OrderDeletingResponse
    {
        public bool IsSuccess { get; set; }
        public int? Id { get; set; }

        public OrderDeletingResponse(bool isSuccess, int? id)
        {
            IsSuccess = isSuccess;
            Id = id;
        }
    }
}
