using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Order.API.Domain;

namespace eCommerce.Order.API.Infrastructure.Repository
{
    public interface IOrderRepository
    {
        Task<Orders> GetByIdAsync(Guid orderId);
        Task SaveAsync(Orders order);
    }

}
