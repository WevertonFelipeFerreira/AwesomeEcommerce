using AwesomeShop.Services.Orders.Core.ValueObjects;
using System;

namespace AwesomeShop.Services.Orders.Core.Events
{
    public class OrderCreated : IDomainEvent
    {
        private Guid Id;
        private decimal TotalPrice;
        private PaymentInfo PaymentInfo;
        private string FullName;
        private string Email;

        public OrderCreated(Guid id, decimal totalPrice, PaymentInfo paymentInfo, string fullName, string email)
        {
            Id = id;
            TotalPrice = totalPrice;
            PaymentInfo = paymentInfo;
            FullName = fullName;
            Email = email;
        }
    }
}
