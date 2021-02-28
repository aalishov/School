using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.ViewModels
{
    public class SearchPropertiesViewModel : PagingViewModel
    {
        public ICollection<PropertyViewModel> Properties { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }
    }
}
