using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentSystem.Contracts;
using PaymentSystem.Enums;

namespace PaymentSystem
{
    public class CreditCardPayment : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"Successfully paid {amount} to merchant using {PaymentMethod.CreditCard}.";
        }
    }
}
