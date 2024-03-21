using System.Text;
using PaymentSystem.Contracts;
using PaymentSystem.Enums;

namespace PaymentSystem
{
    public class Program
    {
        public static void Main()
        {

            Console.WriteLine("Choose your payment method");
            Menu();
            Console.Write("Enter the method:");
            int cmd = int.Parse(Console.ReadLine());
            Console.Write("Enter the amount of money:");
            decimal amount = decimal.Parse(Console.ReadLine());

            string result = CreatePayment((PaymentMethod)cmd).Pay(amount);
            Console.WriteLine(result);

        }
        public static void Menu()
        {

            foreach (var item in Enum.GetValues(typeof(PaymentMethod)))
            {
                Console.WriteLine($"{(int)item} {item}");
            }
        }

        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                case PaymentMethod.Bitcoin:
                    return new BitcoinPayment();
                case PaymentMethod.ApplePay:
                    return new ApplePayPayment();
                default:
                    throw new NotSupportedException($"{paymentMethod} is not currently supported as a payment method.");
            }
        }
    }
}
