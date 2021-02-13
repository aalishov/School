namespace RealEstates.Services.Models
{
    using System.Collections.Generic;
    public class PropertiesViewModel : PagingViewModel
    {
        public ICollection<PropertyViewModel> Properties { get; set; }
    }
}
