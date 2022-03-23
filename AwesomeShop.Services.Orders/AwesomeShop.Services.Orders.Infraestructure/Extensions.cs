using AwesomeShop.Services.Orders.Core.Repositories;
using AwesomeShop.Services.Orders.Infraestructure.Persistence;
using AwesomeShop.Services.Orders.Infraestructure.Persistence.Repositorie;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AwesomeShop.Services.Orders.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddMongo(this IServiceCollection services)
        {
            services.AddSingleton(s =>
            {
                var configuration = s.GetService<IConfiguration>();
                var options = new MongoDbOptions();

                configuration.GetSection("Mongo").Bind(options);

                return options;
            });

            services.AddSingleton<MongoClient>(sp =>
            {
                var option = sp.GetService<MongoDbOptions>();

                return new MongoClient(option.ConnectionString);
            });

            services.AddTransient(sp =>
            {
                BsonDefaults.GuidRepresentation = GuidRepresentation.Standard;

                var option = sp.GetService<MongoDbOptions >();
                var mongoClient = sp.GetService<IMongoClient>();

                return mongoClient.GetDatabase(option.Database);
            });

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }
    }
}
