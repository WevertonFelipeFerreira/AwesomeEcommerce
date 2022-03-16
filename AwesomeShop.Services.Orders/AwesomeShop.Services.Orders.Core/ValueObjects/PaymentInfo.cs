using System;

namespace AwesomeShop.Services.Orders.Core.ValueObjects
{
    public class PaymentInfo
    {
        public PaymentInfo(string fullName, string cardNumber, string expiration, string cvv)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Expiration = expiration;
            Cvv = cvv;
        }

        public string FullName { get; private set; }
        public string CardNumber { get; private set; }
        public string Expiration { get; private set; }
        public string Cvv { get; private set; }

        public override bool Equals(object obj)
        {
            return obj is PaymentInfo info &&
                   FullName == info.FullName &&
                   CardNumber == info.CardNumber &&
                   Expiration == info.Expiration &&
                   Cvv == info.Cvv;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FullName, CardNumber, Expiration, Cvv);
        }
    }
}
