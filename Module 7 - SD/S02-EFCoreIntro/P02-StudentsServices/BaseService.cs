namespace P02_StudentsServices
{
    using P02_StudentsAppData;
    public abstract class BaseService
    {
        internal ApplicationDbContext dbContext;

        public BaseService()
        {
            dbContext = new ApplicationDbContext();
        }
    }
}
