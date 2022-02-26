using Scooters.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scooters.Services
{
    public class MainService
    {
        private AppDbContext context = new AppDbContext();
        public MainService()
        {
            this.UsersService = new UsersService(context);
        }
        public UsersService UsersService { get; private set; }
    }
}
