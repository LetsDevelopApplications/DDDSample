using eCommerce.Order.API.Appliation.Commands;
using eCommerce.Order.API.Domain;
using eCommerce.Order.API.Infrastructure.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace eCommerce.Order.API.Appliation.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Guid>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Guid> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var orderId = Guid.NewGuid();
            var order = new Orders(orderId, request.OrderDate);

            foreach (var itemDto in request.OrderItems)
            {
                var orderItem = new OrderItem(Guid.NewGuid(), itemDto.ProductName, itemDto.UnitPrice, itemDto.Quantity);
                order.AddOrderItem(orderItem);
            }

            await _orderRepository.SaveAsync(order);

            return orderId;
        }
    }

}
