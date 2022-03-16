using AwesomeShop.Services.Orders.Core.Entities.Common;
using System;

namespace AwesomeShop.Services.Orders.Core.Entities
{
    public class Customer : IEntitieBase
    {
        public Customer(Guid id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string FullName { get; set; }
        public string Email { get; set; }

    }
}
