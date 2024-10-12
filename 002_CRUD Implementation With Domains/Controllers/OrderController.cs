using _002_CRUD_Implementation_With_Domains.Data;
using _002_CRUD_Implementation_With_Domains.Models.Domain_Models;
using _002_CRUD_Implementation_With_Domains.Models.Request_Models.Order_Models;
using _002_CRUD_Implementation_With_Domains.Models.Response_Models.Order_Models;
using Microsoft.AspNetCore.Mvc;

namespace _002_CRUD_Implementation_With_Domains.Controllers
{
    [ApiController]
    [Route("/api/orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public OrderCreationResponse Create([FromBody] OrderCreationRequest request)
        {
            var repo = GetRepo();
            var order = new Order(
                request.OrderDate,
                request.CustomerId,
                request.ProductIds
                );

            repo.Add(order);
            return new OrderCreationResponse() { Id = order.Id };
        }

        [HttpGet]
        [Route("{id}")]
        public OrderGettingResponse Retrieve(int id)
        {
            var repo = GetRepo();
            var order = repo.Get(id);
            if (order is null)
                return new OrderGettingResponse();
            return new OrderGettingResponse(order);
        }

        [HttpGet]
        public AllOrdersGettingResponse GetAll()
        {
            var repo = GetRepo();
            return new AllOrdersGettingResponse(repo.GetAll().Select(x => new OrderGettingResponse(x)));
        }

        [HttpPut]
        [Route("{id}")]
        public OrderUpdatingResponse Update(int id, [FromBody] OrderUpdatingRequest request)
        {
            var repo = GetRepo();
            var res = repo.Update(id, new Order(request.OrderDate, request.CustomerId, request.ProductIds) { Id = id });
            return new OrderUpdatingResponse(res, res ? id : null);
        }

        [HttpDelete]
        [Route("{id}")]
        public OrderDeletingResponse Delete(int id)
        {
            var repo = GetRepo();
            var res = repo.Delete(id);
            return new OrderDeletingResponse(res, res ? id : null);
        }

        private static DataRepository<Order> GetRepo() => DataRepository<Order>.GetOrderRepository();
    }
}
