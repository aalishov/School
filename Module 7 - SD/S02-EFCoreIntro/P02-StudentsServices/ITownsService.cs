using P02_StudentsAppData.Models;

namespace P02_StudentsServices
{
    public interface ITownsService
    {
        string AddTown(string townName, string countryName);
        string GetAllTowns();
        Town GetTownByName(string townName, string countryName);
    }
}