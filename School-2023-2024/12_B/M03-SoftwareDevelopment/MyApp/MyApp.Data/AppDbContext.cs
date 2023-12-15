using MyApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Data
{
    public class AppDbContext
    {
        public List<Car> Cars
        {
            get
            {
                return new List<Car>()
                {
                    new Car{Brand="Audi",Model="A4",Color="Black", Engine=new Engine{Type="V6"} },
                    new Car{Brand="Audi",Model="A8 RS",Color="Red"},
                    new Car{Brand="BMW",Model="X3",Color="Black"},
                    new Car{Brand="BMW",Model="M3",Color="Orange"}
                };
            }
        }
    }
}
