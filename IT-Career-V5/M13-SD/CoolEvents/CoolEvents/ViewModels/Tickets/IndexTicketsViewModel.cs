namespace CoolEvents.ViewModels.Tickets
{
    public class IndexTicketsViewModel : PagingViewModel
    {
        public IndexTicketsViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }
        public IndexTicketsViewModel() : base(0)
        {

        }

        public string LoggedUserId { get; set; }

        public ICollection<IndexTicketViewModel> Tickets { get; set; } = new List<IndexTicketViewModel>();
    }
}
