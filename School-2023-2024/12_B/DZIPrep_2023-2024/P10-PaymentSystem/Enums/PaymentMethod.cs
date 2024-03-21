using System.ComponentModel.DataAnnotations;

namespace PaymentSystem.Enums
{
    public enum PaymentMethod
    {
        [Display(Name = "Google pay")]
        GooglePay = 0,
        [Display(Name = "Pay pal")]
        PayPal = 1,
        [Display(Name = "Credit card")]
        CreditCard = 2,
        Bitcoin = 3,
        ApplePay = 4
    }
}
