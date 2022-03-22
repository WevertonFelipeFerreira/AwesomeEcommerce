using AwesomeShop.Services.Orders.Core.Entities;
using AwesomeShop.Services.Orders.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infraestructure.Persistence.Repositorie
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
