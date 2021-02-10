namespace BrokerCompany.Models
{
    public interface IBuilding
    {
        string City { get; }

        bool IsAvailable { get; set; }

        string Name { get; }

        double RentAmount { get;  }

        int Stars { get; }

        string ToString();
    }
}