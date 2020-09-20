namespace StorageMaster.Products
{
    public class SolidStateDrive : Product
    {
        private const double ssdWeigth = 0.2;
        public SolidStateDrive(double price) : base(price, ssdWeigth)
        {
        }
    }
}
