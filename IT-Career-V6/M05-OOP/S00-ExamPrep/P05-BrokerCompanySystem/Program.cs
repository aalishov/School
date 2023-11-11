using System.Linq;
using System.Text;

namespace P05_BrokerCompanySystem
{
    public class Program
    {
        private static CompanyController controller = new CompanyController();

        public static void Main()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split("*");
                string cmd = input[0];
                List<string> args = input.Skip(1).ToList();

                switch (cmd)
                {
                    case nameof(controller.CreateCompany):
                        Console.WriteLine(controller.CreateCompany(args));
                        break;
                    case nameof(controller.RegisterBuilding):
                        Console.WriteLine(controller.RegisterBuilding(args));
                        break;
                    case nameof(controller.RegisterBroker):
                        Console.WriteLine(controller.RegisterBroker(args));
                        break;
                    case nameof(controller.RentBuilding):
                        Console.WriteLine(controller.RentBuilding(args));
                        break;
                    case nameof(controller.CompanyInfo):
                        Console.WriteLine(controller.CompanyInfo(args));
                        break;
                    case nameof(controller.Shutdown):
                        Console.WriteLine(controller.Shutdown());
                        Environment.Exit(0);
                        break;
                }

            }
        }


    }
}