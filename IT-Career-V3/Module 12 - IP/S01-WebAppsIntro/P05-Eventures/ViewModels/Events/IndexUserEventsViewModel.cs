using P05_Eventures.ViewModels.Shared;
using System.Collections.Generic;

namespace P05_Eventures.ViewModels.Events
{
    public class IndexUserEventsViewModel:PagingViewModel
    {
        public IndexUserEventsViewModel():base(5)
        {

        }
        public ICollection<IndexUserEventViewModel> Events { get; set; }
    }
}
