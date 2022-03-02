using Microsoft.AspNetCore.Mvc.Rendering;
using Pizza.Data.Models.Enums;
using System.Collections.Generic;

namespace Pizza.ViewModels.Order
{
    public class OrderViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int PizzaId { get; set; }
        public Size Size { get; set; }
        public PaymentType PaymentType { get; set; }
        public SelectList AppPizzas { get; set; }
    }
}
