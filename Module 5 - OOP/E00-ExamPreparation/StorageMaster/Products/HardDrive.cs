namespace StorageMaster.Products
{
    public class HardDrive : Product
    {
        private const double hardDriveWeight = 1;
        public HardDrive(double price) : base(price, hardDriveWeight)
        {
        }
    }
}
