using Microsoft.Extensions.DependencyInjection;
using P02_StudentsAppData;
using P02_StudentsServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace P02_StudentsServices
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddTransient<IAddressesService, AddressesService>();
            container.AddTransient<ICountriesService, CountriesService>();
            container.AddTransient<IStudentsService , StudentsService>();
            container.AddTransient<ITownsService, TownsService>();
            container.AddDbContext<ApplicationDbContext>();

            return container.BuildServiceProvider();
        }
    }
}
