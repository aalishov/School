namespace BrokerCompany.ConsoleApp
{
    using BrokerCompany.Services;
    public class Program
    {
        public static void Main()
        {
            CompanyController companyController = new CompanyController();
            Engine engine = new Engine(companyController);
            engine.Run();
        }
    }
}

