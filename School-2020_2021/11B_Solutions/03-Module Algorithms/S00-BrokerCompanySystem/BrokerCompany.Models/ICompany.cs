namespace BrokerCompany.Models
{
    public interface ICompany
    {
        string Name { get; set; }

        void AddBroker(IBroker broker);

        void AddBuilding(IBuilding building);

        IBroker GetBrokerByName(string name);

        IBuilding GetBuildingByName(string name);

        string ToString();
    }
}