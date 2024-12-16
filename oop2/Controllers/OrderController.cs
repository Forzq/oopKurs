
using Microsoft.AspNetCore.Mvc;
using oop2.Contracts;
using oop2.Models;
using oop2.Repository;

namespace oop2.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public IActionResult GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders(trackChanges: false);
            return Ok(orders);
        }
    }
}

