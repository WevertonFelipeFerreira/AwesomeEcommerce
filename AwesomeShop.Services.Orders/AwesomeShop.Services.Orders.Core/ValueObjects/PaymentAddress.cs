using System;

namespace AwesomeShop.Services.Orders.Core.ValueObjects
{
    public class PaymentAddress
    {
        public PaymentAddress(string street, string city, string number, string state, string zipCode)
        {
            Street = street;
            City = city;
            Number = number;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; private set; }
        public string City { get; private set; }
        public string Number { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is PaymentAddress address &&
                   Street == address.Street &&
                   City == address.City &&
                   Number == address.Number &&
                   State == address.State &&
                   ZipCode == address.ZipCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Street, City, Number, State, ZipCode);
        }
    }
}
