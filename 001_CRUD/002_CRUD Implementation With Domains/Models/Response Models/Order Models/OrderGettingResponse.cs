using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;

namespace _002_CRUD_Implementation_With_Domains.Models.Response_Models.Order_Models
{
    public class OrderGettingResponse
    {
        public OrderGettingResponse(DateOnly orderDate, int customerId, List<int> productIds)
        {
            IsSuccess = true;
            OrderDate = orderDate;
            CustomerId = customerId;
            ProductIds = productIds;
        }

        public OrderGettingResponse(Order order) : this(order.OrderDate, order.CustomerId, order.ProductIds) { }

        public OrderGettingResponse()
        {
            IsSuccess = false;
        }
        public bool IsSuccess {  get; set; }
        public DateOnly? OrderDate { get; set; }
        public int? CustomerId { get; set; }
        public List<int>? ProductIds { get; set; }

    }
}
