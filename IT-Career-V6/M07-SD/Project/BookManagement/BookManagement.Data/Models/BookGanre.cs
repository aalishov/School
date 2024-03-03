namespace BookManagement.Data.Models
{
    using Microsoft.EntityFrameworkCore;

    [PrimaryKey(nameof(BookId), nameof(GanreId))]
    public class BookGanre
    {
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        public int GanreId { get; set; }

        public virtual Ganre Ganre { get; set; }
    }
}
