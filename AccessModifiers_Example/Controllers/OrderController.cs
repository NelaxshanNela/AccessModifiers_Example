using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AccessModifiers_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var order = _orderService.GetOrder();
            return Ok(new
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                OrderStatus = order.OrderStatus,
                TotalAmount = order.GetTotalAmount()  // Accessing private TotalAmount via public method
            });
        }
    }
}
