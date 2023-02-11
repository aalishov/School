namespace P02_Eventures.ViewModels.Orders
{
    public class CreateOrderViewModel
    {
        public string EventName { get; set; }
        public string EventPlace { get; set; }
        public string EventId { get; set; }
        public string AvailableTickets { get; set; }
        public  int TicketsCount { get; set; }
        public string CustomerId { get; set; }
    }
}
