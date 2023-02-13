namespace P02_Eventures.ViewModels.Events
{
    using P02_Eventures.ViewModels.Shared;
    using System.Collections.Generic;
    public class IndexEventsViewModel : PagingViewModel
    {
        public ICollection<IndexEventViewModel> Events { get; set; }

        public string PlaceFilter { get; set; }
    }

}
