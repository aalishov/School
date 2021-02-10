using P02_StudentsServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using P02_StudentsAppData;

namespace P02_StudentsConsoleApp
{
    public class Program
    {
        public static readonly IServiceProvider serviceProvider = new ContainerBuilder().Build();
        static void Main()
        {
            var dbContext = serviceProvider.GetService<ApplicationDbContext>();
            var addressesService = serviceProvider.GetService<IAddressesService>();
            var countriesService = serviceProvider.GetService<ICountriesService>();
            var studentService = serviceProvider.GetService<IStudentsService>();
            var townsService = serviceProvider.GetService<ITownsService>();

            Engine engine = new Engine(addressesService, dbContext, countriesService, townsService, studentService);

            engine.Run();
        }
    }
}
