using System.ComponentModel.DataAnnotations;

namespace P02_Eventures.ViewModels.Orders
{
    public class UserOrderViewModel
    {
        public string UserId { get; set; }

        public string OrderId { get; set; }

        public string EventId { get; set; }

        [Display(Name = "Tickets")]
        public string TicketsCount { get; set; }


        [Display(Name ="Event name")]
        public string EventName { get; set; }

        [Display(Name = "Event place")]
        public string EventPlace { get; set; }

        [Display(Name = "Total price")]
        public string OrderPrice { get; set; }
    }
}
