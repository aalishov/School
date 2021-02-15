namespace BrokerCompany.Models
{
    public interface IBroker
    {
        int Age { get; }
        double Bonus { get; }
        string City { get; }
        string Name { get; }

        double ReceiveBonus(IBuilding building);
        string ToString();
    }
}