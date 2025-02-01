using BarberRating.ViewModels.Users;

namespace BarberRating.ViewModels.Barbers
{
    public class IndexBarbersViewModel : PagingViewModel
    {
        public IndexBarbersViewModel() : base(10)
        {

        }
        public IndexBarbersViewModel(int elementsCount, int itemsPerPage = 5, string action = "Index") : base(elementsCount, itemsPerPage, action)
        {
        }

        public string FilterByName { get; set; }

        public bool IsAsc { get; set; } = true;

        public ICollection<IndexBarberViewModel> Barbers { get; set; } = new List<IndexBarberViewModel>();
    }
}
