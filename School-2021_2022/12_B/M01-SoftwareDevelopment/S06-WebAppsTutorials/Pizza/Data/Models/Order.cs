using Pizza.Data.Models.Enums;

namespace Pizza.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Size Size { get; set; }
        public string Address { get; set; }
        public int AppPizzaId { get; set; }
        public AppPizza Pizza { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}
