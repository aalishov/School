namespace P01_Cars.ViewModels.Cars
{
    using System.Collections.Generic;

    public class IndexCarsViewModel
    {
        public ICollection<IndexCarViewModel> Cars { get; set; }

        public int CarsCount { get => Cars.Count; }
    }
}
