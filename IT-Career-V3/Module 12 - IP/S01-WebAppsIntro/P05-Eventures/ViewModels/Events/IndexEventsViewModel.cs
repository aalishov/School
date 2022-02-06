using P05_Eventures.ViewModels.Shared;
using System.Collections;
using System.Collections.Generic;

namespace P05_Eventures.ViewModels.Events
{
    public class IndexEventsViewModel : PagingViewModel
    {
        public IndexEventsViewModel() : base(3)
        {

        }
        public ICollection<IndexEventViewModel> Events { get; set; }
    }
}
