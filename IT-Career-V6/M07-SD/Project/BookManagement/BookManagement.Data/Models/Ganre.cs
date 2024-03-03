namespace BookManagement.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Ganre
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<BookGanre> Books { get; set; } = new HashSet<BookGanre>();
    }
}
