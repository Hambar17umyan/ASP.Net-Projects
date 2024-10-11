using _002_CRUD_Implementation_With_Domains.Helpers;
using _002_CRUD_Implementation_With_Domains.Interfaces;

namespace _002_CRUD_Implementation_With_Domains.Models.Domain_Models
{
    public class Order : IIdHaver
    {
        public int Id { get; set; }
        public DateOnly OrderDate { get; set; }
        public int CustomerId { get; set; }
        public List<int> ProductIds { get; set; }

        public Order(DateOnly orderDate, int customerId, List<int> productIds)
        {
            OrderDate = orderDate;
            CustomerId = customerId;
            ProductIds = productIds;
            Id = IdHelper.Generate(_startingID,_endingID,_ids);
        }


        private int _startingID = 100000;
        private int _endingID = 1000000 - 1;
        private static HashSet<int> _ids = new HashSet<int>();
    }
}
