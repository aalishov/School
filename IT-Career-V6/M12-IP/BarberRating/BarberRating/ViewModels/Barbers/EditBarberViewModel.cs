using System.ComponentModel.DataAnnotations;

namespace BarberRating.ViewModels.Barbers
{
    public class EditBarberViewModel
    {
        public string Id { get; set; }


        [Required]
        [MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
    }
}
