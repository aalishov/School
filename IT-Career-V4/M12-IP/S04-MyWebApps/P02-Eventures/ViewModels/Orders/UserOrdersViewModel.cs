using P02_Eventures.ViewModels.Shared;
using System.Collections.Generic;

namespace P02_Eventures.ViewModels.Orders
{
    public class UserOrdersViewModel : PagingViewModel
    {
        public ICollection<UserOrderViewModel> Orders { get; set; }
    }
}
