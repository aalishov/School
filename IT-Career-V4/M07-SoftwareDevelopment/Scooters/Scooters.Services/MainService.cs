namespace Scooters.Services
{
    using Scooters.Data;
    public class MainService
    {
        private AppDbContext context = new AppDbContext();
        public MainService()
        {
            this.Users = new UsersService(context);
            this.Scooters = new ScootersService(context);
            this.Rents = new RentsService(context, this.Users, this.Scooters);
        }
        public UsersService Users { get; private set; }
        public ScootersService Scooters { get; private set; }
        public RentsService Rents { get; private set; }
    }
}
