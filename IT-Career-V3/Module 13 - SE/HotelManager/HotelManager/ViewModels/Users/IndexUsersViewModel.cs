using HotelManager.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelManager.ViewModels.Users
{
    public class IndexUsersViewModel : PagingViewModel
    {
        public ICollection<IndexUserViewModel> Users { get; set; }
        public UserFilterViewModel Filter { get; set; } = new UserFilterViewModel();
    }
}
