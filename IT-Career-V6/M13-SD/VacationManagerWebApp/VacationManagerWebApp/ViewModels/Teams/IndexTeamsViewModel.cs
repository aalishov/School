namespace VacationManagerWebApp.ViewModels.Teams
{
    public class IndexTeamsViewModel:PagingViewModel
    {
        public IndexTeamsViewModel() : base(0) { }

        public IndexTeamsViewModel(int elementsCount, int itemsPerPage = 10, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public string FilterByName { get; set; }

        public string SortBy { get; set; }

        public bool IsAsc { get; set; } = true;

        public ICollection<IndexTeamViewModel> Teams { get; set; }= new List<IndexTeamViewModel>();
    }
}
