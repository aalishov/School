using P02_StudentsAppData.Models;

namespace P02_StudentsServices
{
    public interface IAddressesService
    {
        string AddAddress(string addressName, string townName, string countryName);
        Address GetAddressByName(string addressName, string townName, string countryName);
    }
}