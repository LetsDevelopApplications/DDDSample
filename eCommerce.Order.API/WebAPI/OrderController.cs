using eCommerce.Order.API.Appliation.Commands;
using eCommerce.Order.API.Appliation.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Order.API.WebAPI
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateOrder(CreateOrderCommand command)
        {
            var orderId = await _mediator.Send(command);
            return Ok(orderId);
        }

        [HttpGet("{orderId}")]
        public async Task<ActionResult<OrderDto>> GetOrder(Guid orderId)
        {
            var query = new GetOrderQuery { OrderId = orderId };
            var orderDto = await _mediator.Send(query);

            if (orderDto == null)
            {
                return NotFound();
            }

            return Ok(orderDto);
        }
    }

}
