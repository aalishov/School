using System.ComponentModel.DataAnnotations;

namespace BarberRating.ViewModels.Barbers
{
    public class IndexBarberViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }


        [Display(Name = "Picture")]
        public  string Image { get; set; }
    }
}
