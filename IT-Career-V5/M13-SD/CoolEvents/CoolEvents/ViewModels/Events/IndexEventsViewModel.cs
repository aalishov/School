namespace CoolEvents.ViewModels.Events
{
    public class IndexEventsViewModel : PagingViewModel
    {
        public IndexEventsViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public IndexEventsViewModel() : base(0)
        {

        }

        public string FilterByName { get; set; }

        public ICollection<IndexEventViewModel> Events { get; set; } = new List<IndexEventViewModel>();

    }
}
