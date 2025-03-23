namespace CoolEvents.ViewModels.Events
{
    public class IndexEventsViewModel : PagingViewModel
    {

        public IndexEventsViewModel() : base(0)
        {

        }
        public IndexEventsViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public string FilterByName { get; set; }

        public ICollection<BaseEventViewModel> Events { get; set; } = new HashSet<BaseEventViewModel>();
    }
}
