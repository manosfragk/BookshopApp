using OrderService.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderService.Repositories
{
    public class OrderRepository
    {
        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order { Id = 1, CustomerId = 1, BookId = 1, Quantity = 1, TotalPrice = 10 },
                new Order { Id = 2, CustomerId = 2, BookId = 2, Quantity = 2, TotalPrice = 20 },
                new Order { Id = 3, CustomerId = 3, BookId = 3, Quantity = 3, TotalPrice = 30 }
            };
        }

        public Order GetOrderById(int id)
        {
            return GetOrders().FirstOrDefault(o => o.Id == id);
        }
    }
}
