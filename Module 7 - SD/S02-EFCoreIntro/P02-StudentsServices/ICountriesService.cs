using P02_StudentsAppData.Models;

namespace P02_StudentsServices
{
    public interface ICountriesService
    {
        string AddCountry(string name);
        string DeleteCountryByName(string name);
        string EditCoutryNameById(int id, string newName);
        string GetAllCountries();
        Country GetCountryById(int id);
        Country GetCountryByName(string name);
    }
}