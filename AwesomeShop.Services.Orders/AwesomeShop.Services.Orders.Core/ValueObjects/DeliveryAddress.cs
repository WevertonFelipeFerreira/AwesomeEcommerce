using System;

namespace AwesomeShop.Services.Orders.Core.ValueObjects
{
    public class DeliveryAddress
    {
        public DeliveryAddress(string street, string city, string number, string state, string zipCode)
        {
            Street = street;
            City = city;
            Number = number;
            State = state;
            ZipCode = zipCode;
        }

        public string Street { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public override bool Equals(object obj)
        {
            return obj is DeliveryAddress address &&
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
