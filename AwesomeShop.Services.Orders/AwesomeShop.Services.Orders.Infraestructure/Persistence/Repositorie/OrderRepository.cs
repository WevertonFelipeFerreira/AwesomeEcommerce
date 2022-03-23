using AwesomeShop.Services.Orders.Core.Entities;
using AwesomeShop.Services.Orders.Core.Repositories;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infraestructure.Persistence.Repositorie
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _collection;
        public OrderRepository(IMongoDatabase mongoDataBase)
        {
            _collection = mongoDataBase.GetCollection<Order>("orders");
        }
        public async Task AddAsync(Order order)
        {
            await _collection.InsertOneAsync(order);
        }

        public async Task<Order> GetByIdAsync(Guid id)
        {
            return await _collection.Find(x => x.Id == id).SingleOrDefaultAsync();
        }

        public async Task UpdateAsync(Order order)
        {
            await _collection.ReplaceOneAsync(x => x.Id == order.Id, order);
        }
    }
}
