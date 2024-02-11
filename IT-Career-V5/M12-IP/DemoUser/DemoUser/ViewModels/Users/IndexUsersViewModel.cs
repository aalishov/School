using DemoUser.ViewModels.Shared;

namespace DemoUser.ViewModels.Users
{
    public class IndexUsersViewModel : PagingViewModel
    {
        public IndexUsersViewModel(int usersCount = 0, int page = 1, string sort = "Asc", int itemsPerPage = 5) : base(usersCount, itemsPerPage)
        {
            Sort = sort;
        }

        public ICollection<IndexUserViewModel> Users { get; set; }

        public string Sort { get; set; }
    }
}
