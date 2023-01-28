using System.ComponentModel.DataAnnotations;

namespace P01_Cars.ViewModels.Cars
{
    public class BaseCarViewModel
    {
        public int Id { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string Brand { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        public string Model { get; set; }
    }
}
