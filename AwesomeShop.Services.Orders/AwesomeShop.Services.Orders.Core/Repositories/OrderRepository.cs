using AwesomeShop.Services.Orders.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Core.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public Task AddAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
