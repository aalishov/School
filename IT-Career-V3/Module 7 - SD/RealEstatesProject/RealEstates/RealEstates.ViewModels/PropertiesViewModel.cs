using System;
using System.Collections.Generic;
using System.Text;

namespace RealEstates.ViewModels
{
    public class PropertiesViewModel : PagingViewModel
    {
        public ICollection<PropertyViewModel> Properties { get; set; }
    }
}
