using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.Repositories;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _orderRepository;

        public OrderController(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        public IEnumerable<Order> Get() => _orderRepository.GetOrders();

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrderById(int id)
        {
            var order = _orderRepository.GetOrderById(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }
    }
}
