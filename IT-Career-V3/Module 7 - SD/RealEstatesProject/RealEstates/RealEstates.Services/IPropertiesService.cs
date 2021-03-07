using RealEstates.Services.Models;
using RealEstates.ViewModels;

namespace RealEstates.Services
{
    public interface IPropertiesService
    {
        void Create(PropertyInputViewModel input);

        PropertiesViewModel GetProperties(int pageNumber = 1);

        TopPropertiesViwModel GetTopExpensivePropeties();

        TopPropertiesViwModel GetTopChepestPropeties();
        public TopPropertiesViwModel GetLastAddedProperties();

        SearchPropertiesViewModel SearchByPrice(int minPrice, int maxPrice, int pageNumber);
        TopPropertiesViwModel TopNewestProperties();
        public void UpdateProperties(PropertyViewModel model);

        public bool DeleteProperty(int id);
    }
}