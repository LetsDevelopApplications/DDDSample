
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerce.Order.API.Domain;



namespace eCommerce.Order.API.Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DbContext _dbContext;

        public OrderRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Orders> GetByIdAsync(Guid orderId)
        {
            return await _dbContext.Set<Orders>().FindAsync(orderId);
        }

        public async Task SaveAsync(Orders order)
        {
            _dbContext.Set<Orders>().Add(order);
            await _dbContext.SaveChangesAsync();
        }
    }

}
