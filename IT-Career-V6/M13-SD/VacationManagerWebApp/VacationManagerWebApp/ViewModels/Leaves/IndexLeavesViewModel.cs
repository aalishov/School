using VacationManagerWebApp.ViewModels.Teams;

namespace VacationManagerWebApp.ViewModels.Leaves
{
    public class IndexLeavesViewModel : PagingViewModel
    {
        public IndexLeavesViewModel() : base(0) { }

        public IndexLeavesViewModel(int elementsCount, int itemsPerPage = 10, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }
        public string LoggedUserId { get; set; }

        public bool HideApproved { get; set; } = true;

        public string FilterByName { get; set; }

        public string SortBy { get; set; }

        public bool IsAsc { get; set; } = true;

        public ICollection<IndexLeaveViewModel> Leaves { get; set; } = new List<IndexLeaveViewModel>();
    }
}
