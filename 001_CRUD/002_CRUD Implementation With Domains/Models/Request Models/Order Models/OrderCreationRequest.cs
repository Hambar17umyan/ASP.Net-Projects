namespace _002_CRUD_Implementation_With_Domains.Models.Request_Models.Order_Models
{
    public class OrderCreationRequest
    {
        public OrderCreationRequest() { }
        public OrderCreationRequest(DateOnly orderDate, int customerId, List<int> productIds)
        {
            OrderDate = orderDate;
            CustomerId = customerId;
            ProductIds = productIds;
        }

        public DateOnly OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }
    }
}