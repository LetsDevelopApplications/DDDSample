using eCommerce.Order.API.Appliation.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Order.API.Appliation.Query
{
    public class GetOrderQuery : IRequest<OrderDto>
    {
        public Guid OrderId { get; set; }
    }

    public class OrderDto
    {
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }

}
